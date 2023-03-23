Public Class AdminLogin
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Obj = New login()
        Obj.Show()
        Me.Hide()


    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Application.Exit()

    End Sub

    Private Sub PasswordTb_TextChanged(sender As Object, e As EventArgs) Handles PasswordTb.TextChanged

    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        If PasswordTb.Text = "Password" Then
            Dim Obj = New Books()
            Obj.Show()
            Me.Hide()
        Else
            MsgBox("Wrong Password")
        End If

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class