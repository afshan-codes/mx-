Imports System.Data.SqlClient
Public Class login
    Dim Con As New SqlConnection("Data Source=LAPTOP-S33ATO1O\SQLEXPRESS;Initial Catalog=bookshop;Integrated Security=True")
    Dim cmd As SqlCommand
    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        If UnameTb.Text = "" Or PasswordTb.Text = "" Then
            MsgBox("enter username and password")
        Else
            Con.Open()
            Dim query = "select * from UserTbl where name ='" & UnameTb.Text & "'and password ='" & PasswordTb.Text & "'"
            cmd = New SqlCommand(query, Con)
            Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()
            sda.Fill(ds)
            Dim a As Integer
            a = ds.Tables(0).Rows.Count
            If a = 0 Then
                MsgBox("Wrong Username or Password")
            Else
                Dim Bill = New Bills
                Bill.UserName = UnameTb.Text
                Bill.Show()
                Me.Hide()

            End If

            Con.Close()


            End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Application.Exit()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Obj = New AdminLogin()

        Obj.Show()
        Me.Hide()
    End Sub
End Class