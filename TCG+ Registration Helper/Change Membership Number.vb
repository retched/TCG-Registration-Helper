Public Class frmChangePlayerNumber
    Private Sub txtNewPlayerID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNewPlayerID.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNewPlayerID_Leave(sender As Object, e As EventArgs) Handles txtNewPlayerID.Leave
        If IsNumeric(txtNewPlayerID.Text.Trim) Then
            ' If the text is a numeric number (AKA, not a guest) change that number
            ' to a proper membership number

            txtNewPlayerID.Text = txtNewPlayerID.Text.ToString.PadLeft(10, "0")
        End If
    End Sub
End Class