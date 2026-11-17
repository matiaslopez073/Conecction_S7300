namespace Conecction_S7300
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BTNConexion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.Preformas0 = new System.Windows.Forms.Label();
            this.Preformas1 = new System.Windows.Forms.Label();
            this.Preformas3 = new System.Windows.Forms.Label();
            this.Preformas2 = new System.Windows.Forms.Label();
            this.Sopladora0 = new System.Windows.Forms.Label();
            this.Sopladora1 = new System.Windows.Forms.Label();
            this.Llenadora0 = new System.Windows.Forms.Label();
            this.Llenadora1 = new System.Windows.Forms.Label();
            this.Carbonatador0 = new System.Windows.Forms.Label();
            this.Checkmat0 = new System.Windows.Forms.Label();
            this.Codificador0 = new System.Windows.Forms.Label();
            this.TTEB1_0 = new System.Windows.Forms.Label();
            this.TTEB1_1 = new System.Windows.Forms.Label();
            this.TTEB1_2 = new System.Windows.Forms.Label();
            this.Etiquetadora0 = new System.Windows.Forms.Label();
            this.TTEB2_0 = new System.Windows.Forms.Label();
            this.TTEB2_1 = new System.Windows.Forms.Label();
            this.TTEB2_2 = new System.Windows.Forms.Label();
            this.TTEB2_3 = new System.Windows.Forms.Label();
            this.TTEB2_4 = new System.Windows.Forms.Label();
            this.Horno0 = new System.Windows.Forms.Label();
            this.TTP_0 = new System.Windows.Forms.Label();
            this.TTP_1 = new System.Windows.Forms.Label();
            this.Paletizadora0 = new System.Windows.Forms.Label();
            this.Paletizadora1 = new System.Windows.Forms.Label();
            this.Paletizadora2 = new System.Windows.Forms.Label();
            this.Envolvedora0 = new System.Windows.Forms.Label();
            this.Impresora0 = new System.Windows.Forms.Label();
            this.TTP_2 = new System.Windows.Forms.Label();
            this.LlenadoraVel = new System.Windows.Forms.Label();
            this.BotellasProducidas = new System.Windows.Forms.Label();
            this.BotellasRechazadas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // BTNConexion
            // 
            this.BTNConexion.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.BTNConexion, "BTNConexion");
            this.BTNConexion.ForeColor = System.Drawing.Color.Black;
            this.BTNConexion.Name = "BTNConexion";
            this.BTNConexion.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.pictureBox5.Image = global::Conecction_S7300.Properties.Resources.minimizar_signo;
            resources.ApplyResources(this.pictureBox5, "pictureBox5");
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.PictureBox5_Click);
            this.pictureBox5.MouseEnter += new System.EventHandler(this.PictureBox5_MouseEnter);
            this.pictureBox5.MouseLeave += new System.EventHandler(this.PictureBox5_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Conecction_S7300.Properties.Resources.configuracion;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.PictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.PictureBox1_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Conecction_S7300.Properties.Resources.salida;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.PictureBox2_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.PictureBox2_MouseLeave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Conecction_S7300.Properties.Resources.minimizar;
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.PictureBox4_Click);
            this.pictureBox4.MouseEnter += new System.EventHandler(this.PictureBox4_MouseEnter);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.PictureBox4_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Conecction_S7300.Properties.Resources.maximizar__1_;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            this.pictureBox3.MouseEnter += new System.EventHandler(this.PictureBox3_MouseEnter);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.PictureBox3_MouseLeave);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::Conecction_S7300.Properties.Resources.Fondo;
            resources.ApplyResources(this.pictureBox6, "pictureBox6");
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.TabStop = false;
            // 
            // Preformas0
            // 
            resources.ApplyResources(this.Preformas0, "Preformas0");
            this.Preformas0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Preformas0.Name = "Preformas0";
            // 
            // Preformas1
            // 
            resources.ApplyResources(this.Preformas1, "Preformas1");
            this.Preformas1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Preformas1.Name = "Preformas1";
            // 
            // Preformas3
            // 
            resources.ApplyResources(this.Preformas3, "Preformas3");
            this.Preformas3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Preformas3.Name = "Preformas3";
            // 
            // Preformas2
            // 
            resources.ApplyResources(this.Preformas2, "Preformas2");
            this.Preformas2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Preformas2.Name = "Preformas2";
            // 
            // Sopladora0
            // 
            resources.ApplyResources(this.Sopladora0, "Sopladora0");
            this.Sopladora0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Sopladora0.Name = "Sopladora0";
            // 
            // Sopladora1
            // 
            resources.ApplyResources(this.Sopladora1, "Sopladora1");
            this.Sopladora1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Sopladora1.Name = "Sopladora1";
            // 
            // Llenadora0
            // 
            resources.ApplyResources(this.Llenadora0, "Llenadora0");
            this.Llenadora0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Llenadora0.Name = "Llenadora0";
            // 
            // Llenadora1
            // 
            resources.ApplyResources(this.Llenadora1, "Llenadora1");
            this.Llenadora1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Llenadora1.Name = "Llenadora1";
            // 
            // Carbonatador0
            // 
            resources.ApplyResources(this.Carbonatador0, "Carbonatador0");
            this.Carbonatador0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Carbonatador0.Name = "Carbonatador0";
            // 
            // Checkmat0
            // 
            resources.ApplyResources(this.Checkmat0, "Checkmat0");
            this.Checkmat0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Checkmat0.Name = "Checkmat0";
            // 
            // Codificador0
            // 
            resources.ApplyResources(this.Codificador0, "Codificador0");
            this.Codificador0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Codificador0.Name = "Codificador0";
            // 
            // TTEB1_0
            // 
            resources.ApplyResources(this.TTEB1_0, "TTEB1_0");
            this.TTEB1_0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TTEB1_0.Name = "TTEB1_0";
            // 
            // TTEB1_1
            // 
            resources.ApplyResources(this.TTEB1_1, "TTEB1_1");
            this.TTEB1_1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TTEB1_1.Name = "TTEB1_1";
            // 
            // TTEB1_2
            // 
            resources.ApplyResources(this.TTEB1_2, "TTEB1_2");
            this.TTEB1_2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TTEB1_2.Name = "TTEB1_2";
            // 
            // Etiquetadora0
            // 
            resources.ApplyResources(this.Etiquetadora0, "Etiquetadora0");
            this.Etiquetadora0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Etiquetadora0.Name = "Etiquetadora0";
            // 
            // TTEB2_0
            // 
            resources.ApplyResources(this.TTEB2_0, "TTEB2_0");
            this.TTEB2_0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TTEB2_0.Name = "TTEB2_0";
            // 
            // TTEB2_1
            // 
            resources.ApplyResources(this.TTEB2_1, "TTEB2_1");
            this.TTEB2_1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TTEB2_1.Name = "TTEB2_1";
            // 
            // TTEB2_2
            // 
            resources.ApplyResources(this.TTEB2_2, "TTEB2_2");
            this.TTEB2_2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TTEB2_2.Name = "TTEB2_2";
            // 
            // TTEB2_3
            // 
            resources.ApplyResources(this.TTEB2_3, "TTEB2_3");
            this.TTEB2_3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TTEB2_3.Name = "TTEB2_3";
            // 
            // TTEB2_4
            // 
            resources.ApplyResources(this.TTEB2_4, "TTEB2_4");
            this.TTEB2_4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TTEB2_4.Name = "TTEB2_4";
            // 
            // Horno0
            // 
            resources.ApplyResources(this.Horno0, "Horno0");
            this.Horno0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Horno0.Name = "Horno0";
            // 
            // TTP_0
            // 
            resources.ApplyResources(this.TTP_0, "TTP_0");
            this.TTP_0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TTP_0.Name = "TTP_0";
            // 
            // TTP_1
            // 
            resources.ApplyResources(this.TTP_1, "TTP_1");
            this.TTP_1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TTP_1.Name = "TTP_1";
            // 
            // Paletizadora0
            // 
            resources.ApplyResources(this.Paletizadora0, "Paletizadora0");
            this.Paletizadora0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Paletizadora0.Name = "Paletizadora0";
            // 
            // Paletizadora1
            // 
            resources.ApplyResources(this.Paletizadora1, "Paletizadora1");
            this.Paletizadora1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Paletizadora1.Name = "Paletizadora1";
            // 
            // Paletizadora2
            // 
            resources.ApplyResources(this.Paletizadora2, "Paletizadora2");
            this.Paletizadora2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Paletizadora2.Name = "Paletizadora2";
            // 
            // Envolvedora0
            // 
            resources.ApplyResources(this.Envolvedora0, "Envolvedora0");
            this.Envolvedora0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Envolvedora0.Name = "Envolvedora0";
            // 
            // Impresora0
            // 
            resources.ApplyResources(this.Impresora0, "Impresora0");
            this.Impresora0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Impresora0.Name = "Impresora0";
            // 
            // TTP_2
            // 
            resources.ApplyResources(this.TTP_2, "TTP_2");
            this.TTP_2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TTP_2.Name = "TTP_2";
            // 
            // LlenadoraVel
            // 
            resources.ApplyResources(this.LlenadoraVel, "LlenadoraVel");
            this.LlenadoraVel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LlenadoraVel.Name = "LlenadoraVel";
            // 
            // BotellasProducidas
            // 
            this.BotellasProducidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(83)))), ((int)(((byte)(121)))));
            resources.ApplyResources(this.BotellasProducidas, "BotellasProducidas");
            this.BotellasProducidas.ForeColor = System.Drawing.Color.Black;
            this.BotellasProducidas.Name = "BotellasProducidas";
            // 
            // BotellasRechazadas
            // 
            this.BotellasRechazadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(83)))), ((int)(((byte)(121)))));
            resources.ApplyResources(this.BotellasRechazadas, "BotellasRechazadas");
            this.BotellasRechazadas.ForeColor = System.Drawing.Color.Black;
            this.BotellasRechazadas.Name = "BotellasRechazadas";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.Controls.Add(this.BotellasRechazadas);
            this.Controls.Add(this.BotellasProducidas);
            this.Controls.Add(this.LlenadoraVel);
            this.Controls.Add(this.TTP_2);
            this.Controls.Add(this.Impresora0);
            this.Controls.Add(this.Envolvedora0);
            this.Controls.Add(this.Paletizadora2);
            this.Controls.Add(this.Paletizadora1);
            this.Controls.Add(this.Paletizadora0);
            this.Controls.Add(this.TTP_1);
            this.Controls.Add(this.TTP_0);
            this.Controls.Add(this.Horno0);
            this.Controls.Add(this.TTEB2_4);
            this.Controls.Add(this.TTEB2_3);
            this.Controls.Add(this.TTEB2_2);
            this.Controls.Add(this.TTEB2_1);
            this.Controls.Add(this.TTEB2_0);
            this.Controls.Add(this.Etiquetadora0);
            this.Controls.Add(this.TTEB1_2);
            this.Controls.Add(this.TTEB1_1);
            this.Controls.Add(this.TTEB1_0);
            this.Controls.Add(this.Codificador0);
            this.Controls.Add(this.Checkmat0);
            this.Controls.Add(this.Carbonatador0);
            this.Controls.Add(this.Llenadora1);
            this.Controls.Add(this.Llenadora0);
            this.Controls.Add(this.Sopladora1);
            this.Controls.Add(this.Sopladora0);
            this.Controls.Add(this.Preformas2);
            this.Controls.Add(this.Preformas3);
            this.Controls.Add(this.Preformas1);
            this.Controls.Add(this.Preformas0);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNConexion);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox6);
            this.Name = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BTNConexion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label Preformas0;
        private System.Windows.Forms.Label Preformas1;
        private System.Windows.Forms.Label Preformas3;
        private System.Windows.Forms.Label Preformas2;
        private System.Windows.Forms.Label Sopladora0;
        private System.Windows.Forms.Label Sopladora1;
        private System.Windows.Forms.Label Llenadora0;
        private System.Windows.Forms.Label Llenadora1;
        private System.Windows.Forms.Label Carbonatador0;
        private System.Windows.Forms.Label Checkmat0;
        private System.Windows.Forms.Label Codificador0;
        private System.Windows.Forms.Label TTEB1_0;
        private System.Windows.Forms.Label TTEB1_1;
        private System.Windows.Forms.Label TTEB1_2;
        private System.Windows.Forms.Label Etiquetadora0;
        private System.Windows.Forms.Label TTEB2_0;
        private System.Windows.Forms.Label TTEB2_1;
        private System.Windows.Forms.Label TTEB2_2;
        private System.Windows.Forms.Label TTEB2_3;
        private System.Windows.Forms.Label TTEB2_4;
        private System.Windows.Forms.Label Horno0;
        private System.Windows.Forms.Label TTP_0;
        private System.Windows.Forms.Label TTP_1;
        private System.Windows.Forms.Label Paletizadora0;
        private System.Windows.Forms.Label Paletizadora1;
        private System.Windows.Forms.Label Paletizadora2;
        private System.Windows.Forms.Label Envolvedora0;
        private System.Windows.Forms.Label Impresora0;
        private System.Windows.Forms.Label TTP_2;
        private System.Windows.Forms.Label LlenadoraVel;
        private System.Windows.Forms.Label BotellasProducidas;
        private System.Windows.Forms.Label BotellasRechazadas;
    }
}

