namespace Матричный_калькулятор
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelRow = new System.Windows.Forms.Label();
            this.labelColumn = new System.Windows.Forms.Label();
            this.textBoxColumn = new System.Windows.Forms.TextBox();
            this.textBoxRow = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelRow
            // 
            this.labelRow.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRow.Location = new System.Drawing.Point(12, 43);
            this.labelRow.Name = "labelRow";
            this.labelRow.Size = new System.Drawing.Size(170, 20);
            this.labelRow.TabIndex = 0;
            this.labelRow.Text = "Введите строку:";
            // 
            // labelColumn
            // 
            this.labelColumn.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColumn.Location = new System.Drawing.Point(12, 9);
            this.labelColumn.Name = "labelColumn";
            this.labelColumn.Size = new System.Drawing.Size(170, 20);
            this.labelColumn.TabIndex = 1;
            this.labelColumn.Text = "Введите столбец:";
            // 
            // textBoxColumn
            // 
            this.textBoxColumn.BackColor = System.Drawing.Color.White;
            this.textBoxColumn.ForeColor = System.Drawing.Color.Black;
            this.textBoxColumn.Location = new System.Drawing.Point(190, 9);
            this.textBoxColumn.Multiline = true;
            this.textBoxColumn.Name = "textBoxColumn";
            this.textBoxColumn.Size = new System.Drawing.Size(80, 20);
            this.textBoxColumn.TabIndex = 2;
            // 
            // textBoxRow
            // 
            this.textBoxRow.Location = new System.Drawing.Point(190, 44);
            this.textBoxRow.Multiline = true;
            this.textBoxRow.Name = "textBoxRow";
            this.textBoxRow.Size = new System.Drawing.Size(80, 20);
            this.textBoxRow.TabIndex = 3;
            // 
            // buttonEnter
            // 
            this.buttonEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(85)))));
            this.buttonEnter.FlatAppearance.BorderSize = 0;
            this.buttonEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnter.Font = new System.Drawing.Font("Consolas", 10F);
            this.buttonEnter.ForeColor = System.Drawing.Color.White;
            this.buttonEnter.Location = new System.Drawing.Point(16, 71);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(254, 25);
            this.buttonEnter.TabIndex = 12;
            this.buttonEnter.Text = "Ввод";
            this.buttonEnter.UseVisualStyleBackColor = false;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(275, 105);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxRow);
            this.Controls.Add(this.textBoxColumn);
            this.Controls.Add(this.labelColumn);
            this.Controls.Add(this.labelRow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Минор элемента";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRow;
        private System.Windows.Forms.Label labelColumn;
        private System.Windows.Forms.Button buttonEnter;
        public System.Windows.Forms.TextBox textBoxColumn;
        public System.Windows.Forms.TextBox textBoxRow;
    }
}