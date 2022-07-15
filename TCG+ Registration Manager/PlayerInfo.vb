Public Class PlayerInfo
    Public Property strPlayerFirstName As String
    Public Property strPlayerLastName As String
    Public Property strMembershipNo As String
    Public Property strMembershipName As String

    Public Property strSearchHelper As String
        Get
            Return strPlayerLastName & ", " & strPlayerFirstName & ", " & strMembershipName
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property strSummary As String
        Get
            ' Full format: GUEST99999 - SomeNickname (PlayerFirst PlayerLast)
            Return strMembershipNo & " - " & strMembershipName & IIf(String.IsNullOrWhiteSpace(strPlayerFirstName) Or String.IsNullOrWhiteSpace(strPlayerLastName), "", " (" & strPlayerLastName & ", " & strPlayerFirstName & ")")
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property strSummaryName As String
        Get
            Return strMembershipName & IIf(String.IsNullOrWhiteSpace(strPlayerFirstName) And String.IsNullOrWhiteSpace(strPlayerLastName), "", " (" & strPlayerLastName & ", " & strPlayerFirstName & ")")
        End Get
        Set(value As String)

        End Set
    End Property

    Public Sub FormatNumber(MemberNo As Integer)
        If IsNumeric(MemberNo) Then strMembershipNo = MemberNo.ToString.PadLeft(10, "0")
    End Sub
End Class

Public Class TournamentPlayer : Inherits PlayerInfo
    Public Property intStatus As Integer = 0
    Public Property intByeRounds As Integer
    Public Property intTeamID As Integer = 0
    Public Property strTeamName As String
    Public Property strSeatOrder As String = "A"
    Public Property strMemo As String
End Class

Public Class TournamentStaff : Inherits PlayerInfo
    Public Property intPosition As Integer

End Class

Public Class TournamentPenalty
    Public strPlayerNumber As String
    Public strJudgeNumber As String
    Public intInfractionType As Integer
    Public intPenaltyType As Integer
    Public strNotes As String
    Public intRoundNumber As Integer
End Class

Public Class Teams : Inherits TournamentPlayer
    Public tpPlayerA As TournamentPlayer
    Public tpPlayerB As TournamentPlayer
    Public tpPlayerC As TournamentPlayer
End Class