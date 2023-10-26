using Training_4;

Shape[] shapes = new Shape[3];

shapes[0] = new Rectangle(12,15);
shapes[1] = new Square(4,5);
//shape[2] = new Shape(14, 3); // Compiler will Cry out because we convert the class to an abstract class
shapes[2] = new Square(14,3);


foreach(Shape shape in shapes) { 
    Console.WriteLine($"Area : {shape.CalculateArea()}");
}