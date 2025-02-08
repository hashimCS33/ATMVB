Public Class MainForm

    Public Property Acc As String
    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Dim Obj = New Deposit()
        Obj.Acc = AccNumLbl.Text
        Obj.Show()
        Me.Hide()

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AccNumLbl.Text = Acc
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim Obj = New Login()
        Obj.Show()
        Acc = AccNumLbl.Text
        Me.Hide()
    End Sub

    Private Sub BunifuThinButton25_Click(sender As Object, e As EventArgs) Handles BunifuThinButton25.Click
        Dim Obj = New Balance()
        Obj.Acc = AccNumLbl.Text
        Obj.Show()
        Me.Hide()

    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        Dim Obj = New Withdraw()
        Obj.Acc = AccNumLbl.Text
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuThinButton26_Click(sender As Object, e As EventArgs) Handles BunifuThinButton26.Click
        Dim Obj = New ChangePin()
        Obj.Acc = AccNumLbl.Text
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        Dim Obj = New Fastcash()
        Obj.Acc = AccNumLbl.Text
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        Dim Obj = New Ministatement()
        Obj.Acc = AccNumLbl.Text
        Obj.Show()
        Me.Hide()
    End Sub
End Class