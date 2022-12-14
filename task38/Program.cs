// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// Диапазон любой, ввод зависит от пользователя. (размер, значения)
Console.WriteLine("Задайте размер массива");
int a = Convert.ToInt32(Console.ReadLine());
double[] array = new double[a];
Random random = new Random();
Console.WriteLine("Задайте размер значения от..->до.. ");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(n, m) + random.NextDouble();
}
Console.WriteLine(string.Join(",", array));
Console.WriteLine("Раздница между Max и Min : {0}", difference(array));

double difference(double[] array)
{
    double diff = 0;
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
        diff = max - min;
    }
    diff = max - min;
    return diff;
}