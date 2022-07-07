Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Module PDFController
    ''' <summary>
    ''' generate the resume
    ''' </summary>
    ''' <param name="path">path where to save PDF</param>
    Public Sub GeneratePDF(path As String)
        Dim userInfo As UserInfo = CreateUserInfo()
        Dim doc As Document = New Document(PageSize.LETTER, 48, 48, 48, 48)
        Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(
                                                        path + $"\{userInfo.FirstName}_{userInfo.LastName}.pdf",
                                                        FileMode.Create))
        ' Fonts
        Dim tNRoman As BaseFont = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, False)
        Dim nameFont As Font = New Font(tNRoman, 20, Font.BOLD)

        ' Texts
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

        doc.Open()
        doc.Add(nameParagraph)
        doc.Close()
    End Sub
End Module
