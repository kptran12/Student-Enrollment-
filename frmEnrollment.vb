Public Class frmEnrollment
    Dim enrollList As New List(Of clsEnrollment)

    'Create lists for the comboboxes
    Dim studentList As New List(Of clsStudent)
    Dim catalogList As New List(Of clsCatalog)
    'Load the data
    Private Sub frmEnrollment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CPP_DB.dbOpen()
        enrollList = CPP_DB.loadEnroll()
        CPP_DB.dbClose()

        'Student combobox load
        CPP_DB.dbOpen()
        studentList = CPP_DB.loadStudents()
        CPP_DB.dbClose()

        Dim studentInfo As New List(Of String)

        For Each aStudent As clsStudent In studentList
            studentInfo.Add(aStudent.broncoID & " - " & aStudent.lastName & " , " & aStudent.firstName)
        Next

        BRONCO_IDComboBox.DataSource = studentInfo

        'Catalog combobox load
        CPP_DB.dbOpen()
        catalogList = CPP_DB.loadCatalog()
        CPP_DB.dbClose()

        Dim catalogInfo As New List(Of String)

        For Each aCatalog As clsCatalog In catalogList
            catalogInfo.Add(aCatalog.catalogID & " - " & " ( " & aCatalog.year & " , " & aCatalog.quarter & " , " & aCatalog.courseId & ")")
        Next

        CATALOG_IDComboBox.DataSource = catalogInfo

        If (CPP_DB.dbGetError = "") Then
            refreshDataGrid()
        Else
            MessageBox.Show(CPP_DB.dbGetError)
        End If
    End Sub


    Public Sub setMode(strMode As String)
        'CONTROL THE DISPLAY OF LIST VS DETAIL OF EnrollmentS

        If strMode = "L" Then
            'MODE IS LIST

            Me.gbEnrollmentDetail.Hide()
            Me.gbEnrollmentList.Left = 0
            Me.gbEnrollmentList.Top = 0
            Me.Width = gbEnrollmentList.Width + 50
            Me.Height = gbEnrollmentList.Height + 50

            Me.gbEnrollmentList.Visible = True
        Else
            'MODE IS DETAIL

            Me.gbEnrollmentList.Hide()
            Me.gbEnrollmentDetail.Left = 0
            Me.gbEnrollmentDetail.Top = 0
            Me.Width = gbEnrollmentDetail.Width + 50
            Me.Height = gbEnrollmentDetail.Height + 50

            Me.gbEnrollmentDetail.Visible = True
        End If
    End Sub

    'Update grid
    Private Sub refreshDataGrid()
        Dim EnrollBindSource As New BindingSource

        EnrollBindSource.DataSource = enrollList

        Me.CPP_ENROLLMENTDataGridView.DataSource = EnrollBindSource
    End Sub

    'Add
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.setMode("D")
        Me.BRONCO_IDComboBox.Focus()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim row As DataGridViewRow = Me.CPP_ENROLLMENTDataGridView.CurrentRow

        If IsNothing(row) Then
            MessageBox.Show("Nothing is selected!")
            Exit Sub
        End If

        Dim aEnrollment As clsEnrollment = TryCast(row.DataBoundItem, clsEnrollment)

        Me.BRONCO_IDComboBox.SelectedItem = Me.BRONCO_IDComboBox.FindString(aEnrollment.broncoId)
        Me.CATALOG_IDComboBox.SelectedItem = Me.CATALOG_IDComboBox.FindString(aEnrollment.catalogID)

        Me.btnSave.Text = "&Update"

        Me.setMode("D")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim row As DataGridViewRow = Me.CPP_ENROLLMENTDataGridView.CurrentRow

        If IsNothing(row) Then
            MessageBox.Show("Nothing is selected!")
            Exit Sub
        End If

        Dim aEnrollment As clsEnrollment = TryCast(row.DataBoundItem, clsEnrollment)

        If CPP_DB.dbGetError = "" Then
            MessageBox.Show("Enrollment entry has been deleted!")

            For Each enrollment In enrollList
                If (enrollment.broncoId = aEnrollment.broncoId) And (enrollment.catalogID = aEnrollment.catalogID) Then
                    enrollList.Remove(enrollment)
                    Exit For
                End If
            Next
            refreshDataGrid()
        Else
            MessageBox.Show(CPP_DB.dbGetError)
        End If
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Dim strBroncoId As String = InputBox("Enter the bronco id of the entry you are searching for")

        For Each row As DataGridViewRow In CPP_ENROLLMENTDataGridView.Rows
            If row.Cells(0).Value = strBroncoId Then
                row.Selected = True
                MessageBox.Show("We have found the following for Bronco Id, " & strBroncoId & ".")
                Exit Sub
            End If
        Next

        MessageBox.Show("We have not found an enrollment entry match for the Bronco ID you have entered.")
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim aEnrollment As New clsEnrollment()

        aEnrollment.broncoId = Trim(Me.BRONCO_IDComboBox.SelectedItem.Split("-").getValue(0))
        aEnrollment.catalogID = Trim(Me.CATALOG_IDComboBox.SelectedItem.Split("-").getValue(0))

        'Default save
        If (btnSave.Text = "&Save") Then
            CPP_DB.dbOpen()
            CPP_DB.insertEnroll(aEnrollment)
            CPP_DB.dbClose()

            If CPP_DB.dbGetError <> "" Then
                MessageBox.Show(CPP_DB.dbGetError)
            Else
                enrollList.Add(aEnrollment)
                refreshDataGrid()
                MessageBox.Show("Enrollment entry saved!")
                Me.setMode("L")
            End If
        Else

            'Update an existing enrollment entry
            CPP_DB.dbOpen()
            CPP_DB.updateEnroll(aEnrollment)
            CPP_DB.dbClose()

            If CPP_DB.dbGetError <> "" Then
                MessageBox.Show(CPP_DB.dbGetError)
            Else
                For Each enrollment In enrollList
                    If enrollment.broncoId = aEnrollment.broncoId Then
                        enrollList.Remove(enrollment)
                        Exit For
                    End If
                Next
                enrollList.Add(aEnrollment)
                refreshDataGrid()
                MessageBox.Show("Enrollment entry updated!")
                Me.setMode("L")
                Me.btnSave.Text = "&Save"
            End If
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        setMode("L")
    End Sub

 
    
   
  
End Class