using System;
using System.Collections.Generic;

namespace Inlamningsuppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        public static void Start()
        {
            //create login function with denial message if password is wrong
            Console.WriteLine("Enter Password: ");
            string password = Console.ReadLine();
            password = password.ToLower();

            if (password != "csharks")
            {
                Console.WriteLine("Wrong password");
                Start();
            }
            else
            {
                MainMenu();
            }


            

            //create List of participants
            List<Participant> lists = new List<Participant>();
        }

        //create menu (list all participants, get 10 generic details about participants, get specific string about each participants
        public static void MainMenu()
        {

        }
    }
}
