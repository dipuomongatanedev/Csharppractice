string realpassword = "Csharp123";

Console.WriteLine("please enter the password");
 string password =Console.ReadLine();

while (password != realpassword)
{
    Console.WriteLine("incorrect password. Try again");
    password = Console.ReadLine();
}

Console.WriteLine("Access granted!! welcome to the system");