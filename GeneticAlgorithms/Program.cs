using System;

namespace GeneticAlgorithms
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Equations equations = new Equations();
            Populations populations = new Populations();

            SolveEquation(populations, equations);
        }

        private static void SolveEquation(Populations populations, Equations equations)
        {
            bool adaptedIndividual = false;
            bool mix = true;
            int indexOfAdaptedIndividual = 0;
            int counter = 0;

            while (!adaptedIndividual)
            {
                for (int i = 0; i < 20; i++)
                {
                    for (int g = 0; g < 8; g++)
                    {
                        double score = 0;

                        for (int j = 0; j < 8; j++)
                        {
                             score += equations.Equation[g, j] * populations.Individuals[i].Members[j];
                        }

                        populations.Individuals[i].Score += equations.BTable[g] - score;
                    }
                }

                populations.SortIndividuals();

                counter = 0;
                foreach (var adaptation in populations.Individuals)
                {
                    if (adaptation.Score < 1 && adaptation.Score >= 0)
                    {
                        adaptedIndividual = true;
                        indexOfAdaptedIndividual = counter;
                        mix = false;
                    }
                    counter++;
                }

                if (mix)
                {
                    for (int i = 2; i < 18;)
                    {
                        for (int g = 4; g < 8; g++)
                        {
                            double temp = populations.Individuals[i + 1].Members[g];
                            populations.Individuals[i + 1].Members[g] = populations.Individuals[i].Members[g];
                            populations.Individuals[i].Members[g] = temp;
                        }

                        i += 2;
                    }

                    populations.ResetScore();
                }
                else
                {
                    Console.WriteLine("Adapted individual:");
                    for (int j = 0; j < 8; j++)
                    {
                        Console.WriteLine(populations.Individuals[indexOfAdaptedIndividual].Members[j] + " ");
                    }

                    Console.WriteLine("Score: " + populations.Individuals[indexOfAdaptedIndividual].Score);
                    Console.WriteLine();
                }
            }
        }
    }
}