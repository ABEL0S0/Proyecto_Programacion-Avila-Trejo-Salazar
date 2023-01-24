using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
        public string usuario;
        public void btnIniciar_Click(object sender, EventArgs e)
        {
            if (this.txtUsuario.TextLength == (0) || this.txtContrasenia.TextLength == (0))
            {
                MessageBox.Show("Ingrese Usuario o contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Proyecto_Programacion_Avila_Trejo_Salazar.DAO.UsuariosDao oEst = new Proyecto_Programacion_Avila_Trejo_Salazar.DAO.UsuariosDao();

            usuario = this.txtUsuario.Text;
            string contrasenia=this.txtContrasenia.Text;
            bool x = oEst.InicioSesion(usuario, contrasenia);
            
            if (x == true)
            {
                    MessageBox.Show("Inicio de Sesion exitoso.","Inicializando",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    MDIJuegos menu = new MDIJuegos();
                    this.Hide();
                    menu.Show();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            this.txtContrasenia.Clear();
            this.txtUsuario.Clear();            
        }
       
    }
}
