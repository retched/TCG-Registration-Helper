Public Class frmPlayerDetail
    Friend lstPlayers As New List(Of PlayerInfo)

    Private Sub btnAddPlayer_Click(sender As Object, e As EventArgs) Handles btnAddPlayer.Click
        Dim searchResult = lstPlayers.Find(Function(x) x.MembershipNumber = txtMemberNo.Text.Trim())

        ' If there is a result from the search, STOP. Alert the user. Clear the fields.
        If String.IsNullOrWhiteSpace(txtMemberNo.Text) Or String.IsNullOrWhiteSpace(txtPlayerNickname.Text) Then
            MessageBox.Show("You must enter at least a player number and a nickname for the player.", "Invalid Player Info Entered", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            DialogResult = DialogResult.None
        ElseIf Not IsNothing(searchResult) Then
            MessageBox.Show("A player with this Membership Number already exists." & Environment.NewLine & Environment.NewLine & "Double check the number and try again.", "Duplicate Player Number", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DialogResult = DialogResult.None
            ClearFields()
        Else
            ' Everything works? Add this info to the XML
            DialogResult = DialogResult.OK
        End If

    End Sub

    Private Sub ClearFields()
        txtMemberNo.Clear()
        txtPlayerFirstName.Clear()
        txtPlayerLastName.Clear()
        txtPlayerNickname.Clear()
        txtMemberNo.Focus()
    End Sub
    Private Sub txtMemberNo_KeyUp(sender As Object, e As KeyPressEventArgs) Handles txtMemberNo.KeyPress
        ' Number keys only.
        e.Handled = Not Char.IsDigit(e.KeyChar)
    End Sub

    Private Sub txtMemberNo_Leave(sender As Object, e As EventArgs) Handles txtMemberNo.Leave
        If IsNumeric(txtMemberNo.Text) Then txtMemberNo.Text = txtMemberNo.Text.PadLeft(10, "0")
    End Sub
End Class