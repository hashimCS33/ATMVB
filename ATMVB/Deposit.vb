Imports System.Data.SqlClient

Public Class Deposit
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim Obj = New MainForm()
        Obj.Acc = Acc
        Obj.Show()
        Me.Hide()
    End Sub

    Public Property Acc As String

    Dim Con = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\hashi\Documents\ATMVbDb.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    Dim OldBalance = 0
    Private Sub GetBalance()
        Con.Open()
        Dim cmd As SqlCommand
        Dim query = "Select Balance from AccountTbl where AccNum=" & Acc & ""
        cmd = New SqlCommand(query, Con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable
        dt = New DataTable
        sda.Fill(dt)
        OldBalance = Convert.ToInt32(dt.Rows(0)(0).ToString())
        Con.Close()
    End Sub
    Private Sub UpdateBal()
        Dim Account = Convert.ToInt32(Acc)
        Dim NewBal = OldBalance + Convert.ToInt32(AmountTb.Text)
        Try
            'Dim Bal = 0
            Con.open()
            Dim query = "Update AccountTbl set Balance =" & NewBal & "where AccNum=" & Acc & " "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Balance Updated")
            Con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Try
            If AmountTb.Text = "" Or Convert.ToInt32(AmountTb.Text) < 1 Then

                MsgBox("Missing Information")
            Else
                Dim Account = Convert.ToInt32(Acc)
                Dim TrType = "Depsoit"
                Try
                    Dim Bal = 0
                    Con.open()
                    Dim query = "insert into TransactionYbl values(" & MyAcc & ",'" & TrType & "'," & AmountTb.Text & ",'" & System.DateTime.Today.Date & "')"
                    Dim cmd As SqlCommand
                    cmd = New SqlCommand(query, Con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Deposit Successfull")
                    Con.Close()
                    UpdateBal()
                Catch ex As Exception
                    MsgBox(ex.Message)

                End Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Dim MyAcc As Integer
    Private Sub Deposit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyAcc = Convert.ToInt32(Acc)
        GetBalance()

    End Sub
End Class