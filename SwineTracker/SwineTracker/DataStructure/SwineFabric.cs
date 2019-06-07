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
        List<string> pesos = new List<string>();

        string characters = "#&|$!";

        public void Distribute(string line)
        {
            int count = 0;
            List<int> positions = new List<int>();

            for (int i = 0; i < characters.Length; i++)
            {
                foreach (char item in line)
                {
                    if (item == characters.ElementAt(i))
                    {
                        positions.Add(count);
                    }
                    count++;
                }
                string part = getSubstring(positions.ElementAt(0) + 1, positions.ElementAt(1), line);
                elements.Add(part);
                positions.Clear();
                count = 0;
            }

            DistribuirParto(line);
        }

        private string getSubstring(int start, int end, string line)
        {
            StringBuilder result = new StringBuilder(); 

            for (int i = start; i < end; i++)
            {
                result.Append(line.ElementAt(i));
            }

            return result.ToString();
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
            }
            DistribuirPesos();
        }

        private void DistribuirPesos()
        {
            List<int> positions = new List<int>();
            List<int> positionsComplement = new List<int>();
            StringBuilder peso = new StringBuilder();
            int count = 0;
            
            for (int i = 0; i < partos.Count; i++)
            {
                string element = partos.ElementAt(i);

                foreach (char item in element)
                {
                    if(item == '?')
                    {
                        positionsComplement.Add(count);
                    }
                    if (item == '%')
                    {
                        positions.Add(count);
                    }
                    count++;
                }
                string part1 = getSubstring(positionsComplement.ElementAt(0) + 1, positionsComplement.ElementAt(1), element);
                string part2 = getSubstring(positions.ElementAt(0) + 1, positions.ElementAt(1), element);
                partoComplement.Add(part1);
                pesos.Add(part2);
                positions.Clear();
                positionsComplement.Clear();
                count = 0;
            }
        }
      
        public Swine AsignarElementos()
        {
            Swine newSwine = new Swine();

            for (int i = 0; i < elements.Count; i++)
            {
                var singles = elements.ElementAt(i).Split(',');

                if(i == 0)
                {
                    newSwine.setArete(singles.ElementAt(0).ToString());
                    newSwine.setTotalPartos(Convert.ToInt32(singles.ElementAt(1)));
                    newSwine.setTotalLechonesVivos(Convert.ToInt32(singles.ElementAt(2)));
                    newSwine.setTotalLechonesMuertos(Convert.ToInt32(singles.ElementAt(3)));
                    newSwine.setTotalLechonesMomia(Convert.ToInt32(singles.ElementAt(4)));
                }

                if(i == 1)
                {
                    newSwine.setFechaIngreso(singles.ElementAt(0).ToString());
                    newSwine.setNumSemanas(Convert.ToInt32(singles.ElementAt(1)));
                }

                if(i == 2) //Fechas de inseminación
                {
                    singles.Cast<List<string>>();

                    for (int j = 0; j < singles.Count(); j++)
                    {
                        newSwine.fechasInseminacion.Add(singles.ElementAt(j));
                    }
                }

                if (i == 3) //Fechas de confirmación
                {
                    singles.Cast<List<string>>();

                    for (int j = 0; j < singles.Count(); j++)
                    {
                        newSwine.fechasConfirmacion.Add(singles.ElementAt(j));
                    }
                }

                if (i == 4) //Fechas de falsa preñez
                {
                    singles.Cast<List<string>>();

                    for (int j = 0; j < singles.Count(); j++)
                    {
                        newSwine.fechasFalsaPreniez.Add(singles.ElementAt(j));
                    }
                }
            }

            Birth newBirth = new Birth();

            for (int i = 0; i < partoComplement.Count; i++)
            {
                var items = partoComplement.ElementAt(i).Split(',');

                newBirth.setFechaParto(items.ElementAt(0).ToString());
                newBirth.setTotalNacidos(Convert.ToInt32(items.ElementAt(1)));
                newBirth.setNacidosVivos(Convert.ToInt32(items.ElementAt(2)));
                newBirth.setNacidosMuertos(Convert.ToInt32(items.ElementAt(3)));
                newBirth.setNacidosMomias(Convert.ToInt32(items.ElementAt(4)));
            }

            for (int i = 0; i < pesos.Count; i++)
            {
                var items = pesos.ElementAt(i).Split(',');

                for (int j = 0; j < items.Count(); j++)
                {
                    newBirth.pesos.Add(Convert.ToInt32(items.ElementAt(j)));
                }
            }
            newSwine.partos.Add(newBirth);

            return newSwine;
        }
    }
}
