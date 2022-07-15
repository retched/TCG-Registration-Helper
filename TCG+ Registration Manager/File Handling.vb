Imports System.Xml

Module FileHandling
    Public Function xmlSinglePlayerReadOut(strFileName As String) As List(Of Object)

        ' Load the XML Document
        Dim xDoc As New XDocument
        xDoc = XDocument.Load(strFileName)

        Dim lstOutputPlayers As New List(Of TournamentPlayer)
        Dim lstOutputStaff As New List(Of TournamentStaff)
        Dim lstOutputPenalties As New List(Of TournamentPenalty)
        Dim lstFinalOutput As New List(Of Object)

        ' Load the players
        lstOutputPlayers = xDoc.Root.Elements("Teams").[Select](Function(st) New TournamentPlayer With {
                                                      .strMembershipNo = st.Element("MembershipNo"),
                                                      .strMembershipName = st.Element("MembershipName"),
                                                      .strPlayerFirstName = st.Element("FirstName"),
                                                      .strPlayerLastName = st.Element("LastName"),
                                                      .intByeRounds = st.Element("ByeRounds"),
                                                      .intTeamID = st.Element("TeamID"),
                                                      .intStatus = st.Element("Status")
                                                      }).ToList()

        lstFinalOutput.Add(lstOutputPlayers)


        lstOutputStaff = xDoc.Root.Elements("Staff").[Select](Function(st) New TournamentStaff With {
                                                      .strMembershipNo = st.Element("MembershipNo"),
                                                      .intPosition = st.Element("Position")
                                                      }).ToList()

        lstFinalOutput.Add(lstOutputStaff)

        lstOutputPenalties = xDoc.Root.Elements("Penalties").[Select](Function(st) New TournamentPenalty With {
                                                      .strJudgeNumber = st.Element("Judge"),
                                                      .strPlayerNumber = st.Element("Player"),
                                                      .intInfractionType = st.Element("InfractionType"),
                                                      .intPenaltyType = st.Element("PenaltyType"),
                                                      .intRoundNumber = st.Element("Round"),
                                                      .strNotes = st.Element("Notes")}).ToList()

        lstFinalOutput.Add(lstOutputPenalties)

        Return lstFinalOutput

    End Function

    Public Function csvSinglePlayerReadOut(strFileName As String) As List(Of TournamentPlayer)

        Dim lstOutputPlayers As New List(Of TournamentPlayer)

        Using csvDoc As New FileIO.TextFieldParser(strFileName)
            csvDoc.TextFieldType = FileIO.FieldType.Delimited
            csvDoc.Delimiters = New String() {","}
            csvDoc.HasFieldsEnclosedInQuotes = True

            Dim currentRow As String()

            While Not csvDoc.EndOfData

                Try
                    currentRow = csvDoc.ReadFields()

                    If currentRow(0) = "Team ID" Or currentRow.Any(Function(e) e.Contains("※")) Then
                        ' Skip this line, this is either a header OR the instruction row from Bandai.
                        Continue While
                    Else
                        lstOutputPlayers.Add(New TournamentPlayer With {
                            .intTeamID = currentRow(0),
                            .strTeamName = currentRow(1),
                            .intStatus = currentRow(3),
                            .intByeRounds = currentRow(4),
                            .strMembershipNo = currentRow(5),
                            .strMembershipName = currentRow(6),
                            .strSeatOrder = currentRow(7),
                            .strMemo = currentRow(8)
                        })
                    End If

                Catch ex As Exception
                    MsgBox("Line " & ex.Message & " is invalid.  Skipping")
                End Try

            End While

        End Using

        Return lstOutputPlayers
    End Function
End Module
