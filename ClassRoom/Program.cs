using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom classR = new ClassRoom();
            classR.Classlist.Add("Grzegorz");
            classR.Classlist.Add("Bartosz");
            classR.ClassName = "3Q";
            classR.SemesterStart = Convert.ToDateTime("26-8-2019");
        }
    }
}
