Public Class PlayerInfo
    Public Property FirstName As String
    Public Property LastName As String
    Public Property MembershipNumber As String
    Public Property MembershipName As String
    Public Property SeatOrder As String = "A"

    Public Property SearchHelper As String
        Get
            Return LastName & ", " & FirstName & ", " & MembershipName
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property ListSummary As String
        Get
            ' Full format: GUEST99999 - SomeNickname (PlayerFirst PlayerLast)
            Return MembershipNumber & " - " & MembershipName & IIf(String.IsNullOrWhiteSpace(FirstName) Or String.IsNullOrWhiteSpace(LastName), "", " (" & LastName & ", " & FirstName & ")")
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property SummaryName As String
        Get
            Return MembershipName & IIf(String.IsNullOrWhiteSpace(FirstName) And String.IsNullOrWhiteSpace(LastName), "", " (" & LastName & ", " & FirstName & ")")
        End Get
        Set(value As String)

        End Set
    End Property

    Public Sub FormatNumber()
        If IsNumeric(MembershipNumber) Then MembershipNumber = MembershipNumber.ToString.PadLeft(10, "0")
    End Sub
End Class

Public Class TournamentPlayer
    Public Property Status As Integer = 0
    Public Property ByeRounds As Integer
    Public Property TeamID As Integer = 0
    Public Property TeamName As String
    Public Property Memo As String
End Class

Public Class TournamentTeam : Inherits TournamentPlayer
    Public PlayerA As PlayerInfo
    Public PlayerB As PlayerInfo
    Public PlayerC As PlayerInfo
End Class

Public Class TournamentStaff : Inherits PlayerInfo
    Public Property StaffPosition As Integer

    Public Property StaffListString As String
        Get
            Return ListSummary & "(" & _status.Item(StaffPosition) & ")"
        End Get
        Set(value As String)

        End Set
    End Property

End Class

Public Class TournamentPenalty
    Public PlayerNumber As String
    Public JudgeNumber As String
    Public InfractionType As Integer
    Public PenaltyType As Integer
    Public Notes As String
    Public RoundNumber As Integer
End Class

