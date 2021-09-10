<?php 
header('Content-Type: text/html; charset=UTF-8'); 	
//Creamos el objeto con el que mandaremos a Consultar los Folios 
//$soapclient = new SoapClient('http://prod.facturaselectronicascfdi.com/WsConsultaFolios.asmx?WSDL');
$soapclient = new SoapClient('http://pruebas.facturaselectronicascfdi.com/WsConsultaFolios.asmx?WSDL');
$ResultText = '';
if(isset($_POST['ConsultarFolios']))
{
	//ConsultarFolios(Correo, Pass, Proceso);
	// Correo    : Este campo debe de incluir el correo con el que fue habilitada su cuenta
	// Pass      : Su contraseña 
	// Proceso   : Este numero de proceso se le proporcionara dependiendo de su tipo de timbrado
	//              - 511110 Cadena de texto a XML,Sellado, Timbrado, PDF 
	$Correo = "demo.sifec@gmail.com";
	$Pass = 'Acceso$01';
	$Proceso = "511110";

	$params = array('curCorreo' => $Correo, 'password' => $Pass, 'Proceso' => $Proceso);
	//var_dump($params);
	try{
		$response = $soapclient->ConsultarFolios($params);
		//var_dump($response);
		//if (empty($response->timbrarResult->errores))
		if (empty($response->ConsultarFoliosResult->errores))
		{
			$ResultText= "</tr><td colspan=\"2\"> Mi Número de Pedido : ".$response->ConsultarFoliosResult->idPedido."</td><tr>";
			$ResultText= $ResultText."</tr><td colspan=\"2\">  Fecha de Caducidad : ".$response->ConsultarFoliosResult->fechaCaducidad."</td><tr>";
			$ResultText= $ResultText."</tr><td colspan=\"2\">  Total : ".$response->ConsultarFoliosResult->Total."</td><tr>";
			$ResultText= $ResultText."</tr><td colspan=\"2\">  Disponibles : ".$response->ConsultarFoliosResult->Disponibles."</td><tr>";
			$ResultText= $ResultText."</tr><td colspan=\"2\">  Usados : ".$response->ConsultarFoliosResult->Usados."</td><tr>";

		}else{
			$ResultText= "</tr><td colspan=\"2\">La consulta tuvo errores:".$response->ConsultarFoliosResult->errores."</td><tr>";
		}
	} catch (Exception $e) {
		$ResultText= "</tr><td colspan=\"2\">Se genero el siguiente error: ".$response->ConsultarFoliosResult->errores."</td><tr>";
	}
}

?>
<html>
<head>
	<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
	<title>Cliente del Web Service</title>
</head>
<body>
	<div class="jumbotron">
		<h1 class="display-4 text-warning">Inowebs</h1>
		<p class="lead">Cliente del Web Service para consultar folios disponibles en <a href="http://www.facturaselectronicascfdi.com/">www.facturaselectronicascfdi.com</a>.</p>
		<hr class="my-4">
		<p class="lead">
			<form method="post" action="folios.php">
				<h5>Método para Consulta de Folios</h5>
				<table class="table bg-white rounded">
					<tr>
						<td align="center">
							<input type="submit" name="ConsultarFolios" value="ConsultarFolios" class="btn btn-lg btn-info">
						</td>
						<td>
							<p> - ConsultarFolios(Correo, Pass,Proceso);</p>
							<p> - El método ConsultarFolios requiere Correo, Pass,Proceso, para consultar folios.</p>
						</td>
					</tr>
					<?php echo $ResultText;?></p>
				</table>
			</form>
		</p>
	</div>
</body>
</html>