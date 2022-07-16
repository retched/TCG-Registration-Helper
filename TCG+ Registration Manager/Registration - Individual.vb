Imports System.ComponentModel
Imports System.Xml
Public Class frmIndividual

    Public Property txtXMLFileName As String
    Public Property txtCSVFileName As String

    ''' <summary>
    ''' Holds the list of players from the XML File
    ''' </summary>
    Dim lstPlayers As New List(Of PlayerInfo)

    ''' <summary>
    ''' Holds the list of Players that are Registered.
    ''' </summary>
    Dim lstTournTeams As New List(Of TournamentTeam)

    Dim lstStaff As New List(Of TournamentStaff)

    Dim lstPenalties As New List(Of TournamentPenalty)

    Dim blnSearch As Boolean = False

    Private Sub cbGuest_CheckedChanged(sender As Object, e As EventArgs) Handles cbGuest.CheckedChanged
        If cbGuest.Checked Then
            ' This is a Guest Player
            txtMemberNo.Enabled = False
            txtMemberNo.Text = "GUEST99999"

            ' Reset all to default (MINUS the team number)
            txtPlayerFirstName.Clear()
            txtPlayerLastName.Clear()
            txtPlayerNickname.Clear()
            cboChangeStatus.SelectedValue = 10

            ' Clear selections from datagridview and select box
            lbSearchResults.ClearSelected()
            dgvPlayers.ClearSelection()

            ' Move the focus to the team's name
            txtPlayerFirstName.Focus()

        Else
            ' This is NOT a Guest Player
            txtMemberNo.Enabled = True
            txtMemberNo.Clear() ' Clear the number box of any entry

            ' Move the focus to the entry
            txtMemberNo.Focus()

        End If
    End Sub

    Private Sub txtMemberNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMemberNo.KeyPress

        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub frmIndividual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        ' Bind the Status Dictionary to the Combo Boxes as Needed
        cboStatus.DisplayMember = "Value"
        cboStatus.ValueMember = "Key"
        cboStatus.DataSource = New BindingSource(_status, Nothing)

        cboChangeStatus.DisplayMember = "Value"
        cboChangeStatus.ValueMember = "Key"
        cboChangeStatus.DataSource = New BindingSource(_status, Nothing)

        ' Set the Default to "Participating in Tournament"
        cboStatus.SelectedValue = 10
        cboChangeStatus.SelectedValue = 10


        If Not String.IsNullOrEmpty(txtCSVFileName) Then
            ' If CSV Name is set, process the CSV file.
            Dim lstFileData As List(Of TournamentTeam) = csvSinglePlayerReadOut(txtCSVFileName)

            lstTournTeams = lstFileData.ToList()

            ' Add New Players to Global Player List 
            AddNewPlayersFromImport()
        ElseIf Not String.IsNullOrEmpty(txtXMLFileName) Then
            ' If the XML Name is set, process the XML File.
            Dim lstFileData As List(Of Object) = xmlSinglePlayerReadOut(txtXMLFileName).ToList()

            lstTournTeams = lstFileData(0)
            lstStaff = lstFileData(1)
            lstPenalties = lstFileData(2)

            ' Add New Players to Global Player List 
            AddNewPlayersFromImport()
        End If

        ' Load from XML and put names into Datatable
        LoadPlayersListFromXML()

        ' Clear selection from listbox. (I have no idea why .NET does this.)
        lbSearchResults.ClearSelected()

        BuildTournamentList()

    End Sub

    Private Sub AddNewPlayersFromImport()
        ' Gist: Comb through the imported players and add them (or update them) to the Global Player XML.

        For Each team In lstTournTeams
            team.PlayerA.FormatNumber()
            ' We only have a SINGLE team in this list, so we only need PlayerA from lstTournTeams
            UpdateAllPlayerXML(team.PlayerA.MembershipNumber, team.PlayerA.MembershipName, team.PlayerA.FirstName, team.PlayerA.LastName)
        Next

        For Each staff In lstStaff
            staff.FormatNumber()
            ' We also have to loop through and add all staff members to the master list of players.
            UpdateAllPlayerXML(staff.MembershipNumber, staff.MembershipName, staff.FirstName, staff.LastName)
        Next

    End Sub

    Private Sub btnAddPlayer_Click(sender As Object, e As EventArgs) Handles btnAddPlayer.Click

        If String.IsNullOrEmpty(txtMemberNo.Text.Trim) Or String.IsNullOrEmpty(txtPlayerNickname.Text.Trim) Then
            MessageBox.Show("You must enter at LEAST a Membership Number and a Nickname.", "Invalid Entrant", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ' Add Player to Tournament List, check to make sure they AREN'T in the list already
            ' Again we're only working with Player A as this is a solo event.
            Dim resultPlayer As TournamentPlayer = lstTournTeams.Find(Function(x) x.PlayerA.MembershipNumber = txtMemberNo.Text.Trim())
            Dim resultStaff As TournamentStaff = lstStaff.Find(Function(x) x.MembershipNumber = txtMemberNo.Text.Trim())

            If IsNothing(resultPlayer) And IsNothing(resultStaff) Then
                lstTournTeams.Add(New TournamentTeam() With {
                                    .PlayerA = New PlayerInfo() With {
                                        .FirstName = txtPlayerFirstName.Text.Trim(),
                                        .LastName = txtPlayerLastName.Text.Trim(),
                                        .MembershipName = txtPlayerNickname.Text.Trim(),
                                        .MembershipNumber = txtMemberNo.Text.Trim(),
                                        .SeatOrder = "A"},
                                    .ByeRounds = IIf(rbByes_0.Checked, 0, 1),
                                    .Status = cboStatus.SelectedValue
                                  })

            ElseIf Not IsNothing(resultStaff) Then
                ' This player should NOT be added as they are staff. Tournament Staff CANNOT be a player in the tournament.
                MessageBox.Show("This player is listed as a member of the event staff and is therefore INELIGIBLE to be added as a tournament player.", "Cannot Add Event Staff", MessageBoxButtons.OK, MessageBoxIcon.Error)

                ' Clear the player info
                ClearPlayer()
            Else

                ' This team should not be ADDED but rather UPDATED to the new information.
                ' MessageBox.Show("Player No. " & txtMemberNo.Text.Trim() & " already exists in the Player List. This team will be updated instead.")

                Dim index As Integer = lstTournTeams.IndexOf(resultPlayer)
                lstTournTeams(index) = New TournamentTeam() With {
                                            .PlayerA = New PlayerInfo() With {
                                                .FirstName = txtPlayerFirstName.Text.Trim(),
                                                .LastName = txtPlayerLastName.Text.Trim(),
                                                .MembershipName = txtPlayerNickname.Text.Trim(),
                                                .MembershipNumber = txtMemberNo.Text.Trim(),
                                                .SeatOrder = "A"},
                                            .ByeRounds = IIf(rbByes_0.Checked, 0, 1),
                                            .Status = cboStatus.SelectedValue
                                            }

            End If

            ' Should also add this team to the XML file of AllPlayers too and reload the XMLFile.
            ' Does this team ID (non-guest exist within the AllPlayers XML?)
            UpdateAllPlayerXML(txtMemberNo.Text, txtPlayerNickname.Text, txtPlayerFirstName.Text, txtPlayerLastName.Text)

            ' Clear and reset all the fields
            ClearPlayer()

            BuildTournamentList()

            ' Clear the selection of the DGV
            dgvPlayers.ClearSelection()

            ' Go back to entry.
            txtMemberNo.Focus()

        End If


    End Sub

    Private Sub UpdateAllPlayerXML(strMemberID As String, strMemberName As String, Optional strPlayerFirstName As String = "", Optional strPlayerLastName As String = "")
        ' Open the XML AllPlayers.xml file
        Dim xdoc As New XDocument
        xdoc = XDocument.Load(Application.StartupPath + "AllPlayers.xml")

        Dim target As XElement = xdoc.Descendants("Player").FirstOrDefault(Function(x) x.Element("MembershipNo").Value = strMemberID)

        If strMemberID <> "GUEST99999" And Not String.IsNullOrWhiteSpace(strMemberID) Then
            If IsNothing(target) Then
                ' This should mean we have a NEW element.
                Dim newPlayer As XElement = New XElement("Player")
                newPlayer.Add(New XElement("FirstName", strPlayerFirstName))
                newPlayer.Add(New XElement("LastName", strPlayerLastName))
                newPlayer.Add(New XElement("MembershipNo", strMemberID))
                newPlayer.Add(New XElement("MembershipName", strMemberName))

                xdoc.Element("PlayerList").Add(newPlayer)

            Else
                ' This should mean we are UPDATING an element.

                ' If there is already either a first or last name AND there is a value
                ' for the firstname and last, update as needed.

                If String.IsNullOrWhiteSpace(target.Element("FirstName").Value) And Not String.IsNullOrWhiteSpace(strPlayerFirstName) Then
                    target.SetElementValue("FirstName", strPlayerFirstName)
                Else
                    target.SetElementValue("FirstName", "")
                End If

                If String.IsNullOrWhiteSpace(target.Element("LastName").Value) And Not String.IsNullOrWhiteSpace(strPlayerLastName) Then
                    target.SetElementValue("LastName", strPlayerLastName)
                Else
                    target.SetElementValue("LastName", "")
                End If


                target.SetElementValue("MembershipNo", strMemberID)
                target.SetElementValue("MembershipName", strMemberName)
            End If

            xdoc.Save(Application.StartupPath + "AllPlayers.xml")

            ' Since a new team was made, we should update the "Global Player List" on the form.
            LoadPlayersListFromXML()
            lbSearchResults.ClearSelected()
        End If

    End Sub

    Private Sub BuildTournamentList()
        ' Clear the rows already there.
        dgvPlayers.Rows.Clear()

        For Each team In lstTournTeams
            ' Find each team in the master list of players and add change the data as needed

            Dim result As PlayerInfo = lstPlayers.Find(Function(x) x.MembershipNumber = team.PlayerA.MembershipNumber)
            If IsNothing(result) Then
                dgvPlayers.Rows.Add(lstTournTeams.IndexOf(team), False, team.PlayerA.MembershipNumber, team.PlayerA.SummaryName, IIf(team.ByeRounds, "Yes", "No"), _status.Item(team.Status))
            Else
                ' We found a matching team
                ' That means we copy that team's info over to the tournament team info
                team.PlayerA.LastName = result.LastName
                team.PlayerA.FirstName = result.FirstName
                team.PlayerA.MembershipName = result.MembershipName


                dgvPlayers.Rows.Add(lstTournTeams.IndexOf(team), False, team.PlayerA.MembershipNumber, team.PlayerA.SummaryName, IIf(team.ByeRounds, "Yes", "No"), _status.Item(team.Status))
            End If

        Next

        dgvPlayers.Sort(dgvPlayers.Columns("dgcNickname"), ListSortDirection.Ascending)

        dgvPlayers.ClearSelection()
    End Sub

    Sub ClearPlayer()
        txtMemberNo.Clear()
        cbGuest.Checked = False
        txtPlayerFirstName.Clear()
        txtPlayerLastName.Clear()
        txtPlayerNickname.Clear()
        cboStatus.SelectedValue = 10
        rbByes_0.Checked = True
        txtMemberNo.Clear()

    End Sub

    Sub LoadPlayersListFromXML()
        Dim xdoc As New XDocument
        xdoc = XDocument.Load(Application.StartupPath + "AllPlayers.xml")

        ' Load XML Document into a list.

        lstPlayers = xdoc.Root.Elements("Player").[Select](Function(st) New PlayerInfo With {
                                                      .MembershipName = st.Element("MembershipName"),
                                                      .FirstName = st.Element("FirstName"),
                                                      .LastName = st.Element("LastName"),
                                                      .MembershipNumber = st.Element("MembershipNo")}).ToList()

        blnSearch = False
        FillListBox()

        ' Clear the Search box since we added a team.
        txtSearchPlayer.Clear()

    End Sub

    Private Sub FillListBox()

        If blnSearch Then
            ' Make a copy of the list of TournPlayers (we don't want to overwrite)
            Dim lstSearch As List(Of PlayerInfo) = lstPlayers.FindAll(Function(x) x.SearchHelper.ToLower.Contains(txtSearchPlayer.Text.ToLower.Trim)).ToList

            If rbMemberName.Checked Then
                lstSearch = lstSearch.OrderBy(Function(x) x.MembershipName).ToList()
            ElseIf rbMembershipID.Checked Then
                lstSearch = lstSearch.OrderBy(Function(x) x.MembershipNumber).ToList()
            Else
                'rbPlayerName.Checked, Sort by First Name Then Last Name.
                lstSearch = lstSearch.OrderBy(Function(x) x.LastName).ThenBy(Function(x) x.FirstName).ToList()
            End If

            lbSearchResults.DataSource = lstSearch

        Else
            If rbMemberName.Checked Then
                lstPlayers = lstPlayers.OrderBy(Function(x) x.MembershipName).ToList()
            ElseIf rbMembershipID.Checked Then
                lstPlayers = lstPlayers.OrderBy(Function(x) x.MembershipNumber).ToList()
            Else
                'rbPlayerName.Checked, Sort by First Name Then Last Name.
                lstPlayers = lstPlayers.OrderBy(Function(x) x.LastName).ThenBy(Function(x) x.FirstName).ToList()
            End If

            ' Fill listbox from dataset. (Format: "GUEST99999 - SomeNickname (PlayerFirst PlayerLast)" )
            lbSearchResults.DisplayMember = "ListSummary"
            lbSearchResults.ValueMember = "MembershipNumber"
            lbSearchResults.DataSource = lstPlayers

        End If


        lbSearchResults.ClearSelected()

    End Sub

    Private Sub lbSearchResults_SelectedValueChanged(sender As Object, e As EventArgs) Handles lbSearchResults.SelectedValueChanged
        ' When the selection is changed, clear the fields and replace them with the data from the table.
        ClearPlayer()

        If lbSearchResults.SelectedItems.Count > 0 Then
            ' MessageBox.Show("Selected Row was: " & lbSearchResults.SelectedItem.MembershipNumber)

            txtMemberNo.Text = lbSearchResults.SelectedItem.MembershipNumber.ToString
            txtPlayerFirstName.Text = lbSearchResults.SelectedItem.FirstName.ToString
            txtPlayerLastName.Text = lbSearchResults.SelectedItem.LastName.ToString
            txtPlayerNickname.Text = lbSearchResults.SelectedItem.MembershipName.ToString
        Else
            ClearPlayer()
        End If

    End Sub

    Private Sub txtMemberNo_Leave(sender As Object, e As EventArgs) Handles txtMemberNo.Leave
        If IsNumeric(txtMemberNo.Text.Trim) And cbGuest.Checked = False Then
            ' If the text is a numeric number (AKA, not a guest) change that number
            ' to a proper membership number

            txtMemberNo.Text = txtMemberNo.Text.ToString.PadLeft(10, "0")

            ' Find the team whose info matches
            FindPlayerFromList(txtMemberNo.Text)
        End If

    End Sub

    Private Sub FindPlayerFromList(strPlayerNo As String)
        ' Find a team within the AllPlayers list whose number matches and fill it in.
        Dim result As PlayerInfo = lstPlayers.Find(Function(x) x.MembershipNumber = strPlayerNo)

        If Not IsNothing(result) Then
            ' If there was a team... Then change stuff as Needed

            txtPlayerFirstName.Text = result.FirstName
            txtPlayerLastName.Text = result.LastName
            txtPlayerNickname.Text = result.MembershipName
        Else
            ' Clear the fields, but do NOT change the bye setting(?)
            cbGuest.Checked = False
            txtPlayerFirstName.Clear()
            txtPlayerLastName.Clear()
            txtPlayerNickname.Clear()
            cboStatus.SelectedValue = 10
            rbByes_0.Checked = True
        End If
    End Sub

    Private Sub txtMemberNo_KeyUp(sender As Object, e As KeyEventArgs) Handles txtMemberNo.KeyUp
        'FindPlayerFromList(txtMemberNo.Text.Trim.PadLeft(10, "0"))

        ' If the Enter key is struck, format the number as needed.
        If e.KeyCode = Keys.Enter Then

            e.SuppressKeyPress = True

            txtMemberNo.Text = txtMemberNo.Text.Trim.PadLeft(10, "0")

            txtPlayerFirstName.Focus()

        End If

        If String.IsNullOrEmpty(txtMemberNo.Text) Then
            ClearPlayer()

        End If
    End Sub

    Private Sub txtPlayerFirstName_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPlayerFirstName.KeyUp, txtPlayerLastName.KeyUp, txtPlayerNickname.KeyUp, cboStatus.KeyUp
        If e.KeyCode = Keys.Enter Then
            ' If we hit the enter key on Player Name, Nickname, or Status, submit the form (aka click the button)
            btnAddPlayer.PerformClick()
        End If
    End Sub

    Private Sub btnChangeChecked_Click(sender As Object, e As EventArgs) Handles btnChangeChecked.Click
        ' Go through each checked box and change the status as requested
        For Each tourn In dgvPlayers.Rows
            If tourn.Cells("dgcSelect").Value = True Then
                ' If the dgcSelect cell is checked, then update that row's dgcStatus to match
                tourn.Cells("dgcStatus").Value = _status.Item(cboChangeStatus.SelectedValue)

                ' Change the matching lstTournPlayers to match
                lstTournTeams(tourn.Cells("dgcListIndex").Value).Status = cboChangeStatus.SelectedValue

                ' Turn off the check box since we're done
                tourn.Cells("dgcSelect").Value = 0
            End If
        Next
    End Sub

    Private Sub cbSelectAll_CheckedChanged(sender As Object, e As EventArgs) Handles cbSelectAll.CheckedChanged
        For Each tourn In dgvPlayers.Rows
            tourn.Cells("dgcSelect").Value = cbSelectAll.Checked
        Next
    End Sub

    Private Sub rbMemberName_CheckedChanged(sender As Object, e As EventArgs) Handles rbMemberName.CheckedChanged, rbMembershipID.CheckedChanged, rbPlayerName.CheckedChanged
        ' The FillListBox() handles the sorting.
        FillListBox()
    End Sub

    Private Sub btnSearchPlayer_Click(sender As Object, e As EventArgs) Handles btnSearchPlayer.Click
        blnSearch = True
        FillListBox()
    End Sub

    Private Sub dgvPlayers_SelectionChanged(sender As Object, e As EventArgs) Handles dgvPlayers.SelectionChanged
        If dgvPlayers.SelectedRows.Count > 0 Then

            Dim intSelected As Integer = dgvPlayers.SelectedRows(0).Cells(0).Value

            ' A row was selected, take that row and preload all the info back into entry field

            txtMemberNo.Text = lstTournTeams(intSelected).PlayerA.MembershipNumber
            txtPlayerFirstName.Text = lstTournTeams(intSelected).PlayerA.FirstName
            txtPlayerLastName.Text = lstTournTeams(intSelected).PlayerA.LastName
            txtPlayerNickname.Text = lstTournTeams(intSelected).PlayerA.MembershipName

            Select Case lstTournTeams(intSelected).ByeRounds
                Case 0
                    rbByes_0.Checked = True
                Case 1
                    rbByes_1.Checked = True
            End Select

            cboStatus.SelectedValue = lstTournTeams(intSelected).Status

            ' Uncheck Guest Box and Re-Enable Membershhp
            cbGuest.Checked = False
            txtMemberNo.Enabled = True
        Else
            ClearPlayer()

        End If

    End Sub

    Private Sub lbSearchResults_MouseDown(sender As Object, e As MouseEventArgs) Handles lbSearchResults.MouseDown
        cmsPlayerList.Location = MousePosition

        If e.Button = MouseButtons.Right Then
            lbSearchResults.SelectedIndex = lbSearchResults.IndexFromPoint(e.Location)

            If lbSearchResults.SelectedIndex <> -1 Then cmsPlayerList.Show()

            ' Change the first item in the CMS to what is needed.
            ChangePlayerDetails0ToolStripMenuItem.Text = String.Format(ChangePlayerDetails0ToolStripMenuItem.Text, lstPlayers.Find(Function(x) x.MembershipNumber = lbSearchResults.SelectedValue).SummaryName)
        End If
    End Sub

    Private Sub DeletePlayerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeletePlayerToolStripMenuItem.Click
        If MessageBox.Show("Are you ABSOLUTELY sure that you want to delete this player from the local database?" & System.Environment.NewLine & System.Environment.NewLine & "This will not remove them from any tournaments they are registered for on Bandai TCG+ and will remove them from this current tournament.", "Delete This Player?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            Dim strMemberToDelete As String = lbSearchResults.SelectedValue

            ' We have confirmed that we are DELETING this team from the XML Database
            ' Load the XML Database 
            Dim xdoc As New XDocument
            xdoc = XDocument.Load(Application.StartupPath + "AllPlayers.xml")

            Dim target As XElement = xdoc.Descendants("Player").FirstOrDefault(Function(x) x.Element("MembershipNo").Value = strMemberToDelete)

            ' Remove the node
            target.Remove()

            ' Save the changes
            xdoc.Save(Application.StartupPath + "AllPlayers.xml")

            ' Refill the listbox
            LoadPlayersListFromXML()

            ' Clear Selection of ListBox
            lbSearchResults.ClearSelected()

            ' Also we should delete them from the current OPEN tournament too.
            Dim intIndex As Integer = lstTournTeams.FindIndex(Function(x) x.PlayerA.MembershipNumber = strMemberToDelete)

            If lstTournTeams(intIndex).TeamID = 0 Then

                If intIndex <> -1 Then
                    ' If it's not -1 then we find something and should delete that team on sight.

                    lstTournTeams.RemoveAt(intIndex)

                    ' Rebuild the list 
                    BuildTournamentList()
                End If

                ' TODO: Remove penalties AND judge listing.

            End If
        End If

    End Sub

    Private Sub btnDeletePlayer_Click(sender As Object, e As EventArgs) Handles btnDeletePlayer.Click
        ' This can ONLY be done if the team does NOT have a "TeamID" loaded in from the Tournament file.
        ' If the team has a TeamID, do NOT delete the team.

        Dim lstErrors As New List(Of TournamentTeam)

        Dim intCount As Integer = 0
        For Each row In dgvPlayers.Rows
            If row.Cells("dgcSelect").Value = 1 Then intCount += 1
        Next

        If intCount > 0 Then
            If MessageBox.Show(String.Format("You are about to delete {0} player(s) from this tournament." & Environment.NewLine & Environment.NewLine & "Are you sure you want to proceed?", intCount), "Deleting Multiple Players", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                For Each row In dgvPlayers.Rows
                    If row.Cells(1).Value = True Then
                        Dim intListIndex As Integer = row.Cells(0).Value

                        If lstTournTeams(intListIndex).TeamID = 0 Then
                            ' Remove the team from the list.
                            lstTournTeams.RemoveAt(intListIndex)

                            ' Rebuild the DGV.
                            BuildTournamentList()
                        Else
                            ' Can't delete the team, make an error
                            lstErrors.Add(lstTournTeams(intListIndex))
                        End If

                        row.Cells(1).Value = False

                    End If
                Next

                If lstErrors.Count > 0 Then
                    Dim strErrors As String = ""

                    For Each [error] In lstErrors
                        strErrors &= "•  " & [error].PlayerA.SummaryName & Environment.NewLine
                    Next


                    MessageBox.Show(String.Format("Deleted {0} players from the tournament roster." & Environment.NewLine & Environment.NewLine & "But {1} player(s) could not be deleted. Either the player pre-registered or was enrolled through the TCG+ app. To remove these players from the pairings, set their status to ANYTHING but ""Participating in Tournament""." & Environment.NewLine & Environment.NewLine & "Players not removed:" & Environment.NewLine & strErrors, intCount - lstErrors.Count, lstErrors.Count), "Deleted Players", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show(String.Format("Succesfully deleted {0} players from tournament roster.", intCount), "Deleted players with no errors", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            End If
        ElseIf dgvPlayers.SelectedRows.Count = 1 Then
            Dim intLstID As Integer = dgvPlayers.SelectedRows(0).Cells(0).Value

            If lstTournTeams(intLstID).TeamID <> 0 Then
                MessageBox.Show("Cannot delete this player." & Environment.NewLine & Environment.NewLine & "Either the player pre-registered or was enrolled through the TCG+ app. To remove this player from the pairings, set their status to ANYTHING but ""Participating in Tournament"".", "Cannot delete pre-registered player", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                lstTournTeams.RemoveAt(intLstID)

                BuildTournamentList()
            End If

        End If

        dgvPlayers.ClearSelection()

    End Sub

    Private Sub CloseTournamentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseTournamentToolStripMenuItem.Click
        Close() ' Close this form.
    End Sub

    Private Sub CommaSeparatedValuesFilecsvToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CommaSeparatedValuesFilecsvToolStripMenuItem.Click

        Dim FileName As String
        If Not String.IsNullOrWhiteSpace(txtCSVFileName) AndAlso My.Computer.FileSystem.FileExists(txtCSVFileName) Then
            FileName = txtCSVFileName
        Else
            SaveFileDialogCSV.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            SaveFileDialogCSV.ShowDialog(Me)
            FileName = SaveFileDialogCSV.FileName

        End If

        If Not String.IsNullOrWhiteSpace(FileName) Then

            ' Set this file name as the NEW saved file name.
            txtCSVFileName = FileName

            Using csvDoc As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(FileName, False)
                csvDoc.WriteLine("""Team ID"",""Team Name"",""Win Point"",""Status"",""Bye Count"",""Membership Number - 1"",""Player Name - 1"",""Seat Order - 1"",""Memo""")
                csvDoc.WriteLine("""Required
※Please set the value to 0 for new registrations."",""Optional
※Required for team competitions only"",""Uneditable
No change in value will have any effect."",""Required
1:Applied
2:Successful
3:Waiting list
4:Unsuccessful
5:Cancelled
6:Selected + Checked In
7:Waiting for Cancellation + Checked In
8:Absent on Day of Event
9:Advance Elected
10:Participating in Tournament
11:Dropped"",""0: No Round Bye
1: 1 Round Bye
Optional
※When not entered"",""Required"",""Uneditable
No change in value will have any effect."",""Required""")

                For Each team In lstTournTeams
                    If team.Status <> 9999 Then
                        csvDoc.Write("""" & team.TeamID & """,")
                        csvDoc.Write("""" & team.TeamName & """,")
                        csvDoc.Write("""" & 0 & """,")
                        csvDoc.Write("""" & team.Status & """,")
                        csvDoc.Write("""" & team.ByeRounds & """,")
                        csvDoc.Write("""" & team.PlayerA.MembershipNumber & """,")
                        csvDoc.Write("""" & team.PlayerA.MembershipName & """,")
                        csvDoc.Write("""" & team.PlayerA.SeatOrder & """,")
                        csvDoc.Write("""" & team.Memo & """,")
                        csvDoc.Write(Environment.NewLine)
                    End If
                Next

                csvDoc.Close()
            End Using


            ' Iterate over all members of the lstTournPlayers (except anyone with 9999 status, that's staff.) 
        End If

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        ' No check for a file, this one will ALWAYS generate a prompt.

        SaveFileDialogCSV.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments

        If SaveFileDialogCSV.ShowDialog(Me) = DialogResult.OK Then
            Dim FileName As String = SaveFileDialogCSV.FileName

            Using csvDoc As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(FileName, False)
                csvDoc.WriteLine("""Team ID"",""Team Name"",""Win Point"",""Status"",""Bye Count"",""Membership Number - 1"",""Player Name - 1"",""Seat Order - 1"",""Memo""")
                csvDoc.WriteLine("""Required
※Please set the value to 0 for new registrations."",""Optional
※Required for team competitions only"",""Uneditable
No change in value will have any effect."",""Required
1:Applied
2:Successful
3:Waiting list
4:Unsuccessful
5:Cancelled
6:Selected + Checked In
7:Waiting for Cancellation + Checked In
8:Absent on Day of Event
9:Advance Elected
10:Participating in Tournament
11:Dropped"",""0: No Round Bye
1: 1 Round Bye
Optional
※When not entered"",""Required"",""Uneditable
No change in value will have any effect."",""Required""")

                For Each player In lstTournTeams
                    If player.Status <> 9999 Then
                        csvDoc.Write("""" & player.TeamID & """,")
                        csvDoc.Write("""" & player.TeamName & """,")
                        csvDoc.Write("""" & 0 & """,")
                        csvDoc.Write("""" & player.Status & """,")
                        csvDoc.Write("""" & player.ByeRounds & """,")
                        csvDoc.Write("""" & player.PlayerA.MembershipNumber & """,")
                        csvDoc.Write("""" & player.PlayerA.MembershipName & """,")
                        csvDoc.Write("""" & player.PlayerA.SeatOrder & """,")
                        csvDoc.Write("""" & player.Memo & """,")
                        csvDoc.Write(Environment.NewLine)
                    End If
                Next

                csvDoc.Close()
            End Using


            ' Iterate over all members of the lstTournPlayers (except anyone with 9999 status, that's staff.) 
        End If

    End Sub

    Private Sub TournamentXMLxmlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TournamentXMLxmlToolStripMenuItem.Click

        Dim FileName As String

        If Not String.IsNullOrWhiteSpace(txtXMLFileName) AndAlso My.Computer.FileSystem.FileExists(txtXMLFileName) Then
            FileName = txtXMLFileName
        Else
            SaveFileDialogXML.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            SaveFileDialogXML.ShowDialog(Me)
            FileName = SaveFileDialogXML.FileName
        End If

        If Not String.IsNullOrWhiteSpace(FileName) Then
            ' Set this file name as the NEW saved file name.
            txtXMLFileName = FileName

            ' Write the actual XML File.
            ' Format should be:
            ' <Tournament TeamPlayers="1">
            '   <Teams></Teams>
            '   <Staff></Staff>
            '   <Penalty></Penalty>
            ' </Tournament>

            Dim xDoc As New XDocument

            Dim tournament As XElement = New XElement("Tournament")
            tournament.SetAttributeValue("TeamPlayers", 1) ' One player tournament.

            ' List of TournamentPlayers
            tournament.Add(New XElement("Teams"))

            Dim playerNode As XElement = tournament.Descendants("Teams").FirstOrDefault()

            For Each team In lstTournTeams
                playerNode.Add(New XElement("Team", New XElement("TeamID", team.TeamID),
                                                    New XElement("TeamName", team.TeamName),
                                                    New XElement("Status", team.Status),
                                                    New XElement("Memo", team.Memo),
                                                    New XElement("ByeRounds", team.ByeRounds),
                                                    New XElement("Players", New XElement("Player",
                                                                                         New XElement("MemberNumber", team.PlayerA.MembershipNumber),
                                                                                         New XElement("MemberName", team.PlayerA.MembershipName),
                                                                                         New XElement("PlayerFirstName", team.PlayerA.FirstName),
                                                                                         New XElement("PlayerLastName", team.PlayerA.LastName),
                                                                                         New XElement("SeatOrder", "A")))))
            Next
            'tournament.Add(playerNode)

            ' List of TournamentStaff
            tournament.Add(New XElement("Staff"))
            Dim staffNode As XElement = tournament.Descendants("Staff").FirstOrDefault()

            For Each staff In lstStaff
                staffNode.Add(New XElement("Player", New XElement("MembershipNo", staff.MembershipNumber),
                                                     New XElement("PlayerFirstName", staff.FirstName),
                                                     New XElement("PlayerLastName", staff.LastName),
                                                     New XElement("MembershipName", staff.MembershipName),
                                                     New XElement("StaffPosition", staff.StaffPosition)))
            Next
            'tournament.Add(staffNode)

            ' List of Penalties
            tournament.Add(New XElement("Penalties"))
            Dim penaltyNode As XElement = tournament.Descendants("Penalties").FirstOrDefault()

            For Each penalty In lstPenalties
                penaltyNode.Add(New XElement("Penalty", New XElement("Judge", penalty.JudgeNumber),
                                                        New XElement("Player", penalty.PlayerNumber),
                                                        New XElement("InfractionType", penalty.InfractionType),
                                                        New XElement("PenaltyType", penalty.PenaltyType),
                                                        New XElement("RoundNumber", penalty.RoundNumber),
                                                        New XElement("Notes", penalty.Notes)))
            Next
            'tournament.Add(penaltyNode)

            xDoc.Add(tournament)

            xDoc.Save(txtXMLFileName)

        End If
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        ' This is to save a copy as. So there will always be a prompt.

        SaveFileDialogCSV.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments

        If SaveFileDialogXML.ShowDialog(Me) = DialogResult.OK Then
            ' Set this file name as the NEW saved file name.
            txtXMLFileName = SaveFileDialogXML.FileName

            ' Write the actual XML File.
            ' Format should be:
            ' <Tournament TeamPlayers="1">
            '   <Teams></Teams>
            '   <Staff></Staff>
            '   <Penalty></Penalty>
            ' </Tournament>

            Dim xDoc As New XDocument
            xDoc.Add(New XComment("DO NOT EDIT ANY DETAILS IN THIS FILE! UNLESS YOU KNOW EXACTLY WHAT YOU ARE DOING!!!"))
            Dim tournament As XElement = New XElement("Tournament")
            tournament.SetAttributeValue("TeamPlayers", 1) ' One player tournament.

            ' List of TournamentPlayers
            tournament.Add(New XElement("Teams"))

            Dim playerNode As XElement = tournament.Descendants("Teams").FirstOrDefault()

            For Each team In lstTournTeams
                playerNode.Add(New XElement("Team", New XElement("TeamID", team.TeamID),
                                                    New XElement("TeamName", team.TeamName),
                                                    New XElement("Status", team.Status),
                                                    New XElement("Memo", team.Memo),
                                                    New XElement("ByeRounds", team.ByeRounds),
                                                    New XElement("Players", New XElement("Player",
                                                                                         New XElement("MemberNumber", team.PlayerA.MembershipNumber),
                                                                                         New XElement("MemberName", team.PlayerA.MembershipName),
                                                                                         New XElement("PlayerFirstName", team.PlayerA.FirstName),
                                                                                         New XElement("PlayerLastName", team.PlayerA.LastName),
                                                                                         New XElement("SeatOrder", "A")))))
            Next
            'tournament.Add(playerNode)

            ' List of TournamentStaff
            tournament.Add(New XElement("Staff"))
            Dim staffNode As XElement = tournament.Descendants("Staff").FirstOrDefault()

            For Each staff In lstStaff
                staffNode.Add(New XElement("Player", New XElement("MembershipNo", staff.MembershipNumber),
                                                     New XElement("PlayerFirstName", staff.FirstName),
                                                     New XElement("PlayerLastName", staff.LastName),
                                                     New XElement("MembershipName", staff.MembershipName),
                                                     New XElement("StaffPosition", staff.StaffPosition)))
            Next
            'tournament.Add(staffNode)

            ' List of Penalties
            tournament.Add(New XElement("Penalties"))
            Dim penaltyNode As XElement = tournament.Descendants("Penalties").FirstOrDefault()

            For Each penalty In lstPenalties
                penaltyNode.Add(New XElement("Penalty", New XElement("Judge", penalty.JudgeNumber),
                                                        New XElement("Player", penalty.PlayerNumber),
                                                        New XElement("InfractionType", penalty.InfractionType),
                                                        New XElement("PenaltyType", penalty.PenaltyType),
                                                        New XElement("RoundNumber", penalty.RoundNumber),
                                                        New XElement("Notes", penalty.Notes)))
            Next
            'tournament.Add(penaltyNode)

            xDoc.Add(tournament)

            xDoc.Save(txtXMLFileName)
        End If

    End Sub

    Private Sub PenaltiesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenaltiesToolStripMenuItem.Click
        ' Call up the frmPenalties
        Using frmPenaltyList As New frmPenalties

            ' New field since we have to cycle through EACH team to extra the tournament players.
            Dim lstPlayers As New List(Of PlayerInfo)

            For Each team In lstTournTeams
                ' There is only a PlayerA field since this is Individual registration. 
                lstPlayers.Add(team.PlayerA)
            Next

            ' Copy all the "major" details from this form and assign them to the sub form.
            frmPenaltyList.lstPenalties = lstPenalties
            frmPenaltyList.lstTournPlayers = lstPlayers
            frmPenaltyList.lstStaff = lstStaff

            frmPenaltyList.ShowDialog()

        End Using
    End Sub

    Private Sub StaffJudgesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaffJudgesToolStripMenuItem.Click
        Using frmStaff As New frmStaffList
            ' Assign the staff list to a local variable for manipulating
        End Using
    End Sub
End Class
