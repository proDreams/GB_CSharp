// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
package seminar_3.Java;

import java.util.Scanner;

public class task3 {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Введите координату x точки A: ");
        int x1 = input.nextInt();
        System.out.print("Введите координату y точки A: ");
        int y1 = input.nextInt();
        System.out.print("Введите координату x точки B: ");
        int x2 = input.nextInt();
        System.out.print("Введите координату y точки B: ");
        int y2 = input.nextInt();
        int x = (x2 - x1) * (x2 - x1);
        int y = (y2 - y1) * (y2 - y1);
        double res = Math.sqrt(x + y);
        System.out.printf("%.2f", res);
    }
}
