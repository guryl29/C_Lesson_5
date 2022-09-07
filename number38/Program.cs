
// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива

void FillArray(double [] array)
{
  int length = array.Length;
  for ( int i = 0; i<length; i++)
  {
    array [i] = new Random().Next(1, 99);
  }
}
void PrintArray(double [] arr)
{
  Console.Write("[");
  int count = arr.Length;
    for ( int j = 0; j< count-1; j++)
    {
      Console.Write(arr[j] + ";");
    }
Console.WriteLine(arr[count-1]+ "]");    
}
void SubMaxMin(double[]Nums,int length)
{
    double Max = Nums[0];
    double Min = Nums[1];
    for (int i = 0; i < length; i++)
    {
       if (Nums[i]>Max)
       {
        Max = Nums[i];
       } 
       else if (Nums[i]<Min)    
    {
    Min = Nums [i];
    }
    }
double SubMaxMin=Max-Min;
Console.WriteLine("максимальное значение " + Max+", минимальное значение " + Min+", разница между ними равна "+SubMaxMin);
}
int length= new Random().Next(5,10);
double[]Array = new double [length];
FillArray(Array);
PrintArray(Array);
SubMaxMin(Array,length);