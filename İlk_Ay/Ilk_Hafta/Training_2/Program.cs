using System.Diagnostics;
using Training_2;

Process.Start(new ProcessStartInfo("cmd", $"/c color 0A"));

//int[] studentNum = { 100, 200, 300, 400 };
//string[] name = { "Eren", "Efe", "Sinan", "Barış" };
//string[] branch = { "10A", "10B", "11B" };

//Console.WriteLine($" no: {studentNum[0]} ad: {name[0]} şube:  {branch[0]}");
//Console.WriteLine($" no: {studentNum[1]} ad: {name[1]} şube:  {branch[1]}");
//Console.WriteLine($" no: {studentNum[2]} ad: {name[2]} şube:  {branch[2]}");
//Console.WriteLine($" no: {studentNum[3]} ad: {name[3]} şube:  {branch[0]}");

//Book book1 = new Book("ayooo");

//book1.title = "Tel Ali";
//book1.author = "Nurrettin Topalak";
//book1.pages = 30;

//Console.WriteLine(book1.author);
//Console.WriteLine(book1.title);
//Console.WriteLine(book1.pages);


//Movie movie = new Movie("Lord of The Rings", 3);
//Console.WriteLine(movie.Rating);

//Song holiday = new Song("Holiday", "Green asd", 200);
//Song kashmir = new Song("Kashmir", "Leah Jhonsan", 150);

Console.WriteLine(Song.CountInstances);