using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktorok
{
    public class Student
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public int Score { get; set; }
        public Student(string Fulltext)
        {
            var parts = Fulltext.Split(';');
            Name = parts[0];
            Class = parts[1];
            Score = int.Parse(parts[2]);
        }
        public override string ToString()
        {
            return $"{Name} : {Class} : {Score}";
        }
    }
}
