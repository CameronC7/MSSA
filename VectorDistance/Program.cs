using System;

namespace VectorDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector2D vector2D = new Vector2D();
            vector2D.PrintClosestPair();
            Vector3D vector3D = new Vector3D();
            vector3D.PrintClosestPair();
        }
    }
}
