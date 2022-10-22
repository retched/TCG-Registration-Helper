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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAddPlayer = New System.Windows.Forms.Button()
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
        Me.btnShowAll = New System.Windows.Forms.Button()
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
        Me.dgcIndex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgcTeamId = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.tslPlayerPreReg = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslBorder = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslActivePlayer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslSpacer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslFileName = New System.Windows.Forms.ToolStripStatusLabel()
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
        Me.TournamentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenaltiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffJudgesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialogCSV = New System.Windows.Forms.SaveFileDialog()
        Me.SaveFileDialogXML = New System.Windows.Forms.SaveFileDialog()
        Me.AddFromCSVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddFromXMLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsAddFromFile = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenFileDialogCSV = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialogXML = New System.Windows.Forms.OpenFileDialog()
        Me.cmsTournamentList = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ChangeMembershipNumberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeTeamIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeletePlayerFromTournamentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePlayerStatusToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AppliedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuccessfulToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WaitingListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnsuccessfulToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelledToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectedCheckedInToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WaitingForCancellationCheckedInToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbsentOnDayOfEventToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdvanceElectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParticipatingInTournamentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DroppedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.FullNameEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.cmsPlayerList.SuspendLayout()
        CType(Me.dgvPlayers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.cmsAddFromFile.SuspendLayout()
        Me.cmsTournamentList.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.btnAddPlayer)
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
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(497, 279)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Register Player"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(397, 21)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(92, 29)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnAddPlayer
        '
        Me.btnAddPlayer.Location = New System.Drawing.Point(165, 241)
        Me.btnAddPlayer.Name = "btnAddPlayer"
        Me.btnAddPlayer.Size = New System.Drawing.Size(159, 29)
        Me.btnAddPlayer.TabIndex = 6
        Me.btnAddPlayer.Text = "Add Player to Tournament"
        Me.btnAddPlayer.UseVisualStyleBackColor = True
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Location = New System.Drawing.Point(213, 207)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(276, 28)
        Me.cboStatus.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
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
        Me.Panel1.Size = New System.Drawing.Size(276, 29)
        Me.Panel1.TabIndex = 4
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
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
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
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(20, 141)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 19)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Player Member Name*"
        '
        'txtPlayerNickname
        '
        Me.txtPlayerNickname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtPlayerNickname.Location = New System.Drawing.Point(213, 136)
        Me.txtPlayerNickname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPlayerNickname.Name = "txtPlayerNickname"
        Me.txtPlayerNickname.Size = New System.Drawing.Size(276, 29)
        Me.txtPlayerNickname.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
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
        Me.txtPlayerLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtPlayerLastName.Location = New System.Drawing.Point(213, 99)
        Me.txtPlayerLastName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPlayerLastName.Name = "txtPlayerLastName"
        Me.txtPlayerLastName.Size = New System.Drawing.Size(276, 29)
        Me.txtPlayerLastName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
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
        Me.txtPlayerFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtPlayerFirstName.Location = New System.Drawing.Point(213, 60)
        Me.txtPlayerFirstName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPlayerFirstName.Name = "txtPlayerFirstName"
        Me.txtPlayerFirstName.Size = New System.Drawing.Size(276, 29)
        Me.txtPlayerFirstName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(20, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 19)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "TCG+ Membership Number*"
        '
        'txtMemberNo
        '
        Me.txtMemberNo.Font = New System.Drawing.Font("Courier New", 14.0!)
        Me.txtMemberNo.Location = New System.Drawing.Point(213, 21)
        Me.txtMemberNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMemberNo.MaxLength = 10
        Me.txtMemberNo.Name = "txtMemberNo"
        Me.txtMemberNo.Size = New System.Drawing.Size(177, 29)
        Me.txtMemberNo.TabIndex = 0
        Me.txtMemberNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.btnShowAll)
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Controls.Add(Me.btnSearchPlayer)
        Me.GroupBox2.Controls.Add(Me.txtSearchPlayer)
        Me.GroupBox2.Controls.Add(Me.lbSearchResults)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 299)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(497, 312)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Player Search"
        '
        'btnShowAll
        '
        Me.btnShowAll.Location = New System.Drawing.Point(388, 26)
        Me.btnShowAll.Name = "btnShowAll"
        Me.btnShowAll.Size = New System.Drawing.Size(103, 29)
        Me.btnShowAll.TabIndex = 4
        Me.btnShowAll.Text = "Show All"
        Me.btnShowAll.UseVisualStyleBackColor = True
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
        Me.rbMembershipID.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.rbMembershipID.Location = New System.Drawing.Point(320, 6)
        Me.rbMembershipID.Name = "rbMembershipID"
        Me.rbMembershipID.Size = New System.Drawing.Size(162, 21)
        Me.rbMembershipID.TabIndex = 0
        Me.rbMembershipID.Text = "Sort by Membership ID"
        Me.rbMembershipID.UseVisualStyleBackColor = True
        '
        'rbPlayerName
        '
        Me.rbPlayerName.AutoSize = True
        Me.rbPlayerName.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.rbPlayerName.Location = New System.Drawing.Point(171, 6)
        Me.rbPlayerName.Name = "rbPlayerName"
        Me.rbPlayerName.Size = New System.Drawing.Size(146, 21)
        Me.rbPlayerName.TabIndex = 1
        Me.rbPlayerName.Text = "Sort by Player Name"
        Me.rbPlayerName.UseVisualStyleBackColor = True
        '
        'rbMemberName
        '
        Me.rbMemberName.AutoSize = True
        Me.rbMemberName.Checked = True
        Me.rbMemberName.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.rbMemberName.Location = New System.Drawing.Point(4, 6)
        Me.rbMemberName.Name = "rbMemberName"
        Me.rbMemberName.Size = New System.Drawing.Size(161, 21)
        Me.rbMemberName.TabIndex = 2
        Me.rbMemberName.TabStop = True
        Me.rbMemberName.Text = "Sort by Member Name"
        Me.rbMemberName.UseVisualStyleBackColor = True
        '
        'btnSearchPlayer
        '
        Me.btnSearchPlayer.Location = New System.Drawing.Point(279, 26)
        Me.btnSearchPlayer.Name = "btnSearchPlayer"
        Me.btnSearchPlayer.Size = New System.Drawing.Size(103, 29)
        Me.btnSearchPlayer.TabIndex = 1
        Me.btnSearchPlayer.Text = "Search"
        Me.btnSearchPlayer.UseVisualStyleBackColor = True
        '
        'txtSearchPlayer
        '
        Me.txtSearchPlayer.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtSearchPlayer.Location = New System.Drawing.Point(6, 26)
        Me.txtSearchPlayer.Name = "txtSearchPlayer"
        Me.txtSearchPlayer.Size = New System.Drawing.Size(267, 29)
        Me.txtSearchPlayer.TabIndex = 0
        '
        'lbSearchResults
        '
        Me.lbSearchResults.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbSearchResults.ContextMenuStrip = Me.cmsPlayerList
        Me.lbSearchResults.Font = New System.Drawing.Font("Segoe UI", 12.0!)
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
        Me.dgvPlayers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvPlayers.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPlayers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPlayers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgcListIndex, Me.dgcSelect, Me.dgcIndex, Me.dgcTeamId, Me.dgcMembershipNo, Me.dgcNickname, Me.dgcByesCount, Me.dgcStatus})
        Me.dgvPlayers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgvPlayers.EnableHeadersVisualStyles = False
        Me.dgvPlayers.Location = New System.Drawing.Point(516, 37)
        Me.dgvPlayers.MultiSelect = False
        Me.dgvPlayers.Name = "dgvPlayers"
        Me.dgvPlayers.RowHeadersVisible = False
        Me.dgvPlayers.RowTemplate.Height = 90
        Me.dgvPlayers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvPlayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPlayers.Size = New System.Drawing.Size(731, 539)
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
        'dgcIndex
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgcIndex.DefaultCellStyle = DataGridViewCellStyle14
        Me.dgcIndex.FillWeight = 25.0!
        Me.dgcIndex.HeaderText = "#"
        Me.dgcIndex.Name = "dgcIndex"
        '
        'dgcTeamId
        '
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgcTeamId.DefaultCellStyle = DataGridViewCellStyle15
        Me.dgcTeamId.FillWeight = 75.0!
        Me.dgcTeamId.HeaderText = "Team ID#"
        Me.dgcTeamId.Name = "dgcTeamId"
        '
        'dgcMembershipNo
        '
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.dgcMembershipNo.DefaultCellStyle = DataGridViewCellStyle16
        Me.dgcMembershipNo.FillWeight = 80.0!
        Me.dgcMembershipNo.HeaderText = "Membership Number"
        Me.dgcMembershipNo.Name = "dgcMembershipNo"
        Me.dgcMembershipNo.ReadOnly = True
        '
        'dgcNickname
        '
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgcNickname.DefaultCellStyle = DataGridViewCellStyle17
        Me.dgcNickname.FillWeight = 140.0!
        Me.dgcNickname.HeaderText = "Nickname (Player Name)"
        Me.dgcNickname.Name = "dgcNickname"
        Me.dgcNickname.ReadOnly = True
        '
        'dgcByesCount
        '
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dgcByesCount.DefaultCellStyle = DataGridViewCellStyle18
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
        Me.cbSelectAll.Location = New System.Drawing.Point(516, 12)
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
        Me.Panel3.Size = New System.Drawing.Size(731, 29)
        Me.Panel3.TabIndex = 4
        '
        'btnAddFromFile
        '
        Me.btnAddFromFile.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddFromFile.Location = New System.Drawing.Point(481, 0)
        Me.btnAddFromFile.Name = "btnAddFromFile"
        Me.btnAddFromFile.Size = New System.Drawing.Size(135, 29)
        Me.btnAddFromFile.TabIndex = 10
        Me.btnAddFromFile.Text = "Add From File"
        Me.btnAddFromFile.UseVisualStyleBackColor = True
        '
        'btnDeletePlayer
        '
        Me.btnDeletePlayer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDeletePlayer.BackColor = System.Drawing.Color.Red
        Me.btnDeletePlayer.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnDeletePlayer.ForeColor = System.Drawing.Color.White
        Me.btnDeletePlayer.Location = New System.Drawing.Point(622, 0)
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
        Me.cboChangeStatus.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.cboChangeStatus.FormattingEnabled = True
        Me.cboChangeStatus.Location = New System.Drawing.Point(198, 0)
        Me.cboChangeStatus.Name = "cboChangeStatus"
        Me.cboChangeStatus.Size = New System.Drawing.Size(277, 28)
        Me.cboChangeStatus.TabIndex = 9
        '
        'btnChangeChecked
        '
        Me.btnChangeChecked.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnChangeChecked.Location = New System.Drawing.Point(3, 0)
        Me.btnChangeChecked.Name = "btnChangeChecked"
        Me.btnChangeChecked.Size = New System.Drawing.Size(189, 29)
        Me.btnChangeChecked.TabIndex = 8
        Me.btnChangeChecked.Text = "Change Checked Entries to:"
        Me.btnChangeChecked.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslPlayerPreReg, Me.tslBorder, Me.tslActivePlayer, Me.tslSpacer, Me.tslFileName})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 614)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1259, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tslPlayerPreReg
        '
        Me.tslPlayerPreReg.Name = "tslPlayerPreReg"
        Me.tslPlayerPreReg.Size = New System.Drawing.Size(141, 17)
        Me.tslPlayerPreReg.Text = "0 Player(s) Pre-Registered"
        '
        'tslBorder
        '
        Me.tslBorder.Name = "tslBorder"
        Me.tslBorder.Size = New System.Drawing.Size(10, 17)
        Me.tslBorder.Text = "|"
        '
        'tslActivePlayer
        '
        Me.tslActivePlayer.Name = "tslActivePlayer"
        Me.tslActivePlayer.Size = New System.Drawing.Size(97, 17)
        Me.tslActivePlayer.Text = "0 Player(s) Active"
        '
        'tslSpacer
        '
        Me.tslSpacer.Name = "tslSpacer"
        Me.tslSpacer.Size = New System.Drawing.Size(996, 17)
        Me.tslSpacer.Spring = True
        '
        'tslFileName
        '
        Me.tslFileName.Name = "tslFileName"
        Me.tslFileName.Size = New System.Drawing.Size(71, 17)
        Me.tslFileName.Text = "File Name - "
        Me.tslFileName.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.TournamentToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1259, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseTournamentToolStripMenuItem, Me.ToolStripSeparator3, Me.SaveTournamentToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripSeparator1})
        Me.FileToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'CloseTournamentToolStripMenuItem
        '
        Me.CloseTournamentToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Replace
        Me.CloseTournamentToolStripMenuItem.Name = "CloseTournamentToolStripMenuItem"
        Me.CloseTournamentToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CloseTournamentToolStripMenuItem.Text = "&Close Tournament"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.MergeAction = System.Windows.Forms.MergeAction.MatchOnly
        Me.ToolStripSeparator3.MergeIndex = 1
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(177, 6)
        '
        'SaveTournamentToolStripMenuItem
        '
        Me.SaveTournamentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CommaSeparatedValuesFilecsvToolStripMenuItem, Me.TournamentXMLxmlToolStripMenuItem})
        Me.SaveTournamentToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Replace
        Me.SaveTournamentToolStripMenuItem.Name = "SaveTournamentToolStripMenuItem"
        Me.SaveTournamentToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
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
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
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
        Me.ToolStripSeparator1.MergeAction = System.Windows.Forms.MergeAction.MatchOnly
        Me.ToolStripSeparator1.MergeIndex = 2
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'TournamentToolStripMenuItem
        '
        Me.TournamentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenaltiesToolStripMenuItem, Me.StaffJudgesToolStripMenuItem, Me.ToolStripSeparator2, Me.FullNameEntryToolStripMenuItem})
        Me.TournamentToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Replace
        Me.TournamentToolStripMenuItem.Name = "TournamentToolStripMenuItem"
        Me.TournamentToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.TournamentToolStripMenuItem.Text = "&Tournament"
        '
        'PenaltiesToolStripMenuItem
        '
        Me.PenaltiesToolStripMenuItem.Name = "PenaltiesToolStripMenuItem"
        Me.PenaltiesToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.PenaltiesToolStripMenuItem.Text = "&Penalties"
        '
        'StaffJudgesToolStripMenuItem
        '
        Me.StaffJudgesToolStripMenuItem.Name = "StaffJudgesToolStripMenuItem"
        Me.StaffJudgesToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
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
        'AddFromCSVToolStripMenuItem
        '
        Me.AddFromCSVToolStripMenuItem.Name = "AddFromCSVToolStripMenuItem"
        Me.AddFromCSVToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AddFromCSVToolStripMenuItem.Text = "Add from &CSV"
        '
        'AddFromXMLToolStripMenuItem
        '
        Me.AddFromXMLToolStripMenuItem.Name = "AddFromXMLToolStripMenuItem"
        Me.AddFromXMLToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AddFromXMLToolStripMenuItem.Text = "Add from &XML"
        '
        'cmsAddFromFile
        '
        Me.cmsAddFromFile.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddFromCSVToolStripMenuItem, Me.AddFromXMLToolStripMenuItem})
        Me.cmsAddFromFile.Name = "cmsAddFromFile"
        Me.cmsAddFromFile.Size = New System.Drawing.Size(153, 48)
        '
        'OpenFileDialogCSV
        '
        Me.OpenFileDialogCSV.DefaultExt = "csv"
        Me.OpenFileDialogCSV.Filter = "Comma-Seperated Files (*.csv)|*.csv|All Files (*.*)|*.*"
        Me.OpenFileDialogCSV.Title = "Open Bandai+ Ready CSV File"
        '
        'OpenFileDialogXML
        '
        Me.OpenFileDialogXML.Filter = "Tournament XML (*.xml)|*.xml|All Files (*.*)|*.*"
        '
        'cmsTournamentList
        '
        Me.cmsTournamentList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeMembershipNumberToolStripMenuItem, Me.ChangeTeamIDToolStripMenuItem, Me.DeletePlayerFromTournamentToolStripMenuItem, Me.ChangePlayerStatusToToolStripMenuItem})
        Me.cmsTournamentList.Name = "cmsTournamentList"
        Me.cmsTournamentList.Size = New System.Drawing.Size(241, 92)
        '
        'ChangeMembershipNumberToolStripMenuItem
        '
        Me.ChangeMembershipNumberToolStripMenuItem.Name = "ChangeMembershipNumberToolStripMenuItem"
        Me.ChangeMembershipNumberToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.ChangeMembershipNumberToolStripMenuItem.Text = "Change &Membership Number"
        '
        'ChangeTeamIDToolStripMenuItem
        '
        Me.ChangeTeamIDToolStripMenuItem.Name = "ChangeTeamIDToolStripMenuItem"
        Me.ChangeTeamIDToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.ChangeTeamIDToolStripMenuItem.Text = "Change &TeamID"
        '
        'DeletePlayerFromTournamentToolStripMenuItem
        '
        Me.DeletePlayerFromTournamentToolStripMenuItem.Name = "DeletePlayerFromTournamentToolStripMenuItem"
        Me.DeletePlayerFromTournamentToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.DeletePlayerFromTournamentToolStripMenuItem.Text = "Delete Player From Tournament"
        '
        'ChangePlayerStatusToToolStripMenuItem
        '
        Me.ChangePlayerStatusToToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AppliedToolStripMenuItem, Me.SuccessfulToolStripMenuItem, Me.WaitingListToolStripMenuItem, Me.UnsuccessfulToolStripMenuItem, Me.CancelledToolStripMenuItem, Me.SelectedCheckedInToolStripMenuItem, Me.WaitingForCancellationCheckedInToolStripMenuItem, Me.AbsentOnDayOfEventToolStripMenuItem, Me.AdvanceElectedToolStripMenuItem, Me.ParticipatingInTournamentToolStripMenuItem, Me.DroppedToolStripMenuItem})
        Me.ChangePlayerStatusToToolStripMenuItem.Name = "ChangePlayerStatusToToolStripMenuItem"
        Me.ChangePlayerStatusToToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.ChangePlayerStatusToToolStripMenuItem.Text = "Change Player Status To"
        '
        'AppliedToolStripMenuItem
        '
        Me.AppliedToolStripMenuItem.Name = "AppliedToolStripMenuItem"
        Me.AppliedToolStripMenuItem.Size = New System.Drawing.Size(275, 22)
        Me.AppliedToolStripMenuItem.Text = "&Applied"
        '
        'SuccessfulToolStripMenuItem
        '
        Me.SuccessfulToolStripMenuItem.Name = "SuccessfulToolStripMenuItem"
        Me.SuccessfulToolStripMenuItem.Size = New System.Drawing.Size(275, 22)
        Me.SuccessfulToolStripMenuItem.Text = "&Successful"
        '
        'WaitingListToolStripMenuItem
        '
        Me.WaitingListToolStripMenuItem.Name = "WaitingListToolStripMenuItem"
        Me.WaitingListToolStripMenuItem.Size = New System.Drawing.Size(275, 22)
        Me.WaitingListToolStripMenuItem.Text = "&Waiting List"
        '
        'UnsuccessfulToolStripMenuItem
        '
        Me.UnsuccessfulToolStripMenuItem.Name = "UnsuccessfulToolStripMenuItem"
        Me.UnsuccessfulToolStripMenuItem.Size = New System.Drawing.Size(275, 22)
        Me.UnsuccessfulToolStripMenuItem.Text = "&Unsuccessful"
        '
        'CancelledToolStripMenuItem
        '
        Me.CancelledToolStripMenuItem.Name = "CancelledToolStripMenuItem"
        Me.CancelledToolStripMenuItem.Size = New System.Drawing.Size(275, 22)
        Me.CancelledToolStripMenuItem.Text = "&Cancelled"
        '
        'SelectedCheckedInToolStripMenuItem
        '
        Me.SelectedCheckedInToolStripMenuItem.Name = "SelectedCheckedInToolStripMenuItem"
        Me.SelectedCheckedInToolStripMenuItem.Size = New System.Drawing.Size(275, 22)
        Me.SelectedCheckedInToolStripMenuItem.Text = "S&elected + Checked In"
        '
        'WaitingForCancellationCheckedInToolStripMenuItem
        '
        Me.WaitingForCancellationCheckedInToolStripMenuItem.Name = "WaitingForCancellationCheckedInToolStripMenuItem"
        Me.WaitingForCancellationCheckedInToolStripMenuItem.Size = New System.Drawing.Size(275, 22)
        Me.WaitingForCancellationCheckedInToolStripMenuItem.Text = "Wa&iting for Cancellation + Checked In"
        '
        'AbsentOnDayOfEventToolStripMenuItem
        '
        Me.AbsentOnDayOfEventToolStripMenuItem.Name = "AbsentOnDayOfEventToolStripMenuItem"
        Me.AbsentOnDayOfEventToolStripMenuItem.Size = New System.Drawing.Size(275, 22)
        Me.AbsentOnDayOfEventToolStripMenuItem.Text = "Abs&ent on Day of Event"
        '
        'AdvanceElectedToolStripMenuItem
        '
        Me.AdvanceElectedToolStripMenuItem.Name = "AdvanceElectedToolStripMenuItem"
        Me.AdvanceElectedToolStripMenuItem.Size = New System.Drawing.Size(275, 22)
        Me.AdvanceElectedToolStripMenuItem.Text = "A&dvance Elected"
        '
        'ParticipatingInTournamentToolStripMenuItem
        '
        Me.ParticipatingInTournamentToolStripMenuItem.Name = "ParticipatingInTournamentToolStripMenuItem"
        Me.ParticipatingInTournamentToolStripMenuItem.Size = New System.Drawing.Size(275, 22)
        Me.ParticipatingInTournamentToolStripMenuItem.Text = "&Participating in Tournament"
        '
        'DroppedToolStripMenuItem
        '
        Me.DroppedToolStripMenuItem.Name = "DroppedToolStripMenuItem"
        Me.DroppedToolStripMenuItem.Size = New System.Drawing.Size(275, 22)
        Me.DroppedToolStripMenuItem.Text = "&Dropped"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(190, 6)
        '
        'FullNameEntryToolStripMenuItem
        '
        Me.FullNameEntryToolStripMenuItem.Checked = True
        Me.FullNameEntryToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.FullNameEntryToolStripMenuItem.Name = "FullNameEntryToolStripMenuItem"
        Me.FullNameEntryToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.FullNameEntryToolStripMenuItem.Text = "&Full Player Name Entry"
        '
        'frmIndividual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1259, 636)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.cbSelectAll)
        Me.Controls.Add(Me.dgvPlayers)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(1258, 625)
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
        Me.cmsAddFromFile.ResumeLayout(False)
        Me.cmsTournamentList.ResumeLayout(False)
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
    Friend WithEvents tslPlayerPreReg As ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveTournamentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CommaSeparatedValuesFilecsvToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TournamentXMLxmlToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents CloseTournamentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TournamentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenaltiesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StaffJudgesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents SaveFileDialogCSV As SaveFileDialog
    Friend WithEvents SaveFileDialogXML As SaveFileDialog
    Friend WithEvents tslBorder As ToolStripStatusLabel
    Friend WithEvents tslActivePlayer As ToolStripStatusLabel
    Friend WithEvents tslSpacer As ToolStripStatusLabel
    Friend WithEvents tslFileName As ToolStripStatusLabel
    Friend WithEvents btnClear As Button
    Friend WithEvents btnShowAll As Button
    Friend WithEvents AddFromCSVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddFromXMLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmsAddFromFile As ContextMenuStrip
    Friend WithEvents OpenFileDialogCSV As OpenFileDialog
    Friend WithEvents OpenFileDialogXML As OpenFileDialog
    Friend WithEvents cmsTournamentList As ContextMenuStrip
    Friend WithEvents DeletePlayerFromTournamentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangePlayerStatusToToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AppliedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SuccessfulToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WaitingListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnsuccessfulToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CancelledToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectedCheckedInToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WaitingForCancellationCheckedInToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbsentOnDayOfEventToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdvanceElectedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ParticipatingInTournamentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DroppedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgcListIndex As DataGridViewTextBoxColumn
    Friend WithEvents dgcSelect As DataGridViewCheckBoxColumn
    Friend WithEvents dgcIndex As DataGridViewTextBoxColumn
    Friend WithEvents dgcTeamId As DataGridViewTextBoxColumn
    Friend WithEvents dgcMembershipNo As DataGridViewTextBoxColumn
    Friend WithEvents dgcNickname As DataGridViewTextBoxColumn
    Friend WithEvents dgcByesCount As DataGridViewTextBoxColumn
    Friend WithEvents dgcStatus As DataGridViewTextBoxColumn
    Friend WithEvents ChangeTeamIDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeMembershipNumberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents FullNameEntryToolStripMenuItem As ToolStripMenuItem
End Class
