Imports System.Data.SqlClient

Public Class Fastcash
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
        BalLbl.Text = OldBalance
        Con.Close()
    End Sub
    Dim MyAcc = 0

    Private Sub Fastcash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetBalance()
        MyAcc = Convert.ToInt32(Acc)
    End Sub
    Dim Amount As Integer
    Private Sub UpdateBal(Amt As Integer)
        Dim Account = Convert.ToInt32(Acc)
        Dim NewBal = OldBalance - Amt
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
        If OldBalance < 100000 Then
            MsgBox("No Enough Balance")

        Else
            Dim Account = Convert.ToInt32(Acc)
            Dim TrType = "WithDraw"
            Amount = 100000
            Try
                Dim Bal = 0
                Con.open()
                Dim query = "insert into TransactionYbl values(" & MyAcc & ",'" & TrType & "'," & Amount & ",'" & System.DateTime.Today.Date & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Withdraw Successfull")
                Con.Close()
                UpdateBal(Amount)
                Dim Obj = New Fastcash()
                Obj.Acc = Acc
                Obj.Show()
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim Obj = New MainForm()
        Obj.Acc = Acc
        Obj.Show()
        Me.Hide()

    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        If OldBalance < 500000 Then
            MsgBox("No Enough Balance")

        Else
            Dim Account = Convert.ToInt32(Acc)
            Dim TrType = "WithDraw"
            Amount = 500000
            Try
                Dim Bal = 0
                Con.open()
                Dim query = "insert into TransactionYbl values(" & MyAcc & ",'" & TrType & "'," & Amount & ",'" & System.DateTime.Today.Date & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Withdraw Successfull")
                Con.Close()
                UpdateBal(Amount)
                Dim Obj = New Fastcash()
                Obj.Acc = Acc
                Obj.Show()
                Me.Hide()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        If OldBalance < 750000 Then
            MsgBox("No Enough Balance")

        Else
            Dim Account = Convert.ToInt32(Acc)
            Dim TrType = "WithDraw"
            Amount = 750000
            Try
                Dim Bal = 0
                Con.open()
                Dim query = "insert into TransactionYbl values(" & MyAcc & ",'" & TrType & "'," & Amount & ",'" & System.DateTime.Today.Date & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Withdraw Successfull")
                Con.Close()
                UpdateBal(Amount)
                Dim Obj = New Fastcash()
                Obj.Acc = Acc
                Obj.Show()
                Me.Hide()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        If OldBalance < 1000000 Then
            MsgBox("No Enough Balance")

        Else
            Dim Account = Convert.ToInt32(Acc)
            Dim TrType = "WithDraw"
            Amount = 1000000
            Try
                Dim Bal = 0
                Con.open()
                Dim query = "insert into TransactionYbl values(" & MyAcc & ",'" & TrType & "'," & Amount & ",'" & System.DateTime.Today.Date & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Withdraw Successfull")
                Con.Close()
                UpdateBal(Amount)
                Dim Obj = New Fastcash()
                Obj.Acc = Acc
                Obj.Show()
                Me.Hide()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BunifuThinButton26_Click(sender As Object, e As EventArgs) Handles BunifuThinButton26.Click
        If OldBalance < 2000000 Then
            MsgBox("No Enough Balance")

        Else
            Dim Account = Convert.ToInt32(Acc)
            Dim TrType = "WithDraw"
            Amount = 2000000
            Try
                Dim Bal = 0
                Con.open()
                Dim query = "insert into TransactionYbl values(" & MyAcc & ",'" & TrType & "'," & Amount & ",'" & System.DateTime.Today.Date & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Withdraw Successfull")
                Con.Close()
                UpdateBal(Amount)
                Dim Obj = New Fastcash()
                Obj.Acc = Acc
                Obj.Show()
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BunifuThinButton25_Click(sender As Object, e As EventArgs) Handles BunifuThinButton25.Click
        If OldBalance < 3000000 Then
            MsgBox("No Enough Balance")

        Else
            Dim Account = Convert.ToInt32(Acc)
            Dim TrType = "WithDraw"
            Amount = 3000000
            Try
                Dim Bal = 0
                Con.open()
                Dim query = "insert into TransactionYbl values(" & MyAcc & ",'" & TrType & "'," & Amount & ",'" & System.DateTime.Today.Date & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Withdraw Successfull")
                Con.Close()
                UpdateBal(Amount)
                Dim Obj = New Fastcash()
                Obj.Acc = Acc
                Obj.Show()
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub
End Class