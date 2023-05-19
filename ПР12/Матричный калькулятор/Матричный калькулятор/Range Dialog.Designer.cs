namespace Матричный_калькулятор
{
    partial class RangeDialog
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
            this.buttonEnter = new System.Windows.Forms.Button();
            this.textBoxSecondValue = new System.Windows.Forms.TextBox();
            this.textBoxFirstValue = new System.Windows.Forms.TextBox();
            this.labelColumn = new System.Windows.Forms.Label();
            this.labelRow = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.checkBoxRange = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonEnter
            // 
            this.buttonEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(85)))));
            this.buttonEnter.FlatAppearance.BorderSize = 0;
            this.buttonEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnter.Font = new System.Drawing.Font("Consolas", 10F);
            this.buttonEnter.ForeColor = System.Drawing.Color.White;
            this.buttonEnter.Location = new System.Drawing.Point(16, 90);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(147, 25);
            this.buttonEnter.TabIndex = 17;
            this.buttonEnter.Text = "Ввод";
            this.buttonEnter.UseVisualStyleBackColor = false;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // textBoxSecondValue
            // 
            this.textBoxSecondValue.Location = new System.Drawing.Point(61, 43);
            this.textBoxSecondValue.Multiline = true;
            this.textBoxSecondValue.Name = "textBoxSecondValue";
            this.textBoxSecondValue.Size = new System.Drawing.Size(102, 20);
            this.textBoxSecondValue.TabIndex = 16;
            // 
            // textBoxFirstValue
            // 
            this.textBoxFirstValue.BackColor = System.Drawing.Color.White;
            this.textBoxFirstValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxFirstValue.Location = new System.Drawing.Point(61, 9);
            this.textBoxFirstValue.Multiline = true;
            this.textBoxFirstValue.Name = "textBoxFirstValue";
            this.textBoxFirstValue.Size = new System.Drawing.Size(102, 20);
            this.textBoxFirstValue.TabIndex = 15;
            // 
            // labelColumn
            // 
            this.labelColumn.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColumn.Location = new System.Drawing.Point(12, 9);
            this.labelColumn.Name = "labelColumn";
            this.labelColumn.Size = new System.Drawing.Size(43, 20);
            this.labelColumn.TabIndex = 14;
            this.labelColumn.Text = "От:";
            // 
            // labelRow
            // 
            this.labelRow.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRow.Location = new System.Drawing.Point(12, 43);
            this.labelRow.Name = "labelRow";
            this.labelRow.Size = new System.Drawing.Size(170, 20);
            this.labelRow.TabIndex = 13;
            this.labelRow.Text = "До: ";
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(85)))));
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Consolas", 10F);
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(16, 121);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(147, 25);
            this.buttonClose.TabIndex = 18;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // checkBoxRange
            // 
            this.checkBoxRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxRange.Location = new System.Drawing.Point(16, 69);
            this.checkBoxRange.Name = "checkBoxRange";
            this.checkBoxRange.Size = new System.Drawing.Size(147, 18);
            this.checkBoxRange.TabIndex = 19;
            this.checkBoxRange.Text = "Учитывать границы";
            this.checkBoxRange.UseVisualStyleBackColor = true;
            // 
            // RangeDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 155);
            this.ControlBox = false;
            this.Controls.Add(this.checkBoxRange);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxSecondValue);
            this.Controls.Add(this.textBoxFirstValue);
            this.Controls.Add(this.labelColumn);
            this.Controls.Add(this.labelRow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RangeDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Диапазон";
            this.Load += new System.EventHandler(this.Range_Dialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEnter;
        public System.Windows.Forms.TextBox textBoxSecondValue;
        public System.Windows.Forms.TextBox textBoxFirstValue;
        private System.Windows.Forms.Label labelColumn;
        private System.Windows.Forms.Label labelRow;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.CheckBox checkBoxRange;
    }
}