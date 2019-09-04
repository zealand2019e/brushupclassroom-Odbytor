using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class Student
    {
        private string _name;
        private int _birth_month;
        private int _birthday;

        public string Name
        {
            get { return _name; }
          private  set { _name = value; }
        }

        public int Birth_month
        {
            get { return _birth_month; }
           private set { _birth_month = value; }
        }

        public int Birthday
        {
            get { return _birthday; }
            private set { _birthday = value;  }
        }

        public Student(string name, int birthmonth, int birthday )
        {
            Name = name;
            Birthday = birthday;
            Birth_month = birthmonth;
        }



    }
}
