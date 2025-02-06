using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class Student
    {
        public string Name { get; private set; }
        public int BirthMonth { get; private set; }

        public int BirthYear { get; private set; }

        public Student(string name, int birthMonth, int birthYear)
        {
            Name = name;
            BirthMonth = birthMonth;
            BirthYear = birthYear;
        }

        public override string ToString()
        {
            return "Name: " + Name.PadRight(20) + "Birth Month: " + BirthMonth + "                " + "Birth Year: " + BirthYear;
        }

    }
}
