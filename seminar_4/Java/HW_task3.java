// Напишите программу, которая задаёт массив из N элементов, заполненных случайнми числами из [a, b) и выводит их на экран.
// 5, 0, 20 -> [1, 2, 5, 7, 19]
// 3, 1, 35 -> [6, 1, 33]
package seminar_4.Java;

import java.util.Arrays;
import java.util.Scanner;
import java.util.concurrent.ThreadLocalRandom;

public class HW_task3 {
    public static void main(String[] args) {
        ThreadLocalRandom randomNum = ThreadLocalRandom.current();
        Scanner input = new Scanner(System.in);
        System.out.print("Введите количество элементов: ");
        int size = input.nextInt();
        System.out.print("Введите начало диапазона: ");
        int start = input.nextInt();
        System.out.print("Введите конец диапазона: ");
        int end = input.nextInt();
        int[] arr = new int[size];
        for (int i = 0; i < size; i++) {
            arr[i] = randomNum.nextInt(start, end);
        }
        System.out.println(Arrays.toString(arr));
    }
}
