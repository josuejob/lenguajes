/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pruebaws;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.lang.String;
import org.tempuri.Resultado;

/**
 *
 * @author ventas3
 */
public class PruebaWS {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        //declaramos nuestras variables
        String ruta="C:\\Users\\ventas3\\Documents\\NetBeansProjects\\PruebaWS\\src\\pruebaws\\";
        String correo="demo.sifec@gmail.com";
        String pass="Acceso$01";
        String rfc="AAA010101AAA";
        boolean pdf=true;
        String passCer="12345678a";
        try {
            //KEY RUTA
        File file = new File(ruta+"csd.key");
            FileInputStream fis = new FileInputStream(file); 
            byte[] keyFile = new byte[(int)file.length()]; 
            fis.read(keyFile);
            fis.close();
            //CERTIFICADO RUTA
        File file2 = new File(ruta+"certificado.cer");
            FileInputStream fis2 = new FileInputStream(file2); 
            byte[] cerFile = new byte[(int)file2.length()]; 
            fis2.read(cerFile);
            fis2.close();
            //RUTA ARCHIVO NOMINA TEXTO
        File file3 = new File(ruta+"FormatoNominaTEXTO3_2.txt");
            FileInputStream fis3 = new FileInputStream(file3); 
            byte[] contenidoArchivo= new byte[(int)file3.length()]; 
            fis3.read(contenidoArchivo);
            fis3.close();
       
            Resultado timbrarNomina=timbradoPorTextoNomina(correo,pass,rfc,cerFile,keyFile,passCer,contenidoArchivo,pdf,"Pruebas","3.2-1.2");
            if (timbrarNomina.getErrores().equals("")) {
                //si no existen errores
                System.out.println("\n\n\t RESULTAOD EXITOSO\n ");
                //RUTA DE SALIDA DE PDF
                FileOutputStream fos= new FileOutputStream(ruta+"SalidaTimbre.pdf");
                fos.write(timbrarNomina.getPDF());
                fos.close();
                //RUTA DE SALIDA DE XML TIMBRADO
                FileOutputStream fos2= new FileOutputStream(ruta+"SalidaTimbre.xml");
                fos2.write(timbrarNomina.getXML());
                fos2.close();
            }else{
                System.out.println("Se generaron los siguientes errores: "+timbrarNomina.getErrores() );
            }
            
            
            
        } catch (Exception e) {
            System.out.println(" ERRORES ****** : "+e);
        }
        
        // TODO code application logic here
    }

    private static org.tempuri.Resultado timbradoPorTextoNomina(String correo, String pass, String rfc, byte[] cerFile, byte[] keyFile, String passCer, byte[] contenidoArchivo, boolean pdf, String ambiente,String version) {
        org.tempuri.WsTimbradoTexto service = new org.tempuri.WsTimbradoTexto();
        org.tempuri.WsTimbradoTextoSoap port = service.getWsTimbradoTextoSoap12();
        return port.timbradoPorTextoNomina(correo, pass, rfc, cerFile, keyFile, passCer, contenidoArchivo, pdf, ambiente, version);
    }




    

    
}
