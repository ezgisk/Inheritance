using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class BaseKisi
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public void WriteNameSurname()//Function that prints name and surname
        {
            Console.WriteLine($"Ad: {Name} Soyad: {Surname}");
        }
    }
}
