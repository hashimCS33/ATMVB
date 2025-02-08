Imports System.Data.SqlClient

Public Class Balance
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()

    End Sub
    Public Property Acc As String
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim Obj = New MainForm
        Obj.Acc = AccNumLbl.Text
        Obj.Show()
        Me.Hide()

    End Sub
    Dim Con = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\hashi\Documents\ATMVbDb.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    Private Sub GetBalance()
        Con.Open()
        Dim cmd As SqlCommand
        Dim query = "Select Balance from AccountTbl where AccNum=" & Account & ""
        cmd = New SqlCommand(query, Con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable
        dt = New DataTable
        sda.Fill(dt)
        BalLbl.Text = Convert.ToInt32(dt.Rows(0)(0).ToString())
        Con.Close()
    End Sub
    Dim Account As Integer
    Private Sub Balance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Account = Convert.ToInt32(Acc)
        AccNumLbl.Text = Acc
        GetBalance()

    End Sub
End Class