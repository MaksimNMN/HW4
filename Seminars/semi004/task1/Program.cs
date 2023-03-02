// Напишите программу которая разворачивает массив




int[] GetRandomArray(int length, int leftRange, int rightRange)
{

    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftRange, rightRange + 1);
    }

    return array;
}

const int Length = 12;
const int LeftBorder = -10;
const int RightBorder = 10;


void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;
    }
        return array;
}

int[] myArray = GetRandomArray(Length, LeftBorder, RightBorder);
Console.WriteLine(string.Join(",", myArray));
ReverseArray(myArray);
Console.WriteLine(string.Join(",", myArray));





