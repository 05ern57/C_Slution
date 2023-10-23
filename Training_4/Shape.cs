using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Training_4
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Shape(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        //before the class being converted to an abstract class

        //public virtual void Draw()
        //{
        //    Console.WriteLine("Draw a shape");
        //}

        // we can also create a normal methods to 
        public int CalculateArea()
        {
            return this.Width * this.Height ;
        }

        protected abstract void Draw(); // in here we defined a abstract method it is a sign of the method we only define accesibility (it can't be private) 
        protected abstract void Dememe(int a);
    }

    class Square : Shape
    {
        public Square(int width, int height) : base(width, height) { }

        // after converting main class we orginized the code at the under lines
        //public override void Draw()
        //{
        //    base.Draw();
        //    Console.WriteLine("Draw A Square!!!");
        //}

        // abstract methods must be overrided when we add ad abstract before method itself it acts like virtual think like that
        protected override void Draw()
        {
            Console.WriteLine("Draw A Square!!!");
        }
        
        protected override void Dememe(int a)
        {
            Console.WriteLine(a);
        }
    }

    class Rectangle : Shape
    {
        public Rectangle (int width, int height)  : base(width , height) { }

        //public override void Draw()
        //{
        //    base.Draw();
        //    Console.WriteLine("Draw A Rectangle!!!");
        //}

        //protected void Draw()
        //{           
        //    Console.WriteLine("Draw A Rectangle!!!");
        //}

        protected override void Draw()
        {
            Console.WriteLine("Draw A Rectangle!!!");
            //throw new NotImplementedException();
        }
    }
}


// we can't create instances of abstract class. contrary to (bunun aksine) inteface we can write normal methods in it.However  we have to override all abstract methods like in the interfaces
// when we are defining an abstract method. we should use the same acces modifier with overrided abstract method. and we must use override keyword when we override the abstract method
