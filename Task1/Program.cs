Start();


void Start()
{
    while (true)
    {
        Console.ReadLine();
        Console.Clear();

        System.Console.WriteLine("25) Задача 25: Напишите цикл, который принимает на вход два числа (A и B)и возводит число A в натуральную степень B.");
        System.Console.WriteLine("27) Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
        System.Console.WriteLine("29) Задача 29: Напишите программу, которая задаёт массив из введённого числа и выводит их на экран.");
        System.Console.WriteLine("0) End");

        int numTask = SetNumber("task");

        switch (numTask)
        {
            case 0: return; break;
            case 25: MyPow(); break;
            case 27: SunNumbers(); break;
            case 29: ViewArray(); break;
            default: System.Console.WriteLine("error"); break;
        }
    }
}
//Напишите цикл, который принимает на вход два числа (A и B)
//и возводит число A в натуральную степень B. 

void MyPow()
{
    
    Console.Clear();

    int num = SetNumber("");

    int degree = SetNumber("degree of");

    Console.WriteLine{$"{num} в степени {degree} - {Pow(num, degree)}"};
}



int Pow(int num, int rank)
{
    if (rank == 0) return 1;
    else if (rank == 1) return num;

    int result = num;

    for (int i = 2; i <= rank; i++)
    {
        result *= num;
    }

    return result;
}
//end

//Напишите программу, которая принимает 
//на вход число и выдаёт сумму цифр в числе.
void Sumnumbers()
{
    Console.Clear();

    int num = SetNumber("N");
    Console.WriteLine($"Сумма цифр - {GetSumNums(num)}");
}


int GetSumNums(int number)
{
    int sum = 0;

    while (number > 0)
    {
        sum += number % 10;
        number /=10;
    }

    return sum;
}
//end

//Напишите программу, которая задаёт массив 
//из введённого числа и выводит их на экран.

