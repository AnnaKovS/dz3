// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число N: ");

int num1 = Convert.ToInt32(Console.ReadLine());
for(int i=1; i<=num1; i++)
{
    Console.Write($"Начальное число: {i} ");
    Console.WriteLine($"Возведение числа в куб: {Math.Pow(i,3)} ");
}
