using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Diagnostics;


namespace Simulador_Admin_Procesos
{
    public partial class Form1 : Form
    {
        List<Proceso>[] arp = new List<Proceso>[6];
        // 0 Listo
        // 1 Bloqueado
        // 2 Suspendido Listo
        // 3 Suspendido Bloqueado
        // 4 Ejecutando
        // 5 Terminado

        Stopwatch stw;
        int timerCicles = 0;
        public Form1()
        {
           
            InitializeComponent();
            for(int i=0;i<6;i++) { 
                arp[i] = new List<Proceso>(); 
                
            }
            stw = new Stopwatch();
            Timer.Start();
           
        }
        private Proceso generarNP()
        {
            Random r = new Random();
            string aux = "";
            int Local_random;
            for (int i = 0; i < 5; i++)
            {
                Local_random = r.Next(15);
                switch (Local_random)
                {
                    case 10:
                        aux += "A";
                        break;
                    case 11:
                        aux += "B";
                        break;
                    case 12:
                        aux += "C";
                        break;
                    case 13:
                        aux += "D";
                        break;
                    case 14:
                        aux += "E";
                        break;
                    case 15:
                        aux += "F";
                        break;
                    default:
                        aux += "" + Local_random;
                        break;
                }
            }

            return new Proceso(aux, r.Next(10) + 1, r.Next(3) + 1,(int)Math.Round(stw.Elapsed.TotalSeconds)) ;
        }
        private Proceso capturarNP()
        {
            int s = 0;
            switch (CB_Prior.Text)
            {
                case "Low":
                    s = 1;
                    break;
                case "Medium":
                    s = 2;
                    break;
                case "High":
                    s = 3;
                    break;
            }
            return new Proceso(TB_NProc.Text, (int)SP_Tiempo.Value, s, (int)Math.Round(stw.Elapsed.TotalSeconds));
        }
        private void Mover(Proceso pr, List<Proceso> a, List<Proceso> b)
        {
            try
            {
                b.Add(pr);
                a.Remove(pr);
            }catch (Exception){ }
        }
        private void botonThicc3_Click(object sender, EventArgs e)
        {
            if (botonThicc3.BackColor == Color.LawnGreen)
            {
                stw.Stop();
                Timer.Stop();
                botonThicc3.BackColor = Color.DarkRed;
                return;
            }
            Timer.Start();
            botonThicc3.BackColor = Color.LawnGreen;
           
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!stw.IsRunning) { stw.Start(); }
            lblCrn.Text = stw.Elapsed.ToString(@"hh\:mm\:ss\.ff");
            timerCicles++;
            if (timerCicles == 9)
            {
                
            }
            timerCicles %= 9;
        }

        private void botonThicc1_Click(object sender, EventArgs e)
        {

        }

        private void botonThicc2_Click(object sender, EventArgs e)
        {

        }
    }
}
