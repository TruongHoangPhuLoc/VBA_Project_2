Public Class Transfer
    Dim id As Integer
    Dim source_kind As String
    Dim rate As Decimal
    Dim dest_kind As String
    Dim complete_kind As String
    Public Property pId() As Integer
        Get
            Return Me.id
        End Get
        Set(value As Integer)
            Me.id = value
        End Set
    End Property
    Public Property pSource_Kind() As String
        Get
            Return Me.source_kind
        End Get
        Set(value As String)
            Me.source_kind = value
        End Set
    End Property
    Public Property pRate() As Decimal
        Get
            Return Me.rate
        End Get
        Set(value As Decimal)
            Me.rate = value
        End Set
    End Property
    Public Property pDest_Kind() As String
        Get
            Return Me.dest_kind
        End Get
        Set(value As String)
            Me.dest_kind = value
        End Set
    End Property
    Public Property pCompl_Kind() As String
        Get
            Return Me.complete_kind
        End Get
        Set(value As String)
            Me.complete_kind = value
        End Set
    End Property
End Class
