<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REGISTRATION
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(REGISTRATION))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.AccNumTb = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PinTb = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NameTb = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FNameTb = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.OccupationTb = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.AddressTb = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PhoneTb = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DobDate = New System.Windows.Forms.DateTimePicker()
        Me.SubmitBtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.EduCb = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(714, 68)
        Me.Panel1.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(683, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(28, 26)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(196, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(331, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ATM MANAGEMENT SYSTEM"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 589)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(714, 10)
        Me.Panel2.TabIndex = 3
        '
        'AccNumTb
        '
        Me.AccNumTb.Location = New System.Drawing.Point(122, 154)
        Me.AccNumTb.Name = "AccNumTb"
        Me.AccNumTb.Size = New System.Drawing.Size(175, 20)
        Me.AccNumTb.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 19)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "ACC NUM"
        '
        'PinTb
        '
        Me.PinTb.Location = New System.Drawing.Point(489, 156)
        Me.PinTb.Name = "PinTb"
        Me.PinTb.Size = New System.Drawing.Size(175, 20)
        Me.PinTb.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(379, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 19)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "PIN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(379, 215)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 19)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "EDUCATION"
        '
        'NameTb
        '
        Me.NameTb.Location = New System.Drawing.Point(122, 214)
        Me.NameTb.Name = "NameTb"
        Me.NameTb.Size = New System.Drawing.Size(175, 20)
        Me.NameTb.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 19)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "NAME"
        '
        'FNameTb
        '
        Me.FNameTb.Location = New System.Drawing.Point(122, 267)
        Me.FNameTb.Name = "FNameTb"
        Me.FNameTb.Size = New System.Drawing.Size(175, 20)
        Me.FNameTb.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(38, 268)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 19)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "FNAME"
        '
        'OccupationTb
        '
        Me.OccupationTb.Location = New System.Drawing.Point(489, 267)
        Me.OccupationTb.Name = "OccupationTb"
        Me.OccupationTb.Size = New System.Drawing.Size(175, 20)
        Me.OccupationTb.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(379, 268)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 19)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "OCCUPATION"
        '
        'AddressTb
        '
        Me.AddressTb.Location = New System.Drawing.Point(122, 318)
        Me.AddressTb.Multiline = True
        Me.AddressTb.Name = "AddressTb"
        Me.AddressTb.Size = New System.Drawing.Size(175, 96)
        Me.AddressTb.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(36, 319)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 19)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "ADDRESS"
        '
        'PhoneTb
        '
        Me.PhoneTb.Location = New System.Drawing.Point(489, 330)
        Me.PhoneTb.Name = "PhoneTb"
        Me.PhoneTb.Size = New System.Drawing.Size(175, 20)
        Me.PhoneTb.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(379, 331)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 19)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "PHONE"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(379, 384)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 19)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "DOB"
        '
        'DobDate
        '
        Me.DobDate.CalendarFont = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DobDate.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DobDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DobDate.Location = New System.Drawing.Point(489, 382)
        Me.DobDate.Name = "DobDate"
        Me.DobDate.Size = New System.Drawing.Size(181, 27)
        Me.DobDate.TabIndex = 25
        '
        'SubmitBtn
        '
        Me.SubmitBtn.ActiveBorderThickness = 1
        Me.SubmitBtn.ActiveCornerRadius = 20
        Me.SubmitBtn.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.SubmitBtn.ActiveForecolor = System.Drawing.Color.White
        Me.SubmitBtn.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.SubmitBtn.BackColor = System.Drawing.SystemColors.Control
        Me.SubmitBtn.BackgroundImage = CType(resources.GetObject("SubmitBtn.BackgroundImage"), System.Drawing.Image)
        Me.SubmitBtn.ButtonText = "Submit"
        Me.SubmitBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SubmitBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubmitBtn.ForeColor = System.Drawing.Color.SeaGreen
        Me.SubmitBtn.IdleBorderThickness = 1
        Me.SubmitBtn.IdleCornerRadius = 20
        Me.SubmitBtn.IdleFillColor = System.Drawing.Color.OrangeRed
        Me.SubmitBtn.IdleForecolor = System.Drawing.Color.White
        Me.SubmitBtn.IdleLineColor = System.Drawing.Color.OrangeRed
        Me.SubmitBtn.Location = New System.Drawing.Point(290, 501)
        Me.SubmitBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.SubmitBtn.Name = "SubmitBtn"
        Me.SubmitBtn.Size = New System.Drawing.Size(173, 39)
        Me.SubmitBtn.TabIndex = 27
        Me.SubmitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(349, 545)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 23)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "LOGOUT"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(285, 86)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(161, 25)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "NEW ACCOUNT"
        '
        'EduCb
        '
        Me.EduCb.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EduCb.FormattingEnabled = True
        Me.EduCb.Items.AddRange(New Object() {"DIPLOMA", "UG", "PG", "PHD", "UNEDUCATED"})
        Me.EduCb.Location = New System.Drawing.Point(489, 207)
        Me.EduCb.Name = "EduCb"
        Me.EduCb.Size = New System.Drawing.Size(175, 27)
        Me.EduCb.TabIndex = 29
        '
        'REGISTRATION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 599)
        Me.Controls.Add(Me.EduCb)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.SubmitBtn)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DobDate)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PhoneTb)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.AddressTb)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.OccupationTb)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.FNameTb)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NameTb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PinTb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AccNumTb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "REGISTRATION"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REGISTRATION"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents AccNumTb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PinTb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NameTb As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents FNameTb As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents OccupationTb As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents AddressTb As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PhoneTb As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents DobDate As DateTimePicker
    Friend WithEvents SubmitBtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents EduCb As ComboBox
End Class
