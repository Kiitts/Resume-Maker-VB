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
        Dim userInfo As UserInfo = CreateUserInfo()

        Dim json As String = JsonConvert.SerializeObject(userInfo, Formatting.Indented)

        File.WriteAllText(path + $"\{userInfo.FirstName}_{userInfo.LastName}.json", json)
        MessageBox.Show("JSON is now Generated!", "Success!")
    End Sub

    ''' <summary>
    ''' Upload the JSON and generate inputs from the selected json file
    ''' </summary>
    ''' <param name="path">reference where the json saved</param>
    Public Sub UploadJSON(path As String)
        Dim json As String = File.ReadAllText(path)
        Dim userInfo As UserInfo = CreateUserInfo(json)
        If userInfo IsNot Nothing Then
            Form1.inputFirstName.Text = userInfo.FirstName
            Form1.inputMiddleName.Text = userInfo.MiddleName
            Form1.inputLastName.Text = userInfo.LastName
            Form1.inputAddress.Text = userInfo.Address
            Form1.inputNumber.Text = userInfo.ContactNumber
            Form1.inputEmail.Text = userInfo.EmailAddress
            Form1.inputSummary.Text = userInfo.Summary
            For Each educDict As Dictionary(Of String, String) In userInfo.EducationalAttainment
                Dim row As Integer = Form1.tableEducational.Rows.Add()
                Form1.tableEducational.Rows(row).Cells("inputSchool").Value = educDict("School")
                Form1.tableEducational.Rows(row).Cells("inputDegree").Value = educDict("Degree")
                Form1.tableEducational.Rows(row).Cells("inputYearAttended").Value =
                    educDict("Year Attended")
            Next
            For Each workDict As Dictionary(Of String, String) In userInfo.WorkingExperience
                Dim row As Integer = Form1.tableExperience.Rows.Add()
                Form1.tableExperience.Rows(row).Cells("inputJobPosition").Value =
                    workDict("Job Position")
                Form1.tableExperience.Rows(row).Cells("inputJobDescription").Value =
                    workDict("Job Description")
                Form1.tableExperience.Rows(row).Cells("inputCompanyName").Value =
                    workDict("Company Name")
                Form1.tableExperience.Rows(row).Cells("inputCompanyAddress").Value =
                    workDict("Company Address")
                Form1.tableExperience.Rows(row).Cells("inputJobYear").Value =
                    workDict("Working Years")
            Next
            MessageBox.Show("Inputs are now Generated!", "Success!")
        End If
    End Sub

    ''' <summary>
    ''' Create an instance of User info according to inputs
    ''' </summary>
    ''' <returns>return the filled userinfo</returns>
    Function CreateUserInfo() As UserInfo
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
        Return userInfo
    End Function

    ''' <summary>
    ''' Create user info according the json string
    ''' </summary>
    ''' <param name="json">reference of a json string</param>
    ''' <returns>return the filled userinfo</returns>
    Function CreateUserInfo(json As String) As UserInfo
        Static userInfo As UserInfo
        Try
            userInfo = JsonConvert.DeserializeObject(Of UserInfo)(json)
        Catch ex As Exception
            MessageBox.Show("Wrong JSON is used", "Error")
        End Try
        Return userInfo
    End Function
End Module
