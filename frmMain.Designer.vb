<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSerial = New System.Windows.Forms.TextBox()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtStart_time = New System.Windows.Forms.TextBox()
        Me.txtUse_time = New System.Windows.Forms.TextBox()
        Me.txtPack_time = New System.Windows.Forms.TextBox()
        Me.txtScrapped = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtOrder_time = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.lblEXEVersion = New System.Windows.Forms.Label()
        Me.lblLinxLibVersion = New System.Windows.Forms.Label()
        Me.txtPart = New System.Windows.Forms.TextBox()
        Me.txtScannedSerial = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(291, 343)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(70, 33)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Scanned Serial No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "AS Part Number"
        '
        'txtSerial
        '
        Me.txtSerial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerial.Location = New System.Drawing.Point(168, 16)
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.Size = New System.Drawing.Size(193, 26)
        Me.txtSerial.TabIndex = 1
        Me.txtSerial.Tag = ""
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(215, 343)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(70, 33)
        Me.btnLoad.TabIndex = 2
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Start Time"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Use Time"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Scrapped"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Pack Time"
        '
        'txtStart_time
        '
        Me.txtStart_time.BackColor = System.Drawing.Color.Gainsboro
        Me.txtStart_time.Enabled = False
        Me.txtStart_time.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStart_time.Location = New System.Drawing.Point(168, 135)
        Me.txtStart_time.Name = "txtStart_time"
        Me.txtStart_time.Size = New System.Drawing.Size(193, 26)
        Me.txtStart_time.TabIndex = 5
        '
        'txtUse_time
        '
        Me.txtUse_time.BackColor = System.Drawing.Color.Gainsboro
        Me.txtUse_time.Enabled = False
        Me.txtUse_time.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUse_time.Location = New System.Drawing.Point(168, 168)
        Me.txtUse_time.Name = "txtUse_time"
        Me.txtUse_time.Size = New System.Drawing.Size(193, 26)
        Me.txtUse_time.TabIndex = 6
        '
        'txtPack_time
        '
        Me.txtPack_time.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPack_time.Enabled = False
        Me.txtPack_time.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPack_time.Location = New System.Drawing.Point(168, 203)
        Me.txtPack_time.Name = "txtPack_time"
        Me.txtPack_time.Size = New System.Drawing.Size(193, 26)
        Me.txtPack_time.TabIndex = 7
        '
        'txtScrapped
        '
        Me.txtScrapped.BackColor = System.Drawing.Color.Gainsboro
        Me.txtScrapped.Enabled = False
        Me.txtScrapped.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScrapped.Location = New System.Drawing.Point(168, 236)
        Me.txtScrapped.Name = "txtScrapped"
        Me.txtScrapped.Size = New System.Drawing.Size(193, 26)
        Me.txtScrapped.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(27, 271)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Order Time"
        '
        'txtOrder_time
        '
        Me.txtOrder_time.BackColor = System.Drawing.Color.Gainsboro
        Me.txtOrder_time.Enabled = False
        Me.txtOrder_time.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrder_time.Location = New System.Drawing.Point(168, 268)
        Me.txtOrder_time.Name = "txtOrder_time"
        Me.txtOrder_time.Size = New System.Drawing.Size(193, 26)
        Me.txtOrder_time.TabIndex = 9
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(27, 308)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(74, 20)
        Me.lblMessage.TabIndex = 16
        Me.lblMessage.Text = "Message"
        '
        'lblEXEVersion
        '
        Me.lblEXEVersion.AutoSize = True
        Me.lblEXEVersion.Location = New System.Drawing.Point(12, 363)
        Me.lblEXEVersion.Name = "lblEXEVersion"
        Me.lblEXEVersion.Size = New System.Drawing.Size(28, 13)
        Me.lblEXEVersion.TabIndex = 17
        Me.lblEXEVersion.Text = "v1.0"
        '
        'lblLinxLibVersion
        '
        Me.lblLinxLibVersion.AutoSize = True
        Me.lblLinxLibVersion.Location = New System.Drawing.Point(12, 381)
        Me.lblLinxLibVersion.Name = "lblLinxLibVersion"
        Me.lblLinxLibVersion.Size = New System.Drawing.Size(28, 13)
        Me.lblLinxLibVersion.TabIndex = 18
        Me.lblLinxLibVersion.Text = "v1.0"
        '
        'txtPart
        '
        Me.txtPart.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPart.Location = New System.Drawing.Point(168, 101)
        Me.txtPart.Name = "txtPart"
        Me.txtPart.Size = New System.Drawing.Size(193, 26)
        Me.txtPart.TabIndex = 4
        '
        'txtScannedSerial
        '
        Me.txtScannedSerial.BackColor = System.Drawing.Color.Gainsboro
        Me.txtScannedSerial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScannedSerial.Location = New System.Drawing.Point(168, 65)
        Me.txtScannedSerial.Name = "txtScannedSerial"
        Me.txtScannedSerial.Size = New System.Drawing.Size(193, 26)
        Me.txtScannedSerial.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(27, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 20)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Serial"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 413)
        Me.Controls.Add(Me.txtScannedSerial)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblLinxLibVersion)
        Me.Controls.Add(Me.lblEXEVersion)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.txtOrder_time)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtScrapped)
        Me.Controls.Add(Me.txtPack_time)
        Me.Controls.Add(Me.txtUse_time)
        Me.Controls.Add(Me.txtStart_time)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.txtPart)
        Me.Controls.Add(Me.txtSerial)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.Text = "PROD044"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSerial As TextBox
    Friend WithEvents btnLoad As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtStart_time As TextBox
    Friend WithEvents txtUse_time As TextBox
    Friend WithEvents txtPack_time As TextBox
    Friend WithEvents txtScrapped As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtOrder_time As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblMessage As Label
    Friend WithEvents lblEXEVersion As Label
    Friend WithEvents lblLinxLibVersion As Label
    Friend WithEvents txtPart As TextBox
    Friend WithEvents txtScannedSerial As TextBox
    Friend WithEvents Label8 As Label
End Class
