namespace calculatorapp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Calculator App!");
        Console.Write("Please enter the first number: ");
        double num1= Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Please choice +, -, *, or /: ");
        char op=Console.ReadKey().KeyChar;
        Console.WriteLine();
        
        Console.Write("Please enter the second number: ");
        double num2=Convert.ToDouble(Console.ReadLine());

        double result = 0;
        bool validOperation = true;


    }
}