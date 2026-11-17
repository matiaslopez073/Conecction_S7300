namespace Conecction_S7300
{
    partial class Form2
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rack = new System.Windows.Forms.TextBox();
            this.slot = new System.Windows.Forms.TextBox();
            this.ip = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.velocidad = new System.Windows.Forms.TextBox();
            this.desconectar = new System.Windows.Forms.Button();
            this.conectar = new System.Windows.Forms.Button();
            this.cerrar = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.db = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lenght = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Path = new System.Windows.Forms.TextBox();
            this.CantVariables = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Slot";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Rack";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "IP del PLC ";
            // 
            // rack
            // 
            this.rack.Location = new System.Drawing.Point(48, 103);
            this.rack.Name = "rack";
            this.rack.Size = new System.Drawing.Size(44, 20);
            this.rack.TabIndex = 9;
            // 
            // slot
            // 
            this.slot.Location = new System.Drawing.Point(108, 103);
            this.slot.Name = "slot";
            this.slot.Size = new System.Drawing.Size(44, 20);
            this.slot.TabIndex = 8;
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(48, 61);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(163, 20);
            this.ip.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Velocidad de muestreo";
            // 
            // velocidad
            // 
            this.velocidad.Location = new System.Drawing.Point(49, 205);
            this.velocidad.Name = "velocidad";
            this.velocidad.Size = new System.Drawing.Size(77, 20);
            this.velocidad.TabIndex = 14;
            // 
            // desconectar
            // 
            this.desconectar.Location = new System.Drawing.Point(326, 100);
            this.desconectar.Name = "desconectar";
            this.desconectar.Size = new System.Drawing.Size(96, 23);
            this.desconectar.TabIndex = 16;
            this.desconectar.Text = "DESCONECTAR";
            this.desconectar.UseVisualStyleBackColor = true;
            this.desconectar.Click += new System.EventHandler(this.Desconectar_Click);
            // 
            // conectar
            // 
            this.conectar.Location = new System.Drawing.Point(326, 61);
            this.conectar.Name = "conectar";
            this.conectar.Size = new System.Drawing.Size(96, 23);
            this.conectar.TabIndex = 15;
            this.conectar.Text = "CONECTAR";
            this.conectar.UseVisualStyleBackColor = true;
            this.conectar.Click += new System.EventHandler(this.Conectar_Click);
            // 
            // cerrar
            // 
            this.cerrar.Location = new System.Drawing.Point(254, 296);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(117, 31);
            this.cerrar.TabIndex = 18;
            this.cerrar.Text = "CERRAR";
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(123, 296);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(117, 31);
            this.guardar.TabIndex = 17;
            this.guardar.Text = "GUARDAR";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl1.Location = new System.Drawing.Point(322, 140);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(113, 20);
            this.lbl1.TabIndex = 19;
            this.lbl1.Text = "Desconectado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "DB de Estados";
            // 
            // db
            // 
            this.db.Location = new System.Drawing.Point(48, 149);
            this.db.Name = "db";
            this.db.Size = new System.Drawing.Size(90, 20);
            this.db.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(132, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "ms";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(177, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Nº de equipos";
            // 
            // lenght
            // 
            this.lenght.Location = new System.Drawing.Point(180, 149);
            this.lenght.Name = "lenght";
            this.lenght.Size = new System.Drawing.Size(90, 20);
            this.lenght.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Archivo de dispositivos (.txt)";
            // 
            // Path
            // 
            this.Path.Location = new System.Drawing.Point(48, 259);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(379, 20);
            this.Path.TabIndex = 25;
            // 
            // CantVariables
            // 
            this.CantVariables.Location = new System.Drawing.Point(214, 205);
            this.CantVariables.Name = "CantVariables";
            this.CantVariables.Size = new System.Drawing.Size(90, 20);
            this.CantVariables.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(211, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "Nº de Variables";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(502, 344);
            this.ControlBox = false;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CantVariables);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Path);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lenght);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.db);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.desconectar);
            this.Controls.Add(this.conectar);
            this.Controls.Add(this.velocidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rack);
            this.Controls.Add(this.slot);
            this.Controls.Add(this.ip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rack;
        private System.Windows.Forms.TextBox slot;
        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox velocidad;
        private System.Windows.Forms.Button desconectar;
        private System.Windows.Forms.Button conectar;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox db;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lenght;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Path;
        private System.Windows.Forms.TextBox CantVariables;
        private System.Windows.Forms.Label label9;
    }
}