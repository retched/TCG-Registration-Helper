<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPenaltyDetail
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboPlayer = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboJudge = New System.Windows.Forms.ComboBox()
        Me.cboInfraction = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboPenalty = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nudRound = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPenaltyNotes = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAddPenalty = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.nudRound, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Player"
        '
        'cboPlayer
        '
        Me.cboPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPlayer.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cboPlayer.FormattingEnabled = True
        Me.cboPlayer.Location = New System.Drawing.Point(132, 12)
        Me.cboPlayer.Name = "cboPlayer"
        Me.cboPlayer.Size = New System.Drawing.Size(481, 29)
        Me.cboPlayer.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Judge"
        '
        'cboJudge
        '
        Me.cboJudge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboJudge.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cboJudge.FormattingEnabled = True
        Me.cboJudge.Location = New System.Drawing.Point(132, 68)
        Me.cboJudge.Name = "cboJudge"
        Me.cboJudge.Size = New System.Drawing.Size(481, 29)
        Me.cboJudge.TabIndex = 3
        '
        'cboInfraction
        '
        Me.cboInfraction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboInfraction.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cboInfraction.FormattingEnabled = True
        Me.cboInfraction.Location = New System.Drawing.Point(132, 124)
        Me.cboInfraction.Name = "cboInfraction"
        Me.cboInfraction.Size = New System.Drawing.Size(481, 29)
        Me.cboInfraction.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Infraction"
        '
        'cboPenalty
        '
        Me.cboPenalty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPenalty.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cboPenalty.FormattingEnabled = True
        Me.cboPenalty.Location = New System.Drawing.Point(132, 180)
        Me.cboPenalty.Name = "cboPenalty"
        Me.cboPenalty.Size = New System.Drawing.Size(481, 29)
        Me.cboPenalty.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Penalty Issued"
        '
        'nudRound
        '
        Me.nudRound.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.nudRound.Location = New System.Drawing.Point(132, 231)
        Me.nudRound.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.nudRound.Name = "nudRound"
        Me.nudRound.Size = New System.Drawing.Size(78, 29)
        Me.nudRound.TabIndex = 9
        Me.nudRound.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Round #"
        '
        'txtPenaltyNotes
        '
        Me.txtPenaltyNotes.Location = New System.Drawing.Point(132, 286)
        Me.txtPenaltyNotes.Multiline = True
        Me.txtPenaltyNotes.Name = "txtPenaltyNotes"
        Me.txtPenaltyNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPenaltyNotes.Size = New System.Drawing.Size(481, 92)
        Me.txtPenaltyNotes.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 286)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Penalty Notes"
        '
        'btnAddPenalty
        '
        Me.btnAddPenalty.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAddPenalty.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAddPenalty.Location = New System.Drawing.Point(182, 388)
        Me.btnAddPenalty.Name = "btnAddPenalty"
        Me.btnAddPenalty.Size = New System.Drawing.Size(127, 29)
        Me.btnAddPenalty.TabIndex = 12
        Me.btnAddPenalty.Text = "&OK"
        Me.btnAddPenalty.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(315, 388)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 29)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "&Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(216, 231)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(241, 39)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Round 0 = Before the official start of the event"
        '
        'frmPenaltyDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 429)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnAddPenalty)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPenaltyNotes)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.nudRound)
        Me.Controls.Add(Me.cboPenalty)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboInfraction)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboJudge)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboPlayer)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmPenaltyDetail"
        Me.ShowInTaskbar = False
        Me.Text = "Penalty Detail"
        CType(Me.nudRound, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cboPlayer As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboJudge As ComboBox
    Friend WithEvents cboInfraction As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboPenalty As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents nudRound As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPenaltyNotes As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnAddPenalty As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
End Class
