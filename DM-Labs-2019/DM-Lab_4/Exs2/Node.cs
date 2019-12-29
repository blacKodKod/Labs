using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Exs2
{
    class Node
    {
        private Point _drawingLocation;
        private Point _center;
        private string _label;
        private double _diameter;
        private const int _fontSize = 10;

        private bool _visited;
        private Cluster _cluster;
        private double _totalCost;
        private Edge _edgeVisitor;

        public Node(Point location, string label, double diameter)
        {
            this._drawingLocation = location;
            this._label = label;
            this._diameter = diameter;
            this._cluster = new Cluster(label);
            _visited = false;
        }

        public Node(Point location, Point center, string label, double diameter)
            : this(location, label, diameter)
        {
            this._center = center;
        }

        public Node(Point location, Point center, string label, double diameter, Cluster cluster)
            : this(location, center, label, diameter)
        {
            this._cluster = cluster;
        }

        public Point Location
        {
            get { return _drawingLocation; }
        }

        public Point Center
        {
            get { return _center; }
            set { this._center = value; }
        }

        public double Diameter
        {
            get { return _diameter; }
        }

        public string Label
        {
            get { return _label; }
        }

        public Cluster Cluster
        {
            get { return _cluster; }
            set { this._cluster = value; }
        }

        public double TotalCost
        {
            get { return _totalCost; }
            set { this._totalCost = value; }
        }

        public Edge EdgeVisitor
        {
            get { return _edgeVisitor; }
            set { this._edgeVisitor = value; }
        }

        public bool HasPoint(Point p)
        {
            double xSq = Math.Pow(p.X - _center.X, 2);
            double ySq = Math.Pow(p.Y - _center.Y, 2);
            double dist = Math.Sqrt(xSq + ySq);

            return (dist <= (_diameter / 2));
        }

        public bool Visited
        {
            get { return _visited; }
            set { this._visited = value; }
        }
    }
}
