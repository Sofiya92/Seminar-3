// Напишите программу, которая принимает на вход число (N) 
// и выдает таблицу квадратов от 1 до N.


Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
Table(number);


void Table(int num)
{
    int index = 1;
    int result = 0;
    while(index<=num)
    {
        result = index*index;
        Console.WriteLine($"{index,5}  {result,5}" );
        index++;
    }
}