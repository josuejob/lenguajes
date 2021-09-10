
package org.tempuri;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
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
 *         &lt;element name="timbradoPorTextoResult" type="{http://tempuri.org/}resultado" minOccurs="0"/>
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
    "timbradoPorTextoResult"
})
@XmlRootElement(name = "timbradoPorTextoResponse")
public class TimbradoPorTextoResponse {

    protected Resultado timbradoPorTextoResult;

    /**
     * Obtiene el valor de la propiedad timbradoPorTextoResult.
     * 
     * @return
     *     possible object is
     *     {@link Resultado }
     *     
     */
    public Resultado getTimbradoPorTextoResult() {
        return timbradoPorTextoResult;
    }

    /**
     * Define el valor de la propiedad timbradoPorTextoResult.
     * 
     * @param value
     *     allowed object is
     *     {@link Resultado }
     *     
     */
    public void setTimbradoPorTextoResult(Resultado value) {
        this.timbradoPorTextoResult = value;
    }

}
