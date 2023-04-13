int num1 = new Random().Next(1, 10);
Console.WriteLine("first number = " + num1);

int num2 = new Random().Next(1, 10);
Console.WriteLine("second number = " + num2);

int num3 = new Random().Next(1, 10);
Console.WriteLine("third number = " + num3);


if(num1 >= num2 && num1 >= num3) 

Console.WriteLine("max number = " + num1);

else if(num2 >= num1 && num2 >= num3) 

Console.WriteLine("max number = " + num2);

else if(num3 >= num1 && num3 >= num2) 

Console.WriteLine("max number = " + num3);
  