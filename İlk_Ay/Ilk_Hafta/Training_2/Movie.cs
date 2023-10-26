using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_2
{
    internal class Movie
    {
        // we can also use properties to store data but i guess properties are used to secure data.
        //public string Name { get; set; }

        public string name;
        private int _rate;

        public Movie(string name, int rate) { 
            this.name = name;
            this.Rating= rate;
        }

        public int Rating
        {
            get { return _rate; }

            set
            { if (value == 1 || value == 2 || value == 3 || value == 4 || value == 5)
                {
                    _rate = value;
                }else
                {
                    _rate = 1;
                }
            }

        }

    }
}
