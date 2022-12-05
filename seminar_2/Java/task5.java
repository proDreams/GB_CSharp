// 16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет
package seminar_2.Java;

import java.util.Scanner;

public class task5 {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Введите первое число: ");
        int numA = input.nextInt();
        System.out.print("Введите второе число: ");
        int numB = input.nextInt();
        if (numA * numA == numB || numB * numB == numA) System.out.print("Да");
        else System.out.print("Нет");
    }
}
