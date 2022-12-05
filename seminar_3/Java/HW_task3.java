// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
package seminar_3.Java;

import java.util.ArrayList;
import java.util.Scanner;

public class HW_task3 {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Введите число N: ");
        int n = input.nextInt();
        ArrayList<Integer> result = new ArrayList<>();
        for (int i = 1; i <= n; i++) {
            result.add((int) Math.pow(i, 3));
        }
        System.out.println(result);
    }
}
