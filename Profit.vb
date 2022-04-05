Public Class Profit
    Dim id As Integer
    Dim profit As Decimal
    Dim description As String
    Public Property pId() As Integer
        Get
            Return Me.id
        End Get
        Set(value As Integer)
            Me.id = value
        End Set
    End Property
    Public Property pProfit() As Decimal
        Get
            Return Me.profit
        End Get
        Set(value As Decimal)
            Me.profit = value
        End Set
    End Property
    Public Property pDescription() As String
        Get
            Return Me.description
        End Get
        Set(value As String)
            Me.description = value
        End Set
    End Property
End Class
