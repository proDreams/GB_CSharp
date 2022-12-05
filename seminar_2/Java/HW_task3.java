// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
package seminar_2.Java;

import java.util.Scanner;

public class HW_task3 {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Введите первое число: ");
        int num = input.nextInt();
        switch (num){
            case 1, 2, 3, 4, 5 -> System.out.print("Будни =(");
            case 6, 7 -> System.out.print("Выходные!");
            default -> System.out.print("Не день недели");
        }
    }
}
