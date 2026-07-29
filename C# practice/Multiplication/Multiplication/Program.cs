Console.WriteLine("please enter a number");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("======Multiplication Table========");

for (int i = 10; i>=1;i--)
{
    Console.WriteLine($"{number} x {i} = {number * i}");
}
