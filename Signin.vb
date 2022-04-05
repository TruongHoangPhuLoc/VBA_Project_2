Public Class Signin
    Dim userlist As New ArrayList
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim user As New User
        user.pUsername = TextBox1.Text
        user.pPassword = TextBox2.Text
        If validLogin(user) Then
            MessageBox.Show("Success to Sign-in")
            Dim mf As New MainForm(user)
            mf.Show()
        Else
            MessageBox.Show("Fail to Sign-in")
        End If
    End Sub

    Private Function validLogin(ByRef user As User) As Boolean
        For Each item As User In userlist
            If item.pUsername = user.pUsername And item.pPassword = user.pPassword Then
                user = item
                Return True
            End If
        Next
        Return False
    End Function
    Private Sub Signin_Load(sender As Object, e As EventArgs) Handles Me.Load
        userlist = Connection.getUserlist()
    End Sub
End Class
