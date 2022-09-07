//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int size =5;
int minValye = 100;
int maxValye = 999;
int [] array = new int [size];
int count = 0;

for ( int i = 0;i< array.Length; i++)
{
    array [i] = new Random().Next(minValye, maxValye+1);
}
Console.WriteLine(string.Join("," , array));
Console.WriteLine();

for ( int i =0; i<array.Length; ++i)
{
    if (array[i]%2==0)
    {
        count++;
    }

}
Console.WriteLine( "Количество четных чисел в массиве " + count);