using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Validator class is used for making sure correct inputs are entered
// created January 2020
// Author: Steven Hillman

namespace StevenHillman_CPRG_200_Lab1
{
    public static class Validator
    {
        // checks if the textbox has something in it
        public static bool IsPresent(TextBox tb, string name)
        {
            bool valid = true; // assume true, check otherwise
            if (tb.Text == "") // if there is nothing tell the user what is required
            {
                valid = false;
                MessageBox.Show(name + " is required", "Input Error");
                tb.Focus();
            }
            return valid;
        }

        // checks if the input of the textbox is a positive decimal number
        public static bool IsNonNegativeDecimal(TextBox tb, string name)
        {
            bool valid = true; // assume true
            decimal val;
            if (!Decimal.TryParse(tb.Text, out val)) // if not a decimal value tell user what is required
            {
                valid = false;
                MessageBox.Show(name + " must be a number", "Input Error");
                tb.SelectAll();
                tb.Focus();
            }
            else if (val < 0) // if negative tell user the number must be positve or zero
            {
                valid = false;
                MessageBox.Show(name + " must be positive or zero");
                tb.SelectAll();
                tb.Focus();
            }
            return valid;
        }
    }
}
