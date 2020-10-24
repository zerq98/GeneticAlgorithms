using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GeneticAlgorithms
{
    public class Equations
    {
        public double[,] Equation { get; set; }
        public double[] BTable { get; set; }

        public Equations()
        {
            Equation = new double[,]
            {
                { -4,-8,-6,-3,4,-3,2,-6},
                {-6,4,9,8,0,-7,-4,0 },
                {0,1,-1,10,-2,-1,-9,-6 },
                {-2,2,9,10,0,2,-10,-6 },
                {5,10,3,7,8,4,-2,5 },
                {1,8,4,0,-1,1,9,-2 },
                {4,-4,-7,0,-6,8,6,6 },
                {-6,-5,7,-7,-2,6,6,3 }
            };

            BTable = new double[] { 154, 119, 67, 136, -136, -75, -200, 49 };
        }
    }
}
