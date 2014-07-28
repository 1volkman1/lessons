using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meliage_Calculator
{
    public partial class Form1 : Form
    {
        int startMileage;
        int endingMileage;
        double milesTraveling;
        double reimburseRates = 0.39;
        double amountOwed;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startMileage = (int) numericUpDown1.Value;
            endingMileage = (int) numericUpDown2.Value;

            if (startMileage > endingMileage)
            {
                MessageBox.Show(" Начальный пробег не может превышать конечный");
            }
            else
            {
                milesTraveling = endingMileage -= startMileage;
                amountOwed = milesTraveling *= reimburseRates;
                label4.Text = "$" + amountOwed;
            }

;        }
    }
}
