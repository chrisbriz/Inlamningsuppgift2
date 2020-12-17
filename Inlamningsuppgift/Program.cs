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
                        ParticipantDetails();
                        break;
                }
            } while (open == false);
        }

        //Display all participants
        private static void ParticipantsList()
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


        public static void ParticipantDetails()
        {
            Console.WriteLine("Choose participant");

            for (int i = 0; i < participants.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {participants[i].FirstName}");
            }

            int namePos = Convert.ToInt32(Console.ReadLine());

            Participant participant = participants[namePos - 1];

            DisplayDetails(participant);
        }

        private static void DisplayDetails(Participant participant)
        {
            Console.WriteLine(participant.ParticipantDetails(participant));

            Console.ReadLine();
        }


        //Magic stuff
        public static void PopulateList()
        {
            Participant tove = new Participant { FirstName = "Tove", LastName = "Seger", Status = "gift", BirthMonth = "december", Age = 28, Hobby = "löpning", TypeOfHabitation = "villa", FavoriteCandy = "saltlakrits", Education = "biomedicin", FavoriteSeason = "sommar", FavoriteFood = "vegetarisk", FavoriteAnimal = "hund", UniqueString = "viljan att skapa en kreativ och intellektuell tillvaro, oberoende av fasta klockslag." };
            participants.Add(tove);

            Participant oskar = new Participant { FirstName = "Oskar", LastName = "Kling", Status = "sambo", BirthMonth = "november", Age = 30, Hobby = "datorspel", TypeOfHabitation = "lägenhet", FavoriteCandy = "kexchocklad", Education = "Software engineer", FavoriteSeason = "höst", FavoriteFood = "kött", FavoriteAnimal = "hund", UniqueString = "Kreativt, roligt, kontroll och problemlösning." };
            participants.Add(oskar);


            Participant elias = new Participant { FirstName = "Elias", LastName = "Hjelm", Status = "sambo", BirthMonth = "augusti", Age = 22, Hobby = "datorspel", TypeOfHabitation = "lägenhet", FavoriteCandy = "chocklad", Education = "Interaktionsdesigner", FavoriteSeason = "sommar", FavoriteFood = "veganskt", FavoriteAnimal = "hund", UniqueString = "Att få arbeta med något som är kreativt och som jag alltid kan utvecklas inom." };
            participants.Add(elias);

            Participant viktor = new Participant { FirstName = "Viktor", LastName = "Salmberg", Status = "singel", BirthMonth = "januari", Age = 30, Hobby = "datorspel", TypeOfHabitation = "lägenhet", FavoriteCandy = "chocklad", Education = "arabiska", FavoriteSeason = "höst", FavoriteFood = "vegetarisk", FavoriteAnimal = "katt", UniqueString = "Kicken att förstå nya koncept och möjligheten till ett utvecklande arbetsliv." };
            participants.Add(viktor);

            Participant johan = new Participant { FirstName = "Johan", LastName = "Rohdin", Status = "sambo", BirthMonth = "mars", Age = 27, Hobby = "poker/fotboll", TypeOfHabitation = "lägenhet", FavoriteCandy = "blandgodis", Education = "Nätverksdrift", FavoriteSeason = "vinter", FavoriteFood = "pasta", FavoriteAnimal = "hund", UniqueString = "Egna arbetstider, roligt och intressant." };
            participants.Add(johan);

            Participant christopher = new Participant { FirstName = "Christopher", LastName = "Brizet", Status = "sambo", BirthMonth = "september", Age = 35, Hobby = "guitar/spel/läsa", TypeOfHabitation = "villa", FavoriteCandy = "sötlakris", Education = "installationselektriker", FavoriteSeason = "höst", FavoriteFood = "stinky french cheeses", FavoriteAnimal = "korp", UniqueString = "Planera, skapa och ett enormt svängrum för kreativitet (plus fantasin om att erövra världen)" };
            participants.Add(christopher);

            Participant robert = new Participant { FirstName = "Robert", LastName = "Bunjaku", Status = "gift", BirthMonth = "november", Age = 35, Hobby = "fiska", TypeOfHabitation = "lägenhet", FavoriteCandy = "mjölkchoklad", Education = "IT-säkerhet", FavoriteSeason = "sommar", FavoriteFood = "Pasta", FavoriteAnimal = "hund", UniqueString = "Kombinera tidigare utbildning med nya kunskaper för att släppa lös den kreativa kraften och styra/forma egna framtiden." };
            participants.Add(robert);

            Participant fisnik = new Participant { FirstName = "Fisnik", LastName = "Balija", Status = "flickvän", BirthMonth = "februari", Age = 32, Hobby = "fotboll", TypeOfHabitation = "villa", FavoriteCandy = "choklad", Education = "geologi", FavoriteSeason = "sommar", FavoriteFood = "kött", FavoriteAnimal = "hund", UniqueString = "Fascineras av hur något så enkelt men samtidigt komplicerat kan skapa något kraftfullt och användbart. Vidare så är programmering oerhört utmanande, spännande och framförallt roligt!" };
            participants.Add(fisnik);
        }
    }
}
