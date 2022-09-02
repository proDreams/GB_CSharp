// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}


int[] CalculateArray(int[] array)
{
    int[] result = new int[2];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) result[1] += array[i];
        else result[0] += array[i];
    }
    return result;
}

void PositiveSum(int[] array)
{
    int pos = 0;

    foreach (int el in array)
    {
        pos += el > 0 ? el : 0;  // если el > 0 прибавь элемент
    }                            // иначе элемент будет равен нулю и добавь его
    Console.WriteLine($"{pos}");
}

int[] newArray = GetArray(10, -100, 101);
int[] calculated = CalculateArray(newArray);
Console.WriteLine($"[{String.Join(", ", newArray)}]");
Console.WriteLine($"Сумма отрицательных: {calculated[0]}.");
Console.WriteLine($"Сумма положительных: {calculated[1]}.");
PositiveSum(newArray);