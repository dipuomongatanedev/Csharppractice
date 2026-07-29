//logical operators project 

Console.WriteLine("please enter your name");
string name = Console.ReadLine();

Console.WriteLine("please enter your age");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("do you have a student card? (true/false)");
bool haveStudentCard = Convert.ToBoolean(Console.ReadLine());
double TicketPrice = 0;
if (age<12)
{
    TicketPrice = 50;

}
else if (haveStudentCard==true)
{
    TicketPrice = 70;
}
else
{
    TicketPrice = 100;

}

Console.WriteLine("=========CINEMA TICKET========");
Console.WriteLine("Name: " + name);
Console.WriteLine("Age: " + age);
Console.WriteLine("student card: " +  haveStudentCard);
Console.WriteLine("Ticket Price: " + TicketPrice);
    
