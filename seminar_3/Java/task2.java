// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

package seminar_3.Java;

import java.util.Scanner;

public class task2 {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Введите первое число: ");
        int x = input.nextInt();
        if (x == 1) System.out.print("x > 0, y > 0");
        else if (x == 2) System.out.print("x < 0, y > 0");
        else if (x == 3) System.out.print("x < 0, y < 0");
        else if (x == 4) System.out.print("x > 0, y < 0");
        else System.out.print("Неверная четверть");
    }
}
