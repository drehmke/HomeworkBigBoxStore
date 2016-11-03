using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkBigBoxStore.Classes
{
    class Dog : Animal
    {
        public string EyeColor { get; set; }
        public bool isTrained { get; set; }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Utilities.PrintColoredLine("Yellow");
            Console.WriteLine("Dog : {0}\t\t\t{1:c}\t\nBreed: {2}\t\tAge: {3}\nEye Color: {4}\t\tTrained: {5}", this.Name, this.Price, this.Breed, this.Age, this.EyeColor, this.isTrained);
        }

        public Dog(string name, decimal price, string breed, int age, string eyeColor, bool isTrained)
        {
            this.Name = name;
            this.Price = price;
            this.Breed = breed;
            this.Age = age;
            this.EyeColor = eyeColor;
            this.isTrained = isTrained;
        }
    }
}
