using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwineTracker.DataStructure
{
    public class Birth
    {
        private string fechaInseminacion = "-";
        private string lote = "-"; 
        private string fechaConfirmacion21 = "-";
        private string fechaConfirmacion28 = "-";
        private string fechaFalsaPreniez = "-";
        private string fechaPosibleParto = "-";
        private string fechaParto = "-";
        private int totalNacidos;
        private int totalMachos;
        private int totalHembras;
        private int nacidosVivos;
        private int nacidosMuertos;
        private int nacidosMomias;

        private int MovimientoLechones;
        private double porcentajeMortalidad;
        private double pesoPrimeraInseminacion;
        private string tipoInseminacion = "Tipo inseminacion"; 
        private double grasaDorsal;
        private int CantidadTetas;
        private string TipoBaja = "Tipo baja"; 

        public List<int> pesos = new List<int>();

        #region methods
        public string getFechaInseminacion()
        {
            return this.fechaInseminacion;
        }

        public void setFechaInseminacion(string item)
        {
            this.fechaInseminacion = item;
        }

        public string getLote()
        {
            return this.lote;
        }

        public void setLote(string item)
        {
            this.lote = item;
        }

        public string getFechaConfirmacion21()
        {
            return this.fechaConfirmacion21;
        }

        public void setFechaConfirmacion21(string item)
        {
            this.fechaConfirmacion21 = item;
        }

        public string getFechaConfirmacion28()
        {
            return this.fechaConfirmacion28;
        }

        public void setFechaConfirmacion28(string item)
        {
            this.fechaConfirmacion28 = item;
        }

        public string getFechaFalsaPreniez()
        {
            return this.fechaFalsaPreniez;
        }

        public void setFechaFalsaPreniez(string item)
        {
            this.fechaFalsaPreniez = item;
        }

        public string getFechaPosibleParto()
        {
            return this.fechaPosibleParto;
        }

        public void setFechaPosibleParto(string item)
        {
            this.fechaPosibleParto = item;
        }

        public string getFechaParto()
        {
            return this.fechaParto;
        }

        public void setFechaParto(string item)
        {
            this.fechaParto = item;
        }

        public int getTotalMachos()
        {
            return this.totalMachos;
        }

        public void setTotalMachos(int item)
        {
            this.totalMachos = item;
        }

        public int getTotalHembras()
        {
            return this.totalHembras;
        }

        public void setTotalHembras(int item)
        {
            this.totalHembras = item;
        }

        public int getTotalNacidos()
        {
            return this.totalNacidos;
        }

        public void setTotalNacidos(int item)
        {
            this.totalNacidos = item;
        }

        public int getNacidosVivos()
        {
            return this.nacidosVivos;
        }

        public void setNacidosVivos(int item)
        {
            this.nacidosVivos = item;
        }       

        public int getNacidosMuertos()
        {
            return this.nacidosMuertos;
        }

        public void setNacidosMuertos(int item)
        {
            this.nacidosMuertos = item;
        }

        public int getNacidosMomias()
        {
            return this.nacidosMomias;
        }

        public void setNacidosMomias(int item)
        {
            this.nacidosMomias = item;
        }
        #endregion

        public int getMovimientoLechones()
        {
            return this.MovimientoLechones;
        }

        public void setMovimientoLechones(int item)
        {
            this.MovimientoLechones = item;
        }

        public double getPorcentajeMortalidad()
        {
            return this.porcentajeMortalidad;
        }

        public void setPorcentajeMortalidad(double item)
        {
            this.porcentajeMortalidad = item;
        }

        public double getPesoPrimeraInseminacion()
        {
            return this.pesoPrimeraInseminacion;
        }

        public void setPesoPrimeraInseminacion(double item)
        {
            this.pesoPrimeraInseminacion = item;
        }

        public string getTipoInseminacion()
        {
            return this.tipoInseminacion;
        }

        public void setTipoInseminacion(string item)
        {
            this.tipoInseminacion = item;
        }

        public double getGrasaDorsal()
        {
            return this.grasaDorsal;
        }

        public void setGrasaDorsal(double item)
        {
            this.grasaDorsal = item;
        }

        public int getCantidadTetas()
        {
            return this.CantidadTetas;
        }

        public void setCantidadTetas(int item)
        {
            this.CantidadTetas = item;
        }

        public string getTipoBaja()
        {
            return this.TipoBaja;
        }

        public void setTipoBaja(string item)
        {
            this.TipoBaja = item;
        }

        public string ConvertString()
        {
            StringBuilder line = new StringBuilder();

            line.Append("@");

            line.Append(getFechaInseminacion());
            line.Append("|");
            line.Append(getLote());
            line.Append("|");
            line.Append(getFechaConfirmacion21());
            line.Append("|");
            line.Append(getFechaConfirmacion28());
            line.Append("|");
            line.Append(getFechaFalsaPreniez());
            line.Append("|");
            line.Append(getFechaPosibleParto());
            line.Append("|");
            line.Append(getFechaParto());
            line.Append("|");
            line.Append(getTotalMachos());
            line.Append("|");
            line.Append(getTotalHembras());
            line.Append("|");
            line.Append(getTotalNacidos());
            line.Append("|");
            line.Append(getNacidosVivos());
            line.Append("|");
            line.Append(getNacidosMuertos());
            line.Append("|");
            line.Append(getNacidosMomias());
            line.Append("|");
            line.Append(getMovimientoLechones());
            line.Append("|");
            line.Append(getPorcentajeMortalidad());
            line.Append("|");
            line.Append(getPesoPrimeraInseminacion());
            line.Append("|");
            line.Append(getTipoInseminacion());
            line.Append("|");
            line.Append(getGrasaDorsal());
            line.Append("|");
            line.Append(getCantidadTetas());
            line.Append("|");
            line.Append(getTipoBaja());
            line.Append("|");

            for (int i = 0; i < pesos.Count; i++)
            {
                if (i + 1 < pesos.Count)
                {
                    line.Append(pesos.ElementAt(i) + ",");
                }
                else
                {
                    line.Append(pesos.ElementAt(i));
                }
            }
            
            line.Append("@");

            return line.ToString();
        }
    }
}
