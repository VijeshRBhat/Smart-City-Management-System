﻿Public Class ElectionDashboard
    Private Sub election_Click(sender As Object, e As EventArgs) Handles election.Click
        Globals.viewChildForm(childformPanel, ElectionInnerScreen1)
    End Sub

    Private Sub ElectionDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub admin_Click(sender As Object, e As EventArgs) Handles admin.Click
        Globals.viewChildForm(childformPanel, ElectionInnerScreenAdmin)
    End Sub

    Private Sub rti_Click(sender As Object, e As EventArgs) Handles rti.Click
        Globals.viewChildForm(childformPanel, ElectionInnerScreenCitizenRTI)
    End Sub
End Class