Public Class CommonFunction
    Public Shared Function getProfit(path As String, key As Integer) As Profit
        Dim profit As Profit
        Dim arrayPF As ArrayList = Connection.getProfitList(path)
        For Each item As Profit In arrayPF
            If item.pId = key Then
                profit = item
            End If
        Next
        Return profit
    End Function
    Public Shared Function convertStringFormatToNumber(str As String) As String
        Dim temp As String() = str.Split(",")
        Dim result As String = ""
        For Each item As String In temp
            result = result + item
        Next
        Return result
    End Function
End Class
