// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

/*
int NumberInDegree(int number, int degree)
{
    {
        int result = number;
        for (int i = 1; i < degree; i++)
        {
            result = result * number;
        }
        return result;
    }
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа: ");
int degree = Convert.ToInt32(Console.ReadLine());

if (degree == 0)
    Console.WriteLine("Любое число в нулевой степени равно единице");
else if (number == 0)
    Console.WriteLine("Ноль в любой натуральной степени равен нулю");
else if (number == 1)
    Console.WriteLine("Единица в любой натуральной степени равна единице");
else
{
    int result = NumberInDegree(number, degree);
    Console.WriteLine($"Число {number} в степени {degree} равно {result}");
}
*/



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

/*
int Counting(int number)
{
    if (number < 0)
    {
        number = number * (-1);
    }
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = Counting(number);
System.Console.WriteLine($"Сумма цифр числа {number} равна {sum}");
*/



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Рандом для любого количества элементов

/*
int[] FillArray(int size)
{
int[] arr = new int[size];
for(int i = 0; i < arr.Length; i++)
{
arr[i] = new Random().Next(1, 100);
}
return arr;
}

System.Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(size);
System.Console.WriteLine($"[{string.Join(", ", array)}]");
*/


// Ввод с клавиатуры
/*
int[] FillArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
        {
            System.Console.Write("Введите элемент массива: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
    return arr;
}

System.Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(size);
System.Console.WriteLine($"[{string.Join(", ", array)}]");
*/