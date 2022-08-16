// Найти произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int size = new Random().Next(5,11);
int min = 0; 
int max = 100;
int[] array = new int[size];
Console.WriteLine("В массиве:");
for(int i = 0; i<size; i++)  
{
    array[i] = new Random().Next(min, max+1);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
for(int i = 0; i < size/2; i++)
{
  int result = array[i] * array[size-i-1];
  Console.WriteLine($"{i+1}-й элемент * {size-i}-й элемент = {result}");  
}
if(size%2 != 0)  // в случае массива с нечетным количеством элементов выводим дополнительную запись 
{
  Console.WriteLine($"{size/2+1}-й элемент не имеет пары.");   
}
