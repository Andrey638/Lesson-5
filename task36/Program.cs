//  Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях
//Диапазон любой, ввод зависит от пользователя. (размер, значения)
Console.WriteLine("Задайте размер массива");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];
Random random = new Random();
Console.WriteLine("Задайте размер значения от..->до.. ");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(n, m);
}
Console.WriteLine(string.Join(",", array));
Console.WriteLine("Сумма чисел на не чётных позициях : {0}", summa(array));

int summa(int[] array)
{
    int caunt = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
            caunt += array[i];
    }
    return caunt;
}