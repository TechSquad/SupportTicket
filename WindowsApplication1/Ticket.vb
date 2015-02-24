Public Class Ticket
    Private _Issue As String
    Private _Reporter As String
    Private _dateReported As Date
    Private _severity As Integer

    Public Property Issue() As String
        Get
            Return _Issue
        End Get

        Set(value As String)
            _Issue = value
        End Set
    End Property

    Public Property Reporter() As String
        Get
            Return _Reporter
        End Get

        Set(value As String)
            _Reporter = value
        End Set
    End Property

    Public Property DateReported() As Date
        Get
            Return _dateReported
        End Get

        Set(value As Date)
            _dateReported = value
        End Set
    End Property

    Public Property Severity() As Integer
        Get
            Return _severity
        End Get

        Set(value As Integer)
            _severity = value
        End Set
    End Property

End Class
