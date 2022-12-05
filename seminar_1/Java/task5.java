// 5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"
package seminar_1.Java;

import java.util.*;

public class task5 {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Введите число N: ");
        int Num = input.nextInt();
        ArrayList<Object> result = new ArrayList<>();
        for (int i = -Num; i <= Num; i++) {
            result.add(i);
        }
        System.out.println(result);
        input.close();
    }
}
