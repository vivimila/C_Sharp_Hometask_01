Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
if (b > a) 
{
    Console.Write($"число {b} большее,а число {a} меньшее");
}
else
{
    Console.Write($"число {b} меньшее,а число {a} большее");
}