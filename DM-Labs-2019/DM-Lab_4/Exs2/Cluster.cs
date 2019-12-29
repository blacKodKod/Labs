using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs2
{
    class Cluster
    {
        private List<Node> _nodes;
        private string _label;

        public Cluster(string label)
        {
            this._nodes = new List<Node>();
            this._label = label;
        }

        public bool HasNode(Node node)
        {
            return _nodes.Contains(node);
        }

        public void AddNode(Node node)
        {
            if (!_nodes.Contains(node))
            {
                _nodes.Add(node);
                node.Cluster = this;
            }
        }

        public string Label
        {
            get { return this._label; }
            set { this._label = value; }
        }

        public void Remove(Node node)
        {
            _nodes.Remove(node);
        }

        public void AddNodeList(List<Node> nodeList)
        {
            foreach (Node n in nodeList)
            {
                AddNode(n);
            }
        }

        public List<Node> GetNodeList()
        {
            return _nodes;
        }
    }
}
