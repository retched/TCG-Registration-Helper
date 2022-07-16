Public Class frmPenalties
    Friend lstPenalties As List(Of TournamentPenalty)
    Friend lstStaff As List(Of TournamentStaff)

    ' Have to extract list of players from this:
    Friend lstTournPlayers As List(Of PlayerInfo)

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Close this form. No need to confirm as this 
        Close()
    End Sub

    Private Sub btnAddPenalty_Click(sender As Object, e As EventArgs) Handles btnAddPenalty.Click
        Using frmPenalty As New frmPenaltyDetail

            ' Bind the List of Tournament Players to the Player DropDown
            frmPenalty.cboPlayer.DataSource = New BindingSource(lstTournPlayers, Nothing)
            frmPenalty.cboPlayer.ValueMember = "MembershipNumber"
            frmPenalty.cboPlayer.DisplayMember = "ListSummary"

            ' Bind the List of Tournament Staff to the Judge DropDown
            frmPenalty.cboJudge.DataSource = New BindingSource(lstStaff, Nothing)
            frmPenalty.cboJudge.ValueMember = "MembershipNumber"
            frmPenalty.cboJudge.DisplayMember = "ListSummary"

            If frmPenalty.ShowDialog(Me) = DialogResult.OK Then
                ' If this form was submitted, take the details and add them to lstPenalties.
                lstPenalties.Add(New TournamentPenalty() With {
                                 .JudgeNumber = frmPenalty.cboJudge.SelectedValue,
                                 .PlayerNumber = frmPenalty.cboPlayer.SelectedValue,
                                 .InfractionType = frmPenalty.cboInfraction.SelectedValue,
                                 .PenaltyType = frmPenalty.cboInfraction.SelectedValue,
                                 .RoundNumber = frmPenalty.nudRound.Value,
                                 .Notes = frmPenalty.txtPenaltyNotes.Text.Trim()})

                ' Rebuild dgvPenalty List
            End If
        End Using

    End Sub
End Class