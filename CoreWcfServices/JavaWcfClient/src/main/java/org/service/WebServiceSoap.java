
package org.service;

import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.jws.WebResult;
import javax.jws.WebService;
import javax.xml.bind.annotation.XmlSeeAlso;
import javax.xml.ws.RequestWrapper;
import javax.xml.ws.ResponseWrapper;


/**
 * This class was generated by the JAX-WS RI.
 * JAX-WS RI 2.2.9-b130926.1035
 * Generated source version: 2.2
 * 
 */
@WebService(name = "WebServiceSoap", targetNamespace = "http://tempuri.org/")
@XmlSeeAlso({
    ObjectFactory.class
})
public interface WebServiceSoap {


    /**
     * 
     * @param a
     * @param b
     * @return
     *     returns int
     */
    @WebMethod(operationName = "Add", action = "http://tempuri.org/Add")
    @WebResult(name = "AddResult", targetNamespace = "http://tempuri.org/")
    @RequestWrapper(localName = "Add", targetNamespace = "http://tempuri.org/", className = "wcf.service.Add")
    @ResponseWrapper(localName = "AddResponse", targetNamespace = "http://tempuri.org/", className = "wcf.service.AddResponse")
    public int add(
        @WebParam(name = "a", targetNamespace = "http://tempuri.org/")
        int a,
        @WebParam(name = "b", targetNamespace = "http://tempuri.org/")
        int b);

    /**
     * 
     * @param a
     * @param b
     * @return
     *     returns int
     */
    @WebMethod(operationName = "Subtract", action = "http://tempuri.org/Subtract")
    @WebResult(name = "SubtractResult", targetNamespace = "http://tempuri.org/")
    @RequestWrapper(localName = "Subtract", targetNamespace = "http://tempuri.org/", className = "wcf.service.Subtract")
    @ResponseWrapper(localName = "SubtractResponse", targetNamespace = "http://tempuri.org/", className = "wcf.service.SubtractResponse")
    public int subtract(
        @WebParam(name = "a", targetNamespace = "http://tempuri.org/")
        int a,
        @WebParam(name = "b", targetNamespace = "http://tempuri.org/")
        int b);

    /**
     * 
     * @param a
     * @param b
     * @return
     *     returns int
     */
    @WebMethod(operationName = "Multiply", action = "http://tempuri.org/Multiply")
    @WebResult(name = "MultiplyResult", targetNamespace = "http://tempuri.org/")
    @RequestWrapper(localName = "Multiply", targetNamespace = "http://tempuri.org/", className = "wcf.service.Multiply")
    @ResponseWrapper(localName = "MultiplyResponse", targetNamespace = "http://tempuri.org/", className = "wcf.service.MultiplyResponse")
    public int multiply(
        @WebParam(name = "a", targetNamespace = "http://tempuri.org/")
        int a,
        @WebParam(name = "b", targetNamespace = "http://tempuri.org/")
        int b);

    /**
     * 
     * @param a
     * @param b
     * @return
     *     returns float
     */
    @WebMethod(operationName = "Divide", action = "http://tempuri.org/Divide")
    @WebResult(name = "DivideResult", targetNamespace = "http://tempuri.org/")
    @RequestWrapper(localName = "Divide", targetNamespace = "http://tempuri.org/", className = "wcf.service.Divide")
    @ResponseWrapper(localName = "DivideResponse", targetNamespace = "http://tempuri.org/", className = "wcf.service.DivideResponse")
    public float divide(
        @WebParam(name = "a", targetNamespace = "http://tempuri.org/")
        int a,
        @WebParam(name = "b", targetNamespace = "http://tempuri.org/")
        int b);

    /**
     * 
     * @param celsius
     * @return
     *     returns double
     */
    @WebMethod(operationName = "CelsiusToFahrenheit", action = "http://tempuri.org/CelsiusToFahrenheit")
    @WebResult(name = "CelsiusToFahrenheitResult", targetNamespace = "http://tempuri.org/")
    @RequestWrapper(localName = "CelsiusToFahrenheit", targetNamespace = "http://tempuri.org/", className = "wcf.service.CelsiusToFahrenheit")
    @ResponseWrapper(localName = "CelsiusToFahrenheitResponse", targetNamespace = "http://tempuri.org/", className = "wcf.service.CelsiusToFahrenheitResponse")
    public double celsiusToFahrenheit(
        @WebParam(name = "celsius", targetNamespace = "http://tempuri.org/")
        double celsius);

    /**
     * 
     * @param fahrenheit
     * @return
     *     returns double
     */
    @WebMethod(operationName = "FahrenheitToCelsius", action = "http://tempuri.org/FahrenheitToCelsius")
    @WebResult(name = "FahrenheitToCelsiusResult", targetNamespace = "http://tempuri.org/")
    @RequestWrapper(localName = "FahrenheitToCelsius", targetNamespace = "http://tempuri.org/", className = "wcf.service.FahrenheitToCelsius")
    @ResponseWrapper(localName = "FahrenheitToCelsiusResponse", targetNamespace = "http://tempuri.org/", className = "wcf.service.FahrenheitToCelsiusResponse")
    public double fahrenheitToCelsius(
        @WebParam(name = "fahrenheit", targetNamespace = "http://tempuri.org/")
        double fahrenheit);

