int num1 = new Random().Next(1, 10);
Console.WriteLine("first number = " + num1);

int num2 = new Random().Next(1, 10);
Console.WriteLine("second number = " + num2);

if(num1 > num2)
{
    Console.WriteLine("max number = " + num1);
    Console.WriteLine("min number = " + num2);
}
else 
{
    Console.WriteLine("max number = " + num2);
    Console.WriteLine("min number = " + num1);
}
