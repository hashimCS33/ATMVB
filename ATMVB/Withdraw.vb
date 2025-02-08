Imports System.Data.SqlClient

Public Class Withdraw
    Public Property Acc As String
    Dim MyAcc As Integer
    Private Sub Withdraw_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyAcc = Convert.ToInt32(Acc)
        GetBalance()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim Obj = New MainForm()
        Obj.Acc = Acc
        Obj.Show()
        Me.Hide()
    End Sub
    Dim OldBalance = 0
    Dim Con = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\hashi\Documents\ATMVbDb.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
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
        BalLbl.Text = OldBalance
        Con.Close()

    End Sub
    Private Sub UpdateBal()
        Dim Account = Convert.ToInt32(Acc)
        Dim NewBal = OldBalance - Convert.ToInt32(AmountTb.Text)
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
            If AmountTb.Text = "" Then
                MsgBox("Missing Information")
            ElseIf Convert.ToInt32(AmountTb.Text) > OldBalance Then
                MsgBox("No Enough Money")

            Else
                Dim Account = Convert.ToInt32(Acc)
                Dim TrType = "WithDraw"
                Try
                    Dim Bal = 0
                    Con.open()
                    Dim query = "insert into TransactionYbl values(" & MyAcc & ",'" & TrType & "'," & AmountTb.Text & ",'" & System.DateTime.Today.Date & "')"
                    Dim cmd As SqlCommand
                    cmd = New SqlCommand(query, Con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Withdraw Successfull")
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

    Private Sub AmountTb_TextChanged(sender As Object, e As EventArgs) Handles AmountTb.TextChanged

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub
End Class