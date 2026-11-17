using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Collections.Generic;
using System.Linq;
using System.Drawing.Imaging;
using System.IO.Ports;

namespace Conecction_S7300
{
    public partial class Form1 : Form
    {
        public static Form1 instance = null;
        Ping Pings = new Ping();


        S7Station DB1 = new S7Station();


        int timeout = 2;
        int pingNok = 0;
        public int CounterTimeTick=0;
        private List<string> MachinesStates = new List<string>();
        private List<string> MachinesText = new List<string>();


        public Form1()
        {
            InitializeComponent();

            instance = this;

            timer1.Interval = Properties.Settings.Default.velocidad;

            DB1.Ip = Properties.Settings.Default.s1ip;
            DB1.Rack = Properties.Settings.Default.s1rack;
            DB1.Slot = Properties.Settings.Default.s1slot;
            DB1.DB = Properties.Settings.Default.s1db;
            DB1.DBlenght = (Properties.Settings.Default.s1length)-1;
            DB1.CantidadVariables = Properties.Settings.Default.CantVariables;
            Datos.ConectionEnable = Properties.Settings.Default.s1conenable;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = false;

            pictureBox6.BackColor = Color.Transparent;


            ///******************* TRANSPARENCIA DE LA IMAGEN DE FONDO ******************///
            Image originalImage = pictureBox6.Image;
            Bitmap bmp = new Bitmap(originalImage.Width, originalImage.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                // Crear la matriz de color con la opacidad deseada
                ColorMatrix colorMatrix = new ColorMatrix(new float[][]
                {
            new float[] {1, 0, 0, 0, 0},
            new float[] {0, 1, 0, 0, 0},
            new float[] {0, 0, 1, 0, 0},
            new float[] {0, 0, 0, 0.6f, 0},
            new float[] {0, 0, 0, 0, 1}
                });

                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                // Dibujar la imagen con la opacidad ajustada
                g.DrawImage(originalImage, new Rectangle(0, 0, originalImage.Width, originalImage.Height),
                    0, 0, originalImage.Width, originalImage.Height, GraphicsUnit.Pixel, attributes);
            }

            // Asignar la nueva imagen semi transparente al PictureBox
            pictureBox6.Image = bmp;

            //**************************************************************

            CounterTimeTick = 5;
            CyclicalEvent();

        }



        public void CyclicalEvent()
        {
            timer1.Interval = Properties.Settings.Default.velocidad;
            bool pingOK = false;

            try
            {
                if (pingNok > 1000) { pingNok = 20; }
                if (Pings.Send(Properties.Settings.Default.s1ip, timeout).Status == IPStatus.Success) { pingOK = true; pingNok = 0; }
                else pingNok++;
            }
            catch { }


            if (Datos.ConectionEnable && pingOK)
            {
                //Carga tabla de buffer 1
                if (!DB1.ConnectionOK)
                {
                    DB1.Conect();
                    if (DB1.ConnectionOK)
                    {
                        BTNConexion.Text = "CONECTADO";
                        BTNConexion.BackColor = Color.Green;
                        ChargueMachineStates();
                    }
                    else ChargueDefaultMachineStates();
                }
                else ChargueMachineStates();


            }
            else
            {
                if (pingNok > 2)
                {
                    BTNConexion.Text = "DESCONECTADO";
                    BTNConexion.BackColor = Color.Red;
                    CargarDatosEnSpeedsDisconected();
                    ChargueAnimatedBlocksDisconected();

                }
            }


            CounterTimeTick++;
        }

        private void ChargueDefaultMachineStates()
        {
            DB1.Disconect();
            MachinesStates.Clear();
            int[] defaultBuffer = new int[MachinesText.Count];
         

        }
        private void ChargueMachineStates()
        {
            string directoryPath = AppDomain.CurrentDomain.BaseDirectory;
            // Construir la ruta completa del archivo Machines.txt
            string filePath = Path.Combine(directoryPath, "Machines.txt");

            if (File.Exists(filePath))
            {
                MachinesText = new List<string>(File.ReadAllLines(filePath));
                if (MachinesText.Count <= DB1.DBlenght)
                {
                    DB1.DBlenght = MachinesText.Count;
                }
                

                if (DB1.ConnectionOK)
                {
                    DB1.ChargueBufferFromPLC();
                    DB1.ChargueSpeedsDwords();
                    MachinesStates.Clear();
                    for (int i = 0; i < DB1.GetBuffer().Length; i++)
                    {
                        
                        MachinesStates.Add(getStringState(DB1.GetBuffer()[i]));
                        ChargueAnimatedBlocks(DB1.GetBuffer());
                    }
                    CargarDatosEnSpeeds(DB1.GetBufferSpeeds()); 

                }
            }else Console.WriteLine("No existe el archivo de configuracion de maquinas en la ruta: " + Properties.Settings.Default.path);


        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            CyclicalEvent();
        }

