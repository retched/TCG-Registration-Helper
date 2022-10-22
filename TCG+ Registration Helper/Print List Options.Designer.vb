<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintListOptions
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
        Me.cbRosterOption = New System.Windows.Forms.CheckBox()
        Me.cbBlankOption = New System.Windows.Forms.CheckBox()
        Me.nudBlankPages = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.nudBlankPages, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(78, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Print Sign Up Sheets"
        '
        'cbRosterOption
        '
        Me.cbRosterOption.AutoSize = True
        Me.cbRosterOption.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRosterOption.Location = New System.Drawing.Point(12, 56)
        Me.cbRosterOption.Name = "cbRosterOption"
        Me.cbRosterOption.Size = New System.Drawing.Size(308, 28)
        Me.cbRosterOption.TabIndex = 1
        Me.cbRosterOption.Text = "Print Pre-Filled Sheets For Roster"
        Me.cbRosterOption.UseVisualStyleBackColor = True
        '
        'cbBlankOption
        '
        Me.cbBlankOption.AutoSize = True
        Me.cbBlankOption.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBlankOption.Location = New System.Drawing.Point(11, 90)
        Me.cbBlankOption.Name = "cbBlankOption"
        Me.cbBlankOption.Size = New System.Drawing.Size(180, 28)
        Me.cbBlankOption.TabIndex = 2
        Me.cbBlankOption.Text = "Print Blank Sheets"
        Me.cbBlankOption.UseVisualStyleBackColor = True
        '
        'nudBlankPages
        '
        Me.nudBlankPages.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudBlankPages.Location = New System.Drawing.Point(211, 89)
        Me.nudBlankPages.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudBlankPages.Name = "nudBlankPages"
        Me.nudBlankPages.Size = New System.Drawing.Size(85, 29)
        Me.nudBlankPages.TabIndex = 3
        Me.nudBlankPages.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudBlankPages.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(302, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Pages"
        '
        'btnAccept
        '
        Me.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAccept.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccept.Location = New System.Drawing.Point(51, 124)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(141, 41)
        Me.btnAccept.TabIndex = 5
        Me.btnAccept.Text = "OK"
        Me.btnAccept.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(198, 124)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(141, 41)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmPrintListOptions
        '
        Me.AcceptButton = Me.btnAccept
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(390, 177)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nudBlankPages)
        Me.Controls.Add(Me.cbBlankOption)
        Me.Controls.Add(Me.cbRosterOption)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmPrintListOptions"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Print List Options"
        CType(Me.nudBlankPages, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbRosterOption As CheckBox
    Friend WithEvents cbBlankOption As CheckBox
    Friend WithEvents nudBlankPages As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAccept As Button
    Friend WithEvents btnCancel As Button
End Class
