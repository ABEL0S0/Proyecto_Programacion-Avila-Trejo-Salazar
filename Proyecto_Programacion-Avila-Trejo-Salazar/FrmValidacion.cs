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
    }
}
