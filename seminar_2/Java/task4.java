// 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да
package seminar_2.Java;

import java.util.Scanner;

public class task4 {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Введите первое число: ");
        int num = input.nextInt();
        if (num % 23 == 0 && num % 7 == 0) System.out.print("Да");
        else System.out.print("Нет");
    }
}
