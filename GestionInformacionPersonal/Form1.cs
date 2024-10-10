using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionInformacionPersonal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tTemporizador.Start();

            string[] paises = { "España", "Bolivia", "Francia", "Chile", "Alemania", "Ecuador", "Eduardo", "Perú", "Alfredo", "Venezuela" };
            cbPaises.Items.AddRange(paises);
        }

        private void btnCambiarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png";
            dialogo.ShowDialog();
            string ruta = dialogo.FileName;
            pbImagenPerfil.Image = Image.FromFile(ruta);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblFechaCalendario.Text = monthCalendar1.SelectionStart.ToString("dd/MM/yy");
        }
    }
}
