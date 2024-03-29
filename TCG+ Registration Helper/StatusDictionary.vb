﻿Module StatusDictionary
    Public _status As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String) From {
        {1, "Applied"},
        {2, "Successful"},
        {3, "Waiting list"},
        {4, "Unsuccessful"},
        {5, "Cancelled"},
        {6, "Successful + Checked In"},
        {7, "Waiting list + Checked In"},
        {8, "Absent from the event"},
        {9, "Advance Successful"},
        {10, "Participating in Tournament"},
        {11, "Dropped"}
    }

    Public _position As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String) From {
        {1, "Tournament Organizer"},
        {2, "Event Manager"},
        {3, "Scorekeeper"},
        {4, "Head Judge"},
        {5, "Assistant Head Judge"},
        {6, "Floor Judge"}
    }

    Public _infrac As New Dictionary(Of Integer, String) From {
        {1, "Failing to Observe Game Rules"},
        {2, "Forgetting to Resolve Automatic Actions"},
        {3, "Looking at Unnecessary Cards"},
        {4, "Invalid Cards in Secret Areas"},
        {5, "Referring to information outside of the Game"},
        {6, "Slow Play"},
        {7, "Deck Error: Illegible Deck List"},
        {8, "Deck Error: Incorrect number of cards in Deck / Deck List"},
        {9, "Deck Error: Incorrect cards in deck / deck list"},
        {10, "Illegal cards in deck"},
        {11, "Communication"},
        {12, "Marked Cards"},
        {13, "Insufficiently shuffling / non-randomized Deck"},
        {14, "Taunts or Inappropriate Behavior"},
        {15, "Threatening, Aggressive or Discriminating Actions"},
        {16, "Theft"},
        {17, "Collusion, payoffs and bribery"},
        {18, "Cheating"},
        {19, "Illegal or Prohibited Items"},
        {20, "Players under the influence of drugs or alcohol"}
    }

    Public _suggested As Dictionary(Of Integer, Integer) = New Dictionary(Of Integer, Integer) From {
        {1, 1},
        {2, 1},
        {3, 1},
        {4, 1},
        {5, 2},
        {6, 1},
        {7, 1},
        {8, 2},
        {9, 2},
        {10, 1},
        {11, 1},
        {12, 1},
        {13, 1},
        {14, 1},
        {15, 4},
        {16, 4},
        {17, 4},
        {18, 4},
        {19, 4},
        {20, 4}
    }
    Public _pen As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String) From {
        {0, "Caution"},
        {1, "Warning"},
        {2, "Game Loss"},
        {3, "Match Loss"},
        {4, "Disqualification"}
    }
End Module
