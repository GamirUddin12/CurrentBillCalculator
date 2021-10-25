using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Current_Bill_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void consutext_TextChanged(object sender, EventArgs e)
        {
            NewMethod();
        }

        public double total_unit;
        public double [] unit_range = { 0,75,200,300,400,600};
        public double[] bill_range = { 4.19,5.72,6.00,6.34,9.94,11.46};


        private void NewMethod()
        {
            if (prevtext.Text != "" && pretext.Text != "")
            {
                total_unit = Math.Abs(Convert.ToDouble(pretext.Text) - Convert.ToDouble(prevtext.Text));
                consutext.Text = total_unit.ToString();

            }
            else { consutext.Text = "0"; }
        }

        private void prevtext_TextChanged(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void pretext_TextChanged(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            int steps = 0;
            for (int i = 0; i < 6; i++) {
                if (total_unit > unit_range[i]) {
                    steps++;
                }
                if (total_unit < unit_range[i]) {
                    break;
                }
            }

            double electricity_bill = calculateBill(steps-1);
            electircity_charge_textBox.Text = electricity_bill.ToString();
            double principalAmount = electricity_bill+Convert.ToDouble(demand_chagre_textBox.Text);
            principal_amount_textBox.Text = principalAmount.ToString();
            double vat = (principalAmount * Convert.ToDouble(vat_textBox.Text)) / 100;
            vatTotal_textBox.Text = vat.ToString();
            double amount = principalAmount + vat;
            amount_textbox.Text = amount.ToString()+"TK";
            
        }

        private double calculateBill(int steps) {
            double temp_bill;
            if (total_unit <= 50) {
                return total_unit*3.75;
            }
            else{
            double temp_reeding = total_unit - unit_range[steps];
            temp_bill = temp_reeding*bill_range[steps];
            for(int i=0;i<steps;i++){
                double diff_unit = unit_range[i + 1] - unit_range[i];
                temp_bill = temp_bill+(bill_range[i] * diff_unit);
            }
            Console.WriteLine(temp_bill);
            return temp_bill;}
        }
               
    }

}
