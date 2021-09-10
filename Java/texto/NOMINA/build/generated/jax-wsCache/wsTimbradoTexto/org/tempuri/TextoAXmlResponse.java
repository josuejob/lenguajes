
package org.tempuri;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Clase Java para anonymous complex type.
 * 
 * <p>El siguiente fragmento de esquema especifica el contenido que se espera que haya en esta clase.
 * 
 * <pre>
 * &lt;complexType>
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="TextoAXmlResult" type="{http://tempuri.org/}resultado" minOccurs="0"/>
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
    "textoAXmlResult"
})
@XmlRootElement(name = "TextoAXmlResponse")
public class TextoAXmlResponse {

    @XmlElement(name = "TextoAXmlResult")
    protected Resultado textoAXmlResult;

    /**
     * Obtiene el valor de la propiedad textoAXmlResult.
     * 
     * @return
     *     possible object is
     *     {@link Resultado }
     *     
     */
    public Resultado getTextoAXmlResult() {
        return textoAXmlResult;
    }

    /**
     * Define el valor de la propiedad textoAXmlResult.
     * 
     * @param value
     *     allowed object is
     *     {@link Resultado }
     *     
     */
    public void setTextoAXmlResult(Resultado value) {
        this.textoAXmlResult = value;
    }

}
