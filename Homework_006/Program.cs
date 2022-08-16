// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int size = 123;
int min = 0; // произвольное значение
int max = 200; // произвольное значение
int[] array = new int[size];
int result = 0;
Console.WriteLine("В массиве:");
for(int i = 0; i<size; i++)
{
    array[i] = new Random().Next(min, max+1);
    if(array[i] >= 10 && array[i] <100) result = result + 1; 
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
Console.WriteLine($"найдено {result} элементов из заданного отрезка.");