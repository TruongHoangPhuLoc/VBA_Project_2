Public Class SavingForm
    Dim user As User
    Dim periodlist As ArrayList

    Public Sub New(user As User)

        ' This call is required by the designer.
        InitializeComponent()
        Me.user = user
        ComboBox1.Text = ComboBox1.Items(0)
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Function addingPeriod(value As Integer)
        Dim path As String = "C:\Users\ASUS\source\repos\WindowsApp2\WindowsApp2\Saving_Period.txt"
        Dim periodlist As ArrayList
        periodlist = Connection.getPeriodlist(path)
        Me.periodlist = periodlist
        For Each item As Period In periodlist
            ComboBox2.Items().Add(item.pAmount.ToString & "." & " " & item.pUnit)
        Next
    End Function
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'clear current selection
        ComboBox2.Items().Clear()
        Dim selection As Integer = Integer.Parse(ComboBox1.SelectedItem.ToString.Split(".")(0))
        addingPeriod(selection)
        'set deafault value
        ComboBox2.Text = ComboBox2.Items(0)
    End Sub

    Private Sub SavingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Function validForm() As Boolean
        If TextBox1.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Then
            Return False
        End If
        Return True
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If validForm() = True Then
            Dim svcf As New SavingConfirmForm(Me.user, TextBox1.Text, ComboBox1.SelectedItem, Me.periodlist, ComboBox2.SelectedItem.ToString())
            svcf.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class