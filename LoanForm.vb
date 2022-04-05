Public Class LoanForm
    Dim user As User
    Dim periodlist As ArrayList
    Public Sub New(user As User)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        ComboBox1.Text = ComboBox1.Items(0)
        Me.user = user
    End Sub

    Private Sub LoanForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Function addingPeriod(value As Integer)
        Dim path As String = ""
        Dim periodlist As ArrayList
        If value = 1 Then
            path = "C:\Users\ASUS\source\repos\WindowsApp2\WindowsApp2\Installment_PeriodList.txt"
        Else
            path = "C:\Users\ASUS\source\repos\WindowsApp2\WindowsApp2\PayFull_PeriodList.txt"
        End If
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
    Private Function validForm() As Boolean
        If TextBox1.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Then
            Return False
        End If
        Return True
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If validForm() = True Then
            Dim lcf As New LoanConfirmForm(Me.user, TextBox1.Text, ComboBox1.SelectedItem, Me.periodlist, ComboBox2.SelectedItem.ToString())
            lcf.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class