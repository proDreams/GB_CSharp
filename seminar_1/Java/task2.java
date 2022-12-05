// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25; b = 5 -> да
// a = 2; b = 10 -> нет
// a = 9; b = -3 -> да
// a = -3; b = 9 -> нет

package seminar_1.Java;

import java.util.Scanner;

public class task2 {
    public static void main(String[] args) {
        Scanner iScanner = new Scanner(System.in);
        System.out.print("Введите первое число: ");
        int numA = iScanner.nextInt();
        System.out.print("Введите второе число: ");
        int numB = iScanner.nextInt();
        if (numB * numB == numA) System.out.print("Да, является");
        else System.out.print("Не является");
        iScanner.close();
    }
}
