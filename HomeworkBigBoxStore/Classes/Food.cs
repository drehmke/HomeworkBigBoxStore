using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkBigBoxStore.Classes
{
    class Food : Commodity
    {
        public int QtyInStock { get; set; }
        public string Consistancy { get; set; }
        public override void PrintInfo()
        {
            Utilities.PrintColoredLine("Blue");
            Console.WriteLine("Food : {0}\t\t\t{1:c}\t\nBrand: {2}\t\tAgeGroup: {3}\nQty In Stock: {4}\t\tConsitancy: {5}", this.Name, this.Price, this.Brand, this.AgeGroup, this.QtyInStock, this.Consistancy);
        }

        public Food(string name, decimal price, string brand, string ageGroup, int qty, string consistancy)
        {
            this.Name = name;
            this.Price = price;
            this.Brand = brand;
            this.AgeGroup = ageGroup;
            this.QtyInStock = qty;
            this.Consistancy = consistancy;
        }

    }
}
