// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20
package seminar_5.Java;

import java.util.Arrays;
import java.util.concurrent.ThreadLocalRandom;

public class task1 {
    public static void main(String[] args) {
        ThreadLocalRandom randomNum = ThreadLocalRandom.current();
        int[] arr = new int[12];
        createArray(arr, randomNum);
        System.out.println(Arrays.toString(arr));
        int[] sums = calculateArray(arr);
        System.out.printf("Сумма положительных чисел равна %d, сумма отрицательных равна %d", sums[0], sums[1]);
    }

    private static void createArray(int[] array, ThreadLocalRandom rand) {
        for (int i = 0; i < 12; i++) {
            array[i] = rand.nextInt(-9, 10);
        }
    }

    private static int[] calculateArray(int[] array) {
        int[] res = new int[2];
        for (int i : array) {
            if (i >= 0) res[0] += i;
            else res[1] += i;
        }
        return res;
    }
}

