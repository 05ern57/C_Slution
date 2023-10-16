
using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Drawing;
using System.Security.Cryptography;


//string[] colors = { "0A", "0B", "0C", "0D", "0E", "0F" };
Process.Start(new ProcessStartInfo("cmd", $"/c color 0A"));

//string name = "Eren";
//string surname = "Erdoğan";
//int age = 21;

//string str = string.Format("My name is {0} {1} and I'm {2} years old maaaaaan", name, surname, age);
//string str = string.Format("My name is {0} {1} and I'm {2} years old maaaaaan", surname, name, age);
//string str = $"My name is {name} {surname} and I'm ";
//Console.WriteLine(str);

//string str1 = "Hi my name is erendir lo asdas lkjşlk sksksk   ";
// ToLower();  ToUpper(); methods are same ;



//Console.WriteLine(str1.Length);
//Console.WriteLine(str1);
//Console.WriteLine(str1.Trim());
//Console.WriteLine(str1.TrimEnd());
//Console.WriteLine(str1.TrimStart());

//Console.WriteLine(str1.Trim() + str1.Trim().Length);
//Console.WriteLine(str1.TrimEnd() + str1.TrimEnd().Length);
//Console.WriteLine(str1.TrimStart() + str1.TrimStart().Length);

// we have the same Split() method we can pass argument


//char[] sepList = { ' ', 'a' };
//string[] seperateds = str1.Split(sepList,15); 

//foreach (string s in seperateds)
//{
//    Console.WriteLine(s);
//}

//Console.WriteLine(str1.ToUpper().Contains("Hi"));
//Console.WriteLine(str1.StartsWith("Hi"));
//Console.WriteLine(str1.EndsWith(" "));
//Console.WriteLine(str1.Substring(5)); // we can not use "-" in substring
//Console.WriteLine(str1.IndexOf("asdas")); // it returns the index of first a of the word that we passed 

//Console.WriteLine(str1.Replace(" ", "      ").Replace("a", "A"));
//Console.WriteLine(str1.Insert(str1.Length-1,"..."));sda
//Console.WriteLine(str1.Remove(21,2)); // first number is the point that we want to start removing second how many letters that we want to remove 

// we can define an Array in two ways 
//string[] arr1 = new string[15];
//string[] arr2 = {"meyve","hayvan","isim","sehir"};
//Console.WriteLine(string.Join(" - ",arr2));


string[] arr1 = { "el1", "el2", "el3", "el4", "el5", "el6", "el7", "el8", "el9", "el10" };
Console.WriteLine(arr1.GetValue(5));
arr1.SetValue("değiştirilmiş eleman", 5);
Console.WriteLine(arr1.GetValue(5));
string[] arrCopy = new string[10];
//arr1.CopyTo(arrCopy, 0);
arr1.CopyTo(arrCopy, 0); // arr1 array completely copied to the arrCopy and this copy proccess started from the index 0
//foreach(string s in arrCopy)
//{
//    Console.WriteLine(s);
//}

int[] num = { 1, 8, 6, 5, 88, 9, 4, 40, 5, 80654, -325,20, 24564 };
////Array.Sort(num); // Sort reorders the array in an decreasing order.
////Array.Reverse(num); // Reverse as we can understand reverse the order of array
//foreach(int i in num)
//{
//    Console.WriteLine(i);
//}

//Console.WriteLine(Array.IndexOf(num, 80654)); // IndexOf method returns the index of the element that referanced array. first we pass the array and second we passed the element of the array than method returns the index
//if there isn't an element that you entered IndexOf method will return '-1'


Array.Resize(ref arrCopy, 15); // we can resize an array with resize array but we used ref and idkw?
Console.WriteLine(arrCopy.Length);

int sonuc = Array.Find(num, numb => numb < 0); // we added the lambda expression as a second paramater we also call this anonim btw we also have FindAll();

bool sonuc2 = Array.TrueForAll(num, numb => numb > 0); // as we can also see here we can check the statement of an array with a certain condition this method checks the conditin for
                                                       // every element of an array
Console.WriteLine(Convert.ToString(sonuc2));