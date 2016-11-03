using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkBigBoxStore.Classes
{
    class Toy : Commodity
    {
        public string Material { get; set; }
        public bool hasMoveable { get; set; }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Utilities.PrintColoredLine("DarkGreen");
            Console.WriteLine("Toy : {0}\t\t{1:c}\t\nBrand: {2}\t\t\tAgeGroup: {3}\nMaterial: {4}\t\tHas Moveable Parts: {5}", this.Name, this.Price, this.Brand, this.AgeGroup, this.Material, this.hasMoveable);

        }
        public Toy(string name, decimal price, string brand, string ageGroup, string material, bool hasMoveable)
        {
            this.Name = name;
            this.Price = price;
            this.Brand = brand;
            this.AgeGroup = ageGroup;
            this.Material = material;
            this.hasMoveable = hasMoveable;
        }
    }
}
