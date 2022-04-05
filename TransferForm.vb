Public Class TransferForm
    Dim transferlist As ArrayList

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Me.transferlist = Connection.getTransferList()
        For Each item As Transfer In Me.transferlist
            ComboBox1.Items.Add(item.pId.ToString & "." & " " & item.pCompl_Kind)
        Next
        For Each item As Transfer In Me.transferlist
            ComboBox2.Items.Add(item.pId.ToString & "." & " " & item.pCompl_Kind)
        Next
        ComboBox1.Text = ComboBox1.Items(0)
        ComboBox2.Text = ComboBox2.Items(0)
        ' Add any initialization after the InitializeComponent() call.
        TextBox2.Visible = False
    End Sub

    Private Sub TransferForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Function validForm() As Boolean
        If TextBox1.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Then
            Return False
        End If
        Return True
    End Function
    Private Function calculateTransfer() As String
        Dim source As Transfer = Me.transferlist.Item(ComboBox1.SelectedItem.ToString().Split(".")(0) - 1)
        Dim des As Transfer = Me.transferlist.Item(ComboBox2.SelectedItem.ToString().Split(".")(0) - 1)
        Dim amount = Long.Parse(TextBox1.Text)
        Dim rate = des.pRate / source.pRate
        Dim transfer = amount * rate
        Dim str = String.Format("{0} {1} = {2} {3}", amount, source.pDest_Kind, Math.Round(transfer, 3), des.pDest_Kind)
        Return str
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If validForm() = True Then
            If TextBox2.Visible = False Then
                TextBox2.Visible = True
            End If
            Dim result = calculateTransfer()
            TextBox2.Text = result
        End If
    End Sub
End Class