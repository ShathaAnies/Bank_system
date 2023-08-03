using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Management
{
    class enumprogram
    {

       enum Bankdays
        {
            Monday, Tusday, Wednesday
                , Thursday, Friday
        }

        public void showactivedays()
        {

            Console.Write("\n" + Bankdays.Monday);
            Console.Write("\t\t" + Bankdays.Tusday);
            Console.Write("\t\t" + Bankdays.Wednesday);
            Console.Write("\t" + Bankdays.Thursday);
            Console.Write("\t" + Bankdays.Friday + "\n");
           


        }
    }

    //Defining a class  holiday --------------------------------
    class holiday
    {
       enumprogram e1;
        string str, sun;
        public holiday(string str, string sun, enumprogram e1)
        {
            this.str = str;
            this.sun = sun;
            this.e1 = e1;
            e1.showactivedays();
        }
        public override string ToString()
        {
            return string.Format("\n\n***the days which they are off:\n{0}\t{1}\n\n" ,str, sun);
        }
       

    }
}

