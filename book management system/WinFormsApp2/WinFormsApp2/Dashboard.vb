Imports System.Data.SqlClient
Imports System.Formats.Asn1

Public Class Dashboard
    Dim Con As New SqlConnection("Data Source=LAPTOP-S33ATO1O\SQLEXPRESS;Initial Catalog=bookshop;Integrated Security=True")
    Private Sub CountBook()
        Dim BookNum As Integer
        Con.Open()
        Dim sql = "select COUNT (*) from BookTbl "
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, Con)
        BookNum = cmd.ExecuteScalar
        BookLbl.Text = BookNum
        Con.Close()
    End Sub
    Private Sub CountUsers()
        Dim UsersNum As Integer
        Con.Open()
        Dim sql = "select COUNT (*) from UserTbl "
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, Con)
        UsersNum = cmd.ExecuteScalar
        UserLbl.Text = UsersNum
        Con.Close()
    End Sub
    Private Sub SumAmount()
        Dim Amount As Integer
        Con.Open()
        Dim sql = "select Sum (Amount) from BillTbl "
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, Con)
        Amount = cmd.ExecuteScalar
        AmountLbl.Text = "Rs " + Convert.ToString(Amount)
        Con.Close()
    End Sub
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CountBook()
        CountUsers()
        SumAmount()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Application.Exit()

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Dim Obj = New Books()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Dim Obj = New users()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Dim Obj = New login()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class