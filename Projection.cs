﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp_Graph6
{
    class Projection
    {
        static float c = 1000;

        static private float[,] perspective =
        {
            { 1, 0, 0, 0},
            { 0, 1, 0, 0},
            { 0, 0, 0, -1 / c },
            { 0, 0, 0, 1 }
        };

        static private float[,] isometric =
            {  { (float)Math.Cos(Math.PI/6), (float)(Math.Sin(Math.PI/6) * Math.Sin(Math.PI/6)), 0, 0 },
               { 0, (float)Math.Cos(Math.PI/6), 0, 0 },
               { (float)(Math.Sin(Math.PI/6)), (float)-(Math.Sin(Math.PI/6) * Math.Cos(Math.PI/6)), 0, 0 },
               { 0, 0, 0, 1 }
        };


        static public float[,] MultMatrix(float[,] m1, float[,] m2)
        {
            float[,] res = new float[m1.GetLength(0), m2.GetLength(1)];

            for (int i = 0; i < m1.GetLength(0); ++i)
                for (int j = 0; j < m2.GetLength(1); ++j)
                    for (int k = 0; k < m2.GetLength(0); k++)
                    {
                        res[i, j] += m1[i, k] * m2[k, j];
                    }

            return res;
        }


        public List<Edge> Project(Figure polyhedron, int mode)
        {

            float[,] matr;
            switch (mode)
            {
                case 0:
                    matr = perspective;
                    break;
                case 1:
                    matr = isometric;
                    break;
                default:
                    throw new ArgumentException();
            }
            List<Edge> edges = new List<Edge>();

            int i = 0;

            foreach (Point3D p in polyhedron.Vertexes)
            {

                Point3D p1 = p;
                float[,] tmp = MultMatrix(new float[,] { { p1.X, p1.Y, p1.Z, 1 } }, matr);
                Point3D from = new Point3D(tmp[0, 0] / tmp[0, 3], tmp[0, 1] / tmp[0, 3]);



                foreach (int index in polyhedron.Adjacency[i])
                {

                    Point3D t = polyhedron.Vertexes[index];

                    float[,] tmp1 = MultMatrix(new float[,] { { t.X, t.Y, t.Z, 1 } }, matr);
                    Point3D to = new Point3D(tmp1[0, 0] / tmp1[0, 3], tmp1[0, 1] / tmp1[0, 3]);
                    edges.Add(new Edge(from, to));
                }
                i++;
            }

            return edges;
        }
    
    }
}
