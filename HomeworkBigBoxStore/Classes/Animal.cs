using HomeworkBigBoxStore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkBigBoxStore.Classes
{
    abstract class Animal : IProduct
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public virtual void PrintInfo() { }
    }
}
