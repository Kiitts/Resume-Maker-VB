Public Class Form1
    Private Sub checkEnableWorkingExperience_CheckedChanged(sender As Object, e As EventArgs) Handles checkEnableWorkingExperience.CheckedChanged
        If checkEnableWorkingExperience.Checked Then
            tableExperience.Enabled = True
        Else
            tableExperience.Enabled = False
        End If
    End Sub

    ' Button that control JSON
    Private Sub buttonGenerateJSON_Click(sender As Object, e As EventArgs) Handles buttonGenerateJSON.Click
        If IsRequiredInputComplete() Then
            jsonFolderSelect.Description = "Select Folder for JSON"
            If jsonFolderSelect.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                GenerateJSON(jsonFolderSelect.SelectedPath)
            End If
        End If
    End Sub
    Private Sub buttonUploadJSON_Click(sender As Object, e As EventArgs) Handles buttonUploadJSON.Click
        jsonFileSelect.Filter = "JSON Files (*.json)|*.json"
        If jsonFileSelect.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            UploadJSON(jsonFileSelect.FileName)
        End If
    End Sub
    ' End of Button that control JSON

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

    Private Sub buttonGenerateResume_Click(sender As Object, e As EventArgs) Handles buttonGenerateResume.Click
        If IsRequiredInputComplete() Then
            jsonFolderSelect.Description = "Select Folder for JSON"
            If MessageBox.Show("Also save Inputs as JSON", "Save as Json",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) =
                        Windows.Forms.DialogResult.Yes Then
                If jsonFolderSelect.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    GenerateJSON(jsonFolderSelect.SelectedPath)
                End If
            End If
            jsonFolderSelect.Description = "Select Folder for Resume PDF"
            If jsonFolderSelect.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                GenerateJSON(jsonFolderSelect.SelectedPath)
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        jsonFolderSelect.UseDescriptionForTitle = True
    End Sub
End Class
