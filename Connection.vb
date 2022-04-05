Imports System.IO

Public Class Connection

    Private Shared Function loadData(path As String) As ArrayList
        Dim sr As StreamReader = New StreamReader(path)
        Dim array As New ArrayList
        Try
            Do Until sr.EndOfStream
                array.Add(sr.ReadLine())
            Loop
        Catch ex As Exception
            MessageBox.Show("Fail to Read Data")
        End Try
        sr.Close()
        Return array
    End Function
    Shared Function getPeriodlist(path As String)
        Dim temp As ArrayList = loadData(path)
        Dim periodlist As New ArrayList
        For Each item As String In temp
            Dim period As New Period
            Dim splitarray() = item.Split(";")
            period.pId = Integer.Parse(splitarray(0))
            period.pAmount = Integer.Parse(splitarray(1))
            period.pUnit = splitarray(2)
            periodlist.Add(period)
        Next
        Return periodlist
    End Function
    Shared Function getProfitList(path As String) As ArrayList
        Dim temp As ArrayList = loadData(path)
        Dim profitlist As New ArrayList
        For Each item As String In temp
            Dim profit As New Profit
            Dim splitarray() = item.Split(";")
            profit.pId = Integer.Parse(splitarray(0))
            profit.pProfit = Single.Parse(splitarray(1))
            profit.pDescription = splitarray(2)
            profitlist.Add(profit)
        Next
        Return profitlist
    End Function
    Shared Function getUserlist() As ArrayList
        Dim path As String = "C:\Users\ASUS\source\repos\WindowsApp2\WindowsApp2\UserList.txt"
        Dim temp As ArrayList = loadData(path)
        Dim userlist As New ArrayList
        For Each item As String In temp
            Dim user As New User
            Dim splitarray() = item.Split(";")
            user.pID = Integer.Parse(splitarray(0))
            user.pFname = splitarray(1)
            user.pLastname = splitarray(2)
            user.pUsername = splitarray(3)
            user.pPassword = splitarray(4)
            userlist.Add(user)
        Next
        Return userlist
    End Function
    Shared Function getTransferList() As ArrayList
        Dim path As String = "C:\Users\ASUS\source\repos\WindowsApp2\WindowsApp2\USD_Transfer.txt"
        Dim temp As ArrayList = loadData(path)
        Dim transferlist As New ArrayList
        For Each item As String In temp
            Dim transfer As New Transfer
            Dim arrsp() = item.Split(";")
            transfer.pId = Integer.Parse(arrsp(0))
            transfer.pSource_Kind = arrsp(1)
            transfer.pRate = Decimal.Parse(arrsp(2))
            transfer.pDest_Kind = arrsp(3)
            transfer.pCompl_Kind = arrsp(4)
            transferlist.Add(transfer)
        Next
        Return transferlist
    End Function
    Public Shared Function getTeams() As ArrayList
        Dim path = "C:\Users\ASUS\source\repos\WindowsApp2\WindowsApp2\Teams.txt"
        Dim temp = loadData(path)
        Dim teams As New ArrayList
        For Each item As String In temp
            Dim line() = item.Split(";")
            Dim mem As New Member
            mem.pName = line(0)
            mem.pID = line(1)
            mem.pMajor = line(2)
            mem.pCourse = line(3)
            mem.pSchoolYear = line(4)
            teams.Add(mem)
        Next
        Return teams
    End Function

End Class
