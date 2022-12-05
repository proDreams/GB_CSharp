// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
package seminar_4.Java;

import java.util.ArrayList;
import java.util.concurrent.ThreadLocalRandom;

public class task4 {
    public static void main(String[] args) {
        ThreadLocalRandom randomNum = ThreadLocalRandom.current();
        ArrayList<Integer> result = new ArrayList<Integer>();
        for (int i = 0; i < 8; i++) {
            result.add(randomNum.nextInt(0, 2));
        }
        System.out.println(result);
    }
}
