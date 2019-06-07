using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwineTracker.DataStructure
{
    public class Swine
    {
        private string arete;
        private int totalPartos;
        private int totalLechonesVivos;
        private int totalLechonesMuertos;
        private int totalLechonesMomias;
        private string fechaIngreso;
        private int numSemanas;
        public List<string> fechasInseminacion = new List<string>();
        public List<string> fechasConfirmacion = new List<string>();
        public List<string> fechasFalsaPreniez = new List<string>();
        public List<Birth> partos = new List<Birth>(); 

        public string getArete()
        {
            return this.arete;
        }

        public void setArete(string item)
        {
            this.arete = item;
        }

        public int getTotalPartos()
        {
            return this.totalPartos;
        }

        public void setTotalPartos(int item)
        {
            this.totalPartos = item;
        }

        public int getTotalLechonesVivos()
        {
            return this.totalPartos;
        }

        public void setTotalLechonesVivos(int item)
        {
            this.totalLechonesVivos = item;
        }

        public int getTotalLechonesMuertos()
        {
            return this.totalLechonesMuertos;
        }

        public void setTotalLechonesMuertos(int item)
        {
            this.totalLechonesMuertos = item;
        }

        public int getTotalLechonesMomia()
        {
            return this.totalLechonesMomias;
        }

        public void setTotalLechonesMomia(int item)
        {
            this.totalLechonesMomias = item;

        }

        public string getFechaIngreso()
        {
            return this.fechaIngreso;
        }

        public void setFechaIngreso(string item)
        {
            this.fechaIngreso = item;
        }

        public int getNumSemanas()
        {
            return this.numSemanas;
        }

        public void setNumSemanas(int item)
        {
            this.numSemanas = item;
        }



    }
}
