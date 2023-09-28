//TASK1

/*
Console.WriteLine("reqem daxil et");
int num = int.Parse(Console.ReadLine());


if (num <= 0)
{
    Console.WriteLine("Yanlis melumat");
}
else
{
    while (num % 2 == 0)
    {
        num = num / 2;

    }

    if (num == 1)
    {
        Console.WriteLine("2nin quvvetidir");
    }
    else
    {
        Console.WriteLine("2nin quvveti deyil");

    }

}

*/


//TASK2


//Console.WriteLine("Reqem daxil et:");
//int number = int.Parse(Console.ReadLine());
//Console.WriteLine("Digit daxil et:");
//int digit = int.Parse(Console.ReadLine());
//Console.WriteLine("Cavab: ");

//for (int i = 1; i < number; i++)
//{
//    int currentNumber = i;
//    while (currentNumber > 0)
//    {
//        int currentDigit = currentNumber % 10;
//        if (currentDigit == digit)
//        {
//            Console.WriteLine(i);
//            break;
//        }

//        currentNumber /= 10;

//    }

//}




//TASK3

/*
Console.WriteLine("Reqem daxil edin:");
int number = int.Parse(Console.ReadLine());
int sum = 0;
bool IsPerfect = true;

for (int i = 1; i < number; i++)
{
    if (number % i == 0)
    {
        sum = sum + i;
    }
}

if (sum == number)
{
    IsPerfect = true;
}

else
{
    IsPerfect = false;
}

Console.WriteLine(IsPerfect);

*/

//Task6 



//Console.WriteLine("Reqem daxil edin:");
//int number = int.Parse(Console.ReadLine());

//for (int i = 1; i <= number; i++)
//{
//    for (int j = 0; j < i; j++)
//    {
//        Console.Write("*");
//    }

//    Console.WriteLine();
//}
