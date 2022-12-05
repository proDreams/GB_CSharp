// 17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
package seminar_3.Java;

import java.util.Scanner;

public class task1 {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Введите первое число: ");
        int x = input.nextInt();
        System.out.print("Введите второе число: ");
        int y = input.nextInt();
        if (x > 0) {
            if (y > 0) System.out.print("I четверть");
            else System.out.print("IV четверть");
        } else {
            if (y < 0) System.out.print("III четверть");
            else System.out.print("II четверть");
        }
    }
}
