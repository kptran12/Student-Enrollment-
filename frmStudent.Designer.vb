<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudent
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

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim BRONCO_IDLabel As System.Windows.Forms.Label
        Dim FIRST_NAMELabel As System.Windows.Forms.Label
        Dim LAST_NAMELabel As System.Windows.Forms.Label
        Dim PHONELabel As System.Windows.Forms.Label
        Dim EMAILLabel As System.Windows.Forms.Label
        Me.CPP_STUDENTSDataGridView = New System.Windows.Forms.DataGridView()
        Me.BRONCO_IDTextBox = New System.Windows.Forms.TextBox()
        Me.FIRST_NAMETextBox = New System.Windows.Forms.TextBox()
        Me.LAST_NAMETextBox = New System.Windows.Forms.TextBox()
        Me.PHONETextBox = New System.Windows.Forms.TextBox()
        Me.EMAILTextBox = New System.Windows.Forms.TextBox()
        Me.gbStudentList = New System.Windows.Forms.GroupBox()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.gbStudentDetail = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        BRONCO_IDLabel = New System.Windows.Forms.Label()
        FIRST_NAMELabel = New System.Windows.Forms.Label()
        LAST_NAMELabel = New System.Windows.Forms.Label()
        PHONELabel = New System.Windows.Forms.Label()
        EMAILLabel = New System.Windows.Forms.Label()
        CType(Me.CPP_STUDENTSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbStudentList.SuspendLayout()
        Me.gbStudentDetail.SuspendLayout()
        Me.SuspendLayout()
        '
        'BRONCO_IDLabel
        '
        BRONCO_IDLabel.AutoSize = True
        BRONCO_IDLabel.Location = New System.Drawing.Point(25, 44)
        BRONCO_IDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        BRONCO_IDLabel.Name = "BRONCO_IDLabel"
        BRONCO_IDLabel.Size = New System.Drawing.Size(89, 17)
        BRONCO_IDLabel.TabIndex = 2
        BRONCO_IDLabel.Text = "BRONCO ID:"
        '
        'FIRST_NAMELabel
        '
        FIRST_NAMELabel.AutoSize = True
        FIRST_NAMELabel.Location = New System.Drawing.Point(25, 76)
        FIRST_NAMELabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FIRST_NAMELabel.Name = "FIRST_NAMELabel"
        FIRST_NAMELabel.Size = New System.Drawing.Size(94, 17)
        FIRST_NAMELabel.TabIndex = 4
        FIRST_NAMELabel.Text = "FIRST NAME:"
        '
        'LAST_NAMELabel
        '
        LAST_NAMELabel.AutoSize = True
        LAST_NAMELabel.Location = New System.Drawing.Point(25, 108)
        LAST_NAMELabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        LAST_NAMELabel.Name = "LAST_NAMELabel"
        LAST_NAMELabel.Size = New System.Drawing.Size(90, 17)
        LAST_NAMELabel.TabIndex = 6
        LAST_NAMELabel.Text = "LAST NAME:"
        '
        'PHONELabel
        '
        PHONELabel.AutoSize = True
        PHONELabel.Location = New System.Drawing.Point(25, 140)
        PHONELabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PHONELabel.Name = "PHONELabel"
        PHONELabel.Size = New System.Drawing.Size(61, 17)
        PHONELabel.TabIndex = 8
        PHONELabel.Text = "PHONE:"
        '
        'EMAILLabel
        '
        EMAILLabel.AutoSize = True
        EMAILLabel.Location = New System.Drawing.Point(25, 172)
        EMAILLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EMAILLabel.Name = "EMAILLabel"
        EMAILLabel.Size = New System.Drawing.Size(52, 17)
        EMAILLabel.TabIndex = 10
        EMAILLabel.Text = "EMAIL:"
        '
        'CPP_STUDENTSDataGridView
        '
        Me.CPP_STUDENTSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CPP_STUDENTSDataGridView.Location = New System.Drawing.Point(24, 23)
        Me.CPP_STUDENTSDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.CPP_STUDENTSDataGridView.Name = "CPP_STUDENTSDataGridView"
        Me.CPP_STUDENTSDataGridView.Size = New System.Drawing.Size(849, 271)
        Me.CPP_STUDENTSDataGridView.TabIndex = 1
        '
        'BRONCO_IDTextBox
        '
        Me.BRONCO_IDTextBox.Location = New System.Drawing.Point(133, 41)
        Me.BRONCO_IDTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.BRONCO_IDTextBox.Name = "BRONCO_IDTextBox"
        Me.BRONCO_IDTextBox.Size = New System.Drawing.Size(132, 22)
        Me.BRONCO_IDTextBox.TabIndex = 3
        '
        'FIRST_NAMETextBox
        '
        Me.FIRST_NAMETextBox.Location = New System.Drawing.Point(133, 73)
        Me.FIRST_NAMETextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.FIRST_NAMETextBox.Name = "FIRST_NAMETextBox"
        Me.FIRST_NAMETextBox.Size = New System.Drawing.Size(353, 22)
        Me.FIRST_NAMETextBox.TabIndex = 5
        '
        'LAST_NAMETextBox
        '
        Me.LAST_NAMETextBox.Location = New System.Drawing.Point(133, 105)
        Me.LAST_NAMETextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.LAST_NAMETextBox.Name = "LAST_NAMETextBox"
        Me.LAST_NAMETextBox.Size = New System.Drawing.Size(353, 22)
        Me.LAST_NAMETextBox.TabIndex = 7
        '
        'PHONETextBox
        '
        Me.PHONETextBox.Location = New System.Drawing.Point(133, 137)
        Me.PHONETextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PHONETextBox.Name = "PHONETextBox"
        Me.PHONETextBox.Size = New System.Drawing.Size(353, 22)
        Me.PHONETextBox.TabIndex = 9
        '
        'EMAILTextBox
        '
        Me.EMAILTextBox.Location = New System.Drawing.Point(133, 169)
        Me.EMAILTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.EMAILTextBox.Name = "EMAILTextBox"
        Me.EMAILTextBox.Size = New System.Drawing.Size(353, 22)
        Me.EMAILTextBox.TabIndex = 11
        '
        'gbStudentList
        '
        Me.gbStudentList.Controls.Add(Me.btnFind)
        Me.gbStudentList.Controls.Add(Me.btnDelete)
        Me.gbStudentList.Controls.Add(Me.btnAdd)
        Me.gbStudentList.Controls.Add(Me.btnUpdate)
        Me.gbStudentList.Controls.Add(Me.CPP_STUDENTSDataGridView)
        Me.gbStudentList.Location = New System.Drawing.Point(28, 302)
        Me.gbStudentList.Margin = New System.Windows.Forms.Padding(4)
        Me.gbStudentList.Name = "gbStudentList"
        Me.gbStudentList.Padding = New System.Windows.Forms.Padding(4)
        Me.gbStudentList.Size = New System.Drawing.Size(881, 388)
        Me.gbStudentList.TabIndex = 12
        Me.gbStudentList.TabStop = False
        Me.gbStudentList.Text = "Student List Information"
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(395, 319)
        Me.btnFind.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(108, 28)
        Me.btnFind.TabIndex = 30
        Me.btnFind.Text = "&Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(267, 319)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(108, 28)
        Me.btnDelete.TabIndex = 29
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(24, 319)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(108, 28)
        Me.btnAdd.TabIndex = 27
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(144, 319)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(108, 28)
        Me.btnUpdate.TabIndex = 28
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'gbStudentDetail
        '
        Me.gbStudentDetail.Controls.Add(Me.btnCancel)
        Me.gbStudentDetail.Controls.Add(Me.btnSave)
        Me.gbStudentDetail.Controls.Add(Me.BRONCO_IDTextBox)
        Me.gbStudentDetail.Controls.Add(Me.EMAILTextBox)
        Me.gbStudentDetail.Controls.Add(BRONCO_IDLabel)
        Me.gbStudentDetail.Controls.Add(EMAILLabel)
        Me.gbStudentDetail.Controls.Add(Me.PHONETextBox)
        Me.gbStudentDetail.Controls.Add(FIRST_NAMELabel)
        Me.gbStudentDetail.Controls.Add(PHONELabel)
        Me.gbStudentDetail.Controls.Add(Me.FIRST_NAMETextBox)
        Me.gbStudentDetail.Controls.Add(Me.LAST_NAMETextBox)
        Me.gbStudentDetail.Controls.Add(LAST_NAMELabel)
        Me.gbStudentDetail.Location = New System.Drawing.Point(28, 15)
        Me.gbStudentDetail.Margin = New System.Windows.Forms.Padding(4)
        Me.gbStudentDetail.Name = "gbStudentDetail"
        Me.gbStudentDetail.Padding = New System.Windows.Forms.Padding(4)
        Me.gbStudentDetail.Size = New System.Drawing.Size(880, 268)
        Me.gbStudentDetail.TabIndex = 13
        Me.gbStudentDetail.TabStop = False
        Me.gbStudentDetail.Text = "Student Information"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(141, 217)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 28)
        Me.btnCancel.TabIndex = 40
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(29, 217)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 28)
        Me.btnSave.TabIndex = 39
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(953, 722)
        Me.Controls.Add(Me.gbStudentDetail)
        Me.Controls.Add(Me.gbStudentList)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmStudent"
        Me.Text = "CPP STUDENT INFORMATION"
        CType(Me.CPP_STUDENTSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbStudentList.ResumeLayout(False)
        Me.gbStudentDetail.ResumeLayout(False)
        Me.gbStudentDetail.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CPP_STUDENTSDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents BRONCO_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FIRST_NAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents LAST_NAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents PHONETextBox As System.Windows.Forms.TextBox
    Friend WithEvents EMAILTextBox As System.Windows.Forms.TextBox
    Friend WithEvents gbStudentList As System.Windows.Forms.GroupBox
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents gbStudentDetail As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button

End Class
