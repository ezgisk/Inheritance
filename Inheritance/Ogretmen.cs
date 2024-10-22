using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Ogretmen : BaseKisi
    {
        public decimal Salary { get; set; }
        public void TeacherInfo()////Function that prints salary
        {
            
            Console.WriteLine($"Maaş bılgısı: {Salary}");
            WriteNameSurname();
        }
    }
}
