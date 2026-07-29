// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Please enter you full name:");
string name = Console.ReadLine();

Console.WriteLine("Please enter your age:");
int age=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter your student number:");
int StudentNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter your qualification");
string qualification = Console.ReadLine();

Console.WriteLine("Please enter your favourite programming language:");
string FavouriteProgrammingLanguage= Console.ReadLine();

Console.WriteLine("======== Student Profile=========");
Console.WriteLine(" Name: " + name);
Console.WriteLine(" Age: " + age);
Console.WriteLine(" Student Number: " + StudentNumber);
Console.WriteLine(" qualification: " + qualification);
Console.WriteLine(" favourite programming lanugauge: " + FavouriteProgrammingLanguage);

Console.WriteLine("===============================");
