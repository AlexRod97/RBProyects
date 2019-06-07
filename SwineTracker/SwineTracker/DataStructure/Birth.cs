using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwineTracker.DataStructure
{
    public class Birth
    {
        private string fechaParto;
        private int totalNacidos;
        private int nacidosVivos;
        private int nacidosMuertos;
        private int nacidosMomias;
        public List<int> pesos = new List<int>(); 

        public string getFechaParto()
        {
            return this.fechaParto;
        }

        public void setFechaParto(string item)
        {
            this.fechaParto = item;
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

        public int getNacidosMomias()
        {
            return this.nacidosMomias;
        }

        public void setNacidosMomias(int item)
        {
            this.nacidosMomias = item;
        }


    }
}
