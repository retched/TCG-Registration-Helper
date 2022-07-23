<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlayerDetail
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
        Me.btnAddPlayer = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPlayerNickname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPlayerLastName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPlayerFirstName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMemberNo = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddPlayer
        '
        Me.btnAddPlayer.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAddPlayer.Location = New System.Drawing.Point(85, 164)
        Me.btnAddPlayer.Name = "btnAddPlayer"
        Me.btnAddPlayer.Size = New System.Drawing.Size(159, 29)
        Me.btnAddPlayer.TabIndex = 8
        Me.btnAddPlayer.Text = "Add to Master List"
        Me.btnAddPlayer.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(13, 133)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Player Member Name*"
        '
        'txtPlayerNickname
        '
        Me.txtPlayerNickname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtPlayerNickname.Location = New System.Drawing.Point(206, 128)
        Me.txtPlayerNickname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPlayerNickname.Name = "txtPlayerNickname"
        Me.txtPlayerNickname.Size = New System.Drawing.Size(276, 29)
        Me.txtPlayerNickname.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(13, 96)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Player Last Name"
        '
        'txtPlayerLastName
        '
        Me.txtPlayerLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtPlayerLastName.Location = New System.Drawing.Point(206, 91)
        Me.txtPlayerLastName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPlayerLastName.Name = "txtPlayerLastName"
        Me.txtPlayerLastName.Size = New System.Drawing.Size(276, 29)
        Me.txtPlayerLastName.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(13, 57)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Player First Name"
        '
        'txtPlayerFirstName
        '
        Me.txtPlayerFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtPlayerFirstName.Location = New System.Drawing.Point(206, 52)
        Me.txtPlayerFirstName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPlayerFirstName.Name = "txtPlayerFirstName"
        Me.txtPlayerFirstName.Size = New System.Drawing.Size(276, 29)
        Me.txtPlayerFirstName.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(13, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TCG+ Membership Number*"
        '
        'txtMemberNo
        '
        Me.txtMemberNo.Font = New System.Drawing.Font("Courier New", 14.0!)
        Me.txtMemberNo.Location = New System.Drawing.Point(206, 13)
        Me.txtMemberNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMemberNo.MaxLength = 10
        Me.txtMemberNo.Multiline = True
        Me.txtMemberNo.Name = "txtMemberNo"
        Me.txtMemberNo.Size = New System.Drawing.Size(177, 29)
        Me.txtMemberNo.TabIndex = 1
        Me.txtMemberNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(250, 164)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(159, 29)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmPlayerDetail
        '
        Me.AcceptButton = Me.btnAddPlayer
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 205)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAddPlayer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPlayerNickname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPlayerLastName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPlayerFirstName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMemberNo)
        Me.Name = "frmPlayerDetail"
        Me.Text = "Add New Player to Master List"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAddPlayer As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPlayerNickname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPlayerLastName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPlayerFirstName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMemberNo As TextBox
    Friend WithEvents btnCancel As Button
End Class
