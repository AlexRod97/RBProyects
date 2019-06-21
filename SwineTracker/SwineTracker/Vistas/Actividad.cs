using SwineTracker.DataStructure;
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
    public partial class Actividad : Form
    {
        public Actividad()
        {
            InitializeComponent();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipal mp = new MenuPrincipal();
            mp.Show();
            this.Visible = false;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Swine swine = new Swine();
            Main data = new Main();
            string arete = textBox1.Text.ToUpper();
            swine = data.ExisteArete(arete);

            //Validar fechas anteriores

            /*
             
            DateTime fechaFalsaPreniez = dateTimePicker2.Value;
                Birth newBirth = new Birth();

                newBirth = swine.partos.Last();

                if (!newBirth.getFechaFalsaPreniez().Equals("") && !newBirth.getFechaParto().Equals(""))
                {
                    newBirth.setFechaFalsaPreniez(fechaFalsaPreniez.Date.ToString("dd-MM-yyyy"));
                }
             */
            if (swine != null)
            {
               if(swine.partos.Count > 0)
                {
                    DateTime now = DateTime.Now;
                    Birth birth = swine.partos.Last();
                    string last = birth.getFechaInseminacion();
                    DateTime lastDate = DateTime.ParseExact(last, "dd-MM-yyyy", null);
                    int result = now.CompareTo(lastDate);

                    if(result > 0)
                    {
                        DateTime fechaInseminacion = dateTimePicker1.Value;
                        DateTime fechaConfirmacion21 = fechaInseminacion.AddDays(21);
                        DateTime fechaConfirmacion28 = fechaInseminacion.AddDays(28);
                        Birth newBirth = new Birth();

                        textBox2.Text = fechaConfirmacion21.Date.ToString("dd-MM-yyyy");
                        textBox3.Text = fechaConfirmacion28.Date.ToString("dd-MM-yyyy");
                        string lote = textBox10.Text;

                        newBirth.setFechaInseminacion(fechaInseminacion.Date.ToString("dd-MM-yyyy"));
                        newBirth.setLote(lote);
                        newBirth.setFechaConfirmacion21(fechaConfirmacion21.Date.ToString("dd-MM-yyyy"));
                        newBirth.setFechaConfirmacion28(fechaConfirmacion28.Date.ToString("dd-MM-yyyy"));
                        swine.partos.Add(newBirth);
                        data.Update(swine);
                        MessageBox.Show("Fecha de inseminación ingresada");
                    }
                    else
                    {
                        MessageBox.Show("La hembra sigue en fecha de confirmación"); 
                    }
                }
                else
                {
                    DateTime fechaInseminacion = dateTimePicker1.Value;
                    DateTime fechaConfirmacion21 = fechaInseminacion.AddDays(21);
                    DateTime fechaConfirmacion28 = fechaInseminacion.AddDays(28);
                    Birth newBirth = new Birth();

                    textBox2.Text = fechaConfirmacion21.Date.ToString("dd-MM-yyyy");
                    textBox3.Text = fechaConfirmacion28.Date.ToString("dd-MM-yyyy");
                    string lote = textBox10.Text;

                    newBirth.setFechaInseminacion(fechaInseminacion.Date.ToString("dd-MM-yyyy"));
                    newBirth.setLote(lote);
                    newBirth.setFechaConfirmacion21(fechaConfirmacion21.Date.ToString("dd-MM-yyyy"));
                    newBirth.setFechaConfirmacion28(fechaConfirmacion28.Date.ToString("dd-MM-yyyy"));
                    swine.partos.Add(newBirth);
                    data.Update(swine);
                    MessageBox.Show("Fecha de inseminación ingresada");
                }

            }
            else
            {
                MessageBox.Show("El número de arete que ingresó no existe");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Swine swine = new Swine();
            Main data = new Main();
            string arete = textBox9.Text.ToUpper();
            swine = data.ExisteArete(arete);

            if (swine != null)
            {
                if (swine.partos.Count > 0)
                {
                    DateTime now = DateTime.Now;
                    Birth birth = swine.partos.Last();
                    string last = birth.getFechaConfirmacion28();
                    DateTime lastDate = DateTime.ParseExact(last, "dd-MM-yyyy", null);
                    int result = now.CompareTo(lastDate);

                    if (result > 0)
                    {
                        DateTime fechaInseminacion = dateTimePicker1.Value;
                        DateTime fechaConfirmacion21 = fechaInseminacion.AddDays(21);
                        DateTime fechaConfirmacion28 = fechaInseminacion.AddDays(28);
                        Birth newBirth = new Birth();

                        textBox2.Text = fechaConfirmacion21.Date.ToString("dd-MM-yyyy");
                        textBox3.Text = fechaConfirmacion28.Date.ToString("dd-MM-yyyy");
                        string lote = textBox10.Text;

                        newBirth.setFechaInseminacion(fechaInseminacion.Date.ToString("dd-MM-yyyy"));
                        newBirth.setLote(lote);
                        newBirth.setFechaConfirmacion21(fechaConfirmacion21.Date.ToString("dd-MM-yyyy"));
                        newBirth.setFechaConfirmacion28(fechaConfirmacion28.Date.ToString("dd-MM-yyyy"));
                        swine.partos.Add(newBirth);
                        data.Update(swine);
                        MessageBox.Show("Fecha de inseminación ingresada");
                    }
                    else
                    {
                        MessageBox.Show("La hembra sigue en fecha de confirmación");
                    }
                }
                else
                {
                    DateTime fechaInseminacion = dateTimePicker1.Value;
                    DateTime fechaConfirmacion21 = fechaInseminacion.AddDays(21);
                    DateTime fechaConfirmacion28 = fechaInseminacion.AddDays(28);
                    Birth newBirth = new Birth();

                    textBox2.Text = fechaConfirmacion21.Date.ToString("dd-MM-yyyy");
                    textBox3.Text = fechaConfirmacion28.Date.ToString("dd-MM-yyyy");
                    string lote = textBox10.Text;

                    newBirth.setFechaInseminacion(fechaInseminacion.Date.ToString("dd-MM-yyyy"));
                    newBirth.setLote(lote);
                    newBirth.setFechaConfirmacion21(fechaConfirmacion21.Date.ToString("dd-MM-yyyy"));
                    newBirth.setFechaConfirmacion28(fechaConfirmacion28.Date.ToString("dd-MM-yyyy"));
                    swine.partos.Add(newBirth);
                    data.Update(swine);
                    MessageBox.Show("Fecha de inseminación ingresada");
                }
            }
            else
            {
                MessageBox.Show("El número de arete que ingresó no existe");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Swine swine = new Swine();
            Main data = new Main();
            string arete = textBox4.Text.ToUpper();
            swine = data.ExisteArete(arete);

            if (swine != null)
            {
                Birth newBirth = new Birth();
                

                DateTime fechaParto = dateTimePicker3.Value;
                int lechonesTotales = Convert.ToInt32(maskedTextBox1.Text);
                int lechonesVivos = Convert.ToInt32(maskedTextBox2.Text); 
                int hembras = Convert.ToInt32(maskedTextBox3.Text);
                int machos = Convert.ToInt32(maskedTextBox4.Text);
                int lechonesMuertos = Convert.ToInt32(maskedTextBox5.Text);
                int lechonesMomias = Convert.ToInt32(maskedTextBox6.Text);
                string pesos = maskedTextBox7.Text;

                int total = hembras + machos;
                int totalDistribuido = lechonesVivos + lechonesMuertos + lechonesMomias;

                if(swine.partos.Count > 0)
                {
                    newBirth = swine.partos.Last();
                    
                    if (newBirth.getFechaFalsaPreniez().Equals("-"))
                    {
                        if (lechonesTotales == total && lechonesTotales == totalDistribuido)
                        {
                            newBirth.setFechaParto(fechaParto.Date.ToString("dd-MM-yyyy"));
                            newBirth.setTotalNacidos(lechonesTotales);
                            newBirth.setNacidosVivos(lechonesVivos);
                            newBirth.setNacidosMuertos(lechonesMuertos);
                            newBirth.setNacidosMomias(lechonesMomias);
                            newBirth.setTotalHembras(hembras);
                            newBirth.setTotalMachos(machos);

                            var items = pesos.Split(',');
                            newBirth.pesos.Clear();

                            if (items.Count() == lechonesVivos)
                            {
                                for (int i = 0; i < items.Count(); i++)
                                {
                                    newBirth.pesos.Add(Convert.ToInt32(items.ElementAt(i)));
                                }

                                swine.setTotalPartos(swine.getTotalPartos() + 1);
                                int actualVivos = swine.getTotalLechonesVivos();
                                int actualMuertos = swine.getTotalLechonesMuertos();
                                int actualMomias = swine.getTotalLechonesMomia();

                                swine.setTotalLechonesVivos(actualVivos + lechonesVivos);
                                swine.setTotalLechonesMuertos(actualMuertos + lechonesMuertos);
                                swine.setTotalLechonesMomia(actualMomias + lechonesMomias);

                                data.Update(swine);

                                MessageBox.Show("El parto fue ingresado con éxito");
                            }
                            else
                            {
                                MessageBox.Show("La cantidad de pesos ingresados no coinciden con el total de lechones");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Los datos de hembras/machos o vivos/muertos/momias no coinciden");
                        }
                    }
                    else
                    {
                        MessageBox.Show("La hembra " + swine.getArete() + " no está preñada");
                    }
                }
                else if(swine.partos == null || swine.partos.Count == 0 || newBirth.getFechaInseminacion().Equals("-"))
                {
                    MessageBox.Show("Verifique que la hembra seleccionada haya sido inseminada");
                }
            }
            else
            {
                MessageBox.Show("El número de arete que ingresó no existe");
            }
        }

        private void Actividad_Load(object sender, EventArgs e)
        {

        }
    }
}
