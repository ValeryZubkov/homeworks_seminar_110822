// Найти сумму чисел одномерного массива стоящих на нечетной позиции
int size = new Random().Next(5,11);
int min = 0; 
int max = 100;
int[] array = new int[size];
int sum = 0;
Console.WriteLine("В массиве:");
for(int i = 0; i<size; i++)
{
    array[i] = new Random().Next(min, max+1);
    if(i%2 != 0) sum = sum + array[i]; 
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
Console.WriteLine($"сумма нечетных элементов равна {sum}.");