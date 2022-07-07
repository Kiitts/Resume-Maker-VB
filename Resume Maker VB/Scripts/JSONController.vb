Imports System.IO
Imports Newtonsoft.Json
Module JSONController
    <Serializable>
    Class UserInfo
        Public FirstName As String
        Public MiddleName As String
        Public LastName As String
        Public Address As String
        Public ContactNumber As String
        Public EmailAddress As String
        Public Summary As String
        Public EducationalAttainment As List(Of Dictionary(Of String, String))
        Public EnableExperience As Boolean
        Public WorkingExperience As List(Of Dictionary(Of String, String))
    End Class

    ''' <summary>
    ''' Generate JSON file
    ''' </summary>
    ''' <param name="path">what directory should the json file be saved</param>
    Public Sub GenerateJSON(path As String)
        Dim userInfo As UserInfo = New UserInfo()
        userInfo.FirstName = Form1.inputFirstName.Text
        userInfo.MiddleName = Form1.inputMiddleName.Text
        userInfo.LastName = Form1.inputLastName.Text
        userInfo.Address = Form1.inputAddress.Text
        userInfo.ContactNumber = Form1.inputNumber.Text
        userInfo.EmailAddress = Form1.inputEmail.Text
        userInfo.Summary = Form1.inputSummary.Text
        Dim educList As List(Of Dictionary(Of String, String)) = New List(Of Dictionary(Of String, String))
        For Each row As DataGridViewRow In Form1.tableEducational.Rows
            Dim educDict As Dictionary(Of String, String) = New Dictionary(Of String, String)
            educDict.Add("School", row.Cells("inputSchool").Value.ToString())
            educDict.Add("Degree", row.Cells("inputDegree").Value.ToString())
            educDict.Add("Year Attended", row.Cells("inputYearAttended").Value.ToString())
            educList.Add(educDict)
        Next
        userInfo.EducationalAttainment = educList
        userInfo.EnableExperience = Form1.checkEnableWorkingExperience.Checked
        If userInfo.EnableExperience Then
            Dim workList As List(Of Dictionary(Of String, String)) = New List(Of Dictionary(Of String, String))
            For Each row As DataGridViewRow In Form1.tableExperience.Rows
                Dim workDict As Dictionary(Of String, String) = New Dictionary(Of String, String)
                workDict.Add("Job Position", row.Cells("inputJobPosition").Value.ToString())
                workDict.Add("Job Description", row.Cells("inputJobDescription").Value.ToString())
                workDict.Add("Company Name", row.Cells("inputCompanyName").Value.ToString())
                workDict.Add("Company Address", row.Cells("inputCompanyAddress").Value.ToString())
                workDict.Add("Working Years", row.Cells("inputJobYear").Value.ToString())
                workList.Add(workDict)
            Next
            userInfo.WorkingExperience = workList
        End If

        Dim json As String = JsonConvert.SerializeObject(userInfo, Formatting.Indented)

        File.WriteAllText(path + $"\{userInfo.FirstName}_{userInfo.LastName}.json", json)
    End Sub
End Module
