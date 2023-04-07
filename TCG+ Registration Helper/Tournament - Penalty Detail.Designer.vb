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
        Me.Label1.Location = New System.Drawing.Point(10, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Player"
        '
        'cboPlayer
        '
        Me.cboPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPlayer.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cboPlayer.FormattingEnabled = True
        Me.cboPlayer.Location = New System.Drawing.Point(113, 10)
        Me.cboPlayer.Name = "cboPlayer"
        Me.cboPlayer.Size = New System.Drawing.Size(413, 29)
        Me.cboPlayer.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Judge"
        '
        'cboJudge
        '
        Me.cboJudge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboJudge.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cboJudge.FormattingEnabled = True
        Me.cboJudge.Location = New System.Drawing.Point(113, 59)
        Me.cboJudge.Name = "cboJudge"
        Me.cboJudge.Size = New System.Drawing.Size(413, 29)
        Me.cboJudge.TabIndex = 3
        '
        'cboInfraction
        '
        Me.cboInfraction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboInfraction.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cboInfraction.FormattingEnabled = True
        Me.cboInfraction.Location = New System.Drawing.Point(113, 107)
        Me.cboInfraction.Name = "cboInfraction"
        Me.cboInfraction.Size = New System.Drawing.Size(413, 29)
        Me.cboInfraction.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Infraction"
        '
        'cboPenalty
        '
        Me.cboPenalty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPenalty.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cboPenalty.FormattingEnabled = True
        Me.cboPenalty.Location = New System.Drawing.Point(113, 156)
        Me.cboPenalty.Name = "cboPenalty"
        Me.cboPenalty.Size = New System.Drawing.Size(413, 29)
        Me.cboPenalty.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Penalty Issued"
        '
        'nudRound
        '
        Me.nudRound.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.nudRound.Location = New System.Drawing.Point(113, 200)
        Me.nudRound.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.nudRound.Name = "nudRound"
        Me.nudRound.Size = New System.Drawing.Size(67, 29)
        Me.nudRound.TabIndex = 9
        Me.nudRound.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Round #"
        '
        'txtPenaltyNotes
        '
        Me.txtPenaltyNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPenaltyNotes.Location = New System.Drawing.Point(113, 248)
        Me.txtPenaltyNotes.Multiline = True
        Me.txtPenaltyNotes.Name = "txtPenaltyNotes"
        Me.txtPenaltyNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPenaltyNotes.Size = New System.Drawing.Size(413, 107)
        Me.txtPenaltyNotes.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 248)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Penalty Notes"
        '
        'btnAddPenalty
        '
        Me.btnAddPenalty.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAddPenalty.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAddPenalty.Location = New System.Drawing.Point(156, 361)
        Me.btnAddPenalty.Name = "btnAddPenalty"
        Me.btnAddPenalty.Size = New System.Drawing.Size(109, 25)
        Me.btnAddPenalty.TabIndex = 12
        Me.btnAddPenalty.Text = "&OK"
        Me.btnAddPenalty.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(270, 361)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 25)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "&Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(186, 195)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(274, 45)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Round 0 = Before the official start of the event"
        '
        'frmPenaltyDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 397)
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
