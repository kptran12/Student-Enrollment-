Public Class frmInstructor
    Dim instructorList As New List(Of clsInstructor)
    Private Sub frmInstructor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CPPDataSet.CPP_INSTRUCTORS' table. You can move, or remove it, as needed.
        CPP_DB.dbOpen()
        instructorList = CPP_DB.loadInstructors()
        CPP_DB.dbClose()

        If (CPP_DB.dbGetError = "") Then
            refreshDataGrid()
        Else
            MessageBox.Show(CPP_DB.dbGetError)
        End If

    End Sub

    'Update grid
    Private Sub refreshDataGrid()
        Dim InstructorBindSource As New BindingSource

        InstructorBindSource.DataSource = instructorList

        Me.CPP_INSTRUCTORSDataGridView.DataSource = InstructorBindSource
    End Sub

    Public Sub setMode(strMode As String)
        'CONTROL THE DISPLAY OF LIST VS DETAIL OF InstructorS

        If strMode = "L" Then
            'MODE IS LIST

            Me.gbInstructorDetail.Hide()
            Me.gbInstructorList.Left = 0
            Me.gbInstructorList.Top = 0
            Me.Width = gbInstructorList.Width + 50
            Me.Height = gbInstructorList.Height + 50

            Me.gbInstructorList.Visible = True
        Else
            'MODE IS DETAIL

            Me.gbInstructorList.Hide()
            Me.gbInstructorDetail.Left = 0
            Me.gbInstructorDetail.Top = 0
            Me.Width = gbInstructorDetail.Width + 50
            Me.Height = gbInstructorDetail.Height + 50

            Me.gbInstructorDetail.Visible = True
        End If
    End Sub

    'List Mode
    'Adding a new Instructor
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.setMode("D")
        Me.PROF_IDTextBox.Focus()
    End Sub

    'Updating an existing Instructor
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim row As DataGridViewRow = Me.CPP_INSTRUCTORSDataGridView.CurrentRow

        If IsNothing(row) Then
            MessageBox.Show("Nothing is selected!")
            Exit Sub
        End If

        'Convert the current row into an object then transfer the data into textboxes
        Dim aInstructor As clsInstructor = TryCast(row.DataBoundItem, clsInstructor)

        Me.PROF_IDTextBox.Text = aInstructor.profID
        Me.FIRST_NAMETextBox.Text = aInstructor.firstName
        Me.LAST_NAMETextBox.Text = aInstructor.lastName
        Me.PHONETextBox.Text = aInstructor.phone
        Me.DEPARTMENTTextBox.Text = aInstructor.department

        Me.PROF_IDTextBox.Focus()

        'Save button is changed to update
        Me.btnSave.Text = "&Update"

        Me.setMode("D")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim row As DataGridViewRow = Me.CPP_INSTRUCTORSDataGridView.CurrentRow

        If IsNothing(row) Then
            MessageBox.Show("Nothing is selected!")
            Exit Sub
        End If

        Dim aInstructor As clsInstructor = TryCast(row.DataBoundItem, clsInstructor)

        'Delete the following instructor from the DB

        CPP_DB.dbOpen()
        CPP_DB.deleteInstructor(aInstructor.profID)
        CPP_DB.dbClose()

        If CPP_DB.dbGetError = "" Then
            MessageBox.Show("Instructor deleted!!")

            For Each instructor In instructorList
                If instructor.profID = aInstructor.profID Then
                    instructorList.Remove(instructor)
                    Exit For
                End If
            Next
            refreshDataGrid()
        Else
            MessageBox.Show(CPP_DB.dbGetError)
        End If
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Dim strProfId As String = InputBox("Enter the id of the professor you want to find")

        For Each row As DataGridViewRow In CPP_INSTRUCTORSDataGridView.Rows
            If row.Cells(0).Value = strProfId Then
                row.Selected = True
                MessageBox.Show("We have found the following for id:" & strProfId & ".")
                Exit Sub
            End If
        Next

        MessageBox.Show("We have not found the id of the instructor you are looking for")
    End Sub


    'Detail Mode
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim aInstructor As New clsInstructor()

        aInstructor.profID = Me.PROF_IDTextBox.Text
        aInstructor.firstName = Me.FIRST_NAMETextBox.Text
        aInstructor.lastName = Me.LAST_NAMETextBox.Text
        aInstructor.phone = Me.PHONETextBox.Text
        aInstructor.department = Me.DEPARTMENTTextBox.Text

        'Default save function
        If (btnSave.Text = "&Save") Then

            CPP_DB.dbOpen()
            CPP_DB.insertInstructor(aInstructor)
            CPP_DB.dbClose()

            If CPP_DB.dbGetError <> "" Then
                MessageBox.Show(CPP_DB.dbGetError)
            Else
                InstructorList.add(aInstructor)
                refreshDataGrid()
                MessageBox.Show("Instructor saved!")
                Me.setMode("L")
            End If
        Else

            'Update Instructor if there is already an instructor
            CPP_DB.dbOpen()
            CPP_DB.updateInstructor(aInstructor)
            CPP_DB.dbClose()

            If CPP_DB.dbGetError <> "" Then
                MessageBox.Show(CPP_DB.dbGetError)
            Else
                'Remove and replace instructor from the list
                For Each instructor In instructorList
                    If instructor.profID = aInstructor.profID Then
                        instructorList.Remove(instructor)
                        Exit For
                    End If
                Next
                instructorList.Add(aInstructor)
                refreshDataGrid()
                MessageBox.Show("Instructor Updated!")
                Me.setMode("L")
                Me.btnSave.Text = "&Save"
            End If

        End If
    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Clear the form
        For Each ctrl In gbInstructorDetail.Controls
            If TypeOf (ctrl) Is TextBox Then
                TryCast(ctrl, TextBox).Clear()
            End If
        Next

        btnSave.Text = "&Save"

        setMode("L")
    End Sub

  
End Class