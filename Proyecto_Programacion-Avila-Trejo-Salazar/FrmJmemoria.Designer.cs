namespace Proyecto_Programacion_Avila_Trejo_Salazar
{
    partial class FrmJmemoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PanelJuego = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTematica = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFacil = new System.Windows.Forms.Button();
            this.btnDificil = new System.Windows.Forms.Button();
            this.btnPesadilla = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMaxMov = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PanelJuego
            // 
            this.PanelJuego.Location = new System.Drawing.Point(12, 12);
            this.PanelJuego.Name = "PanelJuego";
            this.PanelJuego.Size = new System.Drawing.Size(496, 339);
            this.PanelJuego.TabIndex = 0;
            this.PanelJuego.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(539, 188);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(181, 42);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Iniciar juego";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Enabled = false;
            this.btnReiniciar.Location = new System.Drawing.Point(539, 138);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(180, 44);
            this.btnReiniciar.TabIndex = 2;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(540, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Movimientos:";
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Location = new System.Drawing.Point(613, 96);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(0, 13);
            this.lblRecord.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTematica
            // 
            this.lblTematica.AutoSize = true;
            this.lblTematica.Location = new System.Drawing.Point(566, 23);
            this.lblTematica.Name = "lblTematica";
            this.lblTematica.Size = new System.Drawing.Size(161, 13);
            this.lblTematica.TabIndex = 0;
            this.lblTematica.Text = "Bienvenido al juego de Memoria ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(585, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Guía";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(566, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "con tematica de cartas de Uno";
            // 
            // btnFacil
            // 
            this.btnFacil.Enabled = false;
            this.btnFacil.Location = new System.Drawing.Point(561, 236);
            this.btnFacil.Name = "btnFacil";
            this.btnFacil.Size = new System.Drawing.Size(142, 36);
            this.btnFacil.TabIndex = 6;
            this.btnFacil.Text = "Facíl";
            this.btnFacil.UseVisualStyleBackColor = true;
            this.btnFacil.Visible = false;
            this.btnFacil.Click += new System.EventHandler(this.btnFacil_Click);
            // 
            // btnDificil
            // 
            this.btnDificil.Enabled = false;
            this.btnDificil.Location = new System.Drawing.Point(561, 278);
            this.btnDificil.Name = "btnDificil";
            this.btnDificil.Size = new System.Drawing.Size(142, 36);
            this.btnDificil.TabIndex = 7;
            this.btnDificil.Text = "Dificil";
            this.btnDificil.UseVisualStyleBackColor = true;
            this.btnDificil.Visible = false;
            this.btnDificil.Click += new System.EventHandler(this.btnDificil_Click);
            // 
            // btnPesadilla
            // 
            this.btnPesadilla.Enabled = false;
            this.btnPesadilla.Location = new System.Drawing.Point(561, 320);
            this.btnPesadilla.Name = "btnPesadilla";
            this.btnPesadilla.Size = new System.Drawing.Size(142, 36);
            this.btnPesadilla.TabIndex = 8;
            this.btnPesadilla.Text = "Pesadilla";
            this.btnPesadilla.UseVisualStyleBackColor = true;
            this.btnPesadilla.Visible = false;
            this.btnPesadilla.Click += new System.EventHandler(this.btnPesadilla_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(540, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Maximos Movimientos:";
            // 
            // lblMaxMov
            // 
            this.lblMaxMov.AutoSize = true;
            this.lblMaxMov.Location = new System.Drawing.Point(659, 115);
            this.lblMaxMov.Name = "lblMaxMov";
            this.lblMaxMov.Size = new System.Drawing.Size(0, 13);
            this.lblMaxMov.TabIndex = 10;
            // 
            // FrmJmemoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 377);
            this.Controls.Add(this.lblMaxMov);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPesadilla);
            this.Controls.Add(this.btnDificil);
            this.Controls.Add(this.btnFacil);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.lblTematica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.PanelJuego);
            this.Name = "FrmJmemoria";
            this.Text = "Juego Memoria";
            this.Load += new System.EventHandler(this.FrmJmemoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelJuego;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTematica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFacil;
        private System.Windows.Forms.Button btnDificil;
        private System.Windows.Forms.Button btnPesadilla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMaxMov;
    }
}