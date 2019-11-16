using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Graph
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
                //Get all childs of vertice
                var vertice = childs.Dequeue();

                Console.Write(Enum.GetName(typeof(Cities), vertice) + "->(");

                //Add to visited
                visited.Push(vertice);

                var verticeChilds = getChilds(vertice);

                //Check all childs of vertice and add if we did'n visited them
                foreach (var child in verticeChilds)
                {
                    //If we already visited the vertice
                    if (visited.Contains(child))
                        continue;

                    //Add to the queue
                    childs.Enqueue(child);
                    Console.Write(Enum.GetName(typeof(Cities), child) + " ");
                }
                Console.WriteLine(")");
            }
        }

        public bool DFS(int startVerticeId, int endVerticeId)
        {
            //Create stack for visited vertices
            Stack<int> visited = new Stack<int>();

            //Add visited vertice
            visited.Push(startVerticeId);

            for (int i = startVerticeId; i < Adjacency.GetLength(0);)
            {
                for (int j = 0; ; j++)
                {
                    // Check if we don't get out a range of array
                    if (j < Adjacency.GetLength(0))
                    {

                        // Check, if there is path betwen vertices(have any weight)
                        if (Adjacency[i, j] != 0)
                        {
                            //Check if it is required vertex
                            if (j == endVerticeId)
                            {

                                //if yes, add to visited and display path
                                visited.Push(j);
                                displayPath(visited);
                                return true;
                            }

                            // Check if we have visited vertice before
                            else if (!visited.Contains(j))
                            {
                                //if no add to visited vertices
                                visited.Push(j);

                                i = j;
                                break;
                            }
                        }
                    }

                    //If go out the range
                    else
                    {
                        // Check the visited stack on emptiness
                        if (visited.Count == 1)
                            return false;

                        //Go back to parent and continue search
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

        // Get first chield of vertice
        // return -1 if vertice doesn't have any child
        private int getChild(int verticeId, int offset)
        {
            //Looking for verticeId and copy child
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

            //Looking for verticeId and copy child
            for (int i = 0; i < Adjacency.GetLength(0); i++)
            {
                if (Adjacency[verticeId, i] != 0)
                    result.Add(i);
            }
            return result;
        }
    }
}
