Public Class frmTicketManager

    Private TicketQueue As New TicketQueue

    Private ResolvedTicketList As New TicketQueue




    Private Sub btnAddTicket_Click(sender As Object, e As EventArgs) Handles btnAddTicket.Click

        Dim newTicket As New Ticket
        newTicket.Issue = txtTicketIssue.Text
        newTicket.Reporter = txtTicketReporter.Text
        newTicket.DateReported = Date.Now()
        newTicket.Severity = CInt(numTicketSeverity.Value)

        TicketQueue.Add(newTicket)

        lstTicketList.Items.Add(newTicket)

        refreshTicketList()
        clearFields()
    End Sub

    Public Sub refreshTicketList()
        lstTicketList.Items.Clear()

        For Each t As Ticket In TicketQueue
            lstTicketList.Items.Add(t)
        Next
    End Sub

    Public Sub clearFields()
        txtTicketReporter.Clear()
        txtTicketIssue.Clear()
        numTicketSeverity.Value = 1

    End Sub

    Private Sub btnDeleteTicket_Click(sender As Object, e As EventArgs) Handles btnDeleteTicket.Click

        'If nothing selected, then don't delete anything
        If lstTicketList.SelectedIndex = -1 Then
            MessageBox.Show("You must select a ticket to resolve")
        Else
            'Open dialog box for user to enter resolution info
            'Use the Tag property to send the Ticket we want to resolve to the DialogBox
            ResolveTicket.Tag = lstTicketList.SelectedItem

            If ResolveTicket.ShowDialog = DialogResult.OK Then

                TicketQueue.Remove(CType(lstTicketList.SelectedItem, Ticket))
                refreshTicketList()
                ResolvedTicketList.add(CType(ResolveTicket.Tag, Ticket))

            End If
        End If
    End Sub



End Class
