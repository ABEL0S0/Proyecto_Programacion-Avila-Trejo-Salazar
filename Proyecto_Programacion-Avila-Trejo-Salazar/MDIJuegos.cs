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
    public partial class MDIJuegos : Form 
    {
        private int childFormNumber = 0;

        public MDIJuegos()
        {
            InitializeComponent();
            FrmValidacion frmValidacion = new FrmValidacion();
            string usuario = frmValidacion.usuario;
            this.Text = $"Bienvenido: {usuario}";
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }



        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro de cerrar sesion?", "Confirmación", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // El usuario ha seleccionado "Sí"
                // Procesar la acción para guardar los cambios
                Form form = new FrmValidacion();
                form.Show();
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                // El usuario ha seleccionado "No"
                // No se realizarán cambios
            }
        }

        private void MDIJuegos_Load(object sender, EventArgs e)
        {
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que quiere Salir? (Se cerrara la sesion automaticamente)", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // El usuario ha seleccionado "Sí"
                // Procesar la acción para guardar los cambios
                Application.Exit();
            }
            else if (result == DialogResult.No)
            {
                // El usuario ha seleccionado "No"
                // No se realizarán cambios
            }
        }

        private void juegoDeLaMemoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new FrmJmemoria();
            childForm.MdiParent = this;
            this.Size = new Size(917, 501);
            childForm.Show();
        }

        private void dinosaurioGoogleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new FrmJdinosaurio();
            childForm.MdiParent = this;
            this.Size = new Size(917, 501);
            childForm.Show();
        }
    }
}
