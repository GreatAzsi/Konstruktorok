using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktorok
{
    public class Car
    {
        public string Brand { get; set; }
        public string Type { get; set; }
        public int MakeYear { get; set; }
        public int Age { get; set; }
        public Car(string brand, string type, int makeYear) 
        {
            Brand = brand;
            Type = type;
            MakeYear = makeYear;
            Age = 2026-MakeYear;
        }
        public override string ToString() 
        {
            return $"{Brand}: {Type} : {MakeYear} : {Age}";
        }
    }
}
