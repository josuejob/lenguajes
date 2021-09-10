Imports System.IO
Imports System.Text.RegularExpressions

Public Class Form1
    '    Private Sub Button1_Click(sender As Object, e As EventArgs)
    '        Dim Errorr$
    '        lbtxtaxml.Text = ""
    '        Errorr = ""

    '        Dim wstex As New wsTimbradoTexto33.wsTimbradoTexto33
    '        Dim vtext As New wsTimbradoTexto33.resultado33
    '        'al abrirse openfileDialog se debe de ingresar el archivo de txt
    '        Dim rutamiFacturatxt$ = ""
    '        rutamiFacturatxt = DameRuta()
    '        If rutamiFacturatxt <> "" Then
    '            Try
    '                If Path.GetExtension(rutamiFacturatxt) <> ".txt" Then
    '                    Errorr = "No se selecciono ningun archivo o la extencion no es 'txt'"
    '                    GoTo Line1
    '                End If
    '                'inicializamos la ruta del xml que se guardara donde esta nuestro txt
    '                Dim rutaGuardaXML As String = (Path.GetDirectoryName(rutamiFacturatxt) & "\miXML.xml")
    '                'copiamos a un string nuestro archivo
    '                Dim Texto As String = File.ReadAllText(rutamiFacturatxt, System.Text.Encoding.Default)
    '                'vtext = wstex.TextoAXml("correo@diminio", "ContraseñaDeMicuenta", "miRFC", Texto)
    '                Dim correo, contraseniaCuenta, RFC As String
    '                correo = InputBox("Introduzca correo:", "Correo", "demo.sifec@gmail.com", 100, 100)
    '                If Not validaREGEX(correo, "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$") Then
    '                    Errorr = "Correo invalido"
    '                    GoTo Line1
    '                End If
    '                contraseniaCuenta = InputBox("introduzca Contraseña de la cuenta:", "Contraseña CUENTA", "Acceso$01", 100, 100)
    '                If contraseniaCuenta.Length = 0 Then
    '                    Errorr = "No introdujo contraseña"
    '                    GoTo Line1
    '                End If
    '                RFC = InputBox("introduzca RFC:", "RFC", "LAN7008173R5", 100, 100)

    '                If Not validaREGEX(RFC, "^([A-Z\s]{4})\d{6}([A-Z\w]{0,3})$") Then
    '                    If RFC <> "LAN7008173R5" Then
    '                        Errorr = "RFC invalido"
    '                        GoTo Line1
    '                    End If
    '                End If

    '                'para que el cliente acepte el certificado de sitio https donde esta el webservice
    '                System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf ValidarCertificado)
    '                vtext = wstex.TextoAXml(correo.Trim, RFC.Trim, Texto)
    '                If vtext.errores <> "" Then
    '                    lbtxtaxml.Text = vtext.errores
    '                Else
    '                    'escribimos los bytes en bustro xml
    '                    File.WriteAllBytes(rutaGuardaXML, vtext.XML)
    '                    lbtxtaxml.Text = rutaGuardaXML
    '                End If

    '            Catch ex As Exception
    '                MessageBox.Show(ex.ToString)
    '            End Try
    '        Else
    'Line1:
    '            MessageBox.Show(Errorr)
    '        End If

    '    End Sub

    Private Function ValidarCertificado(ByVal sender As Object, ByVal certificate As System.Security.Cryptography.X509Certificates.X509Certificate, ByVal chain As System.Security.Cryptography.X509Certificates.X509Chain, ByVal sslPolicyErrors As System.Net.Security.SslPolicyErrors) As Boolean
        Return True
    End Function

    Function validaREGEX(ByVal plbra$, ByVal exprecion$) As Integer
        'funcion para validar por expresion regular
        'ERRORES: false para indicar que hay un error y true para decir que no hay error 
        Dim validar As Boolean
        'si no es valida
        If (Not Regex.IsMatch(plbra, exprecion)) Then
            validar = False
        Else
            'si es valida
            validar = True
        End If
        Return validar
    End Function

    '    Private Sub llamarWebservice_Click(sender As Object, e As EventArgs)
    '        'sellar
    '        lbsello.Text = ""
    '        Try
    '            'Declarando el WEbSErvice
    '            Dim ws As New wsTimbrado33.wsTimbrado33
    '            Dim v As New wsTimbrado33.resultado33
    '            'declaramos las rutas de nuestro ordenador para nuetro archivo Key,Cer,Xml
    '            'Dim rutamiKey$ = "C:\Ruta_de_mi_archivo_KEY\miArchivoKEY.key"
    '            'Dim rutamiCer$ = "C:\Ruta_de_mi_archivo_cer\miarchivoCER.cer"
    '            'Dim rutaMiXML$ = ("C:\Ruta_donde_esta_mi_xml\miXML.xml")
    '            Dim rutamiKey$ = ""
    '            Dim rutamiCer$ = ""
    '            Dim rutamiXML$ = ""
    '            MessageBox.Show("Abrir archivo .CER")
    '            rutamiCer = DameRuta()
    '            If Path.GetExtension(rutamiCer) <> ".cer" Then
    '                MessageBox.Show("No se selecciono archivo o la extencion no es CER")
    '                GoTo line1
    '            End If
    '            MessageBox.Show("Abrir archivo .KEY")
    '            rutamiKey = DameRuta()
    '            If Path.GetExtension(rutamiKey) <> ".key" Then
    '                MessageBox.Show("No se selecciono archivo o la extencion no es KEY")
    '                GoTo line1
    '            End If
    '            MessageBox.Show("Abrir XML")
    '            rutamiXML = DameRuta()
    '            If Path.GetExtension(rutamiXML) <> ".xml" Then
    '                MessageBox.Show("No se selecciono archivo o la extencion no es XML")
    '                GoTo line1
    '            End If

    '            Dim correo, contraseniaCuenta, contraseniaCer As String
    '            correo = InputBox("introduzca correo:", "Correo", "demo.sifec@gmail.com", 100, 100)
    '            contraseniaCuenta = InputBox("introduzca Contraseña de la cuenta:", "Contraseña CUENTA", "Acceso$01", 100, 100)
    '            contraseniaCer = InputBox("introduzca Contraseña Certificado:", "Contraseña CERTIFICADO", "12345678a", 100, 100)
    '            'delcaramos la ruta del xmlsellado donde lo guardaremos en nuestro ordenador
    '            Dim rutaDestinoXml$ = Path.GetDirectoryName(rutamiXML) & "\xmlSellado.xml"

    '            Dim MemStream As New System.IO.MemoryStream()
    '            Using fs As System.IO.FileStream = File.OpenRead(rutamiKey)
    '                fs.CopyTo(MemStream)
    '            End Using
    '            Dim key As [Byte]() = MemStream.ToArray()
    '            MemStream.Dispose()
    '            MemStream.Close()
    '            Dim MemStream2 As New System.IO.MemoryStream()
    '            Using fs As System.IO.FileStream = File.OpenRead(rutamiCer)
    '                fs.CopyTo(MemStream2)
    '            End Using
    '            Dim cer As [Byte]() = MemStream2.ToArray()
    '            MemStream2.Dispose()
    '            MemStream2.Close()

    '            Dim MemStream3 As New System.IO.MemoryStream()
    '            Using fs As System.IO.FileStream = File.OpenRead(rutamiXML)
    '                fs.CopyTo(MemStream3)
    '            End Using
    '            Dim xml As [Byte]() = MemStream3.ToArray()
    '            MemStream3.Dispose()
    '            MemStream3.Close()

    '            'sellar("correo@diminio", "ContraseñaDeMicuenta", key, "contraseña demi certificado", cer, xml)
    '            System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf ValidarCertificado)
    '            v = ws.sellar(correo.Trim, contraseniaCuenta.Trim, key, contraseniaCer.Trim, cer, xml)
    '            If v.errores <> "" Then
    '                lbsello.Text = v.errores
    '            Else
    '                lbsello.Text = v.sello
    '                If File.Exists(rutaDestinoXml) Then
    '                    File.Delete(rutaDestinoXml)
    '                End If
    '                File.WriteAllBytes(rutaDestinoXml, v.xmlSellado)
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("ocurrio un error: " + ex.Message.ToString())
    '        End Try
    'line1:
    '    End Sub
    'timbrado y pdf
    Private Sub timbrar_Click(sender As Object, e As EventArgs) Handles Timbrar.Click
        uuid2.Text = ""

        Try
            'si el cfdi está fuera de las ultimas 72 hrs debe primero modificarse la fecha de emisión a este rango
            ''actualizar las referencias web antes de ejecutarlas, dandole boton derecho->actualizar ref web
            Dim ws As New PruebasWsTimbradoTexto33.wsTimbradoTexto33
            Dim v As New PruebasWsTimbradoTexto33.resultado33

            'declaramos la rutadonde esta nuietro xml sellado
            'Dim rutaxml$ = "C:\Ruta_de_donde_tomaremos_nuestro_xml\xmlSellado.xml"
            Dim rutaxml$ = ""
            MessageBox.Show("Abrir el archivo txt")
            rutaxml = DameRuta()
            If Path.GetExtension(rutaxml) <> ".txt" Then
                MessageBox.Show("No se selecciono archivo txt o la extencion no es correcta")
            Else
                'delcararmos las rutas donde bajaremos nuestro xml timbrado y  nuestro pdf del xml timbrado
                Dim rutaDestinoXmltim$ = Path.GetDirectoryName(rutaxml) & "\xmlTimbrado.xml"
                Dim rutaDestinoPDFtim$ = Path.GetDirectoryName(rutaxml) & "\xmlTimbrado.pdf"

                Dim sr As StreamReader = New StreamReader(rutaxml, System.Text.Encoding.Default)
                Dim cont As String = sr.ReadToEnd()
                sr.Close()


                Dim ambiente$ = "pruebas"
                Dim correo, contraseniaCuenta, contraseniaCer, rfc As String
                correo = InputBox("Introduzca correo:", "Correo", "demo.sifec@gmail.com", 100, 100)
                contraseniaCuenta = InputBox("introduzca Contraseña de la cuenta:", "Contraseña CUENTA", "Acceso$01", 100, 100)

                Dim rutamiKey$ = ""
                Dim rutamiCer$ = ""
                Dim rutamiXML$ = ""
                MessageBox.Show("Abrir archivo .CER")
                rutamiCer = DameRuta()
                If Path.GetExtension(rutamiCer) <> ".cer" Then
                    MessageBox.Show("No se selecciono archivo o la extencion no es CER")
                    GoTo line1
                End If
                MessageBox.Show("Abrir archivo .KEY")
                rutamiKey = DameRuta()
                If Path.GetExtension(rutamiKey) <> ".key" Then
                    MessageBox.Show("No se selecciono archivo o la extencion no es KEY")
                    GoTo line1
                End If
                contraseniaCer = InputBox("introduzca Contraseña Certificado:", "Contraseña CERTIFICADO", "12345678a", 100, 100)

                Dim MemStream3 As New System.IO.MemoryStream()
                Using fs As System.IO.FileStream = File.OpenRead(rutamiKey)
                    fs.CopyTo(MemStream3)
                End Using
                Dim key As [Byte]() = MemStream3.ToArray()
                MemStream3.Dispose()
                MemStream3.Close()

                Dim MemStream2 As New System.IO.MemoryStream()
                Using fs As System.IO.FileStream = File.OpenRead(rutamiCer)
                    fs.CopyTo(MemStream2)
                End Using
                Dim cer As [Byte]() = MemStream2.ToArray()
                MemStream2.Dispose()
                MemStream2.Close()

                System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf ValidarCertificado)
                v = ws.SellarTimbrarPorTexto33(correo, contraseniaCuenta, "511110", cont, cer, key, contraseniaCer)
                If v.errores <> "" Then
                    uuid2.Text = v.errores
                Else
                    uuid2.Text = v.folioUUID
                    'bajando el xml timbrado
                    File.WriteAllBytes(rutaDestinoXmltim, v.XML)
                    'bajando el pdf formato generico
                    'File.WriteAllBytes(rutaDestinoPDFtim, v.PDF)
                End If

            End If

        Catch ex As Exception
            MessageBox.Show("ocurrio un error: " + ex.Message.ToString())
        End Try
