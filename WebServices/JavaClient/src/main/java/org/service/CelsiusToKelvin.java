
package org.service;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for anonymous complex type.
 * 
 * <p>The following schema fragment specifies the expected content contained within this class.
 * 
 * <pre>
 * &lt;complexType>
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="celsius" type="{http://www.w3.org/2001/XMLSchema}double" minOccurs="0"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "", propOrder = {
    "celsius"
})
@XmlRootElement(name = "CelsiusToKelvin")
public class CelsiusToKelvin {

    protected Double celsius;

    /**
     * Gets the value of the celsius property.
     * 
     * @return
     *     possible object is
     *     {@link Double }
     *     
     */
    public Double getCelsius() {
        return celsius;
    }

    /**
     * Sets the value of the celsius property.
     * 
     * @param value
     *     allowed object is
     *     {@link Double }
     *     
     */
    public void setCelsius(Double value) {
        this.celsius = value;
    }

}
