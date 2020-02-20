using CustomerData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Application is used to calculate price for power usage depending on the type of customer, displays to the list box, saves the customer data and displays totals
// on launch the application will load all data previously saved to the file Customers.txt in the StevenHillman_CPRG_200_Lab1\bin\Debug directory
// this application automatically saves new data added to the customer list
// if this database text file does not exist, the application will create one
// created January 2020
// Author: Steven Hillman
// SAIT OOSD project 2

namespace StevenHillman_CPRG_200_Lab1
{
    public partial class Form1 : Form
    {
        // form level variables
        List<Customer> customers = new List<Customer>(); // list to display customers in list box
        List<Customer> industrial = new List<Customer>(); // list for sum of industrial customers calculation
        List<Customer> residential = new List<Customer>(); // list for sum of residential customers calculation
        List<Customer> commercial = new List<Customer>(); // list for sum of commercial customers calculation

        public Form1()
        {
            InitializeComponent();
        }

        // closes the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // clears all textfields
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtkWh.Text = "";
            txtPeakkWh.Text = "";
            txtOffkWh.Text = "";
            txtCharge.Text = "";
            txtCustomerName.Text = "";
            txtTotalCustomers.Text = "";
            txtIndustrial.Text = "";
            txtCommercial.Text = "";
            txtResidential.Text = "";
            txtAllCharges.Text = "";
            txtCustomerId.Text = "";
        }

        // calculates total for industrial customer
        private decimal calculateIndustrial()
        {
            decimal peakkWh = Convert.ToDecimal(txtPeakkWh.Text); // stores input data from customer for peak
            decimal offPeakkWh = Convert.ToDecimal(txtOffkWh.Text); // stores input data from customer for offpeak
            decimal totalPeak; // used to calculate total
            decimal totalOffPeak; // used to calculate total
            decimal total; // used to display and contain total
            const decimal PEAKFLAT = 76; // the peak flat rate
            const decimal PEAKRATE = 0.065M; // the peak rate after 1000
            const decimal OFFPEAKFLAT = 40; // off peak flat rate
            const decimal OFFPEAKRATE = 0.028M; // off peak rate after 1000
            const decimal NUM = 1000; // const to store a number for calculation
            if (peakkWh < 1001) // if less than 1000 use flat rate otherwise calculate the price
            {
                totalPeak = PEAKFLAT;
            }
            else
            {
                peakkWh = peakkWh - NUM;
                totalPeak = (peakkWh * PEAKRATE) + PEAKFLAT;

            }
            if (offPeakkWh <= 1000) // if less than 1000 use flat rate otherwise calculate the price
            {
                totalOffPeak = OFFPEAKFLAT;
            }
            else
            {
                offPeakkWh = offPeakkWh - NUM;
                totalOffPeak = (offPeakkWh * OFFPEAKRATE) + PEAKFLAT;
            }
            total = totalPeak + totalOffPeak; // combine both prices to display total
            return total;
        }

        // calculates total for residential customer
        private decimal calculateResidential()
        {
            decimal overallkWh = Convert.ToDecimal(txtkWh.Text); // user input 
            const decimal PRICE = 0.052M; // the price per kWh
            const decimal CHARGE = 6; // the flat rate
            decimal total; // store total
            total = (overallkWh * PRICE) + CHARGE;
            return total;
        }

        // calculates total for commercial customer
        private decimal calculateCommercial()
        {
            decimal overallkWh = Convert.ToDecimal(txtkWh.Text); // user input
            decimal total; // store total
            const decimal FLATRATE = 60; // the flat rate used
            const decimal PRICE = 0.045M; // the price used for calculation
            const decimal NUM = 1000; // used to calculate price after 1000 kWh
            if (overallkWh < 1001) // if under 1000 kWh use flat rate otherwise calculate price
            {
                total = FLATRATE;
            }
            else
            {
                overallkWh = overallkWh - NUM;
                total = (overallkWh * PRICE) + FLATRATE;
            }
            return total;
        }

        // calculates total based upon which radio button is selected
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int account; // value for customer id
            string name; // customer name
            string type; // customer type
            decimal charge; // customer charge amount
            decimal sum; // used to get sum from a calculation to display total sums of each type

            name = txtCustomerName.Text;
            account = int.Parse(txtCustomerId.Text);

