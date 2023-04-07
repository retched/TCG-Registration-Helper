Public Class frmPenalties
    Friend lstPenalties As New List(Of TournamentPenalty)
    Friend lstStaff As New List(Of TournamentStaff)

    ' Have to extract list of players from this:
    Friend lstTournPlayers As New List(Of PlayerInfo)

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Close this form. No need to confirm as this 
        Close()
    End Sub

    Private Sub btnAddPenalty_Click(sender As Object, e As EventArgs) Handles btnAddPenalty.Click
        ' If there is no staff or no players, DON'T open the form.

        Using frmPenalty As New frmPenaltyDetail

            ' Bind the List of Tournament Players to the Player DropDown
            frmPenalty.cboPlayer.DataSource = New BindingSource(lstTournPlayers, Nothing)
            frmPenalty.cboPlayer.ValueMember = "MembershipNumber"
            frmPenalty.cboPlayer.DisplayMember = "ListSummary"

            ' Bind the List of Tournament Staff to the Judge DropDown
            frmPenalty.cboJudge.DataSource = New BindingSource(lstStaff, Nothing)
            frmPenalty.cboJudge.ValueMember = "MembershipNumber"
            frmPenalty.cboJudge.DisplayMember = "ListSummary"

            If lstTournPlayers.Count = 0 Or lstStaff.Count = 0 Then
                MessageBox.Show("There are no players or staff registered in this tournament. Please add them as necessary.", "No Participants", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If frmPenalty.ShowDialog(Me) = DialogResult.OK Then
                    ' If this form was submitted, take the details and add them to lstPenalties.
                    lstPenalties.Add(New TournamentPenalty() With {
                                 .JudgeNumber = frmPenalty.cboJudge.SelectedValue,
                                 .PlayerNumber = frmPenalty.cboPlayer.SelectedValue,
                                 .InfractionType = frmPenalty.cboInfraction.SelectedValue,
                                 .PenaltyType = frmPenalty.cboPenalty.SelectedValue,
                                 .RoundNumber = frmPenalty.nudRound.Value,
                                 .Notes = frmPenalty.txtPenaltyNotes.Text.Trim()})

                    ' Rebuild dgvPenalty List
                    FillPenaltyList()
                End If


            End If

        End Using

    End Sub

    Private Sub frmPenalties_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillPenaltyList()

    End Sub
    Private Sub FillPenaltyList()

        dgvPenalties.Rows.Clear()

        For Each penalty In lstPenalties

            Dim playerInfo As PlayerInfo = lstTournPlayers.Find(Function(x) x.MembershipNumber = penalty.PlayerNumber)
            Dim staffInfo As TournamentStaff = lstStaff.Find(Function(x) x.MembershipNumber = penalty.JudgeNumber)
            ' For every penalty add in a new row.
            dgvPenalties.Rows.Add(lstPenalties.IndexOf(penalty), playerInfo.SummaryName, _infrac.Item(penalty.InfractionType), _pen.Item(penalty.PenaltyType), penalty.RoundNumber, staffInfo.SummaryName, penalty.Notes)
        Next

        dgvPenalties.ClearSelection()
    End Sub

    Private Sub btnEditPenalty_Click(sender As Object, e As EventArgs) Handles btnEditPenalty.Click

        Using frmEditPenalty As New frmPenaltyDetail

            frmEditPenalty.EditMode = True

            Dim selectedPenalty As TournamentPenalty = lstPenalties(dgvPenalties.SelectedRows(0).Cells(0).Value)

            frmEditPenalty.cboPlayer.DataSource = New BindingSource(lstTournPlayers, Nothing)
            frmEditPenalty.cboPlayer.ValueMember = "MembershipNumber"
            frmEditPenalty.cboPlayer.DisplayMember = "ListSummary"

            ' Bind the List of Tournament Staff to the Judge DropDown
            frmEditPenalty.cboJudge.DataSource = New BindingSource(lstStaff, Nothing)
            frmEditPenalty.cboJudge.ValueMember = "MembershipNumber"
            frmEditPenalty.cboJudge.DisplayMember = "ListSummary"

            ' Set the form up to the details of the penalty
            frmEditPenalty.cboPlayer.SelectedValue = selectedPenalty.PlayerNumber
            frmEditPenalty.cboJudge.SelectedValue = selectedPenalty.JudgeNumber

            frmEditPenalty.nudRound.Value = selectedPenalty.RoundNumber

            frmEditPenalty.Infraction = selectedPenalty.InfractionType
            frmEditPenalty.Penalty = selectedPenalty.PenaltyType

            frmEditPenalty.txtPenaltyNotes.Text = selectedPenalty.Notes

            If frmEditPenalty.ShowDialog(Me) = DialogResult.OK Then
                ' We are for sure, editing a penalty detail.

                lstPenalties(lstPenalties.IndexOf(selectedPenalty)) = New TournamentPenalty With {
                    .InfractionType = frmEditPenalty.cboInfraction.SelectedValue,
                    .PenaltyType = frmEditPenalty.cboPenalty.SelectedValue,
                    .JudgeNumber = frmEditPenalty.cboJudge.SelectedValue,
                    .PlayerNumber = frmEditPenalty.cboPlayer.SelectedValue,
                    .RoundNumber = frmEditPenalty.nudRound.Value,
                    .Notes = frmEditPenalty.txtPenaltyNotes.Text.Trim()}

                FillPenaltyList()
            End If

        End Using
    End Sub

    Private Sub dgvPenalties_SelectionChanged(sender As Object, e As EventArgs) Handles dgvPenalties.SelectionChanged

        btnEditPenalty.Enabled = dgvPenalties.SelectedRows.Count
        btnDeletePenalty.Enabled = dgvPenalties.SelectedRows.Count

    End Sub

    Private Sub btnDeletePenalty_Click(sender As Object, e As EventArgs) Handles btnDeletePenalty.Click
        ' Delete the highlighted penalty from the list of penalties.
        lstPenalties.RemoveAt(dgvPenalties.SelectedRows(0).Cells(0).Value)

        ' Refill the tournament list
        FillPenaltyList()

    End Sub
End Class