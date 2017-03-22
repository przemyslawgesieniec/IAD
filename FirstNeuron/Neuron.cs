using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstNeuron
{
    public class Neuron
    {
        public double Weight1 { get; set; }
        public double Weight2 { get; set; }
        public double BiasWeight { get; set; }
        public int CalculatedValue { get; set; }
        private double _bias = 1;
        public Neuron()
        {
            Random random = new Random();
            Weight1 = random.NextDouble();
            Weight2 = random.NextDouble();
            BiasWeight = 1; // random.NextDouble();
        }
        public void learn(double in1, double in2, int expectedValue)
        {
            CalculatedValue = calculateNeuronOutput(in1, in2);
            if(CalculatedValue == 1 && expectedValue == 0)
            {
                Weight1 += CalculatedValue * in1;
                Weight2 += CalculatedValue * in2;
            }
            else if(CalculatedValue == 0 && expectedValue == 1)
            {
                Weight1 -= CalculatedValue * in1;
                Weight2 -= CalculatedValue * in2;
            }      
        }
        private int calculateNeuronOutput(double in1, double in2)
        {
            double neuronOutput = Weight1 * in1 + Weight2 * in2 + BiasWeight * _bias;
            return perceptronRule(neuronOutput);
        }
        private int perceptronRule(double neuronOutput)
        {
            return neuronOutput >= 0 ? 1 : 0;
        }
    }
}