
using Inheritance;
using System.Net.Http.Headers;

//Creating ogrencı class
Ogrencı ogrencı = new Ogrencı
{
    Name = "Ezgı",
    Surname = "Gecımlı",
    StudentNo = "15as5462s"

};
//Creating ogretmen class
Ogretmen ogretmen = new Ogretmen
{
    Name = "Derya",
    Surname = "Ulu",
    Salary = 800000
};
// Öğrencı bilgilerini yazdırma
Console.WriteLine("Öğrenci Bilgileri:");
ogrencı.StudentInfo();

Console.WriteLine(); 

// Öğretmen bilgilerini yazdırma
Console.WriteLine("Öğretmen Bilgileri:");
ogretmen.TeacherInfo();


Console.ReadKey();