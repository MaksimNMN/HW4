// Задача 29: Напишите программу, 
// которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int Prompt(string message)
{
    System.Console.Write(message);        // Введите команду
    string ReadInput = System.Console.ReadLine();
    int result = int.Parse(readInput);       // Приводим к числу
    return result;                           // возвращаем результат
}
// создаем метод для получения случайных значений массива
int[] GenerateArray(int length, int minValue, int maxValue)
{
    int array = new int[Length]; // тут обьявили массив
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1); // заполняем случайными цифрами из диапазона
        // SatrArr до EndArr
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, "); // вывод значения массива
    }
    System.Console.Write($"{array[array.Length - 1]}"); // вывод значения массива
    System.Console.Write("]");
}


int length = Prompt("длинна массива");
int min = Prompt("Начальное значение, для дипазона случайного числа: ");
int max = Prompt("Конечное значение, для дипазона случайного числа: ");
int[] array = GenerateArray(length, min, max); // заполнение массива случайными числами
PrintArray(array);

