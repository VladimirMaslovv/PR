using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
namespace Матричный_калькулятор
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            #region Первоначальная настройка формы
            dataGridMatrix_A.RowCount = (int)numericRows_A.Value + 1;
            dataGridMatrix_A.ColumnCount = (int)numericColumns_A.Value;
            dataGridMatrix_A.RowHeadersVisible = false;
            dataGridMatrix_A.ColumnHeadersVisible = false;
            dataGridMatrix_A.AllowUserToAddRows = false;
            dataGridMatrix_B.RowCount = (int)numericRows_B.Value + 1;
            dataGridMatrix_B.ColumnCount = (int)numericColumns_B.Value;
            dataGridMatrix_B.RowHeadersVisible = false;
            dataGridMatrix_B.ColumnHeadersVisible = false;
            dataGridMatrix_B.AllowUserToAddRows = false;
            dataGridResult.RowHeadersVisible = false;
            dataGridResult.ColumnHeadersVisible = false;
            dataGridResult.Enabled = false;
            saveFileDialogResult.Filter = "Текстовые файлы (*.txt)|*.txt|All files (*.*)|*.*";
            #endregion
        }
        #region Общие методы матриц "А" и "В"
        /// <summary>
        /// Задает количество столбцов для матрицы "А"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumericColumns_A_ValueChanged(object sender, EventArgs e)
        {
            #region Если установлен флаг, то происходит подгонка матрицы по столбцам
            if (checkBoxFit.Checked == true)
            {
                try
                {
                    dataGridMatrix_A.ColumnCount = (int)numericColumns_A.Value;
                    numericColumns_B.Value = numericColumns_A.Value;
                    dataGridMatrix_B.ColumnCount = (int)numericColumns_B.Value;
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Неправильно указано количество столбцов!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    dataGridMatrix_A.RowCount = 1;
                }
            }
            #endregion

            #region Задание кол-ва столбцов в матрице "А"
            else
            {
                try
                {
                    dataGridMatrix_A.ColumnCount = (int)numericColumns_A.Value;
                }
                catch (ArgumentOutOfRangeException)
                {

                    MessageBox.Show("Неправильно указано количество столбцов!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    dataGridMatrix_A.ColumnCount = 1;
                }
            }
            #endregion
        }
        /// <summary>
        /// Задает количество строк для матрицы "А"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumericRows_A_ValueChanged(object sender, EventArgs e)
        {
            #region Если установлен флаг, то происходит подгонца матриц по строкам
            if (checkBoxFit.Checked == true)
            {
                try
                {
                    dataGridMatrix_A.RowCount = (int)numericRows_A.Value;
                    numericRows_B.Value = numericRows_A.Value;
                    dataGridMatrix_B.RowCount = (int)numericRows_B.Value;
                }
                catch (ArgumentOutOfRangeException)
                {

                    MessageBox.Show("Неправильно указано количество столбцов!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    dataGridMatrix_A.RowCount = 1;
                }
            }
            #endregion

            #region Задание количества строк для матрицы "А"
            else
            {
                try
                {
                    dataGridMatrix_A.RowCount = (int)numericRows_A.Value;
                }
                catch (ArgumentOutOfRangeException)
                {

                    MessageBox.Show("Неправильно указано количество столбцов!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    dataGridMatrix_A.RowCount = 1;
                }
            }
            #endregion
        }
        /// <summary>
        /// Задает количество столбцов для матрицы "В"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumericColumns_B_ValueChanged(object sender, EventArgs e)
        {
            #region Если установлен флаг, то происходит подгонка матриц по столбцам
            if (checkBoxFit.Checked == true)
            {
                try
                {
                    dataGridMatrix_B.ColumnCount = (int)numericColumns_B.Value;
                    numericColumns_A.Value = numericColumns_B.Value;
                    dataGridMatrix_A.ColumnCount = (int)numericColumns_A.Value;
                }
                catch (ArgumentOutOfRangeException)
                {

                    MessageBox.Show("Неправильно указано количество столбцов!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    dataGridMatrix_A.RowCount = 1;
                }
            }
            #endregion

            #region Задание количества столбцов матрицы "В"
            else
            {
                try
                {
                    dataGridMatrix_B.ColumnCount = (int)numericColumns_B.Value;
                }
                catch (ArgumentOutOfRangeException)
                {

                    MessageBox.Show("Неправильно указано количество столбцов!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    dataGridMatrix_B.ColumnCount = 1;
                }
            }
            #endregion
        }
        /// <summary>
        /// Задает количество строк для матрицы "В"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumericRows_B_ValueChanged(object sender, EventArgs e)
        {
            #region Если установлен флаг, то происходит подгонка матриц по строкам
            if (checkBoxFit.Checked == true)
            {
                try
                {
                    dataGridMatrix_B.RowCount = (int)numericRows_B.Value;
                    numericRows_A.Value = numericRows_B.Value;
                    dataGridMatrix_A.RowCount = (int)numericRows_A.Value;
                }
                catch (ArgumentOutOfRangeException)
                {

                    MessageBox.Show("Неправильно указано количество столбцов!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    dataGridMatrix_B.RowCount = 1;
                }
            }
            #endregion

            #region Задание количества строк в матрице "В"
            else
            {
                try
                {
                    dataGridMatrix_B.RowCount = (int)numericRows_B.Value;
                }
                catch (ArgumentOutOfRangeException)
                {

                    MessageBox.Show("Неправильно указано количество столбцов!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    dataGridMatrix_A.RowCount = 1;
                }
            }
            #endregion
        }
        /// <summary>
        /// Выбирает матрицу "А"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSelectMatrix_B_Click(object sender, EventArgs e)
        {
            dataGridMatrix_A.CurrentCell = dataGridMatrix_A[0, 0];
            dataGridMatrix_A.Select();
        }
        /// <summary>
        /// Выбирает матрицу "В"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSelectMatrix_A_Click(object sender, EventArgs e)
        {
            dataGridMatrix_B.CurrentCell = dataGridMatrix_B[0, 0];
            dataGridMatrix_B.Select();
        }
        /// <summary>
        /// Выполняет операцию сложения над матрицами
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSum_Click(object sender, EventArgs e)
        {
            #region Алгоритм сложения матриц
            if (dataGridMatrix_A.Columns.Count != dataGridMatrix_B.Columns.Count ||
                    dataGridMatrix_A.Rows.Count != dataGridMatrix_B.Rows.Count)
            {
                MessageBox.Show("При сложении матрицы должны быть одинакового размера!",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                ButtonFit_Click(sender, e);
            }
            else
            {
                dataGridResult.RowCount = dataGridMatrix_A.Rows.Count;
                dataGridResult.ColumnCount = dataGridMatrix_A.Columns.Count;

                for (int i = 0; i < dataGridResult.Columns.Count; i++)
                {
                    for (int j = 0; j < dataGridResult.Rows.Count; j++)
                    {
                        try
                        {
                            dataGridResult[i, j].Value = Convert.ToDouble(dataGridMatrix_A[i, j].Value) +
                                                         Convert.ToDouble(dataGridMatrix_B[i, j].Value);
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("В одной или более строк введено не число!",
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
            }
            #endregion
        }
        /// <summary>
        /// Выполняет операцию вычитания над матрицами
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMin_Click(object sender, EventArgs e)
        {
            #region Алгоритм вычитания матриц
            if (dataGridMatrix_A.Columns.Count != dataGridMatrix_B.Columns.Count ||
                    dataGridMatrix_A.Rows.Count != dataGridMatrix_B.Rows.Count)
            {
                MessageBox.Show("При вычитании матрицы должны быть одинакового размера!",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                ButtonFit_Click(sender, e);
            }
            else
            {
                dataGridResult.RowCount = dataGridMatrix_A.Rows.Count;
                dataGridResult.ColumnCount = dataGridMatrix_A.Columns.Count;

                for (int i = 0; i < dataGridResult.Columns.Count; i++)
                {
                    for (int j = 0; j < dataGridResult.Rows.Count; j++)
                    {
                        try
                        {
                            dataGridResult[i, j].Value = Convert.ToDouble(dataGridMatrix_A[i, j].Value) -
                                                         Convert.ToDouble(dataGridMatrix_B[i, j].Value);
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("В одной или более строк введено не число!",
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
            }
            #endregion
        }
        /// <summary>
        /// Выполняет операцию уможения над матрицами (в разработке)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMul_Click(object sender, EventArgs e)
        {
            #region Алгоритм умножения матриц (неправильная логика)
            int i, j, m, n;
            m = dataGridMatrix_A.Columns.Count;
            n = dataGridMatrix_A.Rows.Count;
            dataGridResult.ColumnCount = n;
            dataGridResult.RowCount = m;
            double[,] a = new double[m, n];
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    a[i, j] = Convert.ToDouble(dataGridMatrix_A[j, i].Value);
                }
            }
            double[,] b = new double[m, n];
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    b[i, j] = Convert.ToDouble(dataGridMatrix_B[j, i].Value);
                }
            }
            double[,] c = new double[m, n];
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    c[i, j] = 0;
                    for (int k = 0; k < 2; k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                        dataGridResult[j, i].Value = c[i, j];
                    }
                }
            }
            #endregion
        }
        /// <summary>
        /// Выполняет очистку матрицы "А"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClear_A_Click(object sender, EventArgs e)
        {
            #region Алгоритм очистки матрицы "А"
            DialogResult result = MessageBox.Show("Вы уверены, " +
            "что хотите очистить матрицу?",
            "Подтверждение",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                for (int i = 0; i < dataGridMatrix_A.Columns.Count; i++)
                {
                    for (int j = 0; j < dataGridMatrix_A.Rows.Count; j++)
                    {
                        dataGridMatrix_A[i, j].Value = null;
                    }
                }
            }
            else
            {
                return;
            }
            #endregion
        }
        /// <summary>
        /// Выполняет очистку матрицы "В"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClear_B_Click(object sender, EventArgs e)
        {
            #region Алгоритм очистки матрицы "В"
            DialogResult result = MessageBox.Show("Вы уверены, " +
                "что хотите очистить матрицу?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                for (int i = 0; i < dataGridMatrix_B.Columns.Count; i++)
                {
                    for (int j = 0; j < dataGridMatrix_B.Rows.Count; j++)
                    {
                        dataGridMatrix_B[i, j].Value = null;
                    }
                }
            }
            else
            {
                return;
            }
            #endregion
        }
        /// <summary>
        /// Подгоняет матрицы по размерам
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFit_Click(object sender, EventArgs e)
        {
            #region Алгоритм подгонки матриц
            DialogResult result = MessageBox.Show("Подогнать матрицы по размерам?",
            "Подтверждение",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (dataGridMatrix_A.RowCount > dataGridMatrix_B.RowCount ||
                    dataGridMatrix_A.ColumnCount > dataGridMatrix_B.ColumnCount)
                {

                    dataGridMatrix_B.RowCount = dataGridMatrix_A.RowCount;
                    dataGridMatrix_B.ColumnCount = dataGridMatrix_A.ColumnCount;
                    numericRows_B.Value = numericRows_A.Value;
                    numericColumns_B.Value = numericColumns_A.Value;
                }
                else
                {
                    dataGridMatrix_A.RowCount = dataGridMatrix_B.RowCount;
                    dataGridMatrix_A.ColumnCount = dataGridMatrix_B.ColumnCount;
                    numericRows_A.Value = numericRows_B.Value;
                    numericColumns_A.Value = numericColumns_B.Value;
                }
            }
            else
            {
                return;
            }
            #endregion
        }
        /// <summary>
        /// Очищает результат вычислений
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClear_Result_Click(object sender, EventArgs e)
        {
            #region Алгоритм очистки результата
            DialogResult result = MessageBox.Show("Вы уверены, что хотите очистить результат?",
            "Подтверждение",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                for (int i = 0; i < dataGridResult.Columns.Count; i++)
                {
                    for (int j = 0; j < dataGridResult.Rows.Count; j++)
                    {
                        dataGridResult[i, j].Value = null;
                        dataGridResult.RowCount = 1;
                        dataGridResult.ColumnCount = 0;
                    }
                }
                labelResult.Text = null;
            }
            else
            {
                return;
            }
            #endregion
        }
        /// <summary>
        /// Заполняет матрицу "А" случайными значениями
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFill_A_Click(object sender, EventArgs e)
        {
            #region Алгоритм заполнения матрицы "А" случайными значениями
            Random getRandomValue = new Random();
            RangeDialog range = new RangeDialog();
            range.ShowDialog();
            for (int i = 0; i < dataGridMatrix_A.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridMatrix_A.Rows.Count; j++)
                {
                    dataGridMatrix_A[i, j].Value = getRandomValue.Next(range.firstValue, range.secondValue);
                }
            }
            #endregion
        }
        /// <summary>
        /// Заполняет матрицу "В" случайными значениями
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFill_B_Click(object sender, EventArgs e)
        {
            #region Алгоритм заполнения матрицы "В" случайными значениями
            Random getRandomValue = new Random();
            RangeDialog range = new RangeDialog();
            range.ShowDialog();
            for (int i = 0; i < dataGridMatrix_B.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridMatrix_B.Rows.Count; j++)
                {
                    dataGridMatrix_B[i, j].Value = getRandomValue.Next(range.firstValue, range.secondValue);
                }
            }
            #endregion
        } 
        #endregion
        #region Математические методы матрицы "А"
        /// <summary>
        /// Выполняет вычисление определителя матрицы "А"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDeterminant_A_Click(object sender, EventArgs e)
        {
            #region Алгоритм вычисления детерминанта матрицы "А"

            #region Алгоритм ввода матрицы "А"
            try
            {
                int n = dataGridMatrix_A.Columns.Count, m = dataGridMatrix_A.Rows.Count;
                if (n > 0)
                {
                    double[,] myMatrix = new double[n, m];
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            myMatrix[i, j] = Convert.ToDouble(dataGridMatrix_A[i, j].Value);
                        }
                    }
                    labelResult.Text = $"det(A) = {Determinant(myMatrix)}";
                    labelResult.Font = new Font("Consolas", 12);
                }
            }
            catch (Exception q)
            {
                Console.WriteLine(q.Message.ToString());
            }
            #endregion

            #region Метод, возвращающий полярность текущего элемента матрицы "А"
            int SignOfElement(int i, int j)
            {
                if ((i + j) % 2 == 0)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            #endregion

            #region Метод, создающий меньшую матрицу "А"
            double[,] CreateSmallerMatrix(double[,] input, int i, int j)
            {
                int order = int.Parse(System.Math.Sqrt(input.Length).ToString());
                double[,] output = new double[order - 1, order - 1];
                int x = 0, y = 0;
                for (int m = 0; m < order; m++, x++)
                {
                    if (m != i)
                    {
                        y = 0;
                        for (int n = 0; n < order; n++)
                        {
                            if (n != j)
                            {
                                output[x, y] = input[m, n];
                                y++;
                            }
                        }
                    }
                    else
                    {
                        x--;
                    }
                }
                return output;
            }
            #endregion

            #region Метод, вычисляющий определитель для матрицы "А"
            double Determinant(double[,] input)
            {
                int order = int.Parse(System.Math.Sqrt(input.Length).ToString());
                if (order > 2)
                {
                    double value = 0;
                    for (int j = 0; j < order; j++)
                    {
                        double[,] Temp = CreateSmallerMatrix(input, 0, j);
                        value = value + input[0, j] * (SignOfElement(0, j) * Determinant(Temp));
                    }
                    return value;
                }
                else if (order == 2)
                {
                    return ((input[0, 0] * input[1, 1]) - (input[1, 0] * input[0, 1]));
                }
                else
                {
                    return (input[0, 0]);
                }
            }
            #endregion 

            #endregion
        }
        /// <summary>
        /// Выполняет умножение матрицы "А", на указанное пользователем число
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMul_A_Click(object sender, EventArgs e)
        {
            #region Алгоритм умножения матрицы "А", на указанное пользователем число
            dataGridResult.RowCount = dataGridMatrix_A.Rows.Count;
            dataGridResult.ColumnCount = dataGridMatrix_A.Columns.Count;
            string message = Interaction.InputBox("Введите число: ", "Умножить на число");
            double userValue = double.Parse(message);
            for (int i = 0; i < dataGridResult.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridResult.Rows.Count; j++)
                {
                    try
                    {
                        dataGridResult[i, j].Value = Convert.ToDouble(dataGridMatrix_A[i, j].Value) * userValue;
                    }
                    catch (FormatException)
                    {
                        for (int k = 0; k < dataGridResult.Columns.Count; k++)
                        {
                            for (int n = 0; n < dataGridResult.Rows.Count; n++)
                            {
                                dataGridResult[k, n].Value = null;
                                dataGridResult.RowCount = 0;
                                dataGridResult.ColumnCount = 0;
                            }
                        }
                        MessageBox.Show("В одной или более строк введено не число!",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            #endregion
        }
        /// <summary>
        /// Вычисляет минор, указанного пользователем элемента, 
        /// по столбцам и строкам для матрицы "А"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMinor_A_Click(object sender, EventArgs e)
        {
            #region Алгоритм вычисления минора матрицы "А", указанного пользователем
            Form2 minor = new Form2();
            minor.ShowDialog();
            List<object> tempValues = new List<object>()
            {

            };
            double[,] a = new double[dataGridMatrix_A.Columns.Count, dataGridMatrix_A.Rows.Count];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = Convert.ToDouble(dataGridMatrix_A[i, j].Value);
                }
            }
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i != minor.column - 1 && j != minor.row - 1)
                    {
                        tempValues.Add(a[i, j]);
                    }
                }
            }
            for (int i = 0; i < tempValues.Count; i++)
            {
                if (tempValues[i] == null)
                {
                    tempValues.Remove(tempValues[i]);
                }
            }
            double[,] b = new double[a.GetLength(0) - 1, a.GetLength(1) - 1];
            dataGridResult.ColumnCount = b.GetLength(0);
            dataGridResult.RowCount = b.GetLength(1);
            int count = 0;
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    b[i, j] = Convert.ToDouble(tempValues[count]);
                    count++;
                }
            }
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    dataGridResult[i, j].Value = b[i, j];
                }
            }

            #region Алгоритм ввода матрицы "А"
            try
            {
                int n = dataGridResult.Columns.Count, m = dataGridResult.Rows.Count;
                if (n > 0)
                {
                    double[,] myMatrix = new double[n, m];
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            myMatrix[i, j] = Convert.ToDouble(dataGridResult[i, j].Value);
                        }
                    }
                    labelResult.Text = $"det(A): M{minor.column}{minor.row} = {Determinant(myMatrix)}";
                    labelResult.Font = new Font("Consolas", 12);
                }
            }
            catch (Exception q)
            {
                Console.WriteLine(q.Message.ToString());
            }
            #endregion

            #region Метод, возвращающий полярность текущего элемента матрицы "А"
            int SignOfElement(int i, int j)
            {
                if ((i + j) % 2 == 0)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            #endregion

            #region Метод, создающий меньшую матрицу "А"
            double[,] CreateSmallerMatrix(double[,] input, int i, int j)
            {
                int order = int.Parse(System.Math.Sqrt(input.Length).ToString());
                double[,] output = new double[order - 1, order - 1];
                int x = 0, y = 0;
                for (int m = 0; m < order; m++, x++)
                {
                    if (m != i)
                    {
                        y = 0;
                        for (int n = 0; n < order; n++)
                        {
                            if (n != j)
                            {
                                output[x, y] = input[m, n];
                                y++;
                            }
                        }
                    }
                    else
                    {
                        x--;
                    }
                }
                return output;
            }
            #endregion

            #region Метод, вычисляющий определитель для матрицы "А"
            double Determinant(double[,] input)
            {
                int order = int.Parse(System.Math.Sqrt(input.Length).ToString());
                if (order > 2)
                {
                    double value = 0;
                    for (int j = 0; j < order; j++)
                    {
                        double[,] Temp = CreateSmallerMatrix(input, 0, j);
                        value = value + input[0, j] * (SignOfElement(0, j) * Determinant(Temp));
                    }
                    return value;
                }
                else if (order == 2)
                {
                    return ((input[0, 0] * input[1, 1]) - (input[1, 0] * input[0, 1]));
                }
                else
                {
                    return (input[0, 0]);
                }
            }
            #endregion 

            #region Алгоритм вычисления миноров всех элементов матрицы "А" (не применим)
            /*tempValues.Clear();
            if (row != a.GetLength(1))
            {
                row++;
                goto R;
            }
            if (row == a.GetLength(1))
            {
                if (col != a.GetLength(0))
                {
                    row = 1;
                    col++;
                    goto R;
                }
                else return;
            }*/
            #endregion 

            #endregion
        }
        /// <summary>
        /// Вычисляет ранг матрицы "А"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRank_A_Click(object sender, EventArgs e)
        {
            #region Алгоритм вычисления ранга матрицы "А"
            #region Алгоритм вычисления определителя матрицы "А"
            try
            {
                int n = dataGridMatrix_A.Columns.Count, m = dataGridMatrix_A.Rows.Count;
                if (n > 0)
                {
                    double[,] myMatrix = new double[n, m];
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            myMatrix[i, j] = Convert.ToDouble(dataGridMatrix_A[i, j].Value);
                        }
                    }

                }
            }
            catch (Exception q)
            {
                Console.WriteLine(q.Message.ToString());
            }
            int SignOfElement(int i, int j)
            {
                if ((i + j) % 2 == 0)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            double[,] CreateSmallerMatrix(double[,] input, int i, int j)
            {
                int order = int.Parse(System.Math.Sqrt(input.Length).ToString());
                double[,] output = new double[order - 1, order - 1];
                int x = 0, y = 0;
                for (int m = 0; m < order; m++, x++)
                {
                    if (m != i)
                    {
                        y = 0;
                        for (int n = 0; n < order; n++)
                        {
                            if (n != j)
                            {
                                output[x, y] = input[m, n];
                                y++;
                            }
                        }
                    }
                    else
                    {
                        x--;
                    }
                }
                return output;
            }
            double Determinant(double[,] input)
            {
                int order = int.Parse(System.Math.Sqrt(input.Length).ToString());
                if (order > 2)
                {
                    double value = 0;
                    for (int j = 0; j < order; j++)
                    {
                        double[,] Temp = CreateSmallerMatrix(input, 0, j);
                        value = value + input[0, j] * (SignOfElement(0, j) * Determinant(Temp));
                    }
                    return value;
                }
                else if (order == 2)
                {
                    return ((input[0, 0] * input[1, 1]) - (input[1, 0] * input[0, 1]));
                }
                else
                {
                    return (input[0, 0]);
                }
            }
            #endregion

            #region Метод, возвращающий ранг матрицы "А"
            double Rank(double[,] matrixTemp)
            {
                int rang = 0;
                int q = 1;
                while (q <= MinValue(matrixTemp.GetLength(0), matrixTemp.GetLength(1)))
                {
                    double[,] matbv = new double[q, q];
                    for (int i = 0; i < (matrixTemp.GetLength(0) - (q - 1)); i++)
                    {
                        for (int j = 0; j < (matrixTemp.GetLength(1) - (q - 1)); j++)
                        {
                            for (int k = 0; k < q; k++)
                            {
                                for (int c = 0; c < q; c++)
                                {
                                    matbv[k, c] = matrixTemp[i + k, j + c];
                                }
                            }

                            if (Determinant(matbv) != 0)
                            {

                                rang = q;
                            }
                        }
                    }
                    q++;
                }
                labelResult.Text = $"Rank(A) = {rang}";
                labelResult.Font = new Font("Consolas", 12);
                return rang;
            }
            #endregion

            #region Метод, возвращающий минимальный элемент матрицы "А"
            int MinValue(int a, int b)
            {
                if (a >= b)
                    return b;
                else
                    return a;
            }
            #endregion
            int n1 = dataGridMatrix_A.Columns.Count, m1 = dataGridMatrix_A.Rows.Count;
            double[,] matrix = new double[n1, m1];
            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < m1; j++)
                {
                    matrix[i, j] = Convert.ToDouble(dataGridMatrix_A[i, j].Value);
                }
            }
            Rank(matrix);
            #endregion
        }
        /// <summary>
        /// Транспонирует матрицу "А"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTransposition_A_Click(object sender, EventArgs e)
        {
            #region Алгоритм транспонирования матрицы "А"
            int n = dataGridMatrix_A.Columns.Count;
            int m = dataGridMatrix_A.Rows.Count;
            dataGridResult.ColumnCount = n;
            dataGridResult.RowCount = m;
            double[,] matrix = new double[n, m];
            double[,] matrixTransposition = new double[m, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = Convert.ToDouble(dataGridMatrix_A[i, j].Value);
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrixTransposition[i, j] = matrix[j, i];
                    dataGridResult[i, j].Value = matrixTransposition[i, j];
                }
            }
            #endregion
        }
        /// <summary>
        /// Возвращает обратную матрицу "А"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonReverse_A_Click(object sender, EventArgs e)
        {
            #region Алгоритм обратной матрицы "А"
            int r = dataGridMatrix_A.Columns.Count,
                c = dataGridMatrix_A.Rows.Count;
            dataGridResult.ColumnCount = c;
            dataGridResult.RowCount = r;
            double[][] m;
            m = new double[r][];
            for (int rows = 0; rows < r; rows++)
            {
                m[rows] = new double[r];
            }


            for (int i = 0; i < r; i++)
                for (int j = 0; j < m[i].Length; j++)
                {
                    m[i][j] = Convert.ToDouble(dataGridMatrix_A[i, j].Value);
                }
            double[][] inv = MatrixInverse(m);
            //printing the inverse
            for (int i = 0; i < dataGridResult.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridResult.Rows.Count; j++)
                {
                    dataGridResult[i, j].Value = inv[i][j];
                }
            }
            double[][] MatrixCreate(int rows, int cols)
            {
                double[][] result = new double[rows][];
                for (int i = 0; i < rows; ++i)
                    result[i] = new double[cols];
                return result;
            }
            double[][] MatrixInverse(double[][] matrix)
            {
                int n = matrix.Length;
                double[][] result = MatrixDuplicate(matrix);

                int[] perm;
                int toggle;
                double[][] lum = MatrixDecompose(matrix, out perm,
                  out toggle);
                if (lum == null)
                    throw new Exception("Unable to compute inverse");

                double[] b = new double[n];
                for (int i = 0; i < n; ++i)
                {
                    for (int j = 0; j < n; ++j)
                    {
                        if (i == perm[j])
                            b[j] = 1.0;
                        else
                            b[j] = 0.0;
                    }

                    double[] x = HelperSolve(lum, b);

                    for (int j = 0; j < n; ++j)
                        result[j][i] = x[j];
                }
                return result;
            }

            double[][] MatrixDuplicate(double[][] matrix)
            {
                // allocates/creates a duplicate of a matrix.
                double[][] result = MatrixCreate(c, r);
                for (int i = 0; i < matrix.Length; ++i) // copy the values
                    for (int j = 0; j < matrix[i].Length; ++j)
                        result[i][j] = matrix[i][j];
                return result;
            }

            double[] HelperSolve(double[][] luMatrix, double[] b)
            {
                // before calling this helper, permute b using the perm array
                // from MatrixDecompose that generated luMatrix
                int n = luMatrix.Length;
                double[] x = new double[n];
                b.CopyTo(x, 0);

                for (int i = 1; i < n; ++i)
                {
                    double sum = x[i];
                    for (int j = 0; j < i; ++j)
                        sum -= luMatrix[i][j] * x[j];
                    x[i] = sum;
                }

                x[n - 1] /= luMatrix[n - 1][n - 1];
                for (int i = n - 2; i >= 0; --i)
                {
                    double sum = x[i];
                    for (int j = i + 1; j < n; ++j)
                        sum -= luMatrix[i][j] * x[j];
                    x[i] = sum / luMatrix[i][i];
                }

                return x;
            }

            double[][] MatrixDecompose(double[][] matrix, out int[] perm, out int toggle)
            {
                // Doolittle LUP decomposition with partial pivoting.
                // rerturns: result is L (with 1s on diagonal) and U;
                // perm holds row permutations; toggle is +1 or -1 (even or odd)
                int rows = matrix.Length;
                int cols = matrix[0].Length; // assume square
                if (rows != cols)
                    throw new Exception("Attempt to decompose a non-square m");

                int n = rows; // convenience

                double[][] result = MatrixDuplicate(matrix);

                perm = new int[n]; // set up row permutation result
                for (int i = 0; i < n; ++i) { perm[i] = i; }

                toggle = 1; // toggle tracks row swaps.
                            // +1 -greater-than even, -1 -greater-than odd. used by MatrixDeterminant

                for (int j = 0; j < n - 1; ++j) // each column
                {
                    double colMax = Math.Abs(result[j][j]); // find largest val in col
                    int pRow = j;
                    //for (int i = j + 1; i less-than n; ++i)
                    //{
                    //  if (result[i][j] greater-than colMax)
                    //  {
                    //    colMax = result[i][j];
                    //    pRow = i;
                    //  }
                    //}

                    // reader Matt V needed this:
                    for (int i = j + 1; i < n; ++i)
                    {
                        if (Math.Abs(result[i][j]) > colMax)
                        {
                            colMax = Math.Abs(result[i][j]);
                            pRow = i;
                        }
                    }
                    // Not sure if this approach is needed always, or not.

                    if (pRow != j) // if largest value not on pivot, swap rows
                    {
                        double[] rowPtr = result[pRow];
                        result[pRow] = result[j];
                        result[j] = rowPtr;

                        int tmp = perm[pRow]; // and swap perm info
                        perm[pRow] = perm[j];
                        perm[j] = tmp;

                        toggle = -toggle; // adjust the row-swap toggle
                    }

                    // --------------------------------------------------
                    // This part added later (not in original)
                    // and replaces the 'return null' below.
                    // if there is a 0 on the diagonal, find a good row
                    // from i = j+1 down that doesn't have
                    // a 0 in column j, and swap that good row with row j
                    // --------------------------------------------------

                    if (result[j][j] == 0.0)
                    {
                        // find a good row to swap
                        int goodRow = -1;
                        for (int row = j + 1; row < n; ++row)
                        {
                            if (result[row][j] != 0.0)
                                goodRow = row;
                        }

                        if (goodRow == -1)
                            throw new Exception("Cannot use Doolittle's method");

                        // swap rows so 0.0 no longer on diagonal
                        double[] rowPtr = result[goodRow];
                        result[goodRow] = result[j];
                        result[j] = rowPtr;

                        int tmp = perm[goodRow]; // and swap perm info
                        perm[goodRow] = perm[j];
                        perm[j] = tmp;

                        toggle = -toggle; // adjust the row-swap toggle
                    }
                    // --------------------------------------------------
                    // if diagonal after swap is zero . .
                    //if (Math.Abs(result[j][j]) less-than 1.0E-20) 
                    //  return null; // consider a throw

                    for (int i = j + 1; i < n; ++i)
                    {
                        result[i][j] /= result[j][j];
                        for (int k = j + 1; k < n; ++k)
                        {
                            result[i][k] -= result[i][j] * result[j][k];
                        }
                    }
                } // main j column loop
                return result;
            }
            #endregion
        }
        #endregion
        #region Математические методы матрицы "B"
        /// <summary>
        /// Выполняет вычисление определителя матрицы "B"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDeterminant_B_Click(object sender, EventArgs e)
        {
            #region Алгоритм вычисления детерминанта матрицы "B"

            #region Алгоритм ввода матрицы "B"
            try
            {
                int n = dataGridMatrix_B.Columns.Count, m = dataGridMatrix_B.Rows.Count;
                if (n > 0)
                {
                    double[,] myMatrix = new double[n, m];
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            myMatrix[i, j] = Convert.ToDouble(dataGridMatrix_B[i, j].Value);
                        }
                    }
                    labelResult.Text = $"det(B) = {Determinant(myMatrix)}";
                    labelResult.Font = new Font("Consolas", 12);
                }
            }
            catch (Exception q)
            {
                Console.WriteLine(q.Message.ToString());
            }
            #endregion

            #region Метод, возвращающий полярность текущего элемента матрицы "B"
            int SignOfElement(int i, int j)
            {
                if ((i + j) % 2 == 0)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            #endregion

            #region Метод, создающий меньшую матрицу "B"
            double[,] CreateSmallerMatrix(double[,] input, int i, int j)
            {
                int order = int.Parse(System.Math.Sqrt(input.Length).ToString());
                double[,] output = new double[order - 1, order - 1];
                int x = 0, y = 0;
                for (int m = 0; m < order; m++, x++)
                {
                    if (m != i)
                    {
                        y = 0;
                        for (int n = 0; n < order; n++)
                        {
                            if (n != j)
                            {
                                output[x, y] = input[m, n];
                                y++;
                            }
                        }
                    }
                    else
                    {
                        x--;
                    }
                }
                return output;
            }
            #endregion

            #region Метод, вычисляющий определитель для матрицы "B"
            double Determinant(double[,] input)
            {
                int order = int.Parse(System.Math.Sqrt(input.Length).ToString());
                if (order > 2)
                {
                    double value = 0;
                    for (int j = 0; j < order; j++)
                    {
                        double[,] Temp = CreateSmallerMatrix(input, 0, j);
                        value = value + input[0, j] * (SignOfElement(0, j) * Determinant(Temp));
                    }
                    return value;
                }
                else if (order == 2)
                {
                    return ((input[0, 0] * input[1, 1]) - (input[1, 0] * input[0, 1]));
                }
                else
                {
                    return (input[0, 0]);
                }
            }
            #endregion 

            #endregion
        }
        /// <summary>
        /// Выполняет умножение матрицы "B", на указанное пользователем число
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMul_B_Click(object sender, EventArgs e)
        {
            #region Алгоритм умножения матрицы "B", на указанное пользователем число
            dataGridResult.RowCount = dataGridMatrix_B.Rows.Count;
            dataGridResult.ColumnCount = dataGridMatrix_B.Columns.Count;
            string message = Interaction.InputBox("Введите число: ", "Умножить на число");
            double userValue = double.Parse(message);
            for (int i = 0; i < dataGridResult.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridResult.Rows.Count; j++)
                {
                    try
                    {
                        dataGridResult[i, j].Value = Convert.ToDouble(dataGridMatrix_B[i, j].Value) * userValue;
                    }
                    catch (FormatException)
                    {
                        for (int k = 0; k < dataGridResult.Columns.Count; k++)
                        {
                            for (int n = 0; n < dataGridResult.Rows.Count; n++)
                            {
                                dataGridResult[k, n].Value = null;
                                dataGridResult.RowCount = 0;
                                dataGridResult.ColumnCount = 0;
                            }
                        }
                        MessageBox.Show("В одной или более строк введено не число!",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            #endregion
        }
        /// <summary>
        /// Вычисляет минор, указанного пользователем элемента, 
        /// по столбцам и строкам для матрицы "B"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMinor_B_Click(object sender, EventArgs e)
        {
            #region Алгоритм вычисления минора матрицы "B", указанного пользователем
            Form2 minor = new Form2();
            minor.ShowDialog();
            List<object> tempValues = new List<object>()
            {

            };
            double[,] a = new double[dataGridMatrix_B.Columns.Count, dataGridMatrix_B.Rows.Count];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = Convert.ToDouble(dataGridMatrix_B[i, j].Value);
                }
            }
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i != minor.column - 1 && j != minor.row - 1)
                    {
                        tempValues.Add(a[i, j]);
                    }
                }
            }
            for (int i = 0; i < tempValues.Count; i++)
            {
                if (tempValues[i] == null)
                {
                    tempValues.Remove(tempValues[i]);
                }
            }
            double[,] b = new double[a.GetLength(0) - 1, a.GetLength(1) - 1];
            dataGridResult.ColumnCount = b.GetLength(0);
            dataGridResult.RowCount = b.GetLength(1);
            int count = 0;
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    b[i, j] = Convert.ToDouble(tempValues[count]);
                    count++;
                }
            }
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    dataGridResult[i, j].Value = b[i, j];
                }
            }

            #region Алгоритм вычисления детерминанта матрицы "B"

            #region Алгоритм ввода матрицы "B"
            try
            {
                int n = dataGridResult.Columns.Count, m = dataGridResult.Rows.Count;
                if (n > 0)
                {
                    double[,] myMatrix = new double[n, m];
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            myMatrix[i, j] = Convert.ToDouble(dataGridResult[i, j].Value);
                        }
                    }
                    labelResult.Text = $"det(B) M:{minor.column}{minor.row} = {Determinant(myMatrix)}";
                    labelResult.Font = new Font("Consolas", 12);
                }
            }
            catch (Exception q)
            {
                Console.WriteLine(q.Message.ToString());
            }
            #endregion

            #region Метод, возвращающий полярность текущего элемента матрицы "B"
            int SignOfElement(int i, int j)
            {
                if ((i + j) % 2 == 0)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            #endregion

            #region Метод, создающий меньшую матрицу "B"
            double[,] CreateSmallerMatrix(double[,] input, int i, int j)
            {
                int order = int.Parse(System.Math.Sqrt(input.Length).ToString());
                double[,] output = new double[order - 1, order - 1];
                int x = 0, y = 0;
                for (int m = 0; m < order; m++, x++)
                {
                    if (m != i)
                    {
                        y = 0;
                        for (int n = 0; n < order; n++)
                        {
                            if (n != j)
                            {
                                output[x, y] = input[m, n];
                                y++;
                            }
                        }
                    }
                    else
                    {
                        x--;
                    }
                }
                return output;
            }
            #endregion

            #region Метод, вычисляющий определитель для матрицы "B"
            double Determinant(double[,] input)
            {
                int order = int.Parse(System.Math.Sqrt(input.Length).ToString());
                if (order > 2)
                {
                    double value = 0;
                    for (int j = 0; j < order; j++)
                    {
                        double[,] Temp = CreateSmallerMatrix(input, 0, j);
                        value = value + input[0, j] * (SignOfElement(0, j) * Determinant(Temp));
                    }
                    return value;
                }
                else if (order == 2)
                {
                    return ((input[0, 0] * input[1, 1]) - (input[1, 0] * input[0, 1]));
                }
                else
                {
                    return (input[0, 0]);
                }
            }
            #endregion 

            #endregion

            #region Алгоритм вычисления миноров всех элементов матрицы "А" (не применим)
            tempValues.Clear();
            /*if (row != a.GetLength(1))
                {
                    row++;
                    goto R;
                }
                if (row == a.GetLength(1))
                {
                    if (col != a.GetLength(0))
                    {
                        row = 1;
                        col++;
                        goto R;
                    }
                    else return;
                }*/
            #endregion 

            #endregion
        }
        /// <summary>
        /// Вычисляет ранг матрицы "B"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRank_B_Click(object sender, EventArgs e)
        {
            #region Алгоритм вычисления ранга матрицы "B"

            #region Алгоритм вычисления определителя матрицы "B"
            try
            {
                int n = dataGridMatrix_B.Columns.Count, m = dataGridMatrix_B.Rows.Count;
                if (n > 0)
                {
                    double[,] myMatrix = new double[n, m];
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            myMatrix[i, j] = Convert.ToDouble(dataGridMatrix_B[i, j].Value);
                        }
                    }

                }
            }
            catch (Exception q)
            {
                Console.WriteLine(q.Message.ToString());
            }
            int SignOfElement(int i, int j)
            {
                if ((i + j) % 2 == 0)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            double[,] CreateSmallerMatrix(double[,] input, int i, int j)
            {
                int order = int.Parse(System.Math.Sqrt(input.Length).ToString());
                double[,] output = new double[order - 1, order - 1];
                int x = 0, y = 0;
                for (int m = 0; m < order; m++, x++)
                {
                    if (m != i)
                    {
                        y = 0;
                        for (int n = 0; n < order; n++)
                        {
                            if (n != j)
                            {
                                output[x, y] = input[m, n];
                                y++;
                            }
                        }
                    }
                    else
                    {
                        x--;
                    }
                }
                return output;
            }
            double Determinant(double[,] input)
            {
                int order = int.Parse(System.Math.Sqrt(input.Length).ToString());
                if (order > 2)
                {
                    double value = 0;
                    for (int j = 0; j < order; j++)
                    {
                        double[,] Temp = CreateSmallerMatrix(input, 0, j);
                        value = value + input[0, j] * (SignOfElement(0, j) * Determinant(Temp));
                    }
                    return value;
                }
                else if (order == 2)
                {
                    return ((input[0, 0] * input[1, 1]) - (input[1, 0] * input[0, 1]));
                }
                else
                {
                    return (input[0, 0]);
                }
            }
            #endregion

            #region Метод, возвращающий ранг матрицы "B"
            double Rank(double[,] matrixTemp)
            {
                int rang = 0;
                int q = 1;
                while (q <= MinValue(matrixTemp.GetLength(0), matrixTemp.GetLength(1)))
                {
                    double[,] matbv = new double[q, q];
                    for (int i = 0; i < (matrixTemp.GetLength(0) - (q - 1)); i++)
                    {
                        for (int j = 0; j < (matrixTemp.GetLength(1) - (q - 1)); j++)
                        {
                            for (int k = 0; k < q; k++)
                            {
                                for (int c = 0; c < q; c++)
                                {
                                    matbv[k, c] = matrixTemp[i + k, j + c];
                                }
                            }

                            if (Determinant(matbv) != 0)
                            {

                                rang = q;
                            }
                        }
                    }
                    q++;
                }
                labelResult.Text = $"Rank(B) = {rang}";
                labelResult.Font = new Font("Consolas", 12);
                return rang;
            }
            #endregion

            #region Метод, возвращающий минимальный элемент матрицы "А"
            int MinValue(int a, int b)
            {
                if (a >= b)
                    return b;
                else
                    return a;
            }
            #endregion

            int n1 = dataGridMatrix_A.Columns.Count, m1 = dataGridMatrix_A.Rows.Count;
            double[,] matrix = new double[n1, m1];
            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < m1; j++)
                {
                    matrix[i, j] = Convert.ToDouble(dataGridMatrix_A[i, j].Value);
                }
            }
            Rank(matrix);
            #endregion
        }
        /// <summary>
        /// Транспонирует матрицу "B"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTransposition_B_Click(object sender, EventArgs e)
        {
            #region Алгоритм транспонирования матрицы "А"
            int n = dataGridMatrix_B.Columns.Count;
            int m = dataGridMatrix_B.Rows.Count;
            dataGridResult.ColumnCount = n;
            dataGridResult.RowCount = m;
            double[,] matrix = new double[n, m];
            double[,] matrixTransposition = new double[m, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = Convert.ToDouble(dataGridMatrix_B[i, j].Value);
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrixTransposition[i, j] = matrix[j, i];
                    dataGridResult[i, j].Value = matrixTransposition[i, j];
                }
            }
            #endregion
        }
        /// <summary>
        /// Возвращает обратную матрицу "В"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReverse_B_Click(object sender, EventArgs e)
        {
            #region Алгоритм обратной матрицы "В"
            int r = dataGridMatrix_B.Columns.Count,
                c = dataGridMatrix_B.Rows.Count;
            dataGridResult.ColumnCount = c;
            dataGridResult.RowCount = r;
            double[][] m;
            m = new double[r][];
            for (int rows = 0; rows < r; rows++)
            {
                m[rows] = new double[r];
            }


            for (int i = 0; i < r; i++)
                for (int j = 0; j < m[i].Length; j++)
                {
                    m[i][j] = Convert.ToDouble(dataGridMatrix_B[i, j].Value);
                }
            double[][] inv = MatrixInverse(m);
            //printing the inverse
            for (int i = 0; i < dataGridResult.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridResult.Rows.Count; j++)
                {
                    dataGridResult[i, j].Value = inv[i][j];
                }
            }
            double[][] MatrixCreate(int rows, int cols)
            {
                double[][] result = new double[rows][];
                for (int i = 0; i < rows; ++i)
                    result[i] = new double[cols];
                return result;
            }
            double[][] MatrixInverse(double[][] matrix)
            {
                int n = matrix.Length;
                double[][] result = MatrixDuplicate(matrix);

                int[] perm;
                int toggle;
                double[][] lum = MatrixDecompose(matrix, out perm,
                  out toggle);
                if (lum == null)
                    throw new Exception("Unable to compute inverse");

                double[] b = new double[n];
                for (int i = 0; i < n; ++i)
                {
                    for (int j = 0; j < n; ++j)
                    {
                        if (i == perm[j])
                            b[j] = 1.0;
                        else
                            b[j] = 0.0;
                    }

                    double[] x = HelperSolve(lum, b);

                    for (int j = 0; j < n; ++j)
                        result[j][i] = x[j];
                }
                return result;
            }

            double[][] MatrixDuplicate(double[][] matrix)
            {
                // allocates/creates a duplicate of a matrix.
                double[][] result = MatrixCreate(c, r);
                for (int i = 0; i < matrix.Length; ++i) // copy the values
                    for (int j = 0; j < matrix[i].Length; ++j)
                        result[i][j] = matrix[i][j];
                return result;
            }

            double[] HelperSolve(double[][] luMatrix, double[] b)
            {
                // before calling this helper, permute b using the perm array
                // from MatrixDecompose that generated luMatrix
                int n = luMatrix.Length;
                double[] x = new double[n];
                b.CopyTo(x, 0);

                for (int i = 1; i < n; ++i)
                {
                    double sum = x[i];
                    for (int j = 0; j < i; ++j)
                        sum -= luMatrix[i][j] * x[j];
                    x[i] = sum;
                }

                x[n - 1] /= luMatrix[n - 1][n - 1];
                for (int i = n - 2; i >= 0; --i)
                {
                    double sum = x[i];
                    for (int j = i + 1; j < n; ++j)
                        sum -= luMatrix[i][j] * x[j];
                    x[i] = sum / luMatrix[i][i];
                }

                return x;
            }

            double[][] MatrixDecompose(double[][] matrix, out int[] perm, out int toggle)
            {
                // Doolittle LUP decomposition with partial pivoting.
                // rerturns: result is L (with 1s on diagonal) and U;
                // perm holds row permutations; toggle is +1 or -1 (even or odd)
                int rows = matrix.Length;
                int cols = matrix[0].Length; // assume square
                if (rows != cols)
                    throw new Exception("Attempt to decompose a non-square m");

                int n = rows; // convenience

                double[][] result = MatrixDuplicate(matrix);

                perm = new int[n]; // set up row permutation result
                for (int i = 0; i < n; ++i) { perm[i] = i; }

                toggle = 1; // toggle tracks row swaps.
                            // +1 -greater-than even, -1 -greater-than odd. used by MatrixDeterminant

                for (int j = 0; j < n - 1; ++j) // each column
                {
                    double colMax = Math.Abs(result[j][j]); // find largest val in col
                    int pRow = j;
                    //for (int i = j + 1; i less-than n; ++i)
                    //{
                    //  if (result[i][j] greater-than colMax)
                    //  {
                    //    colMax = result[i][j];
                    //    pRow = i;
                    //  }
                    //}

                    // reader Matt V needed this:
                    for (int i = j + 1; i < n; ++i)
                    {
                        if (Math.Abs(result[i][j]) > colMax)
                        {
                            colMax = Math.Abs(result[i][j]);
                            pRow = i;
                        }
                    }
                    // Not sure if this approach is needed always, or not.

                    if (pRow != j) // if largest value not on pivot, swap rows
                    {
                        double[] rowPtr = result[pRow];
                        result[pRow] = result[j];
                        result[j] = rowPtr;

                        int tmp = perm[pRow]; // and swap perm info
                        perm[pRow] = perm[j];
                        perm[j] = tmp;

                        toggle = -toggle; // adjust the row-swap toggle
                    }

                    // --------------------------------------------------
                    // This part added later (not in original)
                    // and replaces the 'return null' below.
                    // if there is a 0 on the diagonal, find a good row
                    // from i = j+1 down that doesn't have
                    // a 0 in column j, and swap that good row with row j
                    // --------------------------------------------------

                    if (result[j][j] == 0.0)
                    {
                        // find a good row to swap
                        int goodRow = -1;
                        for (int row = j + 1; row < n; ++row)
                        {
                            if (result[row][j] != 0.0)
                                goodRow = row;
                        }

                        if (goodRow == -1)
                            throw new Exception("Cannot use Doolittle's method");

                        // swap rows so 0.0 no longer on diagonal
                        double[] rowPtr = result[goodRow];
                        result[goodRow] = result[j];
                        result[j] = rowPtr;

                        int tmp = perm[goodRow]; // and swap perm info
                        perm[goodRow] = perm[j];
                        perm[j] = tmp;

                        toggle = -toggle; // adjust the row-swap toggle
                    }
                    // --------------------------------------------------
                    // if diagonal after swap is zero . .
                    //if (Math.Abs(result[j][j]) less-than 1.0E-20) 
                    //  return null; // consider a throw

                    for (int i = j + 1; i < n; ++i)
                    {
                        result[i][j] /= result[j][j];
                        for (int k = j + 1; k < n; ++k)
                        {
                            result[i][k] -= result[i][j] * result[j][k];
                        }
                    }


                } // main j column loop
                return result;
            }
            #endregion
        }
        #endregion

        private void buttonAllResult_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Выполнить все операции и занести результат в отдельный файл?",
                                                  "Подтверждение",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (saveFileDialogResult.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var writer = new System.IO.StreamWriter(saveFileDialogResult.FileName,
                        false,
                        System.Text.Encoding.GetEncoding(1251));
                        writer.Write("Матрица \"А\"\n");
                        for (int i = 0; i < dataGridMatrix_A.Columns.Count; i++)
                        {
                            for (int j = 0; j < dataGridMatrix_A.Rows.Count; j++)
                            {
                                writer.Write(dataGridMatrix_A[i,j].Value + " ");
                            }
                            writer.Write("\n");
                        }
                        ButtonReverse_A_Click(sender, e);
                        writer.Write("\n[Обратная матрица]\n");
                        for (int i = 0; i < dataGridMatrix_A.Columns.Count; i++)
                        {
                            for (int j = 0; j < dataGridMatrix_A.Rows.Count; j++)
                            {
                                writer.Write(dataGridResult[i,j].Value + " ");
                            }
                            writer.Write("\n");
                        }
                        ButtonDeterminant_A_Click(sender, e);
                        writer.Write($"\n[Определитель]\n{labelResult.Text}\n");
                        buttonTransposition_A_Click(sender, e);
                        writer.Write($"\n[Транспонированная матрица]\n");
                        for (int i = 0; i < dataGridMatrix_A.Columns.Count; i++)
                        {
                            for (int j = 0; j < dataGridMatrix_A.Rows.Count; j++)
                            {
                                writer.Write(dataGridResult[i, j].Value + " ");
                            }
                            writer.Write("\n");
                        }
                        writer.Write($"\n[Миноры всех элементов]\n");
                        #region Алгоритм вычисления минора матрицы "А", указанного пользователем
                        int column = 1, row = 1;
                        List<object> tempValues = new List<object>()
                        {

                        };
                        double[,] a = new double[dataGridMatrix_A.Columns.Count, dataGridMatrix_A.Rows.Count];
                    R:  for (int i = 0; i < a.GetLength(0); i++)
                        {
                            for (int j = 0; j < a.GetLength(1); j++)
                            {
                                a[i, j] = Convert.ToDouble(dataGridMatrix_A[i, j].Value);
                            }
                        }
                        for (int i = 0; i < a.GetLength(0); i++)
                        {
                            for (int j = 0; j < a.GetLength(1); j++)
                            {
                                if (i != column - 1 && j != row - 1)
                                {
                                    tempValues.Add(a[i, j]);
                                }
                            }
                        }
                        for (int i = 0; i < tempValues.Count; i++)
                        {
                            if (tempValues[i] == null)
                            {
                                tempValues.Remove(tempValues[i]);
                            }
                        }
                        double[,] b = new double[a.GetLength(0) - 1, a.GetLength(1) - 1];
                        dataGridResult.ColumnCount = b.GetLength(0);
                        dataGridResult.RowCount = b.GetLength(1);
                        int count = 0;
                        for (int i = 0; i < b.GetLength(0); i++)
                        {
                            for (int j = 0; j < b.GetLength(1); j++)
                            {
                                b[i, j] = Convert.ToDouble(tempValues[count]);
                                count++;
                            }
                        }
                        for (int i = 0; i < b.GetLength(0); i++)
                        {
                            for (int j = 0; j < b.GetLength(1); j++)
                            {
                                dataGridResult[i, j].Value = b[i, j];
                            }
                        }
                        #region Алгоритм ввода матрицы "А"
                        try
                        {
                            int n = dataGridResult.Columns.Count, m = dataGridResult.Rows.Count;
                            if (n > 0)
                            {
                                double[,] myMatrix = new double[n, m];
                                writer.Write($"det(A): M{column}{row} = {Determinant(myMatrix)}\n");
                                for (int i = 0; i < n; i++)
                                {
                                    for (int j = 0; j < n; j++)
                                    {
                                        myMatrix[i, j] = Convert.ToDouble(dataGridResult[i, j].Value);
                                        writer.Write(dataGridResult[i, j].Value + " ");
                                    }
                                    writer.Write("\n");
                                }
                            }
                        }
                        catch (Exception q)
                        {
                            Console.WriteLine(q.Message.ToString());
                        }
                        #endregion

                        #region Метод, возвращающий полярность текущего элемента матрицы "А"
                        int SignOfElement(int i, int j)
                        {
                            if ((i + j) % 2 == 0)
                            {
                                return 1;
                            }
                            else
                            {
                                return -1;
                            }
                        }
                        #endregion

                        #region Метод, создающий меньшую матрицу "А"
                        double[,] CreateSmallerMatrix(double[,] input, int i, int j)
                        {
                            int order = int.Parse(System.Math.Sqrt(input.Length).ToString());
                            double[,] output = new double[order - 1, order - 1];
                            int x = 0, y = 0;
                            for (int m = 0; m < order; m++, x++)
                            {
                                if (m != i)
                                {
                                    y = 0;
                                    for (int n = 0; n < order; n++)
                                    {
                                        if (n != j)
                                        {
                                            output[x, y] = input[m, n];
                                            y++;
                                        }
                                    }
                                }
                                else
                                {
                                    x--;
                                }
                            }
                            return output;
                        }
                        #endregion

                        #region Метод, вычисляющий определитель для матрицы "А"
                        double Determinant(double[,] input)
                        {
                            int order = int.Parse(System.Math.Sqrt(input.Length).ToString());
                            if (order > 2)
                            {
                                double value = 0;
                                for (int j = 0; j < order; j++)
                                {
                                    double[,] Temp = CreateSmallerMatrix(input, 0, j);
                                    value = value + input[0, j] * (SignOfElement(0, j) * Determinant(Temp));
                                }
                                return value;
                            }
                            else if (order == 2)
                            {
                                return ((input[0, 0] * input[1, 1]) - (input[1, 0] * input[0, 1]));
                            }
                            else
                            {
                                return (input[0, 0]);
                            }
                        }
                        #endregion

                        #region Алгоритм вычисления миноров всех элементов матрицы "А" 
                        tempValues.Clear();
                        if (row != a.GetLength(1))
                        {
                            row++;
                            goto R;
                        }
                        if (row == a.GetLength(1))
                        {
                            if (column != a.GetLength(0))
                            {
                                row = 1;
                                column++;
                                goto R;
                            }
                            else
                            {
                                writer.Close();
                                return;
                            }
                        }
                        #endregion

                        #endregion
                        writer.Close();
                    }
                    catch (Exception exp)
                    { 
                        MessageBox.Show(exp.Message,
                        "Ошибка", MessageBoxButtons.OK, 
                        MessageBoxIcon.Exclamation);
                    }
                }
            }
            else return;
            
        }

        private void timerStartCalculating_Tick(object sender, EventArgs e)
        {

        }
    }
}

