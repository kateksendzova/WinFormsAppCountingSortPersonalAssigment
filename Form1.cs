using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WinFormsAppCountingSortPersonalAssigment
{
    public partial class Form1 : Form
    {
        private double[,] matrix;
        private double maxEl = 6.0;

        public Form1()
        {
            InitializeComponent();

            checkBox_EvenMatrix.CheckedChanged += checkBox_EvenMatrix_CheckedChanged;
            UpdateMatrixInputVisibility();
        }

        private void checkBox_EvenMatrix_CheckedChanged(object sender, EventArgs e)
        {
            UpdateMatrixInputVisibility();
        }

        private void UpdateMatrixInputVisibility()
        {
            bool isSquare = checkBox_EvenMatrix.Checked;

            label_infoLines.Visible = !isSquare;
            numericUpDown_Lines.Visible = !isSquare;

            label_infoColumn.Visible = !isSquare;
            numericUpDown_Column.Visible = !isSquare;

            label_infoMatrixSize.Visible = isSquare;
            numericUpDown_MatrixSize.Visible = isSquare;
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            matrix = null;
            richTextBox_MatrixAtFirst.Clear();
            richTextBox_SortedMatrix.Clear();
            richTextBox_Steps.Clear();
            numericUpDown_Column.Value = 2;
            numericUpDown_Lines.Value = 2;
            numericUpDown_MatrixSize.Value = 2;
            textBox_Time.Clear();
            checkBox_EvenMatrix.Checked = false;
        }

        private void button_Generate_Click_1(object sender, EventArgs e)
        {
            int n, m;
            Random rand = new Random();
            if (checkBox_EvenMatrix.Checked)
            {
                n = (int)numericUpDown_MatrixSize.Value;
                m = n;
            }
            else
            {
                n = (int)numericUpDown_Lines.Value;
                m = (int)numericUpDown_Column.Value;
            }

            matrix = new double[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = rand.NextDouble() * maxEl;
                }
            }

            richTextBox_MatrixAtFirst.Clear();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    richTextBox_MatrixAtFirst.AppendText($"{matrix[i, j]:F2}\t");
                }
                richTextBox_MatrixAtFirst.AppendText("\n");
            }
        }

        private void button_Sort_Click(object sender, EventArgs e)
        {
            if (matrix == null)
            {
                MessageBox.Show("Будь ласка, спочатку згенеруйте матрицю!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            richTextBox_Steps.Clear();
            richTextBox_SortedMatrix.Clear();

            Stopwatch stopwatch = Stopwatch.StartNew();

            CountingSort();

            stopwatch.Stop();

            textBox_Time.Text = stopwatch.Elapsed.ToString(@"hh\:mm\:ss\.ffffff");
        }

        private void CountingSort()
        {
            int lines = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int i = 0; i < lines; i++)
            {
                double minVal = matrix[i, 0];
                int minColIndex = 0;

                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] < minVal)
                    {
                        minVal = matrix[i, j];
                        minColIndex = j;
                    }
                }

                if (minVal != 0)
                {
                    matrix[i, minColIndex] = Math.Log(Math.Abs(minVal));
                }
                else
                {
                    matrix[i, minColIndex] = Math.Log(0.0001);
                }
            }

            richTextBox_Steps.AppendText("Матриця після заміни мінімальних елементів у кожному рядку на ln(|x|):\n");
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    richTextBox_Steps.AppendText($"{matrix[i, j]:F2}\t");
                }
                richTextBox_Steps.AppendText("\n");
            }
            richTextBox_Steps.AppendText("\n" + new string('-', 40) + "\n\n");

            double[] firstLine = new double[columns];
            for (int i = 0; i < columns; i++)
            {
                firstLine[i] = matrix[0, i];
            }

            int scale = 100;
            double minFirst = firstLine[0];
            double maxFirst = firstLine[0];
            for (int i = 0; i < firstLine.Length; i++)
            {
                if (firstLine[i] < minFirst)
                {
                    minFirst = firstLine[i];
                }

                if (firstLine[i] > maxFirst)
                {
                    maxFirst = firstLine[i];
                }
            }

            int minScaled = (int)Math.Floor(minFirst * scale);
            int maxScaled = (int)Math.Ceiling(maxFirst * scale);
            int range = maxScaled - minScaled + 1;

            int[] additionalArray = new int[range];
            double[] sortedArray = (double[])firstLine.Clone();

            for (int j = 0; j < columns; j++)
            {
                int scaledVal = (int)Math.Round(firstLine[j] * scale);
                int indexInCount = scaledVal - minScaled;
                if (indexInCount >= 0 && indexInCount < range)
                {
                    additionalArray[indexInCount]++;
                }
            }

            string formattedFirstLine = "";
            for (int j = 0; j < columns; j++)
            {
                formattedFirstLine += $"{sortedArray[j]:F2}" + (j < columns - 1 ? ", " : "");
            }

            richTextBox_Steps.AppendText($"Початковий рядок для сортування: {formattedFirstLine}\n");
            richTextBox_Steps.AppendText($"Додатковий масив: {string.Join(", ", additionalArray)}\n\n");

            int index = 0;
            for (int i = 0; i < range; i++)
            {
                while (additionalArray[i] > 0)
                {
                    double insertedVal = (double)(i + minScaled) / scale;

                    sortedArray[index] = insertedVal;

                    string currentSortedStr = "";
                    for (int k = 0; k < columns; k++)
                    {
                        currentSortedStr += $"{sortedArray[k]:F2}" + (k < columns - 1 ? ", " : "");
                    }

                    richTextBox_Steps.AppendText($"Вставляємо елемент {insertedVal:F2} на позицію {index}\n");
                    richTextBox_Steps.AppendText($"Поточний масив: {currentSortedStr}\n");
                    richTextBox_Steps.AppendText($"Додатковий масив: {string.Join(", ", additionalArray)}\n\n");

                    index++;
                    additionalArray[i]--;
                }
            }


            

            double[,] tempMatrix = (double[,])matrix.Clone();
            bool[] usedCols = new bool[columns];

            for (int newCol = 0; newCol < columns; newCol++)
            {
                double targetVal = sortedArray[newCol];
                for (int oldCol = 0; oldCol < columns; oldCol++)
                {
                    double currentValRounded = Math.Round(tempMatrix[0, oldCol] * scale) / scale;

                    if (!usedCols[oldCol] && Math.Abs(currentValRounded - targetVal) < 1e-4)
                    {
                        usedCols[oldCol] = true;
                        for (int i = 0; i < lines; i++)
                        {
                            matrix[i, newCol] = tempMatrix[i, oldCol];
                        }
                        break;
                    }
                }
            }

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    richTextBox_SortedMatrix.AppendText($"{matrix[i, j]:F2}\t");
                }
                richTextBox_SortedMatrix.AppendText("\n");
            }
        }
    }
}