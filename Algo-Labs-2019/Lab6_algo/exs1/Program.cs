using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exs1
{
    class Program
    {
        class Graph
        {
            public int[,] Adjacency { get; set; }

            public Graph(int numberOfVertices)
            {
                Adjacency = new int[numberOfVertices, numberOfVertices];
            }

            public void AddEdge(int firstVerticeId, int secondVerticeId, int weight)
            {
                Adjacency[firstVerticeId, secondVerticeId] = weight;
                Adjacency[secondVerticeId, firstVerticeId] = weight;
            }

            public void BFS(int startVerticeId, int endVerticeId)
            {
                Stack<int> visited = new Stack<int>();
                Queue<int> childs = new Queue<int>();

                childs.Enqueue(startVerticeId);

                while (childs.Count != 0)
                {
                    var vertice = childs.Dequeue();
                    Console.Write(Enum.GetName(typeof(Cities), vertice) + " ->  ");

                    visited.Push(vertice);
                    var verticeChilds = getChilds(vertice);

                    foreach (var child in verticeChilds)
                    {
                        if (visited.Contains(child))
                            continue;
                        
                        childs.Enqueue(child);
                        Console.Write(Enum.GetName(typeof(Cities), child) + "; ");
                    }
                    Console.WriteLine("");
                }
            }

            public bool DFS(int startVerticeId, int endVerticeId)
            {
                Stack<int> visited = new Stack<int>();
                visited.Push(startVerticeId);

                for (int i = startVerticeId; i < Adjacency.GetLength(0);)
                {
                    for (int j = 0; ; j++)
                    {                        
                        if (j < Adjacency.GetLength(0))
                        {
                            if (Adjacency[i, j] != 0)
                            {
                                if (j == endVerticeId)
                                {
                                    visited.Push(j);
                                    displayPath(visited);
                                    return true;
                                }
                                else if (!visited.Contains(j))
                                {
                                    visited.Push(j);

                                    i = j;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            if (visited.Count == 1)
                                return false;

                            j = visited.Pop();
                            i = visited.First();
                        }
                    }
                }
                return false;
            }

            //Вспомагательные методы
            private void displayPath(IEnumerable<int> path)
            {
                Console.WriteLine(getTotalWeight(path));

                foreach (var item in path)
                {
                    Console.Write(Enum.GetName(typeof(Cities), item) + " <- ");
                }
            }

            private int getTotalWeight(IEnumerable<int> path)
            {
                var vertice = path.ToArray<int>();
                int total = 0;
                for (int i = 0; i < vertice.Length - 1; i++)
                {
                    total += Adjacency[vertice[i], vertice[i + 1]];
                }
                return total;
            }

            private int getChild(int verticeId, int offset)
            {
                for (int i = offset; i < Adjacency.GetLength(0); i++)
                {
                    if (Adjacency[verticeId, i] != 0)
                        return i;
                }
                return -1;
            }

            private List<int> getChilds(int verticeId)
            {
                List<int> result = new List<int>();

                for (int i = 0; i < Adjacency.GetLength(0); i++)
                {
                    if (Adjacency[verticeId, i] != 0)
                        result.Add(i);
                }
                return result;
            }
        }

        enum Cities
        {
            Киев,
            Житомир,
            Новоград_Волынський,
            Ровно,
            Луцк,
            Бердичев,
            Винница,
            Хмельницький,
            Тернополь,
            Шепетовка,
            Белая_Церковь,
            Умань,
            Черкассы,
            Кременчуг,
            Полтава,
            Харьков,
            Прилуки,
            Сумы,
            Миргород
        }

        static void Main(string[] args)
        {
            Graph graph = new Graph(19);

            graph.AddEdge((int)Cities.Киев, (int)Cities.Житомир, 135);
            graph.AddEdge((int)Cities.Киев, (int)Cities.Белая_Церковь, 78);
            graph.AddEdge((int)Cities.Киев, (int)Cities.Прилуки, 128);
            graph.AddEdge((int)Cities.Житомир, (int)Cities.Новоград_Волынський, 80);
            graph.AddEdge((int)Cities.Новоград_Волынський, (int)Cities.Ровно, 100);
            graph.AddEdge((int)Cities.Ровно, (int)Cities.Луцк, 68);
            graph.AddEdge((int)Cities.Житомир, (int)Cities.Бердичев, 38);
            graph.AddEdge((int)Cities.Бердичев, (int)Cities.Винница, 73);
            graph.AddEdge((int)Cities.Винница, (int)Cities.Хмельницький, 110);
            graph.AddEdge((int)Cities.Хмельницький, (int)Cities.Тернополь, 104);
            graph.AddEdge((int)Cities.Житомир, (int)Cities.Шепетовка, 115);
            graph.AddEdge((int)Cities.Белая_Церковь, (int)Cities.Умань, 115);
            graph.AddEdge((int)Cities.Белая_Церковь, (int)Cities.Черкассы, 146);
            graph.AddEdge((int)Cities.Черкассы, (int)Cities.Кременчуг, 105);
            graph.AddEdge((int)Cities.Белая_Церковь, (int)Cities.Полтава, 181);
            graph.AddEdge((int)Cities.Полтава, (int)Cities.Харьков, 130);
            graph.AddEdge((int)Cities.Прилуки, (int)Cities.Сумы, 175);
            graph.AddEdge((int)Cities.Прилуки, (int)Cities.Миргород, 109);

            Console.WriteLine("--------------");
            graph.BFS((int)Cities.Киев, (int)Cities.Полтава);
            Console.WriteLine("--------------");
            graph.DFS((int)Cities.Киев, (int)Cities.Полтава);

            Console.ReadKey();
        }
    }
}
