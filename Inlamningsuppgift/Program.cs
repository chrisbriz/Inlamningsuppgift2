using System;
using Inlamningsuppgift.LogicLayer;
using System.Collections.Generic;
using System.Linq;

namespace Inlamningsuppgift
{
    class Program
    {


        static void Main(string[] args)
        {
            Logic logic = new Logic();
            //populate List of participants
            logic.PopulateList();

            logic.Start();
        }
    }




}
