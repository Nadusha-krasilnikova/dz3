// показать вторую цифру трех значного числа
Console.WriteLine("введите трехзначное число");
int a= int.Parse(Console.ReadLine());
if (a>99 && a<1000)
{
    Console.WriteLine("вторая цифра числа: ");
    Console.Write ((a/10) % 10);
}
else
{
    Console.WriteLine(" число не является трехзначным ");
}

