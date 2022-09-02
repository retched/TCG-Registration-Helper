Module FileHandling
    Public Function xmlPlayerReadOut(strFileName As String) As List(Of Object)

        Dim lstFinalOutput As New List(Of Object)

        ' Load the XML Document
        Dim xDoc As XDocument = XDocument.Load(strFileName)

        ' Iterate through Players
        Dim teamNodes = xDoc.Descendants("Team")
        Dim lstOutputTeams As New List(Of TournamentTeam)

        For Each team In teamNodes

            Dim tpPlayerA As New PlayerInfo
            Dim tpPlayerB As New PlayerInfo
            Dim tpPlayerC As New PlayerInfo

            Dim playerNodes = team.Descendants("Player")

            For Each player In playerNodes
                Dim tpPlayer As PlayerInfo
                tpPlayer = New PlayerInfo With {
                    .MembershipName = player.Descendants("MemberName").Value,
                    .MembershipNumber = player.Descendants("MemberNumber").Value,
                    .FirstName = player.Descendants("PlayerFirstName").Value,
                    .LastName = player.Descendants("PlayerLastName").Value,
                    .SeatOrder = player.Descendants("SeatOrder").Value}
                tpPlayer.FormatNumber()

                Select Case tpPlayer.SeatOrder
                    Case "A"
                        tpPlayerA = tpPlayer
                    Case "B"
                        tpPlayerB = tpPlayer
                    Case "C"
                        tpPlayerC = tpPlayer
                End Select

            Next

            lstOutputTeams.Add(New TournamentTeam() With {
                                    .TeamID = team.Descendants("TeamID").Value,
                                    .TeamName = team.Descendants("TeamName").Value,
                                    .Status = team.Descendants("Status").Value,
                                    .Memo = team.Descendants("Memo").Value,
                                    .ByeRounds = team.Descendants("ByeRounds").Value,
                                    .PlayerA = tpPlayerA,
                                    .PlayerB = tpPlayerB,
                                    .PlayerC = tpPlayerC
                               })
        Next
        lstFinalOutput.Add(lstOutputTeams)

        ' Iterate through Staff
        Dim lstOutputStaff As New List(Of TournamentStaff)
        Dim staffNodes = xDoc.Descendants("Staff").Descendants("Player")

        For Each staff In staffNodes
            lstOutputStaff.Add(New TournamentStaff() With {
                               .MembershipName = staff.Descendants("MembershipName").Value,
                               .MembershipNumber = staff.Descendants("MembershipNo").Value,
                               .StaffPosition = staff.Descendants("StaffPosition").Value,
                               .FirstName = staff.Descendants("PlayerFirstName").Value,
                               .LastName = staff.Descendants("PlayerLastName").Value
                               })
        Next
        lstFinalOutput.Add(lstOutputStaff)

        ' Iterate over Penalties
        Dim lstOutputPenalties As New List(Of TournamentPenalty)
        Dim penaltyNodes = xDoc.Descendants("Penalties").Descendants("Penalty")

        For Each penalty In penaltyNodes
            lstOutputPenalties.Add(New TournamentPenalty() With {
                               .JudgeNumber = penalty.Descendants("Judge").Value,
                               .PlayerNumber = penalty.Descendants("Player").Value,
                               .InfractionType = penalty.Descendants("InfractionType").Value,
                               .PenaltyType = penalty.Descendants("PenaltyType").Value,
                               .Notes = penalty.Descendants("Notes").Value,
                               .RoundNumber = penalty.Descendants("RoundNumber").Value
                               })
        Next
        lstFinalOutput.Add(lstOutputPenalties)

        ' Return all to the program as needed.
        Return lstFinalOutput

    End Function

    Public Function csvPlayerReadOut(strFileName As String) As List(Of TournamentTeam)

        Dim lstOutputTeams As New List(Of TournamentTeam)

        Using csvDoc As New FileIO.TextFieldParser(strFileName)
            csvDoc.TextFieldType = FileIO.FieldType.Delimited
            csvDoc.Delimiters = New String() {","}
            csvDoc.HasFieldsEnclosedInQuotes = True

            Dim currentRow As String()
            Dim intPlayers As Integer
            Dim intLineCount As Integer = 0
            While Not csvDoc.EndOfData

                Try
                    currentRow = csvDoc.ReadFields()

                    ' So if there is -3 in the row, that means there are THREE PLAYERS
                    ' No -3? If there is a -2 in the first row, that means, there are TWO PLAYERS
                    ' No -2? Okay so that means there is only ONE PLAYER

                    If currentRow(0) = "Team ID" Or currentRow.Any(Function(e) e.Contains("※")) Then

                        ' Skip this line, this is either a header OR the instruction row from Bandai.
                        If intLineCount = 0 Then
                            ' TODO: When Bandai releases info about team tournaments, fix this.
                            'If currentRow.Any(Function(f) f.Contains("- 3")) Then
                            '    intPlayers = 3
                            'ElseIf currentRow.Any(Function(f) f.Contains("- 2")) Then
                            '    intPlayers = 2
                            'Else intPlayers = 1
                            'End If
                            intPlayers = 1
                        End If

                        intLineCount += 1
                        Continue While
                    ElseIf (currentRow(0) = "Ranking" Or currentRow(3) = "Opp %") And intLineCount = 0 Then
                        ' If this first row contains Ranking or Opp%, stop this is a rankings file.
                        Exit While
                    ElseIf currentRow.Count < 9 Then
                        ' Something went wrong, this isn't a valid file if it contains less than 9 columns.
                        Exit While
                        Else
                            Select Case intPlayers
                            Case 3
                                ' Trios Team
                                lstOutputTeams.Add(New TournamentTeam With {
                                                    .TeamID = currentRow(0),
                                                    .TeamName = currentRow(1),
                                                    .Status = currentRow(3),
                                                    .ByeRounds = currentRow(4),
                                                    .PlayerA = New PlayerInfo With {
                                                        .MembershipNumber = currentRow(5),
                                                        .MembershipName = currentRow(6),
                                                        .SeatOrder = currentRow(7)
                                                    },
                                                    .PlayerB = New PlayerInfo With {
                                                        .MembershipNumber = currentRow(8),
                                                        .MembershipName = currentRow(9),
                                                        .SeatOrder = currentRow(10)
                                                    },
                                                    .PlayerC = New PlayerInfo With {
                                                        .MembershipNumber = currentRow(11),
                                                        .MembershipName = currentRow(12),
                                                        .SeatOrder = currentRow(13)
                                                    },
                                                    .Memo = currentRow(14)})
                            Case 2
                                ' Duo team
                                lstOutputTeams.Add(New TournamentTeam With {
                                                    .TeamID = currentRow(0),
                                                    .TeamName = currentRow(1),
                                                    .Status = currentRow(3),
                                                    .ByeRounds = currentRow(4),
                                                    .PlayerA = New PlayerInfo With {
                                                        .MembershipNumber = currentRow(5),
                                                        .MembershipName = currentRow(6),
                                                        .SeatOrder = currentRow(7)
                                                    },
                                                    .PlayerB = New PlayerInfo With {
                                                        .MembershipNumber = currentRow(8),
                                                        .MembershipName = currentRow(9),
                                                        .SeatOrder = currentRow(10)
                                                    },
                                                    .PlayerC = New PlayerInfo,
                                                    .Memo = currentRow(11)})
                            Case 1
                                ' We have a single player. So Only PlayerA should be used.

                                lstOutputTeams.Add(New TournamentTeam With {
                                                   .TeamID = currentRow(0),
                                                   .TeamName = currentRow(1),
                                                   .Status = currentRow(3),
                                                   .ByeRounds = currentRow(4),
                                                   .PlayerA = New PlayerInfo With {
                                                        .MembershipNumber = currentRow(5),
                                                        .MembershipName = currentRow(6),
                                                        .SeatOrder = currentRow(7)
                                                    },
                                                   .PlayerB = New PlayerInfo,
                                                   .PlayerC = New PlayerInfo,
                                                   .Memo = currentRow(8)})
                        End Select
                    End If

                Catch ex As Exception
                    MsgBox("Line " & intLineCount + 1 & " is invalid.  Skipping: " & Environment.NewLine & Environment.NewLine & ex.Message)
                End Try

                intLineCount += 1
            End While

        End Using

        Return lstOutputTeams
    End Function
    Public Sub UpdateAllPlayerXML(strMemberID As String, strMemberName As String)
        ' Open the XML AllPlayers.xml file
        Dim xdoc As New XDocument
        xdoc = XDocument.Load(Application.StartupPath + "\AllPlayers.xml")

        Dim target As XElement = xdoc.Descendants("Player").FirstOrDefault(Function(x) x.Element("MembershipNo").Value = strMemberID)

        If strMemberID <> "GUEST99999" And Not String.IsNullOrWhiteSpace(strMemberID) Then
            If IsNothing(target) Then
                ' This should mean we have a NEW element.
                Dim newPlayer As XElement = New XElement("Player")
                newPlayer.Add(New XElement("MembershipNo", strMemberID))
                newPlayer.Add(New XElement("MembershipName", strMemberName))
                newPlayer.Add(New XElement("FirstName", ""))
                newPlayer.Add(New XElement("LastName", ""))

                xdoc.Element("PlayerList").Add(newPlayer)

            Else
                ' This should mean we are UPDATING an element.
                ' If the incoming name is blank but the existing name is not, DO NOT UPDATE
                target.SetElementValue("MembershipNo", strMemberID)
                target.SetElementValue("MembershipName", strMemberName)
            End If

            xdoc.Save(Application.StartupPath + "\AllPlayers.xml")
        End If

    End Sub


    Public Sub UpdateAllPlayerXML(strMemberID As String, strMemberName As String, Optional strPlayerFirstName As String = Nothing, Optional strPlayerLastName As String = Nothing)
        ' Open the XML AllPlayers.xml file
        Dim xdoc As New XDocument
        xdoc = XDocument.Load(Application.StartupPath + "\AllPlayers.xml")

        Dim target As XElement = xdoc.Descendants("Player").FirstOrDefault(Function(x) x.Element("MembershipNo").Value = strMemberID)

        If strMemberID <> "GUEST99999" And Not String.IsNullOrWhiteSpace(strMemberID) Then
            If IsNothing(target) Then
                ' This should mean we have a NEW element.
                Dim newPlayer As XElement = New XElement("Player")
                newPlayer.Add(New XElement("FirstName", strPlayerFirstName))
                newPlayer.Add(New XElement("LastName", strPlayerLastName))
                newPlayer.Add(New XElement("MembershipNo", strMemberID))
                newPlayer.Add(New XElement("MembershipName", strMemberName))

                xdoc.Element("PlayerList").Add(newPlayer)

            Else
                ' This should mean we are UPDATING an element.
                ' If the incoming name is blank but the existing name is not, DO NOT UPDATE
                target.SetElementValue("FirstName", strPlayerFirstName)
                target.SetElementValue("LastName", strPlayerLastName)

                target.SetElementValue("MembershipNo", strMemberID)
                target.SetElementValue("MembershipName", strMemberName)

            End If

            xdoc.Save(Application.StartupPath + "\AllPlayers.xml")
        End If

    End Sub
End Module
