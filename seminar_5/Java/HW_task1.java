// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
package seminar_5.Java;

import java.util.Arrays;
import java.util.Scanner;
import java.util.concurrent.ThreadLocalRandom;

public class HW_task1 {
    public static void main(String[] args) {
        ThreadLocalRandom randomNum = ThreadLocalRandom.current();
        Scanner scanner = new Scanner(System.in);
        System.out.print("Введите размер массива: ");
        int arraySize = scanner.nextInt();
        int[] arr = new int[arraySize];
        createArray(arr, randomNum);
        System.out.println(Arrays.toString(arr));
        System.out.println(getPos(arr));
    }

    private static void createArray(int[] array, ThreadLocalRandom rand) {
        for (int i = 0; i < array.length; i++) {
            array[i] = rand.nextInt(100, 1000);
        }
    }

    private static Integer getPos(int[] array) {
        int result = 0;
        for (int i : array) {
            if (i % 2 == 0) result++;
        }
        return result;
    }
}
