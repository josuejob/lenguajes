<?php 
header('Content-Type: text/html; charset=UTF-8'); 	
//Creamos el objeto con el que mandaremos a Timbrar 
$soapclient = new SoapClient('http://pruebas.facturaselectronicascfdi.com/WsTimbradoTexto33.asmx?WSDL');
//Creamos el objeto con el que se mandara a cancelar los folios
$soapclient = new SoapClient('http://pruebas.facturaselectronicascfdi.com/wsCancelar33.asmx?WSDL');

$ResultText = '';
$CanceText= '';

if(isset($_POST['SellarTimbrartexto33']))
{
	//Cargamos nuestro archivo con la cadena de texto generada apartir de la guia proporcionara
	$file1 = "EjemploFacturaCadenaTexto.txt";
	$open = fopen($file1, "r");
	$size = filesize($file1);
	$CadenaTexto = fread($open, $size);


	//Cargamos el Certificado que se utilizara en este xml
	$file2 = "certificado.cer";
	$open = fopen($file2, "r");
	$size = filesize($file2);
	$Cer = fread($open, $size);


	//Cargamos el Key que se utilizara en este xml
	$file3 = "csd.key";
	$open = fopen($file3, "r");
	$size = filesize($file3);
	$Key = fread($open, $size);

	$Correo = "demo.sifec@gmail.com";
	$Pass = 'Acceso$01';
	$Proceso = "511110";
	$ClaveKey = '12345678a';
	
	//SellarTimbrar33(Correo, Pass, contenidoArchivo, Proceso, cer, key, clavekey);
	// Correo    : Este campo debe de incluir el correo con el que fue habilitada su cuenta
	// Pass      : Su contraseña 
	// contenidoArchivo       : Cadena de texto
	// Proceso   : Este numero de proceso se le proporcionara dependiendo de su tipo de timbrado
	//              - 511110 Cadena de texto a XML,Sellado, Timbrado, PDF 
	// Cer       : Certificado en Bytes
	// Key       : Key en Bytes
	// Clave Key : Clave de su key 
	$params = array('curCorreo' => $Correo, 'password' => $Pass,'contenidoArchivo' => $CadenaTexto, 'Proceso' => $Proceso,'CerFile' => $Cer, 'KeyFile' => $Key, 'PassCsd' =>$ClaveKey);
	try{
		$response = $soapclient->SellarTimbrarTexto33($params);
			if (empty($response->SellarTimbrarTexto33Result->errores))
			{
				$ResultText= '<br>El timbrado fue correcto <br> UUID: '.$response->SellarTimbrarTexto3333Result->folioUUID;

				$file = "XmlTimbrado.pdf";
				$miarch = fopen($file, "w");
				fwrite($miarch, $response->SellarTimbrar33Result->PDF );
				fclose($miarch);


				$file = "XmlTimbrado.xml";
				$miarch = fopen($file, "w");
				fwrite($miarch, $response->SellarTimbrar33Result->XML );
				fclose($miarch);
			}else{
				$ResultText = '<br>El timbrado tuvo errores <br> Errores: '.$response->SellarTimbrar33Result->errores;
			}
		} catch (Exception $e) {
			$ResultText= "Se genero el siguiente error: <br>".$response->Timbrar33Result->errores;
		}
}

if(isset($_POST['TibrarTexto33']))
{

	//Cargamos nuestro archivo con la cadena de texto generada apartir de la guia proporcionara
	$file1 = "EjemploFacturaCadenaTexto.txt";
	$open = fopen($file1, "r");
	$size = filesize($file1);
	$CadenaTexto = fread($open, $size);
	//SellarTimbrar33(Correo, Pass, contenidoArchivo, Proceso, cer, key, clavekey);
	// Correo    : Este campo debe de incluir el correo con el que fue habilitada su cuenta
	// Pass      : Su contraseña 
	// contenidoArchivo       : Cadena de Texto
	// Proceso   : Este numero de proceso se le proporcionara dependiendo de su tipo de timbrado
	//              - 511110 Cadena de texto a XML,Sellado, Timbrado, PDF 
	// Cer       : Certificado en Bytes
	// Key       : Key en Bytes
	// Clave Key : Clave de su key 
	$Correo = "demo.sifec@gmail.com";
	$Pass = 'Acceso$01';
	$Proceso = "511110";
	$ClaveKey = '12345678a';
	$params = array('curCorreo' => $Correo, 'password' => $Pass, 'contenidoArchivo' => $CadenaTexto,'Proceso' => $Proceso);
	//var_dump($params);
		try{
		$response = $soapclient->Timbrar33($params);
		//var_dump($response);
		//if (empty($response->timbrarResult->errores))
			if (empty($response->Timbrar33Result->errores))
			{
				$ResultText= "<br>El timbrado fue correcto <br> UUID: ".$response->Timbrar33Result->folioUUID;
				
				$file = "XmlTimbrado.pdf";
				$miarch = fopen($file, "w");
				fwrite($miarch, $response->Timbrar33Result->PDF );
				fclose($miarch);


				$file = "XmlTimbrado.xml";
				$miarch = fopen($file, "w");
				fwrite($miarch, $response->Timbrar33Result->XML );
				fclose($miarch);
			}else{
				$ResultText= "<br>El timbrado tuvo errores <br> Errores:".$response->Timbrar33Result->errores;
			}
		} catch (Exception $e) {
			$ResultText= "Se genero el siguiente error: <br>".$response->Timbrar33Result->errores;
		}
}

