using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Product book1 = new Product("Book1",400);
            //Product book2 = new Product("Book2",500);

            //int result=book1.CompareTo(book2);

            Emplyoee emplyoee1 = new Emplyoee { salary=3000 };
            Emplyoee emplyoee2= new Emplyoee { salary=6000 };

            SalaryComparison comaparsal=new SalaryComparison();
            int s1 = comaparsal.Compare(emplyoee1,emplyoee2);

            if(s1 <0 )
            {
                Console.WriteLine("salary is less");
            }
            else if(s1 > 0)
            {
                Console.WriteLine("salary is grater");
            }
            else{
                Console.WriteLine("Both are equals");
            }



        }
    }
}
