using System;
using System.Collections.Generic;
using System.Linq;

namespace Inlamningsuppgift
{
    class Program
    {
        public static List<Participant> participants = new List<Participant>();

        static void Main(string[] args)
        {
            //populate List of participants
            PopulateList();

            Start();
        }



        public static void Start()
        {
            //create login function with denial message if password is wrong
            Console.WriteLine("Enter Password: ");
            string password = Console.ReadLine();

            if (password.ToLower() != "csharks")
            {
                Console.WriteLine("Wrong password");
                Start();
            }
            else
            {
                MainMenu();
            }
        }

        //create menu (list all participants, get 10 generic details about participants, get specific string about each participants
        public static void MainMenu()
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("1.View all participants");
            Console.WriteLine("2.Participants option");

            bool open = true;
            var cki = Console.ReadKey();

            do
            {
                switch (cki.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        ParticipantsList();
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        ParticipantOption();
                        break;
                }
            } while (open == false);
        }

        //Display all participants
        public static void ParticipantsList()
        {
            var last = participants.Last();
            foreach (var participant in participants)
            {
                if (participants.Equals(last))
                {
                    Console.WriteLine(last);
                }
                else
                {
                    Console.WriteLine(participant.FirstName + " " + participant.LastName + ", ");
                }
            }
            Console.WriteLine("press enter to continue");

            Console.ReadLine();
            Console.Clear();
            MainMenu();
        }

        public static void ParticipantOption()
        {
            Console.WriteLine("Choose an option");
            Console.WriteLine("1. Show Participant details");
            Console.WriteLine("2. Show Participant drive to code");

            var cki = Console.ReadKey();

            if (cki.Key == ConsoleKey.D1 || cki.Key == ConsoleKey.NumPad1)
            {
                Console.WriteLine("Choose participant");
                
                Console.WriteLine("1. Tove");
                Console.WriteLine("2. Oskar");
                Console.WriteLine("3. Elias");
                Console.WriteLine("4. Viktor");
                Console.WriteLine("5. Johan");
                Console.WriteLine("6. Christopher");
                Console.WriteLine("7. Robert");
                Console.WriteLine("8. Fisnik");
            }

        }


        //Magic stuff
        public static void PopulateList()
        {
            Participant tove = new Participant { FirstName = "Tove", LastName = "Seger", Status = "gift", BirthMonth = "december", Age = 28, Hobby = "löpning", TypeOfHabitation = "villa", FavoriteCandy = "saltlakrits", Education = "biomedicin", FavoriteSeason = "sommar", FavoriteFood = "vegetarisk", FavoriteAnimal = "hund" };
            participants.Add(tove);

            Participant oskar = new Participant { FirstName = "Oskar", LastName = "Kling", Status = "sambo", BirthMonth = "november", Age = 30, Hobby = "datorspel", TypeOfHabitation = "lägenhet", FavoriteCandy = "kexchocklad", Education = "Software engineer", FavoriteSeason = "höst", FavoriteFood = "kött", FavoriteAnimal = "hund" };
            participants.Add(oskar);


            Participant elias = new Participant { FirstName = "Elias", LastName = "Hjelm", Status = "sambo", BirthMonth = "augusti", Age = 22, Hobby = "datorspel", TypeOfHabitation = "lägenhet", FavoriteCandy = "chocklad", Education = "Interaktionsdesigner", FavoriteSeason = "sommar", FavoriteFood = "veganskt", FavoriteAnimal = "hund" };
            participants.Add(elias);

            Participant viktor = new Participant { FirstName = "Viktor", LastName = "Salmberg", Status = "singel", BirthMonth = "januari", Age = 30, Hobby = "datorspel", TypeOfHabitation = "lägenhet", FavoriteCandy = "chocklad", Education = "arabiska", FavoriteSeason = "höst", FavoriteFood = "vegetarisk", FavoriteAnimal = "katt" };
            participants.Add(viktor);

            Participant johan = new Participant { FirstName = "Johan", LastName = "Rohdin", Status = "sambo", BirthMonth = "mars", Age = 27, Hobby = "poker/fotboll", TypeOfHabitation = "lägenhet", FavoriteCandy = "blandgodis", Education = "Nätverksdrift", FavoriteSeason = "vinter", FavoriteFood = "pasta", FavoriteAnimal = "hund" };
            participants.Add(johan);

            Participant christopher = new Participant { FirstName = "Christopher", LastName = "Brizet", Status = "sambo", BirthMonth = "september", Age = 35, Hobby = "guitar/spel/läsa", TypeOfHabitation = "villa", FavoriteCandy = "sötlakris", Education = "installationselektriker", FavoriteSeason = "höst", FavoriteFood = "stinky french cheeses", FavoriteAnimal = "korp" };
            participants.Add(christopher);

            Participant robert = new Participant { FirstName = "Robert", LastName = "Bunjaku", Status = "gift", BirthMonth = "november", Age = 35, Hobby = "fiska", TypeOfHabitation = "lägenhet", FavoriteCandy = "mjölkchoklad", Education = "IT-säkerhet", FavoriteSeason = "sommar", FavoriteFood = "Pasta", FavoriteAnimal = "hund" };
            participants.Add(robert);

            Participant fisnik = new Participant { FirstName = "Fisnik", LastName = "Balija", Status = "flickvän", BirthMonth = "februari", Age = 32, Hobby = "fotboll", TypeOfHabitation = "villa", FavoriteCandy = "choklad", Education = "geologi", FavoriteSeason = "sommar", FavoriteFood = "kött", FavoriteAnimal = "hund" };
            participants.Add(fisnik);
        }
    }
}
