// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;
using System.Transactions;

//Console.WriteLine("please enter the first number");

//int num1 =Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("please enter the second number");
//int num2=Convert.ToInt32(Console.ReadLine());

//int sum = num1 + num2;
//Console.WriteLine(" sum: " + sum);

//int difference = num1 - num2;
//Console.WriteLine("difference:" + difference );

//int product = num1 * num2;
//Console.WriteLine("product: " + product);

//int quotient = num1 / num2;
//Console.WriteLine(" quotient: " + quotient);

//int module = num1 % num2;
//Console.WriteLine(" module: "  + module);


//excercise 2

Console.WriteLine("please enter the price for item 1");
double price1=Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please enter the price for item 2");
double price2=Convert.ToDouble(Console.ReadLine());

Console.WriteLine("please enter the price for item 3");
double price3=Convert.ToDouble(Console.ReadLine());

double totalprice = price1 + price2 + price3;

Console.WriteLine("=======SHOPPING CALCULATOR=======");

Console.WriteLine(" the total price is " + totalprice);

Console.WriteLine("=======THANK YOU!=======");