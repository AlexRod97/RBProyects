using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwineTracker.Data_Structure
{
   public class Main
    {
        private string fileName = @"D:\\Escritorio\\Master.txt";


        public void Insert(string data)
        {
            using (StreamWriter sw = (File.Exists(fileName)) ? File.AppendText(fileName) : File.CreateText(fileName))
            {
                sw.WriteLine(data);
            }

        }

        public void Read()
        {

        }

        public void Update(string updatedData, string oldData)
        {
            StreamReader sr = new StreamReader(fileName);
            string tempName = @"D:\\Escritorio\\temp.txt";
            StreamWriter sw = new StreamWriter(tempName);

            while (!sr.EndOfStream)
            {
                string old = sr.ReadLine();

                if (old != oldData)
                {
                    sw.WriteLine(old);
                }
                else if (old == oldData)
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
    }
}
