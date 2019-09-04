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
    }
}
