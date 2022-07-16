<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndividualPlayerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TwoPlayersPerTeamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThreePlayersPerTeamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenTournamentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommaSeparatedValueFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TournamentXMLxmlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseTournamentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveTournamentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommaSeparatedValuesFilecsvToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintTournamentRosterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PageSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TournamentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArrangeIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BandaiTCGTournamentPolicyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SoftwareOperatingManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialogCSV = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialogXML = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.TournamentToolStripMenuItem, Me.WindowToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MdiWindowListItem = Me.WindowToolStripMenuItem
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1286, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenTournamentToolStripMenuItem, Me.ToolStripSeparator2, Me.CloseTournamentToolStripMenuItem, Me.ToolStripSeparator3, Me.SaveTournamentToolStripMenuItem, Me.ToolStripMenuItem2, Me.ToolStripSeparator4, Me.PrintTournamentRosterToolStripMenuItem, Me.PageSetupToolStripMenuItem, Me.ToolStripSeparator5, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IndividualPlayerToolStripMenuItem, Me.TwoPlayersPerTeamToolStripMenuItem, Me.ThreePlayersPerTeamToolStripMenuItem})
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.NewToolStripMenuItem.Text = "&New Tournament"
        '
        'IndividualPlayerToolStripMenuItem
        '
        Me.IndividualPlayerToolStripMenuItem.Name = "IndividualPlayerToolStripMenuItem"
        Me.IndividualPlayerToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.IndividualPlayerToolStripMenuItem.Text = "&Single Player"
        '
        'TwoPlayersPerTeamToolStripMenuItem
        '
        Me.TwoPlayersPerTeamToolStripMenuItem.Name = "TwoPlayersPerTeamToolStripMenuItem"
        Me.TwoPlayersPerTeamToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.TwoPlayersPerTeamToolStripMenuItem.Text = "Two Players Per Team"
        Me.TwoPlayersPerTeamToolStripMenuItem.Visible = False
        '
        'ThreePlayersPerTeamToolStripMenuItem
        '
        Me.ThreePlayersPerTeamToolStripMenuItem.Name = "ThreePlayersPerTeamToolStripMenuItem"
        Me.ThreePlayersPerTeamToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ThreePlayersPerTeamToolStripMenuItem.Text = "Three Players Per Team"
        Me.ThreePlayersPerTeamToolStripMenuItem.Visible = False
        '
        'OpenTournamentToolStripMenuItem
        '
        Me.OpenTournamentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CommaSeparatedValueFileToolStripMenuItem, Me.TournamentXMLxmlToolStripMenuItem})
        Me.OpenTournamentToolStripMenuItem.Name = "OpenTournamentToolStripMenuItem"
        Me.OpenTournamentToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.OpenTournamentToolStripMenuItem.Text = "&Open Tournament"
        '
        'CommaSeparatedValueFileToolStripMenuItem
        '
        Me.CommaSeparatedValueFileToolStripMenuItem.Name = "CommaSeparatedValueFileToolStripMenuItem"
        Me.CommaSeparatedValueFileToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.CommaSeparatedValueFileToolStripMenuItem.Text = "&Comma-Separated Value File (.csv)"
        '
        'TournamentXMLxmlToolStripMenuItem
        '
        Me.TournamentXMLxmlToolStripMenuItem.Name = "TournamentXMLxmlToolStripMenuItem"
        Me.TournamentXMLxmlToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.TournamentXMLxmlToolStripMenuItem.Text = "&Tournament XML (.xml)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(199, 6)
        '
        'CloseTournamentToolStripMenuItem
        '
        Me.CloseTournamentToolStripMenuItem.Name = "CloseTournamentToolStripMenuItem"
        Me.CloseTournamentToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.CloseTournamentToolStripMenuItem.Text = "&Close Tournament"
        Me.CloseTournamentToolStripMenuItem.Visible = False
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(199, 6)
        Me.ToolStripSeparator3.Visible = False
        '
        'SaveTournamentToolStripMenuItem
        '
        Me.SaveTournamentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CommaSeparatedValuesFilecsvToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.SaveTournamentToolStripMenuItem.Name = "SaveTournamentToolStripMenuItem"
        Me.SaveTournamentToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.SaveTournamentToolStripMenuItem.Text = "&Save Tournament"
        Me.SaveTournamentToolStripMenuItem.Visible = False
        '
        'CommaSeparatedValuesFilecsvToolStripMenuItem
        '
        Me.CommaSeparatedValuesFilecsvToolStripMenuItem.Name = "CommaSeparatedValuesFilecsvToolStripMenuItem"
        Me.CommaSeparatedValuesFilecsvToolStripMenuItem.Size = New System.Drawing.Size(262, 22)
        Me.CommaSeparatedValuesFilecsvToolStripMenuItem.Text = "&Comma-Separated Values File (.csv)"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(262, 22)
        Me.ToolStripMenuItem1.Text = "Tournament XML (.xml)"
        Me.ToolStripMenuItem1.Visible = False
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3, Me.ToolStripMenuItem4})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(202, 22)
        Me.ToolStripMenuItem2.Text = "S&ave Copy As..."
        Me.ToolStripMenuItem2.Visible = False
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(262, 22)
        Me.ToolStripMenuItem3.Text = "&Comma-Separated Values File (.csv)"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(262, 22)
        Me.ToolStripMenuItem4.Text = "Tournament XML (.xml)"
        Me.ToolStripMenuItem4.Visible = False
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(199, 6)
        Me.ToolStripSeparator4.Visible = False
        '
        'PrintTournamentRosterToolStripMenuItem
        '
        Me.PrintTournamentRosterToolStripMenuItem.Name = "PrintTournamentRosterToolStripMenuItem"
        Me.PrintTournamentRosterToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.PrintTournamentRosterToolStripMenuItem.Text = "&Print Tournament Roster"
        Me.PrintTournamentRosterToolStripMenuItem.Visible = False
        '
        'PageSetupToolStripMenuItem
        '
        Me.PageSetupToolStripMenuItem.Name = "PageSetupToolStripMenuItem"
        Me.PageSetupToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.PageSetupToolStripMenuItem.Text = "P&age Setup"
        Me.PageSetupToolStripMenuItem.Visible = False
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(199, 6)
        Me.ToolStripSeparator5.Visible = False
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.MergeIndex = 30
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'TournamentToolStripMenuItem
        '
        Me.TournamentToolStripMenuItem.Name = "TournamentToolStripMenuItem"
        Me.TournamentToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.TournamentToolStripMenuItem.Text = "&Tournament"
        Me.TournamentToolStripMenuItem.Visible = False
        '
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CascadeToolStripMenuItem, Me.TileVerticalToolStripMenuItem, Me.TileHorizontalToolStripMenuItem, Me.ArrangeIconsToolStripMenuItem, Me.ToolStripSeparator1})
        Me.WindowToolStripMenuItem.MergeIndex = 6
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.WindowToolStripMenuItem.Text = "Window"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.CascadeToolStripMenuItem.Text = "&Cascade"
        '
        'TileVerticalToolStripMenuItem
        '
        Me.TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem"
        Me.TileVerticalToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.TileVerticalToolStripMenuItem.Text = "Tile &Vertical"
        '
        'TileHorizontalToolStripMenuItem
        '
        Me.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
        Me.TileHorizontalToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.TileHorizontalToolStripMenuItem.Text = "Tile &Horizontal"
        '
        'ArrangeIconsToolStripMenuItem
        '
        Me.ArrangeIconsToolStripMenuItem.Name = "ArrangeIconsToolStripMenuItem"
        Me.ArrangeIconsToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ArrangeIconsToolStripMenuItem.Text = "&Arrange Icons"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(147, 6)
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BandaiTCGTournamentPolicyToolStripMenuItem, Me.SoftwareOperatingManualToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'BandaiTCGTournamentPolicyToolStripMenuItem
        '
        Me.BandaiTCGTournamentPolicyToolStripMenuItem.Name = "BandaiTCGTournamentPolicyToolStripMenuItem"
        Me.BandaiTCGTournamentPolicyToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.BandaiTCGTournamentPolicyToolStripMenuItem.Text = "&Bandai TCG Tournament Policy"
        '
        'SoftwareOperatingManualToolStripMenuItem
        '
        Me.SoftwareOperatingManualToolStripMenuItem.Name = "SoftwareOperatingManualToolStripMenuItem"
        Me.SoftwareOperatingManualToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.SoftwareOperatingManualToolStripMenuItem.Text = "&Software Operating Manual"
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
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1286, 705)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MinimumSize = New System.Drawing.Size(1302, 744)
        Me.Name = "frmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TCG+ Tournament Entry Manager"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndividualPlayerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TwoPlayersPerTeamToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThreePlayersPerTeamToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TileVerticalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TileHorizontalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArrangeIconsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents OpenTournamentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CommaSeparatedValueFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TournamentXMLxmlToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialogCSV As OpenFileDialog
    Friend WithEvents OpenFileDialogXML As OpenFileDialog
    Friend WithEvents TournamentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseTournamentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents SaveTournamentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CommaSeparatedValuesFilecsvToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents PrintTournamentRosterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PageSetupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BandaiTCGTournamentPolicyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SoftwareOperatingManualToolStripMenuItem As ToolStripMenuItem
End Class
