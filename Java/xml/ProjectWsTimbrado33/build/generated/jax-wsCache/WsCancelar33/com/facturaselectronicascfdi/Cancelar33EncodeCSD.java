
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
 *         &lt;element name="curCorreo" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *         &lt;element name="password" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *         &lt;element name="RfcEmisor" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *         &lt;element name="UUID" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *         &lt;element name="CerFile" type="{http://www.w3.org/2001/XMLSchema}base64Binary" minOccurs="0"/>
 *         &lt;element name="KeyEncode64" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
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
    "curCorreo",
    "password",
    "rfcEmisor",
    "uuid",
    "cerFile",
    "keyEncode64"
})
@XmlRootElement(name = "Cancelar33EncodeCSD")
public class Cancelar33EncodeCSD {

    protected String curCorreo;
    protected String password;
    @XmlElement(name = "RfcEmisor")
    protected String rfcEmisor;
    @XmlElement(name = "UUID")
    protected String uuid;
    @XmlElement(name = "CerFile")
    protected byte[] cerFile;
    @XmlElement(name = "KeyEncode64")
    protected String keyEncode64;

    /**
     * Obtiene el valor de la propiedad curCorreo.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getCurCorreo() {
        return curCorreo;
    }

    /**
     * Define el valor de la propiedad curCorreo.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setCurCorreo(String value) {
        this.curCorreo = value;
    }

    /**
     * Obtiene el valor de la propiedad password.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getPassword() {
        return password;
    }

    /**
     * Define el valor de la propiedad password.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setPassword(String value) {
        this.password = value;
    }

    /**
     * Obtiene el valor de la propiedad rfcEmisor.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getRfcEmisor() {
        return rfcEmisor;
    }

    /**
     * Define el valor de la propiedad rfcEmisor.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setRfcEmisor(String value) {
        this.rfcEmisor = value;
    }

    /**
     * Obtiene el valor de la propiedad uuid.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getUUID() {
        return uuid;
    }

    /**
     * Define el valor de la propiedad uuid.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setUUID(String value) {
        this.uuid = value;
    }

    /**
     * Obtiene el valor de la propiedad cerFile.
     * 
     * @return
     *     possible object is
     *     byte[]
     */
    public byte[] getCerFile() {
        return cerFile;
    }

    /**
     * Define el valor de la propiedad cerFile.
     * 
     * @param value
     *     allowed object is
     *     byte[]
     */
    public void setCerFile(byte[] value) {
        this.cerFile = value;
    }

    /**
     * Obtiene el valor de la propiedad keyEncode64.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getKeyEncode64() {
        return keyEncode64;
    }

    /**
     * Define el valor de la propiedad keyEncode64.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setKeyEncode64(String value) {
        this.keyEncode64 = value;
    }

}
