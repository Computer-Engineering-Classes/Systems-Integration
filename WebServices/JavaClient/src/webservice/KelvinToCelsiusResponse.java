
package webservice;

import jakarta.xml.bind.annotation.XmlAccessType;
import jakarta.xml.bind.annotation.XmlAccessorType;
import jakarta.xml.bind.annotation.XmlElement;
import jakarta.xml.bind.annotation.XmlRootElement;
import jakarta.xml.bind.annotation.XmlType;


/**
 * <p>Java class for anonymous complex type.
 * 
 * <p>The following schema fragment specifies the expected content contained within this class.
 * 
 * <pre>
 * &lt;complexType&gt;
 *   &lt;complexContent&gt;
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType"&gt;
 *       &lt;sequence&gt;
 *         &lt;element name="KelvinToCelsiusResult" type="{http://www.w3.org/2001/XMLSchema}double" minOccurs="0"/&gt;
 *       &lt;/sequence&gt;
 *     &lt;/restriction&gt;
 *   &lt;/complexContent&gt;
 * &lt;/complexType&gt;
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
