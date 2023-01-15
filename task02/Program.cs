// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введи число: ");
int a1 = Convert.ToInt32(Console.ReadLine());

int e = 10;

if (ThirDigit(a1) == -1)
Console.WriteLine ("нет третьей цифры");
else
Console.WriteLine ( $"Третье число: {ThirDigit(a1)}");


int ThirDigit (int a)
{
int result = -1;
if ( a > 99)
{
while ( a > 999)
{
  a = a / e;
}
result = a % e;

}
return result;
}


