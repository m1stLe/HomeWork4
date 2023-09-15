//  Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int i = InputNumbers("Введите значение M: ");
int j = InputNumbers("Введите значение N: ");
int temp = i;

if (i > j)
{
    i = j;
    j = temp;
}

PrintSumm(i, j, temp = 0);

void PrintSumm(int i, int j, int summ)
{
    summ = summ + j;
    if (j <= i)
    {
        Console.Write($"Сумма натуральных элементов = {summ} ");
        return;
    }
    PrintSumm(i, j - 1, summ);
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}