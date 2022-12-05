// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
package seminar_1.Java;

import java.util.Scanner;

public class HW_task3 {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Введите число: ");
        int num = input.nextInt();
        if (num % 2 == 0) System.out.print("Да");
        else System.out.print("Нет");
    }
}
