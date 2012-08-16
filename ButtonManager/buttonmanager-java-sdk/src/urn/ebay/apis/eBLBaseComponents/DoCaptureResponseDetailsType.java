package urn.ebay.apis.eBLBaseComponents;
import urn.ebay.apis.eBLBaseComponents.PaymentInfoType;
import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.parsers.ParserConfigurationException;
import org.w3c.dom.Document;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;
import org.w3c.dom.NamedNodeMap;
import java.io.FileInputStream;
import java.io.StringReader;
import java.io.IOException;
import org.xml.sax.InputSource;
import org.xml.sax.SAXException;

/**
 * The authorization identification number you specified in the
 * request. Character length and limits: 19 single-byte
 * characters maximum 
 */
public class DoCaptureResponseDetailsType{


	/**
	 * The authorization identification number you specified in the
	 * request. Character length and limits: 19 single-byte
	 * characters maximum	 
	 */ 
	private String AuthorizationID;

	/**
	 * Information about the transaction 	 
	 */ 
	private PaymentInfoType PaymentInfo;

	/**
	 * Return msgsubid back to merchant 	 
	 */ 
	private String MsgSubID;

	

	/**
	 * Default Constructor
	 */
	public DoCaptureResponseDetailsType (){
	}	

	/**
	 * Getter for AuthorizationID
	 */
	 public String getAuthorizationID() {
	 	return AuthorizationID;
	 }
	 
	/**
	 * Setter for AuthorizationID
	 */
	 public void setAuthorizationID(String AuthorizationID) {
	 	this.AuthorizationID = AuthorizationID;
	 }
	 
	/**
	 * Getter for PaymentInfo
	 */
	 public PaymentInfoType getPaymentInfo() {
	 	return PaymentInfo;
	 }
	 
	/**
	 * Setter for PaymentInfo
	 */
	 public void setPaymentInfo(PaymentInfoType PaymentInfo) {
	 	this.PaymentInfo = PaymentInfo;
	 }
	 
	/**
	 * Getter for MsgSubID
	 */
	 public String getMsgSubID() {
	 	return MsgSubID;
	 }
	 
	/**
	 * Setter for MsgSubID
	 */
	 public void setMsgSubID(String MsgSubID) {
	 	this.MsgSubID = MsgSubID;
	 }
	 


	private  boolean isWhitespaceNode(Node n) {
		if (n.getNodeType() == Node.TEXT_NODE) {
			String val = n.getNodeValue();
			return val.trim().length() == 0;
		} else if (n.getNodeType() == Node.ELEMENT_NODE ){
			return (n.getChildNodes().getLength() == 0);
		} else {
			return false;
		}
	}
	
	private String convertToXML(Node n){
		String name = n.getNodeName();
		short type = n.getNodeType();
		if (Node.CDATA_SECTION_NODE == type) {
			return "<![CDATA[" + n.getNodeValue() + "]]&gt;";
		}
		if (name.startsWith("#")) {
			return "";
		}
		StringBuffer sb = new StringBuffer();
		sb.append("<").append(name);
		NamedNodeMap attrs = n.getAttributes();
		if (attrs != null) {
			for (int i = 0; i < attrs.getLength(); i++) {
				Node attr = attrs.item(i);
				sb.append(" ").append(attr.getNodeName()).append("=\"").append(attr.getNodeValue()).append("\"");
			}
		}
		String textContent = null;
		NodeList children = n.getChildNodes();
		if (children.getLength() == 0) {
			if (((textContent = n.getTextContent())) != null && (!"".equals(textContent))) {
				sb.append(textContent).append("</").append(name).append(">");
			} else {
				sb.append("/>");
			}
		} else {
			sb.append(">");
			boolean hasValidChildren = false;
			for (int i = 0; i < children.getLength(); i++) {
				String childToString = convertToXML(children.item(i));
				if (!"".equals(childToString)) {
					sb.append(childToString);
					hasValidChildren = true;
				}
			}
			if (!hasValidChildren && ((textContent = n.getTextContent()) != null)) {
				sb.append(textContent);
			}
			sb.append("</").append(name).append(">");
		}
		return sb.toString();
	}
	
	public DoCaptureResponseDetailsType(Object xmlSoap) throws IOException, SAXException, ParserConfigurationException {
		DocumentBuilderFactory builderFactory = DocumentBuilderFactory.newInstance();
		DocumentBuilder builder = builderFactory.newDocumentBuilder();
		InputSource inStream = new InputSource();
		inStream.setCharacterStream(new StringReader((String)xmlSoap));
		Document document = builder.parse(inStream);
		NodeList nodeList= null;
		
		String xmlString = "";
		if (document.getElementsByTagName("AuthorizationID").getLength() != 0) {
			if(!isWhitespaceNode(document.getElementsByTagName("AuthorizationID").item(0))) {
				this.AuthorizationID = (String)document.getElementsByTagName("AuthorizationID").item(0).getTextContent();
			}
		}
	
		if(document.getElementsByTagName("PaymentInfo").getLength()!=0) {
			if(!isWhitespaceNode(document.getElementsByTagName("PaymentInfo").item(0))) {
				nodeList = document.getElementsByTagName("PaymentInfo");
				xmlString = convertToXML(nodeList.item(0));
				this.PaymentInfo =  new PaymentInfoType(xmlString);
			}
		}
		if (document.getElementsByTagName("MsgSubID").getLength() != 0) {
			if(!isWhitespaceNode(document.getElementsByTagName("MsgSubID").item(0))) {
				this.MsgSubID = (String)document.getElementsByTagName("MsgSubID").item(0).getTextContent();
			}
		}
	
	}
 
}