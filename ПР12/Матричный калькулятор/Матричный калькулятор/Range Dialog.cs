using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Матричный_калькулятор
{
    public partial class RangeDialog : Form
    {
        public int firstValue { get; set; }
        public int secondValue { get; set; }

        public RangeDialog()
        {
            InitializeComponent();
        }

        private void Range_Dialog_Load(object sender, EventArgs e)
        {

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxRange.Checked == true)
                {
                    firstValue = int.Parse(textBoxFirstValue.Text) + 1;
                    secondValue = int.Parse(textBoxSecondValue.Text) + 1;
                    Close();
                }
                else
                {
                    firstValue = int.Parse(textBoxFirstValue.Text);
                    secondValue = int.Parse(textBoxSecondValue.Text);
                    Close();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введено не число!", 
                "Ошибка", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Warning);
                Close();
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            textBoxFirstValue.Text = null;
            textBoxSecondValue.Text = null;
            this.Close();
        }
    }
}
