// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да
package seminar_3.Java;

import java.util.Scanner;

public class HW_task1 {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Введите число: ");
        int x = input.nextInt();
        if ((x / 10000 == x % 10) && ((x / 1000 % 10 == x / 10 % 10))) System.out.print("Число является палиндромом.");
        else System.out.print("Число не является палиндромом.");
    }
}
