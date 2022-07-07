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
                    MessageBox.Show("Table of Educational Attainment field is empty.", "Error")
                    Return False
                End If
            Next
        Next
        If Form1.checkEnableWorkingExperience.Checked Then
            For row = 0 To Form1.tableExperience.Rows.Count - 1
                For column = 0 To Form1.tableExperience.Columns.Count - 1
                    If Form1.tableExperience.Rows(row).Cells(column).Value Is Nothing OrElse
                        Form1.tableExperience.Rows(row).Cells(column).Value.ToString().Trim() = "" Then
                        MessageBox.Show("Table of Working Experience field is empty.", "Error")
                        Return False
                    End If
                Next
            Next
        End If
        Return True
    End Function
End Module
