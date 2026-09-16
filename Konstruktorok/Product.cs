using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktorok
{
    public class Product
    {
        public string Name { get; set; }
        public int RegPrice { get; set; }
        public double SavePrice { get; set; }
        public Product(string name, int regPrice, int savings)
        {
            Name = name;
            RegPrice = regPrice;
            SavePrice = (regPrice / 100) * (100 - savings);
        }
        public override string ToString() {
            return $"{Name} : {RegPrice} : {SavePrice}";
        }
    }
}
