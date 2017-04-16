<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInstructor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim PROF_IDLabel As System.Windows.Forms.Label
        Dim FIRST_NAMELabel As System.Windows.Forms.Label
        Dim LAST_NAMELabel As System.Windows.Forms.Label
        Dim PHONELabel As System.Windows.Forms.Label
        Dim DEPARTMENTLabel As System.Windows.Forms.Label
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.PROF_IDTextBox = New System.Windows.Forms.TextBox()
        Me.FIRST_NAMETextBox = New System.Windows.Forms.TextBox()
        Me.LAST_NAMETextBox = New System.Windows.Forms.TextBox()
        Me.PHONETextBox = New System.Windows.Forms.TextBox()
        Me.DEPARTMENTTextBox = New System.Windows.Forms.TextBox()
        Me.CPP_INSTRUCTORSDataGridView = New System.Windows.Forms.DataGridView()
        Me.gbInstructorList = New System.Windows.Forms.GroupBox()
        Me.gbInstructorDetail = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.CPPDataSet = New CPP.CPPDataSet()
        Me.CPPDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CPPINSTRUCTORSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CPP_INSTRUCTORSTableAdapter = New CPP.CPPDataSetTableAdapters.CPP_INSTRUCTORSTableAdapter()
        PROF_IDLabel = New System.Windows.Forms.Label()
        FIRST_NAMELabel = New System.Windows.Forms.Label()
        LAST_NAMELabel = New System.Windows.Forms.Label()
        PHONELabel = New System.Windows.Forms.Label()
        DEPARTMENTLabel = New System.Windows.Forms.Label()
        CType(Me.CPP_INSTRUCTORSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbInstructorList.SuspendLayout()
        Me.gbInstructorDetail.SuspendLayout()
        CType(Me.CPPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CPPDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CPPINSTRUCTORSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PROF_IDLabel
        '
        PROF_IDLabel.AutoSize = True
        PROF_IDLabel.Location = New System.Drawing.Point(44, 38)
        PROF_IDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PROF_IDLabel.Name = "PROF_IDLabel"
        PROF_IDLabel.Size = New System.Drawing.Size(67, 17)
        PROF_IDLabel.TabIndex = 27
        PROF_IDLabel.Text = "PROF ID:"
        '
        'FIRST_NAMELabel
        '
        FIRST_NAMELabel.AutoSize = True
        FIRST_NAMELabel.Location = New System.Drawing.Point(44, 70)
        FIRST_NAMELabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FIRST_NAMELabel.Name = "FIRST_NAMELabel"
        FIRST_NAMELabel.Size = New System.Drawing.Size(94, 17)
        FIRST_NAMELabel.TabIndex = 29
        FIRST_NAMELabel.Text = "FIRST NAME:"
        '
        'LAST_NAMELabel
        '
        LAST_NAMELabel.AutoSize = True
        LAST_NAMELabel.Location = New System.Drawing.Point(44, 102)
        LAST_NAMELabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        LAST_NAMELabel.Name = "LAST_NAMELabel"
        LAST_NAMELabel.Size = New System.Drawing.Size(90, 17)
        LAST_NAMELabel.TabIndex = 31
        LAST_NAMELabel.Text = "LAST NAME:"
        '
        'PHONELabel
        '
        PHONELabel.AutoSize = True
        PHONELabel.Location = New System.Drawing.Point(44, 134)
        PHONELabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PHONELabel.Name = "PHONELabel"
        PHONELabel.Size = New System.Drawing.Size(61, 17)
        PHONELabel.TabIndex = 33
        PHONELabel.Text = "PHONE:"
        '
        'DEPARTMENTLabel
        '
        DEPARTMENTLabel.AutoSize = True
        DEPARTMENTLabel.Location = New System.Drawing.Point(44, 166)
        DEPARTMENTLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DEPARTMENTLabel.Name = "DEPARTMENTLabel"
        DEPARTMENTLabel.Size = New System.Drawing.Size(107, 17)
        DEPARTMENTLabel.TabIndex = 35
        DEPARTMENTLabel.Text = "DEPARTMENT:"
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(395, 319)
        Me.btnFind.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(108, 28)
        Me.btnFind.TabIndex = 26
        Me.btnFind.Text = "&Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(267, 319)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(108, 28)
        Me.btnDelete.TabIndex = 25
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(24, 319)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(108, 28)
        Me.btnAdd.TabIndex = 23
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(144, 319)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(108, 28)
        Me.btnUpdate.TabIndex = 24
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'PROF_IDTextBox
        '
        Me.PROF_IDTextBox.Location = New System.Drawing.Point(165, 34)
        Me.PROF_IDTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PROF_IDTextBox.Name = "PROF_IDTextBox"
        Me.PROF_IDTextBox.Size = New System.Drawing.Size(132, 22)
        Me.PROF_IDTextBox.TabIndex = 28
        '
        'FIRST_NAMETextBox
        '
        Me.FIRST_NAMETextBox.Location = New System.Drawing.Point(165, 66)
        Me.FIRST_NAMETextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.FIRST_NAMETextBox.Name = "FIRST_NAMETextBox"
        Me.FIRST_NAMETextBox.Size = New System.Drawing.Size(316, 22)
        Me.FIRST_NAMETextBox.TabIndex = 30
        '
        'LAST_NAMETextBox
        '
        Me.LAST_NAMETextBox.Location = New System.Drawing.Point(165, 98)
        Me.LAST_NAMETextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.LAST_NAMETextBox.Name = "LAST_NAMETextBox"
        Me.LAST_NAMETextBox.Size = New System.Drawing.Size(316, 22)
        Me.LAST_NAMETextBox.TabIndex = 32
        '
        'PHONETextBox
        '
        Me.PHONETextBox.Location = New System.Drawing.Point(165, 130)
        Me.PHONETextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PHONETextBox.Name = "PHONETextBox"
        Me.PHONETextBox.Size = New System.Drawing.Size(132, 22)
        Me.PHONETextBox.TabIndex = 34
        '
        'DEPARTMENTTextBox
        '
        Me.DEPARTMENTTextBox.Location = New System.Drawing.Point(165, 162)
        Me.DEPARTMENTTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DEPARTMENTTextBox.Name = "DEPARTMENTTextBox"
        Me.DEPARTMENTTextBox.Size = New System.Drawing.Size(132, 22)
        Me.DEPARTMENTTextBox.TabIndex = 36
        '
        'CPP_INSTRUCTORSDataGridView
        '
        Me.CPP_INSTRUCTORSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CPP_INSTRUCTORSDataGridView.Location = New System.Drawing.Point(24, 41)
        Me.CPP_INSTRUCTORSDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.CPP_INSTRUCTORSDataGridView.Name = "CPP_INSTRUCTORSDataGridView"
        Me.CPP_INSTRUCTORSDataGridView.Size = New System.Drawing.Size(853, 271)
        Me.CPP_INSTRUCTORSDataGridView.TabIndex = 36
        '
        'gbInstructorList
        '
        Me.gbInstructorList.Controls.Add(Me.CPP_INSTRUCTORSDataGridView)
        Me.gbInstructorList.Controls.Add(Me.btnFind)
        Me.gbInstructorList.Controls.Add(Me.btnDelete)
        Me.gbInstructorList.Controls.Add(Me.btnAdd)
        Me.gbInstructorList.Controls.Add(Me.btnUpdate)
        Me.gbInstructorList.Location = New System.Drawing.Point(16, 289)
        Me.gbInstructorList.Margin = New System.Windows.Forms.Padding(4)
        Me.gbInstructorList.Name = "gbInstructorList"
        Me.gbInstructorList.Padding = New System.Windows.Forms.Padding(4)
        Me.gbInstructorList.Size = New System.Drawing.Size(917, 359)
        Me.gbInstructorList.TabIndex = 37
        Me.gbInstructorList.TabStop = False
        Me.gbInstructorList.Text = "Instructor List Information"
        '
        'gbInstructorDetail
        '
        Me.gbInstructorDetail.Controls.Add(Me.btnCancel)
        Me.gbInstructorDetail.Controls.Add(Me.btnSave)
        Me.gbInstructorDetail.Controls.Add(PROF_IDLabel)
        Me.gbInstructorDetail.Controls.Add(Me.PROF_IDTextBox)
        Me.gbInstructorDetail.Controls.Add(FIRST_NAMELabel)
        Me.gbInstructorDetail.Controls.Add(Me.FIRST_NAMETextBox)
        Me.gbInstructorDetail.Controls.Add(LAST_NAMELabel)
        Me.gbInstructorDetail.Controls.Add(Me.LAST_NAMETextBox)
        Me.gbInstructorDetail.Controls.Add(PHONELabel)
        Me.gbInstructorDetail.Controls.Add(Me.PHONETextBox)
        Me.gbInstructorDetail.Controls.Add(DEPARTMENTLabel)
        Me.gbInstructorDetail.Controls.Add(Me.DEPARTMENTTextBox)
        Me.gbInstructorDetail.Location = New System.Drawing.Point(16, 15)
        Me.gbInstructorDetail.Margin = New System.Windows.Forms.Padding(4)
        Me.gbInstructorDetail.Name = "gbInstructorDetail"
        Me.gbInstructorDetail.Padding = New System.Windows.Forms.Padding(4)
        Me.gbInstructorDetail.Size = New System.Drawing.Size(753, 267)
        Me.gbInstructorDetail.TabIndex = 38
        Me.gbInstructorDetail.TabStop = False
        Me.gbInstructorDetail.Text = "Instructor Information"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(277, 219)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 28)
        Me.btnCancel.TabIndex = 38
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(165, 219)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 28)
        Me.btnSave.TabIndex = 37
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'CPPDataSet
        '
        Me.CPPDataSet.DataSetName = "CPPDataSet"
        Me.CPPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CPPDataSetBindingSource
        '
        Me.CPPDataSetBindingSource.DataSource = Me.CPPDataSet
        Me.CPPDataSetBindingSource.Position = 0
        '
        'CPPINSTRUCTORSBindingSource
        '
        Me.CPPINSTRUCTORSBindingSource.DataMember = "CPP_INSTRUCTORS"
        Me.CPPINSTRUCTORSBindingSource.DataSource = Me.CPPDataSetBindingSource
        '
        'CPP_INSTRUCTORSTableAdapter
        '
        Me.CPP_INSTRUCTORSTableAdapter.ClearBeforeFill = True
        '
        'frmInstructor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 661)
        Me.Controls.Add(Me.gbInstructorDetail)
        Me.Controls.Add(Me.gbInstructorList)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmInstructor"
        Me.Text = "CPP INSTRUCTOR INFORMATION"
        CType(Me.CPP_INSTRUCTORSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbInstructorList.ResumeLayout(False)
        Me.gbInstructorDetail.ResumeLayout(False)
        Me.gbInstructorDetail.PerformLayout()
        CType(Me.CPPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CPPDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CPPINSTRUCTORSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents PROF_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FIRST_NAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents LAST_NAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents PHONETextBox As System.Windows.Forms.TextBox
    Friend WithEvents DEPARTMENTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CPP_INSTRUCTORSDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents gbInstructorList As System.Windows.Forms.GroupBox
    Friend WithEvents gbInstructorDetail As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents CPPDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CPPDataSet As CPP.CPPDataSet
    Friend WithEvents CPPINSTRUCTORSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CPP_INSTRUCTORSTableAdapter As CPP.CPPDataSetTableAdapters.CPP_INSTRUCTORSTableAdapter
End Class
