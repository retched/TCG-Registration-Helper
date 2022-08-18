<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDuos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tslPlayerPreReg = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslBorder = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslActivePlayer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslSpacer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslFileName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnAddFromFile = New System.Windows.Forms.Button()
        Me.btnDeletePlayer = New System.Windows.Forms.Button()
        Me.cboChangeStatus = New System.Windows.Forms.ComboBox()
        Me.btnChangeChecked = New System.Windows.Forms.Button()
        Me.cbSelectAll = New System.Windows.Forms.CheckBox()
        Me.dgvTeams = New System.Windows.Forms.DataGridView()
        Me.dgcListIndex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgcSelect = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dgcTeamName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgcNickname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgcByesCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgcStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbSearchResults = New System.Windows.Forms.ListBox()
        Me.txtSearchPlayer = New System.Windows.Forms.TextBox()
        Me.btnSearchPlayer = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rbMembershipID = New System.Windows.Forms.RadioButton()
        Me.rbPlayerName = New System.Windows.Forms.RadioButton()
        Me.rbMemberName = New System.Windows.Forms.RadioButton()
        Me.btnShowAll = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tcTeams = New System.Windows.Forms.TabControl()
        Me.tpPlayerA = New System.Windows.Forms.TabPage()
        Me.btnClearPlayer1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPlayerNickname1 = New System.Windows.Forms.TextBox()
        Me.txtPlayerLastName1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPlayerFirstName1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMemberNo1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tpPlayerB = New System.Windows.Forms.TabPage()
        Me.btnClearPlayer2 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPlayerNickname2 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtPlayerLastName2 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtPlayerFirstName2 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtMemberNo2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.rbByes_1 = New System.Windows.Forms.RadioButton()
        Me.rbByes_0 = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.btnAddTeam = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClearTeam = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTeamName = New System.Windows.Forms.TextBox()
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
        Me.MasterPlayerRosterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintTournamentRosterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PageSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TournamentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenaltiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffJudgesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsPlayerList = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ChangePlayerDetails0ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeletePlayerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialogCSV = New System.Windows.Forms.SaveFileDialog()
        Me.SaveFileDialogXML = New System.Windows.Forms.SaveFileDialog()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvTeams, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.tcTeams.SuspendLayout()
        Me.tpPlayerA.SuspendLayout()
        Me.tpPlayerB.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.cmsPlayerList.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslPlayerPreReg, Me.tslBorder, Me.tslActivePlayer, Me.tslSpacer, Me.tslFileName})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 614)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1252, 22)
        Me.StatusStrip1.TabIndex = 12
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
        Me.tslSpacer.Size = New System.Drawing.Size(989, 17)
        Me.tslSpacer.Spring = True
        '
        'tslFileName
        '
        Me.tslFileName.Name = "tslFileName"
        Me.tslFileName.Size = New System.Drawing.Size(71, 17)
        Me.tslFileName.Text = "File Name - "
        Me.tslFileName.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.btnAddFromFile)
        Me.Panel3.Controls.Add(Me.btnDeletePlayer)
        Me.Panel3.Controls.Add(Me.cboChangeStatus)
        Me.Panel3.Controls.Add(Me.btnChangeChecked)
        Me.Panel3.Location = New System.Drawing.Point(516, 569)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(724, 29)
        Me.Panel3.TabIndex = 11
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
        Me.btnDeletePlayer.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
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
        Me.cboChangeStatus.Font = New System.Drawing.Font("Segoe UI", 11.0!)
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
        'cbSelectAll
        '
        Me.cbSelectAll.AutoSize = True
        Me.cbSelectAll.Location = New System.Drawing.Point(516, 14)
        Me.cbSelectAll.Name = "cbSelectAll"
        Me.cbSelectAll.Size = New System.Drawing.Size(107, 17)
        Me.cbSelectAll.TabIndex = 9
        Me.cbSelectAll.Text = "Select All Players"
        Me.cbSelectAll.UseVisualStyleBackColor = True
        '
        'dgvTeams
        '
        Me.dgvTeams.AllowUserToAddRows = False
        Me.dgvTeams.AllowUserToDeleteRows = False
        Me.dgvTeams.AllowUserToResizeColumns = False
        Me.dgvTeams.AllowUserToResizeRows = False
        Me.dgvTeams.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTeams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTeams.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTeams.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTeams.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgcListIndex, Me.dgcSelect, Me.dgcTeamName, Me.dgcNickname, Me.dgcByesCount, Me.dgcStatus})
        Me.dgvTeams.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgvTeams.EnableHeadersVisualStyles = False
        Me.dgvTeams.Location = New System.Drawing.Point(516, 39)
        Me.dgvTeams.Name = "dgvTeams"
        Me.dgvTeams.RowHeadersVisible = False
        Me.dgvTeams.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvTeams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTeams.Size = New System.Drawing.Size(724, 524)
        Me.dgvTeams.TabIndex = 10
        '
        'dgcListIndex
        '
        Me.dgcListIndex.HeaderText = "lstTeamID"
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
        'dgcTeamName
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgcTeamName.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgcTeamName.FillWeight = 110.0!
        Me.dgcTeamName.HeaderText = "Team Name"
        Me.dgcTeamName.Name = "dgcTeamName"
        Me.dgcTeamName.ReadOnly = True
        '
        'dgcNickname
        '
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgcNickname.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgcNickname.FillWeight = 160.0!
        Me.dgcNickname.HeaderText = "Team Members (Player Name)"
        Me.dgcNickname.Name = "dgcNickname"
        Me.dgcNickname.ReadOnly = True
        '
        'dgcByesCount
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
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
        'lbSearchResults
        '
        Me.lbSearchResults.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lbSearchResults.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbSearchResults.FormattingEnabled = True
        Me.lbSearchResults.ItemHeight = 21
        Me.lbSearchResults.Location = New System.Drawing.Point(6, 95)
        Me.lbSearchResults.Name = "lbSearchResults"
        Me.lbSearchResults.Size = New System.Drawing.Size(485, 130)
        Me.lbSearchResults.TabIndex = 3
        '
        'txtSearchPlayer
        '
        Me.txtSearchPlayer.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtSearchPlayer.Location = New System.Drawing.Point(6, 26)
        Me.txtSearchPlayer.Name = "txtSearchPlayer"
        Me.txtSearchPlayer.Size = New System.Drawing.Size(267, 29)
        Me.txtSearchPlayer.TabIndex = 0
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
        Me.rbMembershipID.Font = New System.Drawing.Font("Segoe UI", 9.5!)
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
        Me.rbPlayerName.Font = New System.Drawing.Font("Segoe UI", 9.5!)
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
        Me.rbMemberName.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.rbMemberName.Location = New System.Drawing.Point(320, 7)
        Me.rbMemberName.Name = "rbMemberName"
        Me.rbMemberName.Size = New System.Drawing.Size(161, 21)
        Me.rbMemberName.TabIndex = 2
        Me.rbMemberName.Text = "Sort by Member Name"
        Me.rbMemberName.UseVisualStyleBackColor = True
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
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.btnShowAll)
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Controls.Add(Me.btnSearchPlayer)
        Me.GroupBox2.Controls.Add(Me.txtSearchPlayer)
        Me.GroupBox2.Controls.Add(Me.lbSearchResults)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 370)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(497, 228)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Player Search"
        '
        'tcTeams
        '
        Me.tcTeams.Controls.Add(Me.tpPlayerA)
        Me.tcTeams.Controls.Add(Me.tpPlayerB)
        Me.tcTeams.Location = New System.Drawing.Point(12, 14)
        Me.tcTeams.Name = "tcTeams"
        Me.tcTeams.SelectedIndex = 0
        Me.tcTeams.Size = New System.Drawing.Size(491, 203)
        Me.tcTeams.TabIndex = 4
        '
        'tpPlayerA
        '
        Me.tpPlayerA.Controls.Add(Me.btnClearPlayer1)
        Me.tpPlayerA.Controls.Add(Me.Label4)
        Me.tpPlayerA.Controls.Add(Me.txtPlayerNickname1)
        Me.tpPlayerA.Controls.Add(Me.txtPlayerLastName1)
        Me.tpPlayerA.Controls.Add(Me.Label3)
        Me.tpPlayerA.Controls.Add(Me.txtPlayerFirstName1)
        Me.tpPlayerA.Controls.Add(Me.Label2)
        Me.tpPlayerA.Controls.Add(Me.txtMemberNo1)
        Me.tpPlayerA.Controls.Add(Me.Label1)
        Me.tpPlayerA.Location = New System.Drawing.Point(4, 22)
        Me.tpPlayerA.Name = "tpPlayerA"
        Me.tpPlayerA.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPlayerA.Size = New System.Drawing.Size(483, 177)
        Me.tpPlayerA.TabIndex = 0
        Me.tpPlayerA.Text = "Player A"
        Me.tpPlayerA.UseVisualStyleBackColor = True
        '
        'btnClearPlayer1
        '
        Me.btnClearPlayer1.Location = New System.Drawing.Point(384, 16)
        Me.btnClearPlayer1.Name = "btnClearPlayer1"
        Me.btnClearPlayer1.Size = New System.Drawing.Size(92, 29)
        Me.btnClearPlayer1.TabIndex = 4
        Me.btnClearPlayer1.Text = "Clear"
        Me.btnClearPlayer1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(7, 136)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 19)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Player Member Name*"
        '
        'txtPlayerNickname1
        '
        Me.txtPlayerNickname1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtPlayerNickname1.Location = New System.Drawing.Point(200, 131)
        Me.txtPlayerNickname1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPlayerNickname1.Name = "txtPlayerNickname1"
        Me.txtPlayerNickname1.Size = New System.Drawing.Size(276, 29)
        Me.txtPlayerNickname1.TabIndex = 3
        '
        'txtPlayerLastName1
        '
        Me.txtPlayerLastName1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtPlayerLastName1.Location = New System.Drawing.Point(200, 94)
        Me.txtPlayerLastName1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPlayerLastName1.Name = "txtPlayerLastName1"
        Me.txtPlayerLastName1.Size = New System.Drawing.Size(276, 29)
        Me.txtPlayerLastName1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(7, 99)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 19)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Player Last Name"
        '
        'txtPlayerFirstName1
        '
        Me.txtPlayerFirstName1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtPlayerFirstName1.Location = New System.Drawing.Point(200, 55)
        Me.txtPlayerFirstName1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPlayerFirstName1.Name = "txtPlayerFirstName1"
        Me.txtPlayerFirstName1.Size = New System.Drawing.Size(276, 29)
        Me.txtPlayerFirstName1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(7, 60)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 19)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Player First Name"
        '
        'txtMemberNo1
        '
        Me.txtMemberNo1.Font = New System.Drawing.Font("Courier New", 14.0!)
        Me.txtMemberNo1.Location = New System.Drawing.Point(200, 16)
        Me.txtMemberNo1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMemberNo1.MaxLength = 10
        Me.txtMemberNo1.Name = "txtMemberNo1"
        Me.txtMemberNo1.Size = New System.Drawing.Size(177, 29)
        Me.txtMemberNo1.TabIndex = 0
        Me.txtMemberNo1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(7, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 19)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "TCG+ Membership Number*"
        '
        'tpPlayerB
        '
        Me.tpPlayerB.Controls.Add(Me.btnClearPlayer2)
        Me.tpPlayerB.Controls.Add(Me.Label12)
        Me.tpPlayerB.Controls.Add(Me.txtPlayerNickname2)
        Me.tpPlayerB.Controls.Add(Me.Label14)
        Me.tpPlayerB.Controls.Add(Me.txtPlayerLastName2)
        Me.tpPlayerB.Controls.Add(Me.Label16)
        Me.tpPlayerB.Controls.Add(Me.txtPlayerFirstName2)
        Me.tpPlayerB.Controls.Add(Me.Label18)
        Me.tpPlayerB.Controls.Add(Me.txtMemberNo2)
        Me.tpPlayerB.Location = New System.Drawing.Point(4, 22)
        Me.tpPlayerB.Name = "tpPlayerB"
        Me.tpPlayerB.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPlayerB.Size = New System.Drawing.Size(483, 177)
        Me.tpPlayerB.TabIndex = 1
        Me.tpPlayerB.Text = "Player B"
        Me.tpPlayerB.UseVisualStyleBackColor = True
        '
        'btnClearPlayer2
        '
        Me.btnClearPlayer2.Location = New System.Drawing.Point(384, 16)
        Me.btnClearPlayer2.Name = "btnClearPlayer2"
        Me.btnClearPlayer2.Size = New System.Drawing.Size(92, 29)
        Me.btnClearPlayer2.TabIndex = 43
        Me.btnClearPlayer2.Text = "Clear"
        Me.btnClearPlayer2.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(7, 136)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(148, 19)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "Player Member Name*"
        '
        'txtPlayerNickname2
        '
        Me.txtPlayerNickname2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtPlayerNickname2.Location = New System.Drawing.Point(200, 131)
        Me.txtPlayerNickname2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPlayerNickname2.Name = "txtPlayerNickname2"
        Me.txtPlayerNickname2.Size = New System.Drawing.Size(276, 29)
        Me.txtPlayerNickname2.TabIndex = 42
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(7, 99)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(115, 19)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "Player Last Name"
        '
        'txtPlayerLastName2
        '
        Me.txtPlayerLastName2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtPlayerLastName2.Location = New System.Drawing.Point(200, 94)
        Me.txtPlayerLastName2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPlayerLastName2.Name = "txtPlayerLastName2"
        Me.txtPlayerLastName2.Size = New System.Drawing.Size(276, 29)
        Me.txtPlayerLastName2.TabIndex = 39
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(7, 60)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(116, 19)
        Me.Label16.TabIndex = 47
        Me.Label16.Text = "Player First Name"
        '
        'txtPlayerFirstName2
        '
        Me.txtPlayerFirstName2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtPlayerFirstName2.Location = New System.Drawing.Point(200, 55)
        Me.txtPlayerFirstName2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPlayerFirstName2.Name = "txtPlayerFirstName2"
        Me.txtPlayerFirstName2.Size = New System.Drawing.Size(276, 29)
        Me.txtPlayerFirstName2.TabIndex = 37
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(7, 21)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(185, 19)
        Me.Label18.TabIndex = 44
        Me.Label18.Text = "TCG+ Membership Number*"
        '
        'txtMemberNo2
        '
        Me.txtMemberNo2.Font = New System.Drawing.Font("Courier New", 14.0!)
        Me.txtMemberNo2.Location = New System.Drawing.Point(200, 16)
        Me.txtMemberNo2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMemberNo2.MaxLength = 10
        Me.txtMemberNo2.Name = "txtMemberNo2"
        Me.txtMemberNo2.Size = New System.Drawing.Size(177, 29)
        Me.txtMemberNo2.TabIndex = 35
        Me.txtMemberNo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(11, 46)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 19)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Assigned Byes"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.rbByes_1)
        Me.Panel5.Controls.Add(Me.rbByes_0)
        Me.Panel5.Location = New System.Drawing.Point(204, 41)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(276, 29)
        Me.Panel5.TabIndex = 43
        '
        'rbByes_1
        '
        Me.rbByes_1.AutoSize = True
        Me.rbByes_1.Location = New System.Drawing.Point(153, 5)
        Me.rbByes_1.Name = "rbByes_1"
        Me.rbByes_1.Size = New System.Drawing.Size(100, 17)
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
        Me.rbByes_0.Size = New System.Drawing.Size(111, 17)
        Me.rbByes_0.TabIndex = 0
        Me.rbByes_0.TabStop = True
        Me.rbByes_0.Text = "No Assigned Byes"
        Me.rbByes_0.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(11, 81)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 19)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Status"
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Location = New System.Drawing.Point(204, 76)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(276, 28)
        Me.cboStatus.TabIndex = 45
        '
        'btnAddTeam
        '
        Me.btnAddTeam.Location = New System.Drawing.Point(81, 110)
        Me.btnAddTeam.Name = "btnAddTeam"
        Me.btnAddTeam.Size = New System.Drawing.Size(159, 29)
        Me.btnAddTeam.TabIndex = 46
        Me.btnAddTeam.Text = "Add Team to Tournament"
        Me.btnAddTeam.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnClearTeam)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtTeamName)
        Me.Panel1.Controls.Add(Me.btnAddTeam)
        Me.Panel1.Controls.Add(Me.cboStatus)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(12, 219)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(487, 145)
        Me.Panel1.TabIndex = 14
        '
        'btnClearTeam
        '
        Me.btnClearTeam.Location = New System.Drawing.Point(246, 110)
        Me.btnClearTeam.Name = "btnClearTeam"
        Me.btnClearTeam.Size = New System.Drawing.Size(159, 29)
        Me.btnClearTeam.TabIndex = 52
        Me.btnClearTeam.Text = "Clear Entrant"
        Me.btnClearTeam.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(11, 10)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 19)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Team Name*"
        '
        'txtTeamName
        '
        Me.txtTeamName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtTeamName.Location = New System.Drawing.Point(204, 5)
        Me.txtTeamName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTeamName.Name = "txtTeamName"
        Me.txtTeamName.Size = New System.Drawing.Size(276, 29)
        Me.txtTeamName.TabIndex = 50
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.TournamentToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1252, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseTournamentToolStripMenuItem, Me.ToolStripSeparator3, Me.SaveTournamentToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripSeparator1, Me.MasterPlayerRosterToolStripMenuItem, Me.PrintTournamentRosterToolStripMenuItem, Me.PageSetupToolStripMenuItem, Me.ToolStripSeparator2})
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
        'MasterPlayerRosterToolStripMenuItem
        '
        Me.MasterPlayerRosterToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Replace
        Me.MasterPlayerRosterToolStripMenuItem.Name = "MasterPlayerRosterToolStripMenuItem"
        Me.MasterPlayerRosterToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.MasterPlayerRosterToolStripMenuItem.Text = "&Master Player Roster"
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
        Me.PenaltiesToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.PenaltiesToolStripMenuItem.Text = "&Penalties"
        '
        'StaffJudgesToolStripMenuItem
        '
        Me.StaffJudgesToolStripMenuItem.Name = "StaffJudgesToolStripMenuItem"
        Me.StaffJudgesToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.StaffJudgesToolStripMenuItem.Text = "&Staff/Judges"
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
        'frmDuos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1252, 636)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tcTeams)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.cbSelectAll)
        Me.Controls.Add(Me.dgvTeams)
        Me.Controls.Add(Me.GroupBox2)
        Me.MinimumSize = New System.Drawing.Size(1258, 625)
        Me.Name = "frmDuos"
        Me.Text = "Registration - Two Player Teams"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvTeams, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tcTeams.ResumeLayout(False)
        Me.tpPlayerA.ResumeLayout(False)
        Me.tpPlayerA.PerformLayout()
        Me.tpPlayerB.ResumeLayout(False)
        Me.tpPlayerB.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.cmsPlayerList.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tslPlayerPreReg As ToolStripStatusLabel
    Friend WithEvents tslBorder As ToolStripStatusLabel
    Friend WithEvents tslActivePlayer As ToolStripStatusLabel
    Friend WithEvents tslSpacer As ToolStripStatusLabel
    Friend WithEvents tslFileName As ToolStripStatusLabel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnAddFromFile As Button
    Friend WithEvents btnDeletePlayer As Button
    Friend WithEvents cboChangeStatus As ComboBox
    Friend WithEvents btnChangeChecked As Button
    Friend WithEvents cbSelectAll As CheckBox
    Friend WithEvents dgvTeams As DataGridView
    Friend WithEvents lbSearchResults As ListBox
    Friend WithEvents txtSearchPlayer As TextBox
    Friend WithEvents btnSearchPlayer As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents rbMembershipID As RadioButton
    Friend WithEvents rbPlayerName As RadioButton
    Friend WithEvents rbMemberName As RadioButton
    Friend WithEvents btnShowAll As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tcTeams As TabControl
    Friend WithEvents tpPlayerA As TabPage
    Friend WithEvents btnClearPlayer1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPlayerLastName1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPlayerFirstName1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMemberNo1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tpPlayerB As TabPage
    Friend WithEvents btnClearPlayer2 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents txtPlayerNickname2 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtPlayerLastName2 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtPlayerFirstName2 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtMemberNo2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents rbByes_1 As RadioButton
    Friend WithEvents rbByes_0 As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents btnAddTeam As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtPlayerNickname1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTeamName As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseTournamentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents SaveTournamentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CommaSeparatedValuesFilecsvToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TournamentXMLxmlToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents MasterPlayerRosterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintTournamentRosterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PageSetupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents TournamentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenaltiesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StaffJudgesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnClearTeam As Button
    Friend WithEvents dgcListIndex As DataGridViewTextBoxColumn
    Friend WithEvents dgcSelect As DataGridViewCheckBoxColumn
    Friend WithEvents dgcTeamName As DataGridViewTextBoxColumn
    Friend WithEvents dgcNickname As DataGridViewTextBoxColumn
    Friend WithEvents dgcByesCount As DataGridViewTextBoxColumn
    Friend WithEvents dgcStatus As DataGridViewTextBoxColumn
    Friend WithEvents cmsPlayerList As ContextMenuStrip
    Friend WithEvents ChangePlayerDetails0ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeletePlayerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialogCSV As SaveFileDialog
    Friend WithEvents SaveFileDialogXML As SaveFileDialog
End Class
