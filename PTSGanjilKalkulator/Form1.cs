using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTSKalkuator
{
    public partial class Form1 : Form
    {
        double value1, value2, result;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToDouble(txtValue1.Text);
            value2 = Convert.ToDouble(txtValue2.Text);
            result = value1 + value2;
            txtResult.Text = result.ToString();
        }

        private void btnKali_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToDouble(txtValue1.Text);
            value2 = Convert.ToDouble(txtValue2.Text);
            result = value1 * value2;
            txtResult.Text = result.ToString("#0.00");
        }

        private void btnBagi_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToDouble(txtValue1.Text);
            value2 = Convert.ToDouble(txtValue2.Text);
            result = value1 / value2;
            txtResult.Text = result.ToString();
        }

        private void btnKurang_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToDouble(txtValue1.Text);
            value2 = Convert.ToDouble(txtValue2.Text);
            result = value1 - value2;
            txtResult.Text = result.ToString();
        }

        private void txtValue1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtValue2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtValue1.Text = String.Empty;
            txtValue2.Text = String.Empty;
            txtResult.Text = String.Empty;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