        private string getStringState(int number) {
        string [] state = { 
                            "SIN CONEXÓN",
                            "PARADA OPERACIONAL",
                            "FUERA DE PRODUCCION", 
                            "EN PRODUCCION", 
                            "PARADA PROPIA",
                            "PARADA POR ALIMENTACION", 
                            "PARADA POR DESCARGA",
                            "PARADA FUNCIONAL", 
                            "SUBVELOCIDAD", 
                            "EN CIP"};
        if(number>=0 && number <= 9)
            {
                return state[number];
            }else return "ESTADO DESCONOCIDO";
           
        }

        private string getStringStateTransDespLlen(int number)
        {
            string[] state = { 
                            "SIN CONEXÓN",
                            "PARADA OPERACIONAL",
                            "FUERA DE PRODUCCION",
                            "ACUMULO VACIO",
                            "PARADA PROPIA",
                            "ACUMULO VACIO",
                            "ACUMULO LLENO",
                            "ACUMULO MEDIO LLENO",
                            "SUBVELOCIDAD",
                            "EN CIP"};
            if (number >= 0 && number <= 9)
            {
                return state[number];
            }
            else return "ESTADO DESCONOCIDO";

        }

        private System.Drawing.Color getCelColor(int number)
        {
            Color[] colores = { 
                     System.Drawing.Color.Gray,
                     System.Drawing.Color.SkyBlue,
                     System.Drawing.Color.White,
                     System.Drawing.Color.DarkGreen,
                     System.Drawing.Color.Red,
                     System.Drawing.Color.Violet,
                     System.Drawing.Color.Orange,
                     System.Drawing.Color.LightGreen,
                     System.Drawing.Color.Yellow,
                     System.Drawing.Color.PaleTurquoise,
                    };
            if (number >= 0 && number <= 9)
                return colores[number];
            else return colores[0];

        }

        //***************   OBJETOS ANIMADOS  ****************//
        #region [animated Objets]

        void CargarDatosEnSpeeds(Int32[] speedsBuffer)
        {
        LlenadoraVel.Text = speedsBuffer[0].ToString() + " B/h";
        BotellasProducidas.Text = "Botellas Producidas: "+ speedsBuffer[1].ToString();
        BotellasRechazadas.Text = "Botellas Rechazadas: "+ speedsBuffer[2].ToString();


        }

        void CargarDatosEnSpeedsDisconected()
        {
            LlenadoraVel.Text = "####### B/h";
            BotellasProducidas.Text = "Botellas Producidas: #######";
            BotellasRechazadas.Text = "Botellas Rechazadas: #######";


        }
        void ChargueAnimatedBlocks(int[] bufferFun)
        {
            //transporte de preformas
            Preformas0.BackColor = getCelColor(bufferFun[0]);
            Preformas0.Text = getStringState(bufferFun[0]);
            Preformas1.BackColor = getCelColor(bufferFun[0]);
            Preformas2.BackColor = getCelColor(bufferFun[0]);
            Preformas3.BackColor = getCelColor(bufferFun[0]);
            //sopladora
            Sopladora0.BackColor = getCelColor(bufferFun[1]);
            Sopladora0.Text = getStringState(bufferFun[1]);
            Sopladora1.BackColor = getCelColor(bufferFun[1]);
            //Carbonatador
            Carbonatador0.BackColor = getCelColor(bufferFun[2]);    
            Carbonatador0.Text = getStringState(bufferFun[2]);
            //Llenadora
            Llenadora0.BackColor = getCelColor(bufferFun[3]);
            Llenadora0.Text = getStringState(bufferFun[3]);
            Llenadora1.BackColor = getCelColor(bufferFun[3]);            
            //Ckeckmat Llenadora
            Checkmat0.BackColor = getCelColor(bufferFun[4]);    
            Checkmat0.Text = getStringState(bufferFun[4]);
            //Codificador
            Codificador0.BackColor = getCelColor(bufferFun[5]);
            Codificador0.Text = getStringState(bufferFun[5]);
            //Etiquetadora
            Etiquetadora0.BackColor = getCelColor(bufferFun[6]);
            Etiquetadora0.Text = getStringState(bufferFun[6]);
            //Horno
            Horno0.BackColor = getCelColor(bufferFun[8]);
            Horno0.Text = getStringState(bufferFun[8]);
            //Paletizasdora
            Paletizadora0.BackColor = getCelColor(bufferFun[9]);    
            Paletizadora0.Text = getStringState(bufferFun[9]);
            Paletizadora1.BackColor = getCelColor(bufferFun[9]);
            Paletizadora2.BackColor = getCelColor(bufferFun[9]);
            //Envolvedora
            Envolvedora0.BackColor = getCelColor(bufferFun[10]);
            Envolvedora0.Text = getStringState(bufferFun[10]);
            //Impresora
            Impresora0.BackColor = getCelColor(bufferFun[11]);
            Impresora0.Text = getStringState(bufferFun[11]);
            //Transporte llenadora - etiquetadora
            TTEB1_0.BackColor = getCelColor(bufferFun[12]);
            TTEB1_0.Text = getStringStateTransDespLlen(bufferFun[12]);
            TTEB1_1.BackColor = getCelColor(bufferFun[12]);
            TTEB1_2.BackColor = getCelColor(bufferFun[12]);
            //Transporte etiquetadora - horno
            TTEB2_0.BackColor = getCelColor(bufferFun[13]);
            TTEB2_0.Text = getStringStateTransDespLlen(bufferFun[13]);
            TTEB2_1.BackColor = getCelColor(bufferFun[13]);
            TTEB2_2.BackColor = getCelColor(bufferFun[13]);
            TTEB2_3.BackColor = getCelColor(bufferFun[13]);
            TTEB2_4.BackColor = getCelColor(bufferFun[13]);
            //Transporte horno - paletizadora
            TTP_0.BackColor = getCelColor(bufferFun[14]);
            TTP_0.Text = getStringStateTransDespLlen(bufferFun[14]);
            TTP_1.BackColor = getCelColor(bufferFun[14]);
            TTP_2.BackColor = getCelColor(bufferFun[14]);
            //Velocidad Lllenadora
            LlenadoraVel.BackColor = getCelColor(bufferFun[3]);
            

        }

