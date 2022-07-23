<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStaffList
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
        Me.lbStaffListing = New System.Windows.Forms.ListBox()
        Me.btnAddStaff = New System.Windows.Forms.Button()
        Me.btnDeleteStaff = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboStaffMember = New System.Windows.Forms.ComboBox()
        Me.cboStaffPosition = New System.Windows.Forms.ComboBox()
        Me.btnAddUnlisted = New System.Windows.Forms.Button()
        Me.btnSearchbyNumber = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbStaffListing
        '
        Me.lbStaffListing.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbStaffListing.FormattingEnabled = True
        Me.lbStaffListing.ItemHeight = 21
        Me.lbStaffListing.Location = New System.Drawing.Point(12, 35)
        Me.lbStaffListing.Name = "lbStaffListing"
        Me.lbStaffListing.Size = New System.Drawing.Size(353, 256)
        Me.lbStaffListing.TabIndex = 0
        '
        'btnAddStaff
        '
        Me.btnAddStaff.Location = New System.Drawing.Point(493, 231)
        Me.btnAddStaff.Name = "btnAddStaff"
        Me.btnAddStaff.Size = New System.Drawing.Size(116, 29)
        Me.btnAddStaff.TabIndex = 1
        Me.btnAddStaff.Text = "Add to Staff"
        Me.btnAddStaff.UseVisualStyleBackColor = True
        '
        'btnDeleteStaff
        '
        Me.btnDeleteStaff.Location = New System.Drawing.Point(130, 297)
        Me.btnDeleteStaff.Name = "btnDeleteStaff"
        Me.btnDeleteStaff.Size = New System.Drawing.Size(116, 29)
        Me.btnDeleteStaff.TabIndex = 3
        Me.btnDeleteStaff.Text = "Delete Selected"
        Me.btnDeleteStaff.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnClose.Location = New System.Drawing.Point(493, 266)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(116, 29)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "List of Staff Members"
        '
        'cboStaffMember
        '
        Me.cboStaffMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStaffMember.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStaffMember.FormattingEnabled = True
        Me.cboStaffMember.Location = New System.Drawing.Point(6, 19)
        Me.cboStaffMember.Name = "cboStaffMember"
        Me.cboStaffMember.Size = New System.Drawing.Size(360, 29)
        Me.cboStaffMember.TabIndex = 6
        '
        'cboStaffPosition
        '
        Me.cboStaffPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStaffPosition.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStaffPosition.FormattingEnabled = True
        Me.cboStaffPosition.Location = New System.Drawing.Point(6, 19)
        Me.cboStaffPosition.Name = "cboStaffPosition"
        Me.cboStaffPosition.Size = New System.Drawing.Size(358, 29)
        Me.cboStaffPosition.TabIndex = 8
        '
        'btnAddUnlisted
        '
        Me.btnAddUnlisted.Location = New System.Drawing.Point(122, 87)
        Me.btnAddUnlisted.Name = "btnAddUnlisted"
        Me.btnAddUnlisted.Size = New System.Drawing.Size(116, 29)
        Me.btnAddUnlisted.TabIndex = 10
        Me.btnAddUnlisted.Text = "Add Unlisted"
        Me.btnAddUnlisted.UseVisualStyleBackColor = True
        '
        'btnSearchbyNumber
        '
        Me.btnSearchbyNumber.Location = New System.Drawing.Point(250, 53)
        Me.btnSearchbyNumber.Name = "btnSearchbyNumber"
        Me.btnSearchbyNumber.Size = New System.Drawing.Size(116, 29)
        Me.btnSearchbyNumber.TabIndex = 12
        Me.btnSearchbyNumber.Text = "Search by Number"
        Me.btnSearchbyNumber.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(6, 54)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(238, 27)
        Me.txtSearch.TabIndex = 13
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboStaffMember)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.btnAddUnlisted)
        Me.GroupBox1.Controls.Add(Me.btnSearchbyNumber)
        Me.GroupBox1.Location = New System.Drawing.Point(371, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(370, 122)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Staff Member"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboStaffPosition)
        Me.GroupBox2.Location = New System.Drawing.Point(371, 163)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(370, 62)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Staff Position"
        '
        'frmStaffList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(753, 336)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDeleteStaff)
        Me.Controls.Add(Me.btnAddStaff)
        Me.Controls.Add(Me.lbStaffListing)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmStaffList"
        Me.ShowInTaskbar = False
        Me.Text = "Staff List"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbStaffListing As ListBox
    Friend WithEvents btnAddStaff As Button
    Friend WithEvents btnDeleteStaff As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cboStaffMember As ComboBox
    Friend WithEvents cboStaffPosition As ComboBox
    Friend WithEvents btnAddUnlisted As Button
    Friend WithEvents btnSearchbyNumber As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
