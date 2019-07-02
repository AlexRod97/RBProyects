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
            if (hembra != null)
            {
                int num = 0;
                cbPartos.Items.Add("General");
                for (int i = 1; i <= hembra.getTotalPartos(); i++)
                {
                    cbPartos.Items.Add(i.ToString());
                    num = i;
                }

            }
            else
            {
                MessageBox.Show("La hembra no existe");
            }
            

        }

        private void cbPartos_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataStructure.Main main = new DataStructure.Main();
            var hembra = main.ExisteArete(txtArete.Text);
            if (cbPartos.SelectedItem.ToString() == "General")
            {

            }
            else
            {
                int parto = Convert.ToInt32(cbPartos.SelectedItem);

            }
        }
    }
}
