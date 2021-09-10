namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TimbrarPorTexto33 = new System.Windows.Forms.Button();
            this.fecha = new System.Windows.Forms.Button();
            this.SellarTimbrarPorTexto33 = new System.Windows.Forms.Button();
            this.cancelacfdi = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Label();
            this.Cadena = new System.Windows.Forms.Label();
            this.CancelarEncode = new System.Windows.Forms.Button();
            this.uuid = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Errores = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimbrarPorTexto33
            // 
            this.TimbrarPorTexto33.Location = new System.Drawing.Point(20, 28);
            this.TimbrarPorTexto33.Name = "TimbrarPorTexto33";
            this.TimbrarPorTexto33.Size = new System.Drawing.Size(245, 47);
            this.TimbrarPorTexto33.TabIndex = 2;
            this.TimbrarPorTexto33.Text = "TimbrarPorTexto33";
            this.TimbrarPorTexto33.UseVisualStyleBackColor = true;
            this.TimbrarPorTexto33.Click += new System.EventHandler(this.timbrar_Click);
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(52, 19);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(179, 23);
            this.fecha.TabIndex = 4;
            this.fecha.Text = "fechaHoraActual";
            this.fecha.UseVisualStyleBackColor = true;
            this.fecha.Click += new System.EventHandler(this.fecha_Click);
            // 
            // SellarTimbrarPorTexto33
            // 
            this.SellarTimbrarPorTexto33.Location = new System.Drawing.Point(20, 32);
            this.SellarTimbrarPorTexto33.Name = "SellarTimbrarPorTexto33";
            this.SellarTimbrarPorTexto33.Size = new System.Drawing.Size(244, 43);
            this.SellarTimbrarPorTexto33.TabIndex = 0;
            this.SellarTimbrarPorTexto33.Text = "SellarTimbrarPorTexto33";
            this.SellarTimbrarPorTexto33.UseVisualStyleBackColor = true;
            this.SellarTimbrarPorTexto33.Click += new System.EventHandler(this.llamarWebservice_Click);
            // 
            // cancelacfdi
            // 
            this.cancelacfdi.Location = new System.Drawing.Point(19, 3);
            this.cancelacfdi.Name = "cancelacfdi";
            this.cancelacfdi.Size = new System.Drawing.Size(148, 38);
            this.cancelacfdi.TabIndex = 10;
            this.cancelacfdi.Text = "Cancelar";
            this.cancelacfdi.UseVisualStyleBackColor = true;
            this.cancelacfdi.Click += new System.EventHandler(this.cancelacfdi_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.AutoSize = true;
            this.Cancelar.Location = new System.Drawing.Point(15, 25);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(10, 13);
            this.Cancelar.TabIndex = 11;
            this.Cancelar.Text = "-";
            // 
            // Cadena
            // 
            this.Cadena.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.Cadena.Location = new System.Drawing.Point(18, 16);
            this.Cadena.Name = "Cadena";
            this.Cadena.Size = new System.Drawing.Size(833, 35);
            this.Cadena.TabIndex = 1;
            this.Cadena.Text = "-";
            // 
            // CancelarEncode
            // 
            this.CancelarEncode.Location = new System.Drawing.Point(19, 51);
            this.CancelarEncode.Name = "CancelarEncode";
            this.CancelarEncode.Size = new System.Drawing.Size(148, 44);
            this.CancelarEncode.TabIndex = 14;
            this.CancelarEncode.Text = "CancelarEncodeCSD";
            this.CancelarEncode.UseVisualStyleBackColor = true;
            this.CancelarEncode.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // uuid
            // 
            this.uuid.AutoSize = true;
            this.uuid.Location = new System.Drawing.Point(17, 18);
            this.uuid.Name = "uuid";
            this.uuid.Size = new System.Drawing.Size(10, 13);
            this.uuid.TabIndex = 3;
            this.uuid.Text = "-";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.Location = new System.Drawing.Point(60, 61);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(160, 18);
            this.lblFecha.TabIndex = 17;
            this.lblFecha.Text = "AAAA-MM-DDThh:mm:ss ";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(22, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.SellarTimbrarPorTexto33);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Size = new System.Drawing.Size(863, 114);
            this.splitContainer1.SplitterDistance = 287;
            this.splitContainer1.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(10, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(498, 32);
            this.label6.TabIndex = 1;
            this.label6.Text = "En caso de generar correctamente el Xml apartir del texto, este se mandara sellar" +
    " con el certificado propocionado y regresara el Xml timbrado";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(10, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(498, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Este metodo SellarTimbrarPorTexto33 requiere un .cer y .key con el que se mandara" +
    " timbrar el xml generado de la cadena de texto propocionada";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(486, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "SellarTimbrarPorTexto33(correo, pass, Proceso, contenidoArchivo, cerFile, keyFile" +
    ", passCer);";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.uuid);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.groupBox1.Location = new System.Drawing.Point(22, 316);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(863, 41);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "UUID";
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Location = new System.Drawing.Point(22, 132);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer2.Panel1.Controls.Add(this.TimbrarPorTexto33);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.label8);
            this.splitContainer2.Panel2.Controls.Add(this.label7);
            this.splitContainer2.Size = new System.Drawing.Size(863, 116);
            this.splitContainer2.SplitterDistance = 287;
            this.splitContainer2.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(9, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(524, 26);
            this.label8.TabIndex = 1;
            this.label8.Text = "Este metodo requiere que el Emisor del TXT carge su cer y key en la plataforma we" +
    "b para poder realizar el sellado del xml generado apartir de la cadena de texto " +
    "enviada\r\n ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(298, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "TimbrarPorTexto33(correo, pass, Proceso, contenidoArchivo);";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox2.Controls.Add(this.Cadena);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox2.Location = new System.Drawing.Point(22, 360);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(863, 67);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cadena Original";
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox3.Controls.Add(this.Errores);
            this.groupBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox3.Location = new System.Drawing.Point(23, 259);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(863, 53);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Errores";
            this.groupBox3.UseCompatibleTextRendering = true;
            // 
            // Errores
            // 
            this.Errores.ForeColor = System.Drawing.Color.Red;
            this.Errores.Location = new System.Drawing.Point(18, 20);
            this.Errores.Name = "Errores";
            this.Errores.Size = new System.Drawing.Size(645, 17);
            this.Errores.TabIndex = 1;
            this.Errores.Text = "-";
            this.Errores.UseCompatibleTextRendering = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer3.Location = new System.Drawing.Point(22, 445);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.AccessibleName = "";
            this.splitContainer3.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.splitContainer3.Panel1.Controls.Add(this.CancelarEncode);
            this.splitContainer3.Panel1.Controls.Add(this.cancelacfdi);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.label10);
            this.splitContainer3.Panel2.Controls.Add(this.label1);
            this.splitContainer3.Size = new System.Drawing.Size(562, 100);
            this.splitContainer3.SplitterDistance = 187;
            this.splitContainer3.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(3, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(360, 33);
            this.label10.TabIndex = 1;
            this.label10.Text = "Cancelar33EncodeCSD(Correo, Pass, RFC, UUID, Cer, Pem); cer y pem se generan por " +
    "su sistema";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cancelar33(Correo, Pass, RFC, UUID); cer y key configurados en porta web\r\n";
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSize = true;
            this.groupBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox4.Controls.Add(this.Cancelar);
            this.groupBox4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox4.Location = new System.Drawing.Point(22, 551);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(863, 54);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resultado Cancelacion";
            this.groupBox4.UseCompatibleTextRendering = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.fecha);
            this.groupBox5.Controls.Add(this.lblFecha);
            this.groupBox5.Location = new System.Drawing.Point(590, 445);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(295, 100);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Fecha y Hora Servidor";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(498, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "En caso de generar correctamente el Xml apartir del texto, este se mandara sellar" +
    " con los certificados precargados y regresara el Xml timbrado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 614);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.splitContainer3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Timbrado Texto";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TimbrarPorTexto33;
        private System.Windows.Forms.Button fecha;
        private System.Windows.Forms.Button SellarTimbrarPorTexto33;
        private System.Windows.Forms.Button cancelacfdi;
        private System.Windows.Forms.Label Cancelar;
        private System.Windows.Forms.Label Cadena;
        private System.Windows.Forms.Button CancelarEncode;
        private System.Windows.Forms.Label uuid;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label Errores;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

