using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador_Admin_Procesos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botonThicc3_Click(object sender, EventArgs e)
        {
            if (botonThicc3.BackColor == Color.LawnGreen)
            {
                botonThicc3.BackColor = Color.DarkRed;
                return;
            }
            botonThicc3.BackColor = Color.LawnGreen;
           
        }
    }
}
