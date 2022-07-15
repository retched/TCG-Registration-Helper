Imports System.Xml

Public Class frmMainMenu
    Private m_ChildFormNumber As Integer

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private Sub IndividualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IndividualPlayerToolStripMenuItem.Click
        Dim ChildForm As New frmIndividual
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        'ChildForm.Text = ChildForm.Text

        ChildForm.Show()
    End Sub

    Private Sub CommaSeparatedValueFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CommaSeparatedValueFileToolStripMenuItem.Click

        OpenFileDialogCSV.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments

        If (OpenFileDialogCSV.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialogCSV.FileName

            ' This should create a copy of frmIndividual
            Dim ChildForm As New frmIndividual
            ' Make it a child of this MDI form before showing it.
            ChildForm.MdiParent = Me

            ' Set the name of the CSV File.
            ChildForm.txtCSVFileName = FileName

            m_ChildFormNumber += 1
            ChildForm.Text = "(" & m_ChildFormNumber & ") " & ChildForm.Text

            ChildForm.Show()

        End If
    End Sub

    Private Sub TournamentXMLxmlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TournamentXMLxmlToolStripMenuItem.Click

        OpenFileDialogXML.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments

        If (OpenFileDialogXML.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialogXML.FileName
            ' TODO: Add code here to open the file.

            ' This should create a copy of frmIndividual
            Dim ChildForm As New frmIndividual
            ' Make it a child of this MDI form before showing it.
            ChildForm.MdiParent = Me

            ' Set the name of the CSV File.
            ChildForm.txtCSVFileName = FileName

            m_ChildFormNumber += 1
            ChildForm.Text = ChildForm.Text & "-" & FileName

            ChildForm.Show()

        End If
    End Sub
End Class
