Public Class Form1
    Private Sub checkEnableWorkingExperience_CheckedChanged(sender As Object, e As EventArgs) Handles checkEnableWorkingExperience.CheckedChanged
        If checkEnableWorkingExperience.Checked Then
            tableExperience.Enabled = True
        Else
            tableExperience.Enabled = False
        End If
    End Sub

    Private Sub buttonGenerateJSON_Click(sender As Object, e As EventArgs) Handles buttonGenerateJSON.Click
        If IsRequiredInputComplete() Then
            If jsonFolderSelect.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                GenerateJSON(jsonFolderSelect.SelectedPath)
                MessageBox.Show("JSON is now Generated!", "Success!")
            End If
        End If
    End Sub

    ' Buttons that Control Tables
    Private Sub buttonAddRowEducational_Click(sender As Object, e As EventArgs) Handles buttonAddRowEducational.Click
        tableEducational.Rows.Add()
    End Sub

    Private Sub buttonAddRowExperience_Click(sender As Object, e As EventArgs) Handles buttonAddRowExperience.Click
        If checkEnableWorkingExperience.Checked Then
            tableExperience.Rows.Add()
        End If
    End Sub

    Private Sub buttonRemoveRowEducational_Click(sender As Object, e As EventArgs) Handles buttonRemoveRowEducational.Click
        If tableEducational.Rows.Count > 0 Then
            tableEducational.Rows.RemoveAt(tableEducational.Rows.Count - 1)
        End If
    End Sub

    Private Sub buttonRemoveRowExperience_Click(sender As Object, e As EventArgs) Handles buttonRemoveRowExperience.Click
        If checkEnableWorkingExperience.Checked Then
            If tableExperience.Rows.Count > 0 Then
                tableExperience.Rows.RemoveAt(tableExperience.Rows.Count - 1)
            End If
        End If
    End Sub
End Class
