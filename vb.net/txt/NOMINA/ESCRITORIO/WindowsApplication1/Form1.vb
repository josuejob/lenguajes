Imports System.IO
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Cursor = Cursors.WaitCursor
        Dim ws As New WSTimbradoTexto.wsTimbradoTexto33 'referenciaWsLocal.wsTimbradoTexto()
        Dim v As New WSTimbradoTexto.resultado33 'referenciaWsLocal.resultado()
        Dim ruta As String = System.AppDomain.CurrentDomain.BaseDirectory
        '''para los archivos
        Dim MemStream As New System.IO.MemoryStream()
        Using fs As System.IO.FileStream = File.OpenRead(ruta + "\csd.key")
            fs.CopyTo(MemStream)
        End Using
        Dim key As [Byte]() = MemStream.ToArray()
        MemStream.Dispose()
        MemStream.Close()
        Dim MemStream2 As New System.IO.MemoryStream()
        Using fs As System.IO.FileStream = File.OpenRead(ruta + "\certificado.cer")
            fs.CopyTo(MemStream2)
        End Using
        Dim cer As [Byte]() = MemStream2.ToArray()
        MemStream2.Dispose()
        MemStream2.Close()

        'Dim MemStream3 As New System.IO.MemoryStream()
        'Using fs As System.IO.FileStream = File.OpenRead(ruta + "\ejemploNomina.txt")
        '    fs.CopyTo(MemStream3)
        'End Using
        'Dim texto As [Byte]() = MemStream3.ToArray()
        'MemStream3.Dispose()
        'MemStream3.Close()

        Dim sr As StreamReader = New StreamReader(ruta + "\ejemploNomina.txt")
        Dim cont As String = sr.ReadToEnd()
        sr.Close()

        v = ws.TimbrarPorTexto33("demo.sifec@gmail.com", "Acceso$01", "511110", cont)
        If v.errores <> "" Then
            TextBox1.Text = (v.errores.ToString)
        Else
            'para escribir el folio uuid
            TextBox1.Text = v.folioUUID
            File.WriteAllBytes(ruta + "\PruebaXMLTimbrado.xml", v.XML)
            'bajando el pdf formato generico
            If v.PDF IsNot Nothing Then
                File.WriteAllBytes(ruta + "\PruebaXMLPDFTimbrado.pdf", v.PDF)
            End If
            TextBox1.Text = ("Creacion exitosa")
        End If

        Me.Cursor = Cursors.Default

    End Sub

End Class
