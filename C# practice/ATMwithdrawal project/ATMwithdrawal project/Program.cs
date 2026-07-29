double balance = 500.00;

Console.WriteLine("How much do you need?");
double amount = Convert.ToDouble(Console.ReadLine());

while (amount>balance )
{
    Console.WriteLine("invalid amount,how much do you need");
     amount = Convert.ToDouble(Console.ReadLine());




}
double finalAmount = balance - amount;
Console.WriteLine($"withdrawal success!!!!, remaining balance is {finalAmount}");
