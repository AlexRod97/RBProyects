using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwineTracker.DataStructure;


namespace SwineTracker.Vistas
{
    public partial class Comparativa_por_fechas : Form
    {
        public Comparativa_por_fechas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuPrincipal mp = new MenuPrincipal();
            mp.Show();
            this.Visible = false;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();

            main.SearchByDates("25/05/2019", "25/06/2019");
        }
    }
    
}
