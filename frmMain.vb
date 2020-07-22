
Imports LinxLib
Imports LinxLib.DataLib
Imports LinxLib.CommonLib


Public Class frmMain

    Private TextBoxOrder As New Dictionary(Of TextBox, TextBox)()

    Public sExeVersion As String = "1.3"

    Dim bTimerFlag As Boolean

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        TextBoxOrder.Add(txtSerial, txtPart)

        txtSerial.Tag = 1
        btnLoad.Tag = 2

        AddHandler txtSerial.KeyDown, AddressOf BarcodeInputKeyDown
        AddHandler txtSerial.Leave, AddressOf btnLoad_Click

        lblMessage.Text = ""
        lblEXEVersion.Text = sExeVersion & ":" & sLinxLibVersion

        txtSerial.BackColor = Color.Yellow

    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txtSerial.Select()
    End Sub


    Private Sub BarcodeInputKeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter AndAlso ActiveControl.[GetType]() = GetType(TextBox) Then
            e.Handled = True
            e.SuppressKeyPress = True
            btnLoad.Focus()
        End If
    End Sub

    Private Sub BarcodeInputLeave(sender As Object, e As EventArgs)
        If sender.[GetType]() = GetType(TextBox) Then
            Dim textBox As TextBox = DirectCast(sender, TextBox)
            If textBox.Tag.[GetType]() = GetType(Integer) Then
                BarcodeScanned(textBox.Text, CInt(textBox.Tag))
            End If
        End If
    End Sub


    Private Sub BarcodeScanned(barcode As String, order As Integer)

        lblMessage.Text = Convert.ToString(order.ToString() + ": ") & barcode


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        End

    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click

        Dim xBindingsource As BindingSource = Nothing
        xBindingsource = PrinterExists(txtSerial.Text)

        If xBindingsource Is Nothing Then
            SerialNotFound()
            Exit Sub
        End If


        Dim rBindingsource As BindingSource = Nothing

        Try

            If Trim(txtSerial.Text) <> "" Then

                If xBindingsource.Count = 1 Then

                    txtScannedSerial.Text = txtSerial.Text
                    txtSerial.Text = ""

                    txtPart.Text = CType(xBindingsource.List(0), DataRowView).Item(0).ToString
                    txtStart_time.Text = CType(xBindingsource.List(0), DataRowView).Item(1).ToString

                    txtUse_time.Text = CType(xBindingsource.List(0), DataRowView).Item(2).ToString
                    txtPack_time.Text = CType(xBindingsource.List(0), DataRowView).Item(3).ToString
                    txtScrapped.Text = CType(xBindingsource.List(0), DataRowView).Item(4).ToString
                    txtOrder_time.Text = CType(xBindingsource.List(0), DataRowView).Item(5).ToString

                    lblMessage.Text = "Printhead already scanned!"
                    txtSerial.BackColor = Color.Orange
                    Application.DoEvents()
                    WaitHere(50)

                    txtSerial.BackColor = Color.Yellow
                    lblMessage.Text = ""
                    Application.DoEvents()

                Else

                    If Trim(txtSerial.Text) <> "" Then

                        lblMessage.Text = "Searching for printhead ..."
                        txtSerial.BackColor = Color.Orange
                        Application.DoEvents()
                        WaitHere(20)

                        rBindingsource = Find_AS_part_no(txtSerial.Text)

                        If rBindingsource.Count = 1 Then
                            ' Colour the text box
                            lblMessage.Text = "Printhead accepted"
                            txtSerial.BackColor = Color.GreenYellow
                            Application.DoEvents()
                            WaitHere(30)

                            txtSerial.BackColor = Color.White
                            lblMessage.Text = ""
                            Application.DoEvents()

                            txtPart.Text = CType(rBindingsource.List(0), DataRowView).Item(2).ToString

                            If Not InsertPrintheadRecentStarts(Trim(txtSerial.Text), Trim(txtPart.Text)) Then
                                lblMessage.Text = "Not able to insert printhead!"
                                txtSerial.BackColor = Color.Red
                                Application.DoEvents()
                                WaitHere(30)
                            Else
                                txtStart_time.Text = Format(Now, "yyyy-MM-dd HH:mm:ss")
                                txtUse_time.Text = Format(Now, "yyyy-MM-dd HH:mm:ss")
                                txtPack_time.Text = Format(Now, "yyyy-MM-dd HH:mm:ss")
                                txtScrapped.Text = ""
                                txtOrder_time.Text = Format(Now, "yyyy-MM-dd HH:mm:ss")
                            End If

                            txtScannedSerial.Text = txtSerial.Text
                            txtSerial.Text = ""

                            txtSerial.BackColor = Color.Yellow

                        Else
                            SerialNotFound()

                        End If

                    End If


                End If


            End If

            txtSerial.Select()

        Catch
            txtSerial.Select()
            Application.DoEvents()
            txtScannedSerial.Text = txtSerial.Text
            txtSerial.Text = ""

            txtSerial.BackColor = Color.Yellow

            MsgBox("Unable to accept scanned input : " & txtSerial.Text & vbCrLf & "Error: " & Err.Description)
        End Try


    End Sub

    Private Sub SerialNotFound()

        lblMessage.Text = "Serial not found!"
        txtSerial.BackColor = Color.Red

        Application.DoEvents()

        WaitHere(30)

        lblMessage.Text = ""
        txtSerial.BackColor = Color.Yellow
        txtSerial.Text = ""

    End Sub


    Private Function PrinterExists(ByRef sSerial As String) As BindingSource

        PrinterExists = Nothing

        Dim tDatafetch(0) As DataIn
        Dim xDataAccess As New DataAccess

        Try
            xDataAccess.Initialise()
            xDataAccess.SetScheme = "dbo"
            xDataAccess.SetTableName = "PrintheadRecentStarts"
            If xDataAccess.GetConnectionErr() <> "" Then
                MsgBox(xDataAccess.GetConnectionErr())
                Exit Function
            End If

            xDataAccess.SetDBWhere = "serial='" & Trim(sSerial) & "'"

            ReDim tDatafetch(12)
            tDatafetch(0).ColName = "product"
            tDatafetch(1).ColName = "start_time"
            tDatafetch(2).ColName = "use_time"
            tDatafetch(3).ColName = "pack_time"
            tDatafetch(4).ColName = "scrapped"
            tDatafetch(5).ColName = "order_time"
            tDatafetch(6).ColName = "step1"
            tDatafetch(7).ColName = "step2"
            tDatafetch(8).ColName = "step3"
            tDatafetch(9).ColName = "potting_success"
            tDatafetch(10).ColName = "step4"
            tDatafetch(11).ColName = "vacuum_scan"
            tDatafetch(12).ColName = "vacuum_success"

            Dim oBindingSource As BindingSource
            oBindingSource = xDataAccess.GetRecordsDataByID(tDatafetch)
            PrinterExists = oBindingSource

        Catch ex As Exception

            MsgBox("PrinterExists: " & sSerial & vbCrLf & "Error: " & Err.Description)

        End Try


    End Function

    Private Function Find_AS_part_no(ByRef sSerial As String) As BindingSource

        Find_AS_part_no = Nothing

        Dim tDatafetch(0) As DataIn
        Dim xDataAccess As New DataAccess

        Try
            xDataAccess.Initialise()
            xDataAccess.SetScheme = "dbo"
            xDataAccess.SetTableName = "vw_oracle_ph_details"
            xDataAccess.SetDBWhere = "serial='" & Trim(sSerial) & "'"

            ReDim tDatafetch(2)
            tDatafetch(0).ColName = "part_no"
            tDatafetch(1).ColName = "description"
            tDatafetch(2).ColName = "spare_printhead"

            Dim oBindingSource As BindingSource
            oBindingSource = xDataAccess.GetRecordsDataByID(tDatafetch)
            Find_AS_part_no = oBindingSource

        Catch ex As Exception

            MsgBox("PrinterExists: " & sSerial & vbCrLf & "Error: " & Err.Description)

        End Try


    End Function


    Public Function InsertPrintheadRecentStarts(ByRef sSerial As String, ByRef sPart As String) As Boolean

        Dim tDataInsert(0) As DataIn

        InsertPrintheadRecentStarts = False

        Try

            Dim xDataAccess As New DataAccess
            xDataAccess.Initialise()
            xDataAccess.SetScheme = "dbo"
            xDataAccess.SetTableName = "PrintheadRecentStarts"

            ReDim Preserve tDataInsert(5)
            tDataInsert(0) = xDataAccess.SQLVar("product", sPart)
            tDataInsert(1) = xDataAccess.SQLVar("serial", sSerial)
            tDataInsert(2) = xDataAccess.SQLVar("start_time", Format(Now, "yyyy-MM-dd HH:mm:ss"))
            tDataInsert(3) = xDataAccess.SQLVar("order_time", Format(Now, "yyyy-MM-dd HH:mm:ss"))
            tDataInsert(4) = xDataAccess.SQLVar("use_time", Format(Now, "yyyy-MM-dd HH:mm:ss"))
            tDataInsert(5) = xDataAccess.SQLVar("unique_id", "NA")

            InsertPrintheadRecentStarts = xDataAccess.InsertNewRecordArray(tDataInsert)

            xDataAccess.Dispose()

            InsertPrintheadRecentStarts = True

        Catch
            MsgBox("Unable to insert data into PrintheadRecentStarts")


        End Try


    End Function


    Private Sub WaitHere(ByRef iTenthSeconds As Integer)

        Timer1.Interval = iTenthSeconds * 100
        Timer1.Enabled = True

        Do While Timer1.Enabled
            Application.DoEvents()
        Loop

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Timer1.Enabled = False

    End Sub


End Class
