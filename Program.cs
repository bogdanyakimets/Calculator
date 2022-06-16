decimal num1 = 0;
decimal num2 = 0;
char symbol;


while (true)
{
    Console.WriteLine("Possible actions: +, -, *, /.");
    Console.WriteLine("Write number:");
    num1 = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Write actions:");
    symbol = char.Parse(Console.ReadLine());

    Console.WriteLine("Write number");
    num2 = decimal.Parse(Console.ReadLine());

    Console.WriteLine();

    Console.Write("Result: ");

    switch (symbol)
    {
        case '+':
            Console.WriteLine(num1 + num2);
            break;
        case '-':
            Console.WriteLine(num1 - num2);
            break;
        case '/':
            Console.WriteLine(num1 / num2);
            
            break;
        case '*': 
            Console.WriteLine(num1 * num2);
            break;
        default: Console.WriteLine("Wrong format");
            break;         
    }
    
    Thread.Sleep(2500);
    Console.Clear();
}