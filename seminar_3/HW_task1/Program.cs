// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Write("Введите пятизначное число: ");
string num_str = Console.ReadLine();
if (num_str.Length != 5) Console.WriteLine("Введено не пятизначное число.");
else
{   
    int num_int = Convert.ToInt32(num_str);
    if ((num_int / 10000 == num_int % 10) && ((num_int / 1000 % 10 == num_int / 10 % 10)))
    {
        Console.WriteLine("Число является палиндромом.");
    }
    else Console.WriteLine("Число не является палиндромом.");
}
