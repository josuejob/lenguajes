
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
 *         &lt;element name="SellarTimbrar33Result" type="{www.facturaselectronicascfdi.com}resultado33" minOccurs="0"/>
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
    "sellarTimbrar33Result"
})
@XmlRootElement(name = "SellarTimbrar33Response")
public class SellarTimbrar33Response {

    @XmlElement(name = "SellarTimbrar33Result")
    protected Resultado33 sellarTimbrar33Result;

    /**
     * Obtiene el valor de la propiedad sellarTimbrar33Result.
     * 
     * @return
     *     possible object is
     *     {@link Resultado33 }
     *     
     */
    public Resultado33 getSellarTimbrar33Result() {
        return sellarTimbrar33Result;
    }

    /**
     * Define el valor de la propiedad sellarTimbrar33Result.
     * 
     * @param value
     *     allowed object is
     *     {@link Resultado33 }
     *     
     */
    public void setSellarTimbrar33Result(Resultado33 value) {
        this.sellarTimbrar33Result = value;
    }

}
