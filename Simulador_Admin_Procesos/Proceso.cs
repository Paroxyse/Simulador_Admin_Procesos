﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_Admin_Procesos
{
    class Proceso
    {
        public string nombre;
        public int tiempo, prioridad,T_rest, llegada, salida;
        public double inds;
        public Proceso(string n, int t, int pr, int llegada)
        {
            nombre = n;
            tiempo = t;
            T_rest = t;
            prioridad = pr;
            this.llegada = llegada;
         
        }
        public void setIndserv()
        {
            if (T_rest == 0)
            {
                inds = (salida - llegada) / tiempo;
            }
           
        }
    }
}
