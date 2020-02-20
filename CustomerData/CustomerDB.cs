using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// CustomerDB class is used for reading and writing customer data to the file
// created January 2020
// Author: Steven Hillman

namespace CustomerData
{
    public static class CustomerDB
    {
        const string path = "Customers.txt"; // located in bin/Debug

        // reads data from the file and calls to display it
        public static List<Customer> ReadCustomers()
        {
            List<Customer> customerList = new List<Customer>(); // create empty list for customers
            Customer c; // for reading customers
            string line; // for next line in the text file
            string[] fields; // for line broken into fields
            using(FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    while (!sr.EndOfStream) // while it is not the end of stream
                    {
                        line = sr.ReadLine();
                        fields = line.Split(','); // split where the commas are
                        c = new Customer(); // create customer and fill with data
                        c.AccountNo = int.Parse(fields[0]);
                        c.CustomerName = fields[1];
                        c.CustomerType = fields[2];
                        c.ChargeAmount = decimal.Parse(fields[3]);
                        customerList.Add(c); // add to the list
                    }
                }
            }
            return customerList;
        }

        // checks if a file is already created if not creates one and saves all customer data
        public static void SaveCustomers(List<Customer> customerList)
        {
            using(FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                using(StreamWriter sw = new StreamWriter(fs))
                {
                    foreach(Customer c in customerList)
                    {
                        sw.WriteLine(c.ToCSV());
                    }
                }
            }
        }
    }
}
