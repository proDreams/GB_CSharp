// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
package seminar_5.Java;

import java.util.Arrays;
import java.util.concurrent.ThreadLocalRandom;

public class task4 {
    public static void main(String[] args) {
        ThreadLocalRandom randomNum = ThreadLocalRandom.current();
        int[] arr = new int[123];
        createArray(arr, randomNum);
        System.out.println(Arrays.toString(arr));
        System.out.println(findInArray(arr));
    }

    private static void createArray(int[] array, ThreadLocalRandom rand) {
        for (int i = 0; i < array.length; i++) {
            array[i] = rand.nextInt(0, 1000);
        }
    }

    private static int findInArray(int[] array) {
        int result = 0;
        for (int i : array) {
            if ((9 < i) && (i < 100)) result++;
        }
        return result;
    }
}
