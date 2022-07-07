Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Module PDFController
    ''' <summary>
    ''' generate the resume
    ''' </summary>
    ''' <param name="path">path where to save PDF</param>
    Public Sub GeneratePDF(path As String, withJson As Boolean)
        Dim userInfo As UserInfo = CreateUserInfo()
        Dim doc As Document = New Document(PageSize.LETTER, 48, 48, 48, 48)
        Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(
                                                        path + $"\{userInfo.FirstName}_{userInfo.LastName}.pdf",
                                                        FileMode.Create))
        ' Fonts
        Dim tNRoman As BaseFont = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, False)
        Dim nameFont As New Font(tNRoman, 20, Font.BOLD)
        Dim subHeader As New Font(tNRoman, 12, Font.BOLD)
        Dim normalFont As New Font(tNRoman, 11)
        Dim tableHeader As New Font(tNRoman, 11, Font.BOLD)

        ' Texts
        ' Name
        Dim nameParagraph As Paragraph
        If userInfo.MiddleName.Trim() IsNot "" Then
            nameParagraph = New Paragraph(
                $"{userInfo.FirstName} {userInfo.MiddleName} {userInfo.LastName}",
                nameFont)
        Else
            nameParagraph = New Paragraph(
                $"{userInfo.FirstName} {userInfo.LastName}",
                nameFont)
        End If
        nameParagraph.Alignment = Element.ALIGN_CENTER
        ' Contact Details
        Dim contactParagraph As New Paragraph($"{userInfo.Address}" + vbCrLf +
                                              $"{userInfo.ContactNumber}" + vbCrLf +
                                              $"{userInfo.EmailAddress}", normalFont)
        contactParagraph.Alignment = Element.ALIGN_CENTER
        ' Educational Attainment
        Dim educTable As New PdfPTable(3)
        If userInfo.EducationalAttainment.Count > 0 Then
            educTable.WidthPercentage = 100
            educTable.AddCell(New Paragraph("School", tableHeader))
            educTable.AddCell(New Paragraph("Degree", tableHeader))
            educTable.AddCell(New Paragraph("Year Attended", tableHeader))
            For Each educDict As Dictionary(Of String, String) In userInfo.EducationalAttainment
                educTable.AddCell(New Paragraph(educDict("School"), normalFont))
                educTable.AddCell(New Paragraph(educDict("Degree"), normalFont))
                educTable.AddCell(New Paragraph(educDict("Year Attended"), normalFont))
            Next
        End If
        ' Working Experience
        Dim worktable As New PdfPTable(5)
        If userInfo.WorkingExperience.Count > 0 Then
            worktable.WidthPercentage = 100
            worktable.AddCell(New Paragraph("Job Position", tableHeader))
            worktable.AddCell(New Paragraph("Job Description", tableHeader))
            worktable.AddCell(New Paragraph("Company Name", tableHeader))
            worktable.AddCell(New Paragraph("Company Address", tableHeader))
            worktable.AddCell(New Paragraph("Working Years", tableHeader))
            For Each workDict As Dictionary(Of String, String) In userInfo.WorkingExperience
                worktable.AddCell(New Paragraph(workDict("Job Position"), normalFont))
                worktable.AddCell(New Paragraph(workDict("Job Description"), normalFont))
                worktable.AddCell(New Paragraph(workDict("Company Name"), normalFont))
                worktable.AddCell(New Paragraph(workDict("Company Address"), normalFont))
                worktable.AddCell(New Paragraph(workDict("Working Years"), normalFont))
            Next
        End If
        ' Certificates Table
        Dim certTable As New PdfPTable(2)
        If userInfo.Certificates.Count > 0 Then
            certTable.WidthPercentage = 100
            certTable.AddCell(New Paragraph("Title", tableHeader))
            certTable.AddCell(New Paragraph("Issued", tableHeader))
            For Each certDict As Dictionary(Of String, String) In userInfo.Certificates
                certTable.AddCell(New Paragraph(certDict("Title"), normalFont))
                certTable.AddCell(New Paragraph(certDict("Issued"), normalFont))
            Next
        End If

        ' Creating resume PDF
        doc.Open()
        doc.Add(nameParagraph)
        doc.Add(contactParagraph)
        doc.Add(New Paragraph(vbCrLf))
        doc.Add(New draw.LineSeparator(1.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_CENTER, 1))
        doc.Add(New Paragraph("Objectives:", subHeader))
        doc.Add(New Paragraph(userInfo.Summary, normalFont))
        If userInfo.EducationalAttainment.Count > 0 Then
            doc.Add(New Paragraph(vbCrLf))
            doc.Add(New Paragraph("Educational Attainment:", subHeader))
            doc.Add(New Paragraph(vbCrLf))
            doc.Add(educTable)
        End If
        If userInfo.WorkingExperience.Count > 0 Then
            doc.Add(New Paragraph(vbCrLf))
            doc.Add(New Paragraph("Working Experience:", subHeader))
            doc.Add(New Paragraph(vbCrLf))
            doc.Add(worktable)
        End If
        If userInfo.Certificates.Count > 0 Then
            doc.Add(New Paragraph(vbCrLf))
            doc.Add(New Paragraph("Certificates:", subHeader))
            doc.Add(New Paragraph(vbCrLf))
            doc.Add(certTable)
        End If
        doc.Close()
        If withJson Then
            MessageBox.Show("Resume PDF and JSON successfully generated!", "Success")
        Else
            MessageBox.Show("Resume PDF successfully generated!", "Success")
        End If
    End Sub
End Module
