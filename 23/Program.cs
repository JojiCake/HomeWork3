Console.WriteLine("Введите число: ");
string? numberString = Console.ReadLine();
int number = int.Parse(numberString!);
int i = 0;
while(i < number+1)
{
    Console.WriteLine(i*i*i);
    i++;
}
