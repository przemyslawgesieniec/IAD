using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstNeuron
{
    class Program
    {
        private static List<float> x1 = new List<float>();
        private static List<float> x2 = new List<float>();
        private static List<float> y = new List<float>();
        private static List<int> expectedClass = new List<int>();

        static void Main(string[] args)
        {
            NeuronTextFileReader r = new NeuronTextFileReader();
            r.readFile(x1,x2,expectedClass);
            Console.ReadKey();
            Neuron n = new Neuron();
            for (int i = 0; i < x1.Count; i++)
            {
                n.learn(x1[i], x2[i], expectedClass[i]);
                y[i] = n.CalculatedValue;
            }
        }
        


    }
}
