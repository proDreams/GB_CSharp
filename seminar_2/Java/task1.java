// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8
package seminar_2.Java;

import java.util.concurrent.ThreadLocalRandom;

public class task1 {
    public static void main(String[] args) {
        int randomNum = ThreadLocalRandom.current().nextInt(10, 100);
        System.out.println(randomNum);
        int left = randomNum / 10;
        int right = randomNum % 10;
        System.out.println(Math.max(left, right));
    }
}
