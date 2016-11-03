using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkBigBoxStore.Classes
{
    class Cat : Animal
    {
        public string HairLength { get; set; }
        public bool isDeclawed { get; set; }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Utilities.PrintColoredLine("DarkYellow");
            Console.WriteLine("Cat : {0}\t\t\t{1:c}\t\nBreed: {2}\t\t\tAge: {3}\nCoat Length: {4}\t\tDeclawed: {5}", this.Name, this.Price, this.Breed, this.Age, this.HairLength,this.isDeclawed);
        }

        public Cat(string name, decimal price, string breed, int age, string hairLength, bool isDeclawed)
        {
            this.Name = name;
            this.Price = price;
            this.Breed = breed;
            this.Age = Age;
            this.HairLength = hairLength;
            this.isDeclawed = isDeclawed;
        }
    }
}
