<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterPlayerList
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvMasterList = New System.Windows.Forms.DataGridView()
        Me.dgcMembershipID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgcMembershipName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgcPlayerFirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgcPlayerLastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAddPlayer = New System.Windows.Forms.Button()
        Me.txtSearchField = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnEditPlayer = New System.Windows.Forms.Button()
        Me.btnDelPlayer = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnShowAll = New System.Windows.Forms.Button()
        CType(Me.dgvMasterList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvMasterList
        '
        Me.dgvMasterList.AllowUserToAddRows = False
        Me.dgvMasterList.AllowUserToDeleteRows = False
        Me.dgvMasterList.AllowUserToResizeColumns = False
        Me.dgvMasterList.AllowUserToResizeRows = False
        Me.dgvMasterList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMasterList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMasterList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMasterList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMasterList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgcMembershipID, Me.dgcMembershipName, Me.dgcPlayerFirstName, Me.dgcPlayerLastName})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMasterList.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvMasterList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.dgvMasterList.Location = New System.Drawing.Point(12, 47)
        Me.dgvMasterList.Name = "dgvMasterList"
        Me.dgvMasterList.RowHeadersVisible = False
        Me.dgvMasterList.RowTemplate.Height = 27
        Me.dgvMasterList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMasterList.Size = New System.Drawing.Size(794, 401)
        Me.dgvMasterList.TabIndex = 2
        '
        'dgcMembershipID
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgcMembershipID.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgcMembershipID.FillWeight = 75.0!
        Me.dgcMembershipID.HeaderText = "TCG+ Membership Number"
        Me.dgcMembershipID.Name = "dgcMembershipID"
        Me.dgcMembershipID.ReadOnly = True
        '
        'dgcMembershipName
        '
        Me.dgcMembershipName.HeaderText = "TCG+ Membership Name"
        Me.dgcMembershipName.Name = "dgcMembershipName"
        Me.dgcMembershipName.ReadOnly = True
        '
        'dgcPlayerFirstName
        '
        Me.dgcPlayerFirstName.HeaderText = "First Name"
        Me.dgcPlayerFirstName.Name = "dgcPlayerFirstName"
        Me.dgcPlayerFirstName.ReadOnly = True
        '
        'dgcPlayerLastName
        '
        Me.dgcPlayerLastName.HeaderText = "Last Name"
        Me.dgcPlayerLastName.Name = "dgcPlayerLastName"
        Me.dgcPlayerLastName.ReadOnly = True
        '
        'btnAddPlayer
        '
        Me.btnAddPlayer.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAddPlayer.Location = New System.Drawing.Point(76, 454)
        Me.btnAddPlayer.Name = "btnAddPlayer"
        Me.btnAddPlayer.Size = New System.Drawing.Size(162, 30)
        Me.btnAddPlayer.TabIndex = 3
        Me.btnAddPlayer.Text = "Add Player"
        Me.btnAddPlayer.UseVisualStyleBackColor = True
        '
        'txtSearchField
        '
        Me.txtSearchField.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchField.Location = New System.Drawing.Point(12, 13)
        Me.txtSearchField.Name = "txtSearchField"
        Me.txtSearchField.Size = New System.Drawing.Size(458, 27)
        Me.txtSearchField.TabIndex = 0
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(476, 11)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(162, 30)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search Player List"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnEditPlayer
        '
        Me.btnEditPlayer.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnEditPlayer.Enabled = False
        Me.btnEditPlayer.Location = New System.Drawing.Point(244, 454)
        Me.btnEditPlayer.Name = "btnEditPlayer"
        Me.btnEditPlayer.Size = New System.Drawing.Size(162, 30)
        Me.btnEditPlayer.TabIndex = 4
        Me.btnEditPlayer.Text = "Edit Player"
        Me.btnEditPlayer.UseVisualStyleBackColor = True
        '
        'btnDelPlayer
        '
        Me.btnDelPlayer.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDelPlayer.Enabled = False
        Me.btnDelPlayer.Location = New System.Drawing.Point(412, 454)
        Me.btnDelPlayer.Name = "btnDelPlayer"
        Me.btnDelPlayer.Size = New System.Drawing.Size(162, 30)
        Me.btnDelPlayer.TabIndex = 5
        Me.btnDelPlayer.Text = "Delete Player"
        Me.btnDelPlayer.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(580, 454)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(162, 30)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnShowAll
        '
        Me.btnShowAll.Location = New System.Drawing.Point(644, 11)
        Me.btnShowAll.Name = "btnShowAll"
        Me.btnShowAll.Size = New System.Drawing.Size(162, 30)
        Me.btnShowAll.TabIndex = 7
        Me.btnShowAll.Text = "Show All"
        Me.btnShowAll.UseVisualStyleBackColor = True
        '
        'frmMasterPlayerList
        '
        Me.AcceptButton = Me.btnAddPlayer
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(818, 496)
        Me.Controls.Add(Me.btnShowAll)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDelPlayer)
        Me.Controls.Add(Me.btnEditPlayer)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearchField)
        Me.Controls.Add(Me.btnAddPlayer)
        Me.Controls.Add(Me.dgvMasterList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMasterPlayerList"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Master Player Roster"
        CType(Me.dgvMasterList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvMasterList As DataGridView
    Friend WithEvents btnAddPlayer As Button
    Friend WithEvents txtSearchField As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnEditPlayer As Button
    Friend WithEvents btnDelPlayer As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnShowAll As Button
    Friend WithEvents dgcMembershipID As DataGridViewTextBoxColumn
    Friend WithEvents dgcMembershipName As DataGridViewTextBoxColumn
    Friend WithEvents dgcPlayerFirstName As DataGridViewTextBoxColumn
    Friend WithEvents dgcPlayerLastName As DataGridViewTextBoxColumn
End Class
