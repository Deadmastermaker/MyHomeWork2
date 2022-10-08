// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*int DigitSecond(int num)

{

    int one = num % 100;
    int two = one /10;

    return two;
   
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
int second = DigitSecond(num);
Console.WriteLine($"{second}");
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*bool DigitWeek(int num)
{
    bool result;
    int sat = 6;
    int sun = 7;
    if(num == sat || sun)

        result = true; 

    else

        result = false;

    return result;
}
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
bool thisWeek = DigitWeek(num);
Console.WriteLine($"{thisWeek}");
*/


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*int DigitThree(int num)
{
    int result;
    while(num > 999)
        num = num / 10;
    result = num % 10;
    return result;
}

int num = new Random().Next(1, 100000);

if(num >= 1 && num <= 99)
    Console.WriteLine("НЕТ");
else
{
    int digital = DigitThree(num);
    Console.WriteLine($"{num} and answer {digital}");

}
*/

