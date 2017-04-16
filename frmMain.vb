Public Class frmMain

    Private Sub StudentEnrollmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentEnrollmentToolStripMenuItem.Click
        Dim f As New frmEnrollment()
        f.MdiParent = Me
        f.setMode("L")
        f.Show()

    End Sub

    Private Sub StudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentsToolStripMenuItem.Click
        Dim f As New frmStudent()
        f.MdiParent = Me
        f.setMode("L")
        f.Show()
    End Sub

    Private Sub CourseCatalogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CourseCatalogToolStripMenuItem.Click
        Dim f As New frmCatalog
        f.MdiParent = Me
        f.setMode("L")
        f.Show()
    End Sub

    Private Sub InstructorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstructorToolStripMenuItem.Click
        Dim f As New frmInstructor
        f.MdiParent = Me
        f.setMode("L")
        f.Show()
    End Sub

    Private Sub CoursesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoursesToolStripMenuItem.Click
        Dim f As New frmCourse
        f.MdiParent = Me
        f.setMode("L")
        f.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
End Class