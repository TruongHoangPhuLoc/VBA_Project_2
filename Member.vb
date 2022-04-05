Public Class Member
    Dim studentID As String
    Dim name As String
    Dim major As String
    Dim course As String
    Dim school_year As String
    Public Property pID As String
        Get
            Return Me.studentID
        End Get
        Set(value As String)
            Me.studentID = value
        End Set
    End Property
    Public Property pName As String
        Get
            Return Me.name
        End Get
        Set(value As String)
            Me.name = value
        End Set
    End Property
    Public Property pMajor As String
        Get
            Return Me.major
        End Get
        Set(value As String)
            Me.major = value
        End Set
    End Property
    Public Property pCourse As String
        Get
            Return Me.course
        End Get
        Set(value As String)
            Me.course = value
        End Set
    End Property
    Public Property pSchoolYear As String
        Get
            Return Me.school_year
        End Get
        Set(value As String)
            Me.school_year = value
        End Set
    End Property
End Class
