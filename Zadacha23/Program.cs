void Zadacha23()
{
    //Напишите программу, которая принимает на вход число (N) и выдаёт
    //таблицу кубов чисел от 1 до N.

    Console.Write("Введите число: ");
    int number_end = Convert.ToInt32(Console.ReadLine());
    int number_start = 1;

    while (number_start <= number_end)
    {
        double result = Math.Pow(number_start, 3);
        Console.Write(result + " ");
        number_start++;
    }
}

Zadacha23();