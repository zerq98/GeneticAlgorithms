﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace GeneticAlgorithms
{
    public class Populations
    {
        public List<Individual> Individuals { get; set; }

        public Populations()
        {
            Random random = new Random();
            Individuals = new List<Individual>();

            for (int i = 0; i < 20; i++)
            {
                Individuals.Add(new Individual
                {
                    Members = new double[8],
                    Score = 0
                });
                for (int j = 0; j < 8; j++)
                {
                    Individuals[i].Members[j] = random.NextDouble() * (10+10) - 10;
                }
            }
        }

        public void SortIndividuals()
        {
            Individuals = Individuals.OrderBy(x => x.Score).ToList();
        }

        public void ResetScore()
        {
            foreach (var individual in Individuals)
            {
                individual.Score = 0;
            }

            Random random = new Random();

            for (int j = 0; j < 8; j++)
            {
                Individuals[18].Members[j] = random.NextDouble() * (10 + 10) - 10;
            }

            for (int j = 0; j < 8; j++)
            {
                Individuals[19].Members[j] = random.NextDouble() * (10 + 10) - 10;
            }

            for(int i =0; i < 4; i++)
            {
                Individuals[random.Next(0,17)].Members[random.Next(0, 7)] = random.NextDouble() * (10 + 10) - 10;
            }
        }
    }
}