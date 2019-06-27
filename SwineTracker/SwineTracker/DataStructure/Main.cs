using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwineTracker.DataStructure;

namespace SwineTracker.DataStructure
{
   public class Main
    {
        private string fileName = "\\Master.txt", MainfileDirectory = SwineTracker.Properties.Settings.Default.FileDirectory;
        SwineFabric swineFabric = new SwineFabric();
        Swine newSwine = new Swine();
       
        public void BuildDirectory(string fileDirectory)
        {
            MainfileDirectory = fileDirectory;
            fileName = fileDirectory + "\\Master.txt";
            using (StreamWriter sw = (File.Exists(fileName)) ? File.AppendText(fileName) : File.CreateText(fileName))
            {
                sw.Close();
            }
        }

        public void Insert(string data)
        {
            fileName = MainfileDirectory + "\\Master.txt";
            using (StreamWriter sw = (File.Exists(fileName)) ? File.AppendText(fileName) : File.CreateText(fileName))
            {
                sw.WriteLine(data);
                sw.Close();
            }
            
        }

        public void Update(Swine updatedData)
        {
            string oldName = MainfileDirectory + fileName;
            StreamReader sr = new StreamReader(oldName);
            string tempName = MainfileDirectory + "\\temp.txt";
            StreamWriter sw = new StreamWriter(tempName);
            Swine oldSwine = new Swine();

            newSwine = updatedData;

            while (!sr.EndOfStream)
            {
                string old = sr.ReadLine();
                oldSwine = swineFabric.Distribute(old);

                if (newSwine.getArete() != oldSwine.getArete())
                {
                    sw.WriteLine(old);
                }
                else if (newSwine.getArete() == oldSwine.getArete())
                {
                    sw.WriteLine(newSwine.ConvertString());
                }
            }
            sr.Close();
            sw.Close();
            File.Delete(oldName);
            File.Move(tempName, oldName);
        }

        public void Delete(string deleteData)
        {
            StreamReader sr = new StreamReader(MainfileDirectory + fileName);
            string tempName = MainfileDirectory + "\\temp.txt";
            StreamWriter sw = new StreamWriter(tempName);
            newSwine = swineFabric.Distribute(deleteData);

            while (!sr.EndOfStream)
            {
                string old = sr.ReadLine();

                if (old != deleteData)
                {
                    sw.WriteLine(old);
                }
                else if (old == deleteData)
                {
                    continue;
                }
            }
            sr.Close();
            sw.Close();
            File.Delete(fileName);
            File.Move(tempName, fileName);
        }

        public List<Swine> BuscarPorArete(string item)
        {
            StreamReader sr = new StreamReader(MainfileDirectory + fileName);
            List<Swine> results = new List<Swine>();
            Swine oldSwine = new Swine();

            while (!sr.EndOfStream)
            {
                string old = sr.ReadLine();
                oldSwine = swineFabric.Distribute(old);

                if (oldSwine.getArete().Contains(item))
                {
                    results.Add(oldSwine);
                }
            }
            sr.Close();           

            return results;
        }

        public Swine ExisteArete(string item)
        {
            StreamReader sr = new StreamReader(MainfileDirectory + fileName);
            Swine result = new Swine();
            Swine oldSwine = new Swine(); 
            try
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    oldSwine = swineFabric.Distribute(line);

                    if (oldSwine.getArete().Equals(item))
                    {
                        result = oldSwine;
                        break;
                    }
                    else
                    {
                        result = null;
                    }
                }
                sr.Close();
            }
            catch (Exception)
            {
                result = null; 
            }

            return result;
        }

        public Dictionary<Swine, int> SearchByDates(string initialDate, string endDate)
        {
            string oldName = MainfileDirectory + fileName;
            StreamReader sr = new StreamReader(oldName);
            Dictionary<Swine, int> results = new Dictionary<Swine, int>();
            Swine swine = new Swine();           

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                swine = swineFabric.Distribute(line);

                for (int i = 0; i < swine.partos.Count; i++)
                {
                    Birth birth = new Birth();
                    birth = swine.partos.ElementAt(i);

                    if (Convert.ToDateTime(birth.getFechaParto()) >= Convert.ToDateTime(initialDate) && Convert.ToDateTime(birth.getFechaParto()) <= Convert.ToDateTime(endDate))
                    {
                       if(!results.ContainsKey(swine))
                        {
                            results.Add(swine, 1);
                        }
                       else if (results.ContainsKey(swine))
                        {
                            if (results.TryGetValue(swine, out int val))
                            {
                                results[swine] = val + 1;
                            }
                        }
                    }
                }
            }
            sr.Close();          

            return results; 
        }
    }
}
