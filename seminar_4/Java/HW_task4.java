// Задача “со звездочкой”:
// Напишите функцию, которая принимает одно число - высоту елочки и рисует ее в консоли звездочками.
package seminar_4.Java;

import java.util.Scanner;

public class HW_task4 {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Введите размер ёлочки: ");
        int size = input.nextInt();
        print_tree(size);
    }

    public static void print_tree(int size) {
        int spaces = size - 1;
        int chars = 1;
        for (int i = 0; i < size; i++) {
            String text = " ".repeat(spaces) + "*".repeat(chars);
            System.out.println(text);
            spaces--;
            chars += 2;
        }
    }
}
