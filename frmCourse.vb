Public Class frmCourse
    Dim courseList As New List(Of clsCourse)

    Private Sub frmCourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CPP_DB.dbOpen()
        courseList = CPP_DB.loadCourses()
        CPP_DB.dbClose()

        If (CPP_DB.dbGetError = "") Then
            refreshDataGrid()
        Else
            MessageBox.Show(CPP_DB.dbGetError)
        End If
    End Sub

    Private Sub refreshDataGrid()
        Dim CourseBindSource As New BindingSource

        CourseBindSource.DataSource = courseList

        Me.CPP_COURSESDataGridView.DataSource = CourseBindSource

    End Sub

    Public Sub setMode(strMode As String)
        'CONTROL THE DISPLAY OF LIST VS DETAIL OF CourseS

        If strMode = "L" Then
            'MODE IS LIST

            Me.gbCourseDetail.Hide()
            Me.gbCourseList.Left = 0
            Me.gbCourseList.Top = 0
            Me.Width = gbCourseList.Width + 50
            Me.Height = gbCourseList.Height + 50

            Me.gbCourseList.Visible = True
        Else
            'MODE IS DETAIL

            Me.gbCourseList.Hide()
            Me.gbCourseDetail.Left = 0
            Me.gbCourseDetail.Top = 0
            Me.Width = gbCourseDetail.Width + 50
            Me.Height = gbCourseDetail.Height + 50

            Me.gbCourseDetail.Visible = True
        End If
    End Sub

 

    'List settings
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.setMode("D")
        Me.COURSE_IDTextBox.Focus()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim row As DataGridViewRow = Me.CPP_COURSESDataGridView.CurrentRow

        If IsNothing(row) Then
            MessageBox.Show("Nothing is selected!")
            Exit Sub
        End If

        Dim aCourse As clsCourse = TryCast(row.DataBoundItem, clsCourse)

        Me.COURSE_IDTextBox.Text = aCourse.courseID
        Me.DESCRIPTIONTextBox.Text = aCourse.desc
        Me.UNITSTextBox.Text = aCourse.units

        Me.btnSave.Text = "&Update"

        Me.setMode("D")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim row As DataGridViewRow = Me.CPP_COURSESDataGridView.CurrentRow

        If IsNothing(row) Then
            MessageBox.Show("Nothing is selected!")
            Exit Sub
        End If

        Dim aCourse As clsCourse = TryCast(row.DataBoundItem, clsCourse)

        If CPP_DB.dbGetError = "" Then
            MessageBox.Show("Course deleted!!")

            For Each course In courseList
                If course.courseID = aCourse.courseId Then
                    courseList.Remove(course)
                    Exit For
                End If
            Next
            refreshDataGrid()
        Else
            MessageBox.Show(CPP_DB.dbGetError)
        End If

    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Dim strCourseId As String = InputBox("Enter the id of the course you are looking for:")

        For Each row As DataGridViewRow In CPP_COURSESDataGridView.Rows
            If row.Cells(0).Value = strCourseId Then
                row.Selected = True
                MessageBox.Show("We have found the following for course id:" & strCourseId & ".")
                Exit Sub
            End If
        Next

        MessageBox.Show("We have not found the id of the course you are looking for")
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim aCourse As New clsCourse()

        aCourse.courseID = Me.COURSE_IDTextBox.Text
        aCourse.desc = Me.DESCRIPTIONTextBox.Text
        aCourse.units = Me.UNITSTextBox.Text

        'Default Save function
        If (btnSave.Text = "&Save") Then
            CPP_DB.dbOpen()
            CPP_DB.insertCourse(aCourse)
            CPP_DB.dbClose()

            If CPP_DB.dbGetError <> "" Then
                MessageBox.Show(CPP_DB.dbGetError)
            Else
                courseList.Add(aCourse)
                refreshDataGrid()
                MessageBox.Show("Course saved!")
                Me.setMode("L")
            End If
        Else

            'Update course if there is an existing course
            CPP_DB.dbOpen()
            CPP_DB.updateCourse(aCourse)
            CPP_DB.dbClose()

            If CPP_DB.dbGetError <> "" Then
                MessageBox.Show(CPP_DB.dbGetError)
            Else
                For Each course In courseList
                    If course.courseID = aCourse.courseID Then
                        courseList.Remove(course)
                        Exit For
                    End If
                Next
                courseList.Add(aCourse)
                refreshDataGrid()
                MessageBox.Show("Course updated!")
                Me.setMode("L")
                Me.btnSave.Text = "&Save"
            End If

        End If
    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Clear the form
        For Each ctrl In gbCourseDetail.Controls
            If TypeOf (ctrl) Is TextBox Then
                TryCast(ctrl, TextBox).Clear()
            End If
        Next

        btnSave.Text = "&Save"

        setMode("L")
    End Sub

End Class