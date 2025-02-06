// See https://aka.ms/new-console-template for more information
using ClassRoomNet60;

Console.WriteLine("Hello, World!");

ClassRoom DatRoskilde = new ClassRoom();
DatRoskilde.ClassName = "3Q";
DatRoskilde.SemesterStart = new DateTime(2019, 8, 26);

Student Kevin = new("Kevin", 02, 2000);
Student Oliver = new("Oliver", 4, 1995);
Student Gorm = new("Gorm", 5, 1995);
Student Jonas = new("Jonas", 6, 2000);

DatRoskilde.Students.Add(Kevin);
DatRoskilde.Students.Add(Oliver);
DatRoskilde.Students.Add(Gorm);
DatRoskilde.Students.Add(Jonas);

foreach (Student student in DatRoskilde.Students)
{
    Console.WriteLine(student);
}



