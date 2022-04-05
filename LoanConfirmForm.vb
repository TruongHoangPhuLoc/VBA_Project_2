Public Class LoanConfirmForm
    Dim user As User
    Dim amount As String
    Dim method As String
    Dim path As String
    Private Function getKeyToCaculateProfit() As Integer
        Dim str As String = ComboBox1.SelectedItem()
        Dim key = Integer.Parse(str.Split(".")(0))
        Select Case key
            Case < 3
                key = 1
            Case 3 To 5
                key = 2
            Case Else
                key = 3
        End Select
        Return key
    End Function
    Public Sub New(user As User, amount As String, method As String, periodlist As ArrayList, dfperiod As String)

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me.user = user
        Me.amount = amount
        Me.method = method
        For Each item As Period In periodlist
            ComboBox1.Items.Add(item.pAmount.ToString & "." & " " & item.pUnit)
        Next
        If method.Split(".")(0) = "2" Then
            Label6.Visible = False
            TextBox6.Visible = False
            Me.path = "C:\Users\ASUS\source\repos\WindowsApp2\WindowsApp2\Profit_PayFullList.txt"
        Else

            Me.path = "C:\Users\ASUS\source\repos\WindowsApp2\WindowsApp2\Profit_InstallmentList.txt"
        End If
        'default period
        ComboBox1.Text = dfperiod

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Function calculateProfit() As String
        Dim key As Integer = getKeyToCaculateProfit()
        Dim profit As Profit = CommonFunction.getProfit(Me.path, key)
        'get month
        Dim month As Integer = Integer.Parse(ComboBox1.SelectedItem.ToString.Split(".")(0))
        'Dim sum As Double = Math.Round(amount * profit.pProfit / 12 * month)
        Dim sum As Decimal = amount * profit.pProfit / 12 * month
        Return FormatNumber(sum, 0)
    End Function
    Private Function getPayingPermonth() As String
        Dim profit As String = calculateProfit()
        Dim sum As Long = Me.amount + Long.Parse(CommonFunction.convertStringFormatToNumber(profit))
        Dim month As Integer = Integer.Parse(ComboBox1.SelectedItem.ToString.Split(".")(0))
        Dim result As Decimal = sum / month
        Return FormatNumber(Math.Round(result, 0), 0)
    End Function
    Private Function renderValue()
        'set default value
        TextBox1.Text = Me.user.pFname & " " & Me.user.pLastname
        TextBox2.Text = Me.amount
        TextBox3.Text = Me.method
        TextBox5.Text = calculateProfit()
        If Label6.Visible = True And TextBox6.Visible = True Then
            TextBox6.Text = getPayingPermonth() & "/month"
        End If
        TextBox4.Text = Math.Round(CommonFunction.getProfit(Me.path, getKeyToCaculateProfit()).pProfit * 100, 0) & "%"
    End Function

    Private Sub LoanConfirmForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'set default value
        renderValue()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        renderValue()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        renderValue()
    End Sub
End Class