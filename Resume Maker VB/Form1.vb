Public Class Form1
    Private Sub checkEnableWorkingExperience_CheckedChanged(sender As Object, e As EventArgs) Handles checkEnableWorkingExperience.CheckedChanged
        If checkEnableWorkingExperience.Checked Then
            tableExperience.Enabled = True
        Else
            tableExperience.Enabled = False
        End If
    End Sub
End Class
