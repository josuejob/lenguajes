
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
 *         &lt;element name="xml" type="{http://www.w3.org/2001/XMLSchema}base64Binary" minOccurs="0"/>
 *         &lt;element name="Proceso" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *         &lt;element name="CerFile" type="{http://www.w3.org/2001/XMLSchema}base64Binary" minOccurs="0"/>
 *         &lt;element name="KeyFile" type="{http://www.w3.org/2001/XMLSchema}base64Binary" minOccurs="0"/>
 *         &lt;element name="PassCsd" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
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
    "xml",
    "proceso",
    "cerFile",
    "keyFile",
    "passCsd"
})
@XmlRootElement(name = "SellarTimbrar33")
public class SellarTimbrar33 {

    protected String curCorreo;
    protected String password;
    protected byte[] xml;
    @XmlElement(name = "Proceso")
    protected String proceso;
    @XmlElement(name = "CerFile")
    protected byte[] cerFile;
    @XmlElement(name = "KeyFile")
    protected byte[] keyFile;
    @XmlElement(name = "PassCsd")
    protected String passCsd;

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
     * Obtiene el valor de la propiedad xml.
     * 
     * @return
     *     possible object is
     *     byte[]
     */
    public byte[] getXml() {
        return xml;
    }

    /**
     * Define el valor de la propiedad xml.
     * 
     * @param value
     *     allowed object is
     *     byte[]
     */
    public void setXml(byte[] value) {
        this.xml = value;
    }

    /**
     * Obtiene el valor de la propiedad proceso.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getProceso() {
        return proceso;
    }

    /**
     * Define el valor de la propiedad proceso.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setProceso(String value) {
        this.proceso = value;
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
     * Obtiene el valor de la propiedad keyFile.
     * 
     * @return
     *     possible object is
     *     byte[]
     */
    public byte[] getKeyFile() {
        return keyFile;
    }

    /**
     * Define el valor de la propiedad keyFile.
     * 
     * @param value
     *     allowed object is
     *     byte[]
     */
    public void setKeyFile(byte[] value) {
        this.keyFile = value;
    }

    /**
     * Obtiene el valor de la propiedad passCsd.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getPassCsd() {
        return passCsd;
    }

    /**
     * Define el valor de la propiedad passCsd.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setPassCsd(String value) {
        this.passCsd = value;
    }

}
