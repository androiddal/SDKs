
/**
 * Auto generated code
 */

package urn.ebay.apis.eBLBaseComponents;

import java.io.FileInputStream;
import java.io.IOException;
import java.io.StringReader;
import java.util.ArrayList;
import java.util.List;
import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.parsers.ParserConfigurationException;
import org.w3c.dom.Document;
import org.w3c.dom.NamedNodeMap;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;
import org.xml.sax.InputSource;
import org.xml.sax.SAXException;
import urn.ebay.apis.eBLBaseComponents.AckCodeType;
import urn.ebay.apis.eBLBaseComponents.ErrorType;


/**
 * Base type definition of a response payload that can carry any 
 * type of payload content with following optional elements:
 * - timestamp of response message, 
 * - application level acknowledgement, and 
 * - application-level errors and warnings.
 */
public class AbstractResponseType {

	/**
	 * This value represents the date and time (GMT) when the response 
	 * was generated by a service provider (as a result of processing 
	 * of a request). 
	 */
	private String Timestamp;
	public String getTimestamp() {
		return Timestamp;
	}
	public void setTimestamp(String value) {
		this.Timestamp = value;
	}

	/**
	 * Application level acknowledgement code.
	 */
	private AckCodeType Ack;
	public AckCodeType getAck() {
		return Ack;
	}
	public void setAck(AckCodeType value) {
		this.Ack = value;
	}

	/**
	 * CorrelationID may be used optionally with an application 
	 * level acknowledgement.
	 */
	private String CorrelationID;
	public String getCorrelationID() {
		return CorrelationID;
	}
	public void setCorrelationID(String value) {
		this.CorrelationID = value;
	}

	/**
	 */
	private List<ErrorType> Errors = new ArrayList<ErrorType>();
	public List<ErrorType> getErrors() {
		return Errors;
	}
	public void setErrors(List<ErrorType> value) {
		this.Errors = value;
	}

	/**
	 * This refers to the version of the response payload schema.
	 */
	private String Version;
	public String getVersion() {
		return Version;
	}
	public void setVersion(String value) {
		this.Version = value;
	}

	/**
	 * This refers to the specific software build that was used in the deployment 
	 * for processing the request and generating the response.
	 */
	private String Build;
	public String getBuild() {
		return Build;
	}
	public void setBuild(String value) {
		this.Build = value;
	}


	public AbstractResponseType() {
	}
	 private  boolean isWhitespaceNode(Node n) {
		 if (n.getNodeType() == Node.TEXT_NODE) { 
				String val = n.getNodeValue();
				return val.trim().length() == 0; 
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
		 sb.append('<').append(name);
		 NamedNodeMap attrs = n.getAttributes();
		 if (attrs != null) { 
		  for (int i = 0; i < attrs.getLength(); i++) { 
			    Node attr = attrs.item(i);
			    sb.append(' ').append(attr.getNodeName()).append("=\"").append(attr.getNodeValue()).append("\"");
		  }
		 } 
		 String textContent = null; 
		 NodeList children = n.getChildNodes(); 
		 if (children.getLength() == 0) { 
		  if ((textContent = n.getTextContent()) != null && !"".equals(textContent)) {
		    sb.append(textContent).append("</").append(name).append('>'); 
		  } else { 
		    sb.append("/>"); 
		  } 
		 } else { 
		  sb.append('>'); 
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
		  sb.append("</").append(name).append('>');
		 }
		 return sb.toString();
	 } 
	 public AbstractResponseType(Object xmlSoap) throws IOException,SAXException,ParserConfigurationException	{
		 DocumentBuilderFactory builderFactory = DocumentBuilderFactory.newInstance();
		 DocumentBuilder builder = builderFactory.newDocumentBuilder();
		 InputSource inStream = new InputSource(); 
		 inStream.setCharacterStream(new StringReader((String)xmlSoap));
		 Document document = builder.parse(inStream);
		 NodeList nodeList= null; 
		 String xmlString ="";
		 if(document.getElementsByTagName("Timestamp").getLength()!=0){		 if(!isWhitespaceNode(document.getElementsByTagName("Timestamp").item(0))){ 
		 this.Timestamp =(String)document.getElementsByTagName("Timestamp").item(0).getTextContent();

}
	}
		 if(document.getElementsByTagName("Ack").getLength()!=0){		 if(!isWhitespaceNode(document.getElementsByTagName("Ack").item(0))){ 
		 this.Ack = AckCodeType.fromValue(document.getElementsByTagName("Ack").item(0).getTextContent());

}
	}
		 if(document.getElementsByTagName("CorrelationID").getLength()!=0){		 if(!isWhitespaceNode(document.getElementsByTagName("CorrelationID").item(0))){ 
		 this.CorrelationID =(String)document.getElementsByTagName("CorrelationID").item(0).getTextContent();

}
	}
		 if(document.getElementsByTagName("Errors").getLength()!=0){		 if(!isWhitespaceNode(document.getElementsByTagName("Errors").item(0))){ 
		 nodeList = document.getElementsByTagName("Errors");
		 for(int i=0; i<nodeList.getLength(); i++) {
			 xmlString = convertToXML(nodeList.item(i)); 
				this.Errors.add(new ErrorType(xmlString));
			}

}
	}
		 if(document.getElementsByTagName("Version").getLength()!=0){		 if(!isWhitespaceNode(document.getElementsByTagName("Version").item(0))){ 
		 this.Version =(String)document.getElementsByTagName("Version").item(0).getTextContent();

}
	}
		 if(document.getElementsByTagName("Build").getLength()!=0){		 if(!isWhitespaceNode(document.getElementsByTagName("Build").item(0))){ 
		 this.Build =(String)document.getElementsByTagName("Build").item(0).getTextContent();

}
	}
	}
}
