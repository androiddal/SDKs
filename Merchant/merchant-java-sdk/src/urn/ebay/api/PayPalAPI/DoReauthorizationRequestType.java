package urn.ebay.api.PayPalAPI;
import urn.ebay.apis.CoreComponentTypes.BasicAmountType;
import urn.ebay.apis.eBLBaseComponents.AbstractRequestType;
import com.paypal.core.SDKUtil;

/**
 * The value of a previously authorized transaction
 * identification number returned by a PayPal product. You can
 * obtain a buyer's transaction number from the TransactionID
 * element of the PayerInfo structure returned by
 * GetTransactionDetailsResponse. Required Character length and
 * limits: 19 single-byte characters maximum 
 */
public class DoReauthorizationRequestType extends AbstractRequestType {


	/**
	 * The value of a previously authorized transaction
	 * identification number returned by a PayPal product. You can
	 * obtain a buyer's transaction number from the TransactionID
	 * element of the PayerInfo structure returned by
	 * GetTransactionDetailsResponse. Required Character length and
	 * limits: 19 single-byte characters maximum	  
	 *@Required	 
	 */ 
	private String AuthorizationID;

	/**
	 * Amount to reauthorize. Required Limitations: Must not exceed
	 * $10,000 USD in any currency. No currency symbol. Decimal
	 * separator must be a period (.), and the thousands separator
	 * must be a comma (,).	  
	 *@Required	 
	 */ 
	private BasicAmountType Amount;

	

	/**
	 * Constructor with arguments
	 */
	public DoReauthorizationRequestType (String AuthorizationID, BasicAmountType Amount){
		this.AuthorizationID = AuthorizationID;
		this.Amount = Amount;
	}	

	/**
	 * Default Constructor
	 */
	public DoReauthorizationRequestType (){
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
	 * Getter for Amount
	 */
	 public BasicAmountType getAmount() {
	 	return Amount;
	 }
	 
	/**
	 * Setter for Amount
	 */
	 public void setAmount(BasicAmountType Amount) {
	 	this.Amount = Amount;
	 }
	 


	public String toXMLString() {
		StringBuilder sb = new StringBuilder();
		sb.append(super.toXMLString());
		if(AuthorizationID != null) {
			sb.append("<urn:AuthorizationID>").append(SDKUtil.escapeInvalidXmlCharsRegex(AuthorizationID));
			sb.append("</urn:AuthorizationID>");
		}
		if(Amount != null) {
			sb.append("<urn:Amount");
			sb.append(Amount.toXMLString());
			sb.append("</urn:Amount>");
		}
		return sb.toString();
	}

}