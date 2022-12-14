//Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// Диапазон трехзначных чисел, ввод случайный.
int[] array = new int[5];
Random random = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(100, 999);
}
Console.WriteLine(string.Join(",", array));
Console.WriteLine("колличество четных чисел : {0}", even(array));

int even(int[] array)
{
    int caunt = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            caunt++;

    }
    return caunt;
}

