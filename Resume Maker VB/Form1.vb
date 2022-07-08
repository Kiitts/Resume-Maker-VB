Public Class Form1

    ' Button that control JSON
    Private Sub buttonGenerateJSON_Click_1(sender As Object, e As EventArgs) Handles buttonGenerateJSON.Click
        If IsRequiredInputComplete() Then
            If jsonFolderSelect.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                GenerateJSON(jsonFolderSelect.SelectedPath)
                ClearInputs()
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
        tableExperience.Rows.Add()
    End Sub

    Private Sub buttonRemoveRowEducational_Click(sender As Object, e As EventArgs) Handles buttonRemoveRowEducational.Click
        If tableEducational.Rows.Count > 0 Then
            tableEducational.Rows.RemoveAt(tableEducational.Rows.Count - 1)
        End If
    End Sub

    Private Sub buttonRemoveRowExperience_Click(sender As Object, e As EventArgs) Handles buttonRemoveRowExperience.Click
        If tableExperience.Rows.Count > 0 Then
            tableExperience.Rows.RemoveAt(tableExperience.Rows.Count - 1)
        End If
    End Sub

    Private Sub buttonAddRowCertificates_Click(sender As Object, e As EventArgs) Handles buttonAddRowCertificates.Click
        tableCertificates.Rows.Add()
    End Sub
    Private Sub buttonRemoveRowCertificates_Click(sender As Object, e As EventArgs) Handles buttonRemoveRowCertificates.Click
        If tableCertificates.Rows.Count > 0 Then
            tableCertificates.Rows.RemoveAt(tableCertificates.Rows.Count - 1)
        End If
    End Sub
    Private Sub buttonAddRowSkills_Click(sender As Object, e As EventArgs) Handles buttonAddRowSkills.Click
        tableSkills.Rows.Add()
    End Sub
    Private Sub buttonRemoveRowSkills_Click(sender As Object, e As EventArgs) Handles buttonRemoveRowSkills.Click
        If tableSkills.Rows.Count > 0 Then
            tableSkills.Rows.RemoveAt(tableSkills.Rows.Count - 1)
        End If
    End Sub
    ' End of Buttons that control Tables

    ' button for resume pdf
    Private Sub buttonGenerateResume_Click(sender As Object, e As EventArgs) Handles buttonGenerateResume.Click
        Dim withJson As Boolean = False
        If IsRequiredInputComplete() Then
            If jsonFolderSelect.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                If MessageBox.Show("Also save Inputs as JSON", "Save as Json",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) =
                        Windows.Forms.DialogResult.Yes Then

                    GenerateJSON(jsonFolderSelect.SelectedPath, False)
                    withJson = True
                End If
                GeneratePDF(jsonFolderSelect.SelectedPath, withJson)
                ClearInputs()
            End If
        End If
    End Sub
    Private Sub buttonReset_Click_1(sender As Object, e As EventArgs) Handles buttonReset.Click
        ClearInputs()
    End Sub
End Class
