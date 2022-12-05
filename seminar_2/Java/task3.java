// 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно
package seminar_2.Java;

import java.util.Scanner;

public class task3 {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Введите первое число: ");
        int numA = input.nextInt();
        System.out.print("Введите второе число: ");
        int numB = input.nextInt();
        if (numA % numB == 0) System.out.print("Кратно");
        else System.out.printf("Не кратно, остаток %d", numA % numB);
    }
}
