Public Class Period
    Dim id As Integer
    Dim amount As Integer
    Dim unit As String
    Public Property pId() As Integer
        Get
            Return Me.id
        End Get
        Set(value As Integer)
            Me.id = value
        End Set
    End Property
    Public Property pAmount() As Integer
        Get
            Return Me.amount
        End Get
        Set(value As Integer)
            Me.amount = value
        End Set
    End Property
    Public Property pUnit() As String
        Get
            Return Me.unit
        End Get
        Set(value As String)
            Me.unit = value
        End Set
    End Property
End Class
