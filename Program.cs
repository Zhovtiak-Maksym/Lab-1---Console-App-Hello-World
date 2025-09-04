// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine( "My name is Maksym Zhovtiak");

int i;

for (i = 0; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("Feez");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("FeezBuzz ");
    }
    else 
    {
        Console.WriteLine(i);
    }

}
