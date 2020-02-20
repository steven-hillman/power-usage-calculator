using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// customer class is used for creating the customer objects
// created January 2020
// Author: Steven Hillman

namespace CustomerData
{
    public class Customer
    {
        // private data
        int accountNo; // customer account number
        string customerName; // customer name
        string customerType; // industrial commercial or residential
        decimal chargeAmount; // charge amount

        // public properties
        public int AccountNo
        {
            get
            {
                return accountNo;
            }
            set
            {
                accountNo = value; // use the value provided when this property is used
            }
        }

        public string CustomerName
        {
            get
            {
                return customerName;
            }
            set
            {
                customerName = value;
            }
        }

        public string CustomerType
        {
            get
            {
                return customerType;
            }
            set
            {
                customerType = value;
            }
        }

        public decimal ChargeAmount
        {
            get
            {
                return chargeAmount;
            }
            set
            {
                chargeAmount = value;
            }
        }

        // constructors

        public Customer() { } // default constructor

        public Customer(int account, string name, string type, decimal charge) // with parameters
        {
            accountNo = account;
            customerName = name;
            customerType = type;
            chargeAmount = charge;
        }

        // public methods
        public decimal CalculateCharge()
        {
            return chargeAmount;
        }

        // for displaying customer data as a string in the list box
        public override string ToString()
        {
            return accountNo + ", " + customerName + ", " + chargeAmount.ToString() + ", " + customerType;
        }

         // used to create the comma seperated values for storing the data in the text file
        public string ToCSV()
        {
            return accountNo.ToString() + "," + customerName + "," + customerType + "," + chargeAmount.ToString();
        }
    }
}
