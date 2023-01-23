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

        private async void btnIniciar_Click(object sender, EventArgs e)
        {
            Proyecto_Programacion_Avila_Trejo_Salazar.DAO.UsuariosDao oEst = new Proyecto_Programacion_Avila_Trejo_Salazar.DAO.UsuariosDao();

            string usuario = this.txtUsuario.Text;
            string contrasenia=this.txtContrasenia.Text;
            DataTable dt = oEst.InicioSesion(usuario, contrasenia);            
            //recorro los datos recuperados
            foreach (DataRow fila in dt.Rows)
            {
                this.txtUsuario.Text = fila["Usuario"].ToString();
                this.txtContrasenia.Text = fila["Contrasenia"].ToString();                
            }
            int x = dt.Rows.Count;
            if (x > 0)
            {
                MessageBox.Show("Inicio de Sesion exitoso.",":^)");
            }
            else
            {
                MessageBox.Show("No se pudo iniciar sesion.", "Advertencia");
            }

        }
    }
}
