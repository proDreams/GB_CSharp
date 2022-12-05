// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
package seminar_3.Java;

import java.util.Scanner;

public class HW_task2 {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Введите координату x точки A: ");
        int x1 = input.nextInt();
        System.out.print("Введите координату y точки A: ");
        int y1 = input.nextInt();
        System.out.print("Введите координату z точки A: ");
        int z1 = input.nextInt();
        System.out.print("Введите координату x точки B: ");
        int x2 = input.nextInt();
        System.out.print("Введите координату y точки B: ");
        int y2 = input.nextInt();
        System.out.print("Введите координату z точки A: ");
        int z2 = input.nextInt();
        int x = (x2 - x1) * (x2 - x1);
        int y = (y2 - y1) * (y2 - y1);
        int z = (z2 - z1) * (z2 - z1);
        double res = Math.sqrt(x + y + z);
        System.out.printf("%.2f", res);
    }
}
