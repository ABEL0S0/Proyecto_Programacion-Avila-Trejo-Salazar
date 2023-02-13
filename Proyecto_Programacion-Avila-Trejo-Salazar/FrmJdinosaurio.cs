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
    public partial class FrmJdinosaurio : Form
    {
        int CambioApariencia;
        int PosicionInicialPisoX;
        int PosicionInicialPisoY;
        int velocidad = 5;

        bool BrincoDelDino;
        bool InicioJuego = true;

        Random RnTipoObstaculo;
        List<PictureBox> ListaObstaculo;
        public FrmJdinosaurio()
        {
            InitializeComponent();
        }

        public void IniciarJuego() 
        {
            CambioApariencia= 0;
            BrincoDelDino= false;
            lblPuntuacion.Text = "0";
            RnTipoObstaculo = new Random();
            ListaObstaculo = new List<PictureBox>();

            CrearObstaculo(ListaObstaculo,this);
            PosicionInicialPisoX = 12;
            PosicionInicialPisoY = 197;
            btnReset.Visible=false;
            lblGo.Visible=false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!BrincoDelDino)
            {
                //Animacion del Dino (Caminando)
                Dino.Image=(CambioApariencia==0)? Properties.Resources.dinosaurio3 : Properties.Resources.dinosaurio2;
                CambioApariencia= (CambioApariencia==0)? 1 : 0;
            }
            DetectorChoques.Location = Dino.Location;
        }
        public void CrearObstaculo(List<PictureBox> ListaObstaculos, Form panelJuegoUno)
        {
            int TipoObstaculo = RnTipoObstaculo.Next(1, 3);
            PictureBox pb = new PictureBox();
            int posicioObstaculo = (TipoObstaculo == 1) ? 190 : 201;
            pb.Location = new Point(388, posicioObstaculo);
            pb.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("obstaculo" + TipoObstaculo);
            pb.BackColor = Color.Transparent;
            pb.SizeMode = PictureBoxSizeMode.AutoSize;
            ListaObstaculo.Add(pb);
            panelJuegoUno.Controls.Add(pb);

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //Brinco del Dino
            if(BrincoDelDino)
            {
                Dino.Image = Properties.Resources.dinosaurio1;
                int Brinco = Dino.Location.Y - 10;
                Dino.Location = new Point(Dino.Location.X, Brinco);
                if(Brinco <= 10)
                {
                    BrincoDelDino= false;
                }
            }
            else
            {
                if(Dino.Location.Y<PosicionInicialPisoY)
                {
                    int Brinco = Dino.Location.Y + 5;
                    Dino.Location = new Point(Dino.Location.X, Brinco);
                }
            }
            //Animacion de Correr
            DetectorChoques.Location=Dino.Location;
            int Movimiento = carretera.Location.X- 10;
            carretera.Location = new Point(Movimiento,carretera.Location.Y);

            //Efecto de carretera
            if(carretera.Location.X<-200)
            {
                carretera.Location = new Point(PosicionInicialPisoX,carretera.Location.Y);
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            //Leer todos los obstaculos generados
            for (int i=0;i<ListaObstaculo.Count;i++)
            {
                int MovimientosX;
                MovimientosX = ListaObstaculo[i].Location.X;
                MovimientosX = MovimientosX - velocidad;
                ListaObstaculo[i].Location = new Point(MovimientosX, ListaObstaculo[i].Location.Y);
            }
            //Hay elementos en el Obstaculo
            if (ListaObstaculo.Count>0)
            {
                if (ListaObstaculo[(ListaObstaculo.Count)-1].Location.X < -300)
                {
                    CrearObstaculo(ListaObstaculo,this);
                }
            }
            if(ListaObstaculo.Count>0)
            {
                for (int i = 0; i < ListaObstaculo.Count; i++)
                {
                    if (ListaObstaculo[i].Location.X<-300)//Si el obstaculo ya paso
                    {
                        if (ListaObstaculo[i].Location.X<Dino.Location.X)
                        {
                            lblPuntuacion.Text = Convert.ToString(Convert.ToInt32(lblPuntuacion.Text) + 1);
                            if (lblPuntuacion.Text == "15")
                            {
                                Form f1 = new FrmJdinosaurio();
                                f1.BackColor = Color.DimGray;
                            }
                        }
                        this.Controls.Remove(ListaObstaculo[i]);
                        ListaObstaculo.Remove(ListaObstaculo[i]);
                    }
                    //Si Hay Choques cos los obstaculos
                    if (ListaObstaculo[i].Bounds.IntersectsWith(DetectorChoques.Bounds))
                    {
                        timer1.Stop();
                        timer2.Stop();
                        timer3.Stop();
                        btnReset.Visible = true;
                        lblGo.Visible=true;
                        this.Controls.Remove(ListaObstaculo[i]);
                        ListaObstaculo.Remove(ListaObstaculo[i]);
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            IniciarJuego();
            timer1.Start();
            timer2.Start();
            timer3.Start();
        }

        private void FrmJdinosaurio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar==Convert.ToChar(Keys.Space))&&(BrincoDelDino==false))
            {
                //Iniciar el juego cuando presiona la barra espaciadora
                if(InicioJuego)
                {
                    IniciarJuego();
                    InicioJuego = false;
                    timer1.Enabled = true;
                    timer2.Enabled = true;
                    timer3.Enabled = true;
                }
                if (Dino.Location.Y>=PosicionInicialPisoY)
                {
                    Dino.Image = Properties.Resources.dinosaurio3;
                    BrincoDelDino= true;
                }
            }
        }
    }
}
