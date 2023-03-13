// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int start = InputNumbers("Введите Start: ");
int end = InputNumbers("Введите End: ");
int temp = start;

if (start > end)
{
    start = end;
    end = temp;
}

PrintSumm(start, end, temp = 0);

void PrintSumm(int start, int end, int summ)
{
    summ = summ + end;
    if (end <= start)
    {
        Console.Write($"Сумма элементов= {summ} ");
        return;
    }
    PrintSumm(start, end - 1, summ);
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

