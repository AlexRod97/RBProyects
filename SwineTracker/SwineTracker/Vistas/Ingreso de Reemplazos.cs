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
    public partial class Ingreso_de_Reemplazos : Form
    {
        public Ingreso_de_Reemplazos()
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           if(!string.IsNullOrEmpty(txtHembra.Text) || !string.IsNullOrWhiteSpace(txtHembra.Text))
            {
                Swine swine = new Swine();
                Main main = new Main();
                string arete = txtHembra.Text;
                swine = main.ExisteArete(arete);

                if (swine.getArete() == null)
                {
                    DateTime dateNacimiento = fechaNacimiento.Value;
                    DateTime dateIngreso = fechaIngreso.Value;
                    swine.setArete(arete);
                    swine.setFechaIngreso(dateIngreso.Date.ToString("dd-MM-yyyy"));
                    swine.setfechaNacimiento(dateNacimiento.Date.ToString("dd-MM-yyyy"));
                    swine.setActiva(1);
                    if (string.IsNullOrWhiteSpace(txtAreteMadre.Text) == true || string.IsNullOrEmpty(txtAreteMadre.Text) == true ||
                        string.IsNullOrWhiteSpace(txtAretePadre.Text) == true || string.IsNullOrEmpty(txtAretePadre.Text) == true ||
                        string.IsNullOrWhiteSpace(txtHembra.Text) == true || string.IsNullOrEmpty(txtHembra.Text) == true)
                    {
                        MessageBox.Show("Hay campos sin llenar en el formulario");
                    }
                    else
                    {
                        if (txtAreteMadre.Text == txtAretePadre.Text || txtAreteMadre.Text == txtHembra.Text || txtAretePadre.Text == txtHembra.Text)
                        {
                            MessageBox.Show("Error en ingreso de datos, valores repetidos");
                        }
                        else
                        {
                            swine.setAreteMadre(txtAreteMadre.Text);
                            swine.setIdPadre(txtAretePadre.Text);
                            main.Insert(swine.ConvertString());
                            MessageBox.Show("Ingreso con éxito");
                            fechaIngreso.ResetText();
                            fechaNacimiento.ResetText();
                            txtHembra.Clear();
                            txtAreteMadre.Clear();
                            txtAretePadre.Clear();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El arete que ingresó ya existe");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar el arete de una hembra para continuar");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.LightGray;
            btnClose.Size = new Size(25, 25);
        }
        
        private void btnMin_MouseHover(object sender, EventArgs e)
        {
            btnMin.BackColor = Color.LightGray;
            btnMin.Size = new Size(25, 25);
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Transparent;
            btnClose.Size = new Size(25, 25);
        }
      
        private void btnMin_MouseLeave(object sender, EventArgs e)
        {
            btnMin.BackColor = Color.Transparent;
            btnMin.Size = new Size(25, 25);
        }

        private void btnMin_Click(object sender, EventArgs e)
        {

        }
    }
}
