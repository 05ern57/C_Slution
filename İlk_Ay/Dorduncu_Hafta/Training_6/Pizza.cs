using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Training_6
{
    public class Pizza
    {
        string doughType;
        string souceDosage;
        string isCrustFilledCheese;

        public Pizza(string doughType = "slim", string souceDosage = "normal", string isCrustFilledCheese = "not")
        {
            this.doughType = doughType;
            this.souceDosage = souceDosage;
            this.isCrustFilledCheese = isCrustFilledCheese; 
        }


    }
}
