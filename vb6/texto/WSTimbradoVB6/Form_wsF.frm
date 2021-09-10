VERSION 5.00
Begin VB.Form Form_WS 
   Caption         =   "Form_WS"
   ClientHeight    =   9150
   ClientLeft      =   3360
   ClientTop       =   1545
   ClientWidth     =   12480
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   9150
   ScaleWidth      =   12480
   Begin VB.TextBox txtRespuestaCancelacion 
      Height          =   285
      Left            =   8280
      TabIndex        =   23
      Top             =   5640
      Width           =   3015
   End
   Begin VB.TextBox txtUrlCancelar 
      Height          =   285
      Left            =   1680
      TabIndex        =   21
      Text            =   "http://pruebas.facturaselectronicascfdi.com/wsCancelar33.asmx"
      Top             =   5160
      Width           =   9615
   End
   Begin VB.CommandButton Cancelar 
      Caption         =   "Cancelar"
      Height          =   495
      Left            =   1680
      TabIndex        =   19
      Top             =   6360
      Width           =   2055
   End
   Begin VB.TextBox txtRfcEmisor 
      Height          =   285
      Left            =   1680
      TabIndex        =   18
      Text            =   "LAN7008173R5"
      Top             =   5640
      Width           =   4335
   End
   Begin VB.TextBox txtUUID 
      Height          =   285
      Left            =   7080
      TabIndex        =   16
      Top             =   3360
      Width           =   4215
   End
   Begin VB.TextBox txtSello 
      Height          =   285
      Left            =   1680
      TabIndex        =   13
      Top             =   3360
      Width           =   4335
   End
   Begin VB.TextBox txtErrores 
      Height          =   1455
      Left            =   1800
      MultiLine       =   -1  'True
      TabIndex        =   10
      Top             =   7440
      Width           =   9615
   End
   Begin VB.TextBox txtProceso 
      Height          =   375
      Left            =   8760
      TabIndex        =   9
      Text            =   "511110"
      Top             =   1200
      Width           =   2535
   End
   Begin VB.TextBox txtContenido 
      Height          =   1095
      Left            =   1680
      MaxLength       =   5000
      MultiLine       =   -1  'True
      ScrollBars      =   3  'Both
      TabIndex        =   7
      Text            =   "Form_wsF.frx":0000
      Top             =   1560
      Width           =   9615
   End
   Begin VB.TextBox txtPass 
      Height          =   375
      Left            =   5760
      TabIndex        =   3
      Text            =   "Acceso$01"
      Top             =   1200
      Width           =   1695
   End
   Begin VB.TextBox txtCorreo 
      Height          =   375
      Left            =   1680
      TabIndex        =   2
      Text            =   "demo.sifec@gmail.com"
      Top             =   1200
      Width           =   2895
   End
   Begin VB.CommandButton Timbrar 
      Caption         =   "Timbrar"
      Height          =   495
      Left            =   1680
      TabIndex        =   1
      Top             =   2640
      Width           =   2055
   End
   Begin VB.TextBox txtURL 
      Height          =   375
      Left            =   1680
      TabIndex        =   0
      Text            =   "http://pruebas.facturaselectronicascfdi.com/wsTimbradoTexto33.asmx"
      Top             =   840
      Width           =   9615
   End
   Begin VB.Line Line1 
      BorderWidth     =   2
      X1              =   600
      X2              =   11640
      Y1              =   3960
      Y2              =   3960
   End
   Begin VB.Label Label13 
      Caption         =   "Cancelar: Al cancelar se cancelara el UUID que aparece en la seccion de Timbrar"
      Height          =   375
      Left            =   3600
      TabIndex        =   25
      Top             =   4440
      Width           =   6735
   End
   Begin VB.Label Label12 
      Caption         =   "Timbrar"
      Height          =   375
      Left            =   3600
      TabIndex        =   24
      Top             =   240
      Width           =   3975
   End
   Begin VB.Label Label11 
      Caption         =   "Respuesta cancelacion:"
      Height          =   375
      Left            =   6240
      TabIndex        =   22
      Top             =   5640
      Width           =   1815
   End
   Begin VB.Label Label10 
      Caption         =   "Url WS Cancelar:"
      Height          =   495
      Left            =   720
      TabIndex        =   20
      Top             =   5040
      Width           =   855
   End
   Begin VB.Label Label9 
      Caption         =   "Rfc del Emisor:"
      Height          =   495
      Left            =   720
      TabIndex        =   17
      Top             =   5520
      Width           =   735
   End
   Begin VB.Label Label8 
      Caption         =   "UUID:"
      Height          =   255
      Left            =   6240
      TabIndex        =   15
      Top             =   3360
      Width           =   735
   End
   Begin VB.Label Label7 
      Caption         =   "Errores:"
      Height          =   255
      Left            =   960
      TabIndex        =   14
      Top             =   7440
      Width           =   615
   End
   Begin VB.Label Label6 
      Caption         =   "Sello:"
      Height          =   255
      Left            =   720
      TabIndex        =   12
      Top             =   3360
      Width           =   975
   End
   Begin VB.Label Label5 
      Caption         =   "Url del WS:"
      Height          =   255
      Left            =   600
      TabIndex        =   11
      Top             =   840
      Width           =   1095
   End
   Begin VB.Label Label4 
      Caption         =   "Proceso:"
      Height          =   255
      Left            =   7560
      TabIndex        =   8
      Top             =   1200
      Width           =   1095
   End
   Begin VB.Label Label3 
      Caption         =   "Cadena:"
      Height          =   255
      Left            =   600
      TabIndex        =   6
      Top             =   1560
      Width           =   1095
   End
   Begin VB.Label Label2 
      Caption         =   "Password:"
      Height          =   255
      Left            =   4800
      TabIndex        =   5
      Top             =   1200
      Width           =   975
   End
   Begin VB.Label Label1 
      Caption         =   "Correo:"
      Height          =   255
      Left            =   600
      TabIndex        =   4
      Top             =   1200
      Width           =   975
   End
