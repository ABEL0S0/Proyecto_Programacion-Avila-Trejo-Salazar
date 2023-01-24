using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaulSalazarJuegoMemoria
{
    public partial class frmJuegoMemoria : Form
    {
        int TamanioColumnasFilas = 4;
        int Movimientos = 0;
        int CantidadDeCartasVolteadas = 0;
        List<string> CartasEnumeradas;
        List<string> CartasRevueltas;
        ArrayList CartasSeleccionadas;
        PictureBox CartaTemporal1;
        PictureBox CartaTemporal2;
        int CartaActual = 0;
        int NivelDificultad = 0;
        int fallosPermitidos = 0;
        int vidas = 0;

        public frmJuegoMemoria()
        {
            
            InitializeComponent();
            groupBox1.Enabled = false;
            btnFacil.Enabled = false;
            btnMedio.Enabled = false;
            btnDificil.Enabled = false;
            btnPesadilla.Enabled = false;
            btnJugar.Enabled = true;
            btnReiniciar.Enabled = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("O prefieres seguir", "Mejor usa la X para cerrar", MessageBoxButtons.YesNo);
            if(resultado== DialogResult.Yes)
            {
                groupBox1.Enabled= false;
                Application.Restart();
            }
            else
            if (resultado == DialogResult.No)
            {
                groupBox1.Enabled= false;
                
            }
           
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            this.groupBox1.Controls.Clear();
            groupBox1.Enabled = true;
            btnFacil.Enabled = true;
            btnMedio.Enabled = true;
            btnDificil.Enabled = true;
            btnPesadilla.Enabled = true;
            btnJugar.Enabled = false;

        }


        public void iniciarJuego(int vidas)
        {
            this.vidas = vidas;
            lblVidas.Text = vidas.ToString();
            timer1.Enabled = false;
            timer1.Stop();
            lblClicks.Text = "0";
            CantidadDeCartasVolteadas = 0;
            Movimientos = 0;
            groupBox1.Controls.Clear();
            CartasEnumeradas = new List<string>();
            CartasRevueltas = new List<string>();
            CartasSeleccionadas = new ArrayList();
            for (int i = 0; i < 8; i++)
            {
                CartasEnumeradas.Add(i.ToString());
                CartasEnumeradas.Add(i.ToString());
            }
            var NumeroAleatorio = new Random();
            var Resultado = CartasEnumeradas.OrderBy(item => NumeroAleatorio.Next());
            foreach (string ValorCarta in Resultado)
            {
                CartasRevueltas.Add(ValorCarta);
            }
            var tablaPanel = new TableLayoutPanel();
            tablaPanel.RowCount = TamanioColumnasFilas;
            tablaPanel.ColumnCount = TamanioColumnasFilas;
            for (int i = 0; i < TamanioColumnasFilas; i++)
            {
                var Porcentaje = 150f / (float)TamanioColumnasFilas - 10;
                tablaPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, Porcentaje));
                tablaPanel.RowStyles.Add(new RowStyle(SizeType.Percent, Porcentaje));
            }
            int contadorFichas = 1;

            for (var i = 0; i < TamanioColumnasFilas; i++)
            {
                for (var j = 0; j < TamanioColumnasFilas; j++)
                {
                    var CartasJuego = new PictureBox();
                    CartasJuego.Name = string.Format("{0}", contadorFichas);
                    CartasJuego.Dock = DockStyle.Fill;
                    CartasJuego.SizeMode = PictureBoxSizeMode.StretchImage;
                    CartasJuego.Image = Properties.Resources.Girada;
                    CartasJuego.Cursor = Cursors.Hand;
                    CartasJuego.Click += btnCarta_Click;
                    tablaPanel.Controls.Add(CartasJuego, j, i);
                    contadorFichas++;
                }
            }
            tablaPanel.Dock = DockStyle.Fill;
            groupBox1.Controls.Add(tablaPanel);


        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            vidas--;
            lblVidas.Text = vidas.ToString();
            if (vidas > 0)
            {
                iniciarJuego(vidas);
            }
            else
            {
                MessageBox.Show("Perdiste, te quedan: " + vidas + " vidas!");
                Application.Exit();
            }

            /*
            DialogResult resultado = MessageBox.Show("¿Deseas reiniciar el juego?", "Reiniciar", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                groupBox1.Controls.Clear();
                iniciarJuego(vidas);
                vidas = fallosPermitidos;
                lblVidas.Text = vidas.ToString();
                NivelDificultad = 0;
                fallosPermitidos = 0;
                btnFacil.Enabled = false;
                btnMedio.Enabled = false;
                btnDificil.Enabled = false;
                btnPesadilla.Enabled = false;
                btnJugar.Enabled = true;
                btnReiniciar.Enabled = false;

            }
            else
            {
                groupBox1.Enabled = false;
            }
            */
        }





        private void btnCarta_Click(object sender, EventArgs e)
        {
            //desactivar el control de la imagen 
            foreach (Control control in groupBox1.Controls)
            {
                if (control is PictureBox)
                {
                    control.Enabled = false;
                }
            }

            //Acciones del evento
            if (Convert.ToInt32(lblClicks.Text) == fallosPermitidos)
            {
                MessageBox.Show("Se acabaron tus intentos. ¡Fin del juego!");
                groupBox1.Enabled = false;
            }

            if (CartasSeleccionadas.Count < 2)
            {
                Movimientos++;
                lblClicks.Text = Convert.ToString(Movimientos);
                var CartasSeleccionadasUsuario = (PictureBox)sender;

                CartaActual = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartasSeleccionadasUsuario.Name) - 1]);
                CartasSeleccionadasUsuario.Image = RecuperarImagen(CartaActual);
                CartasSeleccionadas.Add(CartasSeleccionadasUsuario);
                //  2 Veces se realizo el evento del click
                if (CartasSeleccionadas.Count == 2)
                {
                    CartaTemporal1 = (PictureBox)CartasSeleccionadas[0];
                    CartaTemporal2 = (PictureBox)CartasSeleccionadas[1];
                    int Carta1 = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartaTemporal1.Name) - 1]);
                    int Carta2 = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartaTemporal2.Name) - 1]);

                    if (Carta1 != Carta2)
                    {
                        timer1.Enabled = true;
                        timer1.Start();
                    }
                    else
                    {
                        CantidadDeCartasVolteadas++;
                        if (CantidadDeCartasVolteadas > 7)
                        {
                            MessageBox.Show("El juego termino");
                        }
                        CartaTemporal1.Enabled = false; CartaTemporal2.Enabled = false;
                        CartasSeleccionadas.Clear();

                    }
                }

            }
        }

        public Bitmap RecuperarImagen(int NumeroImagen)
        {
            Bitmap TmpImg = new Bitmap(200, 100);
            switch (NumeroImagen)
            {
                case 0:
                    TmpImg = Properties.Resources.Imagen8;
                    break;
                default:
                    TmpImg = (Bitmap)Properties.Resources.ResourceManager.GetObject("Imagen" + NumeroImagen);
                    break;
            }
            return TmpImg;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int TiempoVirarCarta = 1;
            if (TiempoVirarCarta == 1)
            {
                CartaTemporal1.Image = Properties.Resources.Girada;
                CartaTemporal2.Image = Properties.Resources.Girada;
                CartasSeleccionadas.Clear();
                TiempoVirarCarta = 0;
                timer1.Stop();

            }
        }

        private void btnFacil_Click(object sender, EventArgs e)
        {
            /*
            // Establecer la dificultad en fácil
            NivelDificultad = "Facil";

            // Mostrar un mensaje indicando que se ha seleccionado el nivel fácil
            MessageBox.Show("Nivel de dificultad seleccionado: Fácil. Puedes fallar 3 veces");

            // Establecer el numero de fallos permitidos
            fallosPermitidos = 10;
            */
            NivelDificultad = 1;
            fallosPermitidos = 16; // estos son los clicks
            MessageBox.Show("Has seleccionado el nivel Facil, tendrás " + fallosPermitidos + " fallos permitidos.");
            vidas = fallosPermitidos;
            lblVidas.Text = vidas.ToString();
            btnFacil.Enabled = false;
            btnMedio.Enabled = false;
            btnDificil.Enabled = false;
            btnPesadilla.Enabled = false;
            btnReiniciar.Enabled = true;
            iniciarJuego(10);
        }

        private void btnMedio_Click(object sender, EventArgs e)
        {
            /* Establecer la dificultad en Medio
            NivelDificultad = "Medio";

            // Mostrar un mensaje indicando que se ha seleccionado el nivel Medio
            MessageBox.Show("Nivel de dificultad seleccionado: Medio. Puedes fallar 2 veces");

            // Establecer el numero de fallos permitidos
            fallosPermitidos = 5;
            */
            
            NivelDificultad = 1;
            fallosPermitidos = 16; // estos son los clicks
            MessageBox.Show("Has seleccionado el nivel Medio, tendrás " + fallosPermitidos + " fallos permitidos.");
            vidas = fallosPermitidos;
            lblVidas.Text = vidas.ToString();
            btnFacil.Enabled = false;
            btnMedio.Enabled = false;
            btnDificil.Enabled = false;
            btnPesadilla.Enabled = false;
            btnReiniciar.Enabled = true;
            iniciarJuego(5);
        }

        private void btnDificil_Click(object sender, EventArgs e)
        {
            /* Establecer la dificultad en Dificil
            NivelDificultad = "Dificil";

            // Mostrar un mensaje indicando que se ha seleccionado el nivel Dificil
            MessageBox.Show("Nivel de dificultad seleccionado: Difícil. Puedes fallar solo 1 vez");

            // Establecer el numero de fallos permitidos
            fallosPermitidos = 3;
            */
            NivelDificultad = 1;
            fallosPermitidos = 12; // estos son los clicks
            MessageBox.Show("Has seleccionado el nivel Dificil, tendrás " + fallosPermitidos + " fallos permitidos.");
            vidas = fallosPermitidos;
            lblVidas.Text = vidas.ToString();
            btnFacil.Enabled = false;
            btnMedio.Enabled = false;
            btnDificil.Enabled = false;
            btnPesadilla.Enabled = false;
            btnReiniciar.Enabled = true;
            iniciarJuego(3);

        }

        private void btnPesadilla_Click(object sender, EventArgs e)
        {
            /* Establecer la dificultad en Dificil
            NivelDificultad = "Pesadilla";

            // Mostrar un mensaje indicando que se ha seleccionado el nivel Dificil
            MessageBox.Show("Nivel de dificultad seleccionado: Pesadilla. Puedes fallar solo 1 vez");

            // Establecer el numero de fallos permitidos
            fallosPermitidos = 1;
            /*else
            {
                MessageBox.Show("Perdistes, este nivel es para los que arriesgan todo");
                Application.Exit();
            }
            */
            NivelDificultad = 1;
            fallosPermitidos = 12; // estos son los clicks
            MessageBox.Show("Has cometido un herror acabas de seleccionar el nivel Pesadilla, tendrás " + fallosPermitidos + " fallos permitidos.");
            vidas = fallosPermitidos;
            lblVidas.Text = vidas.ToString();
            btnFacil.Enabled = false;
            btnMedio.Enabled = false;
            btnDificil.Enabled = false;
            btnPesadilla.Enabled = false;
            btnReiniciar.Enabled = true;
            iniciarJuego(1);

        }




    }
}
