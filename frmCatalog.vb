Imports System.Data.SqlClient

Public Class frmCatalog

    Dim catalogList As New List(Of clsCatalog)
    Dim courseList As New List(Of clsCourse)
    Dim instructorList As New List(Of clsInstructor)
    'Load the gridview 
    Private Sub frmCatalog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CPP_DB.dbOpen()
        catalogList = CPP_DB.loadCatalog()
        CPP_DB.dbClose()


        'Course combobox load
        CPP_DB.dbOpen()
        courseList = CPP_DB.loadCourses()
        CPP_DB.dbClose()

        Dim courseInfo As New List(Of String)

        For Each aCourse As clsCourse In courseList
            courseInfo.Add(aCourse.courseID & " - " & aCourse.desc)
        Next

        COURSE_IDComboBox.DataSource = courseInfo

        'Instructor combobox load
        CPP_DB.dbOpen()
        instructorList = CPP_DB.loadInstructors()
        CPP_DB.dbClose()

        Dim instructorInfo As New List(Of String)

        For Each aInstructor As clsInstructor In instructorList
            instructorInfo.Add(aInstructor.profID & " - " & aInstructor.lastName & " , " & aInstructor.firstName)
        Next

        PROF_IDComboBox.DataSource = instructorInfo

        If (CPP_DB.dbGetError = "") Then
            refreshDataGrid()
        Else
            MessageBox.Show(CPP_DB.dbGetError)
        End If




    End Sub

    Public Sub setMode(strMode As String)
        'CONTROL THE DISPLAY OF LIST VS DETAIL OF CatalogS

        If strMode = "L" Then
            'MODE IS LIST

            Me.gbCatalogDetail.Hide()
            Me.gbCatalogList.Left = 0
            Me.gbCatalogList.Top = 0
            Me.Width = gbCatalogList.Width + 50
            Me.Height = gbCatalogList.Height + 50

            Me.gbCatalogList.Visible = True
        Else
            'MODE IS DETAIL

            Me.gbCatalogList.Hide()
            Me.gbCatalogDetail.Left = 0
            Me.gbCatalogDetail.Top = 0
            Me.Width = gbCatalogDetail.Width + 50
            Me.Height = gbCatalogDetail.Height + 50

            Me.gbCatalogDetail.Visible = True
        End If
    End Sub

    'Update grid
    Private Sub refreshDataGrid()
        Dim CatalogBindSource As New BindingSource

        CatalogBindSource.DataSource = catalogList

        Me.CPP_CATALOGDataGridView.DataSource = CatalogBindSource
    End Sub

 

    'List Mode
    'Add
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.setMode("D")
        Me.CATALOG_IDTextBox.Focus()
    End Sub

    'Update
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim row As DataGridViewRow = Me.CPP_CATALOGDataGridView.CurrentRow

        If IsNothing(row) Then
            MessageBox.Show("Nothing is selected!")
            Exit Sub
        End If

        Dim aCatalog As clsCatalog = TryCast(row.DataBoundItem, clsCatalog)

        Me.CATALOG_IDTextBox.Text = aCatalog.catalogID
        Me.YEARTextBox.Text = aCatalog.year
        Me.QUARTERComboBox.SelectedItem = aCatalog.quarter
        Me.COURSE_IDComboBox.SelectedItem = Me.COURSE_IDComboBox.FindString(aCatalog.courseId)
        Me.PROF_IDComboBox.SelectedItem = Me.PROF_IDComboBox.FindString(aCatalog.profId)

        Me.btnSave.Text = "&Update"

        Me.setMode("D")
    End Sub

    'Delete
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim row As DataGridViewRow = Me.CPP_CATALOGDataGridView.CurrentRow

        If IsNothing(row) Then
            MessageBox.Show("Nothing is selected!")
            Exit Sub
        End If

        Dim aCatalog As clsCatalog = TryCast(row.DataBoundItem, clsCatalog)

        If CPP_DB.dbGetError = "" Then
            MessageBox.Show("Catalog entry deleted!")

            For Each catalog In catalogList
                If catalog.catalogID = aCatalog.catalogID Then
                    catalogList.Remove(catalog)
                    Exit For
                End If
            Next
            refreshDataGrid()
        Else
            MessageBox.Show(CPP_DB.dbGetError)
        End If

    End Sub

    'Find
    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Dim strCatalogId As String = InputBox("Enter the id of the catalog entry you are looking for: ")

        For Each row As DataGridViewRow In CPP_CATALOGDataGridView.Rows
            If row.Cells(0).Value = strCatalogId Then
                row.Selected = True
                MessageBox.Show("We have found the following for catalog id, " & strCatalogId & ".")
                Exit Sub
            End If
        Next

        MessageBox.Show("We have not found the id of the catalog id you are looking for.")
    End Sub

    'Detail Mode
    'Save
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim aCatalog As New clsCatalog()

        aCatalog.catalogID = Me.CATALOG_IDTextBox.Text
        aCatalog.year = Me.YEARTextBox.Text
        aCatalog.quarter = Me.QUARTERComboBox.SelectedItem
        aCatalog.courseId = Trim(Me.COURSE_IDComboBox.SelectedItem.Split("-").GetValue(0))
        aCatalog.profId = Trim(Me.PROF_IDComboBox.SelectedItem.Split("-").GetValue(0))

        'Default Save Function
        If (btnSave.Text = "&Save") Then
            CPP_DB.dbOpen()
            CPP_DB.insertCatalog(aCatalog)
            CPP_DB.dbClose()

            If CPP_DB.dbGetError <> "" Then
                MessageBox.Show(CPP_DB.dbGetError)
            Else
                catalogList.Add(aCatalog)
                refreshDataGrid()
                MessageBox.Show("Catalog entry saved!")
                Me.setMode("L")
            End If

        Else

            'Update course when one already exists
            CPP_DB.dbOpen()
            CPP_DB.updateCatalog(aCatalog)
            CPP_DB.dbClose()

            If CPP_DB.dbGetError <> "" Then
                MessageBox.Show(CPP_DB.dbGetError)
            Else
                For Each catalog In catalogList
                    If catalog.catalogID = aCatalog.catalogID Then
                        catalogList.Remove(catalog)
                        Exit For
                    End If
                Next
                catalogList.Add(aCatalog)
                refreshDataGrid()
                MessageBox.Show("Catalog updated!")
                Me.setMode("L")
                Me.btnSave.Text = "&Save"
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        For Each ctrl In gbCatalogDetail.Controls
            If TypeOf (ctrl) Is TextBox Then
                TryCast(ctrl, TextBox).Clear()
            ElseIf TypeOf (ctrl) Is ComboBox Then
                TryCast(ctrl, ComboBox).SelectedIndex = -1
            End If
        Next

        btnSave.Text = "&Save"

        setMode("L")

    End Sub


 

End Class