End
Attribute VB_Name = "Form_WS"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Const cSOAPTimbrar = "<?xml version=""1.0"" encoding=""utf-8""?><soap:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/""><soap:Body><TimbrarPorTexto33 xmlns=""www.facturaselectronicascfdi.com""><correo>string</correo><pass>string</pass><Proceso>string</Proceso><contenidoArchivo>string</contenidoArchivo></TimbrarPorTexto33></soap:Body></soap:Envelope>"
Private Const cSOAPCancelar = "<?xml version=""1.0"" encoding=""utf-8""?><soap:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/""><soap:Body><Cancelar33 xmlns=""www.facturaselectronicascfdi.com""><curCorreo>string</curCorreo><password>string</password><RfcEmisor>string</RfcEmisor><UUID>string</UUID></Cancelar33></soap:Body></soap:Envelope>"


Private Sub Cancelar_Click()
    Dim parser As DOMDocument
    Set parser = New DOMDocument
    'cargar el codigo SOAP para Cancelar
    parser.loadXML cSOAPCancelar
    'parametros a enviar
    parser.selectSingleNode("/soap:Envelope/soap:Body/Cancelar33/curCorreo").Text = txtCorreo.Text
    parser.selectSingleNode("/soap:Envelope/soap:Body/Cancelar33/password").Text = txtPass.Text
    parser.selectSingleNode("/soap:Envelope/soap:Body/Cancelar33/RfcEmisor").Text = txtRfcEmisor.Text
    parser.selectSingleNode("/soap:Envelope/soap:Body/Cancelar33/UUID").Text = txtUUID.Text
    enviarComandoCancelar parser.xml, "www.facturaselectronicascfdi.com/Cancelar33"
End Sub
Private Sub enviarComandoCancelar(ByVal sXml As String, ByVal sSoapAction As String)
    ' Enviar el comando al servicio Web
    '
    ' usar XMLHTTP40 para enviar la información al servicio Web
    Dim OHttReq As XMLHTTP40
    Set OHttReq = New XMLHTTP40
    ' Enviar el comando de forma síncrona (se espera a que se reciba la respuesta)
    OHttReq.Open "POST", txtUrlCancelar.Text, False
    ' las cabeceras a enviar al servicio Web
    ' (no incluir los dos puntos en el nombre de la cabecera)
    OHttReq.setRequestHeader "Content-Type", "text/xml; charset=utf-8"
    OHttReq.setRequestHeader "SOAPAction", sSoapAction
    ' enviar el comando
    OHttReq.send sXml
    '
    ' este será el texto recibido del servicio Web
    procesarRespuestaCancelar OHttReq.responseText
    '
End Sub
Private Sub procesarRespuestaCancelar(ByVal s As String)
    ' procesar la respuesta recibida del servicio Web
    'Text1.Text = s
    '
    ' Poner los datos en el analizador de XML
    Dim parser As DOMDocument
    Set parser = New DOMDocument
    parser.loadXML s
    '
    On Error Resume Next
    '
    Dim error As String
    
    error = parser.selectSingleNode("/soap:Envelope/soap:Body/Cancelar33Response/Cancelar33Result/errores").Text
    If error = "" Then
      txtRespuestaCancelacion.Text = "Cancelacion Exitosa"
    Else
        txtErrores.Text = error
    End If
    '
    If Err.Number > 0 Then
        txtErrores.SetFocus
    End If
End Sub


