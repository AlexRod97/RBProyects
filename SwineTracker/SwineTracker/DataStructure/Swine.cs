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
        private int activa = 1;
        private string areteMadre;
        private string idPadre;
        private int totalPartos;
        private int totalLechonesVivos;
        private int totalLechonesMuertos;
        private int totalLechonesMomias;
        private string FechaPrimerCelo = "-";
        private string FechaSegundoCelo = "-";
        private string FechaTercerCelo = "-";

        private string fechaIngreso = "-";
        private string fechaNacimiento = "-";
        private string comentario = "No hay comentario";
        
        public List<Birth> partos = new List<Birth>(); 

        public string getArete()
        {
            return this.arete;
        }

        public void setArete(string item)
        {
            this.arete = item;
        }

        public int getActiva()
        {
            return activa; 
        }
        
        public void setActiva(int item)
        {
            activa = item; 
        }

        public string getAreteMadre()
        {
            return areteMadre;
        }

        public void setAreteMadre(string item)
        {
            areteMadre = item; 
        }

        public string getIdPadre()
        {
            return idPadre;
        }

        public void setIdPadre(string item)
        {
            idPadre = item;
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

        public string getFechaPrimerCelo()
        {
            return this.FechaPrimerCelo;
        }

        public void setFechaPrimerCelo(string item)
        {
            this.FechaPrimerCelo = item;
        }

        public string getFechaSegundoCelo()
        {
            return this.FechaSegundoCelo;
        }

        public void setFechaSegundoCelo(string item)
        {
            this.FechaSegundoCelo = item;
        }

        public string getFechaTercerCelo()
        {
            return this.FechaTercerCelo;
        }

        public void setFechaTercerCelo(string item)
        {
            this.FechaTercerCelo = item;
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
            line.Append(getActiva());
            line.Append("|");
            line.Append(getAreteMadre());
            line.Append("|");
            line.Append(getIdPadre());
            line.Append("|");
            line.Append(getTotalPartos());
            line.Append("|");
            line.Append(getTotalLechonesVivos());
            line.Append("|");
            line.Append(getTotalLechonesMuertos());
            line.Append("|");
            line.Append(getTotalLechonesMomia());
            line.Append("|");
            line.Append(getFechaPrimerCelo());
            line.Append("|");
            line.Append(getFechaSegundoCelo());
            line.Append("|");
            line.Append(getFechaTercerCelo());
            line.Append("|");
            line.Append(getFechaIngreso());
            line.Append("|");
            line.Append(getfechaNacimiento());
            line.Append("|");
            line.Append(getComentario());            
            line.Append("#");

            for (int i = 0; i < partos.Count; i++)
            {
                line.Append(partos.ElementAt(i).ConvertString());
            }

            return line.ToString();
        }

        public double PesoPromedio(Swine hembra)
        {
            
            return 0;
        }



    }

}
