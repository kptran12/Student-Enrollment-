<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnrollment
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
        Dim BRONCO_IDLabel As System.Windows.Forms.Label
        Dim CATALOG_IDLabel As System.Windows.Forms.Label
        Me.CPP_ENROLLMENTDataGridView = New System.Windows.Forms.DataGridView()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.gbEnrollmentDetail = New System.Windows.Forms.GroupBox()
        Me.BRONCO_IDComboBox = New System.Windows.Forms.ComboBox()
        Me.CATALOG_IDComboBox = New System.Windows.Forms.ComboBox()
        Me.gbEnrollmentList = New System.Windows.Forms.GroupBox()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        BRONCO_IDLabel = New System.Windows.Forms.Label()
        CATALOG_IDLabel = New System.Windows.Forms.Label()
        CType(Me.CPP_ENROLLMENTDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbEnrollmentDetail.SuspendLayout()
        Me.gbEnrollmentList.SuspendLayout()
        Me.SuspendLayout()
        '
        'BRONCO_IDLabel
        '
        BRONCO_IDLabel.AutoSize = True
        BRONCO_IDLabel.Location = New System.Drawing.Point(48, 49)
        BRONCO_IDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        BRONCO_IDLabel.Name = "BRONCO_IDLabel"
        BRONCO_IDLabel.Size = New System.Drawing.Size(89, 17)
        BRONCO_IDLabel.TabIndex = 32
        BRONCO_IDLabel.Text = "BRONCO ID:"
        '
        'CATALOG_IDLabel
        '
        CATALOG_IDLabel.AutoSize = True
        CATALOG_IDLabel.Location = New System.Drawing.Point(48, 94)
        CATALOG_IDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CATALOG_IDLabel.Name = "CATALOG_IDLabel"
        CATALOG_IDLabel.Size = New System.Drawing.Size(95, 17)
        CATALOG_IDLabel.TabIndex = 34
        CATALOG_IDLabel.Text = "CATALOG ID:"
        '
        'CPP_ENROLLMENTDataGridView
        '
        Me.CPP_ENROLLMENTDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CPP_ENROLLMENTDataGridView.Location = New System.Drawing.Point(8, 23)
        Me.CPP_ENROLLMENTDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.CPP_ENROLLMENTDataGridView.Name = "CPP_ENROLLMENTDataGridView"
        Me.CPP_ENROLLMENTDataGridView.Size = New System.Drawing.Size(803, 271)
        Me.CPP_ENROLLMENTDataGridView.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(289, 148)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 28)
        Me.btnCancel.TabIndex = 32
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(155, 148)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 28)
        Me.btnSave.TabIndex = 31
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'gbEnrollmentDetail
        '
        Me.gbEnrollmentDetail.Controls.Add(BRONCO_IDLabel)
        Me.gbEnrollmentDetail.Controls.Add(Me.BRONCO_IDComboBox)
        Me.gbEnrollmentDetail.Controls.Add(CATALOG_IDLabel)
        Me.gbEnrollmentDetail.Controls.Add(Me.CATALOG_IDComboBox)
        Me.gbEnrollmentDetail.Controls.Add(Me.btnCancel)
        Me.gbEnrollmentDetail.Controls.Add(Me.btnSave)
        Me.gbEnrollmentDetail.Location = New System.Drawing.Point(16, 15)
        Me.gbEnrollmentDetail.Margin = New System.Windows.Forms.Padding(4)
        Me.gbEnrollmentDetail.Name = "gbEnrollmentDetail"
        Me.gbEnrollmentDetail.Padding = New System.Windows.Forms.Padding(4)
        Me.gbEnrollmentDetail.Size = New System.Drawing.Size(523, 208)
        Me.gbEnrollmentDetail.TabIndex = 33
        Me.gbEnrollmentDetail.TabStop = False
        Me.gbEnrollmentDetail.Text = "Student Course"
        '
        'BRONCO_IDComboBox
        '
        Me.BRONCO_IDComboBox.FormattingEnabled = True
        Me.BRONCO_IDComboBox.Location = New System.Drawing.Point(155, 46)
        Me.BRONCO_IDComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.BRONCO_IDComboBox.Name = "BRONCO_IDComboBox"
        Me.BRONCO_IDComboBox.Size = New System.Drawing.Size(309, 24)
        Me.BRONCO_IDComboBox.TabIndex = 33
        '
        'CATALOG_IDComboBox
        '
        Me.CATALOG_IDComboBox.FormattingEnabled = True
        Me.CATALOG_IDComboBox.Location = New System.Drawing.Point(155, 90)
        Me.CATALOG_IDComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CATALOG_IDComboBox.Name = "CATALOG_IDComboBox"
        Me.CATALOG_IDComboBox.Size = New System.Drawing.Size(309, 24)
        Me.CATALOG_IDComboBox.TabIndex = 35
        '
        'gbEnrollmentList
        '
        Me.gbEnrollmentList.Controls.Add(Me.btnFind)
        Me.gbEnrollmentList.Controls.Add(Me.btnDelete)
        Me.gbEnrollmentList.Controls.Add(Me.btnAdd)
        Me.gbEnrollmentList.Controls.Add(Me.btnUpdate)
        Me.gbEnrollmentList.Controls.Add(Me.CPP_ENROLLMENTDataGridView)
        Me.gbEnrollmentList.Location = New System.Drawing.Point(16, 257)
        Me.gbEnrollmentList.Margin = New System.Windows.Forms.Padding(4)
        Me.gbEnrollmentList.Name = "gbEnrollmentList"
        Me.gbEnrollmentList.Padding = New System.Windows.Forms.Padding(4)
        Me.gbEnrollmentList.Size = New System.Drawing.Size(869, 382)
        Me.gbEnrollmentList.TabIndex = 34
        Me.gbEnrollmentList.TabStop = False
        Me.gbEnrollmentList.Text = "Student Course List"
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(379, 320)
        Me.btnFind.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(108, 28)
        Me.btnFind.TabIndex = 34
        Me.btnFind.Text = "&Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(251, 320)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(108, 28)
        Me.btnDelete.TabIndex = 33
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(8, 320)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(108, 28)
        Me.btnAdd.TabIndex = 31
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(128, 320)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(108, 28)
        Me.btnUpdate.TabIndex = 32
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'frmEnrollment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 663)
        Me.Controls.Add(Me.gbEnrollmentList)
        Me.Controls.Add(Me.gbEnrollmentDetail)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmEnrollment"
        Me.Text = "CPP ENROLLMENT INFORMATION"
        CType(Me.CPP_ENROLLMENTDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbEnrollmentDetail.ResumeLayout(False)
        Me.gbEnrollmentDetail.PerformLayout()
        Me.gbEnrollmentList.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CPP_ENROLLMENTDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents gbEnrollmentDetail As System.Windows.Forms.GroupBox
    Friend WithEvents gbEnrollmentList As System.Windows.Forms.GroupBox
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(strMode As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Friend WithEvents BRONCO_IDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CATALOG_IDComboBox As System.Windows.Forms.ComboBox
End Class
