Public Class Splash

    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Myprogress.Increment(10) ' 1 2 34.. 100
        Dim Per As String
        Per = Convert.ToString(Myprogress.Value)
        percentLageLb.Text = Per + "%"
        If Myprogress.Value = 100 Then
            Me.Hide()
            Dim Obj = New Login
            Obj.Show()
            Timer1.Enabled = False

        End If
    End Sub

End Class
