Public Class frmMasterPlayerList
    Dim lstPlayers As New List(Of PlayerInfo)

    Sub LoadPlayersListFromXML()

        Dim xdoc As New XDocument
        xdoc = XDocument.Load(Application.StartupPath + "\AllPlayers.xml")

        ' Load XML Document into a list.

        lstPlayers = xdoc.Root.Elements("Player").[Select](Function(st) New PlayerInfo With {
                                                      .MembershipName = st.Element("MembershipName"),
                                                      .FirstName = st.Element("FirstName"),
                                                      .LastName = st.Element("LastName"),
                                                      .MembershipNumber = st.Element("MembershipNo")}).ToList()

        lstPlayers = lstPlayers.OrderBy(Function(x) x.LastName.ToLower).ThenBy(Function(x) x.FirstName.ToLower).ThenBy(Function(x) x.MembershipName.ToLower).ToList

        ' Cycle through and add each row to the datagridview.
        dgvMasterList.Rows.Clear()

        For Each player In lstPlayers
            dgvMasterList.Rows.Add(player.MembershipNumber, player.MembershipName, player.FirstName, player.LastName)
        Next

    End Sub

    Private Sub frmMasterPlayers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load the list from the XML
        LoadPlayersListFromXML()

        Me.Left = (MdiParent.ClientRectangle.Width - Me.Width) / 2
        Me.Top = (MdiParent.ClientRectangle.Height - Me.Height) / 2

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Close this form
        Me.Close()
    End Sub

    Private Sub btnAddPlayer_Click(sender As Object, e As EventArgs) Handles btnAddPlayer.Click
        ' Call for a new player form.

        Using frmAddPlayer As New frmPlayerDetail

            If frmAddPlayer.ShowDialog = DialogResult.OK Then
                ' The frmAddPlayer is adding a player it to the database, so it should be okay.
                UpdateAllPlayerXML(frmAddPlayer.txtMemberNo.Text, frmAddPlayer.txtPlayerNickname.Text, frmAddPlayer.txtPlayerFirstName.Text, frmAddPlayer.txtPlayerLastName.Text)

                ' Since a new team was made, we should update the "Global Player List" on the form.
                LoadPlayersListFromXML()
                dgvMasterList.ClearSelection()
            End If

        End Using
    End Sub

    Private Sub btnEditPlayer_Click(sender As Object, e As EventArgs) Handles btnEditPlayer.Click
        Using frmEditPlayer As New frmPlayerDetail

            frmEditPlayer.txtMemberNo.Text = dgvMasterList.SelectedRows(0).Cells(0).Value
            frmEditPlayer.txtPlayerFirstName.Text = dgvMasterList.SelectedRows(0).Cells(2).Value
            frmEditPlayer.txtPlayerLastName.Text = dgvMasterList.SelectedRows(0).Cells(3).Value
            frmEditPlayer.txtPlayerNickname.Text = dgvMasterList.SelectedRows(0).Cells(1).Value


            If frmEditPlayer.ShowDialog = DialogResult.OK Then
                UpdateAllPlayerXML(frmEditPlayer.txtMemberNo.Text, frmEditPlayer.txtPlayerNickname.Text, frmEditPlayer.txtPlayerFirstName.Text, frmEditPlayer.txtPlayerLastName.Text)

                ' Since a change was made, we should update the "Global Player List" on the form.
                LoadPlayersListFromXML()
                dgvMasterList.ClearSelection()
            End If

        End Using
    End Sub

    Private Sub dgvMasterList_SelectionChanged(sender As Object, e As EventArgs) Handles dgvMasterList.SelectionChanged
        Select Case dgvMasterList.SelectedRows.Count
            Case 1
                btnEditPlayer.Enabled = True
                btnDelPlayer.Enabled = True
            Case > 1
                btnEditPlayer.Enabled = False
                btnDelPlayer.Enabled = True
            Case 0
                btnEditPlayer.Enabled = False
                btnDelPlayer.Enabled = False
        End Select
    End Sub

    Private Sub btnDelPlayer_Click(sender As Object, e As EventArgs) Handles btnDelPlayer.Click
        If MessageBox.Show("Are you sure that you want to delete the selected player(s)?" & Environment.NewLine & Environment.NewLine & "This will delete the player from the Global List but will not remove them from any tournament files or registered tournaments. Also, it will not prevent them from being readded on the opening of a new file with that player info.", "Confirm Deletion Of Players", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then

            Dim xdoc As New XDocument
            xdoc = XDocument.Load(Application.StartupPath + "\AllPlayers.xml")

            For Each row In dgvMasterList.SelectedRows
                Dim strMemberID As String = row.Cells(0).Value

                ' For Each Row that is selected, find it in the XML file by it's Membership Number and delete it.
                Dim deleteTarget As XElement = xdoc.Descendants("Player").FirstOrDefault(Function(x) x.Element("MembershipNo").Value = strMemberID)

                deleteTarget.Remove()
            Next

            xdoc.Save(Application.StartupPath + "\AllPlayers.xml")

            ' Reload the file.
            LoadPlayersListFromXML()

        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim lstSearch As List(Of PlayerInfo) = lstPlayers.FindAll(Function(x) x.SearchHelper.ToLower.Contains(txtSearchField.Text.ToLower.Trim)).ToList

        ' Erase the current contents and start over.
        dgvMasterList.Rows.Clear()

        For Each player In lstSearch
            dgvMasterList.Rows.Add(player.MembershipNumber, player.MembershipName, player.LastName, player.FirstName)
        Next

    End Sub


    Private Sub frmMasterPlayerList_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ' Reload the file.
        LoadPlayersListFromXML()
    End Sub

    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click
        LoadPlayersListFromXML()
    End Sub

    Private Sub dgvMasterList_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvMasterList.CellMouseDoubleClick
        Using frmEditPlayer As New frmPlayerDetail

            frmEditPlayer.txtMemberNo.Text = dgvMasterList.SelectedRows(0).Cells(0).Value
            frmEditPlayer.txtPlayerFirstName.Text = dgvMasterList.SelectedRows(0).Cells(2).Value
            frmEditPlayer.txtPlayerLastName.Text = dgvMasterList.SelectedRows(0).Cells(3).Value
            frmEditPlayer.txtPlayerNickname.Text = dgvMasterList.SelectedRows(0).Cells(1).Value


            If frmEditPlayer.ShowDialog = DialogResult.OK Then
                UpdateAllPlayerXML(frmEditPlayer.txtMemberNo.Text, frmEditPlayer.txtPlayerNickname.Text, frmEditPlayer.txtPlayerFirstName.Text, frmEditPlayer.txtPlayerLastName.Text)

                ' Since a change was made, we should update the "Global Player List" on the form.
                LoadPlayersListFromXML()

                dgvMasterList.ClearSelection()
            End If

        End Using
    End Sub

    Private Sub btnClearPlayerNames_Click(sender As Object, e As EventArgs) Handles btnClearPlayerNames.Click
        If MessageBox.Show("This option will allow you to completely remove all stored First and Last Names from the AllPlayers.xml. (It will keep the Player Nickname.)" & Environment.NewLine & Environment.NewLine & "This option is NOT REVERSIBLE. PROCEED WITH CAUTION!!!", "Delete all player names from AllPlayers.XML?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Dim xdoc As New XDocument
            xdoc = XDocument.Load(Application.StartupPath + "\AllPlayers.xml")

            ' Don't delete the child nodes, set it.
            xdoc.Descendants("FirstName").Value = ""
            xdoc.Descendants("LastName").Value = ""

            xdoc.Save(Application.StartupPath + "\AllPlayers.xml")

            ' Reload the file.
            LoadPlayersListFromXML()
        End If
    End Sub
End Class