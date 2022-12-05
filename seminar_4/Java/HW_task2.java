// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
package seminar_4.Java;

import java.util.Scanner;

public class HW_task2 {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Введите число: ");
        int num = input.nextInt();
        int count = 0;
        while (num > 0) {
            count += num % 10;
            num /= 10;
        }
        System.out.println(count);
    }
}
