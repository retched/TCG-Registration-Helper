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
        Me.btnEditStaff = New System.Windows.Forms.Button()
        Me.btnDeleteStaff = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbStaffListing
        '
        Me.lbStaffListing.FormattingEnabled = True
        Me.lbStaffListing.ItemHeight = 15
        Me.lbStaffListing.Location = New System.Drawing.Point(12, 12)
        Me.lbStaffListing.Name = "lbStaffListing"
        Me.lbStaffListing.Size = New System.Drawing.Size(411, 364)
        Me.lbStaffListing.TabIndex = 0
        '
        'btnAddStaff
        '
        Me.btnAddStaff.Location = New System.Drawing.Point(429, 52)
        Me.btnAddStaff.Name = "btnAddStaff"
        Me.btnAddStaff.Size = New System.Drawing.Size(75, 29)
        Me.btnAddStaff.TabIndex = 1
        Me.btnAddStaff.Text = "Add"
        Me.btnAddStaff.UseVisualStyleBackColor = True
        '
        'btnEditStaff
        '
        Me.btnEditStaff.Location = New System.Drawing.Point(429, 97)
        Me.btnEditStaff.Name = "btnEditStaff"
        Me.btnEditStaff.Size = New System.Drawing.Size(75, 29)
        Me.btnEditStaff.TabIndex = 2
        Me.btnEditStaff.Text = "Edit"
        Me.btnEditStaff.UseVisualStyleBackColor = True
        '
        'btnDeleteStaff
        '
        Me.btnDeleteStaff.Location = New System.Drawing.Point(429, 146)
        Me.btnDeleteStaff.Name = "btnDeleteStaff"
        Me.btnDeleteStaff.Size = New System.Drawing.Size(75, 29)
        Me.btnDeleteStaff.TabIndex = 3
        Me.btnDeleteStaff.Text = "Delete"
        Me.btnDeleteStaff.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(429, 310)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 29)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Close"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'frmStaffList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 391)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnDeleteStaff)
        Me.Controls.Add(Me.btnEditStaff)
        Me.Controls.Add(Me.btnAddStaff)
        Me.Controls.Add(Me.lbStaffListing)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmStaffList"
        Me.ShowInTaskbar = False
        Me.Text = "Staff List"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbStaffListing As ListBox
    Friend WithEvents btnAddStaff As Button
    Friend WithEvents btnEditStaff As Button
    Friend WithEvents btnDeleteStaff As Button
    Friend WithEvents Button4 As Button
End Class
