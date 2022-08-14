// Console.WriteLine("Введите пятзначное число: ");
// string str  = Console.ReadLine();
// int number = int.Parse(numberString!);
// if (number > 9999 && number < 100000)

Console.WriteLine("Введите пятизначное число: ");

string number  = Console.ReadLine();

if (number[0] == number[4] && number[1] == number[3] )

    Console.WriteLine("Да");

else
{
    Console.WriteLine("Нет");
}