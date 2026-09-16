using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktorok
{
    public class Movie
    {
        public string Name { get; set; }
        public double Rating { get; set; }
        public bool IsRecomended { get; set; }
        public Movie(string name,double rating) 
        {
            Name = name;
            Rating = rating;
            IsRecomended = rating >= 7;
        }
        public override string ToString()
        {
            return $"{Name} : {Rating} : {IsRecomended}";
        }
    }
}
