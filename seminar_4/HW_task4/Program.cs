// Задача “со звездочкой”:
// Напишите функцию, которая принимает одно число - высоту елочки и рисует ее в консоли звездочками.

void Tree(int height)
{
    int spaces = height - 1;
    int stars = 1;
    for (int i = 1; i <= height; i++)
    {
        for (int j = 1; j <= (spaces + stars); j++)
        {
            if (j <= spaces) Console.Write(" ");
            else Console.Write("*");
        }
        spaces--;
        stars += 2;
        Console.WriteLine();
    }
}
Console.Write("Введите высоту: ");
int heightTree = Convert.ToInt32(Console.ReadLine());
Tree(heightTree);