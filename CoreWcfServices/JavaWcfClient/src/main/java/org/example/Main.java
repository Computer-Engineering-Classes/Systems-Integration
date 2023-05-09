package org.example;

import org.service.WebService;
import org.service.WebServiceSoap;

public class Main {
    public static void main(String[] args) {
        WebService service = new WebService();
        WebServiceSoap port = service.getWebServiceSoap();
        System.out.println(port.add(1, 2));
        System.out.println(port.reverse("Hello World!"));
    }
}