Module InputsController
    Public Sub CheckInputs()
        If Form1.inputName.Text.Trim() = "" Then
            MessageBox.Show("Error", "Name input field is empty.")
            Exit Sub
        ElseIf Form1.inputAddress.Text.Trim() = "" Then
            MessageBox.Show("Error", "Address input field is empty.")
            Exit Sub
        ElseIf Form1.inputNumber.Text.Trim() = "" Then
            MessageBox.Show("Error", "Contact Number input field is empty.")
            Exit Sub
        ElseIf Form1.inputSummary.Text.Trim() = "" Then
            MessageBox.Show("Error", "Object/Summary input field is empty.")
            Exit Sub
        End If
    End Sub

    Public Sub Test()
        For row = 0 To Form1.tableEducational.Rows.Count - 1
            For column = 0 To Form1.tableEducational.Columns.Count - 1
                MessageBox.Show(Form1.tableEducational.Rows(row).Cells(column).Value)
            Next
        Next
    End Sub
End Module
