using service = WindowsFormsApplication1.PruebasWsTimbrado33;
using service2 = WindowsFormsApplication1.wsFechaHora;
using service4 = WindowsFormsApplication1.PruebasWsCancelar33;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
//pruebe 1o a sellar y 2o a timbrar si desea usar los archivos de prueba proporcionados, para que el sello tome una fecha no menor a 72 hrs
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void llamarWebservice_Click(object sender, EventArgs e) //sellar
        {
            try
            {
                //Declarando el WEbSErvice
                service.wsTimbrado33 ws = new service.wsTimbrado33();
                service.resultado33 v = new service.resultado33();

                Errores.Text = "-";
                Cadena.Text = "-";
                uuid.Text = "-";

                //Tener en cuenta la ruta donde el programa toma los archivos, ya que estos se utilizan para el sellado
                string path = @"C:\csd.key"; //Tomamos el .KEY podemos modificar la ruta de ser requerido
                System.IO.MemoryStream MemStream = new System.IO.MemoryStream();
                using (System.IO.FileStream fs = File.OpenRead(path))
                {
                    fs.CopyTo(MemStream);
                }
                Byte[] key = MemStream.ToArray();
                MemStream.Dispose();
                MemStream.Close();

                path = @"C:\certificado.cer"; //Tomamos el .CER podemos modificar la ruta de ser requerido
                System.IO.MemoryStream MemStream2 = new System.IO.MemoryStream();
                using (System.IO.FileStream fs = File.OpenRead(path))
                {
                    fs.CopyTo(MemStream2);
                }
                Byte[] cer = MemStream2.ToArray();
                MemStream2.Dispose();
                MemStream2.Close();

                path = @"C:\ruta_destino\SinTimbre.xml";// XML v3.3 listo para mandar timbrar, en caso de recibir el error de que este comprobante ya fue timbrado, favor de cambiar el Numero de Folio o Otro campo con finalidad de cambiar la cadena original del XML 
                System.IO.MemoryStream MemStream3 = new System.IO.MemoryStream();
                using (System.IO.FileStream fs = File.OpenRead(path))
                {
                    fs.CopyTo(MemStream3);
                }
                Byte[] xml = MemStream3.ToArray();
                MemStream3.Dispose();
                MemStream3.Close();

                //SellarTimbrar33(Correo, Pass, xml, Proceso, cer, key, clavekey);
                // Correo    : Este campo debe de incluir el correo con el que fue habilitada su cuenta
                // Pass      : Su contraseña 
                // XML       : Xml en Bytes
                // Proceso   : Este numero de proceso se le proporcionara dependiendo de su tipo de timbrado
                //              - 210100 Solo Sellado Timbrado 
                //              - 410110 Sellado Timbrado Mas PDF
                // Cer       : Certificado en Bytes
                // Key       : Key en Bytes
                // Clave Key : Clave de su key 
                v = ws.SellarTimbrar33("demo.sifec@gmail.com", "Acceso$01", xml, "410110", cer, key, "12345678a");

                //En caso de errores la respuesta se contendra en .errores en caso de lo contrario sera ""
                if (v.errores != "")
                {
                    Errores.Text = v.errores;
                }
                else
                {
                    uuid.Text = v.folioUUID;
                    Cadena.Text = v.cadenaOriginal; 

                    File.WriteAllBytes(@"C:\ruta_destino\xmlSelladoTimbrado.xml", v.XML);

                    //Dependiento el tipo de timbrado este puede contener su version en PDF
                    if (v.PDF != null) {

                            File.WriteAllBytes(@"C:\ruta_destino\xmlSelladoTimbrado.pdf", v.PDF);
                    }
                    
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("ocurrio un error: " + ex.Message.ToString());
            }
        }

        private void timbrar_Click(object sender, EventArgs e)
        {
            try
            {

                Errores.Text = "-";
                Cadena.Text = "-";
                uuid.Text = "-";
                //si el cfdi está fuera de las ultimas 72 hrs debe primero modificarse la fecha de emisión a este rango
                //'actualizar las referencias web antes de ejecutarlas, dandole boton derecho->actualizar ref web
                service.wsTimbrado33 ws = new service.wsTimbrado33();
                service.resultado33 v = new service.resultado33();

                string path = @"C:\ruta_destino\SinTimbre.xml";// XML v3.3 listo para mandar timbrar, en caso de recibir el error de que este comprobante ya fue timbrado, favor de cambiar el Numero de Folio o Otro campo con finalidad de cambiar la cadena original del XML 
                System.IO.MemoryStream MemStream = new System.IO.MemoryStream();
                using (System.IO.FileStream fs = File.OpenRead(path))
                {
                    fs.CopyTo(MemStream);
                }
                Byte[] xml = MemStream.ToArray();
                MemStream.Dispose();
                MemStream.Close();

                // ws.Timbrar33(Correo, Pass, xml, Proceso);
                // Correo    : Este campo debe de incluir el correo con el que fue habilitada su cuenta
                // Pass      : Su contraseña 
                // XML       : Xml en Bytes
                // Proceso   : Este numero de proceso se le proporcionara dependiendo de su tipo de timbrado 
                //              - 210100 Solo Sellado Timbrado 
                //              - 410110 Sellado Timbrado Mas PDF
                v = ws.Timbrar33("demo.sifec@gmail.com", "Acceso$01", xml, "210100"); 

                if (v.errores != "")
                {
                    Errores.Text = v.errores + " a las "+ DateTime.Now;
                }
                else 
                {
                    uuid.Text = v.folioUUID;
                    Cadena.Text = v.cadenaOriginal;
                    //bajando el xml timbrado
                    path = @"C:\ruta_destino\xmlTimbrado.xml";
                    File.WriteAllBytes(path, v.XML);

                    //Dependiento el tipo de timbrado este puede contener su version en PDF
                    if (v.PDF != null)
                    {                      
                            File.Delete(@"C:\ruta_destino\xmlSelladoTimbrado.pdf");
                            File.WriteAllBytes(@"C:\ruta_destino\xmlSelladoTimbrado.pdf", v.PDF);
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("ocurrio un error: " + ex.Message.ToString());
            }
        }

        private void fecha_Click(object sender, EventArgs e)
        {
            service2.wsFechaHora ws = new service2.wsFechaHora();
            service2.respuesta v = new service2.respuesta();

            v = ws.RecuperarFechaHoraActual("demo.sifec@gmail.com", "Acceso$01");
            if (v.errores != "")
            {
                lblFecha.Text = v.errores;
            }
            else
            {
                lblFecha.Text = v.fechaHoraActual;
            }
        }

  
        private void cancelacfdi_Click(object sender, EventArgs e)
        {
            //Declarando el WEbSErvice
            service4.wsCancelar33 ws = new service4.wsCancelar33();
            service4.resultado33 v = new service4.resultado33();
            Cancelar.Text = "-";
                try
                {
                // Cancelar33(Correo, Pass, RFC, UUID); cer y key configurados en porta web
                // Correo    : Este campo debe de incluir el correo con el que fue habilitada su cuenta
                // Pass      : Su contraseña 
                // RFC       : RFC del emisor del xml que se quiere cancelar 
                // UUID      : UUID del xml a cancelar
                //Para este tipo de cancelacion el cer y key deben de cargarse en el portal web ya que con requeridos para cancelar ante el SAT
                v = ws.Cancelar33("demo.sifec@gmail.com", "Acceso$01", "LAN7008173R5", "a812348d-cb3f-4241-8112-1b8927a31651");
                    if (v.errores != "")
                    {
                        Cancelar.Text = v.errores;
                    }
                    else
                    {
                         Cancelar.Text = @"acuse bajado a C:\ruta_destino\Acusedecancelar.xml";
                        //bajando el xml timbrado
                        File.WriteAllBytes(@"C:\ruta_destino\Acusedecancelar.xml", v.acuse);

                     }      
               }
              catch (Exception ex)
               { 
                 MessageBox.Show("ocurrio un error: " + ex.Message.ToString());
               }

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            //Declarando el WEbSErvice
            service4.wsCancelar33 ws = new service4.wsCancelar33();
            service4.resultado33 v = new service4.resultado33();
            Cancelar.Text = "-";
            try
            {
                //Para cancelar sin tener que cagar los certificados en el portal wev se da la opcion de generar su propio encode de cancelacion y para ello se trabaja con el certificado, key y clave key del emisor del xml
                string path = @"C:\certificado.cer"; //@"D:\ruta\aaa010101aaa__csd_01.cer";
                System.IO.MemoryStream MemStream2 = new System.IO.MemoryStream();
                using (System.IO.FileStream fs = File.OpenRead(path))
                {
                    fs.CopyTo(MemStream2);
                }
                Byte[] cer = MemStream2.ToArray();
                MemStream2.Dispose();
                MemStream2.Close();

                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = @"C:\OpenSSL-Win64\bin\openssl.exe";
                startInfo.Arguments = @"pkcs8 -inform DER -in C:\csd.key -passin pass:12345678a -out C:\ruta_destino\Encode.pem";
                process.StartInfo = startInfo;
                process.Start();
                //se crea el encode el cual proviene del key 
                string pem = System.IO.File.ReadAllText(@"C:\ruta_destino\Encode.pem");

                pem = pem.Replace("-----BEGIN PRIVATE KEY-----", "");
                pem = pem.Replace("-----END PRIVATE KEY-----", "");

                // Cancelar33EncodeCSD(Correo, Pass, RFC, UUID, Cer, Pem); cer y pem se generan por su sistema
                // Correo    : Este campo debe de incluir el correo con el que fue habilitada su cuenta
                // Pass      : Su contraseña 
                // RFC       : RFC del emisor del xml que se quiere cancelar 
                // UUID      : UUID del xml a cancelar
                // CER       : Certificado del emisor del xml a cancelar en Bytes
                // Encode    : Encode proviene del tratado que se le dio anteriormente al Key 
                //Para este tipo de cancelacion el cer y key deben de cargarse en el portal web ya que con requeridos para cancelar ante el SAT
                v = ws.Cancelar33EncodeCSD("demo.sifec@gmail.com", "Acceso$01", "LAN7008173R5", "578c7935-c41c-43ba-a89f-320b0297f9ba", cer, pem);
                if (v.errores != "")
                {
                    Cancelar.Text = v.errores;
                }
                else
                {
                    Cancelar.Text = @"acuse bajado a C:\ruta_destino\AcusedecancelarEncode.xml";
                    //bajando el xml timbrado
                    File.WriteAllBytes(@"C:\ruta_destino\AcusedecancelarEncode.xml", v.acuse);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("ocurrio un error: " + ex.Message.ToString());
            }
        }

      
    }
}
