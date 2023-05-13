// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine ("Введите первое число");
int number=int.Parse(Console.ReadLine());
Console.WriteLine ("Введите второе число");
int number2=int.Parse(Console.ReadLine());
Console.WriteLine ("Введите третье число");
int number3=int.Parse(Console.ReadLine());
int max = number;
if (number2>number && number2>number3)
{
   max = number2;
   Console.WriteLine( "Большее число = " + number2);
}
else if (number3>number2 && number3>number)
{
    max = number3;
    Console.WriteLine( "Большее число = " + number3);
}
else if (max == number)
{ 
 Console.WriteLine("Большее число = " + number);
}
