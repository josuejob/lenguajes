
package org.tempuri;

import java.util.ArrayList;
import java.util.List;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlType;
import com.certus.facturehoy.ws2.cfdi.WsItemCancelacionObj;


/**
 * <p>Clase Java para ArrayOfWsItemCancelacionObj complex type.
 * 
 * <p>El siguiente fragmento de esquema especifica el contenido que se espera que haya en esta clase.
 * 
 * <pre>
 * &lt;complexType name="ArrayOfWsItemCancelacionObj">
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="wsItemCancelacionObj" type="{http://cfdi.ws2.facturehoy.certus.com/}wsItemCancelacionObj" maxOccurs="unbounded" minOccurs="0"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "ArrayOfWsItemCancelacionObj", propOrder = {
    "wsItemCancelacionObj"
})
public class ArrayOfWsItemCancelacionObj {

    @XmlElement(nillable = true)
    protected List<WsItemCancelacionObj> wsItemCancelacionObj;

    /**
     * Gets the value of the wsItemCancelacionObj property.
     * 
     * <p>
     * This accessor method returns a reference to the live list,
     * not a snapshot. Therefore any modification you make to the
     * returned list will be present inside the JAXB object.
     * This is why there is not a <CODE>set</CODE> method for the wsItemCancelacionObj property.
     * 
     * <p>
     * For example, to add a new item, do as follows:
     * <pre>
     *    getWsItemCancelacionObj().add(newItem);
     * </pre>
     * 
     * 
     * <p>
     * Objects of the following type(s) are allowed in the list
     * {@link WsItemCancelacionObj }
     * 
     * 
     */
    public List<WsItemCancelacionObj> getWsItemCancelacionObj() {
        if (wsItemCancelacionObj == null) {
            wsItemCancelacionObj = new ArrayList<WsItemCancelacionObj>();
        }
        return this.wsItemCancelacionObj;
    }

}
