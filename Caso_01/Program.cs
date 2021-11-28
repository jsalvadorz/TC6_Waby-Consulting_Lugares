using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lugares
            string[] lugares = new string[5]
            {
                "San Miguel",
                "La Molina",
                "El Callao",
                "San Borja",
                "Magdalena"
            };

            // Ejecución algoritmo de Dijkstra
            int[,] graph_1 =  {
                          { 0,  8,  6,  0, 0 },
                          { 0,  0,  0,  0, 9 },
                          { 0,  0,  0, 16, 0 },
                          { 8, 10,  0,  0, 0 },
                          { 0,  0,  1,  0, 0 }
            };

            Console.WriteLine(">> Dijkstra: Caminos más cortos desde San Miguel a los demás puntos de llegada.\n");
            Dijkstra.DijkstraAlgo(graph_1, 0, 5, lugares);

            // Ejecución algoritmo de Floyd-Warshall
            const int INF = 99999;

            int[,] graph_2 = {
                            {   0,   8,   6, INF, INF },
                            { INF,   0, INF, INF,   9 },
                            { INF, INF,   0,  16, INF },
                            {   8,  10, INF,   0, INF },
                            { INF, INF,   1, INF,   0 }
            };

            Console.WriteLine("\n>> Floyd-Warshall: Caminos más cortos para cada par de puntos.\n");
            FloydWarshall.FloydWarshallAlgo(graph_2, 5, lugares);

            Console.ReadKey();
        }
    }
}
