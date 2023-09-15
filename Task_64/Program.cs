// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int j = InputNumbers("Введите значение N: ");
int count = 2;
PrintNumbers(j, count);
Console.Write(1);

void PrintNumbers(int n, int count)
{
    if (count > j) return;
    PrintNumbers(j, count + 1);
    Console.Write(count + " , ");
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}