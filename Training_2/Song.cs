using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_2
{
    internal class Song
    {
        public string title;
        public string singer;
        public int duration;
        public static int countInstances = 0;

        public Song(string title, string singer, int duration)
        {
            this.title = title;
            this.singer = singer;
            this.duration = duration;
            ++countInstances;

        }

        //Properties for normal variables
        public string Title { 
            get { return this.title; } 
            set { this.title = value; }
        }

        public string Singer
        {
            get { return this.singer; }
            set { this.singer = value; }
        }

        public int Duration { 
            get { return this.duration; }
            set { this.duration = value; }
        }

        //Property for static variables
        public static int CountInstances
        {
            get { return countInstances; }
            private set { countInstances = value; }
        }

    }
}
