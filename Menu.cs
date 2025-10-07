using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS332_Lab4
{
    public partial class Menu : Form
    {
        List<MyPolygon> myPolygons = new List<MyPolygon>();
        List<PointF[]> edges = new List<PointF[]>();

        MyPolygon currentPolygon = new MyPolygon();

        MyPolygon selectedPolygon = new MyPolygon();
        PointF polygonPoint;

        PointF selectedPoint;
        PointF[] selectedEdge;
        Pen p;


        bool creatingPolygon = false;
        bool selectingPolygon = false;
        bool selectingPoint = false;
        bool selectingEdge = false;

        bool classificate = false;

        public Menu()
        {
            InitializeComponent();
            p = new Pen(Brushes.Black, 2);
        }

        public void CreatingPolygon()
        {
            button_ClearPoligons.Visible = !creatingPolygon;
            button_ClearPoligons.Enabled = !creatingPolygon;

            button_SelectPolygon.Visible = !creatingPolygon;
            button_SelectPolygon.Enabled = !creatingPolygon;

            button_SelectPoint.Visible = !creatingPolygon;
            button_SelectPoint.Enabled = !creatingPolygon;

            button_Translation.Visible = !creatingPolygon;
            button_Translation.Enabled = !creatingPolygon;

            label1.Visible = !creatingPolygon;
            numericUpDown_Dx.Visible = !creatingPolygon;
            numericUpDown_Dx.Enabled = !creatingPolygon;

            label2.Visible = !creatingPolygon;
            numericUpDown_Dy.Visible = !creatingPolygon;
            numericUpDown_Dy.Enabled = !creatingPolygon;

            button_Rotate.Visible = !creatingPolygon;
            button_Rotate.Enabled = !creatingPolygon;

            label3.Visible = !creatingPolygon;
            numericUpDown_Rotation.Visible = !creatingPolygon;
            numericUpDown_Rotation.Enabled = !creatingPolygon;

            trackBar_Rotation.Visible = !creatingPolygon;
            trackBar_Rotation.Enabled = !creatingPolygon;

            button_Dilation.Visible = !creatingPolygon;
            button_Dilation.Enabled = !creatingPolygon;

            label4.Visible = !creatingPolygon;
            numericUpDown_DilatationX.Visible = !creatingPolygon;
            numericUpDown_DilatationX.Enabled = !creatingPolygon;

            label5.Visible = !creatingPolygon;
            numericUpDown_DilatationY.Visible = !creatingPolygon;
            numericUpDown_DilatationY.Enabled = !creatingPolygon;


            button_ClearPoint.Visible = !creatingPolygon;
            button_ClearPoint.Enabled = !creatingPolygon;

            button_Classificate.Visible = !creatingPolygon;
            button_Classificate.Enabled = !creatingPolygon;

            button_SelectEdge.Visible = !creatingPolygon;
            button_SelectEdge.Enabled = !creatingPolygon;
        }

        public void SelectingPolygon()
        {
            button_ClearPoligons.Visible = !selectingPolygon;
            button_ClearPoligons.Enabled = !selectingPolygon;

            button_CreatePolygon.Visible = !selectingPolygon;
            button_CreatePolygon.Enabled = !selectingPolygon;

            button_SelectPoint.Visible = !selectingPolygon;
            button_SelectPoint.Enabled = !selectingPolygon;

            button_Translation.Visible = !selectingPolygon;
            button_Translation.Enabled = !selectingPolygon;

            label1.Visible = !selectingPolygon;
            numericUpDown_Dx.Visible = !selectingPolygon;
            numericUpDown_Dx.Enabled = !selectingPolygon;

            label2.Visible = !selectingPolygon;
            numericUpDown_Dy.Visible = !selectingPolygon;
            numericUpDown_Dy.Enabled = !selectingPolygon;

            button_Rotate.Visible = !selectingPolygon;
            button_Rotate.Enabled = !selectingPolygon;

            label3.Visible = !selectingPolygon;
            numericUpDown_Rotation.Visible = !selectingPolygon;
            numericUpDown_Rotation.Enabled = !selectingPolygon;

            trackBar_Rotation.Visible = !selectingPolygon;
            trackBar_Rotation.Enabled = !selectingPolygon;

            button_Dilation.Visible = !selectingPolygon;
            button_Dilation.Enabled = !selectingPolygon;

            label4.Visible = !selectingPolygon;
            numericUpDown_DilatationX.Visible = !selectingPolygon;
            numericUpDown_DilatationX.Enabled = !selectingPolygon;

            label5.Visible = !selectingPolygon;
            numericUpDown_DilatationY.Visible = !selectingPolygon;
            numericUpDown_DilatationY.Enabled = !selectingPolygon;

            button_ClearPoint.Visible = !selectingPolygon;
            button_ClearPoint.Enabled = !selectingPolygon;

            button_Classificate.Visible = !selectingPolygon;
            button_Classificate.Enabled = !selectingPolygon;

            button_SelectEdge.Visible = !selectingPolygon;
            button_SelectEdge.Enabled = !selectingPolygon;
        }

        public void SelectingPoint()
        {
            button_ClearPoligons.Visible = !selectingPoint;
            button_ClearPoligons.Enabled = !selectingPoint;

            button_CreatePolygon.Visible = !selectingPoint;
            button_CreatePolygon.Enabled = !selectingPoint;

            button_SelectPolygon.Visible = !selectingPoint;
            button_SelectPolygon.Enabled = !selectingPoint;

            button_Translation.Visible = !selectingPoint;
            button_Translation.Enabled = !selectingPoint;

            label1.Visible = !selectingPoint;
            numericUpDown_Dx.Visible = !selectingPoint;
            numericUpDown_Dx.Enabled = !selectingPoint;

            label2.Visible = !selectingPoint;
            numericUpDown_Dy.Visible = !selectingPoint;
            numericUpDown_Dy.Enabled = !selectingPoint;

            button_Rotate.Visible = !selectingPoint;
            button_Rotate.Enabled = !selectingPoint;

            label3.Visible = !selectingPoint;
            numericUpDown_Rotation.Visible = !selectingPoint;
            numericUpDown_Rotation.Enabled = !selectingPoint;

            trackBar_Rotation.Visible = !selectingPoint;
            trackBar_Rotation.Enabled = !selectingPoint;

            button_Dilation.Visible = !selectingPoint;
            button_Dilation.Enabled = !selectingPoint;

            label4.Visible = !selectingPoint;
            numericUpDown_DilatationX.Visible = !selectingPoint;
            numericUpDown_DilatationX.Enabled = !selectingPoint;

            label5.Visible = !selectingPoint;
            numericUpDown_DilatationY.Visible = !selectingPoint;
            numericUpDown_DilatationY.Enabled = !selectingPoint;

            button_ClearPoint.Visible = !selectingPoint;
            button_ClearPoint.Enabled = !selectingPoint;

            button_Classificate.Visible = !selectingPoint;
            button_Classificate.Enabled = !selectingPoint;

            button_SelectEdge.Visible = !selectingPoint;
            button_SelectEdge.Enabled = !selectingPoint;

        }

        public void SelectingEdge()
        {
            button_ClearPoligons.Visible = !selectingEdge;
            button_ClearPoligons.Enabled = !selectingEdge;

            button_CreatePolygon.Visible = !selectingEdge;
            button_CreatePolygon.Enabled = !selectingEdge;

            button_SelectPolygon.Visible = !selectingEdge;
            button_SelectPolygon.Enabled = !selectingEdge;

            button_Translation.Visible = !selectingEdge;
            button_Translation.Enabled = !selectingEdge;

            label1.Visible = !selectingEdge;
            numericUpDown_Dx.Visible = !selectingEdge;
            numericUpDown_Dx.Enabled = !selectingEdge;

            label2.Visible = !selectingEdge;
            numericUpDown_Dy.Visible = !selectingEdge;
            numericUpDown_Dy.Enabled = !selectingEdge;

            button_Rotate.Visible = !selectingEdge;
            button_Rotate.Enabled = !selectingEdge;

            label3.Visible = !selectingEdge;
            numericUpDown_Rotation.Visible = !selectingEdge;
            numericUpDown_Rotation.Enabled = !selectingEdge;

            trackBar_Rotation.Visible = !selectingEdge;
            trackBar_Rotation.Enabled = !selectingEdge;

            button_Dilation.Visible = !selectingEdge;
            button_Dilation.Enabled = !selectingEdge;

            label4.Visible = !selectingEdge;
            numericUpDown_DilatationX.Visible = !selectingEdge;
            numericUpDown_DilatationX.Enabled = !selectingEdge;

            label5.Visible = !selectingEdge;
            numericUpDown_DilatationY.Visible = !selectingEdge;
            numericUpDown_DilatationY.Enabled = !selectingEdge;

            button_ClearPoint.Visible = !selectingEdge;
            button_ClearPoint.Enabled = !selectingEdge;

            button_SelectPoint.Visible = !selectingEdge;
            button_SelectPoint.Enabled = !selectingEdge;

            button_Classificate.Visible = !selectingEdge;
            button_Classificate.Enabled = !selectingEdge;
        }

        public void Classificating()
        {
            button_ClearPoligons.Visible = !classificate;
            button_ClearPoligons.Enabled = !classificate;

            button_CreatePolygon.Visible = !classificate;
            button_CreatePolygon.Enabled = !classificate;

            button_SelectPolygon.Visible = !classificate;
            button_SelectPolygon.Enabled = !classificate;

            button_Translation.Visible = !classificate;
            button_Translation.Enabled = !classificate;

            label1.Visible = !classificate;
            numericUpDown_Dx.Visible = !classificate;
            numericUpDown_Dx.Enabled = !classificate;

            label2.Visible = !classificate;
            numericUpDown_Dy.Visible = !classificate;
            numericUpDown_Dy.Enabled = !classificate;

            button_Rotate.Visible = !classificate;
            button_Rotate.Enabled = !classificate;

            label3.Visible = !classificate;
            numericUpDown_Rotation.Visible = !classificate;
            numericUpDown_Rotation.Enabled = !classificate;

            trackBar_Rotation.Visible = !classificate;
            trackBar_Rotation.Enabled = !classificate;

            button_Dilation.Visible = !classificate;
            button_Dilation.Enabled = !classificate;

            label4.Visible = !classificate;
            numericUpDown_DilatationX.Visible = !classificate;
            numericUpDown_DilatationX.Enabled = !classificate;

            label5.Visible = !classificate;
            numericUpDown_DilatationY.Visible = !classificate;
            numericUpDown_DilatationY.Enabled = !classificate;

            button_ClearPoint.Visible = !classificate;
            button_ClearPoint.Enabled = !classificate;

            button_SelectPoint.Visible = !classificate;
            button_SelectPoint.Enabled = !classificate;

            button_SelectEdge.Visible = !classificate;
            button_SelectEdge.Enabled = !classificate;
        }

        private void panel1_Click(object sender, MouseEventArgs e)
        {
            if (creatingPolygon)
            {
                currentPolygon.AddPoint(e.Location);
                panel1.Invalidate();
            }

            if (selectingPoint)
            {
                selectedPoint = e.Location;
                panel1.Invalidate();
            }

            if (selectingPolygon)
            {
                polygonPoint = e.Location;
            }

            if (selectingEdge)
            {
                selectedEdge = selectedPolygon.SelectEdge(e.Location);
            }

            if (classificate)
            {
                if (MyPolygon.ClassifyPoint(e.Location, selectedEdge) == PointClassification.Right)
                {
                    MessageBox.Show("Правая точка", "Тип точки");
                }
                else
                {
                    MessageBox.Show("Левая точка", "Тип точки");
                }
                
            }
        }

        private void buttonCreatePolygon_Click(object sender, EventArgs e)
        {
            if (!creatingPolygon)
            {
                creatingPolygon = true;
                button_CreatePolygon.Text = "Готово";
                panel1.Invalidate();
            }
            else
            {
                creatingPolygon = false;
                button_CreatePolygon.Text = "Создать полигон";

                if (currentPolygon.CountPoints() > 0)
                {
                    myPolygons.Add(currentPolygon.Copy());
                    edges = edges.Union(currentPolygon.Edges).ToList();
                    currentPolygon.Clear();

                    panel1.Invalidate();
                }
            }
            CreatingPolygon();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (myPolygons.Count != 0)
            {
                foreach (MyPolygon polygon in myPolygons)
                {
                    foreach (PointF[] edge in polygon.Edges)
                    {
                        g.DrawLine(p, edge[0], edge[1]);
                    }
                }
            }

            if (currentPolygon.CountPoints() > 0)
            {
                PointF lastPoint = currentPolygon.LastPoint();

                if (currentPolygon.CountPoints() == 1)
                {
                    g.FillEllipse(Brushes.Black, lastPoint.X - 1, lastPoint.Y - 1, 2, 2);
                }
                else
                {
                    foreach (PointF[] edge in currentPolygon.Edges)
                    {
                        g.DrawLine(p, edge[0], edge[1]);
                    }
                }
            }

            if (selectedPoint != default)
            {
                g.FillEllipse(Brushes.Red, selectedPoint.X - 2, selectedPoint.Y - 2, 4, 4);
            }



            for (int i = 0; i < myPolygons.Count; i++)
            {
                for (int j = i + 1; j < myPolygons.Count; j++)
                {
                    MyPolygon polygon1 = myPolygons[i];
                    MyPolygon polygon2 = myPolygons[j];

                    foreach (PointF[] edge1 in polygon1.Edges)
                    {
                        foreach (PointF[] edge2 in polygon2.Edges)
                        {
                            PointF? intersect = MyPolygon.FindIntersection(edge1, edge2);

                            if (intersect != null)
                            {
                                PointF point = new PointF((int)intersect.Value.X, (int)intersect.Value.Y);
                                g.FillEllipse(Brushes.Blue, point.X - 4, point.Y - 4, 8, 8);
                            }
                        }
                    }
                }
            }

        }

        private void button_ClearPoligons_Click(object sender, EventArgs e)
        {
            myPolygons.Clear();
            currentPolygon.Clear();
            selectedPolygon.Clear();
            edges.Clear();
            panel1.Invalidate();
        }

        private void trackBar_Rotation_Scroll(object sender, EventArgs e)
        {
            numericUpDown_Rotation.Value = ((TrackBar)sender).Value;
        }

        private void numericUpDown_Rotation_ValueChanged(object sender, EventArgs e)
        {
            trackBar_Rotation.Value = (int)((NumericUpDown) sender).Value;
        }

        private void button_Translation_Click(object sender, EventArgs e)
        {
            if (selectedPolygon.CountPoints() == 0)
            {
                MessageBox.Show("Сначала выберите полигон!", "Ошибка!");
                numericUpDown_Dx.Value = 0;
                numericUpDown_Dy.Value = 0;
                return;
            }

            float dx = (float)numericUpDown_Dx.Value;
            float dy = (float)numericUpDown_Dy.Value;

            Transform transform = new Transform();
            transform.Translation(-dx, -dy);

            selectedPolygon.ApplyTransfrom(transform);
            panel1.Invalidate();

            numericUpDown_Dx.Value = 0;
            numericUpDown_Dy.Value = 0;
        }

        private void button_Rotate_Click(object sender, EventArgs e)
        {
            if (selectedPolygon.CountPoints() == 0)
            {
                MessageBox.Show("Сначала выберите полигон!", "Ошибка");
                numericUpDown_Rotation.Value = 0;
                return;
            }

            PointF rotationPoint = selectedPoint == default ? selectedPolygon.Center() : selectedPoint;

            Transform transform = new Transform();
            transform.Translation(-rotationPoint.X, -rotationPoint.Y);
            transform.Rotation((float)numericUpDown_Rotation.Value);
            transform.Translation(rotationPoint.X, rotationPoint.Y);

            selectedPolygon.ApplyTransfrom(transform);

            numericUpDown_Rotation.Value = 0;

            panel1.Invalidate();

        }

        private void trackBar_DilationX_Scroll(object sender, EventArgs e)
        {
            numericUpDown_DilatationX.Value = ((TrackBar)sender).Value;
        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            numericUpDown_DilatationY.Value = (int)((TrackBar)sender).Value;
        }

        private void button_Dilation_Click(object sender, EventArgs e)
        {
            if (selectedPolygon.CountPoints() == 0)
            {
                MessageBox.Show("Сначала выберите полигон!", "Ошибка");
                numericUpDown_DilatationX.Value = 100;
                numericUpDown_DilatationY.Value = 100;

                return;
            }
            PointF DilatationPoint = selectedPoint == default ? selectedPolygon.Center() : selectedPoint;

            Transform transform = new Transform();
            transform.Translation(-DilatationPoint.X, -DilatationPoint.Y);
            transform.Dilatation((float)numericUpDown_DilatationX.Value / 100, (float)numericUpDown_DilatationY.Value / 100);
            transform.Translation(DilatationPoint.X, DilatationPoint.Y);

            selectedPolygon.ApplyTransfrom(transform);

            numericUpDown_DilatationX.Value = 100;
            numericUpDown_DilatationY.Value = 100;

            panel1.Invalidate();

        }

        private void button_SelectPolygon_Click(object sender, EventArgs e)
        {
            if (myPolygons.Count() == 0)
            {
                MessageBox.Show("Сначала создайте полигоны!", "Ошибка");
                return;
            }

            if (!selectingPolygon)
            {
                selectingPolygon = true;
                button_SelectPolygon.Text = "Готово";
            }
            else
            {
                List<MyPolygon> polygons = myPolygons.Where(x => x.ContainsPoint(polygonPoint)).ToList();
                
                if (polygons.Count() == 0)
                {
                    MessageBox.Show("Полигон не найден!", "Выбор полигона");
                }
                else
                {
                    MessageBox.Show("Полигон выбран", "Выбор полигона");
                    selectedPolygon = polygons.First();
                    selectingPolygon = false;
                    button_SelectPolygon.Text = "Выбрать полигон";
                }
                    
            }
            
            SelectingPolygon();
        }

        private void button_SelectPoint_Click(object sender, EventArgs e)
        {
            if (!selectingPoint)
            {
                selectingPoint = true;
                button_SelectPoint.Text = "Готово";
            }
            else
            {
                selectingPoint = false;
                button_SelectPoint.Text = "Выбрать точку для поворота/растяжения";
            }
            SelectingPoint();
            Invalidate();
        }

        private void button_ClearPoint_Click(object sender, EventArgs e)
        {
            selectedPoint = default;
            panel1.Invalidate();
        }

        private void button_Classificate_Click(object sender, EventArgs e)
        {
            if (selectedPolygon.CountPoints() == 0)
            {
                MessageBox.Show("Сначала выберите полигон!", "Выбор ребра полигона");
                return;
            }

            if (selectedEdge == null)
            {
                MessageBox.Show("Сначала выберите ребро полигона!", "Выбор ребра полигона");
                return;
            }

            if (!classificate)
            {
                classificate = true;
            }
            else
            {
                classificate = false;
            }
            Classificating();
        }

        private void button_SelectEdge_Click(object sender, EventArgs e)
        {
            if (selectedPolygon.CountPoints() == 0)
            {
                MessageBox.Show("Сначала выберите полигон!", "Выбор ребра полигона");
                return;
            }

            if (!selectingEdge)
            {
                button_SelectEdge.Text = "Готово";
                selectingEdge = true;
            }
            else
            {
                if (selectedEdge == null)
                {
                    MessageBox.Show("Ребро не найдено!", "Выбор ребра");
                    return;
                }
                else
                {
                    MessageBox.Show("Ребро выбрано", "Выбор ребра");
                }

                button_SelectEdge.Text = "Выбрать ребро полигона";
                selectingEdge = false;
            }
            SelectingEdge();
        }
    }
}
