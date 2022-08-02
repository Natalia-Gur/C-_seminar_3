void Zadacha19()
{
    //Напишите программу, которая принимает на вход пятизначное число и проверяет,
    //является ли оно палиндромом.
    
    Console.Write("Введите пятизначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if(number >= 10000 && number <= 99999)
    {
        int startPartNumber = number/1000;
        int endPartNumber = number%100;
        int startPartOnEndPartNumber = endPartNumber/10;
        int endPartOnEndPartNumber = endPartNumber%10;
        endPartNumber = 10 * endPartOnEndPartNumber + startPartOnEndPartNumber;

        if(startPartNumber == endPartNumber)
        Console.WriteLine("Палиндром");
        else  Console.WriteLine("Не палиндром");
    }
    else Console.WriteLine("Введено неверное число! Повторите ввод!");
}

Zadacha19();


/*void Zadacha19()
{
    

    Console.Write("Введите пятизначное число: ");
    string number = Console.ReadLine();

    if (number.Length == 5)
    {
        char i = number[0];
        char j = number[4];
            if(i == j)
            {
                i = number[1];
                j = number[3];
                    if(i == j) Console.WriteLine("Палиндром");
                    else Console.WriteLine("Не палиндром");
            }
            else Console.WriteLine("Не палиндром");
    }
    else Console.WriteLine("Введено неверное число! Повторите ввод!");
    
}

Zadacha19();*/