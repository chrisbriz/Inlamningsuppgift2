using System;
using System.Collections.Generic;
using System.Text;

namespace Inlamningsuppgift
{
    class Participant
    {
        public Participant(string status, string birthMonth, int age, string hobby, string typeOfHabitation, string favoriteCandy, string education, string favoriteSeason, string favoriteFood, string favoriteAnimal)
        {
            Status = status;
            BirthMonth = birthMonth;
            Age = age;
            Hobby = hobby;
            TypeOfHabitation = typeOfHabitation;
            FavoriteCandy = favoriteCandy;
            FavoriteAnimal = favoriteAnimal;
            FavoriteSeason = favoriteSeason;
            Education = education;
            FavoriteFood = favoriteFood;
        }

        public string Status { get; set; }
        public string BirthMonth { get; set; }
        public string TypeOfHabitation { get; set; }
        public int Age { get; set; }
        public string Hobby { get; set; }
        public string FavoriteCandy { get; set; }
        public string Education { get; set; }
        public string FavoriteSeason { get; set; }
        public string FavoriteFood { get; set; }
        public string FavoriteAnimal { get; set; }

    }
}
