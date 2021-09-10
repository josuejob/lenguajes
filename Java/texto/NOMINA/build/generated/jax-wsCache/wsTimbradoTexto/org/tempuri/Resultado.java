
package org.tempuri;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlSchemaType;
import javax.xml.bind.annotation.XmlType;
import javax.xml.datatype.XMLGregorianCalendar;


/**
 * <p>Clase Java para resultado complex type.
 * 
 * <p>El siguiente fragmento de esquema especifica el contenido que se espera que haya en esta clase.
 * 
 * <pre>
 * &lt;complexType name="resultado">
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="sello" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *         &lt;element name="errores" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *         &lt;element name="xmlSellado" type="{http://www.w3.org/2001/XMLSchema}base64Binary" minOccurs="0"/>
 *         &lt;element name="acuse" type="{http://www.w3.org/2001/XMLSchema}base64Binary" minOccurs="0"/>
 *         &lt;element name="arrayFolios" type="{http://tempuri.org/}ArrayOfWsItemCancelacionObj" minOccurs="0"/>
 *         &lt;element name="arregloAcuse" type="{http://tempuri.org/}ArrayOfBase64Binary" minOccurs="0"/>
 *         &lt;element name="cadenaOriginal" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *         &lt;element name="fechaHoraTimbrado" type="{http://www.w3.org/2001/XMLSchema}dateTime" minOccurs="0"/>
 *         &lt;element name="fechaHoraTimbradoSpecified" type="{http://www.w3.org/2001/XMLSchema}boolean"/>
 *         &lt;element name="folioUUID" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *         &lt;element name="PDF" type="{http://www.w3.org/2001/XMLSchema}base64Binary" minOccurs="0"/>
 *         &lt;element name="selloDigitalEmisor" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *         &lt;element name="selloDigitalTimbreSAT" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *         &lt;element name="XML" type="{http://www.w3.org/2001/XMLSchema}base64Binary" minOccurs="0"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "resultado", propOrder = {
    "sello",
    "errores",
    "xmlSellado",
    "acuse",
    "arrayFolios",
    "arregloAcuse",
    "cadenaOriginal",
    "fechaHoraTimbrado",
    "fechaHoraTimbradoSpecified",
    "folioUUID",
    "pdf",
    "selloDigitalEmisor",
    "selloDigitalTimbreSAT",
    "xml"
})
public class Resultado {

    protected String sello;
    protected String errores;
    protected byte[] xmlSellado;
    protected byte[] acuse;
    protected ArrayOfWsItemCancelacionObj arrayFolios;
    protected ArrayOfBase64Binary arregloAcuse;
    protected String cadenaOriginal;
    @XmlSchemaType(name = "dateTime")
    protected XMLGregorianCalendar fechaHoraTimbrado;
    protected boolean fechaHoraTimbradoSpecified;
    protected String folioUUID;
    @XmlElement(name = "PDF")
    protected byte[] pdf;
    protected String selloDigitalEmisor;
    protected String selloDigitalTimbreSAT;
    @XmlElement(name = "XML")
    protected byte[] xml;

    /**
     * Obtiene el valor de la propiedad sello.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getSello() {
        return sello;
    }

    /**
     * Define el valor de la propiedad sello.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setSello(String value) {
        this.sello = value;
    }

    /**
     * Obtiene el valor de la propiedad errores.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getErrores() {
        return errores;
    }

    /**
     * Define el valor de la propiedad errores.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setErrores(String value) {
        this.errores = value;
    }

    /**
     * Obtiene el valor de la propiedad xmlSellado.
     * 
     * @return
     *     possible object is
     *     byte[]
     */
    public byte[] getXmlSellado() {
        return xmlSellado;
    }

    /**
     * Define el valor de la propiedad xmlSellado.
     * 
     * @param value
     *     allowed object is
     *     byte[]
     */
    public void setXmlSellado(byte[] value) {
        this.xmlSellado = value;
    }

    /**
     * Obtiene el valor de la propiedad acuse.
     * 
     * @return
     *     possible object is
     *     byte[]
     */
    public byte[] getAcuse() {
        return acuse;
    }

    /**
     * Define el valor de la propiedad acuse.
     * 
     * @param value
     *     allowed object is
     *     byte[]
     */
    public void setAcuse(byte[] value) {
        this.acuse = value;
    }

    /**
     * Obtiene el valor de la propiedad arrayFolios.
     * 
     * @return
     *     possible object is
     *     {@link ArrayOfWsItemCancelacionObj }
     *     
     */
    public ArrayOfWsItemCancelacionObj getArrayFolios() {
        return arrayFolios;
    }

    /**
     * Define el valor de la propiedad arrayFolios.
     * 
     * @param value
     *     allowed object is
     *     {@link ArrayOfWsItemCancelacionObj }
     *     
     */
    public void setArrayFolios(ArrayOfWsItemCancelacionObj value) {
        this.arrayFolios = value;
    }

    /**
     * Obtiene el valor de la propiedad arregloAcuse.
     * 
     * @return
     *     possible object is
     *     {@link ArrayOfBase64Binary }
     *     
     */
    public ArrayOfBase64Binary getArregloAcuse() {
        return arregloAcuse;
    }

    /**
     * Define el valor de la propiedad arregloAcuse.
     * 
     * @param value
     *     allowed object is
     *     {@link ArrayOfBase64Binary }
     *     
     */
    public void setArregloAcuse(ArrayOfBase64Binary value) {
        this.arregloAcuse = value;
    }

    /**
     * Obtiene el valor de la propiedad cadenaOriginal.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getCadenaOriginal() {
        return cadenaOriginal;
    }

    /**
     * Define el valor de la propiedad cadenaOriginal.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setCadenaOriginal(String value) {
        this.cadenaOriginal = value;
    }

    /**
     * Obtiene el valor de la propiedad fechaHoraTimbrado.
     * 
     * @return
     *     possible object is
     *     {@link XMLGregorianCalendar }
     *     
     */
    public XMLGregorianCalendar getFechaHoraTimbrado() {
        return fechaHoraTimbrado;
    }

    /**
     * Define el valor de la propiedad fechaHoraTimbrado.
     * 
     * @param value
     *     allowed object is
     *     {@link XMLGregorianCalendar }
     *     
     */
    public void setFechaHoraTimbrado(XMLGregorianCalendar value) {
        this.fechaHoraTimbrado = value;
    }

    /**
     * Obtiene el valor de la propiedad fechaHoraTimbradoSpecified.
     * 
     */
    public boolean isFechaHoraTimbradoSpecified() {
        return fechaHoraTimbradoSpecified;
    }

    /**
     * Define el valor de la propiedad fechaHoraTimbradoSpecified.
     * 
     */
    public void setFechaHoraTimbradoSpecified(boolean value) {
        this.fechaHoraTimbradoSpecified = value;
    }

    /**
     * Obtiene el valor de la propiedad folioUUID.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getFolioUUID() {
        return folioUUID;
    }

    /**
     * Define el valor de la propiedad folioUUID.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setFolioUUID(String value) {
        this.folioUUID = value;
    }

    /**
     * Obtiene el valor de la propiedad pdf.
     * 
     * @return
     *     possible object is
     *     byte[]
     */
    public byte[] getPDF() {
        return pdf;
    }

    /**
     * Define el valor de la propiedad pdf.
     * 
     * @param value
     *     allowed object is
     *     byte[]
     */
    public void setPDF(byte[] value) {
        this.pdf = value;
    }

    /**
     * Obtiene el valor de la propiedad selloDigitalEmisor.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getSelloDigitalEmisor() {
        return selloDigitalEmisor;
    }

    /**
     * Define el valor de la propiedad selloDigitalEmisor.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setSelloDigitalEmisor(String value) {
        this.selloDigitalEmisor = value;
    }

    /**
     * Obtiene el valor de la propiedad selloDigitalTimbreSAT.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getSelloDigitalTimbreSAT() {
        return selloDigitalTimbreSAT;
    }

    /**
     * Define el valor de la propiedad selloDigitalTimbreSAT.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setSelloDigitalTimbreSAT(String value) {
        this.selloDigitalTimbreSAT = value;
    }

    /**
     * Obtiene el valor de la propiedad xml.
     * 
     * @return
     *     possible object is
     *     byte[]
     */
    public byte[] getXML() {
        return xml;
    }

    /**
     * Define el valor de la propiedad xml.
     * 
     * @param value
     *     allowed object is
     *     byte[]
     */
    public void setXML(byte[] value) {
        this.xml = value;
    }

}