line1:
    End Sub
    'Para obtener la fecha y hora
    Private Sub fecha_Click(sender As Object, e As EventArgs) Handles fecha.Click
        lblFecha.Text = ""
        Dim ws As New wsFechaHora.wsFechaHora()
        Dim v As New wsFechaHora.respuesta()
        Dim correo, contraseniaCuenta As String
        correo = InputBox("introduzca correo:", "Correo", "demo.sifec@gmail.com", 100, 100)
        contraseniaCuenta = InputBox("introduzca Contraseña de la cuenta:", "Contraseña CUENTA", "Acceso$01", 100, 100)
        System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf ValidarCertificado)
        v = ws.RecuperarFechaHoraActual(correo.Trim, contraseniaCuenta.Trim)
        If v.errores <> "" Then
            lblFecha.Text = v.errores
        Else
            'respuesta de la hora del servidor
            lblFecha.Text = v.fechaHoraActual
        End If
    End Sub

    Private Sub RecAcuse_Click(sender As Object, e As EventArgs)
        Try
            Dim ws As New wsTimbrado33.wsTimbrado33
            Dim v As New wsTimbrado33.resultado33
            Dim correo = InputBox("introduzca correo:", "Correo", "demo.sifec@gmail.com", 100, 100)
            Dim contraseniaCuenta = InputBox("introduzca Contraseña de la cuenta:", "Contraseña CUENTA", "Acceso$01", 100, 100)
            Dim UUIDcapt = InputBox("UUID:", "UUID", "", 100, 100)
            'aqui ponemos el Uuid
            'v = ws.recuperarAcuse("demo.sifec@gmailcom", "ContraseñaDeMicuenta", "uuid_cfdi")
            System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf ValidarCertificado)
            'v = ws.recuperarAcuse(correo, contraseniaCuenta, UUIDcapt)
            lbacuse.Text = "acuse bajado a C:\ruta_destino\AcuseEnvio.xml"
            'bajando el xml timbrado


            File.WriteAllBytes("C:\ruta_destino\AcuseEnvio.xml", v.acuse)
        Catch ex As Exception
            MessageBox.Show("ocurrio un error: " + ex.Message.ToString())
        End Try
    End Sub

    Private Sub RecAcuseCancel_Click(sender As Object, e As EventArgs)

        'Declarando el WEbSErvice
        Dim ws As New wsTimbrado33.wsTimbrado33
        Dim v As New wsTimbrado33.resultado33

        Try
            Dim process As New System.Diagnostics.Process()
            Dim startInfo As New System.Diagnostics.ProcessStartInfo()
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
            startInfo.FileName = "C:\OpenSSL-Win64\bin\openssl.exe"
            startInfo.Arguments = "pkcs8 -inform DER -in C:\ruta\aaa010101aaa__csd_01.key -passin pass:12345678a -out C:\ruta_destino\aaa010101aaa__csd_01.pem"
            process.StartInfo = startInfo
            process.Start()
            Dim pem As String = System.IO.File.ReadAllText("C:\ruta_destino\aaa010101aaa__csd_01.pem")

            pem = pem.Replace("-----BEGIN PRIVATE KEY-----", "")
            pem = pem.Replace("-----END PRIVATE KEY-----", "")
            Dim mylist As New List(Of String)(New String() {"uuid_cfdi"})

            System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf ValidarCertificado)
            Dim correo = InputBox("introduzca correo:", "Correo", "demo.sifec@gmail.com", 100, 100)
            Dim contraseniaCuenta = InputBox("introduzca Contraseña de la cuenta:", "Contraseña CUENTA", "Acceso$01", 100, 100)

            'v = ws.cancelar(correo, contraseniaCuenta, mylist.ToArray(), pem)
            If v.errores <> "" Then
                uuid.Text = v.errores
            Else
                uuid.Text = "acuse bajado a C:\ruta_destino\Acusedecancelar.xml"
                'bajando el xml timbrado

                File.WriteAllBytes("C:\ruta_destino\Acusedecancelar.xml", v.acuse)


            End If
        Catch ex As Exception
            MessageBox.Show("ocurrio un error: " + ex.Message.ToString())
        End Try

    End Sub

    Private Sub cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
        'Declarando el WEbSErvice
        Dim ws As New pruebasWsCancelar33.wsCancelar33
        Dim v As New pruebasWsCancelar33.resultado33
        Dim rutaKey, rutadestinoPem As String
        'la ruta de mi archivo hace referencia a donde se guardara nuestro archivo pem ya que se creara en el transcurso del proceso de cancelacion
        rutadestinoPem = "C:\ruta_destino_de_mi_archivo_PEM\miarchivoPEM.pem"
        rutaKey = "C:\Ruta_de_mi_archivo_KEY\miarhcivoKEY.key"
        Try
            If Not File.Exists(rutadestinoPem) Then
                Directory.CreateDirectory(Path.GetDirectoryName(rutadestinoPem))
                Dim arch As System.IO.FileStream
                arch = System.IO.File.Create(rutadestinoPem)
                arch.Close()
            End If
            Dim process As New System.Diagnostics.Process()
            Dim startInfo As New System.Diagnostics.ProcessStartInfo()
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
            startInfo.FileName = "C:\OpenSSL-Win64\bin\openssl.exe"
            startInfo.Arguments = "pkcs8 -inform DER -in " & rutaKey & " -passin pass:12345678a -out" & rutadestinoPem
            process.StartInfo = startInfo
            process.Start()
            'Dim pem As String = System.IO.File.ReadAllText(rutadestinoPem)

            'pem = pem.Replace("-----BEGIN PRIVATE KEY-----", "")
            'pem = pem.Replace("-----END PRIVATE KEY-----", "")
            'Dim mylist As New List(Of String)(New String() {"uuid_cfdi"})
            'Dim mylist As New List(Of String)(New String() {uuid.Text.ToUpper.Trim})
            Dim correo = InputBox("introduzca correo:", "Correo", "demo.sifec@gmail.com", 100, 100)
            Dim contraseniaCuenta = InputBox("introduzca Contraseña de la cuenta:", "Contraseña CUENTA", "Acceso$01", 100, 100)
            Dim rfcEmisor = InputBox("introduzca rfcEmisor:", "rfcEmisor", "LAN7008173R5", 100, 100)
            'System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf ValidarCertificado)
            v = ws.Cancelar33(correo, contraseniaCuenta, rfcEmisor, uuid.Text.ToUpper.Trim)
            'ruta donde bajaremos el acuse de cancelacion de nuestro xml
            'Dim rutaDestinoAccuseXML$ = "C:\Ruta_destino_donde_guardaremos_nuestro_acuse_de_cancelacion\Acusedecancelar.xml"
            If v.errores <> "" Then
                uuid.Text = v.errores
            Else
                uuid.Text = "cancelado ok"
                'uuid.Text = "acuse bajado a " & rutaDestinoAccuseXML
                'bajando el xml acusde de cancelacion
                ' File.WriteAllBytes(rutaDestinoAccuseXML, v.acuse)

            End If
        Catch ex As Exception
            MessageBox.Show("ocurrio un error: " + ex.Message.ToString())
        End Try
    End Sub
    Function DameRuta() As String
        Dim ruta$
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            ruta = OpenFileDialog1.FileName
            Return ruta
        End If
        ruta = ""
    End Function

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub timTxt_Click(sender As Object, e As EventArgs) Handles timTxt.Click
        uuid.Text = ""

        Try
            'si el cfdi está fuera de las ultimas 72 hrs debe primero modificarse la fecha de emisión a este rango
            ''actualizar las referencias web antes de ejecutarlas, dandole boton derecho->actualizar ref web
            Dim ws As New PruebasWsTimbradoTexto33.wsTimbradoTexto33
            Dim v As New PruebasWsTimbradoTexto33.resultado33

            'declaramos la rutadonde esta nuietro xml sellado
            'Dim rutaxml$ = "C:\Ruta_de_donde_tomaremos_nuestro_xml\xmlSellado.xml"
            Dim rutaxml$ = ""
            MessageBox.Show("Abrir el archivo txt")
            rutaxml = DameRuta()
            If Path.GetExtension(rutaxml) <> ".txt" Then
                MessageBox.Show("No se selecciono archivo txt o la extencion no es correcta")
            Else
                'delcararmos las rutas donde bajaremos nuestro xml timbrado y  nuestro pdf del xml timbrado
                Dim rutaDestinoXmltim$ = Path.GetDirectoryName(rutaxml) & "\xmlTimbrado.xml"
                Dim rutaDestinoPDFtim$ = Path.GetDirectoryName(rutaxml) & "\xmlTimbrado.pdf"

                Dim sr As StreamReader = New StreamReader(rutaxml, System.Text.Encoding.Default)
                Dim cont As String = sr.ReadToEnd()
                sr.Close()


                Dim ambiente$ = "pruebas"
                Dim correo, contraseniaCuenta, contraseniaCer, rfc As String
                correo = InputBox("Introduzca correo:", "Correo", "demo.sifec@gmail.com", 100, 100)
                contraseniaCuenta = InputBox("introduzca Contraseña de la cuenta:", "Contraseña CUENTA", "Acceso$01", 100, 100)
                'rfc = InputBox("introduzca RFC emisor:", "RFC emisor", "LAN7008173R5", 13, 13)
                'ambiente = InputBox("Introduzca Ambiente, el ambiente sera pruebas o producion pruebas no consume folios:", "Ambiente", "pruebas", 100, 100)

                'Dim rutamiKey$ = ""
                'Dim rutamiCer$ = ""
                'Dim rutamiXML$ = ""
                'MessageBox.Show("Abrir archivo .CER")
                'rutamiCer = DameRuta()
                'If Path.GetExtension(rutamiCer) <> ".cer" Then
                '    MessageBox.Show("No se selecciono archivo o la extencion no es CER")
                '    GoTo line1
                'End If
                'MessageBox.Show("Abrir archivo .KEY")
                'rutamiKey = DameRuta()
                'If Path.GetExtension(rutamiKey) <> ".key" Then
                '    MessageBox.Show("No se selecciono archivo o la extencion no es KEY")
                '    GoTo line1
                'End If
                'contraseniaCer = InputBox("introduzca Contraseña Certificado:", "Contraseña CERTIFICADO", "12345678a", 100, 100)

                'Dim MemStream3 As New System.IO.MemoryStream()
                'Using fs As System.IO.FileStream = File.OpenRead(rutamiKey)
                '    fs.CopyTo(MemStream3)
                'End Using
                'Dim key As [Byte]() = MemStream3.ToArray()
                'MemStream3.Dispose()
                'MemStream3.Close()

                'Dim MemStream2 As New System.IO.MemoryStream()
                'Using fs As System.IO.FileStream = File.OpenRead(rutamiCer)
                '    fs.CopyTo(MemStream2)
                'End Using
                'Dim cer As [Byte]() = MemStream2.ToArray()
                'MemStream2.Dispose()
                'MemStream2.Close()

                'System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf ValidarCertificado)
                v = ws.TimbrarPorTexto33(correo, contraseniaCuenta, "511110", cont)
                If v.errores <> "" Then
                    uuid.Text = v.errores
                Else
                    uuid.Text = v.folioUUID
                    'bajando el xml timbrado
                    File.WriteAllBytes(rutaDestinoXmltim, v.XML)
                    'bajando el pdf formato generico
                    If v.PDF IsNot Nothing Then
                        File.WriteAllBytes(rutaDestinoPDFtim, v.PDF)
                    End If

                End If

            End If

        Catch ex As Exception
            MessageBox.Show("ocurrio un error: " + ex.Message.ToString())
        End Try
