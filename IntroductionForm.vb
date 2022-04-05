Public Class IntroductionForm
    Dim teams As ArrayList

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.teams = Connection.getTeams()
    End Sub

    Private Sub IntroductionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim count = 2
        For Each item As TextBox In Me.Controls.OfType(Of TextBox)()
            item.Text = Me.teams.Item(count).pName
            count = count - 1
        Next

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        Dim str = String.Format("MSSV:{0}
Họ tên:{1}
Ngành:{2}
Môn học:{3}
Khóa:{4}", Me.teams.Item(0).pID, Me.teams.Item(0).pName, Me.teams.Item(0).pMajor, Me.teams.Item(0).pCourse, Me.teams.Item(0).pSchoolyear)
        MessageBox.Show(str)
    End Sub



    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click
        Dim str = String.Format("MSSV:{0}
Họ tên:{1}
Ngành:{2}
Môn học:{3}
Khóa:{4}", Me.teams.Item(1).pID, Me.teams.Item(1).pName, Me.teams.Item(1).pMajor, Me.teams.Item(1).pCourse, Me.teams.Item(1).pSchoolyear)
        MessageBox.Show(str)
    End Sub



    Private Sub TextBox3_Click(sender As Object, e As EventArgs) Handles TextBox3.Click
        Dim str = String.Format("MSSV:{0}
Họ tên:{1}
Ngành:{2}
Môn học:{3}
Khóa:{4}", Me.teams.Item(2).pID, Me.teams.Item(2).pName, Me.teams.Item(2).pMajor, Me.teams.Item(2).pCourse, Me.teams.Item(2).pSchoolyear)
        MessageBox.Show(str)
    End Sub
End Class