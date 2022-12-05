// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница
package seminar_1.Java;

import java.util.Scanner;

public class task3 {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        String day = input.nextLine();
        switch (day) {
            case "1" -> System.out.println("Понедельник");
            case "2" -> System.out.println("Вторник");
            case "3" -> System.out.println("Среда");
            case "4" -> System.out.println("Четверг");
            case "5" -> System.out.println("Пятница");
            case "6" -> System.out.println("Суббота");
            case "7" -> System.out.println("Воскресенье");
            default -> System.out.println("Не день недели");
        }
        input.close();
    }
}
