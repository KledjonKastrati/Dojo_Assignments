// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.Diagnostics.CodeAnalysis;

int sum =0;

for (int i = 0; i < 250; i++)
{
    System.Console.WriteLine(i);
}
Random rnd= new Random ();
for (int i = 0; i < 5; i++)
{ 
    sum = sum + (rnd.Next(10,20));
}
System.Console.WriteLine(sum);

for (int i = 0; i < 101; i++)
{
    if(i % 3 ==0 && i % 5 ==0)
    {
        ;
    }
    else if (i % 3 ==0) {
        System.Console.WriteLine(i);
    }else if(i % 5 ==0){
        System.Console.WriteLine(i);
    }
}

for (int i = 0; i < 101; i++)
{
    if (i % 3 ==0)
    {
        System.Console.WriteLine("FIZZ");
    }
    else if (i % 5 == 0 )
    {
        System.Console.WriteLine("Buzz");
    }
}

for (int i = 0; i < 101; i++)
{
    if (i % 3 ==0 && i % 5 ==0)
    {
        System.Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 ==0)
    {
        System.Console.WriteLine("FIZZ");
    }
    else if (i % 5 == 0 )
    {
        System.Console.WriteLine("Buzz");
    }
}
