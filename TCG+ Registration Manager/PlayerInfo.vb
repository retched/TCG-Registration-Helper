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
    Public Property PlayerFullName As String
        Get
            Dim output As String = ""

            If String.IsNullOrWhiteSpace(FirstName) Or String.IsNullOrWhiteSpace(LastName) Then
                ' Only add the non-blank name

                If Not String.IsNullOrWhiteSpace(LastName) Then
                    output &= LastName.Trim
                End If

                If Not String.IsNullOrWhiteSpace(FirstName) Then
                    output &= FirstName.Trim
                End If
            ElseIf Not String.IsNullOrWhiteSpace(FirstName) And Not String.IsNullOrWhiteSpace(LastName) Then
                output &= LastName.Trim & ", " & FirstName.Trim
            Else
                output = ""
            End If


            Return output
        End Get
        Set(value As String)

        End Set
    End Property
    Public Property SummaryName As String
        Get
            Dim output As String = ""

            output &= MembershipName

            If String.IsNullOrWhiteSpace(FirstName) Or String.IsNullOrWhiteSpace(LastName) Then
                ' Only add the non-blank name

                If Not String.IsNullOrWhiteSpace(LastName) Then
                    output &= " (" & LastName & ")"
                End If

                If Not String.IsNullOrWhiteSpace(FirstName) Then
                    output &= " (" & FirstName & ")"
                End If
            ElseIf Not String.IsNullOrWhiteSpace(FirstName) And Not String.IsNullOrWhiteSpace(LastName) Then
                output &= " (" & LastName & ", " & FirstName & ")"

            End If


            Return output
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
            Return ListSummary & " (" & _position.Item(StaffPosition) & ")"
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

