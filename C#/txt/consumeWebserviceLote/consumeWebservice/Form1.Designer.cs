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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Descargar = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Errores = new System.Windows.Forms.Label();
            this.TimbrarLote = new System.Windows.Forms.Button();
            this.ConsultarPID = new System.Windows.Forms.Button();
            this.AbortarPID = new System.Windows.Forms.Button();
            this.TEXTPID = new System.Windows.Forms.GroupBox();
            this.PID = new System.Windows.Forms.TextBox();
            this.DesHisto = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Filtro = new System.Windows.Forms.ComboBox();
            this.Buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.TEXTPID.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.Descargar);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.groupBox1.Location = new System.Drawing.Point(222, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 100);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Respuesta";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Descargar
            // 
            this.Descargar.AcceptsReturn = true;
            this.Descargar.AcceptsTab = true;
            this.Descargar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Descargar.Location = new System.Drawing.Point(17, 19);
            this.Descargar.Multiline = true;
            this.Descargar.Name = "Descargar";
            this.Descargar.Size = new System.Drawing.Size(485, 75);
            this.Descargar.TabIndex = 19;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox3.Controls.Add(this.Errores);
            this.groupBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox3.Location = new System.Drawing.Point(221, 180);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(512, 57);
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
            this.Errores.Size = new System.Drawing.Size(485, 21);
            this.Errores.TabIndex = 1;
            this.Errores.Text = "-";
            this.Errores.UseCompatibleTextRendering = true;
            // 
            // TimbrarLote
            // 
            this.TimbrarLote.Location = new System.Drawing.Point(29, 29);
            this.TimbrarLote.Name = "TimbrarLote";
            this.TimbrarLote.Size = new System.Drawing.Size(156, 39);
            this.TimbrarLote.TabIndex = 25;
            this.TimbrarLote.Text = "Timbrar Lote";
            this.TimbrarLote.UseVisualStyleBackColor = true;
            this.TimbrarLote.Click += new System.EventHandler(this.TimbrarLote_Click);
            // 
            // ConsultarPID
            // 
            this.ConsultarPID.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ConsultarPID.Location = new System.Drawing.Point(29, 78);
            this.ConsultarPID.Name = "ConsultarPID";
            this.ConsultarPID.Size = new System.Drawing.Size(156, 41);
            this.ConsultarPID.TabIndex = 26;
            this.ConsultarPID.Text = "Consultar PID";
            this.ConsultarPID.UseVisualStyleBackColor = true;
            this.ConsultarPID.Click += new System.EventHandler(this.button1_Click);
            // 
            // AbortarPID
            // 
            this.AbortarPID.ForeColor = System.Drawing.Color.Red;
            this.AbortarPID.Location = new System.Drawing.Point(29, 186);
            this.AbortarPID.Name = "AbortarPID";
            this.AbortarPID.Size = new System.Drawing.Size(156, 41);
            this.AbortarPID.TabIndex = 27;
            this.AbortarPID.Text = "Abortar PID";
            this.AbortarPID.UseVisualStyleBackColor = true;
            this.AbortarPID.Click += new System.EventHandler(this.button2_Click);
            // 
            // TEXTPID
            // 
            this.TEXTPID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TEXTPID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TEXTPID.Controls.Add(this.PID);
            this.TEXTPID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TEXTPID.Location = new System.Drawing.Point(222, 29);
            this.TEXTPID.Name = "TEXTPID";
            this.TEXTPID.Size = new System.Drawing.Size(511, 39);
            this.TEXTPID.TabIndex = 20;
            this.TEXTPID.TabStop = false;
            this.TEXTPID.Text = "PID";
            this.TEXTPID.Enter += new System.EventHandler(this.PID_Enter);
            // 
            // PID
            // 
            this.PID.Location = new System.Drawing.Point(20, 13);
            this.PID.Name = "PID";
            this.PID.Size = new System.Drawing.Size(482, 20);
            this.PID.TabIndex = 0;
            // 
            // DesHisto
            // 
            this.DesHisto.ForeColor = System.Drawing.SystemColors.Highlight;
            this.DesHisto.Location = new System.Drawing.Point(29, 133);
            this.DesHisto.Name = "DesHisto";
            this.DesHisto.Size = new System.Drawing.Size(156, 41);
            this.DesHisto.TabIndex = 28;
            this.DesHisto.Text = "Descargar Historial";
            this.DesHisto.UseVisualStyleBackColor = true;
            this.DesHisto.Click += new System.EventHandler(this.DesHisto_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(508, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 21);
            this.button2.TabIndex = 29;
            this.button2.Text = "Descargar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Filtro
            // 
            this.Filtro.AllowDrop = true;
            this.Filtro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.Filtro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Filtro.FormattingEnabled = true;
            this.Filtro.Items.AddRange(new object[] {
            "LOTE",
            "UUID",
            "FOLIO"});
            this.Filtro.Location = new System.Drawing.Point(121, 302);
            this.Filtro.Name = "Filtro";
            this.Filtro.Size = new System.Drawing.Size(89, 21);
            this.Filtro.TabIndex = 30;
            this.Filtro.SelectedIndexChanged += new System.EventHandler(this.Filtro_SelectedIndexChanged);
            // 
            // Buscar
            // 
            this.Buscar.AccessibleDescription = "Buscar";
            this.Buscar.Location = new System.Drawing.Point(216, 302);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(286, 20);
            this.Buscar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Descargar CFDI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Filtro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Busqueda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 383);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.Filtro);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DesHisto);
            this.Controls.Add(this.TimbrarLote);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TEXTPID);
            this.Controls.Add(this.AbortarPID);
            this.Controls.Add(this.ConsultarPID);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Timbrado Texto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.TEXTPID.ResumeLayout(false);
            this.TEXTPID.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label Errores;
        private System.Windows.Forms.Button TimbrarLote;
        private System.Windows.Forms.Button ConsultarPID;
        private System.Windows.Forms.Button AbortarPID;
        private System.Windows.Forms.GroupBox TEXTPID;
        private System.Windows.Forms.TextBox PID;
        private System.Windows.Forms.TextBox Descargar;
        private System.Windows.Forms.Button DesHisto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox Filtro;
        private System.Windows.Forms.TextBox Buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

