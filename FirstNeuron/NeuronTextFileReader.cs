using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstNeuron
{
    class NeuronTextFileReader
    {
        public void readFile(List<float> x1, List<float> x2, List<int> expectedClass)
        {
            string line = null;
            try
            {
                using (StreamReader datafile = new StreamReader("../../data.txt"))
                {
                    while ((line = datafile.ReadLine()) != null)
                    {
                        string[] values = line.Split(',');
                        x1.Add(float.Parse(values[0]));
                        x2.Add(float.Parse(values[1]));
                        expectedClass.Add(int.Parse(values[2]));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Cant read this file");
                Console.WriteLine(e.Message);
            }
        }
    }
}
