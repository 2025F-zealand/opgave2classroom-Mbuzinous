// See https://aka.ms/new-console-template for more information
using ClassRoomNet60;

Console.WriteLine("Hello, World!");

ClassRoom DatRoskilde = new ClassRoom();
DatRoskilde.ClassName = "3Q";
DatRoskilde.SemesterStart = new DateTime(2019, 8, 26);


try
{
    Student Kevin = new("Kevin", 02, 2000);
    Student Oliver = new("Oliver", 4, 1995);
    Student Gorm = new("Gorm", 5, 1995);
    Student Jonas = new("Jonas", -55, 2000);

    DatRoskilde.Students.Add(Kevin);
    DatRoskilde.Students.Add(Oliver);
    DatRoskilde.Students.Add(Gorm);
    DatRoskilde.Students.Add(Jonas);
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}


foreach (Student student in DatRoskilde.Students)
{
    Console.WriteLine(student);
}

void BirthCounter(List<Student> students)
{
    List<Student> winter = new List<Student>();
    List<Student> spring = new List<Student>();
    List<Student> summer = new List<Student>();
    List<Student> autumn = new List<Student>();

    winter = students.FindAll(x => x.BirthMonth == 12 || x.BirthMonth == 1 || x.BirthMonth == 2);
    spring = students.FindAll(x => x.BirthMonth == 3 || x.BirthMonth == 4 || x.BirthMonth == 5);
    summer = students.FindAll(x => x.BirthMonth == 6 || x.BirthMonth == 7 || x.BirthMonth == 8);
    autumn = students.FindAll(x => x.BirthMonth == 9 || x.BirthMonth == 10 || x.BirthMonth == 11);

    Console.WriteLine($"Number of student for: \nWinter: {winter.Count}\nSpring: {spring.Count}\nSummer: {summer.Count}\nAutumn: {autumn.Count}");
}

BirthCounter(DatRoskilde.Students);

