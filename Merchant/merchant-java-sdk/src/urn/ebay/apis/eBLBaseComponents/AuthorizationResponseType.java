package urn.ebay.apis.eBLBaseComponents;
import urn.ebay.apis.eBLBaseComponents.AckCodeType;
import java.util.List;
import java.util.ArrayList;
import urn.ebay.apis.eBLBaseComponents.ErrorType;
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
 * Status will denote whether Auto authorization was successful
 * or not. 
 */
public class AuthorizationResponseType{


	/**
	 * Status will denote whether Auto authorization was successful
	 * or not. 	  
	 *@Required	 
	 */ 
	private AckCodeType Status;

	/**
	 * 	 
	 */ 
	private List<ErrorType> AuthorizationError = new ArrayList<ErrorType>();

	

	/**
	 * Default Constructor
	 */
	public AuthorizationResponseType (){
	}	

	/**
	 * Getter for Status
	 */
	 public AckCodeType getStatus() {
	 	return Status;
	 }
	 
	/**
	 * Setter for Status
	 */
	 public void setStatus(AckCodeType Status) {
	 	this.Status = Status;
	 }
	 
	/**
	 * Getter for AuthorizationError
	 */
	 public List<ErrorType> getAuthorizationError() {
	 	return AuthorizationError;
	 }
	 
	/**
	 * Setter for AuthorizationError
	 */
	 public void setAuthorizationError(List<ErrorType> AuthorizationError) {
	 	this.AuthorizationError = AuthorizationError;
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
	
	public AuthorizationResponseType(Object xmlSoap) throws IOException, SAXException, ParserConfigurationException {
		DocumentBuilderFactory builderFactory = DocumentBuilderFactory.newInstance();
		DocumentBuilder builder = builderFactory.newDocumentBuilder();
		InputSource inStream = new InputSource();
		inStream.setCharacterStream(new StringReader((String)xmlSoap));
		Document document = builder.parse(inStream);
		NodeList nodeList= null;
		
		String xmlString = "";
		if(document.getElementsByTagName("Status").getLength() != 0) {
			if(!isWhitespaceNode(document.getElementsByTagName("Status").item(0))) {
				this.Status = AckCodeType.fromValue(document.getElementsByTagName("Status").item(0).getTextContent());
			}
		}
		if (document.getElementsByTagName("AuthorizationError").getLength() != 0) {
			if(!isWhitespaceNode(document.getElementsByTagName("AuthorizationError").item(0))) {
				nodeList = document.getElementsByTagName("AuthorizationError");
				for(int i=0; i < nodeList.getLength(); i++) {
					xmlString = convertToXML(nodeList.item(i));
					this.AuthorizationError.add(new ErrorType(xmlString));
				}
			}
		}
	}
 
}