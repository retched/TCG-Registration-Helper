Module StatusDictionary
    Public _status As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String) From {
        {1, "Applied"},
        {2, "Successful"},
        {3, "Waiting list"},
        {4, "Unsuccessful"},
        {5, "Cancelled"},
        {6, "Selected + Checked In"},
        {7, "Waiting for Cancellation + Checked In"},
        {8, "Absent on Day of Event"},
        {9, "Advance Elected"},
        {10, "Participating in Tournament"},
        {11, "Dropped"}
    }
End Module
