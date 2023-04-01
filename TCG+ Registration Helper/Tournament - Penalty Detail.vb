Public Class frmPenaltyDetail
    Public Property EditMode As Boolean = False

    Private Sub frmPenaltyDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Assign the Infraction Types to the field
        cboInfraction.DataSource = New BindingSource(_infraction, Nothing)
        cboInfraction.DisplayMember = "Value"
        cboInfraction.ValueMember = "Key"

        ' Assign the Penalty Types to the field
        cboPenalty.DataSource = New BindingSource(_penalty, Nothing)
        cboPenalty.DisplayMember = "Value"
        cboPenalty.ValueMember = "Key"

    End Sub

    Private Sub cboInfraction_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboInfraction.SelectedIndexChanged
        If Not EditMode Then
            cboPenalty.SelectedValue = _suggested.Item(cboInfraction.SelectedValue.Key)

            EditMode = False
        End If
    End Sub
End Class