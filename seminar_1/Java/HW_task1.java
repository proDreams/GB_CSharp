// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
package seminar_1.Java;

import java.util.Scanner;

public class HW_task1 {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Введите первое число: ");
        int numA = input.nextInt();
        System.out.print("Введите второе число: ");
        int numB = input.nextInt();
        System.out.print(Math.max(numA, numB));
        input.close();
    }
}
