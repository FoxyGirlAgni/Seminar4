Start();

void Start()
{
    bool isEnd = false;
    while (isEnd == false)
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
            case 0:isEnd = true; break;
            case 25: MyPow(); break;
            case 27: SumNumbers(); break;
            case 29: ViewArray(); break;
            default: System.Console.WriteLine("error"); break;
        }
    }
}
int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

//Напишите цикл, который принимает на вход два числа (A и B)
//и возводит число A в натуральную степень B. 

void MyPow()
{
    
    Console.Clear();

    int num = SetNumber("");

    int degree = SetNumber("degree of");

    Console.WriteLine($"{num} в степени {degree} = {Pow(num, degree)}");
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
//на вход число N и выдаёт сумму цифр в числе.
void SumNumbers()
{
    Console.Clear();

    int num = SetNumber("N");
    Console.WriteLine($"Сумма цифр = {GetSumNums(num)}");
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
//из элементов и выводит их на экран.
void ViewArray()
{
int lenArray = ReadInt("Введите длинну массива: ");

int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,9);
    Console.Write(randomArray[i] + " ");
}


// Функция ввода
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());

}
}
// //end