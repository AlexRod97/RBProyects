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
            List<string> pesos = new List<string>();
            List<int> positions = new List<int>();
            StringBuilder peso = new StringBuilder();
            int count = 0; 

            for (int i = 0; i < partos.Count; i++)
            {
                string element = partos.ElementAt(i);

                foreach (char item in element)
                {
                    if (item == '%')
                    {
                        positions.Add(count);
                    }
                    count++;
                }
                string part = getSubstring(positions.ElementAt(0) + 1, positions.ElementAt(1), element);
                pesos.Add(part);
                positions.Clear();
                count = 0;
            }

        }
    }
}
