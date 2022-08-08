// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/statements/iteration-statements
// Инструкция for
// Оператор for выполняет оператор или блок операторов, пока определенное логическое выражение равно значению true. 
// В следующем примере показана инструкция for, выполняющая тело пока целочисленный счетчик меньше трех:

Console.WriteLine("Начало диапазона:1");
Console.WriteLine("Введите конец диапазона: ");
int num = Convert.ToInt32(Console.ReadLine());
for (int i=1; i<=num; i++)
    if (i % 2 == 0)
{
    Console.Write($"{i}  ");
}


