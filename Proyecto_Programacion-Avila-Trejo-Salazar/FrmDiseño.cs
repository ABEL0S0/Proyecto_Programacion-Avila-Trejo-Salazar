using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Programacion_Avila_Trejo_Salazar
{
    public partial class FrmDiseño : Form
    {
        public FrmDiseño()
        {
            InitializeComponent();
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.Left = 50;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.Left = 15;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.Left = 50;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.Left = 15;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FrmRegistrarse Registrado = new FrmRegistrarse();
            Registrado.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmValidacion validate = new FrmValidacion();
            validate.Show();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tienes que iniciar sesión para poder disfrutar de el juego de la memoria");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tienes que iniciar sesión para poder disfrutar de el juego del dinosaurio");
        }
    }
}
