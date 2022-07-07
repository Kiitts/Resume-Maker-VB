Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Module PDFController
    Public Sub GeneratePDF()
        Dim userInfo As UserInfo = CreateUserInfo()
        Dim doc As Document = New Document(PageSize.LETTER, 5, 5, 5, 5)
        'Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream())
    End Sub
End Module