        void ChargueAnimatedBlocksDisconected()
        {
            //transporte de preformas
            Preformas0.BackColor = getCelColor(0);
            Preformas0.Text = getStringState(0);
            Preformas1.BackColor = getCelColor(0);
            Preformas2.BackColor = getCelColor(0);
            Preformas3.BackColor = getCelColor(0);
            //sopladora
            Sopladora0.BackColor = getCelColor(0);
            Sopladora0.Text = getStringState(0);
            Sopladora1.BackColor = getCelColor(0);
            //Carbonatador
            Carbonatador0.BackColor = getCelColor(0);
            Carbonatador0.Text = getStringState(0);
            //Llenadora
            Llenadora0.BackColor = getCelColor(0);
            Llenadora0.Text = getStringStateTransDespLlen(0);
            Llenadora1.BackColor = getCelColor(0);
            //Ckeckmat Llenadora
            Checkmat0.BackColor = getCelColor(0);
            Checkmat0.Text = getStringState(0);
            //Codificador
            Codificador0.BackColor = getCelColor(0);
            Codificador0.Text = getStringState(0);
            //Etiquetadora
            Etiquetadora0.BackColor = getCelColor(0);
            Etiquetadora0.Text = getStringState(0);
            //Horno
            Horno0.BackColor = getCelColor(0);
            Horno0.Text = getStringState(0);
            //Paletizasdora
            Paletizadora0.BackColor = getCelColor(0);
            Paletizadora0.Text = getStringState(0);
            Paletizadora1.BackColor = getCelColor(0);
            Paletizadora2.BackColor = getCelColor(0);
            //Envolvedora
            Envolvedora0.BackColor = getCelColor(0);
            Envolvedora0.Text = getStringState(0);
            //Impresora
            Impresora0.BackColor = getCelColor(0);
            Impresora0.Text = getStringState(0);
            //Transporte llenadora - etiquetadora
            TTEB1_0.BackColor = getCelColor(0);
            TTEB1_0.Text = getStringStateTransDespLlen(0);
            TTEB1_1.BackColor = getCelColor(0);
            TTEB1_2.BackColor = getCelColor(0);
            //Transporte etiquetadora - horno
            TTEB2_0.BackColor = getCelColor(0);
            TTEB2_0.Text = getStringStateTransDespLlen(0);
            TTEB2_1.BackColor = getCelColor(0);
            TTEB2_2.BackColor = getCelColor(0);
            TTEB2_3.BackColor = getCelColor(0);
            TTEB2_4.BackColor = getCelColor(0);
            //Transporte horno - paletizadora
            TTP_0.BackColor = getCelColor(0);
            TTP_0.Text = getStringStateTransDespLlen(0);
            TTP_1.BackColor = getCelColor(0);
            TTP_2.BackColor = getCelColor(0);
            //Velocidad Lllenadora
            LlenadoraVel.BackColor = getCelColor(0);


        }


        #endregion
        //***************   TABLA  ****************//


        //***************   BOTONES DE VENTANA  ****************//
        #region [Buttoms]
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (DB1.ConnectionOK) DB1.Disconect();
            Form2 CambioF = new Form2();
            CambioF.Show();
        }
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = true;
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = false;
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.FromArgb(0, 89, 162);
        }

        private void PictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.FromArgb(0, 120, 215);
        }

        private void PictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.FromArgb(0, 89, 162);
        }

        private void PictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.FromArgb(0, 120, 215);
        }

        private void PictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.FromArgb(0, 89, 162);
        }

        private void PictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.FromArgb(0, 120, 215);
        }

        private void PictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(0, 89, 162);
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(0, 120, 215);
        }

        private void PictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(237, 35, 35);
        }

        private void PictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(0, 120, 215);
        }



        #endregion

   
    }
}
