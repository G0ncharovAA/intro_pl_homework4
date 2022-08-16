/*
* Урок 4. Функции продолжение
* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит
* число A в натуральную степень B.
*
* 3, 5 -> 243 (3⁵)
* 2, 4 -> 16
*
* Решение:
*/

long power(long baseNum, long exponent)
{
    if (exponent < 2)
    {
        return baseNum;
    }
    else
    {
        return baseNum * power(baseNum, exponent - 1);
    }
}

Console.WriteLine("Введите число A");
long numA = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("Введите число B");
long numB = Convert.ToInt64(Console.ReadLine());

if (numB < 1)
{
    Console.WriteLine("Некорректное значение");
}
else
{
    Console.WriteLine("число A в степени числа B: " + power(numA, numB));
}

/*
* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
*
* 452 -> 11
* 82 -> 10
* 9012 -> 12
*
* Решение:
*/

long cutFromRight(long num)
{
    return num / 10;
}

long getRightDigit(long num)
{
    return num % 10;
}

Console.WriteLine("Введите число");
long num = Math.Abs(Convert.ToInt64(Console.ReadLine()));

long summ = 0;

while (num >= 10) {
    summ += getRightDigit(num);
    num = cutFromRight(num);
}

summ += num;

Console.WriteLine("Сумма цифр в числе: " + summ);

/*
* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
*
* 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
* 6, 1, 33 -> [6, 1, 33]
*
* Решение:
*/

/*
*  Из условий не очевидно какого типа должны быть элементы массива,
*  но в примере показаны целочисленные элементы.
*/

void setValue(int[] arr, int index)
{
    Console.WriteLine("Введите значение элемента массива под индексом " + index);
    arr[index] = Convert.ToInt32(Console.ReadLine());
}

int[] arr = new int[8];
for (int index = 0; index < arr.Length; index++) {
    setValue(arr, index);
}
string output = $"[{arr[0]}";
for (int index = 1; index < arr.Length - 1; index++) {
    output += $", {arr[index]}";
}
output += $", {arr[7]}]";

Console.WriteLine("Массив: " + output);