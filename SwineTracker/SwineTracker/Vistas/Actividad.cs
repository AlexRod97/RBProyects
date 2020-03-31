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
    
        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipal mp = new MenuPrincipal();
            mp.Show();
            this.Visible = false;
            this.Close();
        }     
       
        private void btnParto_Click(object sender, EventArgs e)
        {
           if((!string.IsNullOrEmpty(txtParto.Text) || !string.IsNullOrWhiteSpace(txtParto.Text)))
            {
                Swine swine = new Swine();
                Main main = new Main();
                string arete = txtParto.Text;
                swine = main.ExisteArete(arete);

                if (swine != null)
                {
                    Birth newBirth = new Birth();

                    DateTime dateParto = fechaParto.Value;
                    int lechonesTotales = Convert.ToInt32(txtLechonesTotales.Text);
                    int lechonesVivos = Convert.ToInt32(txtLechonesVivos.Text);
                    int hembras = Convert.ToInt32(txtHembras.Text);
                    int machos = Convert.ToInt32(txtMachos.Text);
                    int lechonesMuertos = Convert.ToInt32(txtMuertos.Text);
                    int lechonesMomias = Convert.ToInt32(txtMomias.Text);
                    string pesos = txtPesos.Text;

                    int totaGenero = hembras + machos;
                    int totalDistribuido = lechonesVivos + lechonesMuertos + lechonesMomias;

                    if (swine.partos.Count > 0)
                    {
                        newBirth = swine.partos.Last();

                        if (newBirth.getFechaFalsaPreniez().Equals("-"))
                        {
                            if (lechonesTotales == totaGenero && lechonesTotales == totalDistribuido)
                            {
                                newBirth.setFechaParto(dateParto.Date.ToString("dd-MM-yyyy"));
                                newBirth.setTotalNacidos(lechonesTotales);
                                newBirth.setNacidosVivos(lechonesVivos);
                                newBirth.setNacidosMuertos(lechonesMuertos);
                                newBirth.setNacidosMomias(lechonesMomias);
                                newBirth.setTotalHembras(hembras);
                                newBirth.setTotalMachos(machos);
                                newBirth.setMovimientoLechones(Convert.ToInt32(txtMovLechones.Text));
                                //newBirth.setPorcentajeMortalidad();
                                newBirth.setGrasaDorsal(Convert.ToDouble(txtGrasaDorsal.Text));
                                newBirth.setCantidadTetas(Convert.ToInt32(txtCantTetas.Text));
                                newBirth.setTipoBaja(txtTipoBaja.Text);

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

                                    main.Update(swine);

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
                    else if (swine.partos == null || swine.partos.Count == 0 || newBirth.getFechaInseminacion().Equals("-"))
                    {
                        MessageBox.Show("Verifique que la hembra seleccionada haya sido inseminada");
                    }
                }
                else
                {
                    MessageBox.Show("El número de arete que ingresó no existe");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar el arete de una hembra para continuar");
            }
        }

        private void btnInseminacion_Click(object sender, EventArgs e)
        {
           if(!string.IsNullOrEmpty(txtAreteInseminacion.Text) || !string.IsNullOrWhiteSpace(txtAreteInseminacion.Text))
            {
                Swine swine = new Swine();
                Main main = new Main();
                string arete = txtAreteInseminacion.Text;
                swine = main.ExisteArete(arete);

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
                if (swine.getArete() != null)
                {
                    if (swine.partos.Count > 0)
                    {
                        DateTime now = DateTime.Now;
                        Birth birth = swine.partos.Last();
                        string last = birth.getFechaInseminacion();

                        if (last.Equals("-"))
                        {
                            DateTime dateInseminacion = fechaInseminacion.Value;
                            DateTime fechaConfirmacion21 = dateInseminacion.AddDays(21);
                            DateTime fechaConfirmacion28 = dateInseminacion.AddDays(28);
                            //DateTime fechaPosibleParto = dateInseminacion.AddDays(114);
                            Birth newBirth = new Birth();

                            txtConfirmacion21.Text = fechaConfirmacion21.Date.ToString("dd-MM-yyyy");
                            txtConfirmacion28.Text = fechaConfirmacion28.Date.ToString("dd-MM-yyyy");
                            //txtPosibleParto.Text = fechaPosibleParto.Date.ToString("dd-MM-yyyy");
                            string lote = txtLote.Text;

                            if(!string.IsNullOrEmpty(txtLote.Text) || !string.IsNullOrWhiteSpace(txtLote.Text))
                            {
                                newBirth.setFechaInseminacion(dateInseminacion.Date.ToString("dd-MM-yyyy"));
                                newBirth.setLote(lote);
                                newBirth.setFechaConfirmacion21(fechaConfirmacion21.Date.ToString("dd-MM-yyyy"));
                                newBirth.setFechaConfirmacion28(fechaConfirmacion28.Date.ToString("dd-MM-yyyy"));
                                //newBirth.setFechaPosibleParto(fechaPosibleParto.Date.ToString("dd-MM-yyyy"));
                                swine.partos.Add(newBirth);
                                main.Update(swine);
                                MessageBox.Show("Fecha de inseminación ingresada");
                            }
                            else
                            {
                                MessageBox.Show("Debe ingresar el lote de la hembra");
                            }                           
                        }
                        else
                        {
                            MessageBox.Show("La hembra ya está inseminada, verifique fecha de confirmación");
                        }
                    }
                    else
                    {
                        DateTime dateInseminacion = fechaInseminacion.Value;
                        DateTime fechaConfirmacion21 = dateInseminacion.AddDays(21);
                        DateTime fechaConfirmacion28 = dateInseminacion.AddDays(28);
                        Birth newBirth = new Birth();

                        txtConfirmacion21.Text = fechaConfirmacion21.Date.ToString("dd-MM-yyyy");
                        txtConfirmacion28.Text = fechaConfirmacion28.Date.ToString("dd-MM-yyyy");
                        string lote = txtLote.Text;

                        if (!string.IsNullOrEmpty(txtLote.Text) || !string.IsNullOrWhiteSpace(txtLote.Text))
                        {
                            newBirth.setFechaInseminacion(dateInseminacion.Date.ToString("dd-MM-yyyy"));
                            newBirth.setLote(lote);
                            newBirth.setFechaConfirmacion21(fechaConfirmacion21.Date.ToString("dd-MM-yyyy"));
                            newBirth.setFechaConfirmacion28(fechaConfirmacion28.Date.ToString("dd-MM-yyyy"));
                            swine.partos.Add(newBirth);
                            main.Update(swine);
                            MessageBox.Show("Fecha de inseminación ingresada");
                        }
                        else
                        {
                            MessageBox.Show("Debe ingresar el lote de la hembra");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El número de arete que ingresó no existe");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar el arete de una hembra para continuar");
            }
        }
         
        private void btnFalsaPreniez_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAreteInseminacion.Text) || !string.IsNullOrWhiteSpace(txtAreteInseminacion.Text))
            {
                Swine swine = new Swine();
                Main main = new Main();
                string arete = txtAreteInseminacion.Text;
                swine = main.ExisteArete(arete);
              
                if (swine.getArete() != null)
                {
                    if (swine.partos.Count > 0)
                    {
                        DateTime now = DateTime.Now;
                        Birth birth = swine.partos.Last();
                        string last = birth.getFechaInseminacion();
                        DateTime fechaConfirmacion = DateTime.ParseExact(birth.getFechaConfirmacion28(),"dd-MM-yyyy",null);
                        int comparacion = now.CompareTo(fechaConfirmacion);

                        if (comparacion > 0)
                        {
                            DateTime dateFalsaPreniez = fechaFalsaP.Value;
                            int comparacion2 = dateFalsaPreniez.CompareTo(fechaConfirmacion);

                            if(comparacion > 0) //Será necesaria?
                            {
                                string date = dateFalsaPreniez.Date.ToString("dd-MM-yyyy");
                                birth.setFechaFalsaPreniez(date);
                                main.Update(swine);
                            }
                            else
                            {
                                MessageBox.Show("La fecha que ingresó es anterior a la fecha de confirmación");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Aún no han pasado los 28 días de confirmación");
                        }
                    }
                    else
                    {
                        MessageBox.Show("La hembra nunca ha iniciado proceso de embarazo");
                    }
                }
                else
                {
                    MessageBox.Show("El número de arete que ingresó no existe");
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

        private void Actividad_Load(object sender, EventArgs e)
        {
            cbTipoInseminacion.SelectedIndex = 0;
        }
    }
}
