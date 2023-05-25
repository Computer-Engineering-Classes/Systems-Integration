import ws.ArrayOfint;
import ws.IService;
import ws.Service;

import java.util.List;
import java.util.Random;

public class Main {
    public static void main(String[] args) {
        IService service = new Service().getBasicHttpBindingIService();
        System.out.println(service.add(1, 2));
        double celsius = 36.6;
        System.out.printf("%.2fºC = %.2fºF\n", celsius, service.celsiusToFahrenheit(celsius));
        System.out.println(service.reverse("Hello World!"));
        ArrayOfint arrayOfint = new ArrayOfint();
        List<Integer> list = arrayOfint.getInt();
        Random random = new Random();
        for (int i = 0; i < 10; i++) {
            list.add(random.nextInt(201) - 100);
        }
        System.out.println("List: " + list);
        System.out.println("Max: " + service.max(arrayOfint));
        System.out.println("Min: " + service.min(arrayOfint));
        System.out.println("Sum: " + service.sum(arrayOfint));
        System.out.println("Avg: " + service.average(arrayOfint));
    }
}