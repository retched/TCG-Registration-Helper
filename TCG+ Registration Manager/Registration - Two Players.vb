Public Class frmDuos
    Public Property txtXMLFileName As String
    Public Property txtCSVFileName As String

    ' List of Teams, Players, Penalties, and Staff
    Dim lstTournTeams As New List(Of TournamentTeam)
    Dim lstPlayers As New List(Of PlayerInfo)
    Dim lstPenalties As New List(Of TournamentPenalty)
    Dim lstStaff As New List(Of TournamentStaff)
    Dim blnSearch As Boolean = False

    Private Sub btnClearPlayer1_Click(sender As Object, e As EventArgs) Handles btnClearPlayer1.Click
        ' We're clicking this to clear JUST player 1
        txtMemberNo1.Clear()
        txtPlayerFirstName1.Clear()
        txtPlayerLastName1.Clear()
        txtPlayerNickname1.Clear()
    End Sub

    Private Sub btnClearPlayer2_Click(sender As Object, e As EventArgs) Handles btnClearPlayer2.Click
        txtMemberNo2.Clear()
        txtPlayerFirstName2.Clear()
        txtPlayerLastName2.Clear()
        txtPlayerNickname2.Clear()
    End Sub

    Private Sub frmDuos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                AddNewPlayersFromImport()
                MessageBox.Show("CSV File Loaded Sucessfully")
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
            AddNewPlayersFromImport()
            tslFileName.Text = "File Name: " & txtXMLFileName
            tslFileName.Visible = True
            MessageBox.Show("XML File Loaded Sucessfully")
        End If

        LoadPlayersListFromXML()

        BuildTournamentList()

        ClearTeamDetails()

    End Sub

    Private Sub btnAddTeam_Click(sender As Object, e As EventArgs) Handles btnAddTeam.Click
        Dim blnNotInTeam As Boolean = True

        ' Are there two valid player informations for the team?
        ' Valid Player Info means: AT A MINIMUM, Membership Number AND membership name (name is optional)
        ' Valid being two different numbers unless either one is guest
        If String.IsNullOrWhiteSpace(txtMemberNo1.Text) Or String.IsNullOrWhiteSpace(txtPlayerNickname1.Text) Then
            tcTeams.SelectedTab = tpPlayerA
            txtMemberNo1.Focus()
            MessageBox.Show("Missing Player A details.")
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtMemberNo2.Text) Or String.IsNullOrWhiteSpace(txtPlayerNickname2.Text) Then
            tcTeams.SelectedTab = tpPlayerB
            txtMemberNo2.Focus()
            MessageBox.Show("Missing Player B details.")
            Exit Sub
        End If

        ' Are the two member number boxes NOT the same? (It's OK if they're both GUEST99999)
        If {txtMemberNo1.Text, txtMemberNo2.Text}.Distinct().Count() < 2 Then
            MessageBox.Show("Both Players details are identical. Please double check and try again.")
            Exit Sub
        End If

        ' Is there a Team Name? (Since this is a team tournament, team names are a must!)
        If String.IsNullOrWhiteSpace(txtTeamName.Text) Then
            MessageBox.Show("Team name is required!")
            txtTeamName.Focus()
            Exit Sub
        End If


        If dgvTeams.SelectedRows.Count = 0 Then
            ' Are either player already a member of another team?
            For Each team In lstTournTeams
                If team.CheckTeam(txtMemberNo1.Text) Then blnNotInTeam = False
                If team.CheckTeam(txtMemberNo2.Text) Then blnNotInTeam = False
            Next

            If blnNotInTeam = False Then
                MessageBox.Show("One of the team members is registered as a member of another team. Check the team members and try again.")
                txtTeamName.Focus()
                Exit Sub
            End If
        End If

        ' Do either player exist in the staff list?
        If Not IsNothing(lstStaff.Find(Function(x) x.MembershipNumber = txtMemberNo1.Text.Trim())) Or Not IsNothing(lstStaff.Find(Function(x) x.MembershipNumber = txtMemberNo2.Text.Trim())) Then
            If MessageBox.Show("Please confirm that you are about to enroll a staff/judge as a player.", "Warning: Staff/Judge Being Added", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Exit Sub
        End If

        ' Okay we've done all of our checks. They're not in a team, nor are the info blocks blank,
        ' nor are they staff, nor are they the same person entered twice.

        ' Add/Update them to the tournament roster.
        If dgvTeams.SelectedRows.Count Then
            ' So we have a row detail to EDIT.

            lstTournTeams(dgvTeams.SelectedRows(0).Cells("dgcListIndex").Value) = New TournamentTeam With {
                        .PlayerA = New PlayerInfo() With {
                            .FirstName = txtPlayerFirstName1.Text.Trim(),
                            .LastName = txtPlayerLastName1.Text.Trim(),
                            .MembershipName = txtPlayerNickname1.Text.Trim(),
                            .MembershipNumber = txtMemberNo1.Text.Trim(),
                            .SeatOrder = "A"},
                        .PlayerB = New PlayerInfo() With {
                            .FirstName = txtPlayerFirstName2.Text.Trim(),
                            .LastName = txtPlayerLastName2.Text.Trim(),
                            .MembershipName = txtPlayerNickname2.Text.Trim(),
                            .MembershipNumber = txtMemberNo2.Text.Trim(),
                            .SeatOrder = "B"},
                        .PlayerC = New PlayerInfo(),
                        .ByeRounds = IIf(rbByes_0.Checked, 0, 1),
                        .Status = cboStatus.SelectedValue,
                        .TeamName = txtTeamName.Text.Trim(),
                        .TeamID = lstTournTeams(dgvTeams.SelectedRows(0).Cells("dgcListIndex").Value).TeamID
                      }

        Else
            ' We're adding a new team
            lstTournTeams.Add(New TournamentTeam() With {
                        .PlayerA = New PlayerInfo() With {
                            .FirstName = txtPlayerFirstName1.Text.Trim(),
                            .LastName = txtPlayerLastName1.Text.Trim(),
                            .MembershipName = txtPlayerNickname1.Text.Trim(),
                            .MembershipNumber = txtMemberNo1.Text.Trim(),
                            .SeatOrder = "A"},
                        .PlayerB = New PlayerInfo() With {
                            .FirstName = txtPlayerFirstName2.Text.Trim(),
                            .LastName = txtPlayerLastName2.Text.Trim(),
                            .MembershipName = txtPlayerNickname2.Text.Trim(),
                            .MembershipNumber = txtMemberNo2.Text.Trim(),
                            .SeatOrder = "B"},
                        .PlayerC = New PlayerInfo(),
                        .ByeRounds = IIf(rbByes_0.Checked, 0, 1),
                        .Status = cboStatus.SelectedValue,
                        .TeamName = txtTeamName.Text.Trim()
                      })
        End If

        ' Add/Update Player 1 info
        UpdateAllPlayerXML(txtMemberNo1.Text, txtPlayerNickname1.Text, txtPlayerFirstName1.Text, txtPlayerLastName1.Text)

        ' Add/Update Player 2 Info
        UpdateAllPlayerXML(txtMemberNo2.Text, txtPlayerNickname2.Text, txtPlayerFirstName2.Text, txtPlayerLastName2.Text)

        BuildTournamentList()

        dgvTeams.ClearSelection()

        ClearTeamDetails()

        ' When a new team is added, none of the checkboxes should be checked
        cbSelectAll.Checked = False
    End Sub

    Private Sub txtMemberNo1_Leave(sender As Object, e As EventArgs) Handles txtMemberNo1.Leave, txtMemberNo2.Leave
        If IsNumeric(sender.Text) Then
            sender.Text = sender.Text.PadLeft(10, "0")
        End If
        FindPlayerFromList(sender.Text, sender)

    End Sub

    Private Sub FindPlayerFromList(strPlayerNo As String, sender As Object)
        ' Find a team within the AllPlayers list whose number matches and fill it in.
        Dim result As PlayerInfo = lstPlayers.Find(Function(x) x.MembershipNumber = strPlayerNo)

        Dim objTXTArray As Object() = {txtMemberNo1, txtMemberNo2}

        Dim fnTXTArray As Object() = {txtPlayerFirstName1, txtPlayerFirstName2}
        Dim lnTXTArray As Object() = {txtPlayerLastName1, txtPlayerLastName2}
        Dim mnTXTArray As Object() = {txtPlayerNickname1, txtPlayerNickname2}


        Dim intIndex As Integer = Array.IndexOf(objTXTArray, sender)

        If Not IsNothing(result) Then
            ' If there was a team... Then change stuff as Needed

            fnTXTArray(intIndex).Text = result.FirstName
            lnTXTArray(intIndex).Text = result.LastName
            mnTXTArray(intIndex).Text = result.MembershipName
        Else
            ' Clear the fields, but do NOT change the bye setting(?)

            ' Just in case data was already entered. Leaving this alone.
            fnTXTArray(intIndex).Clear()
            lnTXTArray(intIndex).Clear()
            mnTXTArray(intIndex).Clear()
        End If

        objTXTArray(intIndex).Text = strPlayerNo

    End Sub

    Private Sub ClearTeamDetails()
        txtMemberNo1.Clear()
        txtPlayerFirstName1.Clear()
        txtPlayerLastName1.Clear()
        txtPlayerNickname1.Clear()

        txtMemberNo2.Clear()
        txtPlayerFirstName2.Clear()
        txtPlayerLastName2.Clear()
        txtPlayerNickname2.Clear()

        rbByes_0.Checked = True

        cboStatus.SelectedValue = 10

        txtTeamName.Clear()

        tcTeams.SelectedIndex = 0
        txtMemberNo1.Focus()

        dgvTeams.ClearSelection()
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

    Private Sub BuildTournamentList()

        LoadPlayersListFromXML()

        ' Clear the rows already there.
        dgvTeams.Rows.Clear()

        For Each team In lstTournTeams
            ' Find each team in the master list of players and add change the data as needed

            Dim tpPlayerA As PlayerInfo = lstPlayers.Find(Function(x) x.MembershipNumber = team.PlayerA.MembershipNumber)
            Dim tpPlayerB As PlayerInfo = lstPlayers.Find(Function(x) x.MembershipNumber = team.PlayerB.MembershipNumber)

            team.PlayerA.FirstName = tpPlayerA.FirstName
            team.PlayerA.LastName = tpPlayerA.LastName
            team.PlayerA.MembershipName = tpPlayerA.MembershipName

            team.PlayerB.FirstName = tpPlayerB.FirstName
            team.PlayerB.LastName = tpPlayerB.LastName
            team.PlayerB.MembershipName = tpPlayerB.MembershipName

            dgvTeams.Rows.Add(lstTournTeams.IndexOf(team), False, team.TeamName, "Seat A: " & team.PlayerA.ListSummary & Environment.NewLine & "Seat B: " & team.PlayerB.ListSummary, IIf(team.ByeRounds, "Yes", "No"), _status.Item(team.Status))
        Next

        For Each row As DataGridViewRow In dgvTeams.Rows
            row.Height = 40
        Next

        tslPlayerPreReg.Text = String.Format("{0} Teams(s) Pre-Registered", lstTournTeams.Count())
        tslActivePlayer.Text = String.Format("{0} Teams(s) Active", lstTournTeams.FindAll(Function(x As TournamentTeam) x.Status = "10").Count)

        dgvTeams.Sort(dgvTeams.Columns("dgcNickname"), ListSortDirection.Ascending)

        dgvTeams.ClearSelection()
    End Sub

    Private Sub txtMemberNo1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMemberNo1.KeyDown, txtMemberNo2.KeyDown
        ' On KeyPress "G", just change it to Guest99999
        If e.KeyCode = 71 Then
            e.Handled = True
            e.SuppressKeyPress = True
            sender.Text = "GUEST99999"
        End If

        If e.KeyCode = Keys.Enter Then

            e.SuppressKeyPress = True
            e.Handled = True

        End If
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

    Private Sub txtMemberNo1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMemberNo1.KeyPress, txtMemberNo2.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnClearTeam_Click(sender As Object, e As EventArgs) Handles btnClearTeam.Click
        ClearTeamDetails()
    End Sub

    Private Sub btnDeletePlayer_Click(sender As Object, e As EventArgs) Handles btnDeletePlayer.Click
        ' This can ONLY be done if the team does NOT have a "TeamID" loaded in from the Tournament file.
        ' If the team has a TeamID, do NOT delete the team.

        Dim lstErrors As New List(Of TournamentTeam)

        Dim intCount As Integer = 0
        For Each row In dgvTeams.Rows
            If row.Cells(1).Value = 1 Then intCount += 1
        Next

        If intCount > 0 Then
            If MessageBox.Show(String.Format("You are about to delete {0} player(s) from this tournament." & Environment.NewLine & Environment.NewLine & "Are you sure you want to proceed?", intCount), "Deleting Multiple Players", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                For Each row In dgvTeams.Rows
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
                        strErrors &= "•  " & [error].TeamName & Environment.NewLine
                    Next


                    MessageBox.Show(String.Format("Deleted {0} teams from the tournament roster." & Environment.NewLine & Environment.NewLine & "But {1} player(s) could not be deleted. Either the player pre-registered or was enrolled through the TCG+ app. To remove these Teams from the pairings, set their status to ANYTHING but ""Participating in Tournament""." & Environment.NewLine & Environment.NewLine & "Teams not removed:" & Environment.NewLine & strErrors, intCount - lstErrors.Count, lstErrors.Count), "Deleted Teams", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show(String.Format("Succesfully deleted {0} teams from tournament roster.", intCount), "Deleted teams with no errors", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            End If
        ElseIf dgvTeams.SelectedRows.Count = 1 Then
            Dim intLstID As Integer = dgvTeams.SelectedRows(0).Cells(0).Value

            If lstTournTeams(intLstID).TeamID <> 0 Then
                MessageBox.Show("Cannot delete this team." & Environment.NewLine & Environment.NewLine & "Either the team pre-registered or was enrolled through the TCG+ app. To remove this team from the pairings, set their status to ANYTHING but ""Participating in Tournament"".", "Cannot delete pre-registered team", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                lstTournTeams.RemoveAt(intLstID)

                BuildTournamentList()
            End If

        End If

        dgvTeams.ClearSelection()

    End Sub

    Private Sub dgvTeams_SelectionChanged(sender As Object, e As EventArgs) Handles dgvTeams.SelectionChanged
        If dgvTeams.SelectedRows.Count = 1 Then
            ' We have selected one team, put that teams data into the edit text boxes.

            Dim tdSelected As TournamentTeam = lstTournTeams(dgvTeams.SelectedRows(0).Cells(0).Value)

            txtMemberNo1.Text = tdSelected.PlayerA.MembershipNumber
            txtPlayerFirstName1.Text = tdSelected.PlayerA.FirstName
            txtPlayerLastName1.Text = tdSelected.PlayerA.LastName
            txtPlayerNickname1.Text = tdSelected.PlayerA.MembershipName

            txtMemberNo2.Text = tdSelected.PlayerB.MembershipNumber
            txtPlayerFirstName2.Text = tdSelected.PlayerB.FirstName
            txtPlayerLastName2.Text = tdSelected.PlayerB.LastName
            txtPlayerNickname2.Text = tdSelected.PlayerB.MembershipName

            txtTeamName.Text = tdSelected.TeamName

            cboStatus.SelectedValue = tdSelected.Status


            Select Case tdSelected.ByeRounds
                Case 0
                    rbByes_0.Checked = True
                Case 1
                    rbByes_1.Checked = True
            End Select

        Else
            ' Otherwise, we have selected 0 or none. Therefore clear the entry textboxes.
            ClearTeamDetails()
        End If
    End Sub

    Private Sub cbSelectAll_CheckedChanged(sender As Object, e As EventArgs) Handles cbSelectAll.CheckedChanged
        For Each row In dgvTeams.Rows
            row.Cells(1).Value = cbSelectAll.Checked
        Next
    End Sub

    Private Sub lbSearchResults_SelectedValueChanged(sender As Object, e As EventArgs) Handles lbSearchResults.SelectedValueChanged
        If lbSearchResults.SelectedItems.Count Then
            Select Case tcTeams.SelectedTab.Name
                Case "tpPlayerA"
                    FindPlayerFromList(lbSearchResults.SelectedValue, txtMemberNo1)
                Case "tpPlayerB"
                    FindPlayerFromList(lbSearchResults.SelectedValue, txtMemberNo2)
            End Select
        End If
    End Sub
    Private Sub btnSearchPlayer_Click(sender As Object, e As EventArgs) Handles btnSearchPlayer.Click
        blnSearch = True
        FillListBox()
    End Sub
    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click
        blnSearch = False
        txtSearchPlayer.Clear()
        FillListBox()
    End Sub

    Private Sub btnChangeChecked_Click(sender As Object, e As EventArgs) Handles btnChangeChecked.Click
        ' Go through each checked box and change the status as requested
        For Each tourn In dgvTeams.Rows
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

    Private Sub lbSearchResults_MouseDown(sender As Object, e As MouseEventArgs) Handles lbSearchResults.MouseUp
        cmsPlayerList.Location = MousePosition

        If e.Button = MouseButtons.Right Then
            lbSearchResults.SelectedIndex = lbSearchResults.IndexFromPoint(e.Location)

            If lbSearchResults.SelectedIndex <> -1 Then cmsPlayerList.Show()

            ' Change the first item in the CMS to what is needed.
            ChangePlayerDetails0ToolStripMenuItem.Text = String.Format(ChangePlayerDetails0ToolStripMenuItem.Text, lstPlayers.Find(Function(x) x.MembershipNumber = lbSearchResults.SelectedValue).SummaryName)
        End If
    End Sub

    Private Sub cmsPlayerList_Closed(sender As Object, e As ToolStripDropDownClosedEventArgs) Handles cmsPlayerList.Closed
        ' Reset the options
        ChangePlayerDetails0ToolStripMenuItem.Text = "Change Player Details: {0}"
    End Sub

    Private Sub CloseTournamentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseTournamentToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        ' No check for a file, this one will ALWAYS generate a prompt.

        SaveFileDialogCSV.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments

        If SaveFileDialogCSV.ShowDialog(Me) = DialogResult.OK Then
            Dim FileName As String = SaveFileDialogCSV.FileName

            Using csvDoc As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(FileName, False)
                csvDoc.WriteLine("""Team ID"",""Team Name"",""Win Point"",""Status"",""Bye Count"",""Membership Number - 1"",""Player Name - 1"",""Seat Order - 1"",""Membership Number - 2"",""Player Name - 2"",""Seat Order - 2"",""Memo""")
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
No change in value will have any effect."",""Required"",""Required"",""Uneditable
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
                        csvDoc.Write("""" & team.PlayerB.MembershipNumber & """,")
                        csvDoc.Write("""" & team.PlayerB.MembershipName & """,")
                        csvDoc.Write("""" & team.PlayerB.SeatOrder & """,")
                        csvDoc.Write("""" & "Player A - " & team.PlayerA.PlayerFullName & Environment.NewLine & "Player B - " & team.PlayerB.PlayerFullName & """")
                        csvDoc.Write(Environment.NewLine)
                    End If
                Next

                csvDoc.Close()
            End Using


            tslFileName.Text = "File Name: " & txtCSVFileName
            tslFileName.Visible = True
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
            tournament.SetAttributeValue("TeamPlayers", 2) ' Two Player tournament.

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
                                                                                         New XElement("SeatOrder", team.PlayerA.SeatOrder)),
                                                                            New XElement("Player",
                                                                                         New XElement("MemberNumber", team.PlayerB.MembershipNumber),
                                                                                         New XElement("MemberName", team.PlayerB.MembershipName),
                                                                                         New XElement("PlayerFirstName", team.PlayerB.FirstName),
                                                                                         New XElement("PlayerLastName", team.PlayerB.LastName),
                                                                                         New XElement("SeatOrder", team.PlayerB.SeatOrder)))))
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
            tournament.SetAttributeValue("TeamPlayers", 2) ' One player tournament.

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
                                                                                         New XElement("SeatOrder", team.PlayerA.SeatOrder)),
                                                                            New XElement("Player",
                                                                                         New XElement("MemberNumber", team.PlayerB.MembershipNumber),
                                                                                         New XElement("MemberName", team.PlayerB.MembershipName),
                                                                                         New XElement("PlayerFirstName", team.PlayerB.FirstName),
                                                                                         New XElement("PlayerLastName", team.PlayerB.LastName),
                                                                                         New XElement("SeatOrder", team.PlayerB.SeatOrder)))))
            Next

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
                csvDoc.WriteLine("""Team ID"",""Team Name"",""Win Point"",""Status"",""Bye Count"",""Membership Number - 1"",""Player Name - 1"",""Seat Order - 1"",""Membership Number - 2"",""Player Name - 2"",""Seat Order - 2"",""Memo""")
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
No change in value will have any effect."",""Required"",""Required"",""Uneditable
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
                        csvDoc.Write("""" & team.PlayerB.MembershipNumber & """,")
                        csvDoc.Write("""" & team.PlayerB.MembershipName & """,")
                        csvDoc.Write("""" & team.PlayerB.SeatOrder & """,")
                        csvDoc.Write("""" & "Player A - " & team.PlayerA.PlayerFullName & Environment.NewLine & "Player B - " & team.PlayerB.PlayerFullName & """")
                        csvDoc.Write(Environment.NewLine)
                    End If
                Next

                csvDoc.Close()
            End Using

            tslFileName.Text = "File Name: " & txtCSVFileName
            tslFileName.Visible = True
        End If

    End Sub

    Private Sub AddNewPlayersFromImport()
        ' Gist: Comb through the imported players and add them (or update them) to the Global Player XML.

        For Each team In lstTournTeams
            team.PlayerA.FormatNumber()
            team.PlayerB.FormatNumber()

            ' We only have a two-player team in this list, so we only need PlayerA from lstTournTeams
            UpdateAllPlayerXML(team.PlayerA.MembershipNumber, team.PlayerA.MembershipName, team.PlayerA.FirstName, team.PlayerA.LastName)
            UpdateAllPlayerXML(team.PlayerB.MembershipNumber, team.PlayerB.MembershipName, team.PlayerB.FirstName, team.PlayerB.LastName)
        Next

        For Each staff In lstStaff
            staff.FormatNumber()
            ' We also have to loop through and add all staff members to the master list of players.
            UpdateAllPlayerXML(staff.MembershipNumber, staff.MembershipName, staff.FirstName, staff.LastName)
        Next

        ' Since a new team was made, we should update the "Global Player List" on the form.
        LoadPlayersListFromXML()
    End Sub
End Class