using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;


namespace Prueba_S7_1200
{
    public partial class Form1 : Form
    {
        Plc plc1 = new Plc(CpuType.S71200, "10.222.4.10", 0, 1);
        DataTable dtRead = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (plc1.IsConnected)
            {
                plc1.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var dwords = plc1.Read(DataType.DataBlock, 9, 4, VarType.DWord, 1);
            //Int32 result = (Int32)plc.Read("DB9.DBD4");
            //label1.Text = dwords.ToString() + " Kg.";
        }

        private void btnConnect1_Click(object sender, EventArgs e)
        {
            if (btnConnect1.Text == "Conectar")
            {
                btnConnect1.Text = "Cancelar conexión";
                btnRead1.Enabled = true;
                functionCallStatusLabel1.Text = "Conectando...";
                bgwConnect1.RunWorkerAsync();
            }
            else
            {
                btnConnect1.Text = "Conectar";
                btnRead1.Enabled = false;
                if (bgwConnect1.IsBusy)
                {
                    bgwConnect1.CancelAsync();
                    if (plc1.IsConnected)
                    {
                        plc1.Close();
                    }
                }
                else
                {
                    plc1.Close();
                }
            }
        }

        private void bgwConnect1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                plc1.Open();
                if (plc1.IsConnected)
                {
                    e.Result = "PLC Conectado";
                }
                else
                {
                    if (plc1.IsAvailable)
                    {
                        e.Result = "PLC no disponible";
                    }
                }
            }
            catch (Exception ex)
            {
                e.Result = "Error: " + ex.Message;
            }
            
        }

        private void bgwConnect1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            switch (e.Result.ToString())
            {
                case "PLC Conectado":
                    functionCallStatusLabel1.Text = e.Result.ToString();
                    connectionStatus1.BackgroundImage = Properties.Resources.connected;
                    btnConnect1.BackColor = Color.LightGreen;
                    btnConnect1.Text = "Desconectar";
                    btnRead1.Enabled = true;
                    break;
                case "PLC no disponible":
                    btnConnect1.Text = "Conectar";
                    btnRead1.Enabled = false;
                    functionCallStatusLabel1.Text = e.Result.ToString();
                    connectionStatus1.BackgroundImage = Properties.Resources.disconnected;
                    break;
                default:
                    btnConnect1.Text = "Conectar";
                    btnRead1.Enabled = false;
                    functionCallStatusLabel1.Text = e.Result.ToString();
                    connectionStatus1.BackgroundImage = Properties.Resources.disconnected;
                    break;
            }
        }

        private void btnRead1_Click(object sender, EventArgs e)
        {
            if (btnRead1.Text == "Iniciar lectura")
            {
                btnRead1.BackColor = Color.LightGreen;
                btnRead1.Text = "Detener lectura";
                timer1.Enabled = true;
            }
            else
            {
                btnRead1.BackColor = Color.LightGray;
                btnRead1.Text = "Iniciar lectura";
                timer1.Enabled = false;
            }
        }
    }
}
