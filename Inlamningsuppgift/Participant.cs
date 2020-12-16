using System;
using System.Collections.Generic;
using System.Text;

namespace Inlamningsuppgift
{
    class Participant
    {
        private string firstName;
        private string lastName;
        private string status;
        private string birthMonth;
        private int age;
        private string hobby;
        private string typeOfHabitation;
        private string favoriteCandy;
        private string favoriteAnimal;
        private string favoriteSeason;
        private string education;
        private string favoriteFood;

        public Participant()
        {

        }

        public Participant(string firstName, string lastName, string status, string birthMonth, int age, string hobby, string typeOfHabitation, string favoriteCandy, string education, string favoriteSeason, string favoriteFood, string favoriteAnimal)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.status = status;
            this.birthMonth = birthMonth;
            this.age = age;
            this.hobby = hobby;
            this.typeOfHabitation = typeOfHabitation;
            this.favoriteCandy = favoriteCandy;
            this.favoriteAnimal = favoriteAnimal;
            this.favoriteSeason = favoriteSeason;
            this.education = education;
            this.favoriteFood = favoriteFood;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Status { get => status; set => status = value; }
        public string BirthMonth { get => birthMonth; set => birthMonth = value; }
        public string TypeOfHabitation { get => typeOfHabitation; set => typeOfHabitation = value; }
        public int Age { get => age; set => age = value; }
        public string Hobby { get => hobby; set => hobby = value; }
        public string FavoriteCandy { get => favoriteCandy; set => favoriteCandy = value; }
        public string Education { get => education; set => education = value; }
        public string FavoriteSeason { get => favoriteSeason; set => favoriteSeason = value; }
        public string FavoriteFood { get => favoriteFood; set => favoriteFood = value; }
        public string FavoriteAnimal { get => favoriteAnimal; set => favoriteAnimal = value; }

        
    }
}