line1:
    End Sub

    Private Sub lblFecha_Click(sender As Object, e As EventArgs) Handles lblFecha.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles timString.Click
        uuid.Text = ""

        Try
            'si el cfdi está fuera de las ultimas 72 hrs debe primero modificarse la fecha de emisión a este rango
            Dim ws As New PruebasWsTimbradoTexto33.wsTimbradoTexto33
            Dim v As New PruebasWsTimbradoTexto33.resultado33

            'declaramos la rutadonde esta nuietro xml sellado
            'Dim rutaxml$ = "C:\Ruta_de_donde_tomaremos_nuestro_xml\xmlSellado.xml"
            Dim rutaxml$ = ""
            MessageBox.Show("Selecciona un arch de la ruta donde se guardara el xml")
            rutaxml = DameRuta()

            'delcararmos las rutas donde bajaremos nuestro xml timbrado y  nuestro pdf del xml timbrado
            Dim rutaDestinoXmltim$ = Path.GetDirectoryName(rutaxml) & "\xmlTimbrado.xml"
                Dim rutaDestinoPDFtim$ = Path.GetDirectoryName(rutaxml) & "\xmlTimbrado.pdf"

            Dim cont As String = "DOCUMENTO|Factura|COMPROBANTE|3.3|E|26|2017-09-05T12:38:04|01|||1.00||MXN||1.16|I|PUE|61600|||CFDI_RELACIONADOS|6696a060-926c-4923-9155-d01453ea6590|CFDI_RELACION|01|EMISOR|LAN7008173R5|CINDEMEX SA DE CV|601|RECEPTOR|XAXX010101000|Publico en General|||G01|CONCEPTO| 01010101|011|1|DPC|uno|Timbrado desde WEB por texto|1.00|1.00||C_IMP_TRASLADADO|1.00|002|Tasa|0.160000|0.16|IMPUESTOSTOTALES|0.16||IMPUESTOSCOMPROBANTE|IMP_TRASLADADO|002|0.16|0.160000|Tasa|"


            Dim ambiente$ = "pruebas"
                Dim correo, contraseniaCuenta, contraseniaCer, rfc As String
                correo = InputBox("Introduzca correo:", "Correo", "demo.sifec@gmail.com", 100, 100)
                contraseniaCuenta = InputBox("introduzca Contraseña de la cuenta:", "Contraseña CUENTA", "Acceso$01", 100, 100)
                v = ws.TimbrarPorTexto33(correo, contraseniaCuenta, "511110", cont)
                If v.errores <> "" Then
                    uuid.Text = v.errores
                Else
                    uuid.Text = v.folioUUID
                    'bajando el xml timbrado
                    File.WriteAllBytes(rutaDestinoXmltim, v.XML)
                    'bajando el pdf formato generico
                    'File.WriteAllBytes(rutaDestinoPDFtim, v.PDF)
                End If


        Catch ex As Exception
            MessageBox.Show("ocurrio un error: " + ex.Message.ToString())
        End Try
