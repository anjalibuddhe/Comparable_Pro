using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableProject
{
    public class Emplyoee
    {
        public int salary { get; set; }
        
    }
    public class SalaryComparison : IComparer<Emplyoee>
    {
        public int Compare(Emplyoee sal, Emplyoee sal1)
        {
            if(sal.salary < sal1.salary)
            {
                return -1;
            }
            else if (sal.salary > sal1.salary)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }
    }
}
