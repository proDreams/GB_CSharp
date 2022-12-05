// Напишите программу, которая выводит третью цифру (слева направо) заданного числа или сообщает, что третьей цифры нет.
// 645 -> 6
// 78 -> третьей цифры нет
// 32679 -> 6
package seminar_2.Java;

import java.util.Scanner;

public class HW_task2 {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Введите первое число: ");
        int num = input.nextInt();
        if (num > 99) System.out.print(num / 100 % 10);
        else System.out.print("Третьей цифры нет");
    }
}
