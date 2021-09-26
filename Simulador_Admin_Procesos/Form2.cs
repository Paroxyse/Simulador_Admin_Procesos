using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Simulador_Admin_Procesos;

namespace Simulador_Admin_Procesos
{
    public partial class Form2 : Form
    {
        public Form2(List<Proceso>Procesos)
        {
            double aux1, aux2, aux3;
            InitializeComponent();
            foreach(Proceso x in Procesos)
            {
                aux1 = x.salida - x.llegada;
                aux2 = -x.tiempo + aux1;
                aux3 = x.tiempo / aux1;
                DVG_datos.Rows.Add(x.nombre, x.llegada, x.tiempo, x.salida, aux1, aux2, aux3);
            }
            aux1 = 0;aux2 = 0;aux3 = 0;
            foreach (Proceso x in Procesos)
            {
                aux1 += x.salida - x.llegada;
                aux2 += (x.salida - x.llegada) -x.tiempo;
                aux3 += (double)x.tiempo / (double)(x.salida - x.llegada);
                
            }
            DVG_stats.Rows.Add(aux1/Procesos.Count, aux2/Procesos.Count, aux3 / Procesos.Count);
        }
    }
}
