<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmIndividual
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIndividual))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAddPlayer = New System.Windows.Forms.Button()
        Me.cbGuest = New System.Windows.Forms.CheckBox()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbByes_1 = New System.Windows.Forms.RadioButton()
        Me.rbByes_0 = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPlayerNickname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPlayerLastName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPlayerFirstName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMemberNo = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rbMembershipID = New System.Windows.Forms.RadioButton()
        Me.rbPlayerName = New System.Windows.Forms.RadioButton()
        Me.rbMemberName = New System.Windows.Forms.RadioButton()
        Me.btnSearchPlayer = New System.Windows.Forms.Button()
        Me.txtSearchPlayer = New System.Windows.Forms.TextBox()
        Me.lbSearchResults = New System.Windows.Forms.ListBox()
        Me.cmsPlayerList = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ChangePlayerDetails0ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeletePlayerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvPlayers = New System.Windows.Forms.DataGridView()
        Me.dgcListIndex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgcSelect = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dgcMembershipNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgcNickname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgcByesCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgcStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbSelectAll = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnAddFromFile = New System.Windows.Forms.Button()
        Me.btnDeletePlayer = New System.Windows.Forms.Button()
        Me.cboChangeStatus = New System.Windows.Forms.ComboBox()
        Me.btnChangeChecked = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseTournamentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveTournamentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommaSeparatedValuesFilecsvToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TournamentXMLxmlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintTournamentRosterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PageSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TournamentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenaltiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffJudgesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialogCSV = New System.Windows.Forms.SaveFileDialog()
        Me.SaveFileDialogXML = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.cmsPlayerList.SuspendLayout()
        CType(Me.dgvPlayers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAddPlayer)
        Me.GroupBox1.Controls.Add(Me.cbGuest)
        Me.GroupBox1.Controls.Add(Me.cboStatus)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtPlayerNickname)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtPlayerLastName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtPlayerFirstName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtMemberNo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(497, 279)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Register Player"
        '
        'btnAddPlayer
        '
        Me.btnAddPlayer.Location = New System.Drawing.Point(165, 241)
        Me.btnAddPlayer.Name = "btnAddPlayer"
        Me.btnAddPlayer.Size = New System.Drawing.Size(159, 29)
        Me.btnAddPlayer.TabIndex = 7
        Me.btnAddPlayer.Text = "Add Player to Tournament"
        Me.btnAddPlayer.UseVisualStyleBackColor = True
        '
        'cbGuest
        '
        Me.cbGuest.AutoSize = True
        Me.cbGuest.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbGuest.Location = New System.Drawing.Point(413, 24)
        Me.cbGuest.Name = "cbGuest"
        Me.cbGuest.Size = New System.Drawing.Size(70, 23)
        Me.cbGuest.TabIndex = 0
        Me.cbGuest.Text = "Guest?"
        Me.ToolTip1.SetToolTip(Me.cbGuest, resources.GetString("cbGuest.ToolTip"))
        Me.cbGuest.UseVisualStyleBackColor = True
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Location = New System.Drawing.Point(213, 207)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(277, 28)
        Me.cboStatus.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(20, 212)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 19)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Status"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbByes_1)
        Me.Panel1.Controls.Add(Me.rbByes_0)
        Me.Panel1.Location = New System.Drawing.Point(213, 172)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(277, 29)
        Me.Panel1.TabIndex = 5
        '
        'rbByes_1
        '
        Me.rbByes_1.AutoSize = True
        Me.rbByes_1.Location = New System.Drawing.Point(153, 5)
        Me.rbByes_1.Name = "rbByes_1"
        Me.rbByes_1.Size = New System.Drawing.Size(107, 19)
        Me.rbByes_1.TabIndex = 1
        Me.rbByes_1.Text = "First Round Bye"
        Me.rbByes_1.UseVisualStyleBackColor = True
        '
        'rbByes_0
        '
        Me.rbByes_0.AutoSize = True
        Me.rbByes_0.Checked = True
        Me.rbByes_0.Location = New System.Drawing.Point(11, 5)
        Me.rbByes_0.Name = "rbByes_0"
        Me.rbByes_0.Size = New System.Drawing.Size(119, 19)
        Me.rbByes_0.TabIndex = 0
        Me.rbByes_0.TabStop = True
        Me.rbByes_0.Text = "No Assigned Byes"
        Me.rbByes_0.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(20, 177)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 19)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Assigned Byes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(20, 141)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 19)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Player Member Name"
        '
        'txtPlayerNickname
        '
        Me.txtPlayerNickname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtPlayerNickname.Location = New System.Drawing.Point(213, 136)
        Me.txtPlayerNickname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPlayerNickname.Name = "txtPlayerNickname"
        Me.txtPlayerNickname.Size = New System.Drawing.Size(276, 29)
        Me.txtPlayerNickname.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(20, 104)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 19)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Player Last Name"
        '
        'txtPlayerLastName
        '
        Me.txtPlayerLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtPlayerLastName.Location = New System.Drawing.Point(213, 99)
        Me.txtPlayerLastName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPlayerLastName.Name = "txtPlayerLastName"
        Me.txtPlayerLastName.Size = New System.Drawing.Size(276, 29)
        Me.txtPlayerLastName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(20, 65)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Player First Name"
        '
        'txtPlayerFirstName
        '
        Me.txtPlayerFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtPlayerFirstName.Location = New System.Drawing.Point(213, 60)
        Me.txtPlayerFirstName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPlayerFirstName.Name = "txtPlayerFirstName"
        Me.txtPlayerFirstName.Size = New System.Drawing.Size(276, 29)
        Me.txtPlayerFirstName.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(20, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 19)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "TCG+ Membership Number"
        '
        'txtMemberNo
        '
        Me.txtMemberNo.Font = New System.Drawing.Font("Courier New", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtMemberNo.Location = New System.Drawing.Point(213, 21)
        Me.txtMemberNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMemberNo.MaxLength = 10
        Me.txtMemberNo.Multiline = True
        Me.txtMemberNo.Name = "txtMemberNo"
        Me.txtMemberNo.Size = New System.Drawing.Size(177, 29)
        Me.txtMemberNo.TabIndex = 1
        Me.txtMemberNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtMemberNo, "This NOT the same as the BCC (Budokai Card Club) numbers" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "used before." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The pla" &
        "yers MUST re-enroll at" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "https://www.bandai-tcg-plus.com/ and use the new Members" &
        "hip" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "No. listed there.")
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Controls.Add(Me.btnSearchPlayer)
        Me.GroupBox2.Controls.Add(Me.txtSearchPlayer)
        Me.GroupBox2.Controls.Add(Me.lbSearchResults)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 313)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(497, 298)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Player Search"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rbMembershipID)
        Me.Panel2.Controls.Add(Me.rbPlayerName)
        Me.Panel2.Controls.Add(Me.rbMemberName)
        Me.Panel2.Location = New System.Drawing.Point(6, 61)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(485, 33)
        Me.Panel2.TabIndex = 2
        '
        'rbMembershipID
        '
        Me.rbMembershipID.AutoSize = True
        Me.rbMembershipID.Checked = True
        Me.rbMembershipID.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rbMembershipID.Location = New System.Drawing.Point(8, 7)
        Me.rbMembershipID.Name = "rbMembershipID"
        Me.rbMembershipID.Size = New System.Drawing.Size(162, 21)
        Me.rbMembershipID.TabIndex = 0
        Me.rbMembershipID.TabStop = True
        Me.rbMembershipID.Text = "Sort by Membership ID"
        Me.rbMembershipID.UseVisualStyleBackColor = True
        '
        'rbPlayerName
        '
        Me.rbPlayerName.AutoSize = True
        Me.rbPlayerName.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rbPlayerName.Location = New System.Drawing.Point(172, 7)
        Me.rbPlayerName.Name = "rbPlayerName"
        Me.rbPlayerName.Size = New System.Drawing.Size(146, 21)
        Me.rbPlayerName.TabIndex = 1
        Me.rbPlayerName.Text = "Sort by Player Name"
        Me.rbPlayerName.UseVisualStyleBackColor = True
        '
        'rbMemberName
        '
        Me.rbMemberName.AutoSize = True
        Me.rbMemberName.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rbMemberName.Location = New System.Drawing.Point(320, 7)
        Me.rbMemberName.Name = "rbMemberName"
        Me.rbMemberName.Size = New System.Drawing.Size(161, 21)
        Me.rbMemberName.TabIndex = 2
        Me.rbMemberName.Text = "Sort by Member Name"
        Me.rbMemberName.UseVisualStyleBackColor = True
        '
        'btnSearchPlayer
        '
        Me.btnSearchPlayer.Location = New System.Drawing.Point(387, 26)
        Me.btnSearchPlayer.Name = "btnSearchPlayer"
        Me.btnSearchPlayer.Size = New System.Drawing.Size(103, 29)
        Me.btnSearchPlayer.TabIndex = 1
        Me.btnSearchPlayer.Text = "Search"
        Me.btnSearchPlayer.UseVisualStyleBackColor = True
        '
        'txtSearchPlayer
        '
        Me.txtSearchPlayer.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtSearchPlayer.Location = New System.Drawing.Point(6, 26)
        Me.txtSearchPlayer.Name = "txtSearchPlayer"
        Me.txtSearchPlayer.Size = New System.Drawing.Size(372, 29)
        Me.txtSearchPlayer.TabIndex = 0
        '
        'lbSearchResults
        '
        Me.lbSearchResults.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lbSearchResults.ContextMenuStrip = Me.cmsPlayerList
        Me.lbSearchResults.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbSearchResults.FormattingEnabled = True
        Me.lbSearchResults.ItemHeight = 21
        Me.lbSearchResults.Location = New System.Drawing.Point(6, 100)
        Me.lbSearchResults.Name = "lbSearchResults"
        Me.lbSearchResults.Size = New System.Drawing.Size(485, 193)
        Me.lbSearchResults.TabIndex = 3
        '
        'cmsPlayerList
        '
        Me.cmsPlayerList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangePlayerDetails0ToolStripMenuItem, Me.DeletePlayerToolStripMenuItem})
        Me.cmsPlayerList.Name = "cms"
        Me.cmsPlayerList.Size = New System.Drawing.Size(225, 48)
        '
        'ChangePlayerDetails0ToolStripMenuItem
        '
        Me.ChangePlayerDetails0ToolStripMenuItem.Name = "ChangePlayerDetails0ToolStripMenuItem"
        Me.ChangePlayerDetails0ToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.ChangePlayerDetails0ToolStripMenuItem.Text = "Change Player Details: {0}"
        '
        'DeletePlayerToolStripMenuItem
        '
        Me.DeletePlayerToolStripMenuItem.Name = "DeletePlayerToolStripMenuItem"
        Me.DeletePlayerToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.DeletePlayerToolStripMenuItem.Text = "Delete Player From Database"
        '
        'dgvPlayers
        '
        Me.dgvPlayers.AllowUserToAddRows = False
        Me.dgvPlayers.AllowUserToDeleteRows = False
        Me.dgvPlayers.AllowUserToResizeColumns = False
        Me.dgvPlayers.AllowUserToResizeRows = False
        Me.dgvPlayers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPlayers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPlayers.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPlayers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPlayers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgcListIndex, Me.dgcSelect, Me.dgcMembershipNo, Me.dgcNickname, Me.dgcByesCount, Me.dgcStatus})
        Me.dgvPlayers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgvPlayers.EnableHeadersVisualStyles = False
        Me.dgvPlayers.Location = New System.Drawing.Point(516, 52)
        Me.dgvPlayers.MultiSelect = False
        Me.dgvPlayers.Name = "dgvPlayers"
        Me.dgvPlayers.RowHeadersVisible = False
        Me.dgvPlayers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvPlayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPlayers.Size = New System.Drawing.Size(724, 524)
        Me.dgvPlayers.TabIndex = 3
        '
        'dgcListIndex
        '
        Me.dgcListIndex.HeaderText = "lstPlayerID"
        Me.dgcListIndex.Name = "dgcListIndex"
        Me.dgcListIndex.ReadOnly = True
        Me.dgcListIndex.Visible = False
        '
        'dgcSelect
        '
        Me.dgcSelect.FalseValue = "0"
        Me.dgcSelect.FillWeight = 25.0!
        Me.dgcSelect.HeaderText = ""
        Me.dgcSelect.Name = "dgcSelect"
        Me.dgcSelect.TrueValue = "1"
        '
        'dgcMembershipNo
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dgcMembershipNo.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgcMembershipNo.FillWeight = 80.0!
        Me.dgcMembershipNo.HeaderText = "Membership Number"
        Me.dgcMembershipNo.Name = "dgcMembershipNo"
        Me.dgcMembershipNo.ReadOnly = True
        '
        'dgcNickname
        '
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgcNickname.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgcNickname.FillWeight = 160.0!
        Me.dgcNickname.HeaderText = "Nickname (Player Name)"
        Me.dgcNickname.Name = "dgcNickname"
        Me.dgcNickname.ReadOnly = True
        '
        'dgcByesCount
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dgcByesCount.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgcByesCount.FillWeight = 60.0!
        Me.dgcByesCount.HeaderText = "First Round Bye"
        Me.dgcByesCount.Name = "dgcByesCount"
        Me.dgcByesCount.ReadOnly = True
        '
        'dgcStatus
        '
        Me.dgcStatus.FillWeight = 120.0!
        Me.dgcStatus.HeaderText = "Status"
        Me.dgcStatus.Name = "dgcStatus"
        Me.dgcStatus.ReadOnly = True
        Me.dgcStatus.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgcStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'cbSelectAll
        '
        Me.cbSelectAll.AutoSize = True
        Me.cbSelectAll.Location = New System.Drawing.Point(516, 27)
        Me.cbSelectAll.Name = "cbSelectAll"
        Me.cbSelectAll.Size = New System.Drawing.Size(114, 19)
        Me.cbSelectAll.TabIndex = 2
        Me.cbSelectAll.Text = "Select All Players"
        Me.cbSelectAll.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.btnAddFromFile)
        Me.Panel3.Controls.Add(Me.btnDeletePlayer)
        Me.Panel3.Controls.Add(Me.cboChangeStatus)
        Me.Panel3.Controls.Add(Me.btnChangeChecked)
        Me.Panel3.Location = New System.Drawing.Point(516, 582)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(724, 29)
        Me.Panel3.TabIndex = 4
        '
        'btnAddFromFile
        '
        Me.btnAddFromFile.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddFromFile.Location = New System.Drawing.Point(478, 0)
        Me.btnAddFromFile.Name = "btnAddFromFile"
        Me.btnAddFromFile.Size = New System.Drawing.Size(135, 29)
        Me.btnAddFromFile.TabIndex = 10
        Me.btnAddFromFile.Text = "Add From File"
        Me.btnAddFromFile.UseVisualStyleBackColor = True
        Me.btnAddFromFile.Visible = False
        '
        'btnDeletePlayer
        '
        Me.btnDeletePlayer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDeletePlayer.BackColor = System.Drawing.Color.Red
        Me.btnDeletePlayer.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnDeletePlayer.ForeColor = System.Drawing.Color.White
        Me.btnDeletePlayer.Location = New System.Drawing.Point(619, 0)
        Me.btnDeletePlayer.Name = "btnDeletePlayer"
        Me.btnDeletePlayer.Size = New System.Drawing.Size(105, 29)
        Me.btnDeletePlayer.TabIndex = 11
        Me.btnDeletePlayer.Text = "DELETE"
        Me.btnDeletePlayer.UseVisualStyleBackColor = False
        '
        'cboChangeStatus
        '
        Me.cboChangeStatus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboChangeStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboChangeStatus.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cboChangeStatus.FormattingEnabled = True
        Me.cboChangeStatus.Location = New System.Drawing.Point(195, 0)
        Me.cboChangeStatus.Name = "cboChangeStatus"
        Me.cboChangeStatus.Size = New System.Drawing.Size(277, 28)
        Me.cboChangeStatus.TabIndex = 9
        '
        'btnChangeChecked
        '
        Me.btnChangeChecked.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnChangeChecked.Location = New System.Drawing.Point(0, 0)
        Me.btnChangeChecked.Name = "btnChangeChecked"
        Me.btnChangeChecked.Size = New System.Drawing.Size(189, 29)
        Me.btnChangeChecked.TabIndex = 8
        Me.btnChangeChecked.Text = "Change Checked Entries to:"
        Me.btnChangeChecked.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsl})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 614)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1252, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsl
        '
        Me.tsl.Name = "tsl"
        Me.tsl.Size = New System.Drawing.Size(119, 17)
        Me.tsl.Text = "ToolStripStatusLabel1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.TournamentToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1252, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseTournamentToolStripMenuItem, Me.ToolStripSeparator3, Me.SaveTournamentToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripSeparator1, Me.PrintTournamentRosterToolStripMenuItem, Me.PageSetupToolStripMenuItem, Me.ToolStripSeparator2})
        Me.FileToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'CloseTournamentToolStripMenuItem
        '
        Me.CloseTournamentToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Replace
        Me.CloseTournamentToolStripMenuItem.Name = "CloseTournamentToolStripMenuItem"
        Me.CloseTournamentToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.CloseTournamentToolStripMenuItem.Text = "&Close Tournament"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.MergeAction = System.Windows.Forms.MergeAction.Replace
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(199, 6)
        '
        'SaveTournamentToolStripMenuItem
        '
        Me.SaveTournamentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CommaSeparatedValuesFilecsvToolStripMenuItem, Me.TournamentXMLxmlToolStripMenuItem})
        Me.SaveTournamentToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Replace
        Me.SaveTournamentToolStripMenuItem.Name = "SaveTournamentToolStripMenuItem"
        Me.SaveTournamentToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.SaveTournamentToolStripMenuItem.Text = "&Save Tournament"
        '
        'CommaSeparatedValuesFilecsvToolStripMenuItem
        '
        Me.CommaSeparatedValuesFilecsvToolStripMenuItem.Name = "CommaSeparatedValuesFilecsvToolStripMenuItem"
        Me.CommaSeparatedValuesFilecsvToolStripMenuItem.Size = New System.Drawing.Size(262, 22)
        Me.CommaSeparatedValuesFilecsvToolStripMenuItem.Text = "&Comma-Separated Values File (.csv)"
        '
        'TournamentXMLxmlToolStripMenuItem
        '
        Me.TournamentXMLxmlToolStripMenuItem.Name = "TournamentXMLxmlToolStripMenuItem"
        Me.TournamentXMLxmlToolStripMenuItem.Size = New System.Drawing.Size(262, 22)
        Me.TournamentXMLxmlToolStripMenuItem.Text = "Tournament XML (.xml)"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3})
        Me.ToolStripMenuItem1.MergeAction = System.Windows.Forms.MergeAction.Replace
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(202, 22)
        Me.ToolStripMenuItem1.Text = "S&ave Copy As..."
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(262, 22)
        Me.ToolStripMenuItem2.Text = "&Comma-Separated Values File (.csv)"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(262, 22)
        Me.ToolStripMenuItem3.Text = "Tournament XML (.xml)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.MergeAction = System.Windows.Forms.MergeAction.Replace
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(199, 6)
        '
        'PrintTournamentRosterToolStripMenuItem
        '
        Me.PrintTournamentRosterToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Replace
        Me.PrintTournamentRosterToolStripMenuItem.Name = "PrintTournamentRosterToolStripMenuItem"
        Me.PrintTournamentRosterToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.PrintTournamentRosterToolStripMenuItem.Text = "&Print Tournament Roster"
        Me.PrintTournamentRosterToolStripMenuItem.Visible = False
        '
        'PageSetupToolStripMenuItem
        '
        Me.PageSetupToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Replace
        Me.PageSetupToolStripMenuItem.Name = "PageSetupToolStripMenuItem"
        Me.PageSetupToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.PageSetupToolStripMenuItem.Text = "P&age Setup"
        Me.PageSetupToolStripMenuItem.Visible = False
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.MergeAction = System.Windows.Forms.MergeAction.Replace
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(199, 6)
        '
        'TournamentToolStripMenuItem
        '
        Me.TournamentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenaltiesToolStripMenuItem, Me.StaffJudgesToolStripMenuItem})
        Me.TournamentToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Replace
        Me.TournamentToolStripMenuItem.Name = "TournamentToolStripMenuItem"
        Me.TournamentToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.TournamentToolStripMenuItem.Text = "&Tournament"
        '
        'PenaltiesToolStripMenuItem
        '
        Me.PenaltiesToolStripMenuItem.Name = "PenaltiesToolStripMenuItem"
        Me.PenaltiesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PenaltiesToolStripMenuItem.Text = "&Penalties"
        '
        'StaffJudgesToolStripMenuItem
        '
        Me.StaffJudgesToolStripMenuItem.Name = "StaffJudgesToolStripMenuItem"
        Me.StaffJudgesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.StaffJudgesToolStripMenuItem.Text = "&Staff/Judges"
        '
        'SaveFileDialogCSV
        '
        Me.SaveFileDialogCSV.DefaultExt = "csv"
        Me.SaveFileDialogCSV.Filter = "Comma-Seperated Values (.csv)|*.csv|All files|*.*"
        Me.SaveFileDialogCSV.SupportMultiDottedExtensions = True
        Me.SaveFileDialogCSV.Title = "Save file for Bandai TCG+ Upload (.csv)"
        '
        'SaveFileDialogXML
        '
        Me.SaveFileDialogXML.DefaultExt = "csv"
        Me.SaveFileDialogXML.Filter = "Tournament XML|*.xml|All files|*.*"
        Me.SaveFileDialogXML.SupportMultiDottedExtensions = True
        Me.SaveFileDialogXML.Title = "Save Master Tournament File"
        '
        'frmIndividual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1252, 636)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.cbSelectAll)
        Me.Controls.Add(Me.dgvPlayers)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(1268, 623)
        Me.Name = "frmIndividual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Individual Registration"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.cmsPlayerList.ResumeLayout(False)
        CType(Me.dgvPlayers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rbByes_1 As RadioButton
    Friend WithEvents rbByes_0 As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPlayerNickname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPlayerLastName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPlayerFirstName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMemberNo As TextBox
    Friend WithEvents btnAddPlayer As Button
    Friend WithEvents cbGuest As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSearchPlayer As Button
    Friend WithEvents txtSearchPlayer As TextBox
    Friend WithEvents lbSearchResults As ListBox
    Friend WithEvents dgvPlayers As DataGridView
    Friend WithEvents cbSelectAll As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel2 As Panel
    Friend WithEvents rbMembershipID As RadioButton
    Friend WithEvents rbPlayerName As RadioButton
    Friend WithEvents rbMemberName As RadioButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnAddFromFile As Button
    Friend WithEvents btnDeletePlayer As Button
    Friend WithEvents cboChangeStatus As ComboBox
    Friend WithEvents btnChangeChecked As Button
    Friend WithEvents cmsPlayerList As ContextMenuStrip
    Friend WithEvents ChangePlayerDetails0ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeletePlayerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tsl As ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveTournamentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CommaSeparatedValuesFilecsvToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TournamentXMLxmlToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents PrintTournamentRosterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PageSetupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents CloseTournamentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TournamentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenaltiesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StaffJudgesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents dgcListIndex As DataGridViewTextBoxColumn
    Friend WithEvents dgcSelect As DataGridViewCheckBoxColumn
    Friend WithEvents dgcMembershipNo As DataGridViewTextBoxColumn
    Friend WithEvents dgcNickname As DataGridViewTextBoxColumn
    Friend WithEvents dgcByesCount As DataGridViewTextBoxColumn
    Friend WithEvents dgcStatus As DataGridViewTextBoxColumn
    Friend WithEvents SaveFileDialogCSV As SaveFileDialog
    Friend WithEvents SaveFileDialogXML As SaveFileDialog
End Class
