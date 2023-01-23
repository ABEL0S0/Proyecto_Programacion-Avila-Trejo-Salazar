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
    public partial class FrmRegistrarse : Form
    {
        public FrmRegistrarse()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form f1 = new FrmValidacion();
            f1.Show();
            this.Close();
        }

        private void txtContrasenia_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (this.txtApellidos.TextLength == (0) || this.txtUsuario.TextLength == (0) || this.txtContrasenia.TextLength == (0) || this.txtNombres.TextLength == (0))
            {
                MessageBox.Show("Ingrese los datos en todos los campos", "Advertencia");
                return;
            }
            try
            {
                Proyecto_Programacion_Avila_Trejo_Salazar.DAO.Usuarios est = new Proyecto_Programacion_Avila_Trejo_Salazar.DAO.Usuarios();

                est.Nombres = this.txtNombres.Text;
                est.Apellidos = this.txtApellidos.Text;
                est.Usuario = this.txtUsuario.Text;                                
                est.Contrasenia = this.txtContrasenia.Text;

                Proyecto_Programacion_Avila_Trejo_Salazar.DAO.UsuariosDao objUsuario = new Proyecto_Programacion_Avila_Trejo_Salazar.DAO.UsuariosDao();
                
                //llamo al metodo para guardar el registro
                int X = objUsuario.Registrar(est);
                if (X > 0)
                {
                    MessageBox.Show("Usuario agregado con exito.");
                    this.txtApellidos.Clear();
                    this.txtContrasenia.Clear();
                    this.txtNombres.Clear();
                    this.txtUsuario.Clear();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar al Usuario.", "Advertencia");
                }
            }
            catch (Exception x)
            { MessageBox.Show(x.Message.ToString()); }
           
        }
    }
}
