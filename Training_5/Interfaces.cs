using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Training_5
{

    interface IPrey
    {
        //public IPrey()
        //{

        //}
        // Interfaces can not containg constructor 
        void Flee();
        // we didn't add any access modifiers because in an interface everything is public by default.
    }

    interface IPredator
    {
        void Hunt();
    }

    class Rabbit : IPrey
    {
        // again in here we can not change the access modifier it must be public 
        public void Flee()
        {
            Console.WriteLine("Rabbit is trying to flee");


        }
    }

    class Hawk : IPredator
    {
        public void Hunt()
        {
            Console.WriteLine("Hawk is searching for prey");
        }
    }

    class Fish : IPredator, IPrey
    {
        public void Flee()
        {
            Console.WriteLine("Fish is searching for smaller fishes");
        }

        public void Hunt()
        {
            Console.WriteLine("Fish is trying to flee");
        }
    }


    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Generic Animal Sound!!!");
        }
    }


    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Barrrkkkkk");
        }
    }

    public class Cat : Animal
    {
        public override void MakeSound()
        {
            base.MakeSound(); // by using base keyword we can inherit all the code that we write in the base class
            Console.WriteLine("Meowwwwww");
        }
    }
}

   
