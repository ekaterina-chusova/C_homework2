// Напишите программу, которая выводит третью цифру СЛЕВА заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 3267912 -> 6

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int i = num;
int count = 0;

while (i !=0)
{
    i = i / 10;
    count++;
}

if (count < 3) Console.WriteLine("Третьей цифры нет");
else
{
    Console.WriteLine(num % Convert.ToInt32(Math.Pow(10, count - 2)) / Convert.ToInt32(Math.Pow(10, count - 3)));
}


// Решение с помощью строк:

Console.WriteLine("Решение с помошью строк. Введите число: ");
string a = Console.ReadLine();

char ch3 = a[2];
Console.WriteLine(ch3);



