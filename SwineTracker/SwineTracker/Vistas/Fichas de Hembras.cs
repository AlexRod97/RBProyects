using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwineTracker.Vistas
{
    public partial class FichasHembras : Form
    {
        public FichasHembras()
        {
            DataTable table = new DataTable();
            DataColumn dc;
            DataRow dr;
            
            table.Columns.Add("Arete", typeof(string));
            table.Columns.Add("Numero de Partos", typeof(int));
            table.Columns.Add("Vivos", typeof(int));
            table.Columns.Add("Muertos", typeof(int));
            table.Columns.Add("Momias", typeof(int));
            table.Columns.Add("Pesos", typeof(string));
            table.Columns.Add("Peso Promedio", typeof(double));
            table.Columns.Add("Promedio Lechones por parto", typeof(double));
            
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuPrincipal mp = new MenuPrincipal();
            mp.Show();
            this.Visible = false;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Vistas.Actividad a = new Vistas.Actividad();
            a.Show();

        }

        public void txtHembra_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            cbPartos.Items.Clear();
            DataStructure.Main main = new DataStructure.Main();
            var hembra = main.ExisteArete(txtArete.Text);
            cbPartos.Items.Add("General");
            for (int i = 1; i <= hembra.getTotalPartos(); i++)
            {
                cbPartos.Items.Add(i.ToString());
            }
            

        }
    }
}
