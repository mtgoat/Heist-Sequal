using System;
using System.Collections.Generic;
using System.Linq;

namespace heistSequal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nLet's Your Our Heist!");

            List<IRobber> myRolodex = new List<IRobber>(){
                new Hacker ()
                {
                name = "Aaron",
                skillLevel = 75,
                percentageCut = 20
                },
                new Hacker ()
                {
                name = "Andrea",
                skillLevel = 75,
                percentageCut = 25
                },
                new Muscle()
                {
                name = "Alice",
                skillLevel = 70,
                percentageCut = 20
                },
                new LockSpecialist()
                {
                 name = "Ace",
                skillLevel = 50,
                percentageCut = 20
                },
                new LockSpecialist(){
                name = "Addie",
                skillLevel = 45,
                percentageCut = 10
                }
            };
            
            //When the program starts, print out the number of current operatives in the roladex. 
            Console.WriteLine($"\nCurrently we have {myRolodex.Count} operatives in the roladex.");
            
            //Then prompt the user to enter the name of a new possible crew member. 
            Console.WriteLine("\nLet's add new person to the roladex!");

            while(true){
            Console.WriteLine("\nWhat is a name of the new person to add to the roladex?\n");
            string personName = Console.ReadLine();Console.WriteLine();
            if (personName == "")
            {
                break;
            } else {
            
            Console.WriteLine($"You typed \"{personName}\" as a name.");
            Console.WriteLine();
            //Once the user has entered a name, print out a list of possible specialties and have the user select which specialty this operative has.
            Console.WriteLine(@"Next, please select a specialist type from the following.
            Hacker (Disables alarms): enter 1
            Muscle (Disarms guards): enter 2
            Lock Specialist (cracks vault): enter 3.");

            string specialist = Console.ReadLine();

            switch (specialist)
            {
                case "1":
                Hacker newHacker = new Hacker (){
                    name = personName
                };
                add(newHacker);
                break;

                case "2":
                Muscle newMuscle = new Muscle (){
                    name = personName
                };
                add(newMuscle);
                break;

                case "3":
                LockSpecialist newLock = new LockSpecialist (){
                    name = personName
                };
                add(newLock);
                break;

                default:
                Console.WriteLine("\nplease enter a number from 1 to 3.");
                break;
            }

            //function to add a newMember to myRolodex list
            void add (IRobber newMember)
            {
            //Once the user has selected a specialty, prompt them to enter the crew member's skill level as an integer between 1 and 100. 
            //add skill ,
            Console.WriteLine("\nWhat is a the new person's skill level? please enter between 0 to 100.");

            int personSkill = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nYou typed \"{personSkill}\" as a skill level.");

            newMember.skillLevel = personSkill;
       
            //Then prompt the user to enter the percentage cut the crew member demands for each mission. 
            //add cut ,
            Console.WriteLine("\nWhat is a the new person's cut? please enter between 0 to 100.");

            int personCut = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nYou typed \"{personCut}\" as a skill level.");

            //Once the user has entered the crew member's name, specialty, skill level, and cut, you should instantiate the appropriate class for that crew member (based on their specialty) and they should be added to the rolodex.
            myRolodex.Add(newMember);

            Console.WriteLine($"\nCurrently, we have {myRolodex.Count} operatives in the roladex.");
};

            };

            };
        //Continue the above action and allow the user to enter as many crew members as they like to the rolodex until they enter a blank name before continuing. -line51 while loop
        
        Console.WriteLine("Continues");
        
        /*------------------------------------------------*/
        }
    }
}
