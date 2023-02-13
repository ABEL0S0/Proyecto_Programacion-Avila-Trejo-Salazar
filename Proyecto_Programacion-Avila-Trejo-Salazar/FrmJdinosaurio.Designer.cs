namespace Proyecto_Programacion_Avila_Trejo_Salazar
{
    partial class FrmJdinosaurio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJdinosaurio));
            this.lblGo = new System.Windows.Forms.Label();
            this.lblPuntuacion = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.carretera = new System.Windows.Forms.PictureBox();
            this.Dino = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.PictureBox();
            this.DetectorChoques = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.carretera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetectorChoques)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGo
            // 
            this.lblGo.AutoSize = true;
            this.lblGo.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGo.ForeColor = System.Drawing.Color.Black;
            this.lblGo.Location = new System.Drawing.Point(110, 58);
            this.lblGo.Name = "lblGo";
            this.lblGo.Size = new System.Drawing.Size(186, 22);
            this.lblGo.TabIndex = 5;
            this.lblGo.Text = "GAME OVER";
            this.lblGo.Visible = false;
            // 
            // lblPuntuacion
            // 
            this.lblPuntuacion.AutoSize = true;
            this.lblPuntuacion.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntuacion.Location = new System.Drawing.Point(335, 5);
            this.lblPuntuacion.Name = "lblPuntuacion";
            this.lblPuntuacion.Size = new System.Drawing.Size(26, 22);
            this.lblPuntuacion.TabIndex = 6;
            this.lblPuntuacion.Text = "--";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // carretera
            // 
            this.carretera.Image = global::Proyecto_Programacion_Avila_Trejo_Salazar.Properties.Resources.pisodi;
            this.carretera.Location = new System.Drawing.Point(12, 267);
            this.carretera.Name = "carretera";
            this.carretera.Size = new System.Drawing.Size(596, 35);
            this.carretera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carretera.TabIndex = 4;
            this.carretera.TabStop = false;
            // 
            // Dino
            // 
            this.Dino.Image = ((System.Drawing.Image)(resources.GetObject("Dino.Image")));
            this.Dino.Location = new System.Drawing.Point(33, 197);
            this.Dino.Name = "Dino";
            this.Dino.Size = new System.Drawing.Size(65, 70);
            this.Dino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dino.TabIndex = 3;
            this.Dino.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Image = global::Proyecto_Programacion_Avila_Trejo_Salazar.Properties.Resources.boton;
            this.btnReset.Location = new System.Drawing.Point(165, 83);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(73, 62);
            this.btnReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnReset.TabIndex = 2;
            this.btnReset.TabStop = false;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // DetectorChoques
            // 
            this.DetectorChoques.Location = new System.Drawing.Point(55, 192);
            this.DetectorChoques.Name = "DetectorChoques";
            this.DetectorChoques.Size = new System.Drawing.Size(21, 70);
            this.DetectorChoques.TabIndex = 0;
            this.DetectorChoques.TabStop = false;
            // 
            // FrmJdinosaurio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(417, 294);
            this.Controls.Add(this.lblPuntuacion);
            this.Controls.Add(this.lblGo);
            this.Controls.Add(this.carretera);
            this.Controls.Add(this.Dino);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.DetectorChoques);
            this.Name = "FrmJdinosaurio";
            this.Text = "FrmJdinosaurio";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmJdinosaurio_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.carretera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetectorChoques)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DetectorChoques;
        private System.Windows.Forms.PictureBox btnReset;
        private System.Windows.Forms.PictureBox Dino;
        private System.Windows.Forms.PictureBox carretera;
        private System.Windows.Forms.Label lblGo;
        private System.Windows.Forms.Label lblPuntuacion;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}