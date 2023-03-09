// Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3, b = 9 -> нет

Console.Write ("Введите первое целое число ");
int a = Convert.ToInt32(Console.Readline());
Console.Write ("Введите второе число: ");
int b = Convert.ToInt32(Console.Readline());
if (a == b * b)
{
    Console.WriteLine($"Квадрат числа {a} = {b}");
}
else
{
    Console.WriteLine($"Квадрат числа {a} не равняется {b}");
}




