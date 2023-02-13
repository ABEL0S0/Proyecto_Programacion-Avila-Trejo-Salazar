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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJmemoria));
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
            resources.ApplyResources(this.PanelJuego, "PanelJuego");
            this.PanelJuego.Name = "PanelJuego";
            // 
            // btnStart
            // 
            resources.ApplyResources(this.btnStart, "btnStart");
            this.btnStart.Name = "btnStart";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReiniciar
            // 
            resources.ApplyResources(this.btnReiniciar, "btnReiniciar");
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lblRecord
            // 
            resources.ApplyResources(this.lblRecord, "lblRecord");
            this.lblRecord.Name = "lblRecord";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTematica
            // 
            resources.ApplyResources(this.lblTematica, "lblTematica");
            this.lblTematica.Name = "lblTematica";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnFacil
            // 
            resources.ApplyResources(this.btnFacil, "btnFacil");
            this.btnFacil.Name = "btnFacil";
            this.btnFacil.UseVisualStyleBackColor = true;
            this.btnFacil.Click += new System.EventHandler(this.btnFacil_Click);
            // 
            // btnDificil
            // 
            resources.ApplyResources(this.btnDificil, "btnDificil");
            this.btnDificil.Name = "btnDificil";
            this.btnDificil.UseVisualStyleBackColor = true;
            this.btnDificil.Click += new System.EventHandler(this.btnDificil_Click);
            // 
            // btnPesadilla
            // 
            resources.ApplyResources(this.btnPesadilla, "btnPesadilla");
            this.btnPesadilla.Name = "btnPesadilla";
            this.btnPesadilla.UseVisualStyleBackColor = true;
            this.btnPesadilla.Click += new System.EventHandler(this.btnPesadilla_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // lblMaxMov
            // 
            resources.ApplyResources(this.lblMaxMov, "lblMaxMov");
            this.lblMaxMov.Name = "lblMaxMov";
            // 
            // FrmJmemoria
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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