    /**
     * 
     * @param celsius
     * @return
     *     returns double
     */
    @WebMethod(operationName = "CelsiusToKelvin", action = "http://tempuri.org/CelsiusToKelvin")
    @WebResult(name = "CelsiusToKelvinResult", targetNamespace = "http://tempuri.org/")
    @RequestWrapper(localName = "CelsiusToKelvin", targetNamespace = "http://tempuri.org/", className = "wcf.service.CelsiusToKelvin")
    @ResponseWrapper(localName = "CelsiusToKelvinResponse", targetNamespace = "http://tempuri.org/", className = "wcf.service.CelsiusToKelvinResponse")
    public double celsiusToKelvin(
        @WebParam(name = "celsius", targetNamespace = "http://tempuri.org/")
        double celsius);

    /**
     * 
     * @param kelvin
     * @return
     *     returns double
     */
    @WebMethod(operationName = "KelvinToCelsius", action = "http://tempuri.org/KelvinToCelsius")
    @WebResult(name = "KelvinToCelsiusResult", targetNamespace = "http://tempuri.org/")
    @RequestWrapper(localName = "KelvinToCelsius", targetNamespace = "http://tempuri.org/", className = "wcf.service.KelvinToCelsius")
    @ResponseWrapper(localName = "KelvinToCelsiusResponse", targetNamespace = "http://tempuri.org/", className = "wcf.service.KelvinToCelsiusResponse")
    public double kelvinToCelsius(
        @WebParam(name = "kelvin", targetNamespace = "http://tempuri.org/")
        double kelvin);

    /**
     * 
     * @param numbers
     * @return
     *     returns int
     */
    @WebMethod(operationName = "Max", action = "http://tempuri.org/Max")
    @WebResult(name = "MaxResult", targetNamespace = "http://tempuri.org/")
    @RequestWrapper(localName = "Max", targetNamespace = "http://tempuri.org/", className = "wcf.service.Max")
    @ResponseWrapper(localName = "MaxResponse", targetNamespace = "http://tempuri.org/", className = "wcf.service.MaxResponse")
    public int max(
        @WebParam(name = "numbers", targetNamespace = "http://tempuri.org/")
        ArrayOfInt numbers);

    /**
     * 
     * @param number
     * @param numbers
     * @return
     *     returns int
     */
    @WebMethod(operationName = "GetIndex", action = "http://tempuri.org/GetIndex")
    @WebResult(name = "GetIndexResult", targetNamespace = "http://tempuri.org/")
    @RequestWrapper(localName = "GetIndex", targetNamespace = "http://tempuri.org/", className = "wcf.service.GetIndex")
    @ResponseWrapper(localName = "GetIndexResponse", targetNamespace = "http://tempuri.org/", className = "wcf.service.GetIndexResponse")
    public int getIndex(
        @WebParam(name = "numbers", targetNamespace = "http://tempuri.org/")
        ArrayOfInt numbers,
        @WebParam(name = "number", targetNamespace = "http://tempuri.org/")
        int number);

    /**
     * 
     * @return
     *     returns java.lang.String
     */
    @WebMethod(operationName = "HelloWorld", action = "http://tempuri.org/HelloWorld")
    @WebResult(name = "HelloWorldResult", targetNamespace = "http://tempuri.org/")
    @RequestWrapper(localName = "HelloWorld", targetNamespace = "http://tempuri.org/", className = "wcf.service.HelloWorld")
    @ResponseWrapper(localName = "HelloWorldResponse", targetNamespace = "http://tempuri.org/", className = "wcf.service.HelloWorldResponse")
    public String helloWorld();

    /**
     * 
     * @param text
     * @return
     *     returns java.lang.String
     */
    @WebMethod(operationName = "Reverse", action = "http://tempuri.org/Reverse")
    @WebResult(name = "ReverseResult", targetNamespace = "http://tempuri.org/")
    @RequestWrapper(localName = "Reverse", targetNamespace = "http://tempuri.org/", className = "wcf.service.Reverse")
    @ResponseWrapper(localName = "ReverseResponse", targetNamespace = "http://tempuri.org/", className = "wcf.service.ReverseResponse")
    public String reverse(
        @WebParam(name = "text", targetNamespace = "http://tempuri.org/")
        String text);

    /**
     * 
     * @param numbers
     * @return
     *     returns double
     */
    @WebMethod(operationName = "Average", action = "http://tempuri.org/Average")
    @WebResult(name = "AverageResult", targetNamespace = "http://tempuri.org/")
    @RequestWrapper(localName = "Average", targetNamespace = "http://tempuri.org/", className = "wcf.service.Average")
    @ResponseWrapper(localName = "AverageResponse", targetNamespace = "http://tempuri.org/", className = "wcf.service.AverageResponse")
    public double average(
        @WebParam(name = "numbers", targetNamespace = "http://tempuri.org/")
        ArrayOfInt numbers);

}
