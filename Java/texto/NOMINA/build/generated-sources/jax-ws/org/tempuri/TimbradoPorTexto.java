
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
 *         &lt;element name="correo" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *         &lt;element name="pass" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *         &lt;element name="rfc" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *         &lt;element name="cerFile" type="{http://www.w3.org/2001/XMLSchema}base64Binary" minOccurs="0"/>
 *         &lt;element name="keyFile" type="{http://www.w3.org/2001/XMLSchema}base64Binary" minOccurs="0"/>
 *         &lt;element name="passCer" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *         &lt;element name="contenidoArchivo" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *         &lt;element name="pdf" type="{http://www.w3.org/2001/XMLSchema}boolean"/>
 *         &lt;element name="ambiente" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
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
    "correo",
    "pass",
    "rfc",
    "cerFile",
    "keyFile",
    "passCer",
    "contenidoArchivo",
    "pdf",
    "ambiente"
})
@XmlRootElement(name = "timbradoPorTexto")
public class TimbradoPorTexto {

    protected String correo;
    protected String pass;
    protected String rfc;
    protected byte[] cerFile;
    protected byte[] keyFile;
    protected String passCer;
    protected String contenidoArchivo;
    protected boolean pdf;
    protected String ambiente;

    /**
     * Obtiene el valor de la propiedad correo.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getCorreo() {
        return correo;
    }

    /**
     * Define el valor de la propiedad correo.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setCorreo(String value) {
        this.correo = value;
    }

    /**
     * Obtiene el valor de la propiedad pass.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getPass() {
        return pass;
    }

    /**
     * Define el valor de la propiedad pass.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setPass(String value) {
        this.pass = value;
    }

    /**
     * Obtiene el valor de la propiedad rfc.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getRfc() {
        return rfc;
    }

    /**
     * Define el valor de la propiedad rfc.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setRfc(String value) {
        this.rfc = value;
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
     * Obtiene el valor de la propiedad passCer.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getPassCer() {
        return passCer;
    }

    /**
     * Define el valor de la propiedad passCer.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setPassCer(String value) {
        this.passCer = value;
    }

    /**
     * Obtiene el valor de la propiedad contenidoArchivo.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getContenidoArchivo() {
        return contenidoArchivo;
    }

    /**
     * Define el valor de la propiedad contenidoArchivo.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setContenidoArchivo(String value) {
        this.contenidoArchivo = value;
    }

    /**
     * Obtiene el valor de la propiedad pdf.
     * 
     */
    public boolean isPdf() {
        return pdf;
    }

    /**
     * Define el valor de la propiedad pdf.
     * 
     */
    public void setPdf(boolean value) {
        this.pdf = value;
    }

    /**
     * Obtiene el valor de la propiedad ambiente.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getAmbiente() {
        return ambiente;
    }

    /**
     * Define el valor de la propiedad ambiente.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setAmbiente(String value) {
        this.ambiente = value;
    }

}
