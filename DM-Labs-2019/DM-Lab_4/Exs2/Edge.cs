using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs2
{
    class Edge : IComparable<Edge>
    {
        private double _length;
        private Node _firstNode;
        private Node _secondNode;

        private const int _fontSize = 10;
        private bool _visited;

        public Edge(Node firstNode, Node secondNode)
        {
            this._firstNode = firstNode;
            this._secondNode = secondNode;

            _visited = false;
        }

        public Edge(Node firstNode, Node secondNode, double length)
            : this(firstNode, secondNode)
        {
            this._length = length;
        }

        public Node FirstNode
        {
            get { return this._firstNode; }
            set { this._firstNode = value; }
        }

        public Node SecondNode
        {
            get { return this._secondNode; }
            set { this._secondNode = value; }
        }

        public double Length
        {
            get { return this._length; }
            set { this._length = value; }
        }

        public int CompareTo(Edge otherEdge)
        {
            return this.Length.CompareTo(otherEdge.Length);
        }

        public bool Visited
        {
            get { return _visited; }
            set { this._visited = value; }
        }
    }
}
