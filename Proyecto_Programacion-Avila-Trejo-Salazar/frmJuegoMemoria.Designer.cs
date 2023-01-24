namespace PaulSalazarJuegoMemoria
{
    partial class frmJuegoMemoria
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
            this.btnJugar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPesadilla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDificil = new System.Windows.Forms.Button();
            this.btnMedio = new System.Windows.Forms.Button();
            this.btnFacil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTextoclick = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblClicks = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblVidas = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(603, 28);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(75, 23);
            this.btnJugar.TabIndex = 0;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(684, 28);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Escapar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(642, 57);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(75, 23);
            this.btnReiniciar.TabIndex = 2;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 355);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPesadilla);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnDificil);
            this.groupBox2.Controls.Add(this.btnMedio);
            this.groupBox2.Controls.Add(this.btnFacil);
            this.groupBox2.Location = new System.Drawing.Point(603, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(156, 212);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnPesadilla
            // 
            this.btnPesadilla.Location = new System.Drawing.Point(19, 155);
            this.btnPesadilla.Name = "btnPesadilla";
            this.btnPesadilla.Size = new System.Drawing.Size(75, 42);
            this.btnPesadilla.TabIndex = 4;
            this.btnPesadilla.Text = "Somnum \r\nexterreri";
            this.btnPesadilla.UseVisualStyleBackColor = true;
            this.btnPesadilla.Click += new System.EventHandler(this.btnPesadilla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dificultad";
            // 
            // btnDificil
            // 
            this.btnDificil.Location = new System.Drawing.Point(19, 116);
            this.btnDificil.Name = "btnDificil";
            this.btnDificil.Size = new System.Drawing.Size(75, 23);
            this.btnDificil.TabIndex = 2;
            this.btnDificil.Text = "Dificil";
            this.btnDificil.UseVisualStyleBackColor = true;
            this.btnDificil.Click += new System.EventHandler(this.btnDificil_Click);
            // 
            // btnMedio
            // 
            this.btnMedio.Location = new System.Drawing.Point(19, 78);
            this.btnMedio.Name = "btnMedio";
            this.btnMedio.Size = new System.Drawing.Size(75, 23);
            this.btnMedio.TabIndex = 1;
            this.btnMedio.Text = "Intermedio";
            this.btnMedio.UseVisualStyleBackColor = true;
            this.btnMedio.Click += new System.EventHandler(this.btnMedio_Click);
            // 
            // btnFacil
            // 
            this.btnFacil.Location = new System.Drawing.Point(19, 49);
            this.btnFacil.Name = "btnFacil";
            this.btnFacil.Size = new System.Drawing.Size(75, 23);
            this.btnFacil.TabIndex = 0;
            this.btnFacil.Text = "Facil";
            this.btnFacil.UseVisualStyleBackColor = true;
            this.btnFacil.Click += new System.EventHandler(this.btnFacil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Juego de la memoria";
            // 
            // lblTextoclick
            // 
            this.lblTextoclick.AutoSize = true;
            this.lblTextoclick.Location = new System.Drawing.Point(622, 125);
            this.lblTextoclick.Name = "lblTextoclick";
            this.lblTextoclick.Size = new System.Drawing.Size(35, 13);
            this.lblTextoclick.TabIndex = 6;
            this.lblTextoclick.Text = "Clicks";
            // 
            // lblClicks
            // 
            this.lblClicks.AutoSize = true;
            this.lblClicks.Location = new System.Drawing.Point(665, 125);
            this.lblClicks.Name = "lblClicks";
            this.lblClicks.Size = new System.Drawing.Size(13, 13);
            this.lblClicks.TabIndex = 7;
            this.lblClicks.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(619, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Vidas";
            // 
            // lblVidas
            // 
            this.lblVidas.AutoSize = true;
            this.lblVidas.Location = new System.Drawing.Point(668, 97);
            this.lblVidas.Name = "lblVidas";
            this.lblVidas.Size = new System.Drawing.Size(13, 13);
            this.lblVidas.TabIndex = 9;
            this.lblVidas.Text = "0";
            // 
            // frmJuegoMemoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblVidas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblClicks);
            this.Controls.Add(this.lblTextoclick);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnJugar);
            this.Name = "frmJuegoMemoria";
            this.Text = "frmJuegoMemoria";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDificil;
        private System.Windows.Forms.Button btnMedio;
        private System.Windows.Forms.Button btnFacil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTextoclick;
        private System.Windows.Forms.Button btnPesadilla;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblClicks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblVidas;
    }
}