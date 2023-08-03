using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Management
{

    //Defining a class program ------------------------------


    class program : accounts
    {
        static List<accounts> accountlist = new List<accounts>();
      
        static program c = new program();


        //Password verfication and Menu 
        static void Main(string[] args)
        {

            //int m;

            data show = new data();
            program b = new program();
            show.load();
            Console.Clear();
            show.showintro();
            Console.WriteLine("\n\n\n***Bank active days are as fallowing :");  
            enumprogram h1 = new enumprogram();
            holiday h2 = new holiday("sutarday", "sunday", h1);
            Console.Write(h2);
            Console.Write("\nEnter your password :");
            string password = Console.ReadLine();
            if (password == "0")
            {
                //bool close = true;
             //   while (close)
                //{

                    Console.Clear();

                    A:
                    Console.Write("\n\n\n\t******* Main Menu*******");
                    Console.Write("\n\t 1. New Account");
                    Console.Write("\n\t 2. DELETE Amount");
                    Console.Write("\n\t 3. Deposite Amount");
                    Console.Write("\n\t 4. Withdarw Amount");
                    Console.Write("\n\t 5. search Amount");
                    Console.Write("\n\t 6. All Acount Holder List");
                    Console.Write("\n\t 7. Exite");
                    Console.Write("Choose your option from menu Option(1-7):");
                    int option = int.Parse(Console.ReadLine());

                    if (option == 1)
                    {
                        Console.Clear();
                        show.load();
                        createaccount();
                        goto A;

                    }
                    else if (option == 2)
                    {
                        Console.Clear();
                        show.load();
                        Removeaccount();
                        goto A;
                    }
                    else if (option == 3)
                    {
                        Console.Clear();
                        show.load();
                        accountdep();
                        goto A;
                    }
                    else if (option == 4)
                    {
                        Console.Clear();
                        show.load();
                        Withdarw();
                        goto A;
                    }
                    else if (option == 5)
                    {
                        Console.Clear();
                        show.load();
                        Searchaccount();
                        goto A;
                    }
                    
                    else if (option == 6)
                    {
                        Console.Clear();
                        show.load();
                        showaccount();
                        goto A;
                    }
                    else if (option == 7)
                    {
                        Console.WriteLine("Thank you ^-*");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Invalid option -_-\nRetry !!!");
                    }
                }
           // }
            else
            {
                Console.WriteLine("Invalid password -_-");
                Console.WriteLine("\n_________________________________________________________________________\n");
            }
            Console.ReadLine();
        }

        //To add account details to the bank  database





        public static void createaccount()
        {
            program c = new program();
            Console.WriteLine("count Id:{0}", c.useraccount = accountlist.Count + 1);
            Console.Write("\n\n enter the name of the account holder:");
            c.name = Console.ReadLine();
            Console.Write("enter the type if the account (c/s):");
            c.type = char.Parse(Console.ReadLine());
            Console.Write("enter the initial amount (>=500 for saving >=1000 for current)::");
            c.deposite = int.Parse(Console.ReadLine());
            accountlist.Add(c);
            Console.Write("\n\naccount created... ^-^\n");
        }

        //To delete account details from the bank database

        public static void Removeaccount()
        {
            accounts b = new accounts();
            Console.Write("\n\nEnter accounts id to be deleted :\n ");

            int Del = int.Parse(Console.ReadLine());

            if (accountlist.Exists(x => x.useraccount == Del))
            {
                accountlist.RemoveAt(Del - 1);
                Console.WriteLine("\n account id - {0} has been deleted", Del);
                Console.WriteLine("\n_________________________________________________________________________\n");
            }
            else
            {
                Console.WriteLine("\nInvalid account id");
            }

           // bookList.Add(b);
        }
        //To search account details from the bank database using account id

        public static void Searchaccount()
        {
            accounts book = new accounts();
            Console.Write("\n\nSearch by account id :");
            int find = int.Parse(Console.ReadLine());

            if (accountlist.Exists(x => x.useraccount == find))
            {
                foreach (accounts searchId in accountlist)
                {
                    if (searchId.useraccount == find)
                    {
                        Console.WriteLine("\ncount Id :{0}\n" +
                        " account name :{1}\n" +
                        " account type :{2}\n" +
                        " account amount  :{3}", searchId.useraccount, searchId.name, searchId.type, searchId.deposite);
                        Console.WriteLine("\n_________________________________________________________________________\n");
                    }
                }
            }
            else
            {
                Console.WriteLine("\naccount id {0} not found", find);
            }
        }


        //To return showaccount  from the bank database 
        public static void showaccount()
        {

            accounts book = new accounts();
            foreach (accounts show in accountlist)
            {    
                Console.Write("\n\n ^-^ the account :( {0}  ) \n", show.useraccount);
                Console.Write("\n account number :{0}", show.useraccount);
                Console.Write("\n account holder name :{0}", show.name);
                Console.Write("\n Type of account :{0}", show.type);
                Console.Write("\n Balance amount :{0}\n", show.deposite);
                Console.Write("\n_________________________________________\n");

            }
        }

        //To  add to ccount using account id   
        public static void accountdep()
        {

            accounts book = new accounts();
            Console.Write("\nDeposite Amount id :");
            int find = int.Parse(Console.ReadLine());

            if (accountlist.Exists(x => x.useraccount == find))
            {
                int x;
                Console.Write("\n enter amount you want to deposite  ");
                x = int.Parse(Console.ReadLine());


                foreach (accounts searchId in accountlist)
                {
                    if (searchId.useraccount == find)
                    {
                        searchId.deposite = searchId.deposite + x;
                        int sum = searchId.deposite;
                        Console.WriteLine("\n count Id :{0}\n" +
                        " account name :{1}\n" +
                        " account type :{2}\n" +
                        " account amount  :{3}", searchId.useraccount, searchId.name, searchId.type, sum);
                        Console.WriteLine("\n_________________________________________________________________________\n");
                    }
                }
            }
            else
            {
                Console.WriteLine("\n account id {0} not found", find);
            }
        }



        //To Withdarw from account using account id   
        public static void Withdarw()
        {

            accounts book = new accounts();
            Console.Write("\n Deposite Amount id :");
            int find = int.Parse(Console.ReadLine());

            if (accountlist.Exists(x => x.useraccount == find))
            {
                int x;
                Console.Write("\n enter amount you want to deposite  ");
                x = int.Parse(Console.ReadLine());


                foreach (accounts searchId in accountlist)
                {
                    if (searchId.useraccount == find)
                    {
                        searchId.deposite = searchId.deposite - x;
                        int sum = searchId.deposite;
                        Console.WriteLine("\n count Id :{0}\n" +
                        " account name :{1}\n" +
                        " account type :{2}\n" +
                        " account amount  :{3}", searchId.useraccount, searchId.name, searchId.type, sum);
                        Console.WriteLine("\n_________________________________________________________________________\n");
                    }
                }
            }
            else
            {
                Console.WriteLine("\n account id {0} not found", find);
            }
        }


    }
}
//   ^-^ done...........^-^

