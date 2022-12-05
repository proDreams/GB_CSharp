// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
package seminar_1.Java;

import java.util.Scanner;

public class HW_task2 {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Введите первое число: ");
        int numA = input.nextInt();
        System.out.print("Введите второе число: ");
        int numB = input.nextInt();
        System.out.print("Введите третье число: ");
        int numC = input.nextInt();
        System.out.print(Math.max(Math.max(numA, numB), numC));
        input.close();
    }
}
