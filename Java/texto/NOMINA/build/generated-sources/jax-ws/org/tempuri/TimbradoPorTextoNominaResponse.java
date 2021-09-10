
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
 *         &lt;element name="timbradoPorTextoNominaResult" type="{http://tempuri.org/}resultado" minOccurs="0"/>
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
    "timbradoPorTextoNominaResult"
})
@XmlRootElement(name = "timbradoPorTextoNominaResponse")
public class TimbradoPorTextoNominaResponse {

    protected Resultado timbradoPorTextoNominaResult;

    /**
     * Obtiene el valor de la propiedad timbradoPorTextoNominaResult.
     * 
     * @return
     *     possible object is
     *     {@link Resultado }
     *     
     */
    public Resultado getTimbradoPorTextoNominaResult() {
        return timbradoPorTextoNominaResult;
    }

    /**
     * Define el valor de la propiedad timbradoPorTextoNominaResult.
     * 
     * @param value
     *     allowed object is
     *     {@link Resultado }
     *     
     */
    public void setTimbradoPorTextoNominaResult(Resultado value) {
        this.timbradoPorTextoNominaResult = value;
    }

}
