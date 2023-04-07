Public Class frmPenaltyDetail
    Public Property EditMode As Boolean = False
    Public Property Infraction As Integer = 0
    Public Property Penalty As Integer = 0

    Private Sub frmPenaltyDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Assign the Infraction Types to the field
        cboInfraction.DataSource = New BindingSource(_infrac, Nothing)
        cboInfraction.DisplayMember = "Value"
        cboInfraction.ValueMember = "Key"

        ' Assign the Penalty Types to the field
        cboPenalty.DataSource = New BindingSource(_pen, Nothing)
        cboPenalty.DisplayMember = "Value"
        cboPenalty.ValueMember = "Key"

        If EditMode Then
            cboInfraction.SelectedValue = Infraction

            cboPenalty.SelectedValue = Penalty
        End If

    End Sub

    Private Sub cboInfraction_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboInfraction.SelectionChangeCommitted
        cboPenalty.SelectedValue = _suggested.Item(cboInfraction.SelectedValue)

    End Sub
End Class