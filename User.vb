Public Class User
    Dim id As Integer
    Dim firstname As String
    Dim lastname As String
    Dim username As String
    Dim password As String
    Public Property pID() As Integer
        Get
            Return Me.id
        End Get
        Set(value As Integer)
            Me.id = value
        End Set
    End Property
    Public Property pFname() As String
        Get
            Return Me.firstname
        End Get
        Set(value As String)
            Me.firstname = value
        End Set
    End Property

    Public Property pLastname() As String
        Get
            Return Me.lastname
        End Get
        Set(value As String)
            Me.lastname = value
        End Set
    End Property
    Public Property pUsername() As String
        Get
            Return Me.username
        End Get
        Set(value As String)
            Me.username = value
        End Set
    End Property
    Public Property pPassword() As String
        Get
            Return Me.password
        End Get
        Set(value As String)
            Me.password = value
        End Set
    End Property
End Class
