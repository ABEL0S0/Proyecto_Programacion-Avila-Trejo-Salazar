using System;
using System.Collections;
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
    public partial class FrmJmemoria : Form
    {
        int dimension=4;
        int movimientos = 0;
        int maxmovimientos = 0;
        int CantidadDeCartasVolteadas=0;
        List<string> CartasEnumeradas;
        List<string> CartasRevueltas;
        ArrayList CartasSeleccionadas;
        PictureBox CartaTemporal1;
        PictureBox CartaTemporal2;
        int CartaActual = 0;
        public FrmJmemoria()
        {
            InitializeComponent();
        }
        public void IniciarJuego() 
        {
            timer1.Enabled= false;
            timer1.Stop();
            lblRecord.Text = "0";
            CantidadDeCartasVolteadas = 0;
            movimientos= 0;
            PanelJuego.Controls.Clear();
            CartasEnumeradas = new List<string>();
            CartasRevueltas = new List<string>();
            CartasSeleccionadas = new ArrayList();
            for (int i = 0; i < 8; i++)
            {
                CartasEnumeradas.Add(i.ToString());
                CartasEnumeradas.Add(i.ToString());
            }
            var NumeroRandom = new Random();
            var Resultado = CartasEnumeradas.OrderBy(item => NumeroRandom.Next());
            foreach (string ValorCarta in Resultado)
            {
                CartasRevueltas.Add(ValorCarta);
            }
            var TablaPanel=new TableLayoutPanel();
            TablaPanel.RowCount = dimension;
            TablaPanel.ColumnCount = dimension;
            for (int i = 0; i < dimension; i++)
            {
                var Porcentaje = 150f/(float)dimension-10;
                TablaPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent,Porcentaje));
                TablaPanel.RowStyles.Add(new RowStyle(SizeType.Percent, Porcentaje));
            }
            int ContadorFichas = 1;
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    var CartasJuegos=new PictureBox();
                    CartasJuegos.Name = string.Format("{0}",ContadorFichas);
                    CartasJuegos.Dock= DockStyle.Fill;
                    CartasJuegos.SizeMode = PictureBoxSizeMode.StretchImage;
                    CartasJuegos.Image = Properties.Resources.Girada;
                    CartasJuegos.Cursor= Cursors.Hand;
                    CartasJuegos.Click += btnCarta_Click;
                    TablaPanel.Controls.Add(CartasJuegos,j,i);
                    ContadorFichas++;
                }
            }
            TablaPanel.Dock = DockStyle.Fill;
            PanelJuego.Controls.Add(TablaPanel);
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            PanelJuego.Visible= true;
            MessageBox.Show("Seleccione la dificultad","Dificultad",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            btnFacil.Visible = true;
            btnFacil.Enabled = true;
            btnDificil.Visible = true;
            btnDificil.Enabled = true;
            btnPesadilla.Visible = true;
            btnPesadilla.Enabled = true;
        }
        private void btnCarta_Click(object sender, EventArgs e)
        {
            if (CartasSeleccionadas.Count < 2) 
            { 
                movimientos++;
                lblRecord.Text = Convert.ToString(movimientos);
                var CartasSeleccionadasUsuario = (PictureBox)sender;

                CartaActual = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartasSeleccionadasUsuario.Name)-1]);
                CartasSeleccionadasUsuario.Image = RecuperarImagen(CartaActual);
                CartasSeleccionadas.Add(CartasSeleccionadasUsuario);
                if(CartasSeleccionadas.Count==2)
                {
                    CartaTemporal1 = (PictureBox)CartasSeleccionadas[0];
                    CartaTemporal2 = (PictureBox)CartasSeleccionadas[1];
                    int Carta1 = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartaTemporal1.Name) - 1]);
                    int Carta2 = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartaTemporal2.Name) - 1]);
                    if(Carta1!=Carta2)
                    {
                        timer1.Enabled = true;
                        timer1.Start();
                    }
                    else 
                    {
                        CantidadDeCartasVolteadas++;
                        if(CantidadDeCartasVolteadas>7) 
                        {
                            MessageBox.Show("El Juego Termino","Ganaste",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        CartaTemporal1.Enabled= false;
                        CartaTemporal2.Enabled = false;
                        CartasSeleccionadas.Clear();
                    }
                }
            }
            if(maxmovimientos==movimientos)
            {
                MessageBox.Show("Ya llegaste a los maximos movimientos","PERDISTE",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                PanelJuego.Enabled= false;
                PanelJuego.Visible = false;
                btnStart.Enabled= false;
                btnFacil.Visible = false;
                btnFacil.Enabled = false;
                btnDificil.Visible = false;
                btnDificil.Enabled = false;
                btnPesadilla.Visible = false;
                btnPesadilla.Enabled = false;
            }
        }
        public Bitmap RecuperarImagen(int NumeroImagen)
        {
            Bitmap TmpImg = new Bitmap(200,100);
            switch(CartaActual)
            {
                case 0: TmpImg = Properties.Resources.Imagen11;
                    break;
                default: TmpImg = (Bitmap)Properties.Resources.ResourceManager.GetObject("Imagen"+NumeroImagen);
                    break;
            }
            return TmpImg;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            lblRecord.Text = "0";
            PanelJuego.Visible = false;
            PanelJuego.Enabled= false;
            btnStart_Click(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int TiempoVirarCarta = 1;
            if(TiempoVirarCarta==1)
            {
                CartaTemporal1.Image = Properties.Resources.Girada;
                CartaTemporal2.Image = Properties.Resources.Girada;
                CartasSeleccionadas.Clear();
                TiempoVirarCarta=0;
                timer1.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El juego de la memoria consiste en ir descubriendo parejas de elementos iguales o relacionados entre ellos, que se encuentran escondidos. " +
                "En este caso serian las cartas de Uno","Guía",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnFacil_Click(object sender, EventArgs e)
        {
            maxmovimientos = 100;
            MessageBox.Show($"Tienes un total de {maxmovimientos} movimientos posibles", "Maximos Movimientos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblMaxMov.Text = maxmovimientos.ToString();
            timer1.Interval= 500;
            PanelJuego.Enabled = true;
            btnStart.Enabled = false;
            btnReiniciar.Enabled = true;
            btnFacil.Visible = false;
            btnFacil.Enabled = false;
            btnDificil.Visible = false;
            btnDificil.Enabled = false;
            btnPesadilla.Visible = false;
            btnPesadilla.Enabled = false;
            IniciarJuego();
        }

        private void btnDificil_Click(object sender, EventArgs e)
        {
            maxmovimientos = 44;
            MessageBox.Show($"Tienes un total de {maxmovimientos} movimientos posibles", "Maximos Movimientos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblMaxMov.Text = maxmovimientos.ToString();
            timer1.Interval = 250;
            PanelJuego.Enabled = true;
            btnStart.Enabled = false;
            btnReiniciar.Enabled = true;
            btnFacil.Visible = false;
            btnFacil.Enabled = false;
            btnDificil.Visible = false;
            btnDificil.Enabled = false;
            btnPesadilla.Visible = false;
            btnPesadilla.Enabled = false;
            IniciarJuego();
        }

        private void btnPesadilla_Click(object sender, EventArgs e)
        {
            maxmovimientos = 22;
            MessageBox.Show($"Tienes un total de {maxmovimientos} movimientos posibles", "Maximos Movimientos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblMaxMov.Text = maxmovimientos.ToString();
            timer1.Interval = 100;
            PanelJuego.Enabled = true;
            btnStart.Enabled = false;
            btnReiniciar.Enabled = true;
            btnFacil.Visible = false;
            btnFacil.Enabled = false;
            btnDificil.Visible = false;
            btnDificil.Enabled = false;
            btnPesadilla.Visible = false;
            btnPesadilla.Enabled = false;
            IniciarJuego();
        }

        private void FrmJmemoria_Load(object sender, EventArgs e)
        {

        }
    }
}
