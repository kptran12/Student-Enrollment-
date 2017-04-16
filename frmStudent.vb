Public Class frmStudent
    Dim studentList As New List(Of clsStudent)

    Private Sub frmStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LOAD FROM DB
        CPP_DB.dbOpen()
        studentList = CPP_DB.loadStudents()
        CPP_DB.dbClose()

        'CHECK ERRORS
        If (CPP_DB.dbGetError = "") Then
            refreshDataGrid()
        Else
            MessageBox.Show(CPP_DB.dbGetError)
        End If
    End Sub

    Private Sub refreshDataGrid()
        'CREATE A BINDING SOURCE AND 
        Dim StudentBindingSource As New BindingSource

        'ASSIGN THE DATAROUCE TO THE STUDENT LIST
        StudentBindingSource.DataSource = studentList

        'SET THE GRID DATASOURCE TO THE BINDING SOURCE
        Me.CPP_STUDENTSDataGridView.DataSource = StudentBindingSource
    End Sub

    Public Sub setMode(strMode As String)
        'CONTROL THE DISPLAY OF LIST VS DETAIL OF STUDENTS

        If strMode = "L" Then
            'MODE IS LIST

            Me.gbStudentDetail.Hide()
            Me.gbStudentList.Left = 0
            Me.gbStudentList.Top = 0
            Me.Width = gbStudentList.Width + 50
            Me.Height = gbStudentList.Height + 50

            Me.gbStudentList.Visible = True
        Else
            'MODE IS DETAIL

            Me.gbStudentList.Hide()
            Me.gbStudentDetail.Left = 0
            Me.gbStudentDetail.Top = 0
            Me.Width = gbStudentDetail.Width + 50
            Me.Height = gbStudentDetail.Height + 50

            Me.gbStudentDetail.Visible = True
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'SWITCH TO DETAIL DATA ENTRY
        Me.setMode("D")
        Me.BRONCO_IDTextBox.Focus()
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'CREATE STUDENT OBJECT
        Dim aStudent As New clsStudent

        'POPULATE STUDENT OBJECT
        aStudent.broncoID = Me.BRONCO_IDTextBox.Text
        aStudent.firstName = Me.FIRST_NAMETextBox.Text
        aStudent.lastName = Me.LAST_NAMETextBox.Text
        aStudent.email = Me.EMAILTextBox.Text
        aStudent.phone = Me.PHONETextBox.Text

        'If (clsValidator.getError() <> "") Then
        '    MessageBox.Show(clsValidator.getError)
        'End If

        'CHECK IF WE ARE SAVING OR UPDATING
        If (btnSave.Text = "&Save") Then

            'SAVE STUDENT
            CPP_DB.dbOpen()
            CPP_DB.insertStudent(aStudent)
            CPP_DB.dbClose()

            'CHECK FOR ERRORS
            If CPP_DB.dbGetError <> "" Then
                MessageBox.Show(CPP_DB.dbGetError)
            Else
                studentList.Add(aStudent)                       'NO ERRORS ADD STUDENT TO LIST
                refreshDataGrid()                               'REFRESH GRID
                MessageBox.Show("Student Saved!")               'NOTIFY
                Me.setMode("L")                                 'SWITCH TO LIST MODE
            End If
        Else

            'UPDATE STUDENT
            CPP_DB.dbOpen()
            CPP_DB.updateStudent(aStudent)
            CPP_DB.dbClose()

            'CHECK FOR ERRORS
            If CPP_DB.dbGetError <> "" Then
                MessageBox.Show(CPP_DB.dbGetError)
            Else
                'REMOVE OLD STUDENT FROM LIST
                For Each student In studentList
                    If student.broncoID = aStudent.broncoID Then
                        studentList.Remove(student)
                        Exit For
                    End If
                Next
                studentList.Add(aStudent)                       'NO ERRORS ADD NEW STUDENT TO LIST
                refreshDataGrid()                               'REFRESH GRID
                MessageBox.Show("Student Updated!")             'NOTIFY
                Me.setMode("L")                                 'SWITCH TO LIST MODE
                Me.btnSave.Text = "&Save"                       'MAKE SURE WE SET THE SAVE BUTTON BACK TO DEFAULT
            End If
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'GET CURRENT STUDENT ROW FROM THE GRID
        Dim row As DataGridViewRow = Me.CPP_STUDENTSDataGridView.CurrentRow

        'CHECK IF ROW IS VALIID OTHERWISE STOP
        If IsNothing(row) Then
            MessageBox.Show("Nothing Selected!")
            Exit Sub
        End If

        'CONVERT THE ROW TO A STUDENT OBJECT
        Dim aStudent As clsStudent = TryCast(row.DataBoundItem, clsStudent)

        'GET DATA FROM THE ROW TO THE TEXTBOXES
        Me.BRONCO_IDTextBox.Text = aStudent.broncoID
        Me.FIRST_NAMETextBox.Text = aStudent.firstName
        Me.LAST_NAMETextBox.Text = aStudent.lastName
        Me.PHONETextBox.Text = aStudent.phone
        Me.EMAILTextBox.Text = aStudent.email

        'SET THE FOCUS ON ID
        Me.BRONCO_IDTextBox.Focus()

        'SWITCH SAVE TO UPDATE
        Me.btnSave.Text = "&Update"

        'DISPLAY DETAIL MODE
        Me.setMode("D")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim row As DataGridViewRow = Me.CPP_STUDENTSDataGridView.CurrentRow

        'CHECK IF ROW IS VALID OTHERWISE STOP
        If IsNothing(row) Then
            MessageBox.Show("Nothing selected!")
            Exit Sub
        End If

        'CONVERT ROW TO STUDENT
        Dim aStudent As clsStudent = TryCast(row.DataBoundItem, clsStudent)

        'DELETE STUDENT FROM DB
        CPP_DB.dbOpen()
        CPP_DB.deleteStudent(aStudent.broncoID)
        CPP_DB.dbClose()

        'CHECK FOR ERRORS
        If CPP_DB.dbGetError = "" Then
            MessageBox.Show("Student Deleted!")
            'REMOVE STUDENT FROM LIST
            For Each student In studentList
                If student.broncoID = aStudent.broncoID Then
                    studentList.Remove(student)
                    Exit For
                End If
            Next
            'UPDATE GRID
            refreshDataGrid()
        Else
            MessageBox.Show(CPP_DB.dbGetError)
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        'CLEAR ALL CONTROLS
        For Each ctrl In gbStudentDetail.Controls
            If TypeOf (ctrl) Is TextBox Then
                TryCast(ctrl, TextBox).Clear()
            End If
        Next

        'SET SAVE BUTTON TO DEFAULT 
        btnSave.Text = "&Save"

        'SWITCH TO LIST MODE
        setMode("L")
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Dim strBroncoId As String = InputBox("Enter Bronco ID")

        For Each row As DataGridViewRow In CPP_STUDENTSDataGridView.Rows
            If row.Cells(0).Value = strBroncoID Then
                row.Selected = True 'CPP_STUDENTSDataGridView.CurrentRow.
                MessageBox.Show("Found!")
                Exit Sub
            End If
        Next

        MessageBox.Show("Not found!")
    End Sub
End Class
