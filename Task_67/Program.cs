// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int SumDigitNum(int num) // 453 - 45 - 4 - 0
{
    if (num == 0) return 0;
    return num % 10 + SumDigitNum(num / 10);
    // стек 453, 45, 4
    // 4%10 + 45%10 + 453%10 = 4 + 5 + 3 = 12 + 0
}

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumDigitNum(number));