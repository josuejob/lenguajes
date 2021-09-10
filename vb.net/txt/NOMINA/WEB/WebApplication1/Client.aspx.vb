Imports System.IO
Imports System.Reflection

Public Class Client
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Protected Sub btnNnaTexto_Click(sender As Object, e As EventArgs) Handles btnNnaTexto.Click

        Dim ws As New WSTimbradoTexto.wsTimbradoTexto33 'referenciaWsLocal.wsTimbradoTexto()
        Dim v As New WSTimbradoTexto.resultado33 'referenciaWsLocal.resultado()

        Dim RUTA = System.AppDomain.CurrentDomain.BaseDirectory
        'para los archivos
        'para el archivo ".KEY"
        Dim MemStream As New System.IO.MemoryStream()
        Using fs As System.IO.FileStream = File.OpenRead(RUTA + "\csd.key")
            fs.CopyTo(MemStream)
        End Using
        Dim key As [Byte]() = MemStream.ToArray()
        MemStream.Dispose()
        MemStream.Close()
        Dim MemStream2 As New System.IO.MemoryStream()
        'para el archivo ".CER"
        Using fs As System.IO.FileStream = File.OpenRead(RUTA + "\certificado.cer")
            fs.CopyTo(MemStream2)
        End Using
        Dim cer As [Byte]() = MemStream2.ToArray()
        MemStream2.Dispose()
        MemStream2.Close()
        'para el archivo ".TXT"
        'Dim MemStream3 As New System.IO.MemoryStream()
        'Using fs As System.IO.FileStream = File.OpenRead(RUTA + "\ejemploNomina.txt")
        '    fs.CopyTo(MemStream3)
        'End Using
        'Dim texto As [Byte]() = MemStream3.ToArray()
        'MemStream3.Dispose()
        'MemStream3.Close()

        Dim sr As StreamReader = New StreamReader(RUTA + "\ejemploNomina.txt")
        Dim cont As String = sr.ReadToEnd()
        sr.Close()

        v = ws.TimbrarPorTexto33("demo.sifec@gmail.com", "Acceso$01", "511110", cont)

        'Manejo de ERRORES
        'si exixten errores los mostramos
        If v.errores <> "" Then
            TextBox1.Text = (v.errores.ToString)
        Else
            'en caso de no existrir errores mostramos el UUID, escribimos el XMLTimbrado y el PDFTimbrado
            'para escribir el folio uuid
            TextBox1.Text = v.folioUUID
            'para descargar el xml timbrado
            File.WriteAllBytes(RUTA + "\PruebaXMLTimbrado.xml", v.XML)
            'bajando el pdf formato generico
            If v.PDF IsNot Nothing Then
                File.WriteAllBytes(RUTA + "\PruebaXMLPDFTimbrado.pdf", v.PDF)
            End If

            TextBox1.Text = ("Creacion exitosa")
        End If

    End Sub
End Class