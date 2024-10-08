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
            this.tcPreferencias = new System.Windows.Forms.TabPage();
            this.tcVisualizacion = new System.Windows.Forms.TabPage();
            this.tcDatospersonales.SuspendLayout();
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
            this.tcDatospersonales.Size = new System.Drawing.Size(776, 436);
            this.tcDatospersonales.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(744, 377);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos Personales";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcDatospersonales;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tcPreferencias;
        private System.Windows.Forms.TabPage tcVisualizacion;
    }
}

