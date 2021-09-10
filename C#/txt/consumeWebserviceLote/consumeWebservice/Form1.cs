using service = WindowsFormsApplication1.PruebasWsTimbradoRetencionesTexto;
using service2 = WindowsFormsApplication1.wsFechaHora;
using service4 = WindowsFormsApplication1.PruebasWsCancelar33;
using serviceprimario = WindowsFormsApplication1.WsPruebasPrimarioSIFEI;
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
            Filtro.SelectedIndex = 0;
        }    

        private void TimbrarLote_Click(object sender, EventArgs e)
        {

            try
            {

                Errores.Text = "";
                Descargar.Text = "";
                PID.Text = "";
                //si la cadena de texto está fuera de las ultimas 72 hrs debe primero modificarse la fecha de emisión a este rango
                //'actualizar las referencias web antes de ejecutarlas, dandole boton derecho->actualizar ref web

                serviceprimario.wsTimbradoTextoPrimario33 ws = new serviceprimario.wsTimbradoTextoPrimario33();
                serviceprimario.resultadoloteprimario33 v = new serviceprimario.resultadoloteprimario33();

                String path = @"C:\ruta_destino\EjemploFacturaLoteCadenaTextoPrimario.txt";// Cadena de texto con los datos requeridos para convertir a xml, en caso de recibir el error de que este comprobante ya fue timbrado, favor de cambiar el Numero de Folio o Otro campo con finalidad de cambiar la cadena original del XML 
               
                System.IO.MemoryStream MemStream3 = new System.IO.MemoryStream();
                using (System.IO.FileStream fs = File.OpenRead(path))
                {
                    fs.CopyTo(MemStream3);
                }
                Byte[] LotePrimario = MemStream3.ToArray();
                MemStream3.Dispose();
                MemStream3.Close();



                // ws.Timbrar33(Correo, Pass, xml, Proceso);
                // Correo    : Este campo debe de incluir el correo con el que fue habilitada su cuenta
                // Pass      : Su contraseña 
                // XML       : Xml en Bytes
                // Proceso   : Este numero de proceso se le proporcionara dependiendo de su tipo de timbrado "511110" convierte txt a xml,sella y timbra mas Pdf
                // CadenaTexto: Este parametro resive una cadena en string que contiene los datos para generar el xml
                v = ws.TimbrarPorLoteTextoPrimario33("demo.sifec@gmail.com", "Acceso$01", "911110", LotePrimario);

                if (v.Errores != "")
                {
                    Errores.Text = v.Errores + " a las " + DateTime.Now;
                }
                else
                {
                    PID.Text = v.PID;
                    Descargar.Text = v.Status + " PID: "+ v.PID ;
                    //Cadena.Text = v.cadenaOriginal;
                    //bajando el xml timbrado
                    //path = @"C:\ruta_destino\xmlTimbradoTextoPrimario.xml";
                    //File.WriteAllBytes(path, v.XML);

                    ////Dependiento el tipo de timbrado este puede contener su version en PDF
                    //if (v.PDF != null)
                    //{
                    //    File.Delete(@"C:\ruta_destino\xmlTimbradoTextoPrimario.pdf");
                    //    File.WriteAllBytes(@"C:\ruta_destino\xmlTimbradoTextoPrimario.pdf", v.PDF);
                    //}
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ocurrio un error: " + ex.Message.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

               

                serviceprimario.wsTimbradoTextoPrimario33 ws = new serviceprimario.wsTimbradoTextoPrimario33();
                serviceprimario.resultadoloteprimario33 v = new serviceprimario.resultadoloteprimario33();           


                v = ws.ComandoTimbradoLote("demo.sifec@gmail.com", "Acceso$01", "ESTATUS", PID.Text);

                if (v.Errores != "")
                {
                    Errores.Text = v.Errores + " a las " + DateTime.Now;
                }
                else
                {
                    Descargar.Text = "["+v.Status+"] Informacion de timbrado: "+ v.InfoTimbrado;

                    //Cadena.Text = v.cadenaOriginal;
                    //bajando el xml timbrado
                    //path = @"C:\ruta_destino\xmlTimbradoTextoPrimario.xml";
                    //File.WriteAllBytes(path, v.XML);

                    ////Dependiento el tipo de timbrado este puede contener su version en PDF
                    //if (v.PDF != null)
                    //{
                    //    File.Delete(@"C:\ruta_destino\xmlTimbradoTextoPrimario.pdf");
                    //    File.WriteAllBytes(@"C:\ruta_destino\xmlTimbradoTextoPrimario.pdf", v.PDF);
                    //}
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ocurrio un error: " + ex.Message.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {



                serviceprimario.wsTimbradoTextoPrimario33 ws = new serviceprimario.wsTimbradoTextoPrimario33();
                serviceprimario.resultadoloteprimario33 v = new serviceprimario.resultadoloteprimario33();

                if (PID.Text != "")
                {
                    v = ws.ComandoTimbradoLote("demo.sifec@gmail.com", "Acceso$01", "ABORTAR", PID.Text);

                    if (v.Errores != "")
                    {
                        Errores.Text = v.Errores + " a las " + DateTime.Now;
                    }
                    else
                    {
                        Descargar.Text = "[" + v.Status + "] Informacion de timbrado: " + v.InfoTimbrado;

                        //Cadena.Text = v.cadenaOriginal;
                        //bajando el xml timbrado
                        //path = @"C:\ruta_destino\xmlTimbradoTextoPrimario.xml";
                        //File.WriteAllBytes(path, v.XML);

                        ////Dependiento el tipo de timbrado este puede contener su version en PDF
                        //if (v.PDF != null)
                        //{
                        //    File.Delete(@"C:\ruta_destino\xmlTimbradoTextoPrimario.pdf");
                        //    File.WriteAllBytes(@"C:\ruta_destino\xmlTimbradoTextoPrimario.pdf", v.PDF);
                        //}
                    }
                } else {
                    Errores.Text = "SE REQUIERE UN PID PARA ESTE PROCESO";
                }


               

            }
            catch (Exception ex)
            {
                MessageBox.Show("ocurrio un error: " + ex.Message.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PID_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Filtro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            serviceprimario.wsTimbradoTextoPrimario33 ws = new serviceprimario.wsTimbradoTextoPrimario33();
            serviceprimario.resultadoloteprimario33 v = new serviceprimario.resultadoloteprimario33();

            string comando = "";

            switch (Filtro.SelectedItem.ToString())
            {
                case "LOTE":
                    comando = "DESCLOTE";
                    break;
                case "UUID":
                    comando = "DESCUUID";
                    break;
                case "FOLIO":
                    comando = "DESCFOLIO";
                    break;
                default:
                    comando = "";
                    break;
            }
          
            v = ws.ComandoTimbradoLote("demo.sifec@gmail.com", "Acceso$01", comando, Buscar.Text);

            if (v.Errores != "")
            {
                Errores.Text = v.Errores + " a las " + DateTime.Now;
            }
            else
            {
                Descargar.Text = "[" + v.Status + "] " + v.InfoTimbrado;

                if (v.Archivo != null)
                {
                    File.Delete(@"C:\ruta_destino\"+ Filtro.SelectedItem.ToString() + "-" + Buscar.Text + ".zip");
                    File.WriteAllBytes(@"C:\ruta_destino\" + Filtro.SelectedItem.ToString() + "-" + Buscar.Text + ".zip", v.Archivo);
                }
            }
        }

        private void DesHisto_Click(object sender, EventArgs e)
        {
            serviceprimario.wsTimbradoTextoPrimario33 ws = new serviceprimario.wsTimbradoTextoPrimario33();
            serviceprimario.resultadoloteprimario33 v = new serviceprimario.resultadoloteprimario33();


            v = ws.ComandoTimbradoLote("demo.sifec@gmail.com", "Acceso$01", "HISTORIAL", PID.Text);

            if (v.Errores != "")
            {
                Errores.Text = v.Errores + " a las " + DateTime.Now;
            }
            else
            {
                Descargar.Text = "[" + v.Status + "] " + v.InfoTimbrado;

                if (v.Archivo != null)
                {
                    File.Delete(@"C:\ruta_destino\Historial"+PID.Text+".txt");
                    File.WriteAllBytes(@"C:\ruta_destino\Historial" + PID.Text + ".txt", v.Archivo);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
