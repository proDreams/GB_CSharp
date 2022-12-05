// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
package seminar_2.Java;

import java.util.concurrent.ThreadLocalRandom;

public class task2 {
    public static void main(String[] args) {
        int randomNum = ThreadLocalRandom.current().nextInt(100, 1000);
        System.out.println(randomNum);
        int left = randomNum / 100 * 10;
        int right = randomNum % 10;
        System.out.println(left + right);
    }
}
