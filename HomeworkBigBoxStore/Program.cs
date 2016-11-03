using HomeworkBigBoxStore.Classes;
using HomeworkBigBoxStore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkBigBoxStore
{
    class Program
    {
        static void Main(string[] args)
        {
            IProduct[] inventory = new IProduct[]
            {
                // Dog Inventory
                new Dog("Rex", 65m, "Basset Hound", 6, "Brown", true),
                new Dog("Fifi", 150.3m, "Labradoodle", 1, "Blue ", false),
                new Dog("Baloo", 300.56m, "Black Labrador", 2, "Green", true),
                // Cat Inventory
                new Cat("Mittens", 15m, "Ragdoll", 1, "Short", true),
                new Cat("Pouncer", 29.53m, "Siamese", 6, "Long", false),
                new Cat("Pookie", 86.95m, "Oriental", 4, "Short", true ),
                // Food Inventory
                new Food("Banana",.34m,"Del Monte", "All", 15, "Mushy"),
                new Food("Soup", .69m, "Campbells", "Child+", 90, "Watery"),
                new Food("Crackers", 1m, "Saltine  ", "Child+", 20, "Crispy"),
                // TOy Inventory
                new Toy("Barbie Doll", 10m, "Mattel", "Child+", "Plastic", true),
                new Toy("Lego Blocks", 5m, "Lego", "Child+", "Plastic", true),
                new Toy("Cullen Plushi", 10m, "BioWare", "Teen+", "Cloth  ", false),
                // Electronics Inventory
                new Electronics("Television Set", 500m, "Phillips", "Adult", "Entertainment", true),
                new Electronics("Microwave", 99m, "General Electronics", "Adult", "Household", false),
                new Electronics("Laptop", 1200m, "Asus", "Adult", "Computers", true)
            };


            foreach( IProduct item in inventory)
            {
                    item.PrintInfo();
            }
            Console.ReadLine();
        }
    }
}
