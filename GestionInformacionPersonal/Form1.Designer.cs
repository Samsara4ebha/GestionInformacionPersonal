namespace GestionInformacionPersonal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tcDatospersonales = new System.Windows.Forms.TabControl();
            this.tpDatos = new System.Windows.Forms.TabPage();
            this.mcCalendario = new System.Windows.Forms.MonthCalendar();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.lbEdad = new System.Windows.Forms.Label();
            this.pnRadioB = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbOtro = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpPreferencias = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNota = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.cbPaises = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cblHobbies = new System.Windows.Forms.CheckedListBox();
            this.cbSuscrito = new System.Windows.Forms.CheckBox();
            this.tpVisualizacion = new System.Windows.Forms.TabPage();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnCambiarFoto = new System.Windows.Forms.Button();
            this.lbFechaHora = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.pbImagenPerfil = new System.Windows.Forms.PictureBox();
            this.tTemporizador = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblFechaCalendario = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tcDatospersonales.SuspendLayout();
            this.tpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.pnRadioB.SuspendLayout();
            this.tpPreferencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNota)).BeginInit();
            this.tpVisualizacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // tcDatospersonales
            // 
            this.tcDatospersonales.Controls.Add(this.tpDatos);
            this.tcDatospersonales.Controls.Add(this.tpPreferencias);
            this.tcDatospersonales.Controls.Add(this.tpVisualizacion);
            this.tcDatospersonales.Location = new System.Drawing.Point(2, 2);
            this.tcDatospersonales.Margin = new System.Windows.Forms.Padding(2);
            this.tcDatospersonales.Name = "tcDatospersonales";
            this.tcDatospersonales.SelectedIndex = 0;
            this.tcDatospersonales.Size = new System.Drawing.Size(605, 315);
            this.tcDatospersonales.TabIndex = 0;
            // 
            // tpDatos
            // 
            this.tpDatos.Controls.Add(this.lblFechaCalendario);
            this.tpDatos.Controls.Add(this.mcCalendario);
            this.tpDatos.Controls.Add(this.nudEdad);
            this.tpDatos.Controls.Add(this.lbEdad);
            this.tpDatos.Controls.Add(this.pnRadioB);
            this.tpDatos.Controls.Add(this.tbDireccion);
            this.tpDatos.Controls.Add(this.tbCorreo);
            this.tpDatos.Controls.Add(this.tbNombre);
            this.tpDatos.Controls.Add(this.label3);
            this.tpDatos.Controls.Add(this.label2);
            this.tpDatos.Controls.Add(this.label1);
            this.tpDatos.Location = new System.Drawing.Point(4, 22);
            this.tpDatos.Margin = new System.Windows.Forms.Padding(2);
            this.tpDatos.Name = "tpDatos";
            this.tpDatos.Padding = new System.Windows.Forms.Padding(2);
            this.tpDatos.Size = new System.Drawing.Size(597, 289);
            this.tpDatos.TabIndex = 0;
            this.tpDatos.Text = "Datos Personales";
            this.tpDatos.UseVisualStyleBackColor = true;
            // 
            // mcCalendario
            // 
            this.mcCalendario.Location = new System.Drawing.Point(390, 35);
            this.mcCalendario.Margin = new System.Windows.Forms.Padding(7);
            this.mcCalendario.Name = "mcCalendario";
            this.mcCalendario.TabIndex = 12;
            this.mcCalendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(476, 252);
            this.nudEdad.Margin = new System.Windows.Forms.Padding(2);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(90, 20);
            this.nudEdad.TabIndex = 11;
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.Location = new System.Drawing.Point(412, 259);
            this.lbEdad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(32, 13);
            this.lbEdad.TabIndex = 10;
            this.lbEdad.Text = "Edad";
            // 
            // pnRadioB
            // 
            this.pnRadioB.BackColor = System.Drawing.Color.IndianRed;
            this.pnRadioB.Controls.Add(this.label4);
            this.pnRadioB.Controls.Add(this.rbMasculino);
            this.pnRadioB.Controls.Add(this.rbOtro);
            this.pnRadioB.Controls.Add(this.rbFemenino);
            this.pnRadioB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnRadioB.Location = new System.Drawing.Point(82, 148);
            this.pnRadioB.Margin = new System.Windows.Forms.Padding(2);
            this.pnRadioB.Name = "pnRadioB";
            this.pnRadioB.Size = new System.Drawing.Size(199, 124);
            this.pnRadioB.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Genero";
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(109, 19);
            this.rbMasculino.Margin = new System.Windows.Forms.Padding(2);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 6;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbOtro
            // 
            this.rbOtro.AutoSize = true;
            this.rbOtro.Location = new System.Drawing.Point(110, 89);
            this.rbOtro.Margin = new System.Windows.Forms.Padding(2);
            this.rbOtro.Name = "rbOtro";
            this.rbOtro.Size = new System.Drawing.Size(45, 17);
            this.rbOtro.TabIndex = 8;
            this.rbOtro.TabStop = true;
            this.rbOtro.Text = "Otro";
            this.rbOtro.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(110, 53);
            this.rbFemenino.Margin = new System.Windows.Forms.Padding(2);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbFemenino.TabIndex = 7;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(190, 74);
            this.tbDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(174, 20);
            this.tbDireccion.TabIndex = 5;
            // 
            // tbCorreo
            // 
            this.tbCorreo.Location = new System.Drawing.Point(190, 113);
            this.tbCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(174, 20);
            this.tbCorreo.TabIndex = 4;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(190, 35);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(2);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(174, 20);
            this.tbNombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Correo Electronico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dirección";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // tpPreferencias
            // 
            this.tpPreferencias.Controls.Add(this.label7);
            this.tpPreferencias.Controls.Add(this.tbNota);
            this.tpPreferencias.Controls.Add(this.label6);
            this.tpPreferencias.Controls.Add(this.cbPaises);
            this.tpPreferencias.Controls.Add(this.label5);
            this.tpPreferencias.Controls.Add(this.cblHobbies);
            this.tpPreferencias.Controls.Add(this.cbSuscrito);
            this.tpPreferencias.Location = new System.Drawing.Point(4, 22);
            this.tpPreferencias.Margin = new System.Windows.Forms.Padding(2);
            this.tpPreferencias.Name = "tpPreferencias";
            this.tpPreferencias.Padding = new System.Windows.Forms.Padding(2);
            this.tpPreferencias.Size = new System.Drawing.Size(597, 289);
            this.tpPreferencias.TabIndex = 1;
            this.tpPreferencias.Text = "Preferencias";
            this.tpPreferencias.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 180);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "¿Nota para la aplicación?";
            // 
            // tbNota
            // 
            this.tbNota.Location = new System.Drawing.Point(80, 204);
            this.tbNota.Margin = new System.Windows.Forms.Padding(2);
            this.tbNota.Minimum = 1;
            this.tbNota.Name = "tbNota";
            this.tbNota.Size = new System.Drawing.Size(416, 45);
            this.tbNota.TabIndex = 6;
            this.tbNota.Value = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(415, 72);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Pais de Residencia";
            // 
            // cbPaises
            // 
            this.cbPaises.FormattingEnabled = true;
            this.cbPaises.Location = new System.Drawing.Point(418, 87);
            this.cbPaises.Margin = new System.Windows.Forms.Padding(2);
            this.cbPaises.Name = "cbPaises";
            this.cbPaises.Size = new System.Drawing.Size(92, 21);
            this.cbPaises.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Hobbies";
            // 
            // cblHobbies
            // 
            this.cblHobbies.FormattingEnabled = true;
            this.cblHobbies.Items.AddRange(new object[] {
            "Juegos",
            "Musica",
            "Baile",
            "Programar",
            "UNGA UNGA"});
            this.cblHobbies.Location = new System.Drawing.Point(250, 63);
            this.cblHobbies.Margin = new System.Windows.Forms.Padding(2);
            this.cblHobbies.Name = "cblHobbies";
            this.cblHobbies.Size = new System.Drawing.Size(91, 64);
            this.cblHobbies.TabIndex = 2;
            // 
            // cbSuscrito
            // 
            this.cbSuscrito.AutoSize = true;
            this.cbSuscrito.Location = new System.Drawing.Point(72, 87);
            this.cbSuscrito.Margin = new System.Windows.Forms.Padding(2);
            this.cbSuscrito.Name = "cbSuscrito";
            this.cbSuscrito.Size = new System.Drawing.Size(136, 17);
            this.cbSuscrito.TabIndex = 1;
            this.cbSuscrito.Text = "¿Suscribirse al boletín?";
            this.cbSuscrito.UseVisualStyleBackColor = true;
            // 
            // tpVisualizacion
            // 
            this.tpVisualizacion.Controls.Add(this.lblFecha);
            this.tpVisualizacion.Controls.Add(this.btnCambiarFoto);
            this.tpVisualizacion.Controls.Add(this.lbFechaHora);
            this.tpVisualizacion.Controls.Add(this.labelFecha);
            this.tpVisualizacion.Controls.Add(this.pbImagenPerfil);
            this.tpVisualizacion.Location = new System.Drawing.Point(4, 22);
            this.tpVisualizacion.Margin = new System.Windows.Forms.Padding(2);
            this.tpVisualizacion.Name = "tpVisualizacion";
            this.tpVisualizacion.Padding = new System.Windows.Forms.Padding(2);
            this.tpVisualizacion.Size = new System.Drawing.Size(597, 289);
            this.tpVisualizacion.TabIndex = 2;
            this.tpVisualizacion.Text = "Visualización";
            this.tpVisualizacion.UseVisualStyleBackColor = true;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(280, 129);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(42, 13);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Tiempo";
            // 
            // btnCambiarFoto
            // 
            this.btnCambiarFoto.Location = new System.Drawing.Point(69, 223);
            this.btnCambiarFoto.Name = "btnCambiarFoto";
            this.btnCambiarFoto.Size = new System.Drawing.Size(75, 23);
            this.btnCambiarFoto.TabIndex = 3;
            this.btnCambiarFoto.Text = "Cambiar";
            this.btnCambiarFoto.UseVisualStyleBackColor = true;
            this.btnCambiarFoto.Click += new System.EventHandler(this.btnCambiarFoto_Click);
            // 
            // lbFechaHora
            // 
            this.lbFechaHora.AutoSize = true;
            this.lbFechaHora.Location = new System.Drawing.Point(279, 129);
            this.lbFechaHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFechaHora.Name = "lbFechaHora";
            this.lbFechaHora.Size = new System.Drawing.Size(0, 13);
            this.lbFechaHora.TabIndex = 2;
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(277, 102);
            this.labelFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(112, 13);
            this.labelFecha.TabIndex = 1;
            this.labelFecha.Text = "Fecha y hora actuales";
            // 
            // pbImagenPerfil
            // 
            this.pbImagenPerfil.Location = new System.Drawing.Point(19, 17);
            this.pbImagenPerfil.Margin = new System.Windows.Forms.Padding(2);
            this.pbImagenPerfil.Name = "pbImagenPerfil";
            this.pbImagenPerfil.Size = new System.Drawing.Size(182, 177);
            this.pbImagenPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagenPerfil.TabIndex = 0;
            this.pbImagenPerfil.TabStop = false;
            // 
            // tTemporizador
            // 
            this.tTemporizador.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblFechaCalendario
            // 
            this.lblFechaCalendario.AutoSize = true;
            this.lblFechaCalendario.Location = new System.Drawing.Point(460, 205);
            this.lblFechaCalendario.Name = "lblFechaCalendario";
            this.lblFechaCalendario.Size = new System.Drawing.Size(37, 13);
            this.lblFechaCalendario.TabIndex = 13;
            this.lblFechaCalendario.Text = "Fecha";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(469, 331);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(272, 331);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(71, 331);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 366);
            this.ControlBox = false;
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.tcDatospersonales);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión Avanzada de Información Personal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tcDatospersonales.ResumeLayout(false);
            this.tpDatos.ResumeLayout(false);
            this.tpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.pnRadioB.ResumeLayout(false);
            this.pnRadioB.PerformLayout();
            this.tpPreferencias.ResumeLayout(false);
            this.tpPreferencias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNota)).EndInit();
            this.tpVisualizacion.ResumeLayout(false);
            this.tpVisualizacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenPerfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcDatospersonales;
        private System.Windows.Forms.TabPage tpDatos;
        private System.Windows.Forms.TabPage tpPreferencias;
        private System.Windows.Forms.TabPage tpVisualizacion;
        private System.Windows.Forms.RadioButton rbOtro;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar mcCalendario;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.Label lbEdad;
        private System.Windows.Forms.Panel pnRadioB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox cblHobbies;
        private System.Windows.Forms.CheckBox cbSuscrito;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar tbNota;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbPaises;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.PictureBox pbImagenPerfil;
        private System.Windows.Forms.Timer tTemporizador;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbFechaHora;
        private System.Windows.Forms.Button btnCambiarFoto;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblFechaCalendario;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
    }
}

