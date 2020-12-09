using System;
using System.Collections.Generic;

namespace Inlamningsuppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            //create List of participants
            List<Participant> participants = new List<Participant> {
                new Participant {FirstName = "Tove",LastName = "Seger",Status = "gift", BirthMonth = "december", Age = 28, Hobby = "löpning",TypeOfHabitation = "villa", FavoriteCandy = "saltlakrits", Education = "biomedicin", FavoriteSeason = "sommar", FavoriteFood = "vegetarisk", FavoriteAnimal = "hund" },
                new Participant {FirstName = "Oskar",LastName = "Kling",Status = "sambo", BirthMonth = "november", Age = 30, Hobby = "datorspel",TypeOfHabitation = "lägenhet", FavoriteCandy = "kexchocklad", Education = "Software engineer", FavoriteSeason = "höst", FavoriteFood = "kött", FavoriteAnimal = "hund" },
                new Participant {FirstName = "Elias",LastName = "Hjelm",Status = "sambo", BirthMonth = "augusti", Age = 22, Hobby = "datorspel",TypeOfHabitation = "lägenhet", FavoriteCandy = "chocklad", Education = "Interaktionsdesigner", FavoriteSeason = "sommar", FavoriteFood = "veganskt", FavoriteAnimal = "hund" },
                new Participant {FirstName = "Viktor",LastName = "Salmberg",Status = "singel", BirthMonth = "januari", Age = 30, Hobby = "datorspel",TypeOfHabitation = "lägenhet", FavoriteCandy = "chocklad", Education = "arabiska", FavoriteSeason = "höst", FavoriteFood = "vegetarisk", FavoriteAnimal = "katt" },
                new Participant {FirstName = "Johan",LastName = "Rohdin",Status = "sambo", BirthMonth = "mars", Age = 27, Hobby = "poker/fotboll",TypeOfHabitation = "lägenhet", FavoriteCandy = "blandgodis", Education = "Nätverksdrift", FavoriteSeason = "vinter", FavoriteFood = "pasta", FavoriteAnimal = "hund" },
                new Participant {FirstName = "Christopher",LastName = "Brizet",Status = "sambo", BirthMonth = "september", Age = 35, Hobby = "guitar/spel/läsa",TypeOfHabitation = "villa", FavoriteCandy = "sötlakris", Education = "installationselektriker", FavoriteSeason = "höst", FavoriteFood = "stinky french cheeses", FavoriteAnimal = "korp" },
                new Participant {FirstName = "Robert",LastName = "Bunjaku",Status = "gift", BirthMonth = "november", Age = 35, Hobby = "fiska",TypeOfHabitation = "lägenhet", FavoriteCandy = "mjölkchoklad", Education = "IT-säkerhet", FavoriteSeason = "sommar", FavoriteFood = "Pasta", FavoriteAnimal = "hund" },
                new Participant {FirstName = "Fisnik",LastName = "Balija",Status = "flickvän", BirthMonth = "februari", Age = 32, Hobby = "fotboll",TypeOfHabitation = "villa", FavoriteCandy = "choklad", Education = "geologi", FavoriteSeason = "sommar", FavoriteFood = "kött", FavoriteAnimal = "hund" }

            };

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






        }

        //create menu (list all participants, get 10 generic details about participants, get specific string about each participants
        public static void MainMenu()
        {
            do
            {

            } while (true);
        }
    }
}
