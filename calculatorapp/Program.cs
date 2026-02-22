namespace calculatorapp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Calculator App!");
        Console.Write("Please enter the first number: ");
        double num1= Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("------------------------------");
        
        Console.Write("Please choice +, -, *, or /: ");
        char op=Console.ReadKey().KeyChar;
        Console.WriteLine("");
        Console.WriteLine("------------------------------");
        
        Console.Write("Please enter the second number: ");
        double num2=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("------------------------------");                    

        double result = 0;
        bool validOperation = true;

        switch (op)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result=num1*num2;
                break;
            case'/' :
                if(num2!=0)
                    result = num1 / num2;
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    validOperation = false;
                }
                break;
            default:
                Console.WriteLine("Error: Invalid operator.");
                validOperation = false;
                break;
        }

        if (validOperation)
        {
            Console.WriteLine($" Result: {num1} {op} {num2} = {result}");
        }

        Console.WriteLine("Thank you for using the Calculator App!");
        Console.WriteLine("-----------------------------");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();

    }
}