using System;
using System.Collections.Generic;
using System.Text;

namespace VectorDistance
{
    class Vector3D
    {
        public VectorSetup[] Vectors { get; }
        public Dictionary<int, VectorSetup> ClosestPair { get; set; }

        public Vector3D()
        {
            Vectors = new VectorSetup[1000];
            for (int i = 0; i < 1000; i++)
            {
                Random random = new Random();
                double x = random.Next(1001);
                double y = random.Next(1001);
                double z = random.Next(1001);
                Vectors[i] = new VectorSetup(x, y, z);
            }
            this.Closest3DPair();
        }

        public Dictionary<int, VectorSetup> Closest3DPair()
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
            double z = a.Z - b.Z;

            return Math.Sqrt(Math.Abs(x * x) + Math.Abs(y * y) + Math.Abs(z * z));
        }

        public void PrintClosestPair()
        {
            Console.WriteLine("\nOut of the 1000 3D vectors, the following 2 vectors\n");
            foreach (KeyValuePair<int, VectorSetup> item in ClosestPair)
            {
                Console.WriteLine($"{item.Value.X}, {item.Value.Y}, {item.Value.Z} at index {item.Key}\n");
            }
            Console.WriteLine("were the closest vectors.");
        }
    }
}
