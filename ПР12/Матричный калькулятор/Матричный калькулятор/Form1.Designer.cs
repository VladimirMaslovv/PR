namespace Матричный_калькулятор
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBoxMatrix_A = new System.Windows.Forms.GroupBox();
            this.buttonClear_A = new System.Windows.Forms.Button();
            this.buttonFill_A = new System.Windows.Forms.Button();
            this.labelRows_A = new System.Windows.Forms.Label();
            this.numericRows_A = new System.Windows.Forms.NumericUpDown();
            this.labelColums_A = new System.Windows.Forms.Label();
            this.numericColumns_A = new System.Windows.Forms.NumericUpDown();
            this.dataGridMatrix_A = new System.Windows.Forms.DataGridView();
            this.groupBoxMatrix_B = new System.Windows.Forms.GroupBox();
            this.buttonClear_B = new System.Windows.Forms.Button();
            this.buttonFill_B = new System.Windows.Forms.Button();
            this.labelRows_B = new System.Windows.Forms.Label();
            this.numericRows_B = new System.Windows.Forms.NumericUpDown();
            this.labelColumns_B = new System.Windows.Forms.Label();
            this.numericColumns_B = new System.Windows.Forms.NumericUpDown();
            this.dataGridMatrix_B = new System.Windows.Forms.DataGridView();
            this.buttonSelectMatrix_B = new System.Windows.Forms.Button();
            this.buttonSelectMatrix_A = new System.Windows.Forms.Button();
            this.groupBoxOperations = new System.Windows.Forms.GroupBox();
            this.buttonMul = new System.Windows.Forms.Button();
            this.buttonMin = new System.Windows.Forms.Button();
            this.buttonSum = new System.Windows.Forms.Button();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.buttonAllResult = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonClear_Result = new System.Windows.Forms.Button();
            this.dataGridResult = new System.Windows.Forms.DataGridView();
            this.groupBoxOperations_A = new System.Windows.Forms.GroupBox();
            this.buttonMinor_A = new System.Windows.Forms.Button();
            this.buttonTransposition_A = new System.Windows.Forms.Button();
            this.buttonRank_A = new System.Windows.Forms.Button();
            this.buttonMul_A = new System.Windows.Forms.Button();
            this.buttonDeterminant_A = new System.Windows.Forms.Button();
            this.buttonReverse_A = new System.Windows.Forms.Button();
            this.groupBoxOperations_B = new System.Windows.Forms.GroupBox();
            this.buttonMul_B = new System.Windows.Forms.Button();
            this.buttonRank_B = new System.Windows.Forms.Button();
            this.buttonMinor_B = new System.Windows.Forms.Button();
            this.buttonTransposition_B = new System.Windows.Forms.Button();
            this.buttonDeterminant_B = new System.Windows.Forms.Button();
            this.buttonReverse_B = new System.Windows.Forms.Button();
            this.checkBoxFit = new System.Windows.Forms.CheckBox();
            this.buttonFit = new System.Windows.Forms.Button();
            this.saveFileDialogResult = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxMatrix_A.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRows_A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericColumns_A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatrix_A)).BeginInit();
            this.groupBoxMatrix_B.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRows_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericColumns_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatrix_B)).BeginInit();
            this.groupBoxOperations.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResult)).BeginInit();
            this.groupBoxOperations_A.SuspendLayout();
            this.groupBoxOperations_B.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMatrix_A
            // 
            this.groupBoxMatrix_A.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxMatrix_A.Controls.Add(this.buttonClear_A);
            this.groupBoxMatrix_A.Controls.Add(this.buttonFill_A);
            this.groupBoxMatrix_A.Controls.Add(this.labelRows_A);
            this.groupBoxMatrix_A.Controls.Add(this.numericRows_A);
            this.groupBoxMatrix_A.Controls.Add(this.labelColums_A);
            this.groupBoxMatrix_A.Controls.Add(this.numericColumns_A);
            this.groupBoxMatrix_A.Controls.Add(this.dataGridMatrix_A);
            this.groupBoxMatrix_A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxMatrix_A.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxMatrix_A.Location = new System.Drawing.Point(12, 0);
            this.groupBoxMatrix_A.Name = "groupBoxMatrix_A";
            this.groupBoxMatrix_A.Size = new System.Drawing.Size(600, 244);
            this.groupBoxMatrix_A.TabIndex = 0;
            this.groupBoxMatrix_A.TabStop = false;
            this.groupBoxMatrix_A.Text = "Матрица А:";
            // 
            // buttonClear_A
            // 
            this.buttonClear_A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(85)))));
            this.buttonClear_A.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonClear_A.FlatAppearance.BorderSize = 0;
            this.buttonClear_A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear_A.Font = new System.Drawing.Font("Consolas", 10F);
            this.buttonClear_A.ForeColor = System.Drawing.Color.White;
            this.buttonClear_A.Location = new System.Drawing.Point(5, 25);
            this.buttonClear_A.Name = "buttonClear_A";
            this.buttonClear_A.Size = new System.Drawing.Size(90, 25);
            this.buttonClear_A.TabIndex = 11;
            this.buttonClear_A.Text = "Очистить";
            this.buttonClear_A.UseVisualStyleBackColor = false;
            this.buttonClear_A.Click += new System.EventHandler(this.ButtonClear_A_Click);
            // 
            // buttonFill_A
            // 
            this.buttonFill_A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(85)))));
            this.buttonFill_A.FlatAppearance.BorderSize = 2;
            this.buttonFill_A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFill_A.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFill_A.ForeColor = System.Drawing.Color.White;
            this.buttonFill_A.Location = new System.Drawing.Point(367, 17);
            this.buttonFill_A.Name = "buttonFill_A";
            this.buttonFill_A.Size = new System.Drawing.Size(227, 35);
            this.buttonFill_A.TabIndex = 1;
            this.buttonFill_A.Text = "Заполнить";
            this.buttonFill_A.UseVisualStyleBackColor = false;
            this.buttonFill_A.Click += new System.EventHandler(this.ButtonFill_A_Click);
            // 
            // labelRows_A
            // 
            this.labelRows_A.Location = new System.Drawing.Point(96, 25);
            this.labelRows_A.Name = "labelRows_A";
            this.labelRows_A.Size = new System.Drawing.Size(68, 20);
            this.labelRows_A.TabIndex = 1;
            this.labelRows_A.Text = "Строк:";
            // 
            // numericRows_A
            // 
            this.numericRows_A.Location = new System.Drawing.Point(170, 22);
            this.numericRows_A.Name = "numericRows_A";
            this.numericRows_A.Size = new System.Drawing.Size(50, 26);
            this.numericRows_A.TabIndex = 1;
            this.numericRows_A.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericRows_A.ValueChanged += new System.EventHandler(this.NumericRows_A_ValueChanged);
            // 
            // labelColums_A
            // 
            this.labelColums_A.Location = new System.Drawing.Point(224, 25);
            this.labelColums_A.Name = "labelColums_A";
            this.labelColums_A.Size = new System.Drawing.Size(90, 20);
            this.labelColums_A.TabIndex = 3;
            this.labelColums_A.Text = "Столбцов:";
            // 
            // numericColumns_A
            // 
            this.numericColumns_A.Location = new System.Drawing.Point(316, 22);
            this.numericColumns_A.Name = "numericColumns_A";
            this.numericColumns_A.Size = new System.Drawing.Size(49, 26);
            this.numericColumns_A.TabIndex = 2;
            this.numericColumns_A.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericColumns_A.ValueChanged += new System.EventHandler(this.NumericColumns_A_ValueChanged);
            // 
            // dataGridMatrix_A
            // 
            this.dataGridMatrix_A.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.dataGridMatrix_A.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMatrix_A.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(85)))));
            this.dataGridMatrix_A.Location = new System.Drawing.Point(6, 55);
            this.dataGridMatrix_A.Name = "dataGridMatrix_A";
            this.dataGridMatrix_A.Size = new System.Drawing.Size(588, 181);
            this.dataGridMatrix_A.TabIndex = 0;
            // 
            // groupBoxMatrix_B
            // 
            this.groupBoxMatrix_B.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxMatrix_B.Controls.Add(this.buttonClear_B);
            this.groupBoxMatrix_B.Controls.Add(this.buttonFill_B);
            this.groupBoxMatrix_B.Controls.Add(this.labelRows_B);
            this.groupBoxMatrix_B.Controls.Add(this.numericRows_B);
            this.groupBoxMatrix_B.Controls.Add(this.labelColumns_B);
            this.groupBoxMatrix_B.Controls.Add(this.numericColumns_B);
            this.groupBoxMatrix_B.Controls.Add(this.dataGridMatrix_B);
            this.groupBoxMatrix_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxMatrix_B.Font = new System.Drawing.Font("Consolas", 12F);
            this.groupBoxMatrix_B.Location = new System.Drawing.Point(12, 312);
            this.groupBoxMatrix_B.Name = "groupBoxMatrix_B";
            this.groupBoxMatrix_B.Size = new System.Drawing.Size(600, 242);
            this.groupBoxMatrix_B.TabIndex = 4;
            this.groupBoxMatrix_B.TabStop = false;
            this.groupBoxMatrix_B.Text = "Матрица B:";
            // 
            // buttonClear_B
            // 
            this.buttonClear_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(85)))));
            this.buttonClear_B.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonClear_B.FlatAppearance.BorderSize = 0;
            this.buttonClear_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear_B.Font = new System.Drawing.Font("Consolas", 10F);
            this.buttonClear_B.ForeColor = System.Drawing.Color.White;
            this.buttonClear_B.Location = new System.Drawing.Point(5, 25);
            this.buttonClear_B.Name = "buttonClear_B";
            this.buttonClear_B.Size = new System.Drawing.Size(90, 25);
            this.buttonClear_B.TabIndex = 12;
            this.buttonClear_B.Text = "Очистить";
            this.buttonClear_B.UseVisualStyleBackColor = false;
            this.buttonClear_B.Click += new System.EventHandler(this.ButtonClear_B_Click);
            // 
            // buttonFill_B
            // 
            this.buttonFill_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(85)))));
            this.buttonFill_B.FlatAppearance.BorderSize = 2;
            this.buttonFill_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFill_B.Font = new System.Drawing.Font("Consolas", 12F);
            this.buttonFill_B.ForeColor = System.Drawing.Color.White;
            this.buttonFill_B.Location = new System.Drawing.Point(367, 17);
            this.buttonFill_B.Name = "buttonFill_B";
            this.buttonFill_B.Size = new System.Drawing.Size(227, 35);
            this.buttonFill_B.TabIndex = 1;
            this.buttonFill_B.Text = "Заполнить";
            this.buttonFill_B.UseVisualStyleBackColor = false;
            this.buttonFill_B.Click += new System.EventHandler(this.ButtonFill_B_Click);
            // 
            // labelRows_B
            // 
            this.labelRows_B.AutoSize = true;
            this.labelRows_B.Location = new System.Drawing.Point(101, 25);
            this.labelRows_B.Name = "labelRows_B";
            this.labelRows_B.Size = new System.Drawing.Size(63, 19);
            this.labelRows_B.TabIndex = 1;
            this.labelRows_B.Text = "Строк:";
            // 
            // numericRows_B
            // 
            this.numericRows_B.Location = new System.Drawing.Point(170, 22);
            this.numericRows_B.Name = "numericRows_B";
            this.numericRows_B.Size = new System.Drawing.Size(50, 26);
            this.numericRows_B.TabIndex = 1;
            this.numericRows_B.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericRows_B.ValueChanged += new System.EventHandler(this.NumericRows_B_ValueChanged);
            // 
            // labelColumns_B
            // 
            this.labelColumns_B.AutoSize = true;
            this.labelColumns_B.Location = new System.Drawing.Point(224, 25);
            this.labelColumns_B.Name = "labelColumns_B";
            this.labelColumns_B.Size = new System.Drawing.Size(90, 19);
            this.labelColumns_B.TabIndex = 3;
            this.labelColumns_B.Text = "Столбцов:";
            // 
            // numericColumns_B
            // 
            this.numericColumns_B.Location = new System.Drawing.Point(315, 22);
            this.numericColumns_B.Name = "numericColumns_B";
            this.numericColumns_B.Size = new System.Drawing.Size(50, 26);
            this.numericColumns_B.TabIndex = 2;
            this.numericColumns_B.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericColumns_B.ValueChanged += new System.EventHandler(this.NumericColumns_B_ValueChanged);
            // 
            // dataGridMatrix_B
            // 
            this.dataGridMatrix_B.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.dataGridMatrix_B.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMatrix_B.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(85)))));
            this.dataGridMatrix_B.Location = new System.Drawing.Point(6, 55);
            this.dataGridMatrix_B.Name = "dataGridMatrix_B";
            this.dataGridMatrix_B.Size = new System.Drawing.Size(588, 181);
            this.dataGridMatrix_B.TabIndex = 0;
            // 
            // buttonSelectMatrix_B
            // 
            this.buttonSelectMatrix_B.BackColor = System.Drawing.Color.White;
            this.buttonSelectMatrix_B.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(85)))));
            this.buttonSelectMatrix_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectMatrix_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSelectMatrix_B.ForeColor = System.Drawing.Color.Black;
            this.buttonSelectMatrix_B.Location = new System.Drawing.Point(150, 255);
            this.buttonSelectMatrix_B.Name = "buttonSelectMatrix_B";
            this.buttonSelectMatrix_B.Size = new System.Drawing.Size(50, 50);
            this.buttonSelectMatrix_B.TabIndex = 5;
            this.buttonSelectMatrix_B.Text = "⇓";
            this.buttonSelectMatrix_B.UseVisualStyleBackColor = false;
            this.buttonSelectMatrix_B.Click += new System.EventHandler(this.ButtonSelectMatrix_A_Click);
            // 
            // buttonSelectMatrix_A
            // 
            this.buttonSelectMatrix_A.BackColor = System.Drawing.Color.White;
            this.buttonSelectMatrix_A.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(85)))));
            this.buttonSelectMatrix_A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectMatrix_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSelectMatrix_A.ForeColor = System.Drawing.Color.Black;
            this.buttonSelectMatrix_A.Location = new System.Drawing.Point(400, 255);
            this.buttonSelectMatrix_A.Name = "buttonSelectMatrix_A";
            this.buttonSelectMatrix_A.Size = new System.Drawing.Size(50, 50);
            this.buttonSelectMatrix_A.TabIndex = 6;
            this.buttonSelectMatrix_A.Text = "⇑";
            this.buttonSelectMatrix_A.UseVisualStyleBackColor = false;
            this.buttonSelectMatrix_A.Click += new System.EventHandler(this.ButtonSelectMatrix_B_Click);
            // 
            // groupBoxOperations
            // 
            this.groupBoxOperations.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxOperations.Controls.Add(this.buttonMul);
            this.groupBoxOperations.Controls.Add(this.buttonMin);
            this.groupBoxOperations.Controls.Add(this.buttonSum);
            this.groupBoxOperations.Font = new System.Drawing.Font("Consolas", 10F);
            this.groupBoxOperations.Location = new System.Drawing.Point(815, 12);
            this.groupBoxOperations.Name = "groupBoxOperations";
            this.groupBoxOperations.Size = new System.Drawing.Size(354, 50);
            this.groupBoxOperations.TabIndex = 7;
            this.groupBoxOperations.TabStop = false;
            this.groupBoxOperations.Text = "Операции над матрицами А и В:";
            // 
            // buttonMul
            // 
            this.buttonMul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(85)))));
            this.buttonMul.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonMul.FlatAppearance.BorderSize = 0;
            this.buttonMul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMul.Font = new System.Drawing.Font("Consolas", 10F);
            this.buttonMul.ForeColor = System.Drawing.Color.White;
            this.buttonMul.Location = new System.Drawing.Point(258, 19);
            this.buttonMul.Name = "buttonMul";
            this.buttonMul.Size = new System.Drawing.Size(90, 25);
            this.buttonMul.TabIndex = 10;
            this.buttonMul.Text = "Умножение";
            this.buttonMul.UseVisualStyleBackColor = false;
            this.buttonMul.Click += new System.EventHandler(this.ButtonMul_Click);
            // 
            // buttonMin
            // 
            this.buttonMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(85)))));
            this.buttonMin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonMin.FlatAppearance.BorderSize = 0;
            this.buttonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMin.Font = new System.Drawing.Font("Consolas", 10F);
            this.buttonMin.ForeColor = System.Drawing.Color.White;
            this.buttonMin.Location = new System.Drawing.Point(135, 19);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(90, 25);
            this.buttonMin.TabIndex = 9;
            this.buttonMin.Text = "Вычитание";
            this.buttonMin.UseVisualStyleBackColor = false;
            this.buttonMin.Click += new System.EventHandler(this.ButtonMin_Click);
            // 
            // buttonSum
            // 
            this.buttonSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(85)))));
            this.buttonSum.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonSum.FlatAppearance.BorderSize = 0;
            this.buttonSum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSum.Font = new System.Drawing.Font("Consolas", 10F);
            this.buttonSum.ForeColor = System.Drawing.Color.White;
            this.buttonSum.Location = new System.Drawing.Point(6, 19);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(90, 25);
            this.buttonSum.TabIndex = 8;
            this.buttonSum.Text = "Сложение";
            this.buttonSum.UseVisualStyleBackColor = false;
            this.buttonSum.Click += new System.EventHandler(this.ButtonSum_Click);
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.buttonAllResult);
            this.groupBoxResult.Controls.Add(this.labelResult);
            this.groupBoxResult.Controls.Add(this.buttonClear_Result);
            this.groupBoxResult.Controls.Add(this.dataGridResult);
            this.groupBoxResult.Font = new System.Drawing.Font("Consolas", 12F);
            this.groupBoxResult.Location = new System.Drawing.Point(618, 255);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(554, 299);
            this.groupBoxResult.TabIndex = 9;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Результат";
            // 
            // buttonAllResult
            // 
            this.buttonAllResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(85)))));
            this.buttonAllResult.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonAllResult.FlatAppearance.BorderSize = 0;
            this.buttonAllResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAllResult.Font = new System.Drawing.Font("Consolas", 10F);
            this.buttonAllResult.ForeColor = System.Drawing.Color.White;
            this.buttonAllResult.Location = new System.Drawing.Point(312, 23);
            this.buttonAllResult.Name = "buttonAllResult";
            this.buttonAllResult.Size = new System.Drawing.Size(137, 25);
            this.buttonAllResult.TabIndex = 14;
            this.buttonAllResult.Text = "Посчитать все";
            this.buttonAllResult.UseVisualStyleBackColor = false;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelResult.Location = new System.Drawing.Point(6, 33);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 15);
            this.labelResult.TabIndex = 13;
            // 
            // buttonClear_Result
            // 
            this.buttonClear_Result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(85)))));
            this.buttonClear_Result.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonClear_Result.FlatAppearance.BorderSize = 0;
            this.buttonClear_Result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear_Result.Font = new System.Drawing.Font("Consolas", 10F);
            this.buttonClear_Result.ForeColor = System.Drawing.Color.White;
            this.buttonClear_Result.Location = new System.Drawing.Point(455, 23);
            this.buttonClear_Result.Name = "buttonClear_Result";
            this.buttonClear_Result.Size = new System.Drawing.Size(90, 25);
            this.buttonClear_Result.TabIndex = 12;
            this.buttonClear_Result.Text = "Очистить";
            this.buttonClear_Result.UseVisualStyleBackColor = false;
            this.buttonClear_Result.Click += new System.EventHandler(this.ButtonClear_Result_Click);
            // 
            // dataGridResult
            // 
            this.dataGridResult.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.dataGridResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResult.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(85)))));
            this.dataGridResult.Location = new System.Drawing.Point(7, 56);
            this.dataGridResult.Name = "dataGridResult";
            this.dataGridResult.Size = new System.Drawing.Size(538, 237);
            this.dataGridResult.TabIndex = 4;
            // 
            // groupBoxOperations_A
            // 
            this.groupBoxOperations_A.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxOperations_A.Controls.Add(this.buttonMinor_A);
            this.groupBoxOperations_A.Controls.Add(this.buttonTransposition_A);
            this.groupBoxOperations_A.Controls.Add(this.buttonRank_A);
            this.groupBoxOperations_A.Controls.Add(this.buttonMul_A);
            this.groupBoxOperations_A.Controls.Add(this.buttonDeterminant_A);
            this.groupBoxOperations_A.Controls.Add(this.buttonReverse_A);
            this.groupBoxOperations_A.Font = new System.Drawing.Font("Consolas", 10F);
            this.groupBoxOperations_A.Location = new System.Drawing.Point(618, 73);
            this.groupBoxOperations_A.Name = "groupBoxOperations_A";
            this.groupBoxOperations_A.Size = new System.Drawing.Size(551, 80);
            this.groupBoxOperations_A.TabIndex = 10;
            this.groupBoxOperations_A.TabStop = false;
            this.groupBoxOperations_A.Text = "Операции над матрицей А:";
            // 
            // buttonMinor_A
            // 
            this.buttonMinor_A.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(85)))));
            this.buttonMinor_A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinor_A.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.buttonMinor_A.Location = new System.Drawing.Point(194, 48);
            this.buttonMinor_A.Name = "buttonMinor_A";
            this.buttonMinor_A.Size = new System.Drawing.Size(182, 23);
            this.buttonMinor_A.TabIndex = 16;
            this.buttonMinor_A.Text = "Минор элемента";
            this.buttonMinor_A.UseVisualStyleBackColor = true;
            // 
            // buttonTransposition_A
            // 
            this.buttonTransposition_A.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(85)))));
            this.buttonTransposition_A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransposition_A.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.buttonTransposition_A.Location = new System.Drawing.Point(194, 19);
            this.buttonTransposition_A.Name = "buttonTransposition_A";
            this.buttonTransposition_A.Size = new System.Drawing.Size(182, 23);
            this.buttonTransposition_A.TabIndex = 15;
            this.buttonTransposition_A.Text = "Транспонирование";
            this.buttonTransposition_A.UseVisualStyleBackColor = true;
            // 
            // buttonRank_A
            // 
            this.buttonRank_A.BackColor = System.Drawing.Color.Transparent;
            this.buttonRank_A.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(85)))));
            this.buttonRank_A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRank_A.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.buttonRank_A.Location = new System.Drawing.Point(380, 19);
            this.buttonRank_A.Name = "buttonRank_A";
            this.buttonRank_A.Size = new System.Drawing.Size(165, 23);
            this.buttonRank_A.TabIndex = 14;
            this.buttonRank_A.Text = "Ранг матрицы";
            this.buttonRank_A.UseVisualStyleBackColor = false;
            // 
            // buttonMul_A
            // 
            this.buttonMul_A.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(85)))));
            this.buttonMul_A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMul_A.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.buttonMul_A.Location = new System.Drawing.Point(380, 48);
            this.buttonMul_A.Name = "buttonMul_A";
            this.buttonMul_A.Size = new System.Drawing.Size(165, 23);
            this.buttonMul_A.TabIndex = 13;
            this.buttonMul_A.Text = "Умножить на число";
            this.buttonMul_A.UseVisualStyleBackColor = true;
            // 
            // buttonDeterminant_A
            // 
            this.buttonDeterminant_A.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(85)))));
            this.buttonDeterminant_A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeterminant_A.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.buttonDeterminant_A.Location = new System.Drawing.Point(6, 48);
            this.buttonDeterminant_A.Name = "buttonDeterminant_A";
            this.buttonDeterminant_A.Size = new System.Drawing.Size(182, 23);
            this.buttonDeterminant_A.TabIndex = 12;
            this.buttonDeterminant_A.Text = "Определитель";
            this.buttonDeterminant_A.UseVisualStyleBackColor = true;
            this.buttonDeterminant_A.Click += new System.EventHandler(this.ButtonDeterminant_A_Click);
            // 
            // buttonReverse_A
            // 
            this.buttonReverse_A.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(85)))));
            this.buttonReverse_A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReverse_A.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.buttonReverse_A.Location = new System.Drawing.Point(6, 19);
            this.buttonReverse_A.Name = "buttonReverse_A";
            this.buttonReverse_A.Size = new System.Drawing.Size(182, 23);
            this.buttonReverse_A.TabIndex = 11;
            this.buttonReverse_A.Text = "Обратная матрица";
            this.buttonReverse_A.UseVisualStyleBackColor = true;
            // 
            // groupBoxOperations_B
            // 
            this.groupBoxOperations_B.Controls.Add(this.buttonMul_B);
            this.groupBoxOperations_B.Controls.Add(this.buttonRank_B);
            this.groupBoxOperations_B.Controls.Add(this.buttonMinor_B);
            this.groupBoxOperations_B.Controls.Add(this.buttonTransposition_B);
            this.groupBoxOperations_B.Controls.Add(this.buttonDeterminant_B);
            this.groupBoxOperations_B.Controls.Add(this.buttonReverse_B);
            this.groupBoxOperations_B.Font = new System.Drawing.Font("Consolas", 10F);
            this.groupBoxOperations_B.Location = new System.Drawing.Point(618, 164);
            this.groupBoxOperations_B.Name = "groupBoxOperations_B";
            this.groupBoxOperations_B.Size = new System.Drawing.Size(551, 80);
            this.groupBoxOperations_B.TabIndex = 17;
            this.groupBoxOperations_B.TabStop = false;
            this.groupBoxOperations_B.Text = "Операции над матрицей В:";
            // 
            // buttonMul_B
            // 
            this.buttonMul_B.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(85)))));
            this.buttonMul_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMul_B.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.buttonMul_B.Location = new System.Drawing.Point(380, 48);
            this.buttonMul_B.Name = "buttonMul_B";
            this.buttonMul_B.Size = new System.Drawing.Size(165, 23);
            this.buttonMul_B.TabIndex = 17;
            this.buttonMul_B.Text = "Умножить на число";
            this.buttonMul_B.UseVisualStyleBackColor = true;
            // 
            // buttonRank_B
            // 
            this.buttonRank_B.BackColor = System.Drawing.Color.Transparent;
            this.buttonRank_B.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(85)))));
            this.buttonRank_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRank_B.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.buttonRank_B.Location = new System.Drawing.Point(380, 19);
            this.buttonRank_B.Name = "buttonRank_B";
            this.buttonRank_B.Size = new System.Drawing.Size(165, 23);
            this.buttonRank_B.TabIndex = 17;
            this.buttonRank_B.Text = "Ранг матрицы";
            this.buttonRank_B.UseVisualStyleBackColor = false;
            // 
            // buttonMinor_B
            // 
            this.buttonMinor_B.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(85)))));
            this.buttonMinor_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinor_B.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.buttonMinor_B.Location = new System.Drawing.Point(194, 48);
            this.buttonMinor_B.Name = "buttonMinor_B";
            this.buttonMinor_B.Size = new System.Drawing.Size(182, 23);
            this.buttonMinor_B.TabIndex = 17;
            this.buttonMinor_B.Text = "Минор элемента";
            this.buttonMinor_B.UseVisualStyleBackColor = true;
            // 
            // buttonTransposition_B
            // 
            this.buttonTransposition_B.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(85)))));
            this.buttonTransposition_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransposition_B.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.buttonTransposition_B.Location = new System.Drawing.Point(194, 19);
            this.buttonTransposition_B.Name = "buttonTransposition_B";
            this.buttonTransposition_B.Size = new System.Drawing.Size(182, 23);
            this.buttonTransposition_B.TabIndex = 17;
            this.buttonTransposition_B.Text = "Транспонирование";
            this.buttonTransposition_B.UseVisualStyleBackColor = true;
            // 
            // buttonDeterminant_B
            // 
            this.buttonDeterminant_B.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(85)))));
            this.buttonDeterminant_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeterminant_B.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.buttonDeterminant_B.Location = new System.Drawing.Point(6, 48);
            this.buttonDeterminant_B.Name = "buttonDeterminant_B";
            this.buttonDeterminant_B.Size = new System.Drawing.Size(182, 23);
            this.buttonDeterminant_B.TabIndex = 17;
            this.buttonDeterminant_B.Text = "Определитель";
            this.buttonDeterminant_B.UseVisualStyleBackColor = true;
            // 
            // buttonReverse_B
            // 
            this.buttonReverse_B.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(85)))));
            this.buttonReverse_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReverse_B.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.buttonReverse_B.Location = new System.Drawing.Point(6, 19);
            this.buttonReverse_B.Name = "buttonReverse_B";
            this.buttonReverse_B.Size = new System.Drawing.Size(182, 23);
            this.buttonReverse_B.TabIndex = 17;
            this.buttonReverse_B.Text = "Обратная матрица";
            this.buttonReverse_B.UseVisualStyleBackColor = true;
            // 
            // checkBoxFit
            // 
            this.checkBoxFit.AutoSize = true;
            this.checkBoxFit.Font = new System.Drawing.Font("Consolas", 12F);
            this.checkBoxFit.Location = new System.Drawing.Point(625, 8);
            this.checkBoxFit.Name = "checkBoxFit";
            this.checkBoxFit.Size = new System.Drawing.Size(181, 23);
            this.checkBoxFit.TabIndex = 18;
            this.checkBoxFit.Text = "Подгонять матрицы";
            this.checkBoxFit.UseVisualStyleBackColor = true;
            // 
            // buttonFit
            // 
            this.buttonFit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(85)))));
            this.buttonFit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonFit.FlatAppearance.BorderSize = 0;
            this.buttonFit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFit.Font = new System.Drawing.Font("Consolas", 10F);
            this.buttonFit.ForeColor = System.Drawing.Color.White;
            this.buttonFit.Location = new System.Drawing.Point(624, 31);
            this.buttonFit.Name = "buttonFit";
            this.buttonFit.Size = new System.Drawing.Size(182, 25);
            this.buttonFit.TabIndex = 11;
            this.buttonFit.Text = "Подогнать";
            this.buttonFit.UseVisualStyleBackColor = false;
            this.buttonFit.Click += new System.EventHandler(this.ButtonFit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.buttonFit);
            this.Controls.Add(this.checkBoxFit);
            this.Controls.Add(this.groupBoxOperations_B);
            this.Controls.Add(this.groupBoxOperations_A);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBoxOperations);
            this.Controls.Add(this.buttonSelectMatrix_A);
            this.Controls.Add(this.buttonSelectMatrix_B);
            this.Controls.Add(this.groupBoxMatrix_B);
            this.Controls.Add(this.groupBoxMatrix_A);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Матричный калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxMatrix_A.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericRows_A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericColumns_A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatrix_A)).EndInit();
            this.groupBoxMatrix_B.ResumeLayout(false);
            this.groupBoxMatrix_B.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRows_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericColumns_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatrix_B)).EndInit();
            this.groupBoxOperations.ResumeLayout(false);
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResult)).EndInit();
            this.groupBoxOperations_A.ResumeLayout(false);
            this.groupBoxOperations_B.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMatrix_A;
        private System.Windows.Forms.Label labelColums_A;
        private System.Windows.Forms.Label labelRows_A;
        private System.Windows.Forms.Button buttonFill_A;
        private System.Windows.Forms.GroupBox groupBoxMatrix_B;
        private System.Windows.Forms.Button buttonFill_B;
        private System.Windows.Forms.Label labelRows_B;
        private System.Windows.Forms.NumericUpDown numericRows_B;
        private System.Windows.Forms.Label labelColumns_B;
        private System.Windows.Forms.NumericUpDown numericColumns_B;
        private System.Windows.Forms.DataGridView dataGridMatrix_B;
        private System.Windows.Forms.Button buttonSelectMatrix_B;
        private System.Windows.Forms.Button buttonSelectMatrix_A;
        private System.Windows.Forms.GroupBox groupBoxOperations;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Button buttonMul;
        private System.Windows.Forms.GroupBox groupBoxOperations_A;
        private System.Windows.Forms.Button buttonMinor_A;
        private System.Windows.Forms.Button buttonTransposition_A;
        private System.Windows.Forms.Button buttonRank_A;
        private System.Windows.Forms.Button buttonMul_A;
        private System.Windows.Forms.Button buttonDeterminant_A;
        private System.Windows.Forms.Button buttonReverse_A;
        private System.Windows.Forms.GroupBox groupBoxOperations_B;
        private System.Windows.Forms.Button buttonClear_A;
        private System.Windows.Forms.Button buttonClear_B;
        private System.Windows.Forms.CheckBox checkBoxFit;
        private System.Windows.Forms.Button buttonFit;
        private System.Windows.Forms.Button buttonClear_Result;
        public System.Windows.Forms.DataGridView dataGridMatrix_A;
        public System.Windows.Forms.NumericUpDown numericColumns_A;
        public System.Windows.Forms.NumericUpDown numericRows_A;
        public System.Windows.Forms.DataGridView dataGridResult;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonDeterminant_B;
        private System.Windows.Forms.Button buttonReverse_B;
        private System.Windows.Forms.Button buttonMul_B;
        private System.Windows.Forms.Button buttonRank_B;
        private System.Windows.Forms.Button buttonMinor_B;
        private System.Windows.Forms.Button buttonTransposition_B;
        private System.Windows.Forms.Button buttonAllResult;
        private System.Windows.Forms.SaveFileDialog saveFileDialogResult;
    }
}

