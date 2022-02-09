using System;
using System.Collections.Generic;

namespace heistSequal
{

    public class Hacker : IRobber
    {
        public string name { get; set ; }
        public int skillLevel { get ; set ; }
        public int percentageCut { get ; set ; }
        public string speciality { 
            get { 
                    return "Hacker";
            }
        }

        void PerformSkill (Bank bankObj)
     {   
               //skillLevel to Bank.AlarmScore
               int score = bankObj.alarmScore - skillLevel;
            Console.WriteLine($"Mr. {name} is hacking the alarm system. Decreased security {skillLevel} points.");

            if (score <=0 ){
                Console.WriteLine($"Mr {name} has disabled the alarm system!"); 
            }else {
                Console.WriteLine($"I'm sorry to inform you that we could not hack the alarm system at this time.");
            }
     }
    
    
    
    
    }
}