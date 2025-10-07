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
        MyPolygon currentPolygon = new MyPolygon();
        MyPolygon selectedPolygon;
        Pen p;


        bool creatingPolygon = false;
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
        }


        private void panel1_Click(object sender, MouseEventArgs e)
        {
            if (creatingPolygon)
            {
                currentPolygon.AddPoint(e.Location);
                panel1.Invalidate();
            }
        }

        private void buttonCreatePolygon_Click(object sender, EventArgs e)
        {
            if (!creatingPolygon)
            {
                creatingPolygon = true;
                buttonCreatePolygon.Text = "Готово";
                panel1.Invalidate();
            }
            else
            {
                creatingPolygon = false;
                buttonCreatePolygon.Text = "Создать полигон";

                if (currentPolygon.CountPoints() > 0)
                {
                    myPolygons.Add(currentPolygon.Copy());
                    currentPolygon.Clear();

                    panel1.Invalidate();
                }
            }
            CreatingPolygon();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
            if (myPolygons.Count != 0)
            {
                Graphics g = e.Graphics;
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
                Graphics g = e.Graphics;
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
        }

        private void button_ClearPoligons_Click(object sender, EventArgs e)
        {
            myPolygons.Clear();
            currentPolygon.Clear();
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
            float dx = (float)numericUpDown_Dx.Value;
            float dy = (float)numericUpDown_Dy.Value;

            Transform transform = new Transform();
            transform.Translation(-dx, -dy);

            selectedPolygon = myPolygons.Last();
            selectedPolygon.ApplyTransfrom(transform);
            panel1.Invalidate();

            numericUpDown_Dx.Value = 0;
            numericUpDown_Dy.Value = 0;
        }

        private void button_Rotate_Click(object sender, EventArgs e)
        {
            selectedPolygon = myPolygons.Last();

            MessageBox.Show("Выберите точку вращения. По умолчанию выбран центр полигона", "Выбор точки");
            
            PointF rotationPoint = selectedPolygon.Center();

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

        private void numericUpDown_DilationX_ValueChanged(object sender, EventArgs e)
        {
            trackBar_DilatationX.Value = (int)((NumericUpDown)sender).Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            trackBar_DilatationY.Value = (int)((NumericUpDown)sender).Value;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            numericUpDown_DilatationY.Value = (int)((TrackBar)sender).Value;
        }

        private void button_Dilation_Click(object sender, EventArgs e)
        {
            selectedPolygon = myPolygons.Last();

            PointF DilatationPoint = selectedPolygon.Center();

            Transform transform = new Transform();
            transform.Translation(-DilatationPoint.X, -DilatationPoint.Y);
            transform.Dilatation((float)numericUpDown_DilatationX.Value / 100, (float)numericUpDown_DilatationY.Value / 100);
            transform.Translation(DilatationPoint.X, DilatationPoint.Y);

            selectedPolygon.ApplyTransfrom(transform);

            numericUpDown_DilatationX.Value = 100;
            numericUpDown_DilatationY.Value = 100;

            panel1.Invalidate();

        }
    }
}
