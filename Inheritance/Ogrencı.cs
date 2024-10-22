using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Ogrencı : BaseKisi
    {
        public string StudentNo { get; set; }

        public void StudentInfo()//Function that prints student no
        {
            Console.WriteLine($"Numarası: {StudentNo}");
            WriteNameSurname();

        }
    }
}
