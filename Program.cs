using calculator;

Console.WriteLine("First Number:");
int value1 = int.Parse(Console.ReadLine());
Console.WriteLine("Second Number:");
int value2 = int.Parse(Console.ReadLine());

Calc calc = new Calc();


calc.addVals(value1, value2);

Console.ReadLine();