line1:
    End Sub

    '    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '        Dim b As Byte() = System.Text.Encoding.Default.GetBytes("[Comprobante]
    'serie|A
    'folio|1
    'formaDePago|pago en una sola exhibicion|
    'subtotal|100.00
    'descuento|0
    'motivoDescto|
    'tipoCambio|1.0000
    'moneda|MXN
    'total|116.00	
    'tipoComprobante|factura
    'metodoPago|efectivo
    'lugarExpedicion|LEON LEON Guanajuato MEXICO
    'numCtaPago|9999
    '[fincomprobante]

    '[Emisor]
    'domiciliofiscal|BVLD ADOLFO LOPEZ MATEOS|1902| |PENITAS| | |Leon |Guanajuato|M�xico|37180
    'expedidoen|BLVD ADOLFO LOPEZ MATEOS|1902| |PENITAS| | |Leon |Guanajuato|M�xico|37180
    'RegimenFiscal|REGIMEL FISCAL DE PERSONAS MORALES
    'rfc|AAA010101AAA
    'nombre|ACCEM SERVICIOS EMPRESARIALES SC
    'descuento|0
    'motivoDescto|
    '[finemisor]

    '[receptor]
    'domicilio|MARIANO ESCOBEDO|4307|4| | | |LEON|GUANAJUATO|M�xico|
    'rfc|MURO861018QM2
    'nombre|OLAF ALBERTO MU�OZ ROJAS 
    '[finreceptor]
    '[conceptos]
    'concepto|1|No aplica|-|GASTOS DE MANTENIMIENTO|50|50
    'concepto|1|-|-|GASTOS DE LIMPIEZA|50|50
    'cuentaPredial|
    '[finconceptos]
    '[impuestos]
    'totaltrasladados|16.00	
    'totalretenidos|0
    'retencion|IVA|0
    'traslado|iva|16|16

    '[finimpuestos]
    '")
    '        Dim s = System.Text.Encoding.UTF8.GetString(b)
    '    End Sub
End Class
