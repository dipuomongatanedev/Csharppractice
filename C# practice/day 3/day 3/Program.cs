// See https://aka.ms/new-console-template for more information
Console.WriteLine("please enter your age");
int age = Convert.ToInt32(Console.ReadLine());

if (age >=18)
{
Console.WriteLine("you are eligebale to vote");
}
else
{
Console.WriteLine("you are not allowed to vote");
}

// excercise 2

Console.WriteLine("please enter student's marks");
int marks = Convert.ToInt32(Console.ReadLine());

if (marks >= 75)
{
Console.WriteLine("Distinction");
}
else if (marks >=50)
{
Console.WriteLine("passed");
}
else
{
Console.WriteLine("fail");
}


// excercise 3

Console.WriteLine("please enter password");
string password=Console.ReadLine();

if (password == "Csharp123")
{
    Console.WriteLine("access granted");
}
else
{
    Console.WriteLine("access denied");
}