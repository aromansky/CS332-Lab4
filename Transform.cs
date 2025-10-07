using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace CS332_Lab4
{
    /// <summary>
    /// Афинные преобразования через матрицы
    /// </summary>
    public class Transform
    {
        /// <summary>
        /// Типы матриц афинного преобразования
        /// </summary>
        private enum TypeMat
        {
            /// <summary>
            /// Матрица вращения
            /// </summary>
            Rotation,

            /// <summary>
            /// Матрица растяжения/сжатия
            /// </summary>
            Dilatation,

            /// <summary>
            /// Матрица отражения
            /// </summary>
            Reflection,

            /// <summary>
            /// Матрица переноса
            /// </summary>
            Translation,

            /// <summary>
            /// Еденичная матрица
            /// </summary>
            Identity
        }

        /// <summary>
        ///  Матрица афинного преобразования
        /// </summary>
        private struct TransformMat
        {
            //private float[,] mat;
            private Matrix<float> mat;
            public Matrix<float> Mat { get { return mat.Clone(); } }

            /// <summary>
            /// Создание матрицы афинных преобразований
            /// </summary>
            /// <param name="type">Тип матрицы</param>
            /// <param name="phi">Величина угла φ</param>
            /// <param name="alpha">Величина α</param>
            /// <param name="beta">Величина β</param>
            /// <param name="lambda">Величина λ</param>
            /// <param name="mu">Величина μ</param>
            public TransformMat(TypeMat type, float val1 = 0, float val2 = 0)
            {
                switch (type)
                {
                    case TypeMat.Rotation:
                        this.mat = Matrix<float>.Build.DenseOfArray(new float[3, 3]
                        {
                            {(float) Math.Cos((double)val1), (float) Math.Sin((double)val1), 0 },
                            {-(float) Math.Sin((double)val1), (float) Math.Cos((double)val1), 0 },
                            { 0, 0, 1 }
                        });
                        break;
                    case TypeMat.Dilatation:
                        this.mat = Matrix<float>.Build.DenseOfArray(new float[3, 3]
                        {
                            {val1, 0, 0 },
                            {0, val2, 0 },
                            {0, 0, 1 }
                        });
                        break;
                    case TypeMat.Reflection:
                        this.mat = Matrix<float>.Build.DenseOfArray(new float[3, 3]
                        {
                            {1, 0, 0 },
                            {0, 1, 0 },
                            {0, 0, 1 }
                        });
                        break;
                    case TypeMat.Translation:
                        this.mat = Matrix<float>.Build.DenseOfArray(new float[3, 3]
                        {
                            {1, 0, 0 },
                            {0, 1, 0 },
                            {val1, val2, 1 }
                        });
                        break;
                    default:
                        this.mat = Matrix<float>.Build.DenseOfArray(new float[3, 3]
                        {
                            {1, 0, 0 },
                            {0, 1, 0 },
                            {0, 0, 1 }
                        });
                        break;
                }
            }

            public TransformMat(Matrix<float> mat)
            {
                this.mat = mat.Clone();
            }
        }

        TransformMat mat;


        public Transform()
        {
            mat = new TransformMat(TypeMat.Identity);
        }

        /// <summary>
        /// Применение преобразования к координатам
        /// </summary>
        public PointF Apply(PointF point)
        {
            Matrix<float> left = Matrix<float>.Build.Dense(1, 3, new float [3] { point.X, point.Y, 1 });
            left = left * mat.Mat;
            return new PointF(left[0, 0], left[0, 1]);
        }

        public void Rotation(float phi)
        {
            TransformMat rotationMat = new TransformMat(TypeMat.Rotation,  phi * ((float) Math.PI / 180));
            mat = new TransformMat(mat.Mat * rotationMat.Mat);
        }

        public void Dilatation(float alpha, float beta)
        {
            TransformMat dilatationMat = new TransformMat(TypeMat.Dilatation, alpha, beta);
            mat = new TransformMat(mat.Mat * dilatationMat.Mat);
        }

        public void Reflection()
        {
            TransformMat reflectionMat = new TransformMat(TypeMat.Reflection);
            mat = new TransformMat(mat.Mat * reflectionMat.Mat);
        }

        public void Translation(float dx, float dy)
        {
            TransformMat translatiopnMat = new TransformMat(TypeMat.Translation, dx, dy);
            mat = new TransformMat(mat.Mat * translatiopnMat.Mat);
        }
    }
}