if(isset($_POST['Cancelar']))
{
	$Correo = "demo.sifec@gmail.com";
	$Pass = 'Acceso$01';
	
	$params = array('curCorreo' => $Correo, 'password' => $Pass, 'RfcEmisor' => 'LAN7008173R5', 'UUID' => '691a62ce-f987-421a-a8c4-be851d59b17a');

	try{
	$response = $soapclient->Cancelar33($params);

		if (empty($response->Cancelar33Result->errores))
		{
			$CanceText= "<br>Cancelacion fue correcto <br> ";
		}else{
			$CanceText= "<br>El cancelar tuvo errores <br> Errores:".$response->Cancelar33Result->errores;
		}
	}
	catch (Exception $e) {
		$CanceText= "Se genero el siguiente error: <br>".$e->getMessage();
	}
}

if(isset($_POST['CancelarEncode']))
{
	$Correo = "demo.sifec@gmail.com";
	$Pass = 'Acceso$01';
	
	//Cargamos el Certificado que se utilizara para cancelar este xml
	$file2 = "certificado.cer";
	$open = fopen($file2, "r");
	$size = filesize($file2);
	$Cer = fread($open, $size);
	//Cargamos el Key con el cual procesaremos el Encode
	
	$convert=exec('openssl pkcs8 -inform DER -in csd.key -passin pass:12345678a -out Encode.pem',$salida,$valor);
	if ($valor == 127) {
	$CanceText= "no Funcionó";
	} else{
	$CanceText="Se ejecutó correctamente";
	}

	$file = "Encode.pem";
	$open = fopen($file, "r");
	$size = filesize($file);
	$pem = fread($open, $size);
	$pem2 = str_replace("-----BEGIN PRIVATE KEY-----","",$pem);
	$Encode = str_replace("-----END PRIVATE KEY-----", "",$pem2);
	
	
	$params = array('curCorreo' => $Correo, 'password' => $Pass, 'RfcEmisor' => 'LAN7008173R5', 'UUID' => '7dbd76b1-ac3b-4251-a919-c03a509ff5ec','CerFile' => $Cer,'KeyEncode64' => $Encode);

	try{
	$response = $soapclient->Cancelar33($params);

		if (empty($response->Cancelar33Result->errores))
		{
			$CanceText= "<br>Cancelacion fue correcto <br> ";
		}else{
			$CanceText= "<br>El cancelar tuvo errores <br> Errores:".$response->Cancelar33Result->errores;
		}
	}
	catch (Exception $e) {
		$CanceText= "Se genero el siguiente error: <br>".$e->getMessage();
	}
}
?>
<html>
 <head>
  <title>Cliente del Web Server para timbrado de CFDI. v3.3</title>
 </head>
 <body>
 <div>Cliente del Web Server para timbrado de CFDI. v3.3</div>
    <br> 
	<form method="post" action="soapcfdi2.php">
	<br>Metodos Para el Timbrado
	<br>
	<table border="1px">
	<tr>
	<td align="center">
		<input type="submit" name="SellarTimbrar33" value="SellarTimbrar33">
	</td>
	<td>
		<p> - SellarTimbrar33(Correo, Pass, xml, Proceso, cer, key, clavekey);</p>
		<p> - Este metodo SellarTimbrar33 requiere un .cer y .key con el que se mandara timbrar el xml estos tiene que coincidir con el Emisor</p>
		<p> - Recolecta el cer y key en caso de timbrar correctamente deposita el xml y pdf en caso de existir</p>
	</td>
	</tr>
	<tr>
	<td align="center"><input type="submit" name="Tibrar33" value="Tibrar33"></td>
	<td>
		<p> - Timbrar33(Corre,Pass, xml, Proceso);</p>
		<p> - Este metodo requiere que el Emisor del Xml carge su cer y key en la plataforma web para poder realizar el sellado del xml enviado </p>
		<p> - El xml a timbrar tiene que tener los siguientes atributos vacios NoCetificado="" Certificado="" Sello="" ya que el ws se encargara de sellar con el cer y key cargados, Este metodo regresar el xml timbrado</p>
	</td>
	</tr>
	<tr  >
	<td colspan="2">
		<p> Resultado de Timbrado</p>
    </td>
	</tr>
	<tr >
	<td colspan="2">
		<p> <?php echo $ResultText;?></p>
		<br>
    </td>
	</tr>	
	</table>	
	</br>	
	<br>
	Metodo de Cancelacion
	<table border="1px">
	<tr >
	<td align="center"><input type="submit" name="Cancelar" value="Cancelar"></td>
	<td>
	<br>
	<p>Cancelar33(Correo, Pass, RFC, UUID); cer y key configurados en porta web</p>
	<br>
	</td>
	</tr>
	<tr>
	<td align="center"><input type="submit" name="CancelarEncode" value="CancelarEncode"></td>
	<td>
	<br>
	<p>Cancelar33EncodeCSD(Correo, Pass, RFC, UUID, Cer, Pem); cer y pem se generan por su sistema</p>
	<br>
	</td>
	</tr>
	<tr >
	<td colspan="2">
		<p> <?php echo $CanceText;?></p>
		<br>
    </td>
	</tr>	
	</table>
		
    </form>
</body>
</html>




