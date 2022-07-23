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
            UpdateAllPlayerXML(txtMemberNo.Text, txtPlayerNickname.Text.Trim, txtPlayerFirstName.Text.Trim, txtPlayerLastName.Text.Trim)
        End If

    End Sub

    Private Sub ClearFields()
        txtMemberNo.Clear()
        txtPlayerFirstName.Clear()
        txtPlayerLastName.Clear()
        txtPlayerNickname.Clear()
        txtMemberNo.Focus()
    End Sub

    Private Sub UpdateAllPlayerXML(strMemberID As String, strMemberName As String, strPlayerFirstName As String, strPlayerLastName As String)
        ' Open the XML AllPlayers.xml file
        Dim xdoc As New XDocument
        xdoc = XDocument.Load(Application.StartupPath + "\AllPlayers.xml")

        Dim target As XElement = xdoc.Descendants("Player").FirstOrDefault(Function(x) x.Element("MembershipNo").Value = strMemberID)

        ' This should mean we have a NEW element.
        Dim newPlayer As XElement = New XElement("Player")
        newPlayer.Add(New XElement("FirstName", strPlayerFirstName))
        newPlayer.Add(New XElement("LastName", strPlayerLastName))
        newPlayer.Add(New XElement("MembershipNo", strMemberID))
        newPlayer.Add(New XElement("MembershipName", strMemberName))

        xdoc.Element("PlayerList").Add(newPlayer)


        xdoc.Save(Application.StartupPath + "\AllPlayers.xml")
    End Sub

    Private Sub txtMemberNo_KeyUp(sender As Object, e As KeyPressEventArgs) Handles txtMemberNo.KeyPress
        ' Number keys only.
        e.Handled = Not Char.IsDigit(e.KeyChar)
    End Sub

    Private Sub txtMemberNo_Leave(sender As Object, e As EventArgs) Handles txtMemberNo.Leave
        If IsNumeric(txtMemberNo.Text) Then txtMemberNo.Text = txtMemberNo.Text.PadLeft(10, "0")
    End Sub
End Class