// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int SumNaturalNumbers(int from, int to)
{
    int sum=from;
    if(from < to)
    {
    sum += SumNaturalNumbers(from + 1, to);
    }
    else if(from > to)
    {
        sum += SumNaturalNumbers(from - 1, to);
    }
    return sum;

}

Console.WriteLine("Введите диапазон натуральных чисел");
Console.Write("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

int summa= SumNaturalNumbers(numberOne, numberTwo);
Console.WriteLine($"Сумма натуральных элементов: {summa}");