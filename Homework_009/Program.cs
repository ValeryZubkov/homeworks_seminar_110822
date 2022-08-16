// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
int size = new Random().Next(5,20);
double[] array = new double[size];
Console.WriteLine("В массиве:");
for(int i = 0; i < size; i++)
{
    array[i] = new Random().NextDouble() * 100;    
    Console.Write($"{array[i].ToString("0.00")}  ");
}
Console.WriteLine();
double min = array[0];
double max = array[0];
for(int i = 0; i < size; i++)
{
   if(array[i] < min) min = array[i];
   if(array[i] > max) max = array[i];
}
double result = max - min;
Console.WriteLine($"разница между максимальным ({max.ToString("0.00")}) и минимальным ({min.ToString("0.00")}) элементом составляет: {result.ToString("0.00")}.");
