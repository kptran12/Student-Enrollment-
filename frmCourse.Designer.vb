<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCourse
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
        Dim COURSE_IDLabel As System.Windows.Forms.Label
        Dim DESCRIPTIONLabel As System.Windows.Forms.Label
        Dim UNITSLabel As System.Windows.Forms.Label
        Me.CPP_COURSESDataGridView = New System.Windows.Forms.DataGridView()
        Me.COURSE_IDTextBox = New System.Windows.Forms.TextBox()
        Me.DESCRIPTIONTextBox = New System.Windows.Forms.TextBox()
        Me.UNITSTextBox = New System.Windows.Forms.TextBox()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.gbCourseList = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.gbCourseDetail = New System.Windows.Forms.GroupBox()
        COURSE_IDLabel = New System.Windows.Forms.Label()
        DESCRIPTIONLabel = New System.Windows.Forms.Label()
        UNITSLabel = New System.Windows.Forms.Label()
        CType(Me.CPP_COURSESDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCourseList.SuspendLayout()
        Me.gbCourseDetail.SuspendLayout()
        Me.SuspendLayout()
        '
        'COURSE_IDLabel
        '
        COURSE_IDLabel.AutoSize = True
        COURSE_IDLabel.Location = New System.Drawing.Point(36, 52)
        COURSE_IDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        COURSE_IDLabel.Name = "COURSE_IDLabel"
        COURSE_IDLabel.Size = New System.Drawing.Size(87, 17)
        COURSE_IDLabel.TabIndex = 2
        COURSE_IDLabel.Text = "COURSE ID:"
        '
        'DESCRIPTIONLabel
        '
        DESCRIPTIONLabel.AutoSize = True
        DESCRIPTIONLabel.Location = New System.Drawing.Point(36, 84)
        DESCRIPTIONLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DESCRIPTIONLabel.Name = "DESCRIPTIONLabel"
        DESCRIPTIONLabel.Size = New System.Drawing.Size(104, 17)
        DESCRIPTIONLabel.TabIndex = 4
        DESCRIPTIONLabel.Text = "DESCRIPTION:"
        '
        'UNITSLabel
        '
        UNITSLabel.AutoSize = True
        UNITSLabel.Location = New System.Drawing.Point(36, 116)
        UNITSLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        UNITSLabel.Name = "UNITSLabel"
        UNITSLabel.Size = New System.Drawing.Size(53, 17)
        UNITSLabel.TabIndex = 6
        UNITSLabel.Text = "UNITS:"
        '
        'CPP_COURSESDataGridView
        '
        Me.CPP_COURSESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CPP_COURSESDataGridView.Location = New System.Drawing.Point(55, 42)
        Me.CPP_COURSESDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.CPP_COURSESDataGridView.Name = "CPP_COURSESDataGridView"
        Me.CPP_COURSESDataGridView.Size = New System.Drawing.Size(721, 271)
        Me.CPP_COURSESDataGridView.TabIndex = 1
        '
        'COURSE_IDTextBox
        '
        Me.COURSE_IDTextBox.Location = New System.Drawing.Point(155, 48)
        Me.COURSE_IDTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.COURSE_IDTextBox.Name = "COURSE_IDTextBox"
        Me.COURSE_IDTextBox.Size = New System.Drawing.Size(132, 22)
        Me.COURSE_IDTextBox.TabIndex = 3
        '
        'DESCRIPTIONTextBox
        '
        Me.DESCRIPTIONTextBox.Location = New System.Drawing.Point(155, 80)
        Me.DESCRIPTIONTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DESCRIPTIONTextBox.Name = "DESCRIPTIONTextBox"
        Me.DESCRIPTIONTextBox.Size = New System.Drawing.Size(467, 22)
        Me.DESCRIPTIONTextBox.TabIndex = 5
        '
        'UNITSTextBox
        '
        Me.UNITSTextBox.Location = New System.Drawing.Point(155, 112)
        Me.UNITSTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.UNITSTextBox.Name = "UNITSTextBox"
        Me.UNITSTextBox.Size = New System.Drawing.Size(132, 22)
        Me.UNITSTextBox.TabIndex = 7
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(421, 338)
        Me.btnFind.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(100, 28)
        Me.btnFind.TabIndex = 22
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(293, 338)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 28)
        Me.btnDelete.TabIndex = 21
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(171, 338)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(100, 28)
        Me.btnUpdate.TabIndex = 20
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(51, 338)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 28)
        Me.btnAdd.TabIndex = 19
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'gbCourseList
        '
        Me.gbCourseList.Controls.Add(Me.CPP_COURSESDataGridView)
        Me.gbCourseList.Controls.Add(Me.btnFind)
        Me.gbCourseList.Controls.Add(Me.btnDelete)
        Me.gbCourseList.Controls.Add(Me.btnAdd)
        Me.gbCourseList.Controls.Add(Me.btnUpdate)
        Me.gbCourseList.Location = New System.Drawing.Point(48, 327)
        Me.gbCourseList.Margin = New System.Windows.Forms.Padding(4)
        Me.gbCourseList.Name = "gbCourseList"
        Me.gbCourseList.Padding = New System.Windows.Forms.Padding(4)
        Me.gbCourseList.Size = New System.Drawing.Size(809, 396)
        Me.gbCourseList.TabIndex = 23
        Me.gbCourseList.TabStop = False
        Me.gbCourseList.Text = "Course List Information"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(181, 175)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 28)
        Me.btnCancel.TabIndex = 26
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(47, 175)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 28)
        Me.btnSave.TabIndex = 25
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'gbCourseDetail
        '
        Me.gbCourseDetail.Controls.Add(Me.btnCancel)
        Me.gbCourseDetail.Controls.Add(Me.btnSave)
        Me.gbCourseDetail.Controls.Add(COURSE_IDLabel)
        Me.gbCourseDetail.Controls.Add(Me.COURSE_IDTextBox)
        Me.gbCourseDetail.Controls.Add(DESCRIPTIONLabel)
        Me.gbCourseDetail.Controls.Add(Me.DESCRIPTIONTextBox)
        Me.gbCourseDetail.Controls.Add(UNITSLabel)
        Me.gbCourseDetail.Controls.Add(Me.UNITSTextBox)
        Me.gbCourseDetail.Location = New System.Drawing.Point(48, 55)
        Me.gbCourseDetail.Margin = New System.Windows.Forms.Padding(4)
        Me.gbCourseDetail.Name = "gbCourseDetail"
        Me.gbCourseDetail.Padding = New System.Windows.Forms.Padding(4)
        Me.gbCourseDetail.Size = New System.Drawing.Size(809, 265)
        Me.gbCourseDetail.TabIndex = 27
        Me.gbCourseDetail.TabStop = False
        Me.gbCourseDetail.Text = "Course Information"
        '
        'frmCourse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 784)
        Me.Controls.Add(Me.gbCourseDetail)
        Me.Controls.Add(Me.gbCourseList)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmCourse"
        Me.Text = "CPP COURSE INFORMATION"
        CType(Me.CPP_COURSESDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCourseList.ResumeLayout(False)
        Me.gbCourseDetail.ResumeLayout(False)
        Me.gbCourseDetail.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CPP_COURSESDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents COURSE_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DESCRIPTIONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UNITSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents gbCourseList As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents gbCourseDetail As System.Windows.Forms.GroupBox
End Class
