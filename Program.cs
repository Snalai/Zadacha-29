// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
int[] number = new int[8];
int i = 0;
int l = number.Length;
while (i < l)
{
    if (i < l)
    {
        int a = new Random().Next(0, 100);// Пришлось ограничить т.к там 9 значные числа.
        number[i] = a;
        i++;
    }
}
Console.WriteLine($"{number[0]},{number[1]},{number[2]},{number[3]},{number[4]},{number[5]},{number[6]},{number[7]}");