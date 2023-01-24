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
    public partial class FrmValidacion : Form
    {
        public FrmValidacion()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f1= new FrmRegistrarse();
            this.Hide();
            f1.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                Proyecto_Programacion_Avila_Trejo_Salazar.DAO.UsuariosDao oEst = new Proyecto_Programacion_Avila_Trejo_Salazar.DAO.UsuariosDao();

            string usuario = this.txtUsuario.Text;
            string contrasenia=this.txtContrasenia.Text;
            bool x = oEst.InicioSesion(usuario, contrasenia);
            
            if (x == true)
            {
                MessageBox.Show("Inicio de Sesion exitoso.",":^)");
            }
            else
            {
                MessageBox.Show("No se pudo iniciar sesion.", "Advertencia");
            }
            }catch(Exception ex) {MessageBox.Show(ex.Message); }
        }
    }
}
