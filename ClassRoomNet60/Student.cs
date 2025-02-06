using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

            if (birthMonth > 12 || birthMonth < 1) { throw new Exception("Insert valid birth month"); }

            BirthMonth = birthMonth;
            

            BirthYear = birthYear;
        }


        public string BirthSeason()
        {
            if (BirthMonth == 12 || BirthMonth == 1 || BirthMonth == 2)
            {
                return "Winter";
            }
            if (BirthMonth == 3 || BirthMonth == 4 || BirthMonth == 5)
            {
                return "Spring";
            }
            if (BirthMonth == 6 || BirthMonth == 7 || BirthMonth == 8)
            {
                return "Summer";
            }

            return "Autumn";

        }

        public override string ToString()
        {
            return "Name: " + Name.PadRight(20) + "Birth Month: " + BirthMonth + "                " + "Birth Year: " + BirthYear + "                " + "Season: " + BirthSeason();
        }

    }
}
