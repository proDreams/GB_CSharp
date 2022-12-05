// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
package seminar_5.Java;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Scanner;
import java.util.concurrent.ThreadLocalRandom;

public class task5 {
    public static void main(String[] args) {
        ThreadLocalRandom randomNum = ThreadLocalRandom.current();
        Scanner scanner = new Scanner(System.in);
        System.out.print("Введите размер массива: ");
        int arraySize = scanner.nextInt();
        int[] arr = new int[arraySize];
        createArray(arr, randomNum);
        System.out.println(Arrays.toString(arr));
        System.out.println(getProd(arr, arraySize));
    }

    private static void createArray(int[] array, ThreadLocalRandom rand) {
        for (int i = 0; i < array.length; i++) {
            array[i] = rand.nextInt(0, 10);
        }
    }

    private static ArrayList<Integer> getProd(int[] array, int size) {
        ArrayList<Integer> result = new ArrayList<Integer>();
        for (int i = 0; i < size / 2; i++) {
            result.add(array[i] * array[size - 1 - i]);
        }
        if (size % 2 != 0) result.add(array[size / 2]);
        return result;
    }
}
