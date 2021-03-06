Module InputsController

    ''' <summary>
    ''' Will check if the required inputs are filled
    ''' </summary>
    ''' <param name="Form1">reference of form to check inputs</param>
    ''' <returns>return true if the input are complete</returns>
    Public Function IsRequiredInputComplete() As Boolean
        If Form1.inputFirstName.Text.Trim() = "" Then
            MessageBox.Show("First Name input field is empty.", "Error")
            Return False
        ElseIf Form1.inputLastName.Text.Trim() = "" Then
            MessageBox.Show("Last Name input field is empty.", "Error")
            Return False
        ElseIf Form1.inputAddress.Text.Trim() = "" Then
            MessageBox.Show("Address input field is empty.", "Error")
            Return False
        ElseIf Form1.inputNumber.Text.Trim() = "" Then
            MessageBox.Show("Contact Number input field is empty.", "Error")
            Return False
        ElseIf Form1.inputSummary.Text.Trim() = "" Then
            MessageBox.Show("Object/Summary input field is empty.", "Error")
            Return False
        End If
        For row = 0 To Form1.tableEducational.Rows.Count - 1
            For column = 0 To Form1.tableEducational.Columns.Count - 1
                If Form1.tableEducational.Rows(row).Cells(column).Value Is Nothing OrElse
                    Form1.tableEducational.Rows(row).Cells(column).Value.ToString().Trim() = "" Then
                    MessageBox.Show("Table of Educational Attainment field is incomplete.", "Error")
                    Return False
                End If
            Next
        Next
        For row = 0 To Form1.tableExperience.Rows.Count - 1
            For column = 0 To Form1.tableExperience.Columns.Count - 1
                If Form1.tableExperience.Rows(row).Cells(column).Value Is Nothing OrElse
                        Form1.tableExperience.Rows(row).Cells(column).Value.ToString().Trim() = "" Then
                    MessageBox.Show("Table of Working Experience field is incomplete.", "Error")
                    Return False
                End If
            Next
        Next
        For row = 0 To Form1.tableCertificates.Rows.Count - 1
            For column = 0 To Form1.tableCertificates.Columns.Count - 1
                If Form1.tableCertificates.Rows(row).Cells(column).Value Is Nothing OrElse
                        Form1.tableCertificates.Rows(row).Cells(column).Value.ToString().Trim() = "" Then
                    MessageBox.Show("Table of Certificates field is incomplete.", "Error")
                    Return False
                End If
            Next
        Next
        For row = 0 To Form1.tableSkills.Rows.Count - 1
            For column = 0 To Form1.tableSkills.Columns.Count - 1
                If Form1.tableSkills.Rows(row).Cells(column).Value Is Nothing OrElse
                        Form1.tableSkills.Rows(row).Cells(column).Value.ToString().Trim() = "" Then
                    MessageBox.Show("Table of Skills field is incomplete.", "Error")
                    Return False
                End If
            Next
        Next
        Return True
    End Function

    ''' <summary>
    ''' will clear all the inputted inputs
    ''' </summary>
    Public Sub ClearInputs()
        Form1.inputFirstName.Text = ""
        Form1.inputMiddleName.Text = ""
        Form1.inputLastName.Text = ""
        Form1.inputAddress.Text = ""
        Form1.inputNumber.Text = ""
        Form1.inputEmail.Text = ""
        Form1.inputSummary.Text = ""
        Form1.tableEducational.Rows.Clear()
        Form1.tableExperience.Rows.Clear()
        Form1.tableCertificates.Rows.Clear()
        Form1.tableSkills.Rows.Clear()
    End Sub
End Module
