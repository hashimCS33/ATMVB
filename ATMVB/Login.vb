Imports System.Data.SqlClient

Public Class Login
    Public Property AccountNum As String
    Dim Con = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\hashi\Documents\ATMVbDb.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim Obj = New REGISTRATION()
        Me.Hide()
        Obj.Show()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        If AccNumTb.Text = "" Or PinTb.Text = "" Then
            MsgBox("Enter the Account Number and  PIN Number ")
        Else
            Con.Open()
            Dim query = "Select * from AccountTbl where AccNum =@AccNum and PIN =@PIN"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.Parameters.Add("@AccNum", SqlDbType.VarChar).Value = AccNumTb.Text
            cmd.Parameters.Add("@PIN", SqlDbType.VarChar).Value = PinTb.Text
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim Table As New DataTable()
            da.Fill(Table)
            If Table.Rows.Count <= 0 Then
                MsgBox("wrong UserName Or Password")
            Else
                Dim Obj = New MainForm
                Obj.Acc = AccNumTb.Text
                Obj.Show()
                Me.Hide()
            End If
            Con.Close()
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class