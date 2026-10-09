namespace WinFormsAppCountingSortPersonalAssigment
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_infoSize = new Label();
            label_infoLines = new Label();
            label_infoColumn = new Label();
            numericUpDown_Lines = new NumericUpDown();
            numericUpDown_Column = new NumericUpDown();
            checkBox_EvenMatrix = new CheckBox();
            numericUpDown_MatrixSize = new NumericUpDown();
            label_infoMatrixSize = new Label();
            richTextBox_MatrixAtFirst = new RichTextBox();
            label_infoMatrixAtFirst = new Label();
            richTextBox_SortedMatrix = new RichTextBox();
            label_infoSortedMatrix = new Label();
            button_Sort = new Button();
            button_Generate = new Button();
            richTextBox_Steps = new RichTextBox();
            label_infoSteps = new Label();
            button_Clear = new Button();
            label_infoTime = new Label();
            textBox_Time = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Lines).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Column).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_MatrixSize).BeginInit();
            SuspendLayout();
            // 
            // label_infoSize
            // 
            label_infoSize.AutoSize = true;
            label_infoSize.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            label_infoSize.Location = new Point(203, 11);
            label_infoSize.Name = "label_infoSize";
            label_infoSize.Size = new Size(209, 19);
            label_infoSize.TabIndex = 0;
            label_infoSize.Text = "Введіть розмір матриці";
            // 
            // label_infoLines
            // 
            label_infoLines.AutoSize = true;
            label_infoLines.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_infoLines.Location = new Point(37, 81);
            label_infoLines.Name = "label_infoLines";
            label_infoLines.Size = new Size(198, 20);
            label_infoLines.TabIndex = 1;
            label_infoLines.Text = "Введіть кількість рядків n =";
            // 
            // label_infoColumn
            // 
            label_infoColumn.AutoSize = true;
            label_infoColumn.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_infoColumn.Location = new Point(314, 81);
            label_infoColumn.Name = "label_infoColumn";
            label_infoColumn.Size = new Size(220, 20);
            label_infoColumn.TabIndex = 2;
            label_infoColumn.Text = "Введіть кількість стовпців m =";
            // 
            // numericUpDown_Lines
            // 
            numericUpDown_Lines.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numericUpDown_Lines.Location = new Point(235, 79);
            numericUpDown_Lines.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown_Lines.Name = "numericUpDown_Lines";
            numericUpDown_Lines.Size = new Size(49, 26);
            numericUpDown_Lines.TabIndex = 3;
            numericUpDown_Lines.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // numericUpDown_Column
            // 
            numericUpDown_Column.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numericUpDown_Column.Location = new Point(535, 79);
            numericUpDown_Column.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown_Column.Name = "numericUpDown_Column";
            numericUpDown_Column.Size = new Size(49, 26);
            numericUpDown_Column.TabIndex = 4;
            numericUpDown_Column.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // checkBox_EvenMatrix
            // 
            checkBox_EvenMatrix.AutoSize = true;
            checkBox_EvenMatrix.BackColor = Color.MintCream;
            checkBox_EvenMatrix.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            checkBox_EvenMatrix.Location = new Point(39, 42);
            checkBox_EvenMatrix.Name = "checkBox_EvenMatrix";
            checkBox_EvenMatrix.Size = new Size(179, 22);
            checkBox_EvenMatrix.TabIndex = 5;
            checkBox_EvenMatrix.Text = "Матриця квадратна";
            checkBox_EvenMatrix.UseVisualStyleBackColor = false;
            checkBox_EvenMatrix.CheckedChanged += checkBox_EvenMatrix_CheckedChanged;
            // 
            // numericUpDown_MatrixSize
            // 
            numericUpDown_MatrixSize.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numericUpDown_MatrixSize.Location = new Point(241, 79);
            numericUpDown_MatrixSize.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown_MatrixSize.Name = "numericUpDown_MatrixSize";
            numericUpDown_MatrixSize.Size = new Size(49, 26);
            numericUpDown_MatrixSize.TabIndex = 7;
            numericUpDown_MatrixSize.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label_infoMatrixSize
            // 
            label_infoMatrixSize.AutoSize = true;
            label_infoMatrixSize.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_infoMatrixSize.Location = new Point(34, 81);
            label_infoMatrixSize.Name = "label_infoMatrixSize";
            label_infoMatrixSize.Size = new Size(207, 20);
            label_infoMatrixSize.TabIndex = 6;
            label_infoMatrixSize.Text = "Введіть розмір матриці n =";
            // 
            // richTextBox_MatrixAtFirst
            // 
            richTextBox_MatrixAtFirst.BackColor = Color.Honeydew;
            richTextBox_MatrixAtFirst.Font = new Font("Bahnschrift SemiLight", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBox_MatrixAtFirst.Location = new Point(34, 186);
            richTextBox_MatrixAtFirst.Name = "richTextBox_MatrixAtFirst";
            richTextBox_MatrixAtFirst.Size = new Size(550, 190);
            richTextBox_MatrixAtFirst.TabIndex = 8;
            richTextBox_MatrixAtFirst.Text = "";
            // 
            // label_infoMatrixAtFirst
            // 
            label_infoMatrixAtFirst.AutoSize = true;
            label_infoMatrixAtFirst.BackColor = Color.Honeydew;
            label_infoMatrixAtFirst.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_infoMatrixAtFirst.Location = new Point(246, 166);
            label_infoMatrixAtFirst.Name = "label_infoMatrixAtFirst";
            label_infoMatrixAtFirst.Size = new Size(156, 20);
            label_infoMatrixAtFirst.TabIndex = 9;
            label_infoMatrixAtFirst.Text = "Початкова матриця";
            // 
            // richTextBox_SortedMatrix
            // 
            richTextBox_SortedMatrix.BackColor = Color.Honeydew;
            richTextBox_SortedMatrix.Font = new Font("Bahnschrift SemiLight", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBox_SortedMatrix.Location = new Point(34, 452);
            richTextBox_SortedMatrix.Name = "richTextBox_SortedMatrix";
            richTextBox_SortedMatrix.Size = new Size(550, 198);
            richTextBox_SortedMatrix.TabIndex = 10;
            richTextBox_SortedMatrix.Text = "";
            // 
            // label_infoSortedMatrix
            // 
            label_infoSortedMatrix.AutoSize = true;
            label_infoSortedMatrix.BackColor = Color.Honeydew;
            label_infoSortedMatrix.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_infoSortedMatrix.Location = new Point(232, 429);
            label_infoSortedMatrix.Name = "label_infoSortedMatrix";
            label_infoSortedMatrix.Size = new Size(180, 20);
            label_infoSortedMatrix.TabIndex = 11;
            label_infoSortedMatrix.Text = "Посортована матриця";
            // 
            // button_Sort
            // 
            button_Sort.BackColor = Color.SeaGreen;
            button_Sort.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            button_Sort.ForeColor = Color.MintCream;
            button_Sort.Location = new Point(475, 382);
            button_Sort.Name = "button_Sort";
            button_Sort.Size = new Size(109, 36);
            button_Sort.TabIndex = 12;
            button_Sort.Text = "Сортувати";
            button_Sort.UseVisualStyleBackColor = false;
            button_Sort.Click += button_Sort_Click;
            // 
            // button_Generate
            // 
            button_Generate.BackColor = Color.Honeydew;
            button_Generate.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            button_Generate.ForeColor = Color.DarkGreen;
            button_Generate.Location = new Point(466, 118);
            button_Generate.Name = "button_Generate";
            button_Generate.Size = new Size(118, 36);
            button_Generate.TabIndex = 13;
            button_Generate.Text = "Згенерувати";
            button_Generate.UseVisualStyleBackColor = false;
            button_Generate.Click += button_Generate_Click_1;
            // 
            // richTextBox_Steps
            // 
            richTextBox_Steps.BackColor = Color.Honeydew;
            richTextBox_Steps.Font = new Font("Bahnschrift SemiLight", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBox_Steps.Location = new Point(608, 50);
            richTextBox_Steps.Name = "richTextBox_Steps";
            richTextBox_Steps.Size = new Size(672, 600);
            richTextBox_Steps.TabIndex = 14;
            richTextBox_Steps.Text = "";
            // 
            // label_infoSteps
            // 
            label_infoSteps.AutoSize = true;
            label_infoSteps.BackColor = Color.Honeydew;
            label_infoSteps.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_infoSteps.Location = new Point(891, 30);
            label_infoSteps.Name = "label_infoSteps";
            label_infoSteps.Size = new Size(145, 20);
            label_infoSteps.TabIndex = 15;
            label_infoSteps.Text = "Кроки сортування";
            // 
            // button_Clear
            // 
            button_Clear.BackColor = Color.Honeydew;
            button_Clear.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            button_Clear.ForeColor = Color.DarkGreen;
            button_Clear.Location = new Point(1185, 660);
            button_Clear.Name = "button_Clear";
            button_Clear.RightToLeft = RightToLeft.No;
            button_Clear.Size = new Size(95, 36);
            button_Clear.TabIndex = 16;
            button_Clear.Text = "Очистити";
            button_Clear.UseVisualStyleBackColor = false;
            button_Clear.Click += button_Clear_Click;
            // 
            // label_infoTime
            // 
            label_infoTime.AutoSize = true;
            label_infoTime.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label_infoTime.Location = new Point(34, 664);
            label_infoTime.Name = "label_infoTime";
            label_infoTime.Size = new Size(127, 18);
            label_infoTime.TabIndex = 17;
            label_infoTime.Text = "Час сортування";
            // 
            // textBox_Time
            // 
            textBox_Time.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_Time.Location = new Point(167, 660);
            textBox_Time.Name = "textBox_Time";
            textBox_Time.Size = new Size(125, 26);
            textBox_Time.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1292, 700);
            Controls.Add(textBox_Time);
            Controls.Add(label_infoTime);
            Controls.Add(button_Clear);
            Controls.Add(label_infoSteps);
            Controls.Add(richTextBox_Steps);
            Controls.Add(button_Generate);
            Controls.Add(button_Sort);
            Controls.Add(label_infoSortedMatrix);
            Controls.Add(richTextBox_SortedMatrix);
            Controls.Add(label_infoMatrixAtFirst);
            Controls.Add(richTextBox_MatrixAtFirst);
            Controls.Add(numericUpDown_MatrixSize);
            Controls.Add(label_infoMatrixSize);
            Controls.Add(checkBox_EvenMatrix);
            Controls.Add(numericUpDown_Column);
            Controls.Add(numericUpDown_Lines);
            Controls.Add(label_infoColumn);
            Controls.Add(label_infoLines);
            Controls.Add(label_infoSize);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Lines).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Column).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_MatrixSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_infoSize;
        private Label label_infoLines;
        private Label label_infoColumn;
        private NumericUpDown numericUpDown_Lines;
        private NumericUpDown numericUpDown_Column;
        private CheckBox checkBox_EvenMatrix;
        private NumericUpDown numericUpDown_MatrixSize;
        private Label label_infoMatrixSize;
        private RichTextBox richTextBox_MatrixAtFirst;
        private Label label_infoMatrixAtFirst;
        private RichTextBox richTextBox_SortedMatrix;
        private Label label_infoSortedMatrix;
        private Button button_Sort;
        private Button button_Generate;
        private RichTextBox richTextBox_Steps;
        private Label label_infoSteps;
        private Button button_Clear;
        private Label label_infoTime;
        private TextBox textBox_Time;
    }
}
