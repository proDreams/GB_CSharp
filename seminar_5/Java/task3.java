// Задача 33: Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да
package seminar_5.Java;

import java.util.Arrays;
import java.util.Scanner;
import java.util.concurrent.ThreadLocalRandom;

public class task3 {
    public static void main(String[] args) {
        ThreadLocalRandom randomNum = ThreadLocalRandom.current();
        Scanner scanner = new Scanner(System.in);
        System.out.print("Введите число для поиска в массиве: ");
        int num = scanner.nextInt();
        int[] arr = new int[10];
        createArray(arr, randomNum);
        System.out.println(Arrays.toString(arr));
        System.out.println(findInArray(arr, num));
    }

    private static void createArray(int[] array, ThreadLocalRandom rand) {
        for (int i = 0; i < array.length; i++) {
            array[i] = rand.nextInt(0, 10);
        }
    }

    private static String findInArray(int[] array, int number) {
        for (int i : array) {
            if (i == number) return "Yes";
        }
        return "No";
    }
}

