using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Conecction_S7300
{
    public partial class Form2 : Form
    {
        S7Station B1testConnection = new S7Station();

        public Form2()
        {
            InitializeComponent();

            B1testConnection.Ip = Properties.Settings.Default.s1ip;
            B1testConnection.Rack = Properties.Settings.Default.s1rack;
            B1testConnection.Slot = Properties.Settings.Default.s1slot;

            ip.Text = Properties.Settings.Default.s1ip;
            rack.Text = Properties.Settings.Default.s1rack.ToString();
            slot.Text = Properties.Settings.Default.s1slot.ToString();
            db.Text = Properties.Settings.Default.s1db.ToString();
            lenght.Text = Properties.Settings.Default.s1length.ToString();
            velocidad.Text = Properties.Settings.Default.velocidad.ToString();
            CantVariables.Text = Properties.Settings.Default.CantVariables.ToString();
            Path.Text = Properties.Settings.Default.path;


        }

        private void Conectar_Click(object sender, EventArgs e)
        {
            B1testConnection.Ip = ip.Text;
            B1testConnection.Rack = Convert.ToInt16(rack.Text);
            B1testConnection.Slot = Convert.ToInt16(slot.Text);

            B1testConnection.Conect();
            lbl1.Text = B1testConnection.Diagnostic;
            if (B1testConnection.ConnectionOK) { lbl1.ForeColor = Color.GreenYellow; Datos.ConectionEnable = true; }
            else lbl1.ForeColor = Color.DarkRed;

        }

        private void Desconectar_Click(object sender, EventArgs e)
        {
            B1testConnection.Disconect();
            Datos.ConectionEnable = false;
            lbl1.ForeColor = Color.DarkRed;
            lbl1.Text = "Desconectado";
        }



        private void Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.s1ip = ip.Text;
                Properties.Settings.Default.s1rack = Convert.ToInt16(rack.Text);
                Properties.Settings.Default.s1slot = Convert.ToInt16(slot.Text);
                Properties.Settings.Default.s1db = Convert.ToInt16(db.Text);
                Properties.Settings.Default.velocidad = Convert.ToInt16(velocidad.Text);
                Properties.Settings.Default.s1length = Convert.ToInt16(lenght.Text);
                Properties.Settings.Default.s1conenable = Datos.ConectionEnable;
                Properties.Settings.Default.CantVariables = Convert.ToInt16(CantVariables.Text);
                Properties.Settings.Default.path = Path.Text;


                Properties.Settings.Default.Save();


                Form1.instance.timer1.Start();
                Form1.instance.CounterTimeTick = 0;
                Form1.instance.CyclicalEvent();
                this.Close();
                this.Dispose();
            }
            catch
            {
                DialogResult result = MessageBox.Show(" Ingreso algun campo no admitido ", "Error!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {

                }
                if (result == DialogResult.Cancel)
                {
                    
                    this.Close();
                    this.Dispose();
                    
                }
            }

        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Form1.instance.timer1.Start();
            Form1.instance.CyclicalEvent();
            this.Close();
            this.Dispose();
        }


    }
}
