// Задача 32: Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
package seminar_5.Java;

import java.util.Arrays;
import java.util.concurrent.ThreadLocalRandom;

public class task2 {
    public static void main(String[] args) {
        ThreadLocalRandom randomNum = ThreadLocalRandom.current();
        int[] arr = new int[5];
        createArray(arr, randomNum);
        System.out.println(Arrays.toString(arr));
        changeArray(arr);
        System.out.println(Arrays.toString(arr));
    }
    private static void createArray(int[] array, ThreadLocalRandom rand) {
        for (int i = 0; i < 5; i++) {
            array[i] = rand.nextInt(-9, 10);
        }
    }
    private static void changeArray(int[] array) {
        for (int i = 0; i < array.length; i++) {
            array[i] *= -1;
        }
    }
}
