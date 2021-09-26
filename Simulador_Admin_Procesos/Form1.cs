﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Timers;
using System.Diagnostics;


namespace Simulador_Admin_Procesos
{
    public partial class Form1 : Form
    {
        Random r;
        int qmax = 5;
        int qa=0;
        List<Proceso>[] arp = new List<Proceso>[6];
        // 0 Listo
        // 1 Suspendido Listo
        // 2 Bloqueado
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
            r = new Random();
            CB_Algoritmo.SelectedIndex = 0;
           // Timer.Start();
           
        }
        private void Ejecucion()
        {
            if (arp[4].Count != 0)
            {
                arp[4][0].T_rest--;
                EndProcess();
            }
            //switch con variación de método
            RoundRobin();
            //aeaeaeaea
            desbloqueo();
            Unsus(3,2);
            Unsus(1, 0);
            bloqueo();
            ActualizarFilas();
        }
        private void FIFO() {
            if (arp[0].Count > 0 && arp[4].Count==0)
            {
                Mover(arp[0][0], arp[0], arp[4]);
            }
        }
        private void Lowest() {
            if (arp[0].Count <= 0 ) { return; }


            //Esto podría ser más eficiente si ordeno la lista primero y tomo el primer elemento
            //Pero esto no es código de producción :^]
            int lowindex = arp[0].Count-1;
            for (int i = lowindex; i >= 0; i--)
            {

                if (arp[0][i].T_rest < arp[0][lowindex].T_rest) {
                    lowindex = i;
                }
            }
            if(arp[4].Count <= 0)
            {
                Mover(arp[0][lowindex], arp[0], arp[4]);
                return;
            }
            if (arp[4].Count > 0 && arp[0][lowindex].T_rest < arp[4][0].T_rest) {
                Mover(arp[0][lowindex], arp[0], arp[4]);
                Mover(arp[4][0], arp[4], arp[0]);
            }
           


        }
        private void RoundRobin() {
            FIFO();
            qa++;
            if (arp[4].Count > 0 && qa >= qmax)
            {
                
                Mover(arp[4][0],arp[4],arp[1]);
               // Unsus(1, 0);
               // FIFO();
                qa = 0;
            }
            
        }
       
        private void EndProcess()
        {
            if(arp[4].Count>0 && arp[4][0].T_rest <= 0)
            {
                Mover(arp[4][0], arp[4], arp[5]);
                qa = 0;
            }
          
        }
        private void Unsus(int sender, int receiver) {
        for(int i = 0; i < arp[sender].Count ; i++)
            {
                if (arp[receiver].Count == 5)
                {
                    return;
                }
                Mover(arp[sender][i], arp[sender], arp[receiver]);
                Unsus(sender, receiver);
            }
        }
        private void desbloqueo()
        {
            
            for (int i = arp[2].Count -1; i>=0; i--)
            {
                if (r.Next(3)==2 && Acomodar(arp[2][i]))
                {
                    arp[2].RemoveAt(i);
                }
            }
        }
        private void bloqueo()
        {
            r = new Random();
            if (arp[4].Count == 1 && r.Next(50) == 1)
            {
                AcomodarBloqueo();
            }
        }
        private Proceso generarNP()
        {
            r = new Random(System.DateTime.Now.Millisecond);
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

            return new Proceso(aux, r.Next(20) + 1, r.Next(3) + 1,(int)Math.Round(stw.Elapsed.TotalSeconds)) ;
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
        //Mueve un proceso del contenedor a al b
        private void Mover(Proceso pr, List<Proceso> a, List<Proceso> b)
        {
            if (a.Contains(pr)) {
                try
                {
                    b.Add(pr);
                    a.Remove(pr);
                }
                catch (Exception) { MessageBox.Show("jaja q loco"); }
                return;
            }
            MessageBox.Show("El contenedor del parámetro a no contiene al proceso p");
            
        }
        private void AcomodarBloqueo()
        {
            if (arp[2].Count < 5)
            {
                Mover(arp[4][0], arp[4], arp[2]);
                return;
            }
            if (arp[3].Count < 20)
            {
                Mover(arp[4][0], arp[4], arp[3]);
                return;
            }
            MessageBox.Show("De alguna forma haz logrado llenar la cola de bloqueo suspendido, eres un monstruo");
        }
        private bool Acomodar(Proceso pr)
        {
        
            if (arp[0].Count < 5)
            {
                arp[0].Add(pr);
                return true;
            }
            if (arp[1].Count < 10)
            {
                arp[1].Add(pr);
                return true;
            }

            return false;
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
                //Implementar método de manejo de procesos
                Ejecucion();
            }
            timerCicles %= 9;
        }
      
        private void ActualizarFilas() {
          
            DataGridView[] aux = new DataGridView[] {DGV_L,DGV_B,DGV_SL,DGV_SB,DGV_Actual,DGV_T };
             for(int i = 0; i < 6; i++)
            {
                aux[i].Rows.Clear();
                foreach(Proceso x in arp[i])
                {
                
                    aux[i].Rows.Add(x.nombre,x.T_rest,x.prToString());
                }
            }
        }
        private void botonThicc1_Click(object sender, EventArgs e)
        {
            Acomodar(capturarNP());
            ActualizarFilas();
        }

        private void botonThicc2_Click(object sender, EventArgs e)
        {
           
            for(int i = 0; i < 10; i++)
            {
                
                Acomodar(generarNP());
                Thread.Sleep(5);
            }
            ActualizarFilas();
        }

        private void reporteDetalladoDeProcesosTerminadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Implementar llenado de columnas
            Form2 rep = new Form2();

            rep.Dispose();
        }

        private void CB_Algoritmo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Quantum.Visible = ((ComboBox)sender).SelectedIndex == 1;
            SPN_Quantum.Visible = ((ComboBox)sender).SelectedIndex == 1;
        }

        private void SPN_Quantum_ValueChanged(object sender, EventArgs e)
        {
            qmax = (int)SPN_Quantum.Value+1;
        }
    }
}
