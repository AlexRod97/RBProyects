using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwineTracker.DataStructure
{
    public class SwineFabric
    {
        List<string> elements = new List<string>();

        //Toma la cantidad de elementos contenidos en una cadena en un rango entre start y end
        private string getSubstring(int start, int end, string line)
        {
            StringBuilder result = new StringBuilder();

            for (int i = start; i < end; i++)
            {
                result.Append(line.ElementAt(i));
            }

            return result.ToString();
        }

        //Distribuye la linea completa del archivo de la base de datos
        public Swine Distribute(string line)
        {
            Swine newSwine = new Swine();
            string Main = "";

            Main = DistribuirMain(line); //Obtiene la primera parte (sin dividir) que no depende de partos
            var items = Main.Split('|');

            //Se distribuye cada parametro del archivo en una variable
            newSwine.setArete(items.ElementAt(0));
            newSwine.setActiva(Convert.ToInt32(items.ElementAt(1)));
            newSwine.setAreteMadre(items.ElementAt(2));
            newSwine.setIdPadre(items.ElementAt(3));            
            newSwine.setTotalPartos(Convert.ToInt32(items.ElementAt(4)));
            newSwine.setTotalLechonesVivos(Convert.ToInt32(items.ElementAt(5)));
            newSwine.setTotalLechonesMuertos(Convert.ToInt32(items.ElementAt(6)));
            newSwine.setTotalLechonesMomia(Convert.ToInt32(items.ElementAt(7)));
            newSwine.setFechaPrimerCelo(items.ElementAt(8));
            newSwine.setFechaSegundoCelo(items.ElementAt(9));
            newSwine.setFechaTercerCelo(items.ElementAt(10));
            newSwine.setFechaIngreso(items.ElementAt(11));
            newSwine.setfechaNacimiento(items.ElementAt(12));
            newSwine.setComentario(items.ElementAt(13));

            newSwine.partos = DistribuirParto(line); //Distribuye por parto

            return newSwine;
        }

        private string DistribuirMain(string line)
        {
            int count = 0;
            List<int> positions = new List<int>();
            string result = "";

            //Toma cualquier caracter contenido entre cada #
            foreach (char item in line)
            {
                if (item == '#')
                {
                    positions.Add(count);
                }
                count++;
            }
            //Obtiene la parte de la linea que no depende de los partos y quita el primer y ultimo #
            result = getSubstring(positions.ElementAt(0) + 1, positions.ElementAt(1), line);

            return result;
        }

        private List<Birth> DistribuirParto(string line)
        {
            int count = 0;
            List<int> positions = new List<int>();
            StringBuilder result = new StringBuilder();
            List<Birth> BirthList = new List<Birth>();
            List<string> partos = new List<string>();
            List<string> partoComplement = new List<string>();

            //Obtiene toda la parte que contiene los partos de la hembra
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
            int contador = positions.Count / 2; //Divide dentro de 2 para obtener la cantidad de partos 

            for (int i = 0; i < contador; i++)
            {
                int start, end;

                start = positions.ElementAt(firstPos) + 1; //Establece primer dato quitando @
                end = positions.ElementAt(endPos); //Establece final de datos quitando la @

                //Obtiene la linea (sin dividir) parto por parto
                for (int j = start; j < end; j++)
                {
                    result.Append(line.ElementAt(j)); 
                }
                firstPos = firstPos + 2; //Quita la siguiente @
                endPos = endPos + 2;
                partos.Add(result.ToString());
                result.Clear();
            }

            //Distribuye los valores de los partos que hay en cada linea 
            for (int i = 0; i < partos.Count; i++)
            {

                Birth newBirth = new Birth();
                var items = partos.ElementAt(i).Split('|');

                newBirth.setFechaInseminacion(items.ElementAt(0));
                newBirth.setLote(items.ElementAt(1));
                newBirth.setFechaConfirmacion21(items.ElementAt(2));
                newBirth.setFechaConfirmacion28(items.ElementAt(3));
                newBirth.setFechaFalsaPreniez(items.ElementAt(4));
                newBirth.setFechaPosibleParto(items.ElementAt(5));
                newBirth.setFechaParto(items.ElementAt(6));
                newBirth.setTotalMachos(Convert.ToInt32(items.ElementAt(7)));
                newBirth.setTotalHembras(Convert.ToInt32(items.ElementAt(8)));
                newBirth.setTotalNacidos(Convert.ToInt32(items.ElementAt(9)));
                newBirth.setNacidosVivos(Convert.ToInt32(items.ElementAt(10)));
                newBirth.setNacidosMuertos(Convert.ToInt32(items.ElementAt(11)));
                newBirth.setNacidosMomias(Convert.ToInt32(items.ElementAt(12)));
                newBirth.setMovimientoLechones(Convert.ToInt32(items.ElementAt(13)));
                newBirth.setPorcentajeMortalidad(Convert.ToDouble(items.ElementAt(14)));
                newBirth.setPesoPrimeraInseminacion(Convert.ToDouble(items.ElementAt(15)));
                newBirth.setTipoInseminacion(items.ElementAt(16));
                newBirth.setGrasaDorsal(Convert.ToDouble(items.ElementAt(17)));
                newBirth.setCantidadTetas(Convert.ToInt32(items.ElementAt(18)));
                newBirth.setTipoBaja(items.ElementAt(19));

                string temp = items.ElementAt(20);
                var pesosTemp = temp.Split(','); //Obtiene todos los pesos de manera individual

                //Agrega los pesos a una lista dentr del parto
                for (int j = 0; j < pesosTemp.Count(); j++)
                {
                    newBirth.pesos.Add(Convert.ToInt32(pesosTemp.ElementAt(j)));
                }
                BirthList.Add(newBirth);
            }

            return BirthList;
        }
    }
}
