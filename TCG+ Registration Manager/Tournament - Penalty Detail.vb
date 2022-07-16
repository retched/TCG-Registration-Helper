Public Class frmPenaltyDetail
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
End Class