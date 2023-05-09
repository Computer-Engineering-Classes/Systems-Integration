
package org.service;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
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
 *         &lt;element name="CelsiusToKelvinResult" type="{http://www.w3.org/2001/XMLSchema}double"/>
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
    "celsiusToKelvinResult"
})
@XmlRootElement(name = "CelsiusToKelvinResponse")
public class CelsiusToKelvinResponse {

    @XmlElement(name = "CelsiusToKelvinResult")
    protected double celsiusToKelvinResult;

    /**
     * Gets the value of the celsiusToKelvinResult property.
     * 
     */
    public double getCelsiusToKelvinResult() {
        return celsiusToKelvinResult;
    }

    /**
     * Sets the value of the celsiusToKelvinResult property.
     * 
     */
    public void setCelsiusToKelvinResult(double value) {
        this.celsiusToKelvinResult = value;
    }

}
