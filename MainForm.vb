Public Class MainForm
    Dim user As User
    Public Sub New(user As User)

        ' This call is required by the designer.
        InitializeComponent()
        Me.user = user
        Label1.Text = "Welcome back " + user.pFname + " " + user.pLastname
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ls As New LoanForm(Me.user)
        ls.Show()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim svf As New SavingForm(Me.user)
        svf.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim tsf As New TransferForm()
        tsf.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim introduction As New IntroductionForm()
        introduction.Show()
    End Sub
End Class