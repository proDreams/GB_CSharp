// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20
//package seminar_5.Java;
//
//import java.util.ArrayList;
//import java.util.concurrent.ThreadLocalRandom;
//
//public class task1 {
//    public static void main(String[] args) {
//        ThreadLocalRandom randomNum = ThreadLocalRandom.current();
//        int[] arr = new int[12];
//        for (int i = 0; i < 8; i++) {
//            arr.add(randomNum.nextInt(-9, 10));
//        }
//    }
//}