// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
package seminar_1.Java;

import java.util.ArrayList;
import java.util.Scanner;

public class HW_task4 {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Введите число: ");
        int num = input.nextInt();
        ArrayList<Object> result = new ArrayList<>();
        for (int i = 2; i <= num; i += 2) {
            result.add(i);
        }
        System.out.println(result);
    }
}
