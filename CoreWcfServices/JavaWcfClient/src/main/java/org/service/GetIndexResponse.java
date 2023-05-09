
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
 *         &lt;element name="GetIndexResult" type="{http://www.w3.org/2001/XMLSchema}int"/>
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
    "getIndexResult"
})
@XmlRootElement(name = "GetIndexResponse")
public class GetIndexResponse {

    @XmlElement(name = "GetIndexResult")
    protected int getIndexResult;

    /**
     * Gets the value of the getIndexResult property.
     * 
     */
    public int getGetIndexResult() {
        return getIndexResult;
    }

    /**
     * Sets the value of the getIndexResult property.
     * 
     */
    public void setGetIndexResult(int value) {
        this.getIndexResult = value;
    }

}
