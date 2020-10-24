using System;
using System.Collections.Generic;
using System.Text;

namespace GeneticAlgorithms
{
    public class Populations
    {
        public double[,] Individuals { get; set; }
        public double[] Adaptation { get; set; }

        public Populations()
        {
            Random random = new Random();
            Individuals = new double[20, 8];

            for(int i = 0; i < 20; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    Individuals[i, j] = random.NextDouble()*10;
                }
            }
        }
    }
}
