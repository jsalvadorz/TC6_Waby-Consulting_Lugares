using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso_01
{
    internal class FloydWarshall
    {
        public const int INF = 99999;

        private static void Imprimir(int[,] distancia, int TotalVertices, string[] lugares)
        {
            Console.Write("LUGAR: \t\t");

            for (int i = 0; i < TotalVertices; ++i)
                Console.Write(lugares[i] + "\t");

            Console.WriteLine();

            for (int i = 0; i < TotalVertices; ++i)
            {
                Console.Write(lugares[i] + "\t");

                for (int j = 0; j < TotalVertices; ++j)
                {
                    if (distancia[i, j] == INF)
                        Console.Write("INF".PadLeft(7));
                    else
                        Console.Write(distancia[i, j] + "\t\t");
                }

                Console.WriteLine();
            }
        }

        public static void FloydWarshallAlgo(int[,] grafo, int TotalVertices, string[] lugares)
        {
            int[,] distancia = new int[TotalVertices, TotalVertices];

            for (int i = 0; i < TotalVertices; ++i)
                for (int j = 0; j < TotalVertices; ++j)
                    distancia[i, j] = grafo[i, j];

            for (int k = 0; k < TotalVertices; ++k)
            {
                for (int i = 0; i < TotalVertices; ++i)
                {
                    for (int j = 0; j < TotalVertices; ++j)
                    {
                        if (distancia[i, k] + distancia[k, j] < distancia[i, j])
                            distancia[i, j] = distancia[i, k] + distancia[k, j];
                    }
                }
            }

            Imprimir(distancia, TotalVertices, lugares);
        }
    }
}
