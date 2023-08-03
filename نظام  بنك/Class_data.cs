using System;
using System.Collections.Generic;

namespace Bank_Management
{
    //Defining a class  data --------------------------------
   sealed class data
    {
        private void intro()
        {

            Console.Write("\n\t\t\t*************************************************\n");
            Console.Write("\n\t\t\t*      ^-^ Rafa,Ahlam,Aida,Tsneem,Mariam  ^-*   *\n");
            Console.Write("\n\t\t\t*           Bank  Management System:            *\n");
            Console.Write("\n\t\t\t*  Using all opject orinted programming Tools   *\n ");
            Console.Write("\n\t\t\t*************************************************\n\n\n");

        }
        public void showintro()
        {
            intro();
        }
        public void load()
        {
            Console.Write("\n\n\n\t\tLoading");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(".");
                System.Threading.Thread.Sleep(500);
            }
        }
    }
}
