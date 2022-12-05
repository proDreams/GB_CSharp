// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
package seminar_5.Java;

import java.util.Arrays;
import java.util.Scanner;
import java.util.concurrent.ThreadLocalRandom;

public class HW_task2 {
    public static void main(String[] args) {
        ThreadLocalRandom randomNum = ThreadLocalRandom.current();
        Scanner scanner = new Scanner(System.in);
        System.out.print("Введите размер массива: ");
        int arraySize = scanner.nextInt();
        int[] arr = new int[arraySize];
        createArray(arr, randomNum);
        System.out.println(Arrays.toString(arr));
        System.out.println(getPos(arr, arraySize));
    }

    private static void createArray(int[] array, ThreadLocalRandom rand) {
        for (int i = 0; i < array.length; i++) {
            array[i] = rand.nextInt(0, 10);
        }
    }

    private static Integer getPos(int[] array, int size) {
        int result = 0;
        for (int i = 1; i < size; i += 2) {
            result += array[i];
        }
        return result;
    }
}