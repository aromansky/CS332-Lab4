using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static CS332_Lab4.Transform;

namespace CS332_Lab4
{
    public class MyPolygon
    {
        private bool recorded = false;
        /// <summary>
        /// Вершины полигона.
        /// </summary>
        private List<PointF> points;

        /// <summary>
        /// Рёбра полигона. Идут в направлении от ранних точек к поздним.
        /// </summary>
        private List<PointF[]> edges;
        public List<PointF> Points { get { return points.Select(p => new PointF(p.X, p.Y)).ToList(); } }
        public List<PointF[]> Edges {
            get
            {
                return edges.Select(edge => new PointF[]
                {
                    new PointF(edge[0].X, edge[0].Y),
                    new PointF(edge[1].X, edge[1].Y)
                }).ToList();
            }
        }

        /// <summary>
        /// Создание пустого полигона
        /// </summary>
        public MyPolygon()
        {
            this.points = new List<PointF>();
            this.edges = new List<PointF[]>();
        }

        /// <summary>
        /// Создание полигона по точкам
        /// </summary>
        /// <param name="points"></param>
        public MyPolygon(List<PointF> points)
        {
            this.points = new List<PointF>(points);
            this.edges = new List<PointF[]>();

            for (int i = 1; i < this.points.Count; i++)
            {
                this.edges.Add(new PointF[2] { this.points[i - 1], this.points[i] });
            }
            this.edges.Add(new PointF[2] { points.Last(), points.First() });
        }

        public MyPolygon(MyPolygon polygon)
        {
            this.points = new List<PointF>(polygon.Points);
            this.edges = new List<PointF[]>();

            for (int i = 1; i < this.points.Count; i++)
            {
                this.edges.Add(new PointF[2] { this.points[i - 1], this.points[i] });
            }
            this.edges.Add(new PointF[2] { points.Last(), points.First() });
        }

        public void AddPoint(PointF point)
        {
            if (!recorded)
            {
                if (CountPoints() == 0)
                {
                    this.points.Add(point);
                }
                else
                {
                    PointF[] edge = new PointF[2] { LastPoint(), point};
                    
                    
                    if (this.edges.Count == 0)
                    {
                        this.edges.Add(edge);

                    }
                    else
                    {
                        this.edges[edges.Count - 1] = edge;
                    }
                    this.points.Add(point);
                    
                    this.edges.Add(new PointF[2] { points.Last(), points.First() });
                }
            }
            else
            {
                throw new InvalidOperationException("Полигон зафиксирован, в него нельзя добавлять вершины!");
            }
        }

        public PointF[] SelectEdge(PointF point, float tolerance = 5f)
        {
            if (edges.Count == 0)
                return null;

            foreach (var edge in edges)
            {
                PointF p1 = edge[0];
                PointF p2 = edge[1];

                if (DistanceToEdge(point, p1, p2) <= tolerance)
                {
                    return new PointF[] { p1, p2 };
                }
            }

            return null;
        }

        private float DistanceToEdge(PointF point, PointF p1, PointF p2)
        {
            float edgeX = p2.X - p1.X;
            float edgeY = p2.Y - p1.Y;

            float pointX = point.X - p1.X;
            float pointY = point.Y - p1.Y;

            float dot = pointX * edgeX + pointY * edgeY;
            float edgeLengthSquared = edgeX * edgeX + edgeY * edgeY;

            float t = Math.Max(0, Math.Min(1, dot / edgeLengthSquared));

            float closestX = p1.X + t * edgeX;
            float closestY = p1.Y + t * edgeY;

            float dx = point.X - closestX;
            float dy = point.Y - closestY;

            return (float)Math.Sqrt(dx * dx + dy * dy);
        }

        // алгоритм трассировки луча
        public bool ContainsPoint(PointF point)
        {
            if (points.Count < 3)
                return false;

            bool inside = false;
            int n = points.Count;

            foreach (PointF[] edge in this.edges)
            {
                PointF p1 = edge[0];
                PointF p2 = edge[1];

                if (((p1.Y > point.Y) != (p2.Y > point.Y)) &&
                    (point.X < (p2.X - p1.X) * (point.Y - p1.Y) / (p2.Y - p1.Y) + p1.X))
                {
                    inside = !inside;
                }
            } 

            return inside;
        }

        

        public static PointF? FindIntersection(PointF[] edge1, PointF[] edge2)
        {
            if (edge1.Length != 2 || edge2.Length != 2)
                throw new ArgumentException("Оба ребра должны содержать 2 точки!");

            PointF p1 = edge1[0];
            PointF p2 = edge1[1];
            PointF p3 = edge2[0];
            PointF p4 = edge2[1];

            float denominator = (p4.Y - p3.Y) * (p2.X - p1.X) - (p4.X - p3.X) * (p2.Y - p1.Y);

            if (Math.Abs(denominator) < 0.0001f)
                return null;

            float t = ((p4.X - p3.X) * (p1.Y - p3.Y) - (p4.Y - p3.Y) * (p1.X - p3.X)) / denominator;
            float u = ((p2.X - p1.X) * (p1.Y - p3.Y) - (p2.Y - p1.Y) * (p1.X - p3.X)) / denominator;

            if (t >= 0 && t <= 1 && u >= 0 && u <= 1)
            {
                float x = p1.X + t * (p2.X - p1.X);
                float y = p1.Y + t * (p2.Y - p1.Y);

                return new PointF(x, y);
            }

            return null;
        }

        public void ApplyTransfrom(Transform transform)
        {
            this.points = this.points.Select(x => transform.Apply(x)).ToList();
            this.edges = this.edges.Select(x => x.Select(y => transform.Apply(y)).ToArray()).ToList();
        }

        public void Clear()
        {
            this.points.Clear();
            this.edges.Clear();
        }

        public int CountPoints()
        {
            return this.points.Count;
        }

        public PointF StartPoint()
        {
            return this.points.First();
        }

        public PointF LastPoint()
        {
            return this.points.Last();
        }

        public PointF PenultimatePoint()
        {
            return this.points[points.Count - 2];
        }

        public PointF GetPoint(int index)
        {
            return this.points[index];
        }

        public MyPolygon Copy()
        {
            return new MyPolygon(this.points);
        }

        public PointF Center()
        {
            float x = this.points.Select(p => p.X).Average();
            float y = this.points.Select(p => p.Y).Average();

            return new PointF(x, y);
        }
    }
}
