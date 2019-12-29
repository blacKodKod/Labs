using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Exs2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const double _diameter = 30;
        private const double _edgeLabelSize = 20;

        private const int _fontSize = 12;
        private const int _edgeFontSize = 10;

        private List<Node> _nodes;
        private List<Edge> _edges;
        private List<Edge> _mst;
        private List<Cluster> _clusters;

        private Node _edgeNode1, _edgeNode2;
        private SolidColorBrush _unvisitedBrush, _visitedBrush;
        private int _count;

        public MainWindow()
        {
            InitializeComponent();

            drawingCanvas.SetValue(Canvas.ZIndexProperty, 0);

            _nodes = new List<Node>();
            _edges = new List<Edge>();

            _mst = new List<Edge>();
            _clusters = new List<Cluster>();

            _count = 1;

            _unvisitedBrush = new SolidColorBrush(Colors.Black);
            _visitedBrush = new SolidColorBrush(Colors.LawnGreen);
        }

        private void drawingCanvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Released)
            {
                Point clickPoint = e.GetPosition(drawingCanvas);

                if (HasClickedOnNode(clickPoint.X, clickPoint.Y))
                {
                    AssignEndNodes(clickPoint.X, clickPoint.Y);
                    if (_edgeNode1 != null && _edgeNode2 != null)
                    {

                        double distance = GetEdgeDistance();
                        if (distance != 0.0)
                        {
                            Edge edge = CreateEdge(_edgeNode1, _edgeNode2, distance);
                            _edges.Add(edge);
                            PaintEdge(edge);
                        }
                        ClearEdgeNodes();
                    }
                }
                else
                {
                    if (!OverlapsNode(clickPoint))
                    {
                        Node n = CreateNode(clickPoint);
                        _nodes.Add(n);
                        PaintNode(n);
                        _count++;
                        ClearEdgeNodes();
                    }
                }
            }
        }

        private bool HasClickedOnNode(double x, double y)
        {
            bool rez = false;

            for (int i = 0; i < _nodes.Count; i++)
            {
                if (_nodes[i].HasPoint(new Point(x, y)))
                {
                    rez = true;
                    break;
                }
            }
            return rez;
        }

        private Node GetNodeAt(double x, double y)
        {
            Node rez = null;
            for (int i = 0; i < _nodes.Count; i++)
            {
                if (_nodes[i].HasPoint(new Point(x, y)))
                {
                    rez = _nodes[i];
                    break;
                }
            }
            return rez;
        }

        private bool OverlapsNode(Point p)
        {
            bool rez = false;
            double distance;

            for (int i = 0; i < _nodes.Count; i++)
            {
                distance = GetDistance(p, _nodes[i].Center);
                if (distance < _diameter)
                {
                    rez = true;
                    break;
                }
            }
            return rez;
        }

        private double GetEdgeDistance()
        {
            double distance = 0.0;
            DistanceDialog dd = new DistanceDialog();
            dd.Owner = this;

            dd.ShowDialog();
            distance = dd.Distance;

            return distance;
        }

        private double GetDistance(Point p1, Point p2)
        {
            double xSq = Math.Pow(p1.X - p2.X, 2);
            double ySq = Math.Pow(p1.Y - p2.Y, 2);
            double dist = Math.Sqrt(xSq + ySq);

            return dist;
        }

        private void AssignEndNodes(double x, double y)
        {
            Node currentNode = GetNodeAt(x, y);

            if (currentNode != null)
            {
                if (_edgeNode1 == null)
                {
                    _edgeNode1 = currentNode;
                    statusLabel.Content = "Ви вибрали вершину: " + currentNode.Label + ". Будь-ласка виберіть іншу вершину.";
                }
                else
                {
                    if (currentNode != _edgeNode1)
                    {
                        _edgeNode2 = currentNode;
                        statusLabel.Content = "Натисніть на поверхню для того щоб створити вершину.";
                    }
                }
            }
        }

        private Node CreateNode(Point p)
        {
            double nodeCenterX = p.X - _diameter / 2;
            double nodeCenterY = p.Y - _diameter / 2;

            Node newNode = new Node(new Point(nodeCenterX, nodeCenterY), p, _count.ToString(), _diameter);
            Cluster c = new Cluster(newNode.Label);
            c.AddNode(newNode);
            newNode.Cluster = c;
            _clusters.Add(c);

            return newNode;
        }

        private void PaintNode(Node node)
        {
            Ellipse ellipse = new Ellipse();

            if (node.Visited)
                ellipse.Fill = _visitedBrush;
            else
                ellipse.Fill = _unvisitedBrush;

            ellipse.Width = _diameter;
            ellipse.Height = _diameter;

            ellipse.SetValue(Canvas.LeftProperty, node.Location.X);
            ellipse.SetValue(Canvas.TopProperty, node.Location.Y);
            ellipse.SetValue(Canvas.ZIndexProperty, 2);

            drawingCanvas.Children.Add(ellipse);

            TextBlock tb = new TextBlock();
            tb.Text = node.Label;
            tb.Foreground = Brushes.Red;
            tb.FontSize = _fontSize;
            tb.TextAlignment = TextAlignment.Center;

            tb.SetValue(Canvas.LeftProperty, node.Center.X - (_fontSize / 4 * node.Label.Length));
            tb.SetValue(Canvas.TopProperty, node.Center.Y - _fontSize / 2);
            tb.SetValue(Canvas.ZIndexProperty, 3);

            drawingCanvas.Children.Add(tb);
        }

        private Edge CreateEdge(Node node1, Node node2, double distance)
        {
            return new Edge(node1, node2, distance);
        }

        private void PaintEdge(Edge edge)
        {
            Line line = new Line();
            line.X1 = edge.FirstNode.Center.X;
            line.X2 = edge.SecondNode.Center.X;

            line.Y1 = edge.FirstNode.Center.Y;
            line.Y2 = edge.SecondNode.Center.Y;

            if (edge.Visited)
                line.Stroke = _visitedBrush;
            else
                line.Stroke = _unvisitedBrush;

            line.StrokeThickness = 1;
            line.SetValue(Canvas.ZIndexProperty, 1);
            drawingCanvas.Children.Add(line);
            Point edgeLabelPoint = GetEdgeLabelCoordinate(edge);

            TextBlock tb = new TextBlock();
            tb.Text = edge.Length.ToString();
            tb.Foreground = Brushes.White;

            if (edge.Visited)
                tb.Background = _visitedBrush;
            else
                tb.Background = _unvisitedBrush;

            tb.Padding = new Thickness(5);
            tb.FontSize = _edgeFontSize;

            tb.MinWidth = _edgeLabelSize;
            tb.MinHeight = _edgeLabelSize;

            tb.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
            tb.VerticalAlignment = System.Windows.VerticalAlignment.Center;
            tb.TextAlignment = TextAlignment.Center;

            tb.SetValue(Canvas.LeftProperty, edgeLabelPoint.X);
            tb.SetValue(Canvas.TopProperty, edgeLabelPoint.Y);
            tb.SetValue(Canvas.ZIndexProperty, 2);
            drawingCanvas.Children.Add(tb);
        }

        private Point GetEdgeLabelCoordinate(Edge edge)
        {
            double x = Math.Abs(edge.FirstNode.Location.X - edge.SecondNode.Location.X) / 2;
            double y = Math.Abs(edge.FirstNode.Location.Y - edge.SecondNode.Location.Y) / 2;

            if (edge.FirstNode.Location.X > edge.SecondNode.Location.X)
                x += edge.SecondNode.Location.X;
            else
                x += edge.FirstNode.Location.X;

            if (edge.FirstNode.Location.Y > edge.SecondNode.Location.Y)
                y += edge.SecondNode.Location.Y;
            else
                y += edge.FirstNode.Location.Y;

            return new Point(x, y);
        }

        private void ClearEdgeNodes()
        {
            _edgeNode1 = _edgeNode2 = null;
        }

        private void findMinSpanTreeBtn_Click(object sender, RoutedEventArgs e)
        {
            statusLabel.Content = "Підрахунок...";
            LaunchMinSpanTreeTask();
        }

        // алгоритм Краскала
        private void LaunchMinSpanTreeTask()
        {
            Task.Factory.StartNew(() =>
                FindMinSpanTree()
                )
                .ContinueWith((task) =>
                {
                    foreach (Edge e in _mst)
                    {
                        e.Visited = true;
                        PaintEdge(e);
                        PaintNode(e.FirstNode);
                        PaintNode(e.SecondNode);
                    }

                    statusLabel.Content = "Повна вартість: " + task.Result.ToString("n0");
                },
                TaskScheduler.FromCurrentSynchronizationContext());
        }

        /// алгоритм Краскала
        private double FindMinSpanTree()
        {
            _mst.Clear();

            List<Node> forest = new List<Node>();

            _edges.Sort();
            double totalCost = 0;

            foreach (Edge currentEdge in _edges)
            {
                if (_clusters.Count == 1)
                    break;

                Cluster cluster1 = currentEdge.FirstNode.Cluster;
                Cluster cluster2 = currentEdge.SecondNode.Cluster;

                if (cluster1.Label != cluster2.Label)
                {
                    _mst.Add(currentEdge);

                    totalCost += currentEdge.Length;
                    currentEdge.FirstNode.Visited = true;
                    currentEdge.SecondNode.Visited = true;

                    MergeClusters(cluster1, cluster2);
                }
            }
            return totalCost;
        }

        private void MergeClusters(Cluster cluster1, Cluster cluster2)
        {
            List<Node> nodeList = cluster2.GetNodeList();
            foreach (Node n in nodeList)
            {
                cluster1.AddNode(n);
                n.Cluster = cluster1;
            }
            _clusters.Remove(cluster2);
        }

        private void PaintAllNodes()
        {
            foreach (Node n in _nodes)
                PaintNode(n);
        }

        private void PaintAllEdges()
        {
            foreach (Edge e in _edges)
                PaintEdge(e);
        }

        private void Clear()
        {
            this._nodes.Clear();
            this._edges.Clear();
            this._mst.Clear();
            this._clusters.Clear();
            this._count = 1;
        }

        private void Restart()
        {
            this._mst.Clear();
            this._clusters.Clear();

            foreach (Node n in _nodes)
            {
                n.Visited = false;

                n.Cluster = new Cluster(n.Label);

                n.Cluster.AddNode(n);

                _clusters.Add(n.Cluster);
            }
            foreach (Edge e in _edges)
                e.Visited = false;
        }
        
        private void clearBtn_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            drawingCanvas.Children.Clear();
        }

        private void restartBtn_Click(object sender, RoutedEventArgs e)
        {
            Restart();
            PaintAllNodes();
            PaintAllEdges();
        }
    }
}
