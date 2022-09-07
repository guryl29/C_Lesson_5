//Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine());
Console.WriteLine("Введите мин значение диапазона массива");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите макс значение диапазона массива");
int b = int.Parse(Console.ReadLine());
int []array = new int [size];
for (int i = 0; i< array.Length; ++i)
{
    array [i] = new Random().Next(a,b +1);
}
Console.WriteLine( string.Join( "," , array));

int sum =0;
for (int i = 1; i<size; i+=2)
{
    sum= sum + array[i];
}

Console.WriteLine("сумма элементов стоящих на нечетных позициях равна " + sum);