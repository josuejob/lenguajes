
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
 *         &lt;element name="SellarTimbrarPorTexto33Result" type="{www.facturaselectronicascfdi.com}resultado33" minOccurs="0"/>
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
    "sellarTimbrarPorTexto33Result"
})
@XmlRootElement(name = "SellarTimbrarPorTexto33Response")
public class SellarTimbrarPorTexto33Response {

    @XmlElement(name = "SellarTimbrarPorTexto33Result")
    protected Resultado33 sellarTimbrarPorTexto33Result;

    /**
     * Obtiene el valor de la propiedad sellarTimbrarPorTexto33Result.
     * 
     * @return
     *     possible object is
     *     {@link Resultado33 }
     *     
     */
    public Resultado33 getSellarTimbrarPorTexto33Result() {
        return sellarTimbrarPorTexto33Result;
    }

    /**
     * Define el valor de la propiedad sellarTimbrarPorTexto33Result.
     * 
     * @param value
     *     allowed object is
     *     {@link Resultado33 }
     *     
     */
    public void setSellarTimbrarPorTexto33Result(Resultado33 value) {
        this.sellarTimbrarPorTexto33Result = value;
    }

}
