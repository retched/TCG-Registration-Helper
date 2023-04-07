Public Class frmStaffList

    Friend lstStaff As New List(Of TournamentStaff)
    Dim lstPlayers As New List(Of PlayerInfo)
    Friend lstRoster As New List(Of TournamentTeam)
    Private Sub frmStaffList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' When this loads, load the lstTournStaff into the listbox.

        lbStaffListing.ValueMember = "MembershipNumber"
        lbStaffListing.DisplayMember = "StaffListString"
        lbStaffListing.DataSource = New BindingSource(lstStaff, Nothing)

        cboStaffPosition.ValueMember = "Key"
        cboStaffPosition.DisplayMember = "Value"
        cboStaffPosition.DataSource = New BindingSource(_position, Nothing)

        LoadPlayersListFromXML()
    End Sub

    Private Sub btnAddStaff_Click(sender As Object, e As EventArgs) Handles btnAddStaff.Click

        ' Find the staff we're updating in the list
        Dim staffInfo As TournamentStaff = lstStaff.Find(Function(x) x.MembershipNumber = lbStaffListing.SelectedValue)
        Dim playerInfo As TournamentTeam = lstRoster.Find(Function(x) x.PlayerA.MembershipNumber = cboStaffMember.SelectedValue OrElse x.PlayerB.MembershipNumber = cboStaffMember.SelectedValue OrElse x.PlayerC.MembershipNumber = cboStaffMember.SelectedValue)

        If Not IsNothing(staffInfo) Then
            ' We currently have a selected row.  Update that selected row.


            lstStaff(lstStaff.IndexOf(staffInfo)).StaffPosition = cboStaffPosition.SelectedValue

            lbStaffListing.ClearSelected()
        Else

            ' If there is a player that matches on any of the teams, send a warning.

            If Not IsNothing(playerInfo) Then
                If MessageBox.Show("You are adding a registered player as a staff member. Are you sure?", "Registered player as a judge", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                    Exit Sub
                End If

            End If

            ' Otherwise, we are adding a new staff member.
            Dim piStaffInfo As PlayerInfo = lstPlayers.Find(Function(x) x.MembershipNumber.Contains(cboStaffMember.SelectedValue))

            ' Find the PlayerInfo of the 
            lstStaff.Add(New TournamentStaff() With {
                         .MembershipNumber = cboStaffMember.SelectedValue,
                         .StaffPosition = cboStaffPosition.SelectedValue,
                         .FirstName = piStaffInfo.FirstName,
                         .LastName = piStaffInfo.LastName,
                         .MembershipName = piStaffInfo.MembershipName})
        End If

        ' Clear the search number too
        txtSearch.Clear()

        lstStaff = lstStaff.OrderBy(Function(x As TournamentStaff) x.StaffPosition).ThenBy(Function(y As TournamentStaff) y.MembershipNumber).ToList

        lbStaffListing.DataSource = New BindingSource(lstStaff, Nothing)
        lbStaffListing.ClearSelected()


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

        lstPlayers = lstPlayers.OrderBy(Function(x) x.MembershipName.ToLower).ToList

        cboStaffMember.DataSource = New BindingSource(lstPlayers, Nothing)
    End Sub

    Private Sub lbStaffListing_SelectedValueChanged(sender As Object, e As EventArgs) Handles lbStaffListing.SelectedValueChanged
        ' When this is changed, change the position and selected player to the staff as needed.

        If Not IsNothing(lbStaffListing.SelectedItem) Then
            Dim staffInfo As TournamentStaff = lstStaff.Find(Function(x) x.MembershipNumber = lbStaffListing.SelectedValue)

            ' If we found a staff member, we better have, make their details the selected forms.

            If Not IsNothing(staffInfo) Then
                cboStaffMember.SelectedValue = staffInfo.MembershipNumber
                txtSearch.Clear()

                cboStaffPosition.SelectedValue = staffInfo.StaffPosition
            End If
        Else

            If lstPlayers.Count <> 0 Then cboStaffMember.SelectedIndex = 0


        End If
    End Sub

    Private Sub txtSearch_KeyUp(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress

        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtSearch_Leave(sender As Object, e As EventArgs) Handles txtSearch.Leave
        If IsNumeric(txtSearch.Text) Then txtSearch.Text = txtSearch.Text.PadLeft("10", "0")
    End Sub

    Private Sub btnSearchbyNumber_Click(sender As Object, e As EventArgs) Handles btnSearchbyNumber.Click
        ' Search the combo for a particular number. If it's found, select. Otherwise, send a messagebox alert
        If IsNumeric(txtSearch.Text) Then txtSearch.Text = txtSearch.Text.PadLeft(10, "0")

        Dim staffInfo As PlayerInfo = lstPlayers.Find(Function(x) x.MembershipNumber = txtSearch.Text.Trim())

        If Not IsNothing(staffInfo) Then
            cboStaffMember.SelectedValue = staffInfo.MembershipNumber
            txtSearch.Clear()
        Else
            MessageBox.Show("No player/staff found with that Membership Number.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If


    End Sub

    Private Sub btnDeleteStaff_Click(sender As Object, e As EventArgs) Handles btnDeleteStaff.Click
        If Not IsNothing(lbStaffListing.SelectedValue) Then
            ' We have a row selected, delete that particular row.

            Dim staffInfo As TournamentStaff = lstStaff.Find(Function(x) x.MembershipNumber = lbStaffListing.SelectedValue)

            ' Remove the staff member at this particular index
            lstStaff.RemoveAt(lstStaff.IndexOf(staffInfo))

            ' Reload the listbox
            lbStaffListing.DataSource = New BindingSource(lstStaff, Nothing)

        End If
    End Sub

    Private Sub btnAddUnlisted_Click(sender As Object, e As EventArgs) Handles btnAddUnlisted.Click
        Using frmAddStaff As New frmPlayerDetail

            frmAddStaff.lstPlayers.AddRange(lstPlayers)

            If frmAddStaff.ShowDialog(Me) = DialogResult.OK Then
                ' If all is well, add THAT player to the staff XML
                UpdateAllPlayerXML(frmAddStaff.txtMemberNo.Text, frmAddStaff.txtPlayerNickname.Text, frmAddStaff.txtPlayerFirstName.Text, frmAddStaff.txtPlayerLastName.Text)

                ' Then Reload the XML
                LoadPlayersListFromXML()

                cboStaffMember.SelectedValue = frmAddStaff.txtMemberNo.Text
            End If
        End Using
    End Sub

    Private Sub cboStaffMember_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboStaffMember.SelectedValueChanged
        txtSearch.Clear()
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' Enter button pressed? Format the number and search
            e.Handled = True
            e.SuppressKeyPress = True
            btnSearchbyNumber.PerformClick()
        End If
    End Sub

End Class