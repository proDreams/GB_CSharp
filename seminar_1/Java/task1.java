// Задача 0: Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

package seminar_1.Java;

import java.util.Scanner;

public class task1 {
    public static void main(String[] args) {
        Scanner iScanner = new Scanner(System.in);
        System.out.print("Введите число: ");
        Short num = iScanner.nextShort();
        System.out.printf("Квадрат числа %s = %s", num, num * num);
        iScanner.close();
    }
}