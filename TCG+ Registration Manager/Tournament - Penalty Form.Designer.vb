<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPenalties
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
        Me.dgvPenalties = New System.Windows.Forms.DataGridView()
        Me.dgcPenaltyID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgcPlayer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgcInfractionType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgcPenalty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgcRound = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgcJudge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgcNotes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAddPenalty = New System.Windows.Forms.Button()
        Me.btnEditPenalty = New System.Windows.Forms.Button()
        Me.btnDeletePenalty = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.dgvPenalties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPenalties
        '
        Me.dgvPenalties.AllowUserToAddRows = False
        Me.dgvPenalties.AllowUserToResizeRows = False
        Me.dgvPenalties.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPenalties.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPenalties.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgcPenaltyID, Me.dgcPlayer, Me.dgcInfractionType, Me.dgcPenalty, Me.dgcRound, Me.dgcJudge, Me.dgcNotes})
        Me.dgvPenalties.Location = New System.Drawing.Point(12, 12)
        Me.dgvPenalties.Name = "dgvPenalties"
        Me.dgvPenalties.RowHeadersVisible = False
        Me.dgvPenalties.RowTemplate.Height = 25
        Me.dgvPenalties.Size = New System.Drawing.Size(674, 352)
        Me.dgvPenalties.TabIndex = 0
        '
        'dgcPenaltyID
        '
        Me.dgcPenaltyID.HeaderText = "ID"
        Me.dgcPenaltyID.Name = "dgcPenaltyID"
        Me.dgcPenaltyID.Visible = False
        '
        'dgcPlayer
        '
        Me.dgcPlayer.HeaderText = "Player"
        Me.dgcPlayer.Name = "dgcPlayer"
        Me.dgcPlayer.ReadOnly = True
        '
        'dgcInfractionType
        '
        Me.dgcInfractionType.HeaderText = "Infraction Type"
        Me.dgcInfractionType.Name = "dgcInfractionType"
        Me.dgcInfractionType.ReadOnly = True
        '
        'dgcPenalty
        '
        Me.dgcPenalty.HeaderText = "Penalty"
        Me.dgcPenalty.Name = "dgcPenalty"
        '
        'dgcRound
        '
        Me.dgcRound.HeaderText = "Round #"
        Me.dgcRound.Name = "dgcRound"
        Me.dgcRound.ReadOnly = True
        '
        'dgcJudge
        '
        Me.dgcJudge.HeaderText = "Judge"
        Me.dgcJudge.Name = "dgcJudge"
        Me.dgcJudge.ReadOnly = True
        '
        'dgcNotes
        '
        Me.dgcNotes.HeaderText = "Notes"
        Me.dgcNotes.Name = "dgcNotes"
        Me.dgcNotes.ReadOnly = True
        '
        'btnAddPenalty
        '
        Me.btnAddPenalty.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAddPenalty.Location = New System.Drawing.Point(86, 370)
        Me.btnAddPenalty.Name = "btnAddPenalty"
        Me.btnAddPenalty.Size = New System.Drawing.Size(127, 29)
        Me.btnAddPenalty.TabIndex = 1
        Me.btnAddPenalty.Text = "&Add Penalty"
        Me.btnAddPenalty.UseVisualStyleBackColor = True
        '
        'btnEditPenalty
        '
        Me.btnEditPenalty.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnEditPenalty.Location = New System.Drawing.Point(219, 370)
        Me.btnEditPenalty.Name = "btnEditPenalty"
        Me.btnEditPenalty.Size = New System.Drawing.Size(127, 29)
        Me.btnEditPenalty.TabIndex = 2
        Me.btnEditPenalty.Text = "&Edit Penalty"
        Me.btnEditPenalty.UseVisualStyleBackColor = True
        '
        'btnDeletePenalty
        '
        Me.btnDeletePenalty.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDeletePenalty.Location = New System.Drawing.Point(352, 370)
        Me.btnDeletePenalty.Name = "btnDeletePenalty"
        Me.btnDeletePenalty.Size = New System.Drawing.Size(127, 29)
        Me.btnDeletePenalty.TabIndex = 3
        Me.btnDeletePenalty.Text = "&Delete Penalty"
        Me.btnDeletePenalty.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnClose.Location = New System.Drawing.Point(485, 370)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(127, 29)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmPenalties
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 411)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDeletePenalty)
        Me.Controls.Add(Me.btnEditPenalty)
        Me.Controls.Add(Me.btnAddPenalty)
        Me.Controls.Add(Me.dgvPenalties)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(564, 427)
        Me.Name = "frmPenalties"
        Me.ShowInTaskbar = False
        Me.Text = "Penalties"
        CType(Me.dgvPenalties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvPenalties As DataGridView
    Friend WithEvents btnAddPenalty As Button
    Friend WithEvents btnEditPenalty As Button
    Friend WithEvents btnDeletePenalty As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents dgcPenaltyID As DataGridViewTextBoxColumn
    Friend WithEvents dgcPlayer As DataGridViewTextBoxColumn
    Friend WithEvents dgcInfractionType As DataGridViewTextBoxColumn
    Friend WithEvents dgcPenalty As DataGridViewTextBoxColumn
    Friend WithEvents dgcRound As DataGridViewTextBoxColumn
    Friend WithEvents dgcJudge As DataGridViewTextBoxColumn
    Friend WithEvents dgcNotes As DataGridViewTextBoxColumn
End Class
