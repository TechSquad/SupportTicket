Public Class frmTicketManager

    Private TicketQueue As New ArrayList




    Private Sub btnAddTicket_Click(sender As Object, e As EventArgs) Handles btnAddTicket.Click

        Dim newTicket As New Ticket
        newTicket.Issue = txtTicketIssue.Text
        newTicket.Reporter = txtTicketReporter.Text
        newTicket.DateReported = Date.Now()
        newTicket.Severity = CInt(numTicketSeverity.Value)

        TicketQueue.Add(newTicket)

        lstTicketList.Items.Add(newTicket)
    End Sub
End Class
