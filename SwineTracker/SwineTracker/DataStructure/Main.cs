using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwineTracker.DataStructure;

namespace SwineTracker.Data_Structure
{
   public class Main
    {
        private string fileName = "";
        SwineFabric swineFabric = new SwineFabric();
        Swine newSwine = new Swine();
        Swine oldSwine = new Swine();

        public void BuildDirectory(string fileDirectory)
        {
            fileName = fileDirectory + "\\Master.txt";
            using (StreamWriter sw = (File.Exists(fileName)) ? File.AppendText(fileName) : File.CreateText(fileName))
            {
                sw.Close();
            }


        }

        public void Insert(string data)
        {
            using (StreamWriter sw = (File.Exists(fileName)) ? File.AppendText(fileName) : File.CreateText(fileName))
            {
                sw.WriteLine(data);
            }
        }

        public void Update(string updatedData)
        {
            StreamReader sr = new StreamReader(fileName);
            string tempName = @"D:\\Escritorio\\temp.txt";
            StreamWriter sw = new StreamWriter(tempName);
            newSwine = swineFabric.Distribute(updatedData);

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
                    sw.WriteLine(updatedData);
                }
            }
            sr.Close();
            sw.Close();
            File.Delete(fileName);
            File.Move(tempName, fileName);
        }

        public void Delete(string deleteData)
        {
            StreamReader sr = new StreamReader(fileName);
            string tempName = @"D:\\Escritorio\\temp.txt";
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
            StreamReader sr = new StreamReader(fileName);
            string tempName = @"D:\\Escritorio\\temp.txt";
            StreamWriter sw = new StreamWriter(tempName);
            List<Swine> results = new List<Swine>();

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
            sw.Close();

            return results;
        }
    }
}
