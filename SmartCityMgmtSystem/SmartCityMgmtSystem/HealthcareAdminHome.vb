﻿Imports System.Data.SqlClient
Public Class HealthcareAdminHome



    Private Sub TransportationInnerScreen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub PictureBox6_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox6.Click
        'View the TransportAddSecys screen by default - first argument, name of the panel in the parent panel, second - name of the child form
        Globals.viewChildForm(TransportationDashboard.childformPanel, TransportAddSecys)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class