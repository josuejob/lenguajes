<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.uuid2 = New System.Windows.Forms.Label()
        Me.timTxt = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbacuseCancel = New System.Windows.Forms.Label()
        Me.lbacuse = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.uuid = New System.Windows.Forms.Label()
        Me.cancelar = New System.Windows.Forms.Button()
        Me.fecha = New System.Windows.Forms.Button()
        Me.Timbrar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.timString = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Controls.Add(Me.timString)
        Me.GroupBox1.Controls.Add(Me.uuid2)
        Me.GroupBox1.Controls.Add(Me.timTxt)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lbacuseCancel)
        Me.GroupBox1.Controls.Add(Me.lbacuse)
        Me.GroupBox1.Controls.Add(Me.lblFecha)
        Me.GroupBox1.Controls.Add(Me.uuid)
        Me.GroupBox1.Controls.Add(Me.cancelar)
        Me.GroupBox1.Controls.Add(Me.fecha)
        Me.GroupBox1.Controls.Add(Me.Timbrar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(440, 489)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Conexion Web Service:  los botones estan en el orden en que se deben de mandar ll" &
    "amar"
        '
        'uuid2
        '
        Me.uuid2.AutoSize = True
        Me.uuid2.Location = New System.Drawing.Point(31, 166)
        Me.uuid2.Name = "uuid2"
        Me.uuid2.Size = New System.Drawing.Size(34, 13)
        Me.uuid2.TabIndex = 15
        Me.uuid2.Text = "UUID"
        '
        'timTxt
        '
        Me.timTxt.Location = New System.Drawing.Point(31, 46)
        Me.timTxt.Name = "timTxt"
        Me.timTxt.Size = New System.Drawing.Size(166, 27)
        Me.timTxt.TabIndex = 14
        Me.timTxt.Text = "Timbrado por arch Texto"
        Me.timTxt.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 460)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "cancelar"
        '
        'lbacuseCancel
        '
        Me.lbacuseCancel.AutoSize = True
        Me.lbacuseCancel.Location = New System.Drawing.Point(31, 393)
        Me.lbacuseCancel.Name = "lbacuseCancel"
        Me.lbacuseCancel.Size = New System.Drawing.Size(61, 13)
        Me.lbacuseCancel.TabIndex = 10
        Me.lbacuseCancel.Text = "recuperado"
        '
        'lbacuse
        '
        Me.lbacuse.AutoSize = True
        Me.lbacuse.Location = New System.Drawing.Point(31, 325)
        Me.lbacuse.Name = "lbacuse"
        Me.lbacuse.Size = New System.Drawing.Size(64, 13)
        Me.lbacuse.TabIndex = 9
        Me.lbacuse.Text = "recuperado:"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(31, 263)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(34, 13)
        Me.lblFecha.TabIndex = 8
        Me.lblFecha.Text = "fecha"
        '
        'uuid
        '
        Me.uuid.AutoSize = True
        Me.uuid.Location = New System.Drawing.Point(31, 85)
        Me.uuid.Name = "uuid"
        Me.uuid.Size = New System.Drawing.Size(34, 13)
        Me.uuid.TabIndex = 7
        Me.uuid.Text = "UUID"
        '
        'cancelar
        '
        Me.cancelar.Location = New System.Drawing.Point(31, 418)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.Size = New System.Drawing.Size(166, 28)
        Me.cancelar.TabIndex = 6
        Me.cancelar.Text = "cancelar"
        Me.cancelar.UseVisualStyleBackColor = True
        '
        'fecha
        '
        Me.fecha.Location = New System.Drawing.Point(31, 207)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(166, 27)
        Me.fecha.TabIndex = 3
        Me.fecha.Text = "Fecha Hora"
        Me.fecha.UseVisualStyleBackColor = True
        '
        'Timbrar
        '
        Me.Timbrar.Location = New System.Drawing.Point(31, 122)
        Me.Timbrar.Name = "Timbrar"
        Me.Timbrar.Size = New System.Drawing.Size(166, 27)
        Me.Timbrar.TabIndex = 2
        Me.Timbrar.Text = "Timbrado Por Texto (CER,KEY)"
        Me.Timbrar.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'timString
        '
        Me.timString.Location = New System.Drawing.Point(244, 46)
        Me.timString.Name = "timString"
        Me.timString.Size = New System.Drawing.Size(166, 27)
        Me.timString.TabIndex = 16
        Me.timString.Text = "Timbrado desde string"
        Me.timString.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 498)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lbacuseCancel As Label
    Friend WithEvents lbacuse As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents cancelar As Button
    Friend WithEvents fecha As Button
    Friend WithEvents Timbrar As Button
    Friend WithEvents uuid As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents timTxt As Button
    Friend WithEvents uuid2 As Label
    Friend WithEvents timString As Button
End Class
