using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_5
{
    internal class MyClasses
    {
    }
    public class TestClasses
    {
        public static void TestBaseClass(Animal animal)
        {
            animal.MakeSound();
        }

        public static void TestSubClass(Dog dog)
        {
            dog.MakeSound();
        }
    }
}
