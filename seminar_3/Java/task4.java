// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1, 4
package seminar_3.Java;

import java.util.ArrayList;
import java.util.Scanner;

public class task4 {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Введите число: ");
        int x = input.nextInt();
        ArrayList<Integer> result = new ArrayList<>();
        for (int i = 1; i <= x; i++) {
            result.add(i * i);
        }
        System.out.println(result);
    }
}
