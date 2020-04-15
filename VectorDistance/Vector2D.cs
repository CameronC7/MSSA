using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace VectorDistance
{
    class Vector2D
    {
        public VectorSetup[] Vectors { get; }
        public Dictionary<int, VectorSetup> ClosestPair { get; set; }

        public Vector2D()
        {
            Vectors = new VectorSetup[100];
            for (int i = 0; i < 100; i++)
            {
                Random random = new Random();
                double x = random.Next(101);
                double y = random.Next(101);
                Vectors[i] = new VectorSetup(x, y);
            }
            this.Closest2DPair();
        }

        public Dictionary<int, VectorSetup> Closest2DPair()
        {
            Dictionary<int, VectorSetup> outcome = new Dictionary<int, VectorSetup>();
            double t = 0;
            for (int i = 0; i < Vectors.Length; i++)
            {
                for (int k = i + 1; k < Vectors.Length; k++)
                {
                    double dist = CalculateDistance(Vectors[i], Vectors[k]);
                    if (i == 0 || dist < t)
                    {
                        outcome.Clear();
                        outcome.Add(i, Vectors[i]);
                        outcome.Add(k, Vectors[k]);
                        t = dist;
                    }
                }
            }
            return ClosestPair = outcome;
        }

        public double CalculateDistance(VectorSetup a, VectorSetup b)
        {
            double x = a.X - b.X;
            double y = a.Y - b.Y;

            return Math.Sqrt(Math.Abs(x * x) + Math.Abs(y * y));
        }

        public void PrintClosestPair()
        {
            Console.WriteLine("Out of the 100 2D vectors, the following 2 vectors\n");
            foreach (KeyValuePair<int, VectorSetup> item in ClosestPair)
            {
                Console.WriteLine($"{item.Value.X}, {item.Value.Y} at index {item.Key}\n");
            }
            Console.WriteLine("were the closest vectors.\n");
        }
    }
}
