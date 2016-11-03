using HomeworkBigBoxStore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkBigBoxStore.Classes
{
    abstract class Commodity : IProduct
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Brand { get; set; }
        public string AgeGroup { get; set; }

        public virtual void PrintInfo() { }
    }
}
