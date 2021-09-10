
package com.facturaselectronicascfdi;

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
 *         &lt;element name="Cancelar33EncodeCSDResult" type="{www.facturaselectronicascfdi.com}resultado33" minOccurs="0"/>
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
    "cancelar33EncodeCSDResult"
})
@XmlRootElement(name = "Cancelar33EncodeCSDResponse")
public class Cancelar33EncodeCSDResponse {

    @XmlElement(name = "Cancelar33EncodeCSDResult")
    protected Resultado33 cancelar33EncodeCSDResult;

    /**
     * Obtiene el valor de la propiedad cancelar33EncodeCSDResult.
     * 
     * @return
     *     possible object is
     *     {@link Resultado33 }
     *     
     */
    public Resultado33 getCancelar33EncodeCSDResult() {
        return cancelar33EncodeCSDResult;
    }

    /**
     * Define el valor de la propiedad cancelar33EncodeCSDResult.
     * 
     * @param value
     *     allowed object is
     *     {@link Resultado33 }
     *     
     */
    public void setCancelar33EncodeCSDResult(Resultado33 value) {
        this.cancelar33EncodeCSDResult = value;
    }

}
