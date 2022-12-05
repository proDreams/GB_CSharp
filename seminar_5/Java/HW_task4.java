// Задача "со звездочкой": Разобраться с алгоритмом сортировки методом пузырька. Реализовать невозрастающую сторировку.
// [3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
// [1,2,2,3,2] -> [3, 2, 2, 2, 1]
package seminar_5.Java;

import java.util.Arrays;
import java.util.Scanner;
import java.util.concurrent.ThreadLocalRandom;

public class HW_task4 {
    public static void main(String[] args) {
        ThreadLocalRandom randomNum = ThreadLocalRandom.current();
        Scanner scanner = new Scanner(System.in);
        System.out.print("Введите размер массива: ");
        int arraySize = scanner.nextInt();
        int[] arr = new int[arraySize];
        createArray(arr, randomNum, arraySize);
        System.out.println(Arrays.toString(arr));
        bubbleSort(arr, arraySize);
        System.out.println(Arrays.toString(arr));
    }

    private static void createArray(int[] array, ThreadLocalRandom rand, int size) {
        for (int i = 0; i < array.length; i++) {
            array[i] = rand.nextInt(0, 10);
        }
    }

    private static void bubbleSort(int[] array, int size) {
        for (int i = 0; i < size; i++) {
            for (int j = i; j < size; j++) {
                if (array[i] > array[j]) {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
    }
}