            if (radioIndustrial.Checked)
            {
                // checks if both text boxes contain a positve number and displays the total and then assigns values to customer data and creates customer object and displays it and adds customer to the list box
                if (Validator.IsPresent(txtPeakkWh, "Peak kWh") && Validator.IsNonNegativeDecimal(txtPeakkWh, "Peak kWh") && Validator.IsPresent(txtOffkWh, "Off peak kWh") && Validator.IsNonNegativeDecimal(txtOffkWh, "Off peak kWh"))
                {
                    decimal total = calculateIndustrial();
                    txtCharge.Text = total.ToString("c");
                    charge = total;
                    type = "I";
                    Customer cust = new Customer(account, name, type, charge);
                    customers.Add(cust);
                    industrial.Add(cust);
                    sum = CalculateSum(industrial);
                    txtIndustrial.Text = sum.ToString();
                    DisplayCustomers();
                }
            }
            else if(radioResidential.Checked)
            {
                // checks if textbox contains a valid positve number and displays the totals and adds new customer to the list box
                if (Validator.IsPresent(txtkWh, "Overall kWh") && Validator.IsNonNegativeDecimal(txtkWh, "Overall kWh"))
                {
                    decimal total = calculateResidential();
                    txtCharge.Text = total.ToString("c");
                    charge = total;
                    type = "R";
                    Customer cust = new Customer(account, name, type, charge);
                    customers.Add(cust);
                    residential.Add(cust);
                    sum = CalculateSum(residential);
                    txtResidential.Text = sum.ToString();
                    DisplayCustomers();
                }
            }
            else
            {
                // checks if textbox contains a valid positive number and displays the total and adds new customer to the list box
                if (Validator.IsPresent(txtkWh, "Overall kWh") && Validator.IsNonNegativeDecimal(txtkWh, "Overall kWh"))
                {
                    decimal total = calculateCommercial();
                    txtCharge.Text = total.ToString("c");
                    charge = total;
                    type = "C";
                    Customer cust = new Customer(account, name, type, charge);
                    customers.Add(cust);
                    commercial.Add(cust);
                    sum = CalculateSum(commercial);
                    txtCommercial.Text = sum.ToString();
                    DisplayCustomers();
                }
            }
            CustomerDB.SaveCustomers(customers);
        }

        // displays all customers in the list box
        private void DisplayCustomers()
        {
            lstCustomers.Items.Clear();
            foreach (Customer c in customers)
                lstCustomers.Items.Add(c); // implicit call to, ToString()
            txtTotalCustomers.Text = customers.Count.ToString();
            txtAllCharges.Text = CalculateTotal().ToString("c");
            
        }
        
        // used to calculate total for all charges
        private decimal CalculateTotal()
        {
            decimal total = 0; // stores total value to return
            foreach (Customer c in customers)
                total += c.CalculateCharge();
            return total;
        }
         // used to calculate total of the seperate customer types when given the corresponding customer list
        private decimal CalculateSum(List<Customer> c)
        {
            decimal total = 0; // stores total value to return
            foreach (Customer cust in c)
                total += cust.CalculateCharge();
            return total;
        }

        // displays necessary fields for an Industrial customer and hides the others
        private void radioIndustrial_CheckedChanged(object sender, EventArgs e)
        {
            lblOverall.Visible = false;
            txtkWh.Visible = false;
            lblPeak.Visible = true;
            txtPeakkWh.Visible = true;
            lblOffPeak.Visible = true;
            txtOffkWh.Visible = true;
            txtkWh.Text = "";
            txtPeakkWh.Text = "";
            txtOffkWh.Text = "";
            txtCharge.Text = "";
        }

        // displays necessary fields for a residential customer and hides the others
        private void radioResidential_CheckedChanged(object sender, EventArgs e)
        {
            lblOverall.Visible = true;
            txtkWh.Visible = true;
            lblPeak.Visible = false;
            txtPeakkWh.Visible = false;
            lblOffPeak.Visible = false;
            txtOffkWh.Visible = false;
            txtkWh.Text = "";
            txtPeakkWh.Text = "";
            txtOffkWh.Text = "";
            txtCharge.Text = "";
        }

        // displays necessary fields for commercial customer and hides the others
        private void radioCommercial_CheckedChanged(object sender, EventArgs e)
        {
            lblOverall.Visible = true;
            txtkWh.Visible = true;
            lblPeak.Visible = false;
            txtPeakkWh.Visible = false;
            lblOffPeak.Visible = false;
            txtOffkWh.Visible = false;
            txtkWh.Text = "";
            txtPeakkWh.Text = "";
            txtOffkWh.Text = "";
            txtCharge.Text = "";
        }

        // reads the file database and displays the customers in the list box when the form loads
        private void Form1_Load(object sender, EventArgs e)
        {
            customers = CustomerDB.ReadCustomers();
            DisplayCustomers();
            txtCustomerName.Focus();
        }
    }
}
