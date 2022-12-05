// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
package seminar_4.Java;

import java.util.Scanner;

public class HW_task1 {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Введите первое число: ");
        int numA = input.nextInt();
        System.out.print("Введите второе число: ");
        int numB = input.nextInt();
        System.out.print((int) Math.pow(numA, numB));
    }
}
