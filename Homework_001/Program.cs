// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
int[] array = new int [8];
for(int count = 0; count < 8; count++)
{
    array[count] = new Random().Next(0,2);
    Console.WriteLine((count + 1) + "-й элемент = " + array[count]);
}