using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class ClassRoom
    {
        public string ClassName { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
        public DateTime SemesterStart { get; set; }

        public ClassRoom() { }

        public void BirthCounter()
        {
            List<Student> winter = new List<Student>();
            List<Student> spring = new List<Student>();
            List<Student> summer = new List<Student>();
            List<Student> autumn = new List<Student>();

            winter = Students.FindAll(x => x.BirthMonth == 12 || x.BirthMonth == 1 || x.BirthMonth == 2);
            spring = Students.FindAll(x => x.BirthMonth == 3 || x.BirthMonth == 4 || x.BirthMonth == 5);
            summer = Students.FindAll(x => x.BirthMonth == 6 || x.BirthMonth == 7 || x.BirthMonth == 8);
            autumn = Students.FindAll(x => x.BirthMonth == 9 || x.BirthMonth == 10 || x.BirthMonth == 11);
            
            Console.WriteLine($"Number of student for: \nWinter: {winter.Count}\nSpring: {spring.Count}\nSummer: {summer.Count}\nAutumn: {autumn.Count}");
        }
    }
}
