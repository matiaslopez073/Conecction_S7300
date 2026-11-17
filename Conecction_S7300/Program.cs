using System;
using System.Windows.Forms;
using Sharp7;
using System.Net;
using System.IO;





namespace Conecction_S7300
{


    static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }


    public class Datos  // Datos estaticos para todo el programa
    {

        public static bool ConectionEnable = false;

    }


    public class S7Station
    {
        private S7Client Cliente;
        private int result, rack, slot, db, dblenght, cantidadVariables;
        private String diagnostic, ip;
        private bool connectionOK = false;
        private byte[] buffer = new byte[20000];
        private byte[] bufferSpeeds = new byte[20000];

        public S7Station()
        {
            Cliente = new S7Client();
        }

        public void Conect()
        {

            result = Cliente.ConnectTo(ip, rack, slot);

            diagnostic = "Err: " + result.ToString();

            if (result == 0) //0 == Conexión exitosa
            {
                diagnostic = "Conección Exitosa!";
                connectionOK = true;
            }
            else
            {
                diagnostic = "Sin coneccion - Err: " + result.ToString();
                connectionOK = false;
            }
        }

        public void Disconect()
        {
            diagnostic = "Sin conección";
            Cliente.Disconnect();
            connectionOK = false;
        }

        public void ChargueSpeedsDwords()
        {
            int position = (dblenght * 2) + 2;
            int ReadCode = Cliente.DBRead(db, position, cantidadVariables * 4, bufferSpeeds); //Función lee el DB que se ha configurado en la clase
            int cont2 = 0;

            if (ReadCode == 0)
            {
                diagnostic = "Conección Exitosa!";
                for (int cont1 = 0; cont1 <= cantidadVariables; cont1++)
                {
                    try
                    {

                    }
                    catch
                    {
                        bufferSpeeds[cont2] = 0; //Si no se puede leer el buffer, se pone en cero
                        diagnostic = "Error al leer el buffer";

                    }

                    cont2 = cont2 + 4;

                }
            }
            else
            {
                for (int cont3 = 0; cont3 < 32; cont3++)
                {
                    bufferSpeeds[cont3] = 0;

                }

                Disconect();

            }

        }


        public void ChargueBufferFromPLC()
        {
            int ReadCode = Cliente.DBRead(db, 0, dblenght * 2, buffer); //Función lee el DB que se ha configurado en la clase
            int cont2 = 0;

            if (ReadCode == 0)
            {
                diagnostic = "Conección Exitosa!";
                for (int cont1 = 0; cont1 <= dblenght; cont1++)
                {
                    try
                    {

                    }
                    catch
                    {
                        buffer[cont2] = 0; //Si no se puede leer el buffer, se pone en cero
                        diagnostic = "Error al leer el buffer";

                    }

                    cont2 = cont2 + 2;

                }
            }
            else
            {
                for (int cont3 = 0; cont3 < 32; cont3++)
                {
                    buffer[cont3] = 0;

                }

                Disconect();

            }

        }

        public int[] GetBuffer()
        {
            int[] bufferInt = new int[dblenght];

            for (int i = 0; i < bufferInt.Length; i++)
            {
                bufferInt[i] = S7.GetIntAt(buffer, i * 2);
            }
            return bufferInt;
        }

        public int[] GetBufferSpeeds()
        {
            Int32[] bufferDint = new Int32[cantidadVariables];

            for (int i = 0; i < bufferDint.Length; i++)
            {
 
                    bufferDint[i] = Convert.ToInt32(S7.GetDWordAt(bufferSpeeds, i * 4));

            }
            return bufferDint;
        }

        public int Rack
        {
            set
            {
                rack = value;
            }
            get
            {
                return rack;
            }
        }

        public int Slot
        {
            set
            {
                slot = value;
            }
            get
            {
                return slot;
            }

        }
        public int DB
        {
            set
            {
                db = value;
            }
            get
            {
                return db;
            }

        }

        public int DBlenght
        {
            set
            {
                dblenght = value;
            }
            get
            {
                return dblenght;
            }

        }

        public String Diagnostic
        {
            set
            {
                diagnostic = value;
            }
            get
            {
                return diagnostic;
            }

        }

        public String Ip
        {
            set
            {
                ip = value;
            }
            get
            {
                return ip;
            }

        }

        public bool ConnectionOK
        {
            get
            {
                return connectionOK;
            }
            set
            {
                connectionOK = value;
            }
        }

        public int CantidadVariables
        {
            get
            {
                return cantidadVariables;
            }
            set
            {
                cantidadVariables = value;
            }
        }
    }

}





