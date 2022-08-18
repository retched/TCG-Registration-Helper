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

            ' TODO: Check for Duos or Trios Import Form
            ' First Row will contain a "- 1", "- 2", or "- 3"

            Using csvDoc As New FileIO.TextFieldParser(FileName)
                csvDoc.TextFieldType = FileIO.FieldType.Delimited
                csvDoc.Delimiters = New String() {","}
                csvDoc.HasFieldsEnclosedInQuotes = True

                Dim firstRow As String()
                Dim intPlayers As Integer
                Dim intLineCount As Integer = 0

                ' We're only reading the first row of, what should be, row headers
                firstRow = csvDoc.ReadFields()

                If firstRow(0) = "Team ID" Then
                    ' Skip this line, this is either a header OR the instruction row from Bandai.
                    If firstRow.Any(Function(f) f.Contains("- 3")) Then
                        intPlayers = 3

                    ElseIf firstRow.Any(Function(f) f.Contains("- 2")) Then
                        intPlayers = 2

                    Else intPlayers = 1
                    End If
                End If

                Select Case intPlayers
                    Case 3 ' Load Trios
                        ' This should create a copy of frmDuos
                        Dim ChildForm As New frmTrios
                        ' Make it a child of this MDI form before showing it.
                        ChildForm.MdiParent = Me

                        ' Set the name of the CSV File.
                        ChildForm.txtCSVFileName = FileName

                        m_ChildFormNumber += 1
                        ChildForm.Text = "(" & m_ChildFormNumber & ") " & ChildForm.Text

                        ChildForm.Show()
                    Case 2 ' Load Duos
                        ' This should create a copy of frmDuos
                        Dim ChildForm As New frmDuos
                        ' Make it a child of this MDI form before showing it.
                        ChildForm.MdiParent = Me

                        ' Set the name of the CSV File.
                        ChildForm.txtCSVFileName = FileName

                        m_ChildFormNumber += 1
                        ChildForm.Text = "(" & m_ChildFormNumber & ") " & ChildForm.Text

                        ChildForm.Show()

                    Case 1 ' Load Individual
                        ' This should create a copy of frmIndividual
                        Dim ChildForm As New frmIndividual
                        ' Make it a child of this MDI form before showing it.
                        ChildForm.MdiParent = Me

                        ' Set the name of the CSV File.
                        ChildForm.txtCSVFileName = FileName

                        m_ChildFormNumber += 1
                        ChildForm.Text = "(" & m_ChildFormNumber & ") " & ChildForm.Text

                        ChildForm.Show()
                    Case Else ' If there is no valid row, something wrong... back out.

                End Select

            End Using


        End If
    End Sub

    Private Sub TournamentXMLxmlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TournamentXMLxmlToolStripMenuItem.Click

        OpenFileDialogXML.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments

        If (OpenFileDialogXML.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialogXML.FileName

            Dim intExpectedPlayers As Integer

            ' Open the file and find out what kind of event is it
            Dim xDoc As XDocument = XDocument.Load(FileName)
            intExpectedPlayers = xDoc.Root.Attribute("TeamPlayers").Value

            Select Case intExpectedPlayers
                Case 3
                    ' This should create a copy of frmTrios
                    Dim ChildForm As New frmTrios
                    ' Make it a child of this MDI form before showing it.
                    ChildForm.MdiParent = Me

                    ' Set the name of the CSV File.
                    ChildForm.txtXMLFileName = FileName

                    m_ChildFormNumber += 1
                    ChildForm.Text = ChildForm.Text & "-" & FileName

                    ChildForm.Show()
                Case 2
                    ' This should create a copy of frmDuos
                    Dim ChildForm As New frmDuos
                    ' Make it a child of this MDI form before showing it.
                    ChildForm.MdiParent = Me

                    ' Set the name of the CSV File.
                    ChildForm.txtXMLFileName = FileName

                    m_ChildFormNumber += 1
                    ChildForm.Text = ChildForm.Text & "-" & FileName

                    ChildForm.Show()

                Case Else ' Think it should be ONE
                    ' This should open as a single player event.

                    ' This should create a copy of frmIndividual
                    Dim ChildForm As New frmIndividual
                    ' Make it a child of this MDI form before showing it.
                    ChildForm.MdiParent = Me

                    ' Set the name of the CSV File.
                    ChildForm.txtXMLFileName = FileName

                    m_ChildFormNumber += 1
                    ChildForm.Text = ChildForm.Text & "-" & FileName

                    ChildForm.Show()

            End Select

        End If
    End Sub

    Private Sub BandaiTCGTournamentPolicyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BandaiTCGTournamentPolicyToolStripMenuItem.Click
        If MessageBox.Show("You are going to be directed to the Bandai TCG's webpage to view the Official Tournament Policy." & Environment.NewLine & Environment.NewLine & "As a reminder, this software is NOT official software released by Bandai.", "Directing you to Bandai's Home Page...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) = DialogResult.OK Then
            LaunchWebsite("https://world.digimoncard.com/event/online_event/pdf/tournament_rules.pdf?210604")
        End If
    End Sub

    Sub LaunchWebsite(strWebpageURL As String)

        Using Process.Start(New ProcessStartInfo(strWebpageURL) With {.UseShellExecute = True})
        End Using

    End Sub

    Private Sub MasterPlayerRosterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterPlayerRosterToolStripMenuItem.Click
        Using frmPlayerDatabase As New frmMasterPlayerList
            frmPlayerDatabase.ShowDialog()
        End Using
    End Sub

    Private Sub TwoPlayersPerTeamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TwoPlayersPerTeamToolStripMenuItem.Click
        Dim ChildForm As New frmDuos
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        'ChildForm.Text = ChildForm.Text

        ChildForm.Show()
    End Sub

    Private Sub ThreePlayersPerTeamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThreePlayersPerTeamToolStripMenuItem.Click
        Dim ChildForm As New frmTrios
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        'ChildForm.Text = ChildForm.Text

        ChildForm.Show()
    End Sub
End Class
