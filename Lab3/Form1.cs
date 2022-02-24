using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        private (double, double) _approximateRoot;

        private double _eps = Double.MaxValue;
        private double _a1;
        private double _a2;
        private double _b1;
        private double _b2;
        private const double _h = 0.01;

        public List<(double, double)> F1GraphPoints;
        public List<(double, double)> F2GraphPoints;

        private ResultDto _result;

        public Form1()
        {
            InitializeComponent();

            findRootsButton.Enabled = false;
        }

        /// <summary>
        /// Первая функция в системе
        /// </summary>
        /// <param name="x1">параметр x1</param>
        /// <param name="x2">параметр x2</param>
        /// <returns></returns>
        private double Func1(double x1, double x2)
        {
            return Math.Cos(x1 + 1) - x2 - 1;
        }

        /// <summary>
        /// Вторая функция в системе
        /// </summary>
        /// <param name="x1">параметр x1</param>
        /// <param name="x2">параметр x2</param>
        /// <returns></returns>
        private double Func2(double x1, double x2)
        {
            return Math.Cos(x2) + 2 * x1 - 2;
        }

        /// <summary>
        /// Зависимость x2 = f1(x1)
        /// </summary>
        /// <param name="x1">параметр x1</param>
        /// <returns></returns>
        private double X2FromX1(double x1)
        {
            return Math.Cos(x1 + 1) - 1;
        }

        /// <summary>
        /// Зависимость x1 = f2(x2)
        /// </summary>
        /// <param name="x2">параметр x2</param>
        /// <returns></returns>
        private double X1FromX2(double x2)
        {
            return (-Math.Cos(x2) + 2) / 2d;
        }

        /// <summary>
        /// Производная функции 1 по переменной x1
        /// </summary>
        /// <param name="x1">параметр x1</param>
        /// <returns></returns>
        private double ProizvodnaiaF1ByX1(double x1)
        {
            return -Math.Sin(x1 + 1);
        }

        /// <summary>
        /// Производная функции 1 по переменной x2
        /// </summary>
        /// <returns></returns>
        private double ProizvodnaiaF1ByX2()
        {
            return -1;
        }

        /// <summary>
        /// Производная функции 2 по переменной x1
        /// </summary>
        /// <returns></returns>
        private double ProizvodnaiaF2ByX1()
        {
            return 2;
        }

        /// <summary>
        /// Производная функции 2 по переменной x2
        /// </summary>
        /// <param name="x2">параметр x2</param>
        /// <returns></returns>
        private double ProizvodnaiaF2ByX2(double x2)
        {
            return -Math.Sin(x2);
        }

        /// <summary>
        /// инверсия вектора
        /// </summary>
        /// <param name="x">массив значений вектора</param>
        /// <returns></returns>
        private double[] InverseVector(double[] x)
        {
            return x.Select(i => i * -1).ToArray();
        }

        /// <summary>
        /// функция -f(x)
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="x2"></param>
        /// <returns></returns>
        private double[] MinusFunc(double x1, double x2)
        {
            return InverseVector(new[] {Func1(x1, x2), Func2(x1, x2)});
        }

        /// <summary>
        /// Матрица Якоби
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="x2"></param>
        /// <returns></returns>
        private double[,] JacobyMatrix(double x1, double x2)
        {
            var result = new[,]
            {
                {ProizvodnaiaF1ByX1(x1), ProizvodnaiaF1ByX2()},
                {ProizvodnaiaF2ByX1(), ProizvodnaiaF2ByX2(x2)}
            };
            return result;
        }

        private (double, double) GetNextX(double x1, double x2)
        {
            var jacobyMatrix = JacobyMatrix(x1, x2);
            var minusFunc = MinusFunc(x1, x2);

            var delta = SolveLinearEquationsSystem(jacobyMatrix, minusFunc);

            return (x1 + delta[0], x2 + delta[1]);
        }

        private void FindApproximateRoot()
        {
            var tmp = (-1d, -1d, item3: double.MaxValue);
            for (var i = 0; i < Math.Min(F1GraphPoints.Count, F2GraphPoints.Count); i++)
            {
                var checkingPoint = F1GraphPoints[i];
                for (var j = 0; j < Math.Min(F1GraphPoints.Count, F2GraphPoints.Count); j++)
                {
                    var deltaX = Math.Abs(checkingPoint.Item1 - F2GraphPoints[j].Item2);
                    var deltaY = Math.Abs(checkingPoint.Item2 - F2GraphPoints[j].Item1);

                    var distanceSquared = deltaX * deltaX + deltaY * deltaY;

                    var candidate = (checkingPoint.Item1, checkingPoint.Item2, distanceSquared);
                    if (i != 0 && j != 0 && candidate.distanceSquared < tmp.item3) tmp = candidate;
                }
            }

            _approximateRoot = (tmp.Item1, tmp.Item2);
        }

        /// <summary>
        /// Метод для нахождения пар корней для первого графика
        /// </summary>
        /// <returns></returns>
        private void CalculatePointsForFunc1()
        {
            F1GraphPoints = new List<(double, double)>();
            var iterations = (int) ((_b1 - _a1) / _h) + 1;
            for (var i = 0; i < iterations; i++)
            {
                var x1 = _a1 + (i + 1) * _h;
                var x2 = X2FromX1(x1);
                F1GraphPoints.Add((x1, x2));
            }
        }

        /// <summary>
        /// Метод для нахождения пар корней второго графика
        /// </summary>
        /// <returns></returns>
        public void CalculatePointsForFunc2()
        {
            F2GraphPoints = new List<(double, double)>();
            var iterationCount = (int) ((_b2 - _a2) / _h) + 1;
            for (var i = 0; i < iterationCount; i++)
            {
                var x1 = _a2 + (i + 1) * _h;
                var x2 = X1FromX2(x1);
                F2GraphPoints.Add((x2, x1));
            }
        }

        /// <summary>
        /// метод Ньютона для решения системы уравнений
        /// </summary>
        /// <returns></returns>
        public List<ResultDto> NewtonMethod()
        {
            var fault = double.MaxValue;
            FindApproximateRoot();

            var oldX = _approximateRoot;

            var result = new List<ResultDto>();
            while (fault > _eps)
            {
                var newX = GetNextX(oldX.Item1, oldX.Item2);
                var minusF = MinusFunc(newX.Item1, newX.Item2);
                fault = Math.Sqrt(minusF.Select(fxi => fxi * fxi).Sum());

                var resultRow = new ResultDto
                {
                    ApproximateRoots = oldX,
                    ApproximatedRoots = newX,
                    NormOfApproximatedCoordinatesVector = Math.Sqrt(minusF.Select(xi => xi * xi).Sum())
                };

                result.Add(resultRow);

                oldX = newX;
            }

            return result;
        }

        /// <summary>
        /// Решение системы линейных уравнений
        /// </summary>
        /// <param name="aMatrix">матрица Якоби</param>
        /// <param name="minusFuncVector">вектор -f</param>
        /// <returns></returns>
        public double[] SolveLinearEquationsSystem(double[,] aMatrix, double[] minusFuncVector)
        {
            var gaussArray = new double[minusFuncVector.Length][];
            for (int i = 0; i < minusFuncVector.Length; i++)
            {
                var gaussArrayRow = new double[minusFuncVector.Length + 1];
                for (int j = 0; j < minusFuncVector.Length; j++)
                {
                    gaussArrayRow[j] = aMatrix[i, j];
                }

                gaussArrayRow[minusFuncVector.Length] = minusFuncVector[i];
                gaussArray[i] = gaussArrayRow;
            }

            var result = SolveLinearEquations(gaussArray);
            return result;
        }

        /// <summary>
        /// Решить линейное уравнение
        /// </summary>
        /// <param name="rows"></param>
        /// <returns></returns>
        private double[] SolveLinearEquations(double[][] rows)
        {
            var length = rows[0].Length;

            for (var i = 0; i < rows.Length - 1; i++)
            {
                if (rows[i][i] == 0 && !Swap(rows, i, i)) return null;

                for (var j = i; j < rows.Length; j++)
                {
                    var d = new double[length];
                    for (var x = 0; x < length; x++)
                    {
                        d[x] = rows[j][x];
                        if (rows[j][i] != 0) d[x] /= rows[j][i];
                    }

                    rows[j] = d;
                }

                for (var y = i + 1; y < rows.Length; y++)
                {
                    var f = new double[length];
                    for (var g = 0; g < length; g++)
                    {
                        f[g] = rows[y][g];
                        if (rows[y][i] != 0) f[g] -= rows[i][g];
                    }

                    rows[y] = f;
                }
            }

            return Calculate(rows);
        }

        private double[] Calculate(double[][] rows)
        {
            var length = rows[0].Length;
            var result = new double[rows.Length];

            for (var i = rows.Length - 1; i >= 0; i--)
            {
                double value = rows[i][length - 1];
                for (var x = length - 2; x > i - 1; x--) value -= rows[i][x] * result[x];
                result[i] = value / rows[i][i];

                if (!IsValidResult(result[i])) return null;
            }

            return result;
        }

        private bool Swap(double[][] rows, int row, int column)
        {
            var swapped = false;

            for (var z = rows.Length - 1; z > row; z--)
                if (rows[z][row] != 0)
                {
                    (rows[z], rows[column]) = (rows[column], rows[z]);
                    swapped = true;
                }

            return swapped;
        }


        private void buildGraphButton_Click(object sender, EventArgs e)
        {
            InitTextboxesWithDefaultValues();

            graph.Series[0].Points.Clear();
            graph.Series[1].Points.Clear();

            CalculatePointsForFunc1();
            CalculatePointsForFunc2();
            F1GraphPoints.ForEach(x => graph.Series[0].Points.AddXY(x.Item1, x.Item2));
            F2GraphPoints.ForEach(x => graph.Series[1].Points.AddXY(x.Item1, x.Item2));

            findRootsButton.Enabled = true;
        }

        private void findRootsButton_Click(object sender, EventArgs e)
        {
            findRootsButton.Enabled = false;
            dataGridView.Rows.Clear();
            InitTextboxesWithDefaultValues();

            var result = NewtonMethod();

            for (var i = 0; i < result.Count; i++)
            {
                dataGridView.Rows.Add();
                dataGridView.Rows[i].Cells[0].Value =
                    $"({Math.Round(result[i].ApproximateRoots.Item1, 8)}, {Math.Round(result[i].ApproximateRoots.Item2, 8)})";
                dataGridView.Rows[i].Cells[1].Value =
                    $"({Math.Round(result[i].ApproximatedRoots.Item1, 8)}, {Math.Round(result[i].ApproximatedRoots.Item2, 8)})";
                dataGridView.Rows[i].Cells[2].Value = $"{Math.Round(result[i].NormOfApproximatedCoordinatesVector, 8)}";
            }
        }

        private void a1BoundValue_TextChanged(object sender, EventArgs e)
        {
            a1BoundValue.Text = a1BoundValue.Text.Replace('.', ',');
            a1BoundValue.SelectionStart = a1BoundValue.TextLength;
        }

        private void b1BoundValue_TextChanged(object sender, EventArgs e)
        {
            b1BoundValue.Text = b1BoundValue.Text.Replace('.', ',');
            b1BoundValue.SelectionStart = b1BoundValue.TextLength;
        }
        
        private void epsValue_TextChanged(object sender, EventArgs e)
        {
            epsValue.Text = epsValue.Text.Replace('.', ',');
            epsValue.SelectionStart = epsValue.TextLength;
        }

        /// <summary>
        ///  проверка результата на допустимые значения
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        private static bool IsValidResult(double result)
        {
            return !(double.IsNaN(result) || double.IsInfinity(result));
        }

        private void InitTextboxesWithDefaultValues()
        {
            #region FillingEmptyStrings

            if (a1BoundValue.Text == "")
            {
                a1BoundValue.Text = "-5";
            }

            if (a2BoundValue.Text == "")
            {
                a2BoundValue.Text = "-5";
            }

            if (b1BoundValue.Text == "")
            {
                b1BoundValue.Text = "5";
            }

            if (b2BoundValue.Text == "")
            {
                b2BoundValue.Text = "5";
            }

            if (epsValue.Text == "")
            {
                epsValue.Text = "0,01";
            }

            #endregion

            _a1 = ConvertToDouble(a1BoundValue.Text);
            _a2 = ConvertToDouble(a2BoundValue.Text);
            _b1 = ConvertToDouble(b1BoundValue.Text);
            _b2 = ConvertToDouble(b2BoundValue.Text);
            _eps = ConvertToDouble(epsValue.Text);
        }

        private static double ConvertToDouble(string value)
        {
            if (value == null)
            {
                return 0;
            }

            double.TryParse(value, out var outValue);

            if (double.IsNaN(outValue) || double.IsInfinity(outValue))
            {
                return 0;
            }

            return outValue;
        }
    }
}