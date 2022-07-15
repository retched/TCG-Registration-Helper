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
    Dim lstTournPlayers As New List(Of TournamentPlayer)

    Dim lstStaff As New List(Of TournamentStaff)

    Dim lstPenalties As New List(Of TournamentPenalty)

    Dim blnSearch As Boolean = False

    Private Sub cbGuest_CheckedChanged(sender As Object, e As EventArgs) Handles cbGuest.CheckedChanged
        If cbGuest.Checked Then
            ' This is a Guest Player
            txtMemberNo.Enabled = False
            txtMemberNo.Text = "GUEST99999"

            ' Reset all to default (MINUS the player number)
            txtPlayerFirstName.Clear()
            txtPlayerLastName.Clear()
            txtPlayerNickname.Clear()
            cboChangeStatus.SelectedValue = 10

            ' Clear selections from datagridview and select box
            lbSearchResults.ClearSelected()
            dgvPlayers.ClearSelection()

            ' Move the focus to the player's name
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
            Dim lstFileData As List(Of TournamentPlayer) = csvSinglePlayerReadOut(txtCSVFileName)

            lstTournPlayers = lstFileData.ToList()

            ' Add New Players to Global Player List 
            AddNewPlayersFromImport(lstFileData)
        ElseIf Not String.IsNullOrEmpty(txtXMLFileName) Then
            ' If the XML Name is set, process the XML File.
            Dim lstFileData As List(Of Object) = xmlSinglePlayerReadOut(txtXMLFileName)

            lstTournPlayers = lstFileData(0).ToList
            lstStaff = lstFileData(1).ToList
            lstPenalties = lstFileData(2).ToList

            ' Add New Players to Global Player List 
            AddNewPlayersFromImport(lstTournPlayers)
        End If

        ' Load from XML and put names into Datatable
        LoadPlayersListFromXML()

        ' Clear selection from listbox. (I have no idea why .NET does this.)
        lbSearchResults.ClearSelected()

        BuildTournamentList()

    End Sub

    Private Sub AddNewPlayersFromImport(lstFileData As List(Of TournamentPlayer))
        ' Gist: Comb through the imported players and add them (or update them) to the Global Player XML.

        For Each player In lstFileData
            UpdateAllPlayerXML(player.strMembershipNo, player.strMembershipName)
        Next

    End Sub

    Private Sub btnAddPlayer_Click(sender As Object, e As EventArgs) Handles btnAddPlayer.Click

        If String.IsNullOrEmpty(txtMemberNo.Text.Trim) Or String.IsNullOrEmpty(txtPlayerNickname.Text.Trim) Then
            MessageBox.Show("You must enter at LEAST a Membership Number and a Nickname.", "Invalid Entrant", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ' Add Player to Tournament List, check to make sure they AREN'T in the list already
            Dim result As TournamentPlayer = lstTournPlayers.Find(Function(x) x.strMembershipNo = txtMemberNo.Text.Trim())

            If IsNothing(result) Then
                lstTournPlayers.Add(New TournamentPlayer() With {
                                    .strPlayerFirstName = txtPlayerFirstName.Text.Trim(),
                                    .strPlayerLastName = txtPlayerLastName.Text.Trim(),
                                    .strMembershipName = txtPlayerNickname.Text.Trim(),
                                    .strMembershipNo = txtMemberNo.Text.Trim(),
                                    .intByeRounds = IIf(rbByes_0.Checked, 0, 1),
                                    .intStatus = cboStatus.SelectedValue,
                                    .strSeatOrder = "A"
                                })

            Else
                ' This player should not be ADDED but rather UPDATED to the new information.
                ' MessageBox.Show("Player No. " & txtMemberNo.Text.Trim() & " already exists in the Player List. This player will be updated instead.")

                Dim index As Integer = lstTournPlayers.IndexOf(result)
                lstTournPlayers(index) = New TournamentPlayer() With {
                                    .strPlayerFirstName = txtPlayerFirstName.Text.Trim(),
                                    .strPlayerLastName = txtPlayerLastName.Text.Trim(),
                                    .strMembershipName = txtPlayerNickname.Text.Trim(),
                                    .strMembershipNo = txtMemberNo.Text.Trim(),
                                    .intByeRounds = IIf(rbByes_0.Checked, 0, 1),
                                    .intStatus = cboStatus.SelectedValue,
                                    .strSeatOrder = "A",
                                    .intTeamID = lstTournPlayers(index).intTeamID
                    }

            End If

            ' Should also add this player to the XML file of AllPlayers too and reload the XMLFile.
            ' Does this player ID (non-guest exist within the AllPlayers XML?)
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

        If strMemberID <> "GUEST99999" Then
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
                End If

                If String.IsNullOrWhiteSpace(target.Element("LastName").Value) And Not String.IsNullOrWhiteSpace(strPlayerLastName) Then
                    target.SetElementValue("LastName", strPlayerLastName)
                End If


                target.SetElementValue("MembershipNo", strMemberID)
                target.SetElementValue("MembershipName", strMemberName)
            End If

            xdoc.Save(Application.StartupPath + "AllPlayers.xml")

            ' Since a new player was made, we should update the "Global Player List" on the form.
            LoadPlayersListFromXML()
            lbSearchResults.ClearSelected()
        End If

    End Sub

    Private Sub BuildTournamentList()
        ' Clear the rows already there.
        dgvPlayers.Rows.Clear()

        For Each player In lstTournPlayers

            If player.intStatus <> 9999 Then
                ' Find each player in the master list of players and add change the data as needed

                Dim result As PlayerInfo = lstPlayers.Find(Function(x) x.strMembershipNo = player.strMembershipNo)
                If IsNothing(result) Then
                    dgvPlayers.Rows.Add(lstTournPlayers.IndexOf(player), False, player.strMembershipNo, player.strSummaryName, IIf(player.intByeRounds, "Yes", "No"), _status.Item(player.intStatus))
                Else
                    ' We found a matching player
                    ' That means we copy that player's info over to the tournament player info
                    player.strPlayerLastName = result.strPlayerLastName
                    player.strPlayerFirstName = result.strPlayerFirstName
                    player.strMembershipName = result.strMembershipName


                    dgvPlayers.Rows.Add(lstTournPlayers.IndexOf(player), False, player.strMembershipNo, player.strSummaryName, IIf(player.intByeRounds, "Yes", "No"), _status.Item(player.intStatus))
                End If

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
    End Sub

    Sub LoadPlayersListFromXML()
        Dim xdoc As New XDocument
        xdoc = XDocument.Load(Application.StartupPath + "AllPlayers.xml")

        ' Load XML Document into a list.

        lstPlayers = xdoc.Root.Elements("Player").[Select](Function(st) New PlayerInfo With {
                                                      .strMembershipName = st.Element("MembershipName"),
                                                      .strPlayerFirstName = st.Element("FirstName"),
                                                      .strPlayerLastName = st.Element("LastName"),
                                                      .strMembershipNo = st.Element("MembershipNo")}).ToList()

        blnSearch = False
        FillListBox()

        ' Clear the Search box since we added a player.
        txtSearchPlayer.Clear()

    End Sub

    Private Sub FillListBox()

        If blnSearch Then
            ' Make a copy of the list of TournPlayers (we don't want to overwrite)
            Dim lstSearch As List(Of PlayerInfo) = lstPlayers.FindAll(Function(x) x.strSearchHelper.ToLower.Contains(txtSearchPlayer.Text.ToLower.Trim)).ToList

            If rbMemberName.Checked Then
                lstSearch = lstSearch.OrderBy(Function(x) x.strMembershipName).ToList()
            ElseIf rbMembershipID.Checked Then
                lstSearch = lstSearch.OrderBy(Function(x) x.strMembershipNo).ToList()
            Else
                'rbPlayerName.Checked, Sort by First Name Then Last Name.
                lstSearch = lstSearch.OrderBy(Function(x) x.strPlayerLastName).ThenBy(Function(x) x.strPlayerFirstName).ToList()
            End If

            lbSearchResults.DataSource = lstSearch

        Else
            If rbMemberName.Checked Then
                lstPlayers = lstPlayers.OrderBy(Function(x) x.strMembershipName).ToList()
            ElseIf rbMembershipID.Checked Then
                lstPlayers = lstPlayers.OrderBy(Function(x) x.strMembershipNo).ToList()
            Else
                'rbPlayerName.Checked, Sort by First Name Then Last Name.
                lstPlayers = lstPlayers.OrderBy(Function(x) x.strPlayerLastName).ThenBy(Function(x) x.strPlayerFirstName).ToList()
            End If

            ' Fill listbox from dataset. (Format: "GUEST99999 - SomeNickname (PlayerFirst PlayerLast)" )
            lbSearchResults.DisplayMember = "strSummary"
            lbSearchResults.ValueMember = "strMembershipNo"
            lbSearchResults.DataSource = lstPlayers

        End If


        lbSearchResults.ClearSelected()

    End Sub

    Private Sub lbSearchResults_SelectedValueChanged(sender As Object, e As EventArgs) Handles lbSearchResults.SelectedValueChanged
        ' When the selection is changed, clear the fields and replace them with the data from the table.
        ClearPlayer()

        If lbSearchResults.SelectedItems.Count > 0 Then
            ' MessageBox.Show("Selected Row was: " & lbSearchResults.SelectedItem.strMembershipNo)

            txtMemberNo.Text = lbSearchResults.SelectedItem.strMembershipNo.ToString
            txtPlayerFirstName.Text = lbSearchResults.SelectedItem.strPlayerFirstName.ToString
            txtPlayerLastName.Text = lbSearchResults.SelectedItem.strPlayerLastName.ToString
            txtPlayerNickname.Text = lbSearchResults.SelectedItem.strMembershipName.ToString
        Else
            ClearPlayer()
        End If

    End Sub

    Private Sub txtMemberNo_Leave(sender As Object, e As EventArgs) Handles txtMemberNo.Leave
        If IsNumeric(txtMemberNo.Text.Trim) And cbGuest.Checked = False Then
            ' If the text is a numeric number (AKA, not a guest) change that number
            ' to a proper membership number

            txtMemberNo.Text = txtMemberNo.Text.ToString.PadLeft(10, "0")

            ' Find the player whose info matches
            FindPlayerFromList(txtMemberNo.Text)
        End If

    End Sub

    Private Sub FindPlayerFromList(strPlayerNo As String)
        ' Find a player within the AllPlayers list whose number matches and fill it in.
        Dim result As PlayerInfo = lstPlayers.Find(Function(x) x.strMembershipNo = strPlayerNo)

        If Not IsNothing(result) Then
            ' If there was a player... Then change stuff as Needed

            txtPlayerFirstName.Text = result.strPlayerFirstName
            txtPlayerLastName.Text = result.strPlayerLastName
            txtPlayerNickname.Text = result.strMembershipName
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
                lstTournPlayers(tourn.Cells("dgcListIndex").Value).intStatus = cboChangeStatus.SelectedValue

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

            txtMemberNo.Text = lstTournPlayers(intSelected).strMembershipNo
            txtPlayerFirstName.Text = lstTournPlayers(intSelected).strPlayerFirstName
            txtPlayerLastName.Text = lstTournPlayers(intSelected).strPlayerLastName
            txtPlayerNickname.Text = lstTournPlayers(intSelected).strMembershipName

            Select Case lstTournPlayers(intSelected).intByeRounds
                Case 0
                    rbByes_0.Checked = True
                Case 1
                    rbByes_1.Checked = True
            End Select

            cboStatus.SelectedValue = lstTournPlayers(intSelected).intStatus

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
            ChangePlayerDetails0ToolStripMenuItem.Text = String.Format(ChangePlayerDetails0ToolStripMenuItem.Text, lstPlayers.Find(Function(x) x.strMembershipNo = lbSearchResults.SelectedValue).strSummaryName)
        End If
    End Sub

    Private Sub DeletePlayerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeletePlayerToolStripMenuItem.Click
        If MessageBox.Show("Are you ABSOLUTELY sure that you want to delete this player from the local database?" & System.Environment.NewLine & System.Environment.NewLine & "This will not remove them from any tournaments they are registered for on Bandai TCG+ and will remove them from this current tournament.", "Delete This Player?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            Dim strMemberToDelete As String = lbSearchResults.SelectedValue

            ' We have confirmed that we are DELETING this player from the XML Database
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
            Dim intIndex As Integer = lstTournPlayers.FindIndex(Function(x) x.strMembershipNo = strMemberToDelete)

            If lstTournPlayers(intIndex).intTeamID = 0 Then

                If intIndex <> -1 Then
                    ' If it's not -1 then we find something and should delete that player on sight.

                    lstTournPlayers.RemoveAt(intIndex)

                    ' Rebuild the list 
                    BuildTournamentList()
                End If

                ' TODO: Remove penalties AND judge listing.

            End If
        End If

    End Sub

    Private Sub btnDeletePlayer_Click(sender As Object, e As EventArgs) Handles btnDeletePlayer.Click
        ' This can ONLY be done if the player does NOT have a "TeamID" loaded in from the Tournament file.
        ' If the player has a TeamID, do NOT delete the player.

        Dim lstErrors As New List(Of TournamentPlayer)

        Dim intCount As Integer = 0
        For Each row In dgvPlayers.Rows
            If row.Cells("dgcSelect").Value = 1 Then intCount += 1
        Next

        If intCount > 0 Then
            If MessageBox.Show(String.Format("You are about to delete {0} player(s) from this tournament." & Environment.NewLine & Environment.NewLine & "Are you sure you want to proceed?", intCount), "Deleting Multiple Players", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                For Each row In dgvPlayers.Rows
                    If row.Cells(1).Value = True Then
                        Dim intListIndex As Integer = row.Cells(0).Value

                        If lstTournPlayers(intListIndex).intTeamID = 0 Then
                            ' Remove the player from the list.
                            lstTournPlayers.RemoveAt(intListIndex)

                            ' Rebuild the DGV.
                            BuildTournamentList()
                        Else
                            ' Can't delete the player, make an error
                            lstErrors.Add(lstTournPlayers(intListIndex))
                        End If

                        row.Cells(1).Value = False

                    End If
                Next

                If lstErrors.Count > 0 Then
                    Dim strErrors As String = ""

                    For Each [error] In lstErrors
                        strErrors &= "•  " & [error].strSummaryName & Environment.NewLine
                    Next


                    MessageBox.Show(String.Format("Deleted {0} players from the tournament roster." & Environment.NewLine & Environment.NewLine & "But {1} player(s) could not be deleted. Either the player pre-registered or was enrolled through the TCG+ app. To remove these players from the pairings, set their status to ANYTHING but ""Participating in Tournament""." & Environment.NewLine & Environment.NewLine & "Players not removed:" & Environment.NewLine & strErrors, intCount - lstErrors.Count, lstErrors.Count), "Deleted Players", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show(String.Format("Succesfully deleted {0} players from tournament roster.", intCount), "Deleted players with no errors", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            End If
        ElseIf dgvPlayers.SelectedRows.Count = 1 Then
            Dim intLstID As Integer = dgvPlayers.SelectedRows(0).Cells(0).Value

            If lstTournPlayers(intLstID).intTeamID <> 0 Then
                MessageBox.Show("Cannot delete this player." & Environment.NewLine & Environment.NewLine & "Either the player pre-registered or was enrolled through the TCG+ app. To remove this player from the pairings, set their status to ANYTHING but ""Participating in Tournament"".", "Cannot delete pre-registered player", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                lstTournPlayers.RemoveAt(intLstID)

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

                For Each player In lstTournPlayers
                    If player.intStatus <> 9999 Then
                        csvDoc.Write("""" & player.intTeamID & """,")
                        csvDoc.Write("""" & player.strTeamName & """,")
                        csvDoc.Write("""" & 0 & """,")
                        csvDoc.Write("""" & player.intStatus & """,")
                        csvDoc.Write("""" & player.intByeRounds & """,")
                        csvDoc.Write("""" & player.strMembershipNo & """,")
                        csvDoc.Write("""" & player.strMembershipName & """,")
                        csvDoc.Write("""" & player.strSeatOrder & """,")
                        csvDoc.Write("""" & player.strMemo & """,")
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

                For Each player In lstTournPlayers
                    If player.intStatus <> 9999 Then
                        csvDoc.Write("""" & player.intTeamID & """,")
                        csvDoc.Write("""" & player.strTeamName & """,")
                        csvDoc.Write("""" & 0 & """,")
                        csvDoc.Write("""" & player.intStatus & """,")
                        csvDoc.Write("""" & player.intByeRounds & """,")
                        csvDoc.Write("""" & player.strMembershipNo & """,")
                        csvDoc.Write("""" & player.strMembershipName & """,")
                        csvDoc.Write("""" & player.strSeatOrder & """,")
                        csvDoc.Write("""" & player.strMemo & """,")
                        csvDoc.Write(Environment.NewLine)
                    End If
                Next

                csvDoc.Close()
            End Using


            ' Iterate over all members of the lstTournPlayers (except anyone with 9999 status, that's staff.) 
        End If

    End Sub

End Class
