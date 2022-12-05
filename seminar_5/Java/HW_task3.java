// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
package seminar_5.Java;

import org.apache.commons.math3.util.Precision;

import java.util.Arrays;
import java.util.Scanner;
import java.util.concurrent.ThreadLocalRandom;

public class HW_task3 {
    public static void main(String[] args) {
        ThreadLocalRandom randomNum = ThreadLocalRandom.current();
        Scanner scanner = new Scanner(System.in);
        System.out.print("Введите размер массива: ");
        int arraySize = scanner.nextInt();
        double[] arr = new double[arraySize];
        createArray(arr, randomNum);
        System.out.println(Arrays.toString(arr));
        Arrays.sort(arr);
        System.out.println(arr[0] - arr[arraySize - 1]);
    }

    private static void createArray(double[] array, ThreadLocalRandom rand) {
        for (int i = 0; i < array.length; i++) {
            array[i] = Precision.round(rand.nextDouble(0, 10), 3);
        }
    }
}