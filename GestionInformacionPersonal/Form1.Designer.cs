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
            this.tcDatospersonales = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.lbEdad = new System.Windows.Forms.Label();
            this.panelRadioB = new System.Windows.Forms.Panel();
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
            this.tcVisualizacion = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.tcDatospersonales.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.panelRadioB.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcDatospersonales
            // 
            this.tcDatospersonales.Controls.Add(this.tabPage1);
            this.tcDatospersonales.Controls.Add(this.tcPreferencias);
            this.tcDatospersonales.Controls.Add(this.tcVisualizacion);
            this.tcDatospersonales.Location = new System.Drawing.Point(12, 2);
            this.tcDatospersonales.Name = "tcDatospersonales";
            this.tcDatospersonales.SelectedIndex = 0;
            this.tcDatospersonales.Size = new System.Drawing.Size(776, 382);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 353);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos Personales";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(520, 43);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 12;
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(620, 290);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(120, 22);
            this.nudEdad.TabIndex = 11;
            this.nudEdad.ValueChanged += new System.EventHandler(this.nudEdad_ValueChanged);
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.Location = new System.Drawing.Point(517, 296);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(40, 16);
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
            this.panelRadioB.Location = new System.Drawing.Point(109, 182);
            this.panelRadioB.Name = "panelRadioB";
            this.panelRadioB.Size = new System.Drawing.Size(265, 153);
            this.panelRadioB.TabIndex = 9;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(145, 23);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(89, 20);
            this.rbMasculino.TabIndex = 6;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbOtro
            // 
            this.rbOtro.AutoSize = true;
            this.rbOtro.Location = new System.Drawing.Point(146, 110);
            this.rbOtro.Name = "rbOtro";
            this.rbOtro.Size = new System.Drawing.Size(53, 20);
            this.rbOtro.TabIndex = 8;
            this.rbOtro.TabStop = true;
            this.rbOtro.Text = "Otro";
            this.rbOtro.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(146, 65);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(88, 20);
            this.rbFemenino.TabIndex = 7;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(254, 91);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(231, 22);
            this.tbDireccion.TabIndex = 5;
            // 
            // tbCorreo
            // 
            this.tbCorreo.Location = new System.Drawing.Point(254, 139);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(231, 22);
            this.tbCorreo.TabIndex = 4;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(254, 43);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(231, 22);
            this.tbNombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Correo Electronico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dirección";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // tcPreferencias
            // 
            this.tcPreferencias.Location = new System.Drawing.Point(4, 25);
            this.tcPreferencias.Name = "tcPreferencias";
            this.tcPreferencias.Padding = new System.Windows.Forms.Padding(3);
            this.tcPreferencias.Size = new System.Drawing.Size(768, 407);
            this.tcPreferencias.TabIndex = 1;
            this.tcPreferencias.Text = "Preferencias";
            this.tcPreferencias.UseVisualStyleBackColor = true;
            // 
            // tcVisualizacion
            // 
            this.tcVisualizacion.Location = new System.Drawing.Point(4, 25);
            this.tcVisualizacion.Name = "tcVisualizacion";
            this.tcVisualizacion.Padding = new System.Windows.Forms.Padding(3);
            this.tcVisualizacion.Size = new System.Drawing.Size(768, 407);
            this.tcVisualizacion.TabIndex = 2;
            this.tcVisualizacion.Text = "Visualización";
            this.tcVisualizacion.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Genero";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcDatospersonales);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión Avanzada de Información Personal";
            this.tcDatospersonales.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.panelRadioB.ResumeLayout(false);
            this.panelRadioB.PerformLayout();
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
    }
}

