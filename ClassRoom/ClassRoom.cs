using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class ClassRoom
    {
        public string ClassName;
        public List<string> Classlist;
        public DateTime SemesterStart;


        public ClassRoom()
        {
            Classlist = new List<string>();
        }

        public override string ToString()
        {
            return $"Class Name: {ClassName}, Class list: {Classlist.ToString()}, Semester starts: {SemesterStart}";
        }

        public string season(DateTime date)
        {
            if (date.Month == 12 || date.Month == 1 || date.Month == 2)
                return "Winter";
            else if (date.Month == 6 || date.Month == 7 || date.Month == 8)
                return "Summer";
            else if (date.Month == 9 || date.Month == 11 || date.Month == 10)
                return "Autumn";
            else if (date.Month == 3 || date.Month == 4 || date.Month == 5)
                return "Spring";
            
                return "No";
        }

    }
}
