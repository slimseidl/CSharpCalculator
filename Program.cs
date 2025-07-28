using calculator;

Calc calc = new Calc();

Console.WriteLine("Please choose an operator (+, -, *, /, mean): ");
string operation = Console.ReadLine();

Console.WriteLine("Enter first number:");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter first number:");
int num2 = int.Parse(Console.ReadLine());



switch (operation)
{
    case "+":
        Console.WriteLine($"Sum of numbers: {calc.addNums(num1,num2)}");
        break;
    case "-":
        Console.WriteLine($"Difference of numbers: {calc.subtractNums(num1, num2)}");
        break;
    case "*":
        Console.WriteLine($"Product of numbers: {calc.multiplyNums(num1, num2)}");
        break;
    case "/":
        Console.WriteLine($"Quotient of numbers: {calc.divideNums(num1,num2)}");
        break;
    case "mean":
        Console.WriteLine($"Mean of numbers: {calc.avgNums(num1,num2)}");
        break;
}


Console.ReadLine();