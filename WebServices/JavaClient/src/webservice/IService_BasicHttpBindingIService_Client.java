
package webservice;

/**
 * Please modify this class to meet your needs
 * This class is not complete
 */

import java.io.File;
import java.net.MalformedURLException;
import java.net.URL;
import javax.xml.namespace.QName;
import jakarta.jws.WebMethod;
import jakarta.jws.WebParam;
import jakarta.jws.WebResult;
import jakarta.jws.WebService;
import jakarta.xml.bind.annotation.XmlSeeAlso;
import jakarta.xml.ws.Action;
import jakarta.xml.ws.RequestWrapper;
import jakarta.xml.ws.ResponseWrapper;

/**
 * This class was generated by Apache CXF 4.0.1
 * 2023-05-16T21:54:14.124+01:00
 * Generated source version: 4.0.1
 *
 */
public final class IService_BasicHttpBindingIService_Client {

    private static final QName SERVICE_NAME = new QName("http://tempuri.org/", "Service");

    private IService_BasicHttpBindingIService_Client() {
    }

    public static void main(String args[]) throws java.lang.Exception {
        URL wsdlURL = Service.WSDL_LOCATION;
        if (args.length > 0 && args[0] != null && !"".equals(args[0])) {
            File wsdlFile = new File(args[0]);
            try {
                if (wsdlFile.exists()) {
                    wsdlURL = wsdlFile.toURI().toURL();
                } else {
                    wsdlURL = new URL(args[0]);
                }
            } catch (MalformedURLException e) {
                e.printStackTrace();
            }
        }

        Service ss = new Service(wsdlURL, SERVICE_NAME);
        IService port = ss.getBasicHttpBindingIService();

        {
        System.out.println("Invoking celsiusToKelvin...");
        java.lang.Double _celsiusToKelvin_celsius = null;
        java.lang.Double _celsiusToKelvin__return = port.celsiusToKelvin(_celsiusToKelvin_celsius);
        System.out.println("celsiusToKelvin.result=" + _celsiusToKelvin__return);


        }
        {
        System.out.println("Invoking min...");
        webservice.ArrayOfint _min_numbers = new webservice.ArrayOfint();
        java.lang.Integer _min__return = port.min(_min_numbers);
        System.out.println("min.result=" + _min__return);


        }
        {
        System.out.println("Invoking celsiusToFahrenheit...");
        java.lang.Double _celsiusToFahrenheit_celsius = null;
        java.lang.Double _celsiusToFahrenheit__return = port.celsiusToFahrenheit(_celsiusToFahrenheit_celsius);
        System.out.println("celsiusToFahrenheit.result=" + _celsiusToFahrenheit__return);


        }
        {
        System.out.println("Invoking divide...");
        java.lang.Integer _divide_a = null;
        java.lang.Integer _divide_b = null;
        java.lang.Float _divide__return = port.divide(_divide_a, _divide_b);
        System.out.println("divide.result=" + _divide__return);


        }
        {
        System.out.println("Invoking multiply...");
        java.lang.Integer _multiply_a = null;
        java.lang.Integer _multiply_b = null;
        java.lang.Integer _multiply__return = port.multiply(_multiply_a, _multiply_b);
        System.out.println("multiply.result=" + _multiply__return);


        }
        {
        System.out.println("Invoking subtract...");
        java.lang.Integer _subtract_a = null;
        java.lang.Integer _subtract_b = null;
        java.lang.Integer _subtract__return = port.subtract(_subtract_a, _subtract_b);
        System.out.println("subtract.result=" + _subtract__return);


        }
        {
        System.out.println("Invoking kelvinToCelsius...");
        java.lang.Double _kelvinToCelsius_kelvin = null;
        java.lang.Double _kelvinToCelsius__return = port.kelvinToCelsius(_kelvinToCelsius_kelvin);
        System.out.println("kelvinToCelsius.result=" + _kelvinToCelsius__return);


        }
        {
        System.out.println("Invoking fahrenheitToCelsius...");
        java.lang.Double _fahrenheitToCelsius_fahrenheit = null;
        java.lang.Double _fahrenheitToCelsius__return = port.fahrenheitToCelsius(_fahrenheitToCelsius_fahrenheit);
        System.out.println("fahrenheitToCelsius.result=" + _fahrenheitToCelsius__return);


        }
        {
        System.out.println("Invoking add...");
        java.lang.Integer _add_a = null;
        java.lang.Integer _add_b = null;
        java.lang.Integer _add__return = port.add(_add_a, _add_b);
        System.out.println("add.result=" + _add__return);


        }
        {
        System.out.println("Invoking max...");
        webservice.ArrayOfint _max_numbers = new webservice.ArrayOfint();
        java.lang.Integer _max__return = port.max(_max_numbers);
        System.out.println("max.result=" + _max__return);


        }
        {
        System.out.println("Invoking reverse...");
        java.lang.String _reverse_text = "";
        java.lang.String _reverse__return = port.reverse(_reverse_text);
        System.out.println("reverse.result=" + _reverse__return);


        }
        {
        System.out.println("Invoking sum...");
        webservice.ArrayOfint _sum_numbers = new webservice.ArrayOfint();
        java.lang.Integer _sum__return = port.sum(_sum_numbers);
        System.out.println("sum.result=" + _sum__return);


        }
        {
        System.out.println("Invoking average...");
        webservice.ArrayOfint _average_numbers = new webservice.ArrayOfint();
        java.lang.Double _average__return = port.average(_average_numbers);
        System.out.println("average.result=" + _average__return);


        }
        {
        System.out.println("Invoking getIndex...");
        webservice.ArrayOfint _getIndex_numbers = new webservice.ArrayOfint();
        java.lang.Integer _getIndex_number = null;
        java.lang.Integer _getIndex__return = port.getIndex(_getIndex_numbers, _getIndex_number);
        System.out.println("getIndex.result=" + _getIndex__return);


        }
        {
        System.out.println("Invoking helloWorld...");
        java.lang.String _helloWorld__return = port.helloWorld();
        System.out.println("helloWorld.result=" + _helloWorld__return);


        }

        System.exit(0);
    }

}
