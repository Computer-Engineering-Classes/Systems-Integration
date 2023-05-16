
package webservice;

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
 *         &lt;element name="KelvinToCelsiusResult" type="{http://www.w3.org/2001/XMLSchema}double" minOccurs="0"/>
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
    "kelvinToCelsiusResult"
})
@XmlRootElement(name = "KelvinToCelsiusResponse")
public class KelvinToCelsiusResponse {

    @XmlElement(name = "KelvinToCelsiusResult")
    protected Double kelvinToCelsiusResult;

    /**
     * Gets the value of the kelvinToCelsiusResult property.
     * 
     * @return
     *     possible object is
     *     {@link Double }
     *     
     */
    public Double getKelvinToCelsiusResult() {
        return kelvinToCelsiusResult;
    }

    /**
     * Sets the value of the kelvinToCelsiusResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link Double }
     *     
     */
    public void setKelvinToCelsiusResult(Double value) {
        this.kelvinToCelsiusResult = value;
    }

}
