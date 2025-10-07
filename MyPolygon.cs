using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
        public List<PointF> Points { get { return new List<PointF>(points); } }
        public List<PointF[]> Edges { get { return new List<PointF[]>(edges); } }

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
            this.edges.Add(new PointF[2] { points[-1], points[0] });
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
                    if (CheckEdge(edge))
                    {
                        if (this.edges.Count == 0)
                        {
                            this.edges.Add(edge);

                        }
                        else
                        {
                            this.edges[edges.Count - 1] = edge;
                        }
                        this.points.Add(point);
                    }
                    this.edges.Add(new PointF[2] { points.Last(), points.First() });
                }
            }
            else
            {
                throw new InvalidOperationException("Полигон зафиксирован, в него нельзя добавлять вершины!");
            }
        }

        private bool CheckEdge(PointF[] edge)
        {
            // TODO
            return true;
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
