// See https://aka.ms/new-console-template for more information

Console.WriteLine("please enter your name ");
string name=Console.ReadLine();

Console.WriteLine("please enter your age");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("please enter final school marks");
int FinalMark=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("==========================");
Console.WriteLine("UNIVERSITY ADMISSION");
Console.WriteLine("==========================");

if (age >=18)
{
    Console.WriteLine("Age requirement: Passed");
}
else
{
    Console.WriteLine("Age requirement: Failed");
}

if (FinalMark >=75)
{
    Console.WriteLine("Academic result: Excellent candidate");
}
else if (FinalMark >= 50)
{
    Console.WriteLine("Academic result: Eligible");
}
else
{
    Console.WriteLine("Academic result: not eligibe");

}

