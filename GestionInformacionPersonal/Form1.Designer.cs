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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.lbEdad = new System.Windows.Forms.Label();
            this.panelRadioB = new System.Windows.Forms.Panel();
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
            this.tcPreferencias = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.cbPaises = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tcVisualizacion = new System.Windows.Forms.TabPage();
            this.lbFechaHora = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.pbImagenPerfil = new System.Windows.Forms.PictureBox();
            this.tTemporizador = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCambiarFoto = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.tcDatospersonales.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.panelRadioB.SuspendLayout();
            this.tcPreferencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tcVisualizacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // tcDatospersonales
            // 
            this.tcDatospersonales.Controls.Add(this.tabPage1);
            this.tcDatospersonales.Controls.Add(this.tcPreferencias);
            this.tcDatospersonales.Controls.Add(this.tcVisualizacion);
            this.tcDatospersonales.Location = new System.Drawing.Point(2, 2);
            this.tcDatospersonales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tcDatospersonales.Name = "tcDatospersonales";
            this.tcDatospersonales.SelectedIndex = 0;
            this.tcDatospersonales.Size = new System.Drawing.Size(605, 315);
            this.tcDatospersonales.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.monthCalendar1);
            this.tabPage1.Controls.Add(this.nudEdad);
            this.tabPage1.Controls.Add(this.lbEdad);
            this.tabPage1.Controls.Add(this.panelRadioB);
            this.tabPage1.Controls.Add(this.tbDireccion);
            this.tabPage1.Controls.Add(this.tbCorreo);
            this.tabPage1.Controls.Add(this.tbNombre);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(597, 289);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos Personales";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(390, 35);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 12;
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(465, 236);
            this.nudEdad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(90, 20);
            this.nudEdad.TabIndex = 11;
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.Location = new System.Drawing.Point(388, 240);
            this.lbEdad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(32, 13);
            this.lbEdad.TabIndex = 10;
            this.lbEdad.Text = "Edad";
            // 
            // panelRadioB
            // 
            this.panelRadioB.BackColor = System.Drawing.Color.IndianRed;
            this.panelRadioB.Controls.Add(this.label4);
            this.panelRadioB.Controls.Add(this.rbMasculino);
            this.panelRadioB.Controls.Add(this.rbOtro);
            this.panelRadioB.Controls.Add(this.rbFemenino);
            this.panelRadioB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelRadioB.Location = new System.Drawing.Point(82, 148);
            this.panelRadioB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelRadioB.Name = "panelRadioB";
            this.panelRadioB.Size = new System.Drawing.Size(199, 124);
            this.panelRadioB.TabIndex = 9;
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
            this.rbMasculino.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.rbOtro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.rbFemenino.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.tbDireccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(174, 20);
            this.tbDireccion.TabIndex = 5;
            // 
            // tbCorreo
            // 
            this.tbCorreo.Location = new System.Drawing.Point(190, 113);
            this.tbCorreo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(174, 20);
            this.tbCorreo.TabIndex = 4;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(190, 35);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            // tcPreferencias
            // 
            this.tcPreferencias.Controls.Add(this.label7);
            this.tcPreferencias.Controls.Add(this.trackBar1);
            this.tcPreferencias.Controls.Add(this.label6);
            this.tcPreferencias.Controls.Add(this.cbPaises);
            this.tcPreferencias.Controls.Add(this.label5);
            this.tcPreferencias.Controls.Add(this.checkedListBox1);
            this.tcPreferencias.Controls.Add(this.checkBox1);
            this.tcPreferencias.Location = new System.Drawing.Point(4, 22);
            this.tcPreferencias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tcPreferencias.Name = "tcPreferencias";
            this.tcPreferencias.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tcPreferencias.Size = new System.Drawing.Size(597, 289);
            this.tcPreferencias.TabIndex = 1;
            this.tcPreferencias.Text = "Preferencias";
            this.tcPreferencias.UseVisualStyleBackColor = true;
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
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(80, 204);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(416, 45);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Value = 1;
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
            this.cbPaises.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Juegos",
            "Musica",
            "Baile",
            "Programar",
            "UNGA UNGA"});
            this.checkedListBox1.Location = new System.Drawing.Point(250, 63);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(91, 64);
            this.checkedListBox1.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(72, 87);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(136, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "¿Suscribirse al boletín?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tcVisualizacion
            // 
            this.tcVisualizacion.Controls.Add(this.lblFecha);
            this.tcVisualizacion.Controls.Add(this.btnCambiarFoto);
            this.tcVisualizacion.Controls.Add(this.lbFechaHora);
            this.tcVisualizacion.Controls.Add(this.labelFecha);
            this.tcVisualizacion.Controls.Add(this.pbImagenPerfil);
            this.tcVisualizacion.Location = new System.Drawing.Point(4, 22);
            this.tcVisualizacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tcVisualizacion.Name = "tcVisualizacion";
            this.tcVisualizacion.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tcVisualizacion.Size = new System.Drawing.Size(597, 289);
            this.tcVisualizacion.TabIndex = 2;
            this.tcVisualizacion.Text = "Visualización";
            this.tcVisualizacion.UseVisualStyleBackColor = true;
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
            this.pbImagenPerfil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(280, 129);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(42, 13);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Tiempo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 366);
            this.Controls.Add(this.tcDatospersonales);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión Avanzada de Información Personal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tcDatospersonales.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.panelRadioB.ResumeLayout(false);
            this.panelRadioB.PerformLayout();
            this.tcPreferencias.ResumeLayout(false);
            this.tcPreferencias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tcVisualizacion.ResumeLayout(false);
            this.tcVisualizacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenPerfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcDatospersonales;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tcPreferencias;
        private System.Windows.Forms.TabPage tcVisualizacion;
        private System.Windows.Forms.RadioButton rbOtro;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.Label lbEdad;
        private System.Windows.Forms.Panel panelRadioB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbPaises;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.PictureBox pbImagenPerfil;
        private System.Windows.Forms.Timer tTemporizador;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbFechaHora;
        private System.Windows.Forms.Button btnCambiarFoto;
        private System.Windows.Forms.Label lblFecha;
    }
}

