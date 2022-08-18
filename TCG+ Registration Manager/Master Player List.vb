﻿Public Class frmMasterPlayerList
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

        lstPlayers = lstPlayers.OrderBy(Function(x) x.MembershipName.ToLower).ToList

        Dim iVerScroll As Integer = dgvMasterList.FirstDisplayedScrollingRowIndex

        ' Cycle through and add each row to the datagridview.
        dgvMasterList.Rows.Clear()

        For Each player In lstPlayers
            dgvMasterList.Rows.Add(player.MembershipNumber, player.MembershipName, player.LastName, player.FirstName)
        Next

    End Sub

    Private Sub frmMasterPlayers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load the list from the XML
        LoadPlayersListFromXML()
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

                ' Since a new team was made, we should update the "Global Player List" on the form.
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
End Class