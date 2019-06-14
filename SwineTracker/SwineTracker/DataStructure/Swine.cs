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
        private string fechaIngreso = "-";
        private string fechaNacimiento = "-";
        private string comentario = "-";
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
            return this.totalLechonesVivos;
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

        public string getfechaNacimiento()
        {
            return this.fechaNacimiento;
        }

        public void setfechaNacimiento(string item)
        {
            this.fechaNacimiento = item;
        }

        public string getComentario()
        {
            return this.comentario; 
        }

        public void setComentario(string item)
        {
            this.comentario = item;
        }

        public string ConvertString()
        {
            StringBuilder line = new StringBuilder();

            line.Append("#");
            line.Append(getArete());
            line.Append("|");
            line.Append(getTotalPartos());
            line.Append("|");
            line.Append(getTotalLechonesVivos());
            line.Append("|");
            line.Append(getTotalLechonesMuertos());
            line.Append("|");
            line.Append(getTotalLechonesMomia());
            line.Append("|");
            line.Append(getFechaIngreso());
            line.Append("|");
            line.Append(getfechaNacimiento());
            line.Append("|");
            line.Append(getComentario()); 
            line.Append("|");
            line.Append("#");

            for (int i = 0; i < partos.Count; i++)
            {
                line.Append(partos.ElementAt(i).ConvertString());
            }

            return line.ToString();
        }

    }

}
