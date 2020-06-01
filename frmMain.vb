
Imports LinxLib
Imports LinxLib.DataLib
Imports LinxLib.CommonLib


Public Class frmMain

    Private TextBoxOrder As New Dictionary(Of TextBox, TextBox)()

    Public sExeVersion As String = "1.0"

    Dim bTimerFlag As Boolean

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        TextBoxOrder.Add(txtSerial, txtPart)
        TextBoxOrder.Add(txtPart, txtSerial)

        txtSerial.Tag = 1
        txtPart.Tag = 2
        btnLoad.Tag = 3

        AddHandler txtSerial.KeyDown, AddressOf BarcodeInputKeyDown
        AddHandler txtPart.KeyDown, AddressOf BarcodeInputKeyDown

        '        AddHandler txtSerial.Leave, AddressOf BarcodeInputLeave
        AddHandler txtPart.Leave, AddressOf btnLoad_Click

        lblMessage.Text = ""
        lblEXEVersion.Text = "Exe:" & sExeVersion
        lblLinxLibVersion.Text = "Lib:" & sLinxLibVersion

    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txtSerial.Select()
    End Sub


    Private Sub BarcodeInputKeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter AndAlso ActiveControl.[GetType]() = GetType(TextBox) Then
            Dim nextTextBox As TextBox
            If TextBoxOrder.TryGetValue(DirectCast(ActiveControl, TextBox), nextTextBox) Then
                e.Handled = True
                e.SuppressKeyPress = True
                nextTextBox.Focus()
            End If
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

        Dim sMessage As String = "100"


        Try

            If Trim(txtSerial.Text) <> "" Then

                sMessage = "101"

                If xBindingsource.Count = 1 Then

                    sMessage = "102"

                    txtPart.Text = CType(xBindingsource.List(0), DataRowView).Item(0).ToString
                    sMessage = "103"
                    txtStart_time.Text = CType(xBindingsource.List(0), DataRowView).Item(1).ToString
                    sMessage = "104"

                    txtUse_time.Text = CType(xBindingsource.List(0), DataRowView).Item(2).ToString
                    sMessage = "105"
                    txtPack_time.Text = CType(xBindingsource.List(0), DataRowView).Item(3).ToString
                    sMessage = "106"
                    txtScrapped.Text = CType(xBindingsource.List(0), DataRowView).Item(4).ToString
                    sMessage = "107"

                    txtOrder_time.Text = CType(xBindingsource.List(0), DataRowView).Item(5).ToString

                    sMessage = "108"
                    lblMessage.Text = "Already scanned"
                    txtSerial.BackColor = Color.Orange
                    sMessage = "109"
                    Application.DoEvents()
                    sMessage = "110"
                    WaitHere(20)

                    sMessage = "111"
                    txtSerial.BackColor = Color.White
                    lblMessage.Text = ""
                    Application.DoEvents()

                Else

                    If Trim(txtSerial.Text) <> "" And Trim(txtPart.Text) <> "" Then

                        sMessage = "200"

                        If InsertPrintheadRecentStarts(txtSerial.Text, txtPart.Text) Then
                            ' Colour the text box

                            sMessage = "201"

                            lblMessage.Text = "Serial number accepted"
                            txtSerial.BackColor = Color.GreenYellow

                            sMessage = "202"
                            Application.DoEvents()

                            WaitHere(20)

                            txtSerial.BackColor = Color.White
                            lblMessage.Text = ""
                            sMessage = "203"
                            Application.DoEvents()

                            xBindingsource = PrinterExists(txtSerial.Text)
                            sMessage = "204"
                            txtPart.Text = CType(xBindingsource.List(0), DataRowView).Item(0).ToString
                            sMessage = "205"
                            txtUse_time.Text = CType(xBindingsource.List(0), DataRowView).Item(2).ToString
                            sMessage = "206"
                            txtPack_time.Text = CType(xBindingsource.List(0), DataRowView).Item(3).ToString
                            sMessage = "207"
                            txtScrapped.Text = CType(xBindingsource.List(0), DataRowView).Item(4).ToString
                            sMessage = "208"
                            txtOrder_time.Text = CType(xBindingsource.List(0), DataRowView).Item(5).ToString
                            sMessage = "209"


                        End If

                    End If


                End If


            End If

        Catch

            MsgBox("Unable to accept scanned input : " & txtSerial.Text & vbCrLf & "Error: " & Err.Description & sMessage)

        End Try

        txtSerial.Select()
        Application.DoEvents()


    End Sub


    Private Function PrinterExists(ByRef sSerial As String) As BindingSource

        PrinterExists = Nothing

        Dim tDatafetch(0) As DataIn
        Dim xDataAccess As New DataAccess

        Dim sMessage As String = "300"


        Try

            sMessage = "301"
            xDataAccess.Initialise()
            sMessage = "302"
            xDataAccess.SetScheme = "dbo"
            sMessage = "303"
            xDataAccess.SetTableName = "PrintheadRecentStarts"
            sMessage = "304"
            xDataAccess.SetDBWhere = "serial='" & Trim(sSerial) & "'"
            sMessage = "305"

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

            sMessage = "306"

            Dim oBindingSource As BindingSource
            sMessage = "307"
            oBindingSource = xDataAccess.GetRecordsDataByID(tDatafetch)
            sMessage = "308"
            PrinterExists = oBindingSource

        Catch ex As Exception

            MsgBox("PrinterExists: " & sSerial & vbCrLf & "Error: " & Err.Description & sMessage)

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

            ReDim Preserve tDataInsert(4)
            tDataInsert(0) = xDataAccess.SQLVar("product", Trim(sPart))
            tDataInsert(1) = xDataAccess.SQLVar("serial", Trim(sSerial))
            tDataInsert(2) = xDataAccess.SQLVar("use_time", Format(Now, "yyyy-MM-dd HH:mm:ss"))
            tDataInsert(3) = xDataAccess.SQLVar("order_time", Format(Now, "yyyy-MM-dd HH:mm:ss"))
            tDataInsert(4) = xDataAccess.SQLVar("unique_id", "NA")

            InsertPrintheadRecentStarts = xDataAccess.InsertNewRecordArray(tDataInsert)

            xDataAccess.Dispose()

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
