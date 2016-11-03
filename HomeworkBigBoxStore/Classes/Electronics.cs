using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkBigBoxStore.Classes
{
    class Electronics : Commodity
    {
        public string Category { get; set; }
        public bool HasOnOff { get; set; }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Utilities.PrintColoredLine("Green");
            Console.WriteLine("Electronics : {0}\t\t{1:c}\t\nBrand: {2}\t\t\tAgeGroup: {3}\nCategory: {4}\t\tHas Of/Off Switch: {5}", this.Name, this.Price, this.Brand, this.AgeGroup, this.Category, this.HasOnOff);
        }

        public Electronics(string name, decimal price, string brand, string ageGroup, string category, bool hasOnOff)
        {
            this.Name = name;
            this.Price = price;
            this.Brand = brand;
            this.AgeGroup = ageGroup;
            this.Category = category;
            this.HasOnOff = hasOnOff;
        }
    }
}
