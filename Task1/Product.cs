using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Product
    {
        public Product(string name, double price, int count)
        {
            this.Name = name;
            this.Price = price;
            this.Count = count;
        }

        public string Name;
        public double Price;
        private int Count;
        private double Totalncome;

        public void Sell()
        {
            if (this.Count == 0) Console.WriteLine("Mehsul yoxdur");
            else
            {
                this.Count--;
                this.Totalncome += Price;
            }
        }
    }
}
