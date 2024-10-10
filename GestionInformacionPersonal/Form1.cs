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
            OpenFileDialog imagen = new OpenFileDialog();
            imagen.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png";
            imagen.ShowDialog();
            string ruta = imagen.FileName;
            pbImagenPerfil.Image = Image.FromFile(ruta);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblFechaCalendario.Text = mcCalendario.SelectionStart.ToString("dd/MM/yy");
        }

                                    //Botones
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (TabPage tp in tcDatospersonales.TabPages)
            {
                foreach (Control c in tp.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Clear();
                    }
                    if (c is ComboBox)
                    {
                        ((ComboBox)c).SelectedIndex = -1;
                    }
                    if (c is PictureBox)
                    {
                        ((PictureBox)c).Image = null;
                    }
                    if (c is MonthCalendar)
                    {
                        ((MonthCalendar)c).SetDate(DateTime.Now);
                    }
                    if (c is CheckBox)
                    {
                        ((CheckBox)c).Checked = false;
                    }
                    if (c is RadioButton)
                    {
                        ((RadioButton)c).Checked = false;
                    }
                    if (c is TrackBar)
                    {
                        ((TrackBar)c).Value = 1;
                    }
                    if (c is NumericUpDown)
                    {
                        ((NumericUpDown)c).Value = 0;
                    }
                    if (c is CheckedListBox)
                    {
                        CheckedListBox clb = (CheckedListBox)c;
                        for (int i = 0; i < clb.Items.Count; i++)
                        {
                            clb.SetItemChecked(i, false);
                        }
                    }
                    if (c is Panel)
                    {
                        rbFemenino.Checked = false;
                        rbMasculino.Checked = false;
                        rbOtro.Checked = false;
                    }
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string hobbies = "";
            foreach (object item in cblHobbies.CheckedItems)
            {
                hobbies += item.ToString() + ", ";
            }

            MessageBox.Show("Datos Personales -----> " +
                "\n-Nombre : " + tbNombre.Text +
                "\n-Dirección : " + tbDireccion.Text +
                "\n-Correo : " + tbCorreo.Text +
                "\n-Genero : " + (rbFemenino.Checked ? "Femenino" : rbMasculino.Checked ? "Masculino" : "Otro") +
                "\n-Edad : " + nudEdad.Value +
                "\n-Fecha Nacimiento : " + mcCalendario.SelectionStart.ToString("dd/MM/yy") +
                "\nPreferencias ------> " +
                "\n¿Suscrito? : " + (cbSuscrito.Checked ? "Sí" : "No") +
                "\nHobbies : " + hobbies +
                "\nPais : " + cbPaises.SelectedItem +
                "\nNota de la Aplicación : " + tbNota.Value +
                "\nVisualización -----> " +
                "\nFoto : " + (pbImagenPerfil.Image != null ? "Sí" : "No") +
                "\nFecha informe : " + lblFecha.Text
                );
        }
    }
}
