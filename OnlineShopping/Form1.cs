using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShopping
{
    public partial class Form1 : Form
    {

        Double firstNum;
        Double secondNum;
        Double answer;
        String operation;

        Double mcSubtotal;
        Double mcTotal;

        Double cCARPETS_PRICE = 2.4;
        Double cFABRIC_PRICE = 3.3;
        Double cBLINDS_PRICE = 4.6;
        Double cDelivery_PRICE = 2.10;
        Double cMileage_PRICE = 2.3;

        Double cPrice;
        Double ItemPrice;
        Double ItemCost;
        Double ItemLengthC;
        Double ItemLengthF;
        Double ItemLengthB;
        Double ItemDelivery;
        Double ItemMileage;
        Double AmountCostC;
        Double AmountCostF;
        Double AmountCostB;
        Double AmountCostT;
        Double iDelivery;
        Double TotalMileage;
        Double cTax;

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            if (label1.Text == "0")
            {
           
                label1.Text = num.Text;
            }
            else
            {
                label1.Text = (label1.Text + num.Text);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
