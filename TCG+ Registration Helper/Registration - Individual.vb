Imports System.Drawing.Drawing2D

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
            Dim lstFileData As List(Of TournamentTeam) = csvPlayerReadOut(txtCSVFileName)

            lstTournTeams = lstFileData.ToList()

            tslFileName.Text = "File Name: " & txtCSVFileName
            tslFileName.Visible = True

            If lstTournTeams.Count > 0 Then
                ' Add New Players to Global Player List 
                AddNewPlayersFromImportCSV()
                MessageBox.Show("CSV File Loaded Sucessfully")

                My.Settings.LastUsedDirectory = Path.GetDirectoryName(txtCSVFileName)
                My.Settings.Save()
            Else
                MessageBox.Show("There is no valid Membership data contained within the file." & Environment.NewLine & Environment.NewLine & "Are you trying to read a standings file?" & Environment.NewLine & Environment.NewLine & "Please double check the file and make sure you are using CSV Export from the ""My Event Details"" page and NOT from the Rankings page and try again.", "Invalid CSV File", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        ElseIf Not String.IsNullOrEmpty(txtXMLFileName) Then
            ' If the XML Name is set, process the XML File.
            Dim lstFileData As List(Of Object) = xmlPlayerReadOut(txtXMLFileName).ToList()

            lstTournTeams = lstFileData(0)
            lstStaff = lstFileData(1)
            lstPenalties = lstFileData(2)

            ' Add New Players to Global Player List 
            AddNewPlayersFromImportXML()
            tslFileName.Text = "File Name: " & txtXMLFileName
            tslFileName.Visible = True
            MessageBox.Show("XML File Loaded Sucessfully")

            My.Settings.LastUsedDirectory = Path.GetDirectoryName(txtXMLFileName)
            My.Settings.Save()
        End If

        ' Load from XML and put names into Datatable
        LoadPlayersListFromXML()

        ' Clear selection from listbox. (I have no idea why .NET does this.)
        lbSearchResults.ClearSelected()

        BuildTournamentList()

        ' Load the setting for the Full Player Name option and treat as needed.

        FullNameEntryToolStripMenuItem.Checked = My.Settings.PlayerNameFull

    End Sub

    Private Sub AddNewPlayersFromImportXML()
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

        ' Since a new team was made, we should update the "Global Player List" on the form.
        LoadPlayersListFromXML()

        FillListBox()
    End Sub

    Private Sub AddNewPlayersFromImportCSV()
        ' Gist: Comb through the imported players and add them (or update them) to the Global Player XML.

        For Each team In lstTournTeams
            team.PlayerA.FormatNumber()
            ' We only have a SINGLE team in this list, so we only need PlayerA from lstTournTeams
            UpdateAllPlayerXML(team.PlayerA.MembershipNumber, team.PlayerA.MembershipName)
        Next

        ' If any player has a number of 0000000986, alert the user that the upload
        ' will fail since that is an invalid number.

        ' Since a new team was made, we should update the "Global Player List" on the form.
        LoadPlayersListFromXML()

        FillListBox()
    End Sub

    Private Sub btnAddPlayer_Click(sender As Object, e As EventArgs) Handles btnAddPlayer.Click

        If String.IsNullOrEmpty(txtMemberNo.Text.Trim) Or String.IsNullOrEmpty(txtPlayerNickname.Text.Trim) Then
            MessageBox.Show("You must enter at LEAST a Membership Number and a Nickname.", "Invalid Entrant", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtMemberNo.Text = "0000000986" Then
            MessageBox.Show("CAUTION! The number that you have entered/updated is an invalid TCG+ Membership Number. Using this number in your CSV upload will cause your upload to fail. Please consider having the player recreate their TCG+ account with a new number and delete this number off of your player roster.", "Invalid TCG+ Membership Number Entered", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            ' Add Player to Tournament List, check to make sure they AREN'T in the list already
            ' Again we're only working with Player A as this is a solo event.
            Dim resultPlayer As TournamentPlayer = lstTournTeams.Find(Function(x) x.PlayerA.MembershipNumber = txtMemberNo.Text.Trim())
            Dim resultStaff As TournamentStaff = lstStaff.Find(Function(x) x.MembershipNumber = txtMemberNo.Text.Trim())
            Dim blnStaffFlag As Boolean = True


            If Not IsNothing(resultStaff) Then
                If MessageBox.Show("Please confirm that you are about to enroll a staff/judge as a player.", "Warning: Staff/Judge Being Added", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then blnStaffFlag = False
            End If

            If IsNothing(resultPlayer) And (IsNothing(resultStaff) Or blnStaffFlag) Then
                lstTournTeams.Add(New TournamentTeam() With {
                        .PlayerA = New PlayerInfo() With {
                            .FirstName = txtPlayerFirstName.Text.Trim(),
                            .LastName = txtPlayerLastName.Text.Trim(),
                            .MembershipName = txtPlayerNickname.Text.Trim(),
                            .MembershipNumber = txtMemberNo.Text.Trim(),
                            .SeatOrder = "A"},
                        .PlayerB = New PlayerInfo(),
                        .PlayerC = New PlayerInfo(),
                        .ByeRounds = IIf(rbByes_0.Checked, 0, 1),
                        .Status = cboStatus.SelectedValue
                      })
            ElseIf Not IsNothing(resultPlayer) Then

                ' This team should not be ADDED but rather UPDATED to the new information.
                ' MessageBox.Show("Player No. " & txtMemberNo.Text.Trim() & " already 
                ' exists in the Player List. This team will be updated instead.")

                Dim index As Integer = lstTournTeams.IndexOf(resultPlayer)
                lstTournTeams(index) = New TournamentTeam() With {
                                .PlayerA = New PlayerInfo() With {
                                    .FirstName = txtPlayerFirstName.Text.Trim(),
                                    .LastName = txtPlayerLastName.Text.Trim(),
                                    .MembershipName = txtPlayerNickname.Text.Trim(),
                                    .MembershipNumber = txtMemberNo.Text.Trim(),
                                    .SeatOrder = "A"},
                                .PlayerB = New PlayerInfo(),
                                .PlayerC = New PlayerInfo(),
                                .ByeRounds = IIf(rbByes_0.Checked, 0, 1),
                                .Status = cboStatus.SelectedValue,
                                .TeamID = lstTournTeams(index).TeamID
                            }
            Else
                ' Cancel

            End If

            ' Should also add this team to the XML file of AllPlayers too and reload the XMLFile.
            ' Does this team ID (non-guest exist within the AllPlayers XML?)
            UpdateAllPlayerXML(txtMemberNo.Text, txtPlayerNickname.Text, txtPlayerFirstName.Text, txtPlayerLastName.Text)
            LoadPlayersListFromXML()

            ' Clear and reset all the fields
            ClearPlayer()

            BuildTournamentList()

            ' Go back to entry.
            txtMemberNo.Focus()

        End If


    End Sub

    Private Sub BuildTournamentList()
        ' Clear the rows already there.
        dgvPlayers.Rows.Clear()

        ' Make sure the list is sorted by TeamID since that is the official order by Bandai.
        lstTournTeams = lstTournTeams.OrderBy(Function(o) o.TeamID = 0).ThenBy(Function(o) o.TeamID).ToList

        For Each team In lstTournTeams
            ' Find each team in the master list of players and add change the data as needed

            Dim result As PlayerInfo = lstPlayers.Find(Function(x) x.MembershipNumber = team.PlayerA.MembershipNumber)
            If IsNothing(result) Then
                dgvPlayers.Rows.Add(lstTournTeams.IndexOf(team), False, lstTournTeams.IndexOf(team) + 1, team.TeamID, team.PlayerA.MembershipNumber, team.PlayerA.SummaryName, _status.Item(team.Status))
            Else
                ' We found a matching team
                ' That means we copy that team's info over to the tournament team info
                team.PlayerA.LastName = result.LastName
                team.PlayerA.FirstName = result.FirstName
                team.PlayerA.MembershipName = result.MembershipName

                Dim index As Integer = dgvPlayers.Rows.Add()

                With dgvPlayers.Rows(index)
                    .Cells("dgcListIndex").Value = lstTournTeams.IndexOf(team)
                    .Cells("dgcSelect").Value = False
                    .Cells("dgcIndex").Value = lstTournTeams.IndexOf(team) + 1
                    .Cells("dgcTeamId").Value = team.TeamID
                    .Cells("dgcMembershipNo").Value = team.PlayerA.MembershipNumber
                    .Cells("dgcNickname").Value = team.PlayerA.SummaryName
                    .Cells("dgcStatus").Value = _status.Item(team.Status) & IIf(team.ByeRounds, Environment.NewLine & "First Round Bye", "")
                End With

                'dgvPlayers.Rows.Add()
            End If

        Next

        tslPlayerPreReg.Text = String.Format("{0} Player(s) Pre-Registered", lstTournTeams.Count())
        tslActivePlayer.Text = String.Format("{0} Player(s) Active", lstTournTeams.FindAll(Function(x As TournamentTeam) x.Status = "10").Count)

        'dgvPlayers.Sort(dgvPlayers.Columns("dgcNickname"), ListSortDirection.Ascending)
        dgvPlayers.Sort(dgvPlayers.Columns("dgcIndex"), ListSortDirection.Ascending)

        dgvPlayers.ClearSelection()
    End Sub

    Sub ClearPlayer()

        txtMemberNo.Focus()
        txtMemberNo.Clear()
        txtPlayerFirstName.Clear()
        txtPlayerLastName.Clear()
        txtPlayerNickname.Clear()
        cboStatus.SelectedValue = 10
        rbByes_0.Checked = True
        txtMemberNo.Clear()

        txtMemberNo.ReadOnly = False
        txtPlayerNickname.ReadOnly = False

        ' Clear the selection of the DGV
        dgvPlayers.ClearSelection()

    End Sub

    Sub LoadPlayersListFromXML()
        Dim xdoc As New XDocument
        xdoc = XDocument.Load(Application.StartupPath + "\AllPlayers.xml")

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
                'rbPlayerName.Checked, Sort by First Name Then Last Name THEN by Membership Name.
                'lstSearch = (From player In lstSearch Order By player.LastName Ascending, player.FirstName Ascending, player.MembershipName Select player).ToList()
                lstSearch = lstSearch.OrderBy(Function(x) x.LastName).ThenBy(Function(x) x.FirstName).ThenBy(Function(x) x.MembershipName).ToList()
            End If

            lbSearchResults.DataSource = lstSearch

        Else
            If rbMemberName.Checked Then
                lstPlayers = lstPlayers.OrderBy(Function(x) x.MembershipName).ToList()
            ElseIf rbMembershipID.Checked Then
                lstPlayers = lstPlayers.OrderBy(Function(x) x.MembershipNumber).ToList()
            Else
                'rbPlayerName.Checked, Sort by First Name Then Last Name.
                lstPlayers = lstPlayers.OrderBy(Function(x) x.LastName).ThenBy(Function(x) x.FirstName).ThenBy(Function(x) x.MembershipName).ToList()
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
        If IsNumeric(txtMemberNo.Text.Trim) Then
            ' If the text is a numeric number (AKA, not a guest) change that number
            ' to a proper membership number

            txtMemberNo.Text = txtMemberNo.Text.ToString.PadLeft(10, "0")

            ' Find the team whose info matches
            FindPlayerFromList(txtMemberNo.Text)

            If txtMemberNo.Text = "0000000986" Then MessageBox.Show("CAUTION! The number that you have entered/updated is an invalid TCG+ Membership Number. Using this number in your CSV upload will cause your upload to fail. Please consider having the player recreate their TCG+ account with a new number and delete this number off of your player roster.", "Invalid TCG+ Membership Number Entered", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

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


            txtPlayerFirstName.Clear()
            txtPlayerLastName.Clear()
            txtPlayerNickname.Clear()
            cboStatus.SelectedValue = 10
            'rbByes_0.Checked = True
        End If
    End Sub

    Private Sub txtMemberNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMemberNo.KeyDown, txtPlayerFirstName.KeyDown, txtPlayerLastName.KeyDown, txtPlayerNickname.KeyDown
        If e.KeyCode = Keys.Enter Then

            e.SuppressKeyPress = True
            e.Handled = True

        End If

        ' When this value is changed, clear 

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

        ' Clear checkbox at the top of the player list.
        cbSelectAll.Checked = False
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

            If lstTournTeams(intSelected).TeamID <> 0 Then
                txtMemberNo.ReadOnly = True
                txtPlayerNickname.ReadOnly = True
            End If

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

            txtMemberNo.Enabled = True
        Else
            ClearPlayer()

        End If

    End Sub

    Private Sub lbSearchResults_MouseDown(sender As Object, e As MouseEventArgs) Handles lbSearchResults.MouseUp
        cmsPlayerList.Location = MousePosition

        If e.Button = MouseButtons.Right Then
            lbSearchResults.SelectedIndex = lbSearchResults.IndexFromPoint(e.Location)

            ' Change the first item in the CMS to what is needed.
            ChangePlayerDetails0ToolStripMenuItem.Text = String.Format(ChangePlayerDetails0ToolStripMenuItem.Text, lstPlayers.Find(Function(x) x.MembershipNumber = lbSearchResults.SelectedValue).SummaryName)


            If lbSearchResults.SelectedIndex <> -1 Then cmsPlayerList.Show()

        End If
    End Sub


    Private Sub DeletePlayerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeletePlayerToolStripMenuItem.Click
        If MessageBox.Show("Are you ABSOLUTELY sure that you want to delete this player from the local database?" & System.Environment.NewLine & System.Environment.NewLine & "This will not remove them from the current tournament file nor any tournaments that are later loaded. This also will not remove them from a tournament that the player is registered for on Bandai TCG+." & Environment.NewLine & Environment.NewLine & "This will not prevent the player from being added back to the database if you update the status above.", "Delete This Player?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            Dim strMemberToDelete As String = lbSearchResults.SelectedValue

            ' We have confirmed that we are DELETING this team from the XML Database
            ' Load the XML Database 
            Dim xdoc As New XDocument
            xdoc = XDocument.Load(Application.StartupPath + "\AllPlayers.xml")

            Dim target As XElement = xdoc.Descendants("Player").FirstOrDefault(Function(x) x.Element("MembershipNo").Value = strMemberToDelete)

            ' Remove the node
            target.Remove()

            ' Save the changes
            xdoc.Save(Application.StartupPath + "\AllPlayers.xml")

            ' Refill the listbox
            LoadPlayersListFromXML()

            ' Clear Selection of ListBox
            lbSearchResults.ClearSelected()

            ' Remove penalties AND judge listing.
            lstPenalties.RemoveAll(Function(x) x.PlayerNumber = strMemberToDelete)
            lstPenalties.RemoveAll(Function(x) x.JudgeNumber = strMemberToDelete)
            lstStaff.RemoveAll(Function(x) x.MembershipNumber = strMemberToDelete)

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
            If MessageBox.Show(String.Format("You are about to delete/drop {0} player(s) from this tournament." & Environment.NewLine & Environment.NewLine & "Are you sure you want to proceed?", intCount), "Deleting Multiple Players", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                For Each row In dgvPlayers.Rows
                    If row.Cells("dgcSelect").Value = True Then
                        Dim intListIndex As Integer = row.Cells("dgcListIndex").Value

                        If lstTournTeams(intListIndex).TeamID = 0 Then
                            ' Remove the team from the list.
                            lstTournTeams.RemoveAt(intListIndex)

                            ' Rebuild the DGV.
                            BuildTournamentList()
                        Else
                            ' Can't delete the team, make an error
                            lstErrors.Add(lstTournTeams(intListIndex))

                            ' Instead of deleting them, change the player to "Absent on Day of Event".
                            lstTournTeams(intListIndex).Status = 8
                        End If

                        row.Cells("dgcSelect").Value = False

                    End If
                Next

                If lstErrors.Count > 0 Then
                    Dim strErrors As String = ""

                    For Each [error] In lstErrors
                        strErrors &= "•  " & [error].PlayerA.SummaryName & Environment.NewLine
                    Next


                    MessageBox.Show(String.Format("Deleted {0} players from the tournament roster." & Environment.NewLine & Environment.NewLine & "But {1} player(s) could not be deleted and were dropped instead. Either the player pre-registered or was enrolled through TCG+. To remove these players from the pairings, this player was set to ""Absent on Day of Event""." & Environment.NewLine & Environment.NewLine & "Players withdrawn:" & Environment.NewLine & strErrors, intCount - lstErrors.Count, lstErrors.Count), "Deleted Players", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show(String.Format("Succesfully deleted {0} players from tournament roster.", intCount), "Deleted players with no errors", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            End If

            ' Rebuild the Tournament List whether or not the list was successfully changed.
            BuildTournamentList()
        ElseIf dgvPlayers.SelectedRows.Count = 1 Then
            Dim intLstID As Integer = dgvPlayers.SelectedRows(0).Cells(0).Value

            If lstTournTeams(intLstID).TeamID <> 0 Then
                MessageBox.Show("Cannot delete this player." & Environment.NewLine & Environment.NewLine & "Either the player pre-registered or was enrolled through the TCG+ app. To remove this player from the pairings, set their status to ANYTHING but ""Participating in Tournament"".", "Cannot delete pre-registered player", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                lstTournTeams.RemoveAt(intLstID)
            End If
            ' Rebuild the Tournament List whether or not the list was successfully changed.
            BuildTournamentList()
        End If



        dgvPlayers.ClearSelection()

    End Sub

    Private Sub CloseTournamentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseTournamentToolStripMenuItem.Click
        Close() ' Close this form.
    End Sub

    Private Sub CommaSeparatedValuesFilecsvToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CommaSeparatedValuesFilecsvToolStripMenuItem.Click

        Dim FileName As String

        Dim blnHasInvalidPlayerNumber As Boolean = False

        If Not String.IsNullOrWhiteSpace(txtCSVFileName) AndAlso My.Computer.FileSystem.FileExists(txtCSVFileName) Then
            SaveFileDialogCSV.InitialDirectory = Path.GetDirectoryName(txtCSVFileName)
        ElseIf Not String.IsNullOrWhiteSpace(My.Settings.LastUsedDirectory) Then
            SaveFileDialogCSV.InitialDirectory = My.Settings.LastUsedDirectory
        Else
            SaveFileDialogCSV.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        End If


        If Not String.IsNullOrWhiteSpace(txtCSVFileName) AndAlso My.Computer.FileSystem.FileExists(txtCSVFileName) Then
            FileName = txtCSVFileName
        Else

            SaveFileDialogCSV.ShowDialog(Me)
            FileName = SaveFileDialogCSV.FileName

        End If

        If Not String.IsNullOrWhiteSpace(FileName) Then

            ' Set this file name as the NEW saved file name.
            txtCSVFileName = FileName

            Using csvDoc As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(FileName, False)
                csvDoc.WriteLine("""Team ID"",""Team Name"",""Win Point"",""Status"",""Bye Count"",""Membership Number - 1"",""Player Name - 1"",""Seat Order - 1"",""Memo"",""Deck Recipe - 1"", ""SMS Auth""")
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
No change in value will have any effect."",""Required
※Please set the seat order(A/B/C).""")

                For Each team In lstTournTeams
                    csvDoc.Write("""" & team.TeamID & """,")
                    csvDoc.Write("""" & team.TeamName & """,")
                    csvDoc.Write("""" & """,")
                    csvDoc.Write("""" & team.Status & """,")
                    csvDoc.Write("""" & team.ByeRounds & """,")
                    csvDoc.Write("""" & team.PlayerA.MembershipNumber & """,")
                    csvDoc.Write("""" & team.PlayerA.MembershipName & """,")
                    csvDoc.Write("""" & team.PlayerA.SeatOrder & """,")
                    csvDoc.Write("""" & IIf(My.Settings.PlayerNameFull, team.PlayerA.PlayerFullName, "") & """,")
                    csvDoc.Write("""" & team.PlayerA.DeckRecipe & """,")
                    csvDoc.Write("""" & team.SMSAuth & """")
                    csvDoc.Write(Environment.NewLine)
                Next

                csvDoc.Close()
            End Using

            tslFileName.Text = "File Name: " & txtCSVFileName
            tslFileName.Visible = True

            My.Settings.LastUsedDirectory = Path.GetDirectoryName(txtCSVFileName)
            My.Settings.Save()
            'MessageBox.Show("Last Path Used: " & Path.GetDirectoryName(txtCSVFileName))
            MessageBox.Show("CSV Export Complete." & Environment.NewLine & Environment.NewLine & "File Saved to:" & Environment.NewLine & txtCSVFileName, "CSV Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub CommaSeparatedValuesFilecsvToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CommaSeparatedValuesFilecsvToolStripMenuItem1.Click
        ' No check for a file, this one will ALWAYS generate a prompt.
        If Not String.IsNullOrWhiteSpace(txtCSVFileName) AndAlso My.Computer.FileSystem.FileExists(txtCSVFileName) Then
            SaveFileDialogCSV.InitialDirectory = Path.GetDirectoryName(txtCSVFileName)
        ElseIf Not String.IsNullOrWhiteSpace(My.Settings.LastUsedDirectory) Then
            SaveFileDialogCSV.InitialDirectory = My.Settings.LastUsedDirectory
        Else
            SaveFileDialogCSV.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        End If

        If SaveFileDialogCSV.ShowDialog(Me) = DialogResult.OK Then
            Dim FileName As String = SaveFileDialogCSV.FileName

            Using csvDoc As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(FileName, False)
                csvDoc.WriteLine("""Team ID"",""Team Name"",""Win Point"",""Status"",""Bye Count"",""Membership Number - 1"",""Player Name - 1"",""Seat Order - 1"",""Memo"", ""Deck Recipe - 1"", ""SMS Auth""")
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
                    csvDoc.Write("""" & player.TeamID & """,")
                    csvDoc.Write("""" & player.TeamName & """,")
                    csvDoc.Write("""" & """,")
                    csvDoc.Write("""" & player.Status & """,")
                    csvDoc.Write("""" & player.ByeRounds & """,")
                    csvDoc.Write("""" & player.PlayerA.MembershipNumber & """,")
                    csvDoc.Write("""" & player.PlayerA.MembershipName & """,")
                    csvDoc.Write("""" & player.PlayerA.SeatOrder & """,")
                    csvDoc.Write("""" & IIf(My.Settings.PlayerNameFull, player.PlayerA.PlayerFullName, "") & """,")
                    csvDoc.Write("""" & player.PlayerA.DeckRecipe & """,")
                    csvDoc.Write("""" & player.SMSAuth & """")
                    csvDoc.Write(Environment.NewLine)
                Next

                csvDoc.Close()
            End Using


            tslFileName.Text = "File Name: " & txtCSVFileName
            tslFileName.Visible = True

            My.Settings.LastUsedDirectory = Path.GetDirectoryName(txtCSVFileName)
            My.Settings.Save()
            'MessageBox.Show("Last Path Used: " & Path.GetDirectoryName(txtCSVFileName))
            MessageBox.Show("CSV Export Complete." & Environment.NewLine & Environment.NewLine & "File Saved to:" & Environment.NewLine & txtCSVFileName, "CSV Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub TournamentXMLxmlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TournamentXMLxmlToolStripMenuItem.Click

        Dim FileName As String


        If Not String.IsNullOrWhiteSpace(txtCSVFileName) AndAlso My.Computer.FileSystem.FileExists(txtCSVFileName) Then
            SaveFileDialogXML.InitialDirectory = Path.GetDirectoryName(txtCSVFileName)
        ElseIf Not String.IsNullOrWhiteSpace(My.Settings.LastUsedDirectory) Then
            SaveFileDialogXML.InitialDirectory = My.Settings.LastUsedDirectory
        Else
            SaveFileDialogXML.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        End If

        If Not String.IsNullOrWhiteSpace(txtXMLFileName) AndAlso My.Computer.FileSystem.FileExists(txtXMLFileName) Then
            FileName = txtXMLFileName
        Else
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
                                                                                         New XElement("SeatOrder", "A"),
                                                                                         New XElement("DeckRecipe", team.PlayerA.DeckRecipe)))))
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
            tslFileName.Text = "File Name: " & txtXMLFileName
            tslFileName.Visible = True

            My.Settings.LastUsedDirectory = Path.GetDirectoryName(txtXMLFileName)
            My.Settings.Save()
            MessageBox.Show("XML Export Complete." & Environment.NewLine & Environment.NewLine & "File Saved to:" & Environment.NewLine & txtXMLFileName, "XML Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub TournamentXMLxmlToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TournamentXMLxmlToolStripMenuItem1.Click
        ' This is to save a copy as. So there will always be a prompt.

        If Not String.IsNullOrWhiteSpace(txtCSVFileName) AndAlso My.Computer.FileSystem.FileExists(txtCSVFileName) Then
            SaveFileDialogXML.InitialDirectory = Path.GetDirectoryName(txtCSVFileName)
        ElseIf Not String.IsNullOrWhiteSpace(My.Settings.LastUsedDirectory) Then
            SaveFileDialogXML.InitialDirectory = My.Settings.LastUsedDirectory
        Else
            SaveFileDialogXML.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        End If

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
                                                                                         New XElement("SeatOrder", "A"),
                                                                                         New XElement("DeckRecipe", team.PlayerA.DeckRecipe)))))
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
            tslFileName.Text = "File Name: " & txtXMLFileName
            tslFileName.Visible = True

            My.Settings.LastUsedDirectory = Path.GetDirectoryName(txtXMLFileName)
            My.Settings.Save()
            MessageBox.Show("XML Export Complete." & Environment.NewLine & Environment.NewLine & "File Saved to:" & Environment.NewLine & txtXMLFileName, "XML Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub PenaltiesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenaltiesToolStripMenuItem.Click
        ' Call up the frmPenalties
        Using frmPenaltyList As New frmPenalties

            ' New field since we have to cycle through EACH team to extra the tournament players.

            Dim lstTournPlayers As New List(Of PlayerInfo)

            For Each team In lstTournTeams
                ' There is only a PlayerA field since this is Individual registration. 
                lstTournPlayers.Add(team.PlayerA)
            Next

            ' Copy all the "major" details from this form and assign them to the sub form.
            frmPenaltyList.lstPenalties.AddRange(lstPenalties)
            frmPenaltyList.lstTournPlayers = lstTournPlayers
            frmPenaltyList.lstStaff = lstStaff

            If frmPenaltyList.ShowDialog() = DialogResult.OK Then
                lstPenalties = frmPenaltyList.lstPenalties
            End If

        End Using
    End Sub

    Private Sub StaffJudgesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaffJudgesToolStripMenuItem.Click
        Using frmStaff As New frmStaffList
            ' Assign the staff list to a local variable for manipulating

            frmStaff.cboStaffMember.DataSource = New BindingSource(lstPlayers, Nothing)
            frmStaff.cboStaffMember.ValueMember = "MembershipNumber"
            frmStaff.cboStaffMember.DisplayMember = "ListSummary"

            frmStaff.lstStaff.AddRange(lstStaff)
            ' Add all players from the global list that are NOT tournament players

            frmStaff.lstRoster.AddRange(lstTournTeams)

            If frmStaff.ShowDialog(Me) = DialogResult.OK Then
                lstStaff = frmStaff.lstStaff

                ' Have to make changes in case new players were added via the staff form.
                LoadPlayersListFromXML()

            End If

        End Using
    End Sub

    Private Sub btnNoNumber_Click(sender As Object, e As EventArgs)
        MessageBox.Show("If the player does not have a Bandai TCG+ Number and does not want to sign up for one, that is fine." & Environment.NewLine & Environment.NewLine & "During the event's ""Check-In"" step, you can create a ""guest"" player to be added to the event. This player will NOT be able to use the app to report pairings nor will it count towards your TCG+ Shop Rank." & Environment.NewLine & Environment.NewLine & "Remember, the old BCC (Budokai Card Club) numbers do not work with the new system.", "How to handle ""guest"" registrations.", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ChangePlayerDetails0ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePlayerDetails0ToolStripMenuItem.Click
        'MessageBox.Show(String.Format("{0} was the selected player.", lbSearchResults.SelectedValue))

        Dim playerInfo As PlayerInfo = lstPlayers.Find(Function(x) x.MembershipNumber = lbSearchResults.SelectedValue)

        Using frmChangeInfo As New frmPlayerDetail

            With frmChangeInfo
                .txtMemberNo.Text = playerInfo.MembershipNumber
                .txtPlayerFirstName.Text = playerInfo.FirstName
                .txtPlayerLastName.Text = playerInfo.LastName
                .txtPlayerNickname.Text = playerInfo.MembershipName

                .txtMemberNo.ReadOnly = True
            End With

            frmChangeInfo.txtPlayerFirstName.Focus()

            If frmChangeInfo.ShowDialog = DialogResult.OK Then
                ' We are changing the player's info, so update the XML as needed.
                UpdateAllPlayerXML(frmChangeInfo.txtMemberNo.Text.Trim, frmChangeInfo.txtPlayerNickname.Text.Trim, frmChangeInfo.txtPlayerFirstName.Text.Trim, frmChangeInfo.txtPlayerLastName.Text.Trim)

                LoadPlayersListFromXML()
            End If
        End Using
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearPlayer()
    End Sub

    Private Sub cmsPlayerList_Closed(sender As Object, e As ToolStripDropDownClosedEventArgs) Handles cmsPlayerList.Closed
        ' Reset the options
        ChangePlayerDetails0ToolStripMenuItem.Text = "Change Player Details: {0}"
    End Sub

    Private Sub frmIndividual_Activated(sender As Object, e As EventArgs) Handles MyBase.GotFocus
        ' Whenever the form is activated, refill the list from the XML.
        LoadPlayersListFromXML()

    End Sub

    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click
        blnSearch = False
        txtSearchPlayer.Clear()
        FillListBox()
    End Sub

    Private Sub MasterPlayerRosterToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Using frmPlayerDatabase As New frmMasterPlayerList
            frmPlayerDatabase.ShowDialog()

            LoadPlayersListFromXML()
            BuildTournamentList()
        End Using
    End Sub

    Private Sub btnAddFromFile_Click(sender As Object, e As EventArgs) Handles btnAddFromFile.Click
        ' Put the cmsAddFromFile menu above the "AddFromFile"
        cmsAddFromFile.Show(btnAddFromFile, 0, -cmsAddFromFile.Height)

    End Sub

    Private Sub AddFromCSVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddFromCSVToolStripMenuItem.Click
        ' Prompt the user for a CSV File.
        If (OpenFileDialogCSV.ShowDialog(Me) = DialogResult.OK) Then
            Dim lstFileData As List(Of TournamentTeam) = csvPlayerReadOut(OpenFileDialogCSV.FileName)

            ' Process that CSV file by going through each player in the
            ' CSV and updating as needed.

            ' If the "TeamID" AND "MembershipNumber" BOTH match, replace the 
            ' status of that player with the incoming file.

            For Each player In lstFileData
                Dim index As Integer = lstTournTeams.IndexOf(lstTournTeams.Find(Function(p) p.PlayerA.MembershipNumber = player.PlayerA.MembershipNumber And p.TeamID = player.TeamID))

                If index <> -1 Then
                    If lstTournTeams(index).Status < player.Status Then
                        lstTournTeams(index).Status = player.Status
                        lstTournTeams(index).TeamID = player.TeamID
                    End If
                Else
                    lstTournTeams.Add(player)
                End If
            Next

        End If
        AddNewPlayersFromImportCSV()
        lbSearchResults.ClearSelected()

        BuildTournamentList()
    End Sub

    Private Sub AddFromXMLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddFromXMLToolStripMenuItem.Click
        If (OpenFileDialogCSV.ShowDialog(Me) = DialogResult.OK) Then
            Dim lstFileData As List(Of TournamentTeam) = xmlPlayerReadOut(OpenFileDialogXML.FileName)(0)

            ' Process that CSV file by going through each player in the
            ' CSV and updating as needed.

            ' If the "TeamID" AND "MembershipNumber" BOTH match, replace the 
            ' status of that player with the incoming file.

            For Each player In lstFileData
                Dim index As Integer = lstTournTeams.IndexOf(lstTournTeams.Find(Function(p) p.PlayerA.MembershipNumber = player.PlayerA.MembershipNumber And p.TeamID = player.TeamID))

                If index <> -1 Then
                    If lstTournTeams(index).Status < player.Status Then
                        lstTournTeams(index).Status = player.Status
                        lstTournTeams(index).TeamID = player.TeamID
                    End If
                Else
                    lstTournTeams.Add(player)
                End If
            Next

        End If

        AddNewPlayersFromImportXML()
        lbSearchResults.ClearSelected()

        BuildTournamentList()
    End Sub



    Private Sub dgvPlayers_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvPlayers.CellMouseClick

        If e.Button = MouseButtons.Right And e.RowIndex >= 0 Then
            dgvPlayers.CurrentCell = dgvPlayers.Rows(e.RowIndex).Cells(e.ColumnIndex)

            ' Change the first item in the CMS to what is needed.
            ' Get the current Tournament Status of the selected Player
            Dim index As Integer = dgvPlayers.CurrentRow.Cells("dgcListIndex").Value

            ' Set the options of the cmsTournamentList as needed.
            ' Change the name of the "player" space to the actual player.
            tsmiPlayerName.Text = String.Format(tsmiPlayerName.Text, lstTournTeams(index).PlayerA.SummaryName)

            cmsTournamentList.Show(dgvPlayers, dgvPlayers.PointToClient(Cursor.Position))

            Select Case lstTournTeams(index).Status
                Case 1
                    AppliedToolStripMenuItem.Checked = True
                Case 2
                    SuccessfulToolStripMenuItem.Checked = True
                Case 3
                    WaitingListToolStripMenuItem.Checked = True
                Case 4
                    UnsuccessfulToolStripMenuItem.Checked = True
                Case 5
                    CancelledToolStripMenuItem.Checked = True
                Case 6
                    SelectedCheckedInToolStripMenuItem.Checked = True
                Case 7
                    WaitingForCancellationCheckedInToolStripMenuItem.Checked = True
                Case 8
                    AbsentOnDayOfEventToolStripMenuItem.Checked = True
                Case 9
                    AdvanceElectedToolStripMenuItem.Checked = True
                Case 10
                    ParticipatingInTournamentToolStripMenuItem.Checked = True
                Case 11
                    DroppedToolStripMenuItem.Checked = True
            End Select

        End If
    End Sub

    Private Sub cmsTournamentList_Closed(sender As Object, e As ToolStripDropDownClosedEventArgs) Handles cmsTournamentList.Closed
        ' Reset all items back to unchecked.
        AppliedToolStripMenuItem.Checked = False
        SuccessfulToolStripMenuItem.Checked = False
        WaitingListToolStripMenuItem.Checked = False
        UnsuccessfulToolStripMenuItem.Checked = False
        CancelledToolStripMenuItem.Checked = False
        SelectedCheckedInToolStripMenuItem.Checked = False
        WaitingForCancellationCheckedInToolStripMenuItem.Checked = False
        AbsentOnDayOfEventToolStripMenuItem.Checked = False
        AdvanceElectedToolStripMenuItem.Checked = False
        ParticipatingInTournamentToolStripMenuItem.Checked = False
        DroppedToolStripMenuItem.Checked = False

        ' Reset it back to default
        tsmiPlayerName.Text = "{0}"
    End Sub

    Private Sub AppliedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WaitingListToolStripMenuItem.Click, WaitingForCancellationCheckedInToolStripMenuItem.Click, UnsuccessfulToolStripMenuItem.Click, SuccessfulToolStripMenuItem.Click, SelectedCheckedInToolStripMenuItem.Click, ParticipatingInTournamentToolStripMenuItem.Click, DroppedToolStripMenuItem.Click, CancelledToolStripMenuItem.Click, AppliedToolStripMenuItem.Click, AdvanceElectedToolStripMenuItem.Click, AbsentOnDayOfEventToolStripMenuItem.Click
        Dim index As Integer = dgvPlayers.CurrentRow.Cells("dgcListIndex").Value

        Select Case sender.Name
            Case AppliedToolStripMenuItem.Name
                lstTournTeams(index).Status = 1
            Case SuccessfulToolStripMenuItem.Name
                lstTournTeams(index).Status = 2
            Case WaitingListToolStripMenuItem.Name
                lstTournTeams(index).Status = 3
            Case UnsuccessfulToolStripMenuItem.Name
                lstTournTeams(index).Status = 4
            Case CancelledToolStripMenuItem.Name
                lstTournTeams(index).Status = 5
            Case SelectedCheckedInToolStripMenuItem.Name
                lstTournTeams(index).Status = 6
            Case WaitingForCancellationCheckedInToolStripMenuItem.Name
                lstTournTeams(index).Status = 7
            Case AbsentOnDayOfEventToolStripMenuItem.Name
                lstTournTeams(index).Status = 8
            Case AdvanceElectedToolStripMenuItem.Name
                lstTournTeams(index).Status = 9
            Case ParticipatingInTournamentToolStripMenuItem.Name
                lstTournTeams(index).Status = 10
            Case DroppedToolStripMenuItem.Name
                lstTournTeams(index).Status = 11
        End Select

        dgvPlayers.CurrentRow.Cells("dgcStatus").Value = _status(lstTournTeams(index).Status)
        ' Rebuild the tournament list as needed
        ' BuildTournamentList()

    End Sub

    Private Sub DeletePlayerFromTournamentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeletePlayerFromTournamentToolStripMenuItem.Click
        Dim intLstID As Integer = dgvPlayers.SelectedRows(0).Cells(0).Value

        If lstTournTeams(intLstID).TeamID <> 0 Then
            MessageBox.Show("Cannot delete this player." & Environment.NewLine & Environment.NewLine & "Either the player pre-registered or was enrolled through the TCG+ app. To remove this player from the pairings, set their status to ANYTHING but ""Participating in Tournament"".", "Cannot delete pre-registered player", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            lstTournTeams.RemoveAt(intLstID)

            BuildTournamentList()
        End If

        ClearPlayer()
    End Sub

    Private Sub ChangeTeamIDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeTeamIDToolStripMenuItem.Click
        Dim intLstID As Integer = dgvPlayers.SelectedRows(0).Cells(0).Value

        Using frmChangeTeam As New frmChangeTeamID

            frmChangeTeam.lblOldTeamID.Text = lstTournTeams(intLstID).TeamID
            frmChangeTeam.nudTeamID.Value = lstTournTeams(intLstID).TeamID

            While frmChangeTeam.DialogResult <> DialogResult.OK And frmChangeTeam.DialogResult <> DialogResult.Cancel
                If frmChangeTeam.ShowDialog = DialogResult.OK Then

                    ' Have to make sure at least the value doesn't already exist in the list.
                    ' Or That It's a different value.
                    If lstTournTeams.Any(Function(n) n.TeamID = frmChangeTeam.nudTeamID.Value) And frmChangeTeam.nudTeamID.Value <> 0 And frmChangeTeam.nudTeamID.Value <> lstTournTeams(intLstID).TeamID Then
                        frmChangeTeam.DialogResult = DialogResult.None
                        MessageBox.Show("The selected value already exist within the list and is invalid. Please choose another TeamID.", "Invalid TeamID", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        ' Okay so this number is NOT invalid, so change it as needed.
                        lstTournTeams(intLstID).TeamID = frmChangeTeam.nudTeamID.Value
                        BuildTournamentList()
                    End If
                End If
            End While
        End Using
    End Sub

    Private Sub ChangeMembershipNumberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeMembershipNumberToolStripMenuItem.Click
        Dim intLstID As Integer = dgvPlayers.SelectedRows(0).Cells(0).Value

        Using frmChangePlayer As New frmChangePlayerNumber

            frmChangePlayer.lblOldPlayerID.Text = lstTournTeams(intLstID).PlayerA.MembershipNumber
            frmChangePlayer.txtNewPlayerID.Text = lstTournTeams(intLstID).PlayerA.MembershipNumber

            While frmChangePlayer.DialogResult <> DialogResult.OK And frmChangePlayer.DialogResult <> DialogResult.Cancel
                If frmChangePlayer.ShowDialog = DialogResult.OK Then

                    ' Have to make sure at least the value doesn't already exist in the list.
                    ' Or That It's a different value.
                    If lstTournTeams.Any(Function(n) n.PlayerA.MembershipNumber = frmChangePlayer.txtNewPlayerID.Text) And frmChangePlayer.txtNewPlayerID.Text <> "0000000000" And frmChangePlayer.txtNewPlayerID.Text <> "GUEST99999" And frmChangePlayer.txtNewPlayerID.Text <> lstTournTeams(intLstID).PlayerA.MembershipNumber Then
                        frmChangePlayer.DialogResult = DialogResult.None
                        MessageBox.Show("The selected player already exist within the tournament list or is invalid. Please enter another Membership ID.", "Invalid Membership ID", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        ' Okay so this number is NOT invalid, so change it as needed.
                        lstTournTeams(intLstID).PlayerA.MembershipNumber = frmChangePlayer.txtNewPlayerID.Text
                        BuildTournamentList()
                    End If
                End If
            End While
        End Using
    End Sub

    Private Sub FullNameEntryToolStripMenuItem_CheckedChanged(sender As Object, e As EventArgs) Handles FullNameEntryToolStripMenuItem.CheckedChanged
        ' If the player name option is checked, enable the First and Last name field.

        txtPlayerFirstName.Enabled = FullNameEntryToolStripMenuItem.Checked
        txtPlayerLastName.Enabled = FullNameEntryToolStripMenuItem.Checked

    End Sub

    Private Sub FullNameEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FullNameEntryToolStripMenuItem.Click
        FullNameEntryToolStripMenuItem.Checked = Not FullNameEntryToolStripMenuItem.Checked

        ' Change the Option too
        My.Settings.PlayerNameFull = Not My.Settings.PlayerNameFull
        My.Settings.Save()

    End Sub

    Private Sub AddPlayerToTournamentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddPlayerToTournamentToolStripMenuItem.Click
        ' This should change the selected player to be added.

        Dim index As Integer = dgvPlayers.CurrentRow.Cells("dgcListIndex").Value
        lstTournTeams(index).Status = 10

        dgvPlayers.CurrentRow.Cells("dgcStatus").Value = _status(10)

        ' Rebuild the list after the change.
        'BuildTournamentList()

    End Sub

    Private Sub DropPlayerFromTournamentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DropPlayerFromTournamentToolStripMenuItem.Click
        Dim index As Integer = dgvPlayers.CurrentRow.Cells("dgcListIndex").Value
        lstTournTeams(index).Status = 11

        dgvPlayers.CurrentRow.Cells("dgcStatus").Value = _status(11)

        ' Rebuild the list after the change.
        'BuildTournamentList()
    End Sub
End Class
