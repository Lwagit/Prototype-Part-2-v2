// See https://aka.ms/new-console-template for more information
using System.Runtime.ExceptionServices;

int game = 1;

double numberDouble = 6.9;
int numberInt = (int) numberDouble;

/*
String number = Convert.ToString(game);
Console.WriteLine(number.GetType());
*/

Console.WriteLine(numberDouble);
Console.WriteLine(numberInt);


//for a number of i i want it to print 10 times 
//for priting a traingle 
for (int i = 0; i <= 10; i++)
{
    /*
    for(int a= 2 *(10 -i); a>=0; a--)
    {
        Console.WriteLine(" ");
    }*/

    for(int j = 0; j <= i; j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine("\n");
}

Console.ReadKey();