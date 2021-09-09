<html>
    <head><title></title></head>
    <body>
    <%    
        Dim objHTTP, strEnvelope
        Set objHTTP = Server.CreateObject("MSXML2.ServerXMLHTTP")

        'Create the SOAP Envelope.
        'Start with standard xml name space and XML Schema Definition.
        strEnvelope = "<?xml version='1.0' encoding='utf-8'?>"
        strEnvelope = strEnvelope & "<soap:Envelope xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance' xmlns:xsd='http://www.w3.org/2001/XMLSchema' xmlns:soap='http://schemas.xmlsoap.org/soap/envelope/'>"

        'Define body of SOAP with method name and parameter names and vlaues to be passed.
        strEnvelope = strEnvelope & "<soap:Body>"
        strEnvelope = strEnvelope & "<TimbrarPorTexto33 xmlns='www.facturaselectronicascfdi.com'>"
        strEnvelope = strEnvelope & "<correo>demo.sifec@gmail.com</correo>"
        strEnvelope = strEnvelope & "<pass>Acceso$01</pass>"
        strEnvelope = strEnvelope & "<Proceso>511110</Proceso>"
        strEnvelope = strEnvelope & "<contenidoArchivo>DOCUMENTO|Factura|COMPROBANTE|3.3|ASP Classic|19|2017-11-10T14:47:03|01|1.00||MXN||1.16|I|PUE|61600|||CFDI_RELACIONADOS|6696a060-926c-4923-9155-d01453ea6590|CFDI_RELACION|01|EMISOR|LAN7008173R5|CINDEMEX SA DE CV|601|RECEPTOR|XAXX010101000|Publico en General|||G01|CONCEPTO| 01010101|011|1|DPC|uno|Timbrado WS Asp Classic|1.00|1.00||C_IMP_TRASLADADO|1.00|002|Tasa|0.160000|0.16|IMPUESTOSTOTALES|0.16||IMPUESTOSCOMPROBANTE|IMP_TRASLADADO|002|0.16|0.160000|Tasa|</contenidoArchivo>"
        strEnvelope = strEnvelope & "</TimbrarPorTexto33>"
        strEnvelope = strEnvelope & "</soap:Body></soap:Envelope>"    

        'Set properties of HTTP object and send SOAP envelop while calling 'Send' method
        Dim url
        url = "http://pruebas.facturaselectronicascfdi.com/WsTimbradoTexto33.asmx"
        With objHTTP
            .Open "post", url, False
            .setRequestHeader "Content-Type", "text/xml; charset=utf-8"
            .setRequestHeader "SOAPAction", "www.facturaselectronicascfdi.com/TimbrarPorTexto33"
            .send strEnvelope
        End With
        ' Following will write xml received from web services in the browser
        Dim strResponse
        strResponse = objHTTP.responseXML.Text
		'Response.Write(strResponse)
        If (strResponse = "") Then
            Response.Write("Invalid user")
        Else       
            'Cargamos el XML de respuesta que regresa el SOAP 
            Set myXmlDoc = Server.CreateObject("MSXML2.DOMDocument")
            myXmlDoc.async = False 
            myXmlDoc.loadXML(objHTTP.responseXML.xml)				

            Dim XmlResult,errores,folioUUID,fechaHoraTimbrado,cadenaOriginal  
            'Leemos el nodo TimbrarPorTexto33Result que contiene el resultado de el llamado    
            For Each XmlResult In myXmlDoc.documentElement.selectNodes("//TimbrarPorTexto33Result")
                'Si el elemento "errores" contiene texto este no se timbro 
                If XmlResult.selectSingleNode("errores").text <> "" then
                     errores = XmlResult.selectSingleNode("errores").text   
                     Response.Write Server.HTMLEncode(errores)  
                Else
                    'Si no contiene nada errores quiere decir que se timbro correctamente y solo queda recojer los datos de timbrado
                    Response.Write("Timbrado Exitoso") 
                    'Mostramos los datos del response 
                    'Nota: ver el xml de respuesta ya que existen mas atributos que se regresan, estos son los mas basicos
                    If Not XmlResult.selectSingleNode("folioUUID") is Nothing then
                        folioUUID = XmlResult.selectSingleNode("folioUUID").text 
                        Response.Write("</BR> Folio UUDI: " & folioUUID) 
                    End if
                    If Not XmlResult.selectSingleNode("fechaHoraTimbrado") is Nothing then
                        fechaHoraTimbrado = XmlResult.selectSingleNode("fechaHoraTimbrado").text 
                        Response.Write("</BR> Fecha Timbrado: "&fechaHoraTimbrado) 
                    End If
                    If Not XmlResult.selectSingleNode("cadenaOriginal") is Nothing then
                        cadenaOriginal = XmlResult.selectSingleNode("cadenaOriginal").text 
                        Response.Write("</BR>Cadena Original: "&cadenaOriginal) 
                    End If
                    'En caso de existir el xml lo guardamos 
                    If Not XmlResult.selectSingleNode("XML") is Nothing then
                       'XML esta variable es en Base64 se manda el texto en base 64 a SaveToBase64 para poder guardarlo como archivo
			           Call SaveToBase64(XmlResult.selectSingleNode("XML").text,"XmlTimbradoApsClassic.xml")
			       
                    End If
                    'En caso de existir el pdf lo guardamos
                    If Not XmlResult.selectSingleNode("PDF") is Nothing then
                        'PDF esta variable es en Base64 se manda el texto en base 64 a SaveToBase64 para poder guardarlo como archivo
			           Call SaveToBase64(XmlResult.selectSingleNode("PDF").text,"XmlTimbradoApsClassic.pdf")
			       
                    End If   
                End if                 
            Next   


        End If	
       function SaveToBase64(base64String,NombreArchivo)
            'Eliminamos archivos anteriores
            Set fso = Server.CreateObject("Scripting.FileSystemObject")
            if (fso.FileExists("C:/" &NombreArchivo)) then
                fso.DeleteFile("C:/" &NombreArchivo)
            end if
            'Guardamos
            Set Doc = Server.CreateObject("MSXML2.DomDocument")
            Set nodeB64 = Doc.CreateElement("b64")
            nodeB64.DataType = "bin.base64"
            nodeB64.Text = Mid(base64String, InStr(base64String, ",") + 1)
            dim bStream
            set bStream = server.CreateObject("ADODB.stream")
            bStream.type =  1
            bStream.Open()
            bStream.Write( nodeB64.NodeTypedValue )
            bStream.SaveToFile("C:/" & NombreArchivo)
            Response.Write("</BR> Archivo: C:/" & NombreArchivo)
            bStream.close()
            set bStream = nothing
        end function
    %>

    </body>
</html>