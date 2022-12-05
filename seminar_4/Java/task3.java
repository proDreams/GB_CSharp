// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120
package seminar_4.Java;

import java.util.Scanner;

public class task3 {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Введите число: ");
        int num = input.nextInt();
        int prod = 1;
        for (int i = 1; i <= num; i++) {
            prod *= i;
        }
        System.out.println(prod);
    }
}
