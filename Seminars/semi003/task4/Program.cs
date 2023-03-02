int[] FillArray(int length, int leftnum = int.MinValue, int rightnum = int.MaxValue)
{
    int[] rand_arr = new int[length];
    for (int i = 0; i < rand_arr.Length; i++)
    {
        rand_arr[i] = Random.Shared.Next(leftnum, rightnum);
    }
    return rand_arr;
}

int[] LengthArray(int[] array)
{
    if(array.Length % 2 == 0) 
    {
        return new int[array.Length / 2];
    }
    else
    {
        return new int[array.Length / 2 + 1];
    }
}

int[] MultiplyArray(int[] array)
{
    int[] result = LengthArray(array);
    for(int i = 0; i < array.Length / 2; i++)
    {
        result[i] = array[i] * array[array.Length - i -1];
    }
    if(array.Length % 2 != 0)
    {
        result[result.Length - 1] = array[array.Length / 2];
    }
    return result;
}

int[] filled_array = FillArray(5, -10, 10);

Console.WriteLine($"{string.Join(',', filled_array)} -> {string.Join(',', MultiplyArray(filled_array))}");


// int numberInt = Random.Shared.Next(1, 10);
// double numberDouble = Random.Shared.NextDouble() * 100 - 20;
// double[] doubles = new double[] {2.35345345, 1.392391392, 234.234236546 };
// Console.WriteLine($"{string.Join(", ", doubles.Select(x => Math.Round(x, 2)))}"); // [-20.0, 80.0) ПО ДОМАШКЕ ВЕЩЕСТВЕННЫЕ ЧИСЛА