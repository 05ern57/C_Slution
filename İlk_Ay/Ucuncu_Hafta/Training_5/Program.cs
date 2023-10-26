using System.Reflection.Metadata;
using Training_5;

IPrey rabbit = new Rabbit();
IPredator hawk = new Hawk();
IPredator fish = new Fish(); // if you try to call Flee() method you will see it won't work because of the Polimorphism, it is basically means if you create an instance of fish of Ipredator type
                             // Fish object acts like a predator but if the type of instance would be Iprey it would act like a prey.

fish.Hunt();
// fish.Flee(); as we can see it doesn't work 


// question: if a function takes base class as a parameter but instead if we pass inherited class as an argument does function still work?
// question: what if ı do the opposite of it
Dog dog = new Dog();
Cat cat = new Cat();
Animal dogA = new Dog();
Animal catA = new Cat();

// we passed the subclass as a parameter and it worked.
TestClasses.TestBaseClass(dog);
TestClasses.TestBaseClass(cat);
TestClasses.TestBaseClass(dogA);
TestClasses.TestBaseClass(catA);


Console.WriteLine("#############################");

// we passed baseclass and it throwed error
//TestClasses.TestSubClass(dogA);
//TestClasses.TestSubClass(catA);



// When ı try to create functions we dont use access modifiers because ı guess
// it is accepted as global method 
//internal void MakeAnimalVoice()
//{

//}