Module JSONController
    <Serializable>
    Class UserInfo
        Public Name As String
        Public Address As String
        Public ContactNumber As String
        Public EmailAddress As String
        Public Summary As String
        Public EducationalAttainment As List(Of Dictionary(Of String, String))
        Public EnableExperience As Boolean
        Public WorkingExperience As List(Of Dictionary(Of String, String))
    End Class


End Module