Private Sub Timbrar_Click()
    
    Dim parser As DOMDocument
    Set parser = New DOMDocument
    ' cargar el código SOAP para Timbrar
    parser.loadXML cSOAPTimbrar
    '
    ' Indicar el parámetro a enviar
    parser.selectSingleNode("/soap:Envelope/soap:Body/TimbrarPorTexto33/correo").Text = txtCorreo.Text
    parser.selectSingleNode("/soap:Envelope/soap:Body/TimbrarPorTexto33/pass").Text = txtPass.Text
    parser.selectSingleNode("/soap:Envelope/soap:Body/TimbrarPorTexto33/Proceso").Text = txtProceso.Text
    parser.selectSingleNode("/soap:Envelope/soap:Body/TimbrarPorTexto33/contenidoArchivo").Text = txtContenido.Text
    '
    ' Mostrar el código XML enviado al servicio Web
    'Text2.Text = parser.xml
    enviarComando parser.xml, "www.facturaselectronicascfdi.com/TimbrarPorTexto33"
End Sub
Private Sub enviarComando(ByVal sXml As String, ByVal sSoapAction As String)
    ' Enviar el comando al servicio Web
    '
    ' usar XMLHTTP40 para enviar la información al servicio Web
    Dim OHttReq As MSXML2.ServerXMLHTTP60
    Set OHttReq = New MSXML2.ServerXMLHTTP60
    ' Enviar el comando de forma síncrona (se espera a que se reciba la respuesta)
    OHttReq.Open "POST", txtURL.Text, False
    ' las cabeceras a enviar al servicio Web
    ' (no incluir los dos puntos en el nombre de la cabecera)
    OHttReq.setRequestHeader "Content-Type", "text/xml; charset=utf-8"
    OHttReq.setRequestHeader "SOAPAction", sSoapAction
    OHttReq.setTimeouts "1000", "1000", "1000", "3000"
    ' enviar el comando
    Call OHttReq.send(sXml)
    '
    ' este será el texto recibido del servicio Web
    procesarRespuesta OHttReq.responseText
    '
End Sub

Private Sub procesarRespuesta(ByVal s As String)
    ' procesar la respuesta recibida del servicio Web
    'Text1.Text = s
    '
    ' Poner los datos en el analizador de XML
    Dim parser As DOMDocument
    Set parser = New DOMDocument
    parser.loadXML s
    '
    '
    On Error Resume Next
    '
    Dim error As String
    
    error = parser.selectSingleNode("/soap:Envelope/soap:Body/TimbrarPorTexto33Response/TimbrarPorTexto33Result/errores").Text
    If error = "" Then
        txtSello = parser.selectSingleNode("/soap:Envelope/soap:Body/TimbrarPorTexto33Response/TimbrarPorTexto33Result/sello").Text
        txtUUID = parser.selectSingleNode("/soap:Envelope/soap:Body/TimbrarPorTexto33Response/TimbrarPorTexto33Result/folioUUID").Text
        
        Dim xml, rutaXml As String
        Dim pdf, rutaPdf As String
        Dim path As String
        path = "C:\respuesta\"
        xml = parser.selectSingleNode("/soap:Envelope/soap:Body/TimbrarPorTexto33Response/TimbrarPorTexto33Result/XML").Text
        pdf = parser.selectSingleNode("/soap:Envelope/soap:Body/TimbrarPorTexto33Response/TimbrarPorTexto33Result/PDF").Text
        If xml <> "" Then
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '''''''''''Escribir la ruta de descarga de MXL''''''''
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''
            
            rutaXml = path + txtUUID.Text + ".xml"
            Open rutaXml For Binary Access Write As 1
            'Escribimos los bytes del array anterior, en el nuevo archivo ( archivo 1 )
                Put #1, , decodeBase64(xml)
            'Cerramos los dos archivos
            Close
        End If
        If pdf <> "" Then
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '''''''''''Escribir la ruta de descarga de PDF''''''''
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''
        
            rutaPdf = path + txtUUID.Text + ".pdf"
            Open rutaPdf For Binary Access Write As 2
            'Escribimos los bytes del array anterior, en el nuevo archivo ( archivo 2 )
                Put #2, , decodeBase64(pdf)
            'Cerramos los dos archivos
            Close
        End If
    Else
        txtErrores.Text = error
    End If
    '
    If Err.Number > 0 Then
        txtErrores.SetFocus
        'Text1.SetFocus
    End If
End Sub
Private Sub Form_WS_Load()
    Form_WS.Caption = "Cliente VB6" & vbCrLf & "del Servicio Web Timbrado por Texto 3.3"
End Sub

Private Function decodeBase64(ByVal strData As String) As Byte()
    Dim objXML As MSXML2.DOMDocument
    Dim objNode As MSXML2.IXMLDOMElement
    
    Set objXML = New MSXML2.DOMDocument
    Set objNode = objXML.createElement("b64")
    objNode.dataType = "bin.base64"
    objNode.Text = strData
    decodeBase64 = objNode.nodeTypedValue
    
    Set objNode = Nothing
    Set objXML = Nothing
End Function






