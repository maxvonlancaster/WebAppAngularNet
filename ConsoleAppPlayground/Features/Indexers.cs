using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppPlayground.Features
{
    public class Indexers
    {
        public void IndexersUsage() 
        {
            Days days = new Days();
            Console.WriteLine(days[2]);
            Console.WriteLine(days[6]);
            //days[3] = "Wensday"; -- cannot be assigned - readonly

            Year year = new Year();
            Console.WriteLine(year[40][0]);
            year[30] = days;
        }


    }

    public class Days 
    {
        private string[] daysArray = new string[]
        {
            "Monday",
            "Tuesday",
            "W",
            "T",
            "F",
            "S",
            "Sunday"
        };

        public string this[int i] 
        {
            get 
            {
                return daysArray[i];
            }
        }

        public string this[string s] 
        {
            set 
            {
            
            }
        }
    }

    public class Year 
    {
        private Days[] weeksArray = new Days[52];

        public Year()
        {
            for (int i = 0; i < 53; i++) 
            {
                weeksArray[i] = new Days();
            }
        }

        public Days this[int i] 
        {
            get 
            {
                return weeksArray[i];
            }
            set 
            {
                weeksArray[i] = value;
            }
        }
    }
}
