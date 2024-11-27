using System;

interface IOperations
{
    int Add(int a, int b);
    int Subtract(int a, int b);
}
//dar inja ye calc tarif shode ke method haye jam va tafrighe 2 adadi ro anjam mide
class Calculator : IOperations
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        Console.WriteLine("Add: " + calc.Add( 25 , 60 ));
        Console.WriteLine("Sub: " + calc.Subtract( 100 , 15 ));
        Console.ReadKey();
    }
    
}
