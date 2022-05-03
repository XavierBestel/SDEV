using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actual_S.A.C
{
    public partial class Form1 : Form
    {
        float total = 0f;
        public Form1()
        {
            InitializeComponent();
        }

        private void resetInputs()
        {
            numAge.Value = 0;
            numAmount.Value = 0;

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int age = (int)numAge.Value;
            float purchasedPrice = (float)numAmount.Value;
            float total = 0f; 

            if(age == 0 | purchasedPrice == 0.0)
            {
                lblAmount.Text = "Enter Proper Amount";
            }
            else
            {
                float currentValue = CalculateCurrentValue(purchasedPrice, age);
                total += currentValue;
                lblAmount.Text = $"it is worth {currentValue}.\n the Colllection so far is Worth {total}";
            }

            resetInputs();

        }

        private float CalculateCurrentValue(float purchasedValue, int age)
        {
            float depriciation = purchasedValue * 0.2f * age;
            if (depriciation > purchasedValue) return 0f;
            return purchasedValue - depriciation; 
        }
        private void numAmount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnQoute_Click(object sender, EventArgs e)
        {
            resetInputs();
            lblAmount.Text = "";  
        }
    }
}
