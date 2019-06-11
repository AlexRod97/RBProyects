using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwineTracker.DataStructure
{
    public class SwineFabric
    {
        List<string> elements = new List<string>();
        List<string> partos = new List<string>();
        List<string> partoComplement = new List<string>();
       
        private string getSubstring(int start, int end, string line)
        {
            StringBuilder result = new StringBuilder();

            for (int i = start; i < end; i++)
            {
                result.Append(line.ElementAt(i));
            }

            return result.ToString();
        }

        public Swine Distribute(string line)
        {
            Swine newSwine = new Swine();
            string Main = "";

            Main = DistribuirMain(line);
            var items = Main.Split('|');

            newSwine.setArete(items.ElementAt(0));
            newSwine.setTotalPartos(Convert.ToInt32(items.ElementAt(1)));
            newSwine.setTotalLechonesVivos(Convert.ToInt32(items.ElementAt(2)));
            newSwine.setTotalLechonesMuertos(Convert.ToInt32(items.ElementAt(3)));
            newSwine.setTotalLechonesMomia(Convert.ToInt32(items.ElementAt(4)));
            newSwine.setFechaIngreso(items.ElementAt(5));
            newSwine.setNumSemanas(Convert.ToInt32(items.ElementAt(6)));
            newSwine.setComentario(items.ElementAt(7));

            DistribuirParto(line);

            for (int i = 0; i < partos.Count; i++)
            {
                Birth newBirth = new Birth();
                items.DefaultIfEmpty(); 
                items = partos.ElementAt(i).Split('|');

                newBirth.setFechaInseminacion(items.ElementAt(0));
                newBirth.setFechaConfirmacion21(items.ElementAt(1));
                newBirth.setFechaConfirmacion28(items.ElementAt(2));
                newBirth.setFechaFalsaPreniez(items.ElementAt(3));
                newBirth.setFechaPosibleParto(items.ElementAt(4));
                newBirth.setFechaParto(items.ElementAt(5));
                newBirth.setTotalMachos(Convert.ToInt32(items.ElementAt(6)));
                newBirth.setTotalHembras(Convert.ToInt32(items.ElementAt(7)));
                newBirth.setTotalNacidos(Convert.ToInt32(items.ElementAt(8)));
                newBirth.setNacidosVivos(Convert.ToInt32(items.ElementAt(9)));
                newBirth.setNacidosMuertos(Convert.ToInt32(items.ElementAt(10)));
                newBirth.setNacidosMomias(Convert.ToInt32(items.ElementAt(11)));
                string temp = items.ElementAt(12);
                var pesosTemp = temp.Split(',');

                for (int j = 0; j < pesosTemp.Count(); j++)
                {
                    newBirth.pesos.Add(Convert.ToInt32(pesosTemp.ElementAt(j)));
                }
                newSwine.partos.Add(newBirth);
            }

            return newSwine;
        }

        private string DistribuirMain(string line)
        {
            int count = 0;
            List<int> positions = new List<int>();
            string result = "";

            foreach (char item in line)
            {
                if (item == '#')
                {
                    positions.Add(count);
                }
                count++;
            }

            result = getSubstring(positions.ElementAt(0) + 1, positions.ElementAt(1), line);

            return result;
        }

        private void DistribuirParto(string line)
        {
            int count = 0;
            List<int> positions = new List<int>();
            StringBuilder result = new StringBuilder();

            foreach (char item in line)
            {
                if (item == '@')
                {
                    positions.Add(count);
                }
                count++;
            }

            count = 0;
            int firstPos = 0, endPos = 1;

            for (int i = 0; i < positions.Count/2; i++)
            {
                int start, end;

                start = positions.ElementAt(firstPos) + 1;
                end = positions.ElementAt(endPos);

                for (int j = start; j < end; j++)
                {
                    result.Append(line.ElementAt(j));
                }
                firstPos = firstPos + 2;
                endPos = endPos + 2;
                partos.Add(result.ToString());
                result.Clear();
            }
           // DistribuirPesos();
        }   
      
       
    }
}
