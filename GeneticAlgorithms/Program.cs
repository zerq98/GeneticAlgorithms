using System;

namespace GeneticAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Equations equations = new Equations();
            Populations populations = new Populations();

            SolveEquation(populations, equations);
        }

        static void SolveEquation(Populations populations,Equations equations)
        {
            populations.Adaptation = new double[20];
            for(int i = 0; i < 20; i++)
            {
                for(int g = 0; g < 8; g++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        populations.Adaptation[i] += equations.Equation[g, j] * populations.Individuals[i, j];
                    }
                }
            }

            Array.Sort(populations.Adaptation);

            for(int i = 0; i < 20; i++)
            {
                Console.WriteLine(populations.Adaptation[i]);
            }
        }
    }
}
