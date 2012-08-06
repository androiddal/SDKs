/**
  * Stub objects for AdaptiveAccounts 
  * AUTO_GENERATED_CODE 
  */
using System;
using System.Text;
using System.Web;
using System.Xml;
using System.Collections;
using System.ComponentModel;
using System.Collections.Generic;
using PayPal.Util;

namespace PayPal.AdaptiveAccounts.Model
{

	public class EnumUtils
	{
		public static string getDescription(Enum value)
		{
			string description = "";
			DescriptionAttribute[] attributes = (DescriptionAttribute[])value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attributes.Length > 0)
			{
				description= attributes[0].Description;
			}
			return description;
		}
		
		public static object getValue(String value,Type enumType)
		{
			string[] names = Enum.GetNames(enumType);
			foreach(string name in names)
            {
            	if (getDescription((Enum)Enum.Parse(enumType, name)).Equals(value))
            	{
					return Enum.Parse(enumType, name);
				}
			}
			return null;
		}
	}


	/**
      *This type contains the detailed error information resulting
      *from the service operation. 
      */
	public partial class ErrorData	
	{

		/**
          *
		  */
		private int? errorIdField;
		public int? errorId
		{
			get
			{
				return this.errorIdField;
			}
			set
			{
				this.errorIdField = value;
			}
		}
		

		/**
          *
		  */
		private string domainField;
		public string domain
		{
			get
			{
				return this.domainField;
			}
			set
			{
				this.domainField = value;
			}
		}
		

		/**
          *
		  */
		private string subdomainField;
		public string subdomain
		{
			get
			{
				return this.subdomainField;
			}
			set
			{
				this.subdomainField = value;
			}
		}
		

		/**
          *
		  */
		private ErrorSeverity? severityField;
		public ErrorSeverity? severity
		{
			get
			{
				return this.severityField;
			}
			set
			{
				this.severityField = value;
			}
		}
		

		/**
          *
		  */
		private ErrorCategory? categoryField;
		public ErrorCategory? category
		{
			get
			{
				return this.categoryField;
			}
			set
			{
				this.categoryField = value;
			}
		}
		

		/**
          *
		  */
		private string messageField;
		public string message
		{
			get
			{
				return this.messageField;
			}
			set
			{
				this.messageField = value;
			}
		}
		

		/**
          *
		  */
		private string exceptionIdField;
		public string exceptionId
		{
			get
			{
				return this.exceptionIdField;
			}
			set
			{
				this.exceptionIdField = value;
			}
		}
		

		/**
          *
		  */
		private List<ErrorParameter> parameterField = new List<ErrorParameter>();
		public List<ErrorParameter> parameter
		{
			get
			{
				return this.parameterField;
			}
			set
			{
				this.parameterField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public ErrorData(){
		}



		public static ErrorData createInstance(Dictionary<string, string> map, string prefix, int index)
		{
			ErrorData errorData = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			key = prefix + "errorId";
			if (map.ContainsKey(key))
			{
				errorData = (errorData == null) ? new ErrorData() : errorData;
				errorData.errorId = System.Convert.ToInt32(map[key]);
			}
			key = prefix + "domain";
			if (map.ContainsKey(key))
			{
				errorData = (errorData == null) ? new ErrorData() : errorData;
				errorData.domain = map[key];
			}
			key = prefix + "subdomain";
			if (map.ContainsKey(key))
			{
				errorData = (errorData == null) ? new ErrorData() : errorData;
				errorData.subdomain = map[key];
			}
			key = prefix + "severity";
			if (map.ContainsKey(key))
			{
				errorData = (errorData == null) ? new ErrorData() : errorData;
				errorData.severity = (ErrorSeverity)EnumUtils.getValue(map[key],typeof(ErrorSeverity));;
			}
			key = prefix + "category";
			if (map.ContainsKey(key))
			{
				errorData = (errorData == null) ? new ErrorData() : errorData;
				errorData.category = (ErrorCategory)EnumUtils.getValue(map[key],typeof(ErrorCategory));;
			}
			key = prefix + "message";
			if (map.ContainsKey(key))
			{
				errorData = (errorData == null) ? new ErrorData() : errorData;
				errorData.message = map[key];
			}
			key = prefix + "exceptionId";
			if (map.ContainsKey(key))
			{
				errorData = (errorData == null) ? new ErrorData() : errorData;
				errorData.exceptionId = map[key];
			}
			i = 0;
			while(true)
			{
				ErrorParameter parameter =  ErrorParameter.createInstance(map, prefix + "parameter", i);
				if (parameter != null)
				{
					errorData = (errorData == null) ? new ErrorData() : errorData;
					errorData.parameter.Add(parameter);
					i++;
				} 
				else
				{
					break;
				}
			}
			return errorData;
		}
		
	}




	/**
      *
      */
	public partial class ErrorParameter	
	{

		/**
          *
		  */
		private string nameField;
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}
		

		/**
          *
		  */
		private string valueField;
		public string value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public ErrorParameter(){
		}



		public static ErrorParameter createInstance(Dictionary<string, string> map, string prefix, int index)
		{
			ErrorParameter errorParameter = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			key = prefix + "name";
			if (map.ContainsKey(key))
			{
				errorParameter = (errorParameter == null) ? new ErrorParameter() : errorParameter;
				errorParameter.name = map[key];
			}
			key = prefix.Substring(0, prefix.Length - 1);
			if (map.ContainsKey(key))
			{
				errorParameter = (errorParameter == null) ? new ErrorParameter() : errorParameter;
				errorParameter.value = map[key];
			}
			return errorParameter;
		}
		
	}




	/**
      *This specifies the list of parameters with every request to
      *the service. 
      */
	public partial class RequestEnvelope	
	{

		/**
          *
		  */
		private DetailLevelCode? detailLevelField;
		public DetailLevelCode? detailLevel
		{
			get
			{
				return this.detailLevelField;
			}
			set
			{
				this.detailLevelField = value;
			}
		}
		

		/**
          *
		  */
		private string errorLanguageField;
		public string errorLanguage
		{
			get
			{
				return this.errorLanguageField;
			}
			set
			{
				this.errorLanguageField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public RequestEnvelope(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.detailLevel != null)
			{
					sb.Append(prefix).Append("detailLevel").Append("=").Append(EnumUtils.getDescription(detailLevel));
					sb.Append("&");
			}
			if (this.errorLanguage != null)
			{
					sb.Append(prefix).Append("errorLanguage").Append("=").Append(HttpUtility.UrlEncode(this.errorLanguage, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/**
      *This specifies a list of parameters with every response from
      *a service. 
      */
	public partial class ResponseEnvelope	
	{

		/**
          *
		  */
		private string timestampField;
		public string timestamp
		{
			get
			{
				return this.timestampField;
			}
			set
			{
				this.timestampField = value;
			}
		}
		

		/**
          *
		  */
		private AckCode? ackField;
		public AckCode? ack
		{
			get
			{
				return this.ackField;
			}
			set
			{
				this.ackField = value;
			}
		}
		

		/**
          *
		  */
		private string correlationIdField;
		public string correlationId
		{
			get
			{
				return this.correlationIdField;
			}
			set
			{
				this.correlationIdField = value;
			}
		}
		

		/**
          *
		  */
		private string buildField;
		public string build
		{
			get
			{
				return this.buildField;
			}
			set
			{
				this.buildField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public ResponseEnvelope(){
		}



		public static ResponseEnvelope createInstance(Dictionary<string, string> map, string prefix, int index)
		{
			ResponseEnvelope responseEnvelope = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			key = prefix + "timestamp";
			if (map.ContainsKey(key))
			{
				responseEnvelope = (responseEnvelope == null) ? new ResponseEnvelope() : responseEnvelope;
				responseEnvelope.timestamp = map[key];
			}
			key = prefix + "ack";
			if (map.ContainsKey(key))
			{
				responseEnvelope = (responseEnvelope == null) ? new ResponseEnvelope() : responseEnvelope;
				responseEnvelope.ack = (AckCode)EnumUtils.getValue(map[key],typeof(AckCode));;
			}
			key = prefix + "correlationId";
			if (map.ContainsKey(key))
			{
				responseEnvelope = (responseEnvelope == null) ? new ResponseEnvelope() : responseEnvelope;
				responseEnvelope.correlationId = map[key];
			}
			key = prefix + "build";
			if (map.ContainsKey(key))
			{
				responseEnvelope = (responseEnvelope == null) ? new ResponseEnvelope() : responseEnvelope;
				responseEnvelope.build = map[key];
			}
			return responseEnvelope;
		}
		
	}




	/**
      *This elements in this type refers to the end user of the
      *application invoking this service. 
      */
	public partial class ClientDetailsType	
	{

		/**
          *
		  */
		private string ipAddressField;
		public string ipAddress
		{
			get
			{
				return this.ipAddressField;
			}
			set
			{
				this.ipAddressField = value;
			}
		}
		

		/**
          *
		  */
		private string deviceIdField;
		public string deviceId
		{
			get
			{
				return this.deviceIdField;
			}
			set
			{
				this.deviceIdField = value;
			}
		}
		

		/**
          *
		  */
		private string applicationIdField;
		public string applicationId
		{
			get
			{
				return this.applicationIdField;
			}
			set
			{
				this.applicationIdField = value;
			}
		}
		

		/**
          *
		  */
		private string modelField;
		public string model
		{
			get
			{
				return this.modelField;
			}
			set
			{
				this.modelField = value;
			}
		}
		

		/**
          *
		  */
		private string geoLocationField;
		public string geoLocation
		{
			get
			{
				return this.geoLocationField;
			}
			set
			{
				this.geoLocationField = value;
			}
		}
		

		/**
          *
		  */
		private string customerTypeField;
		public string customerType
		{
			get
			{
				return this.customerTypeField;
			}
			set
			{
				this.customerTypeField = value;
			}
		}
		

		/**
          *
		  */
		private string partnerNameField;
		public string partnerName
		{
			get
			{
				return this.partnerNameField;
			}
			set
			{
				this.partnerNameField = value;
			}
		}
		

		/**
          *
		  */
		private string customerIdField;
		public string customerId
		{
			get
			{
				return this.customerIdField;
			}
			set
			{
				this.customerIdField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public ClientDetailsType(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.ipAddress != null)
			{
					sb.Append(prefix).Append("ipAddress").Append("=").Append(HttpUtility.UrlEncode(this.ipAddress, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.deviceId != null)
			{
					sb.Append(prefix).Append("deviceId").Append("=").Append(HttpUtility.UrlEncode(this.deviceId, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.applicationId != null)
			{
					sb.Append(prefix).Append("applicationId").Append("=").Append(HttpUtility.UrlEncode(this.applicationId, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.model != null)
			{
					sb.Append(prefix).Append("model").Append("=").Append(HttpUtility.UrlEncode(this.model, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.geoLocation != null)
			{
					sb.Append(prefix).Append("geoLocation").Append("=").Append(HttpUtility.UrlEncode(this.geoLocation, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.customerType != null)
			{
					sb.Append(prefix).Append("customerType").Append("=").Append(HttpUtility.UrlEncode(this.customerType, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.partnerName != null)
			{
					sb.Append(prefix).Append("partnerName").Append("=").Append(HttpUtility.UrlEncode(this.partnerName, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.customerId != null)
			{
					sb.Append(prefix).Append("customerId").Append("=").Append(HttpUtility.UrlEncode(this.customerId, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/**
      *This specifies a fault, encapsulating error data, with
      *specific error codes. 
      */
	public partial class FaultMessage	
	{

		/**
          *
		  */
		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope
		{
			get
			{
				return this.responseEnvelopeField;
			}
			set
			{
				this.responseEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public FaultMessage(){
		}



		public static FaultMessage createInstance(Dictionary<string, string> map, string prefix, int index)
		{
			FaultMessage faultMessage = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.createInstance(map, prefix + "responseEnvelope", -1);
			if (responseEnvelope != null)
			{
				faultMessage = (faultMessage == null) ? new FaultMessage() : faultMessage;
				faultMessage.responseEnvelope = responseEnvelope;
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.createInstance(map, prefix + "error", i);
				if (error != null)
				{
					faultMessage = (faultMessage == null) ? new FaultMessage() : faultMessage;
					faultMessage.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return faultMessage;
		}
		
	}




	/**
      *
      */
	public enum ErrorSeverity {
		[Description("Error")]ERROR,	
		[Description("Warning")]WARNING	
	}




	/**
      *
      */
	public enum ErrorCategory {
		[Description("System")]SYSTEM,	
		[Description("Application")]APPLICATION,	
		[Description("Request")]REQUEST	
	}




	/**
      * AckCodeType This code identifies the
      * acknowledgement code types that could be used to
      * communicate the status of processing a (request)
      * message to an application. This code would be
      * used as part of a response message that contains
      * an application level acknowledgement element.
      * 
      */
	public enum AckCode {
		[Description("Success")]SUCCESS,	
		[Description("Failure")]FAILURE,	
		[Description("Warning")]WARNING,	
		[Description("SuccessWithWarning")]SUCCESSWITHWARNING,	
		[Description("FailureWithWarning")]FAILUREWITHWARNING	
	}




	/**
      * DetailLevelCodeType
      * 
      */
	public enum DetailLevelCode {
		[Description("ReturnAll")]RETURNALL,	
		[Description("ReturnAttributes")]RETURNATTRIBUTES	
	}




	/**
      * Bank account type should be CHECKING,
      * SAVINGS,BUSINESS_CHECKING,
      * BUSINESS_SAVINGS,NORMAL, or UNKNOWN.
      * 
      */
	public enum BankAccountType {
		[Description("CHECKING")]CHECKING,	
		[Description("SAVINGS")]SAVINGS,	
		[Description("BUSINESS_CHECKING")]BUSINESSCHECKING,	
		[Description("BUSINESS_SAVINGS")]BUSINESSSAVINGS,	
		[Description("NORMAL")]NORMAL,	
		[Description("UNKNOWN")]UNKNOWN	
	}




	/**
      * API confirmation type currently
      * Valid values are: NONE, MOBILE and
      * WEB. WEB: Returns a URL to complete the
      * registration.
      * 
      */
	public enum ConfirmationType {
		[Description("WEB")]WEB,	
		[Description("MOBILE")]MOBILE,	
		[Description("NONE")]NONE	
	}




	/**
      * Business Types
      * 
      */
	public enum BusinessType {
		[Description("ASSOCIATION")]ASSOCIATION,	
		[Description("CORPORATION")]CORPORATION,	
		[Description("GENERAL_PARTNERSHIP")]GENERALPARTNERSHIP,	
		[Description("GOVERNMENT")]GOVERNMENT,	
		[Description("INDIVIDUAL")]INDIVIDUAL,	
		[Description("LIMITED_LIABILITY_PARTNERSHIP")]LIMITEDLIABILITYPARTNERSHIP,	
		[Description("LIMITED_LIABILITY_PRIVATE_CORPORATION")]LIMITEDLIABILITYPRIVATECORPORATION,	
		[Description("LIMITED_LIABILITY_PROPRIETORS")]LIMITEDLIABILITYPROPRIETORS,	
		[Description("LIMITED_PARTNERSHIP")]LIMITEDPARTNERSHIP,	
		[Description("LIMITED_PARTNERSHIP_PRIVATE_CORPORATION")]LIMITEDPARTNERSHIPPRIVATECORPORATION,	
		[Description("NONPROFIT")]NONPROFIT,	
		[Description("OTHER_CORPORATE_BODY")]OTHERCORPORATEBODY,	
		[Description("PARTNERSHIP")]PARTNERSHIP,	
		[Description("PRIVATE_CORPORATION")]PRIVATECORPORATION,	
		[Description("PRIVATE_PARTNERSHIP")]PRIVATEPARTNERSHIP,	
		[Description("PROPRIETORSHIP")]PROPRIETORSHIP,	
		[Description("PROPRIETORSHIP_CRAFTSMAN")]PROPRIETORSHIPCRAFTSMAN,	
		[Description("PROPRIETARY_COMPANY")]PROPRIETARYCOMPANY,	
		[Description("PUBLIC_COMPANY")]PUBLICCOMPANY,	
		[Description("PUBLIC_CORPORATION")]PUBLICCORPORATION,	
		[Description("PUBLIC_PARTNERSHIP")]PUBLICPARTNERSHIP	
	}




	/**
      * Subtype required only for Business Type GOVERNMENT and
      *ASSOCIATION 
      * GOVERNMENT: ENTITY, EMANATION,ESTD_COMMONWEALTH,
      *ESTD_UNDER_STATE_TERRITORY, 
      * ESTD_UNDER_FOREIGN_COUNTRY 
      * ASSOCIATION: INCORPORATED, NON_INCORPORATED
      * 
      */
	public enum BusinessSubtypeType {
		[Description("ENTITY")]ENTITY,	
		[Description("EMANATION")]EMANATION,	
		[Description("ESTD_COMMONWEALTH")]ESTDCOMMONWEALTH,	
		[Description("ESTD_UNDER_STATE_TERRITORY")]ESTDUNDERSTATETERRITORY,	
		[Description("ESTD_UNDER_FOREIGN_COUNTRY")]ESTDUNDERFOREIGNCOUNTRY,	
		[Description("INCORPORATED")]INCORPORATED,	
		[Description("NON_INCORPORATED")]NONINCORPORATED	
	}




	/**
      * Sales venue / store front type
      * 
      */
	public enum SalesVenueType {
		[Description("WEB")]WEB,	
		[Description("EBAY")]EBAY,	
		[Description("OTHER_MARKETPLACE")]OTHERMARKETPLACE,	
		[Description("OTHER")]OTHER	
	}




	/**
      * Stake holder role 
      * 
      */
	public enum StakeholderRoleType {
		[Description("CHAIRMAN")]CHAIRMAN,	
		[Description("SECRETARY")]SECRETARY,	
		[Description("TREASURER")]TREASURER,	
		[Description("BENEFICIAL_OWNER")]BENEFICIALOWNER,	
		[Description("PRIMARY_CONTACT")]PRIMARYCONTACT,	
		[Description("INDIVIDUAL_PARTNER")]INDIVIDUALPARTNER,	
		[Description("NON_INDIVIDUAL_PARTNER")]NONINDIVIDUALPARTNER,	
		[Description("PRIMARY_INDIVIDUAL_PARTNER")]PRIMARYINDIVIDUALPARTNER,	
		[Description("DIRECTOR")]DIRECTOR,	
		[Description("NO_BENEFICIAL_OWNER")]NOBENEFICIALOWNER	
	}




	/**
      *
      */
	public enum CardTypeType {
		[Description("Visa")]VISA,	
		[Description("MasterCard")]MASTERCARD,	
		[Description("AmericanExpress")]AMERICANEXPRESS,	
		[Description("Discover")]DISCOVER,	
		[Description("SwitchMaestro")]SWITCHMAESTRO,	
		[Description("Solo")]SOLO,	
		[Description("CarteAurore")]CARTEAURORE,	
		[Description("CarteBleue")]CARTEBLEUE,	
		[Description("Cofinoga")]COFINOGA,	
		[Description("4etoiles")]ETOILES,	
		[Description("CartaAura")]CARTAAURA,	
		[Description("TarjetaAurora")]TARJETAAURORA,	
		[Description("JCB")]JCB	
	}




	/**
      *Valid values are: Personal, Premier, and Business. Flag="2"
      *corresponds to java.util.regex.Pattern.CASE_INSENSITIVE,
      *meaning the strings are not case-sensitive 
      */
	public partial class CreateAccountRequest	
	{

		/**
          *
		  */
		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope
		{
			get
			{
				return this.requestEnvelopeField;
			}
			set
			{
				this.requestEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private ClientDetailsType clientDetailsField;
		public ClientDetailsType clientDetails
		{
			get
			{
				return this.clientDetailsField;
			}
			set
			{
				this.clientDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private string accountTypeField;
		public string accountType
		{
			get
			{
				return this.accountTypeField;
			}
			set
			{
				this.accountTypeField = value;
			}
		}
		

		/**
          *
		  */
		private NameType nameField;
		public NameType name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}
		

		/**
          *
		  */
		private string dateOfBirthField;
		public string dateOfBirth
		{
			get
			{
				return this.dateOfBirthField;
			}
			set
			{
				this.dateOfBirthField = value;
			}
		}
		

		/**
          *
		  */
		private AddressType addressField;
		public AddressType address
		{
			get
			{
				return this.addressField;
			}
			set
			{
				this.addressField = value;
			}
		}
		

		/**
          *
		  */
		private string contactPhoneNumberField;
		public string contactPhoneNumber
		{
			get
			{
				return this.contactPhoneNumberField;
			}
			set
			{
				this.contactPhoneNumberField = value;
			}
		}
		

		/**
          *
		  */
		private string homePhoneNumberField;
		public string homePhoneNumber
		{
			get
			{
				return this.homePhoneNumberField;
			}
			set
			{
				this.homePhoneNumberField = value;
			}
		}
		

		/**
          *
		  */
		private string mobilePhoneNumberField;
		public string mobilePhoneNumber
		{
			get
			{
				return this.mobilePhoneNumberField;
			}
			set
			{
				this.mobilePhoneNumberField = value;
			}
		}
		

		/**
          *
		  */
		private string currencyCodeField;
		public string currencyCode
		{
			get
			{
				return this.currencyCodeField;
			}
			set
			{
				this.currencyCodeField = value;
			}
		}
		

		/**
          *
		  */
		private string citizenshipCountryCodeField;
		public string citizenshipCountryCode
		{
			get
			{
				return this.citizenshipCountryCodeField;
			}
			set
			{
				this.citizenshipCountryCodeField = value;
			}
		}
		

		/**
          *
		  */
		private string preferredLanguageCodeField;
		public string preferredLanguageCode
		{
			get
			{
				return this.preferredLanguageCodeField;
			}
			set
			{
				this.preferredLanguageCodeField = value;
			}
		}
		

		/**
          *
		  */
		private string notificationURLField;
		public string notificationURL
		{
			get
			{
				return this.notificationURLField;
			}
			set
			{
				this.notificationURLField = value;
			}
		}
		

		/**
          *
		  */
		private string emailAddressField;
		public string emailAddress
		{
			get
			{
				return this.emailAddressField;
			}
			set
			{
				this.emailAddressField = value;
			}
		}
		

		/**
          *
		  */
		private string registrationTypeField;
		public string registrationType
		{
			get
			{
				return this.registrationTypeField;
			}
			set
			{
				this.registrationTypeField = value;
			}
		}
		

		/**
          *
		  */
		private CreateAccountWebOptionsType createAccountWebOptionsField;
		public CreateAccountWebOptionsType createAccountWebOptions
		{
			get
			{
				return this.createAccountWebOptionsField;
			}
			set
			{
				this.createAccountWebOptionsField = value;
			}
		}
		

		/**
          *
		  */
		private bool? suppressWelcomeEmailField;
		public bool? suppressWelcomeEmail
		{
			get
			{
				return this.suppressWelcomeEmailField;
			}
			set
			{
				this.suppressWelcomeEmailField = value;
			}
		}
		

		/**
          *
		  */
		private bool? performExtraVettingOnThisAccountField;
		public bool? performExtraVettingOnThisAccount
		{
			get
			{
				return this.performExtraVettingOnThisAccountField;
			}
			set
			{
				this.performExtraVettingOnThisAccountField = value;
			}
		}
		

		/**
          *
		  */
		private string taxIdField;
		public string taxId
		{
			get
			{
				return this.taxIdField;
			}
			set
			{
				this.taxIdField = value;
			}
		}
		

		/**
          *
		  */
		private string partnerField1Field;
		public string partnerField1
		{
			get
			{
				return this.partnerField1Field;
			}
			set
			{
				this.partnerField1Field = value;
			}
		}
		

		/**
          *
		  */
		private string partnerField2Field;
		public string partnerField2
		{
			get
			{
				return this.partnerField2Field;
			}
			set
			{
				this.partnerField2Field = value;
			}
		}
		

		/**
          *
		  */
		private string partnerField3Field;
		public string partnerField3
		{
			get
			{
				return this.partnerField3Field;
			}
			set
			{
				this.partnerField3Field = value;
			}
		}
		

		/**
          *
		  */
		private string partnerField4Field;
		public string partnerField4
		{
			get
			{
				return this.partnerField4Field;
			}
			set
			{
				this.partnerField4Field = value;
			}
		}
		

		/**
          *
		  */
		private string partnerField5Field;
		public string partnerField5
		{
			get
			{
				return this.partnerField5Field;
			}
			set
			{
				this.partnerField5Field = value;
			}
		}
		

		/**
          *
		  */
		private BusinessInfoType businessInfoField;
		public BusinessInfoType businessInfo
		{
			get
			{
				return this.businessInfoField;
			}
			set
			{
				this.businessInfoField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public CreateAccountRequest(RequestEnvelope requestEnvelope, NameType name, AddressType address, string preferredLanguageCode){
			this.requestEnvelope = requestEnvelope;
			this.name = name;
			this.address = address;
			this.preferredLanguageCode = preferredLanguageCode;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public CreateAccountRequest(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
			}
			if (this.clientDetails != null)
			{
					string newPrefix = prefix + "clientDetails" + ".";
					sb.Append(this.clientDetailsField.toNVPString(newPrefix));
			}
			if (this.accountType != null)
			{
					sb.Append(prefix).Append("accountType").Append("=").Append(HttpUtility.UrlEncode(this.accountType, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.name != null)
			{
					string newPrefix = prefix + "name" + ".";
					sb.Append(this.nameField.toNVPString(newPrefix));
			}
			if (this.dateOfBirth != null)
			{
					sb.Append(prefix).Append("dateOfBirth").Append("=").Append(this.dateOfBirth).Append("&");
			}
			if (this.address != null)
			{
					string newPrefix = prefix + "address" + ".";
					sb.Append(this.addressField.toNVPString(newPrefix));
			}
			if (this.contactPhoneNumber != null)
			{
					sb.Append(prefix).Append("contactPhoneNumber").Append("=").Append(HttpUtility.UrlEncode(this.contactPhoneNumber, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.homePhoneNumber != null)
			{
					sb.Append(prefix).Append("homePhoneNumber").Append("=").Append(HttpUtility.UrlEncode(this.homePhoneNumber, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.mobilePhoneNumber != null)
			{
					sb.Append(prefix).Append("mobilePhoneNumber").Append("=").Append(HttpUtility.UrlEncode(this.mobilePhoneNumber, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.currencyCode != null)
			{
					sb.Append(prefix).Append("currencyCode").Append("=").Append(HttpUtility.UrlEncode(this.currencyCode, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.citizenshipCountryCode != null)
			{
					sb.Append(prefix).Append("citizenshipCountryCode").Append("=").Append(HttpUtility.UrlEncode(this.citizenshipCountryCode, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.preferredLanguageCode != null)
			{
					sb.Append(prefix).Append("preferredLanguageCode").Append("=").Append(HttpUtility.UrlEncode(this.preferredLanguageCode, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.notificationURL != null)
			{
					sb.Append(prefix).Append("notificationURL").Append("=").Append(HttpUtility.UrlEncode(this.notificationURL, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.emailAddress != null)
			{
					sb.Append(prefix).Append("emailAddress").Append("=").Append(HttpUtility.UrlEncode(this.emailAddress, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.registrationType != null)
			{
					sb.Append(prefix).Append("registrationType").Append("=").Append(HttpUtility.UrlEncode(this.registrationType, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.createAccountWebOptions != null)
			{
					string newPrefix = prefix + "createAccountWebOptions" + ".";
					sb.Append(this.createAccountWebOptionsField.toNVPString(newPrefix));
			}
			if (this.suppressWelcomeEmail != null)
			{
					sb.Append(prefix).Append("suppressWelcomeEmail").Append("=").Append(this.suppressWelcomeEmail).Append("&");
			}
			if (this.performExtraVettingOnThisAccount != null)
			{
					sb.Append(prefix).Append("performExtraVettingOnThisAccount").Append("=").Append(this.performExtraVettingOnThisAccount).Append("&");
			}
			if (this.taxId != null)
			{
					sb.Append(prefix).Append("taxId").Append("=").Append(HttpUtility.UrlEncode(this.taxId, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.partnerField1 != null)
			{
					sb.Append(prefix).Append("partnerField1").Append("=").Append(HttpUtility.UrlEncode(this.partnerField1, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.partnerField2 != null)
			{
					sb.Append(prefix).Append("partnerField2").Append("=").Append(HttpUtility.UrlEncode(this.partnerField2, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.partnerField3 != null)
			{
					sb.Append(prefix).Append("partnerField3").Append("=").Append(HttpUtility.UrlEncode(this.partnerField3, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.partnerField4 != null)
			{
					sb.Append(prefix).Append("partnerField4").Append("=").Append(HttpUtility.UrlEncode(this.partnerField4, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.partnerField5 != null)
			{
					sb.Append(prefix).Append("partnerField5").Append("=").Append(HttpUtility.UrlEncode(this.partnerField5, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.businessInfo != null)
			{
					string newPrefix = prefix + "businessInfo" + ".";
					sb.Append(this.businessInfoField.toNVPString(newPrefix));
			}
			return sb.ToString();
		}
	}




	/**
      *Valid values are: COMPLETED,
      *COMPLETED:MERCHANT_REFERRAL_BONUS_ID_ASSOCIATION_FAILED 
      */
	public partial class CreateAccountResponse	
	{

		/**
          *
		  */
		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope
		{
			get
			{
				return this.responseEnvelopeField;
			}
			set
			{
				this.responseEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private string createAccountKeyField;
		public string createAccountKey
		{
			get
			{
				return this.createAccountKeyField;
			}
			set
			{
				this.createAccountKeyField = value;
			}
		}
		

		/**
          *
		  */
		private string execStatusField;
		public string execStatus
		{
			get
			{
				return this.execStatusField;
			}
			set
			{
				this.execStatusField = value;
			}
		}
		

		/**
          *
		  */
		private string redirectURLField;
		public string redirectURL
		{
			get
			{
				return this.redirectURLField;
			}
			set
			{
				this.redirectURLField = value;
			}
		}
		

		/**
          *
		  */
		private string accountIdField;
		public string accountId
		{
			get
			{
				return this.accountIdField;
			}
			set
			{
				this.accountIdField = value;
			}
		}
		

		/**
          *
		  */
		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public CreateAccountResponse(){
		}



		public static CreateAccountResponse createInstance(Dictionary<string, string> map, string prefix, int index)
		{
			CreateAccountResponse createAccountResponse = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.createInstance(map, prefix + "responseEnvelope", -1);
			if (responseEnvelope != null)
			{
				createAccountResponse = (createAccountResponse == null) ? new CreateAccountResponse() : createAccountResponse;
				createAccountResponse.responseEnvelope = responseEnvelope;
			}
			key = prefix + "createAccountKey";
			if (map.ContainsKey(key))
			{
				createAccountResponse = (createAccountResponse == null) ? new CreateAccountResponse() : createAccountResponse;
				createAccountResponse.createAccountKey = map[key];
			}
			key = prefix + "execStatus";
			if (map.ContainsKey(key))
			{
				createAccountResponse = (createAccountResponse == null) ? new CreateAccountResponse() : createAccountResponse;
				createAccountResponse.execStatus = map[key];
			}
			key = prefix + "redirectURL";
			if (map.ContainsKey(key))
			{
				createAccountResponse = (createAccountResponse == null) ? new CreateAccountResponse() : createAccountResponse;
				createAccountResponse.redirectURL = map[key];
			}
			key = prefix + "accountId";
			if (map.ContainsKey(key))
			{
				createAccountResponse = (createAccountResponse == null) ? new CreateAccountResponse() : createAccountResponse;
				createAccountResponse.accountId = map[key];
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.createInstance(map, prefix + "error", i);
				if (error != null)
				{
					createAccountResponse = (createAccountResponse == null) ? new CreateAccountResponse() : createAccountResponse;
					createAccountResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return createAccountResponse;
		}
		
	}




	/**
      *
      */
	public partial class GetUserAgreementRequest	
	{

		/**
          *
		  */
		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope
		{
			get
			{
				return this.requestEnvelopeField;
			}
			set
			{
				this.requestEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private string createAccountKeyField;
		public string createAccountKey
		{
			get
			{
				return this.createAccountKeyField;
			}
			set
			{
				this.createAccountKeyField = value;
			}
		}
		

		/**
          *
		  */
		private string countryCodeField;
		public string countryCode
		{
			get
			{
				return this.countryCodeField;
			}
			set
			{
				this.countryCodeField = value;
			}
		}
		

		/**
          *
		  */
		private string languageCodeField;
		public string languageCode
		{
			get
			{
				return this.languageCodeField;
			}
			set
			{
				this.languageCodeField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public GetUserAgreementRequest(RequestEnvelope requestEnvelope){
			this.requestEnvelope = requestEnvelope;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public GetUserAgreementRequest(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
			}
			if (this.createAccountKey != null)
			{
					sb.Append(prefix).Append("createAccountKey").Append("=").Append(HttpUtility.UrlEncode(this.createAccountKey, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.countryCode != null)
			{
					sb.Append(prefix).Append("countryCode").Append("=").Append(HttpUtility.UrlEncode(this.countryCode, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.languageCode != null)
			{
					sb.Append(prefix).Append("languageCode").Append("=").Append(HttpUtility.UrlEncode(this.languageCode, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/**
      *
      */
	public partial class GetUserAgreementResponse	
	{

		/**
          *
		  */
		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope
		{
			get
			{
				return this.responseEnvelopeField;
			}
			set
			{
				this.responseEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private string agreementField;
		public string agreement
		{
			get
			{
				return this.agreementField;
			}
			set
			{
				this.agreementField = value;
			}
		}
		

		/**
          *
		  */
		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public GetUserAgreementResponse(){
		}



		public static GetUserAgreementResponse createInstance(Dictionary<string, string> map, string prefix, int index)
		{
			GetUserAgreementResponse getUserAgreementResponse = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.createInstance(map, prefix + "responseEnvelope", -1);
			if (responseEnvelope != null)
			{
				getUserAgreementResponse = (getUserAgreementResponse == null) ? new GetUserAgreementResponse() : getUserAgreementResponse;
				getUserAgreementResponse.responseEnvelope = responseEnvelope;
			}
			key = prefix + "agreement";
			if (map.ContainsKey(key))
			{
				getUserAgreementResponse = (getUserAgreementResponse == null) ? new GetUserAgreementResponse() : getUserAgreementResponse;
				getUserAgreementResponse.agreement = map[key];
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.createInstance(map, prefix + "error", i);
				if (error != null)
				{
					getUserAgreementResponse = (getUserAgreementResponse == null) ? new GetUserAgreementResponse() : getUserAgreementResponse;
					getUserAgreementResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return getUserAgreementResponse;
		}
		
	}




	/**
      *matchCriteria determines which field(s) in addition to
      *emailAddress is used to locate the account. Currently, we
      *support matchCriteria of 'NAME' and 'NONE'. 
      */
	public partial class GetVerifiedStatusRequest	
	{

		/**
          *
		  */
		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope
		{
			get
			{
				return this.requestEnvelopeField;
			}
			set
			{
				this.requestEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private string emailAddressField;
		public string emailAddress
		{
			get
			{
				return this.emailAddressField;
			}
			set
			{
				this.emailAddressField = value;
			}
		}
		

		/**
          *
		  */
		private string matchCriteriaField;
		public string matchCriteria
		{
			get
			{
				return this.matchCriteriaField;
			}
			set
			{
				this.matchCriteriaField = value;
			}
		}
		

		/**
          *
		  */
		private string firstNameField;
		public string firstName
		{
			get
			{
				return this.firstNameField;
			}
			set
			{
				this.firstNameField = value;
			}
		}
		

		/**
          *
		  */
		private string lastNameField;
		public string lastName
		{
			get
			{
				return this.lastNameField;
			}
			set
			{
				this.lastNameField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public GetVerifiedStatusRequest(RequestEnvelope requestEnvelope, string emailAddress, string matchCriteria){
			this.requestEnvelope = requestEnvelope;
			this.emailAddress = emailAddress;
			this.matchCriteria = matchCriteria;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public GetVerifiedStatusRequest(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
			}
			if (this.emailAddress != null)
			{
					sb.Append(prefix).Append("emailAddress").Append("=").Append(HttpUtility.UrlEncode(this.emailAddress, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.matchCriteria != null)
			{
					sb.Append(prefix).Append("matchCriteria").Append("=").Append(HttpUtility.UrlEncode(this.matchCriteria, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.firstName != null)
			{
					sb.Append(prefix).Append("firstName").Append("=").Append(HttpUtility.UrlEncode(this.firstName, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.lastName != null)
			{
					sb.Append(prefix).Append("lastName").Append("=").Append(HttpUtility.UrlEncode(this.lastName, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/**
      *Returned values are: VERIFIED|UNVERIFIED. 
      */
	public partial class GetVerifiedStatusResponse	
	{

		/**
          *
		  */
		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope
		{
			get
			{
				return this.responseEnvelopeField;
			}
			set
			{
				this.responseEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private string accountStatusField;
		public string accountStatus
		{
			get
			{
				return this.accountStatusField;
			}
			set
			{
				this.accountStatusField = value;
			}
		}
		

		/**
          *
		  */
		private string countryCodeField;
		public string countryCode
		{
			get
			{
				return this.countryCodeField;
			}
			set
			{
				this.countryCodeField = value;
			}
		}
		

		/**
          *
		  */
		private UserInfoType userInfoField;
		public UserInfoType userInfo
		{
			get
			{
				return this.userInfoField;
			}
			set
			{
				this.userInfoField = value;
			}
		}
		

		/**
          *
		  */
		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public GetVerifiedStatusResponse(){
		}



		public static GetVerifiedStatusResponse createInstance(Dictionary<string, string> map, string prefix, int index)
		{
			GetVerifiedStatusResponse getVerifiedStatusResponse = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.createInstance(map, prefix + "responseEnvelope", -1);
			if (responseEnvelope != null)
			{
				getVerifiedStatusResponse = (getVerifiedStatusResponse == null) ? new GetVerifiedStatusResponse() : getVerifiedStatusResponse;
				getVerifiedStatusResponse.responseEnvelope = responseEnvelope;
			}
			key = prefix + "accountStatus";
			if (map.ContainsKey(key))
			{
				getVerifiedStatusResponse = (getVerifiedStatusResponse == null) ? new GetVerifiedStatusResponse() : getVerifiedStatusResponse;
				getVerifiedStatusResponse.accountStatus = map[key];
			}
			key = prefix + "countryCode";
			if (map.ContainsKey(key))
			{
				getVerifiedStatusResponse = (getVerifiedStatusResponse == null) ? new GetVerifiedStatusResponse() : getVerifiedStatusResponse;
				getVerifiedStatusResponse.countryCode = map[key];
			}
			UserInfoType userInfo =  UserInfoType.createInstance(map, prefix + "userInfo", -1);
			if (userInfo != null)
			{
				getVerifiedStatusResponse = (getVerifiedStatusResponse == null) ? new GetVerifiedStatusResponse() : getVerifiedStatusResponse;
				getVerifiedStatusResponse.userInfo = userInfo;
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.createInstance(map, prefix + "error", i);
				if (error != null)
				{
					getVerifiedStatusResponse = (getVerifiedStatusResponse == null) ? new GetVerifiedStatusResponse() : getVerifiedStatusResponse;
					getVerifiedStatusResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return getVerifiedStatusResponse;
		}
		
	}




	/**
      *Identifying the PayPal account to which this request is
      *targetted to. Caller of this API has to either provided an
      *emailAddress or an accountId. 
      */
	public partial class AddBankAccountRequest	
	{

		/**
          *
		  */
		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope
		{
			get
			{
				return this.requestEnvelopeField;
			}
			set
			{
				this.requestEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private string emailAddressField;
		public string emailAddress
		{
			get
			{
				return this.emailAddressField;
			}
			set
			{
				this.emailAddressField = value;
			}
		}
		

		/**
          *
		  */
		private string accountIdField;
		public string accountId
		{
			get
			{
				return this.accountIdField;
			}
			set
			{
				this.accountIdField = value;
			}
		}
		

		/**
          *
		  */
		private string createAccountKeyField;
		public string createAccountKey
		{
			get
			{
				return this.createAccountKeyField;
			}
			set
			{
				this.createAccountKeyField = value;
			}
		}
		

		/**
          *
		  */
		private string bankCountryCodeField;
		public string bankCountryCode
		{
			get
			{
				return this.bankCountryCodeField;
			}
			set
			{
				this.bankCountryCodeField = value;
			}
		}
		

		/**
          *
		  */
		private string bankNameField;
		public string bankName
		{
			get
			{
				return this.bankNameField;
			}
			set
			{
				this.bankNameField = value;
			}
		}
		

		/**
          *
		  */
		private string routingNumberField;
		public string routingNumber
		{
			get
			{
				return this.routingNumberField;
			}
			set
			{
				this.routingNumberField = value;
			}
		}
		

		/**
          *
		  */
		private BankAccountType? bankAccountTypeField;
		public BankAccountType? bankAccountType
		{
			get
			{
				return this.bankAccountTypeField;
			}
			set
			{
				this.bankAccountTypeField = value;
			}
		}
		

		/**
          *
		  */
		private string bankAccountNumberField;
		public string bankAccountNumber
		{
			get
			{
				return this.bankAccountNumberField;
			}
			set
			{
				this.bankAccountNumberField = value;
			}
		}
		

		/**
          *
		  */
		private string ibanField;
		public string iban
		{
			get
			{
				return this.ibanField;
			}
			set
			{
				this.ibanField = value;
			}
		}
		

		/**
          *
		  */
		private string clabeField;
		public string clabe
		{
			get
			{
				return this.clabeField;
			}
			set
			{
				this.clabeField = value;
			}
		}
		

		/**
          *
		  */
		private string bsbNumberField;
		public string bsbNumber
		{
			get
			{
				return this.bsbNumberField;
			}
			set
			{
				this.bsbNumberField = value;
			}
		}
		

		/**
          *
		  */
		private string branchLocationField;
		public string branchLocation
		{
			get
			{
				return this.branchLocationField;
			}
			set
			{
				this.branchLocationField = value;
			}
		}
		

		/**
          *
		  */
		private string sortCodeField;
		public string sortCode
		{
			get
			{
				return this.sortCodeField;
			}
			set
			{
				this.sortCodeField = value;
			}
		}
		

		/**
          *
		  */
		private string bankTransitNumberField;
		public string bankTransitNumber
		{
			get
			{
				return this.bankTransitNumberField;
			}
			set
			{
				this.bankTransitNumberField = value;
			}
		}
		

		/**
          *
		  */
		private string institutionNumberField;
		public string institutionNumber
		{
			get
			{
				return this.institutionNumberField;
			}
			set
			{
				this.institutionNumberField = value;
			}
		}
		

		/**
          *
		  */
		private string branchCodeField;
		public string branchCode
		{
			get
			{
				return this.branchCodeField;
			}
			set
			{
				this.branchCodeField = value;
			}
		}
		

		/**
          *
		  */
		private string agencyNumberField;
		public string agencyNumber
		{
			get
			{
				return this.agencyNumberField;
			}
			set
			{
				this.agencyNumberField = value;
			}
		}
		

		/**
          *
		  */
		private string bankCodeField;
		public string bankCode
		{
			get
			{
				return this.bankCodeField;
			}
			set
			{
				this.bankCodeField = value;
			}
		}
		

		/**
          *
		  */
		private string ribKeyField;
		public string ribKey
		{
			get
			{
				return this.ribKeyField;
			}
			set
			{
				this.ribKeyField = value;
			}
		}
		

		/**
          *
		  */
		private string controlDigitField;
		public string controlDigit
		{
			get
			{
				return this.controlDigitField;
			}
			set
			{
				this.controlDigitField = value;
			}
		}
		

		/**
          *
		  */
		private string taxIdTypeField;
		public string taxIdType
		{
			get
			{
				return this.taxIdTypeField;
			}
			set
			{
				this.taxIdTypeField = value;
			}
		}
		

		/**
          *
		  */
		private string taxIdNumberField;
		public string taxIdNumber
		{
			get
			{
				return this.taxIdNumberField;
			}
			set
			{
				this.taxIdNumberField = value;
			}
		}
		

		/**
          *
		  */
		private string accountHolderDateOfBirthField;
		public string accountHolderDateOfBirth
		{
			get
			{
				return this.accountHolderDateOfBirthField;
			}
			set
			{
				this.accountHolderDateOfBirthField = value;
			}
		}
		

		/**
          *
		  */
		private ConfirmationType? confirmationTypeField;
		public ConfirmationType? confirmationType
		{
			get
			{
				return this.confirmationTypeField;
			}
			set
			{
				this.confirmationTypeField = value;
			}
		}
		

		/**
          *
		  */
		private WebOptionsType webOptionsField;
		public WebOptionsType webOptions
		{
			get
			{
				return this.webOptionsField;
			}
			set
			{
				this.webOptionsField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public AddBankAccountRequest(RequestEnvelope requestEnvelope, string bankCountryCode, ConfirmationType? confirmationType){
			this.requestEnvelope = requestEnvelope;
			this.bankCountryCode = bankCountryCode;
			this.confirmationType = confirmationType;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public AddBankAccountRequest(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
			}
			if (this.emailAddress != null)
			{
					sb.Append(prefix).Append("emailAddress").Append("=").Append(HttpUtility.UrlEncode(this.emailAddress, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.accountId != null)
			{
					sb.Append(prefix).Append("accountId").Append("=").Append(HttpUtility.UrlEncode(this.accountId, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.createAccountKey != null)
			{
					sb.Append(prefix).Append("createAccountKey").Append("=").Append(HttpUtility.UrlEncode(this.createAccountKey, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.bankCountryCode != null)
			{
					sb.Append(prefix).Append("bankCountryCode").Append("=").Append(HttpUtility.UrlEncode(this.bankCountryCode, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.bankName != null)
			{
					sb.Append(prefix).Append("bankName").Append("=").Append(HttpUtility.UrlEncode(this.bankName, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.routingNumber != null)
			{
					sb.Append(prefix).Append("routingNumber").Append("=").Append(HttpUtility.UrlEncode(this.routingNumber, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.bankAccountType != null)
			{
					sb.Append(prefix).Append("bankAccountType").Append("=").Append(EnumUtils.getDescription(bankAccountType));
					sb.Append("&");
			}
			if (this.bankAccountNumber != null)
			{
					sb.Append(prefix).Append("bankAccountNumber").Append("=").Append(HttpUtility.UrlEncode(this.bankAccountNumber, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.iban != null)
			{
					sb.Append(prefix).Append("iban").Append("=").Append(HttpUtility.UrlEncode(this.iban, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.clabe != null)
			{
					sb.Append(prefix).Append("clabe").Append("=").Append(HttpUtility.UrlEncode(this.clabe, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.bsbNumber != null)
			{
					sb.Append(prefix).Append("bsbNumber").Append("=").Append(HttpUtility.UrlEncode(this.bsbNumber, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.branchLocation != null)
			{
					sb.Append(prefix).Append("branchLocation").Append("=").Append(HttpUtility.UrlEncode(this.branchLocation, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.sortCode != null)
			{
					sb.Append(prefix).Append("sortCode").Append("=").Append(HttpUtility.UrlEncode(this.sortCode, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.bankTransitNumber != null)
			{
					sb.Append(prefix).Append("bankTransitNumber").Append("=").Append(HttpUtility.UrlEncode(this.bankTransitNumber, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.institutionNumber != null)
			{
					sb.Append(prefix).Append("institutionNumber").Append("=").Append(HttpUtility.UrlEncode(this.institutionNumber, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.branchCode != null)
			{
					sb.Append(prefix).Append("branchCode").Append("=").Append(HttpUtility.UrlEncode(this.branchCode, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.agencyNumber != null)
			{
					sb.Append(prefix).Append("agencyNumber").Append("=").Append(HttpUtility.UrlEncode(this.agencyNumber, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.bankCode != null)
			{
					sb.Append(prefix).Append("bankCode").Append("=").Append(HttpUtility.UrlEncode(this.bankCode, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.ribKey != null)
			{
					sb.Append(prefix).Append("ribKey").Append("=").Append(HttpUtility.UrlEncode(this.ribKey, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.controlDigit != null)
			{
					sb.Append(prefix).Append("controlDigit").Append("=").Append(HttpUtility.UrlEncode(this.controlDigit, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.taxIdType != null)
			{
					sb.Append(prefix).Append("taxIdType").Append("=").Append(HttpUtility.UrlEncode(this.taxIdType, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.taxIdNumber != null)
			{
					sb.Append(prefix).Append("taxIdNumber").Append("=").Append(HttpUtility.UrlEncode(this.taxIdNumber, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.accountHolderDateOfBirth != null)
			{
					sb.Append(prefix).Append("accountHolderDateOfBirth").Append("=").Append(this.accountHolderDateOfBirth).Append("&");
			}
			if (this.confirmationType != null)
			{
					sb.Append(prefix).Append("confirmationType").Append("=").Append(EnumUtils.getDescription(confirmationType));
					sb.Append("&");
			}
			if (this.webOptions != null)
			{
					string newPrefix = prefix + "webOptions" + ".";
					sb.Append(this.webOptionsField.toNVPString(newPrefix));
			}
			return sb.ToString();
		}
	}




	/**
      *Valid values are: FUNDING_SOURCE_ADDED,
      *WEB_URL_VERIFICATION_NEEDED 
      */
	public partial class AddBankAccountResponse	
	{

		/**
          *
		  */
		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope
		{
			get
			{
				return this.responseEnvelopeField;
			}
			set
			{
				this.responseEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private string execStatusField;
		public string execStatus
		{
			get
			{
				return this.execStatusField;
			}
			set
			{
				this.execStatusField = value;
			}
		}
		

		/**
          *
		  */
		private string redirectURLField;
		public string redirectURL
		{
			get
			{
				return this.redirectURLField;
			}
			set
			{
				this.redirectURLField = value;
			}
		}
		

		/**
          *
		  */
		private string fundingSourceKeyField;
		public string fundingSourceKey
		{
			get
			{
				return this.fundingSourceKeyField;
			}
			set
			{
				this.fundingSourceKeyField = value;
			}
		}
		

		/**
          *
		  */
		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public AddBankAccountResponse(){
		}



		public static AddBankAccountResponse createInstance(Dictionary<string, string> map, string prefix, int index)
		{
			AddBankAccountResponse addBankAccountResponse = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.createInstance(map, prefix + "responseEnvelope", -1);
			if (responseEnvelope != null)
			{
				addBankAccountResponse = (addBankAccountResponse == null) ? new AddBankAccountResponse() : addBankAccountResponse;
				addBankAccountResponse.responseEnvelope = responseEnvelope;
			}
			key = prefix + "execStatus";
			if (map.ContainsKey(key))
			{
				addBankAccountResponse = (addBankAccountResponse == null) ? new AddBankAccountResponse() : addBankAccountResponse;
				addBankAccountResponse.execStatus = map[key];
			}
			key = prefix + "redirectURL";
			if (map.ContainsKey(key))
			{
				addBankAccountResponse = (addBankAccountResponse == null) ? new AddBankAccountResponse() : addBankAccountResponse;
				addBankAccountResponse.redirectURL = map[key];
			}
			key = prefix + "fundingSourceKey";
			if (map.ContainsKey(key))
			{
				addBankAccountResponse = (addBankAccountResponse == null) ? new AddBankAccountResponse() : addBankAccountResponse;
				addBankAccountResponse.fundingSourceKey = map[key];
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.createInstance(map, prefix + "error", i);
				if (error != null)
				{
					addBankAccountResponse = (addBankAccountResponse == null) ? new AddBankAccountResponse() : addBankAccountResponse;
					addBankAccountResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return addBankAccountResponse;
		}
		
	}




	/**
      *Identifying the PayPal account to which this request is
      *targetted to. Caller of this API has to either provided an
      *emailAddress or an accountId. 
      */
	public partial class AddPaymentCardRequest	
	{

		/**
          *
		  */
		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope
		{
			get
			{
				return this.requestEnvelopeField;
			}
			set
			{
				this.requestEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private string emailAddressField;
		public string emailAddress
		{
			get
			{
				return this.emailAddressField;
			}
			set
			{
				this.emailAddressField = value;
			}
		}
		

		/**
          *
		  */
		private string accountIdField;
		public string accountId
		{
			get
			{
				return this.accountIdField;
			}
			set
			{
				this.accountIdField = value;
			}
		}
		

		/**
          *
		  */
		private string createAccountKeyField;
		public string createAccountKey
		{
			get
			{
				return this.createAccountKeyField;
			}
			set
			{
				this.createAccountKeyField = value;
			}
		}
		

		/**
          *
		  */
		private NameType nameOnCardField;
		public NameType nameOnCard
		{
			get
			{
				return this.nameOnCardField;
			}
			set
			{
				this.nameOnCardField = value;
			}
		}
		

		/**
          *
		  */
		private AddressType billingAddressField;
		public AddressType billingAddress
		{
			get
			{
				return this.billingAddressField;
			}
			set
			{
				this.billingAddressField = value;
			}
		}
		

		/**
          *
		  */
		private string cardOwnerDateOfBirthField;
		public string cardOwnerDateOfBirth
		{
			get
			{
				return this.cardOwnerDateOfBirthField;
			}
			set
			{
				this.cardOwnerDateOfBirthField = value;
			}
		}
		

		/**
          *
		  */
		private string cardNumberField;
		public string cardNumber
		{
			get
			{
				return this.cardNumberField;
			}
			set
			{
				this.cardNumberField = value;
			}
		}
		

		/**
          *
		  */
		private CardTypeType? cardTypeField;
		public CardTypeType? cardType
		{
			get
			{
				return this.cardTypeField;
			}
			set
			{
				this.cardTypeField = value;
			}
		}
		

		/**
          *
		  */
		private CardDateType expirationDateField;
		public CardDateType expirationDate
		{
			get
			{
				return this.expirationDateField;
			}
			set
			{
				this.expirationDateField = value;
			}
		}
		

		/**
          *
		  */
		private string cardVerificationNumberField;
		public string cardVerificationNumber
		{
			get
			{
				return this.cardVerificationNumberField;
			}
			set
			{
				this.cardVerificationNumberField = value;
			}
		}
		

		/**
          *
		  */
		private CardDateType startDateField;
		public CardDateType startDate
		{
			get
			{
				return this.startDateField;
			}
			set
			{
				this.startDateField = value;
			}
		}
		

		/**
          *
		  */
		private string issueNumberField;
		public string issueNumber
		{
			get
			{
				return this.issueNumberField;
			}
			set
			{
				this.issueNumberField = value;
			}
		}
		

		/**
          *
		  */
		private ConfirmationType? confirmationTypeField;
		public ConfirmationType? confirmationType
		{
			get
			{
				return this.confirmationTypeField;
			}
			set
			{
				this.confirmationTypeField = value;
			}
		}
		

		/**
          *
		  */
		private WebOptionsType webOptionsField;
		public WebOptionsType webOptions
		{
			get
			{
				return this.webOptionsField;
			}
			set
			{
				this.webOptionsField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public AddPaymentCardRequest(RequestEnvelope requestEnvelope, NameType nameOnCard, AddressType billingAddress, string cardNumber, CardTypeType? cardType, ConfirmationType? confirmationType){
			this.requestEnvelope = requestEnvelope;
			this.nameOnCard = nameOnCard;
			this.billingAddress = billingAddress;
			this.cardNumber = cardNumber;
			this.cardType = cardType;
			this.confirmationType = confirmationType;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public AddPaymentCardRequest(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
			}
			if (this.emailAddress != null)
			{
					sb.Append(prefix).Append("emailAddress").Append("=").Append(HttpUtility.UrlEncode(this.emailAddress, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.accountId != null)
			{
					sb.Append(prefix).Append("accountId").Append("=").Append(HttpUtility.UrlEncode(this.accountId, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.createAccountKey != null)
			{
					sb.Append(prefix).Append("createAccountKey").Append("=").Append(HttpUtility.UrlEncode(this.createAccountKey, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.nameOnCard != null)
			{
					string newPrefix = prefix + "nameOnCard" + ".";
					sb.Append(this.nameOnCardField.toNVPString(newPrefix));
			}
			if (this.billingAddress != null)
			{
					string newPrefix = prefix + "billingAddress" + ".";
					sb.Append(this.billingAddressField.toNVPString(newPrefix));
			}
			if (this.cardOwnerDateOfBirth != null)
			{
					sb.Append(prefix).Append("cardOwnerDateOfBirth").Append("=").Append(this.cardOwnerDateOfBirth).Append("&");
			}
			if (this.cardNumber != null)
			{
					sb.Append(prefix).Append("cardNumber").Append("=").Append(HttpUtility.UrlEncode(this.cardNumber, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.cardType != null)
			{
					sb.Append(prefix).Append("cardType").Append("=").Append(EnumUtils.getDescription(cardType));
					sb.Append("&");
			}
			if (this.expirationDate != null)
			{
					string newPrefix = prefix + "expirationDate" + ".";
					sb.Append(this.expirationDateField.toNVPString(newPrefix));
			}
			if (this.cardVerificationNumber != null)
			{
					sb.Append(prefix).Append("cardVerificationNumber").Append("=").Append(HttpUtility.UrlEncode(this.cardVerificationNumber, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.startDate != null)
			{
					string newPrefix = prefix + "startDate" + ".";
					sb.Append(this.startDateField.toNVPString(newPrefix));
			}
			if (this.issueNumber != null)
			{
					sb.Append(prefix).Append("issueNumber").Append("=").Append(HttpUtility.UrlEncode(this.issueNumber, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.confirmationType != null)
			{
					sb.Append(prefix).Append("confirmationType").Append("=").Append(EnumUtils.getDescription(confirmationType));
					sb.Append("&");
			}
			if (this.webOptions != null)
			{
					string newPrefix = prefix + "webOptions" + ".";
					sb.Append(this.webOptionsField.toNVPString(newPrefix));
			}
			return sb.ToString();
		}
	}




	/**
      *Valid values are: FUNDING_SOURCE_ADDED,
      *WEB_URL_VERIFICATION_NEEDED 
      */
	public partial class AddPaymentCardResponse	
	{

		/**
          *
		  */
		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope
		{
			get
			{
				return this.responseEnvelopeField;
			}
			set
			{
				this.responseEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private string execStatusField;
		public string execStatus
		{
			get
			{
				return this.execStatusField;
			}
			set
			{
				this.execStatusField = value;
			}
		}
		

		/**
          *
		  */
		private string redirectURLField;
		public string redirectURL
		{
			get
			{
				return this.redirectURLField;
			}
			set
			{
				this.redirectURLField = value;
			}
		}
		

		/**
          *
		  */
		private string fundingSourceKeyField;
		public string fundingSourceKey
		{
			get
			{
				return this.fundingSourceKeyField;
			}
			set
			{
				this.fundingSourceKeyField = value;
			}
		}
		

		/**
          *
		  */
		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public AddPaymentCardResponse(){
		}



		public static AddPaymentCardResponse createInstance(Dictionary<string, string> map, string prefix, int index)
		{
			AddPaymentCardResponse addPaymentCardResponse = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.createInstance(map, prefix + "responseEnvelope", -1);
			if (responseEnvelope != null)
			{
				addPaymentCardResponse = (addPaymentCardResponse == null) ? new AddPaymentCardResponse() : addPaymentCardResponse;
				addPaymentCardResponse.responseEnvelope = responseEnvelope;
			}
			key = prefix + "execStatus";
			if (map.ContainsKey(key))
			{
				addPaymentCardResponse = (addPaymentCardResponse == null) ? new AddPaymentCardResponse() : addPaymentCardResponse;
				addPaymentCardResponse.execStatus = map[key];
			}
			key = prefix + "redirectURL";
			if (map.ContainsKey(key))
			{
				addPaymentCardResponse = (addPaymentCardResponse == null) ? new AddPaymentCardResponse() : addPaymentCardResponse;
				addPaymentCardResponse.redirectURL = map[key];
			}
			key = prefix + "fundingSourceKey";
			if (map.ContainsKey(key))
			{
				addPaymentCardResponse = (addPaymentCardResponse == null) ? new AddPaymentCardResponse() : addPaymentCardResponse;
				addPaymentCardResponse.fundingSourceKey = map[key];
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.createInstance(map, prefix + "error", i);
				if (error != null)
				{
					addPaymentCardResponse = (addPaymentCardResponse == null) ? new AddPaymentCardResponse() : addPaymentCardResponse;
					addPaymentCardResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return addPaymentCardResponse;
		}
		
	}




	/**
      *Identifying the PayPal account to which this request is
      *targetted to. Caller of this API has to either provided an
      *emailAddress or an accountId. 
      */
	public partial class SetFundingSourceConfirmedRequest	
	{

		/**
          *
		  */
		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope
		{
			get
			{
				return this.requestEnvelopeField;
			}
			set
			{
				this.requestEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private string emailAddressField;
		public string emailAddress
		{
			get
			{
				return this.emailAddressField;
			}
			set
			{
				this.emailAddressField = value;
			}
		}
		

		/**
          *
		  */
		private string accountIdField;
		public string accountId
		{
			get
			{
				return this.accountIdField;
			}
			set
			{
				this.accountIdField = value;
			}
		}
		

		/**
          *
		  */
		private string fundingSourceKeyField;
		public string fundingSourceKey
		{
			get
			{
				return this.fundingSourceKeyField;
			}
			set
			{
				this.fundingSourceKeyField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public SetFundingSourceConfirmedRequest(RequestEnvelope requestEnvelope, string fundingSourceKey){
			this.requestEnvelope = requestEnvelope;
			this.fundingSourceKey = fundingSourceKey;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public SetFundingSourceConfirmedRequest(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
			}
			if (this.emailAddress != null)
			{
					sb.Append(prefix).Append("emailAddress").Append("=").Append(HttpUtility.UrlEncode(this.emailAddress, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.accountId != null)
			{
					sb.Append(prefix).Append("accountId").Append("=").Append(HttpUtility.UrlEncode(this.accountId, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.fundingSourceKey != null)
			{
					sb.Append(prefix).Append("fundingSourceKey").Append("=").Append(HttpUtility.UrlEncode(this.fundingSourceKey, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/**
      *
      */
	public partial class SetFundingSourceConfirmedResponse	
	{

		/**
          *
		  */
		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope
		{
			get
			{
				return this.responseEnvelopeField;
			}
			set
			{
				this.responseEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public SetFundingSourceConfirmedResponse(){
		}



		public static SetFundingSourceConfirmedResponse createInstance(Dictionary<string, string> map, string prefix, int index)
		{
			SetFundingSourceConfirmedResponse setFundingSourceConfirmedResponse = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.createInstance(map, prefix + "responseEnvelope", -1);
			if (responseEnvelope != null)
			{
				setFundingSourceConfirmedResponse = (setFundingSourceConfirmedResponse == null) ? new SetFundingSourceConfirmedResponse() : setFundingSourceConfirmedResponse;
				setFundingSourceConfirmedResponse.responseEnvelope = responseEnvelope;
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.createInstance(map, prefix + "error", i);
				if (error != null)
				{
					setFundingSourceConfirmedResponse = (setFundingSourceConfirmedResponse == null) ? new SetFundingSourceConfirmedResponse() : setFundingSourceConfirmedResponse;
					setFundingSourceConfirmedResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return setFundingSourceConfirmedResponse;
		}
		
	}




	/**
      *Identifies a PayPal account to which this request is
      *targeted. Caller of this API has to provide ONLY one of
      *these inputs: emailAddress, accountId or phoneNumber. 
      */
	public partial class AccountIdentifierType	
	{

		/**
          *
		  */
		private string emailAddressField;
		public string emailAddress
		{
			get
			{
				return this.emailAddressField;
			}
			set
			{
				this.emailAddressField = value;
			}
		}
		

		/**
          *
		  */
		private string phoneNumberField;
		public string phoneNumber
		{
			get
			{
				return this.phoneNumberField;
			}
			set
			{
				this.phoneNumberField = value;
			}
		}
		

		/**
          *
		  */
		private string accountIdField;
		public string accountId
		{
			get
			{
				return this.accountIdField;
			}
			set
			{
				this.accountIdField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public AccountIdentifierType(string emailAddress, string phoneNumber, string accountId){
			this.emailAddress = emailAddress;
			this.phoneNumber = phoneNumber;
			this.accountId = accountId;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public AccountIdentifierType(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.emailAddress != null)
			{
					sb.Append(prefix).Append("emailAddress").Append("=").Append(HttpUtility.UrlEncode(this.emailAddress, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.phoneNumber != null)
			{
					sb.Append(prefix).Append("phoneNumber").Append("=").Append(HttpUtility.UrlEncode(this.phoneNumber, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.accountId != null)
			{
					sb.Append(prefix).Append("accountId").Append("=").Append(HttpUtility.UrlEncode(this.accountId, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/**
      *Identifies a PayPal account to which this request is
      *targeted. Caller of this API has to provide ONLY one of
      *these inputs: emailAddress, accountId or phoneNumber. 
      */
	public partial class CheckComplianceStatusRequest	
	{

		/**
          *
		  */
		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope
		{
			get
			{
				return this.requestEnvelopeField;
			}
			set
			{
				this.requestEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private AccountIdentifierType accountIdentifierField;
		public AccountIdentifierType accountIdentifier
		{
			get
			{
				return this.accountIdentifierField;
			}
			set
			{
				this.accountIdentifierField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public CheckComplianceStatusRequest(RequestEnvelope requestEnvelope, AccountIdentifierType accountIdentifier){
			this.requestEnvelope = requestEnvelope;
			this.accountIdentifier = accountIdentifier;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public CheckComplianceStatusRequest(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
			}
			if (this.accountIdentifier != null)
			{
					string newPrefix = prefix + "accountIdentifier" + ".";
					sb.Append(this.accountIdentifierField.toNVPString(newPrefix));
			}
			return sb.ToString();
		}
	}




	/**
      *Returned values are: ALLOW|DENY 
      */
	public partial class CheckComplianceStatusResponse	
	{

		/**
          *
		  */
		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope
		{
			get
			{
				return this.responseEnvelopeField;
			}
			set
			{
				this.responseEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private string execStatusField;
		public string execStatus
		{
			get
			{
				return this.execStatusField;
			}
			set
			{
				this.execStatusField = value;
			}
		}
		

		/**
          *
		  */
		private string denialReasonField;
		public string denialReason
		{
			get
			{
				return this.denialReasonField;
			}
			set
			{
				this.denialReasonField = value;
			}
		}
		

		/**
          *
		  */
		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public CheckComplianceStatusResponse(){
		}



		public static CheckComplianceStatusResponse createInstance(Dictionary<string, string> map, string prefix, int index)
		{
			CheckComplianceStatusResponse checkComplianceStatusResponse = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.createInstance(map, prefix + "responseEnvelope", -1);
			if (responseEnvelope != null)
			{
				checkComplianceStatusResponse = (checkComplianceStatusResponse == null) ? new CheckComplianceStatusResponse() : checkComplianceStatusResponse;
				checkComplianceStatusResponse.responseEnvelope = responseEnvelope;
			}
			key = prefix + "execStatus";
			if (map.ContainsKey(key))
			{
				checkComplianceStatusResponse = (checkComplianceStatusResponse == null) ? new CheckComplianceStatusResponse() : checkComplianceStatusResponse;
				checkComplianceStatusResponse.execStatus = map[key];
			}
			key = prefix + "denialReason";
			if (map.ContainsKey(key))
			{
				checkComplianceStatusResponse = (checkComplianceStatusResponse == null) ? new CheckComplianceStatusResponse() : checkComplianceStatusResponse;
				checkComplianceStatusResponse.denialReason = map[key];
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.createInstance(map, prefix + "error", i);
				if (error != null)
				{
					checkComplianceStatusResponse = (checkComplianceStatusResponse == null) ? new CheckComplianceStatusResponse() : checkComplianceStatusResponse;
					checkComplianceStatusResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return checkComplianceStatusResponse;
		}
		
	}




	/**
      *
      */
	public partial class NameType	
	{

		/**
          *
		  */
		private string salutationField;
		public string salutation
		{
			get
			{
				return this.salutationField;
			}
			set
			{
				this.salutationField = value;
			}
		}
		

		/**
          *
		  */
		private string firstNameField;
		public string firstName
		{
			get
			{
				return this.firstNameField;
			}
			set
			{
				this.firstNameField = value;
			}
		}
		

		/**
          *
		  */
		private string middleNameField;
		public string middleName
		{
			get
			{
				return this.middleNameField;
			}
			set
			{
				this.middleNameField = value;
			}
		}
		

		/**
          *
		  */
		private string lastNameField;
		public string lastName
		{
			get
			{
				return this.lastNameField;
			}
			set
			{
				this.lastNameField = value;
			}
		}
		

		/**
          *
		  */
		private string suffixField;
		public string suffix
		{
			get
			{
				return this.suffixField;
			}
			set
			{
				this.suffixField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public NameType(string firstName, string lastName){
			this.firstName = firstName;
			this.lastName = lastName;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public NameType(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.salutation != null)
			{
					sb.Append(prefix).Append("salutation").Append("=").Append(HttpUtility.UrlEncode(this.salutation, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.firstName != null)
			{
					sb.Append(prefix).Append("firstName").Append("=").Append(HttpUtility.UrlEncode(this.firstName, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.middleName != null)
			{
					sb.Append(prefix).Append("middleName").Append("=").Append(HttpUtility.UrlEncode(this.middleName, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.lastName != null)
			{
					sb.Append(prefix).Append("lastName").Append("=").Append(HttpUtility.UrlEncode(this.lastName, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.suffix != null)
			{
					sb.Append(prefix).Append("suffix").Append("=").Append(HttpUtility.UrlEncode(this.suffix, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}

		public static NameType createInstance(Dictionary<string, string> map, string prefix, int index)
		{
			NameType nameType = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			key = prefix + "salutation";
			if (map.ContainsKey(key))
			{
				nameType = (nameType == null) ? new NameType() : nameType;
				nameType.salutation = map[key];
			}
			key = prefix + "firstName";
			if (map.ContainsKey(key))
			{
				nameType = (nameType == null) ? new NameType() : nameType;
				nameType.firstName = map[key];
			}
			key = prefix + "middleName";
			if (map.ContainsKey(key))
			{
				nameType = (nameType == null) ? new NameType() : nameType;
				nameType.middleName = map[key];
			}
			key = prefix + "lastName";
			if (map.ContainsKey(key))
			{
				nameType = (nameType == null) ? new NameType() : nameType;
				nameType.lastName = map[key];
			}
			key = prefix + "suffix";
			if (map.ContainsKey(key))
			{
				nameType = (nameType == null) ? new NameType() : nameType;
				nameType.suffix = map[key];
			}
			return nameType;
		}
		
	}




	/**
      *
      */
	public partial class AddressType	
	{

		/**
          *
		  */
		private string line1Field;
		public string line1
		{
			get
			{
				return this.line1Field;
			}
			set
			{
				this.line1Field = value;
			}
		}
		

		/**
          *
		  */
		private string line2Field;
		public string line2
		{
			get
			{
				return this.line2Field;
			}
			set
			{
				this.line2Field = value;
			}
		}
		

		/**
          *
		  */
		private string cityField;
		public string city
		{
			get
			{
				return this.cityField;
			}
			set
			{
				this.cityField = value;
			}
		}
		

		/**
          *
		  */
		private string stateField;
		public string state
		{
			get
			{
				return this.stateField;
			}
			set
			{
				this.stateField = value;
			}
		}
		

		/**
          *
		  */
		private string postalCodeField;
		public string postalCode
		{
			get
			{
				return this.postalCodeField;
			}
			set
			{
				this.postalCodeField = value;
			}
		}
		

		/**
          *
		  */
		private string countryCodeField;
		public string countryCode
		{
			get
			{
				return this.countryCodeField;
			}
			set
			{
				this.countryCodeField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public AddressType(string line1, string countryCode){
			this.line1 = line1;
			this.countryCode = countryCode;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public AddressType(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.line1 != null)
			{
					sb.Append(prefix).Append("line1").Append("=").Append(HttpUtility.UrlEncode(this.line1, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.line2 != null)
			{
					sb.Append(prefix).Append("line2").Append("=").Append(HttpUtility.UrlEncode(this.line2, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.city != null)
			{
					sb.Append(prefix).Append("city").Append("=").Append(HttpUtility.UrlEncode(this.city, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.state != null)
			{
					sb.Append(prefix).Append("state").Append("=").Append(HttpUtility.UrlEncode(this.state, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.postalCode != null)
			{
					sb.Append(prefix).Append("postalCode").Append("=").Append(HttpUtility.UrlEncode(this.postalCode, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.countryCode != null)
			{
					sb.Append(prefix).Append("countryCode").Append("=").Append(HttpUtility.UrlEncode(this.countryCode, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/**
      *Ask end-user to also initiate confirmation of their mobile
      *phone. This number must be supplied by the API caller (using
      *mobilePhoneNumber) Default=false. 
      */
	public partial class CreateAccountWebOptionsType	
	{

		/**
          *
		  */
		private string returnUrlField;
		public string returnUrl
		{
			get
			{
				return this.returnUrlField;
			}
			set
			{
				this.returnUrlField = value;
			}
		}
		

		/**
          *
		  */
		private bool? showAddCreditCardField;
		public bool? showAddCreditCard
		{
			get
			{
				return this.showAddCreditCardField;
			}
			set
			{
				this.showAddCreditCardField = value;
			}
		}
		

		/**
          *
		  */
		private bool? showMobileConfirmField;
		public bool? showMobileConfirm
		{
			get
			{
				return this.showMobileConfirmField;
			}
			set
			{
				this.showMobileConfirmField = value;
			}
		}
		

		/**
          *
		  */
		private string returnUrlDescriptionField;
		public string returnUrlDescription
		{
			get
			{
				return this.returnUrlDescriptionField;
			}
			set
			{
				this.returnUrlDescriptionField = value;
			}
		}
		

		/**
          *
		  */
		private bool? useMiniBrowserField;
		public bool? useMiniBrowser
		{
			get
			{
				return this.useMiniBrowserField;
			}
			set
			{
				this.useMiniBrowserField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public CreateAccountWebOptionsType(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.returnUrl != null)
			{
					sb.Append(prefix).Append("returnUrl").Append("=").Append(HttpUtility.UrlEncode(this.returnUrl, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.showAddCreditCard != null)
			{
					sb.Append(prefix).Append("showAddCreditCard").Append("=").Append(this.showAddCreditCard).Append("&");
			}
			if (this.showMobileConfirm != null)
			{
					sb.Append(prefix).Append("showMobileConfirm").Append("=").Append(this.showMobileConfirm).Append("&");
			}
			if (this.returnUrlDescription != null)
			{
					sb.Append(prefix).Append("returnUrlDescription").Append("=").Append(HttpUtility.UrlEncode(this.returnUrlDescription, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.useMiniBrowser != null)
			{
					sb.Append(prefix).Append("useMiniBrowser").Append("=").Append(this.useMiniBrowser).Append("&");
			}
			return sb.ToString();
		}
	}




	/**
      *PayPal Business Category. i.e., baby - 1004 
      */
	public partial class BusinessInfoType	
	{

		/**
          *
		  */
		private string businessNameField;
		public string businessName
		{
			get
			{
				return this.businessNameField;
			}
			set
			{
				this.businessNameField = value;
			}
		}
		

		/**
          *
		  */
		private AddressType businessAddressField;
		public AddressType businessAddress
		{
			get
			{
				return this.businessAddressField;
			}
			set
			{
				this.businessAddressField = value;
			}
		}
		

		/**
          *
		  */
		private string workPhoneField;
		public string workPhone
		{
			get
			{
				return this.workPhoneField;
			}
			set
			{
				this.workPhoneField = value;
			}
		}
		

		/**
          *
		  */
		private int? categoryField;
		public int? category
		{
			get
			{
				return this.categoryField;
			}
			set
			{
				this.categoryField = value;
			}
		}
		

		/**
          *
		  */
		private int? subCategoryField;
		public int? subCategory
		{
			get
			{
				return this.subCategoryField;
			}
			set
			{
				this.subCategoryField = value;
			}
		}
		

		/**
          *
		  */
		private int? merchantCategoryCodeField;
		public int? merchantCategoryCode
		{
			get
			{
				return this.merchantCategoryCodeField;
			}
			set
			{
				this.merchantCategoryCodeField = value;
			}
		}
		

		/**
          *
		  */
		private string doingBusinessAsField;
		public string doingBusinessAs
		{
			get
			{
				return this.doingBusinessAsField;
			}
			set
			{
				this.doingBusinessAsField = value;
			}
		}
		

		/**
          *
		  */
		private string customerServicePhoneField;
		public string customerServicePhone
		{
			get
			{
				return this.customerServicePhoneField;
			}
			set
			{
				this.customerServicePhoneField = value;
			}
		}
		

		/**
          *
		  */
		private string customerServiceEmailField;
		public string customerServiceEmail
		{
			get
			{
				return this.customerServiceEmailField;
			}
			set
			{
				this.customerServiceEmailField = value;
			}
		}
		

		/**
          *
		  */
		private string disputeEmailField;
		public string disputeEmail
		{
			get
			{
				return this.disputeEmailField;
			}
			set
			{
				this.disputeEmailField = value;
			}
		}
		

		/**
          *
		  */
		private string webSiteField;
		public string webSite
		{
			get
			{
				return this.webSiteField;
			}
			set
			{
				this.webSiteField = value;
			}
		}
		

		/**
          *
		  */
		private string companyIdField;
		public string companyId
		{
			get
			{
				return this.companyIdField;
			}
			set
			{
				this.companyIdField = value;
			}
		}
		

		/**
          *
		  */
		private string dateOfEstablishmentField;
		public string dateOfEstablishment
		{
			get
			{
				return this.dateOfEstablishmentField;
			}
			set
			{
				this.dateOfEstablishmentField = value;
			}
		}
		

		/**
          *
		  */
		private BusinessType? businessTypeField;
		public BusinessType? businessType
		{
			get
			{
				return this.businessTypeField;
			}
			set
			{
				this.businessTypeField = value;
			}
		}
		

		/**
          *
		  */
		private BusinessSubtypeType? businessSubtypeField;
		public BusinessSubtypeType? businessSubtype
		{
			get
			{
				return this.businessSubtypeField;
			}
			set
			{
				this.businessSubtypeField = value;
			}
		}
		

		/**
          *
		  */
		private string incorporationIdField;
		public string incorporationId
		{
			get
			{
				return this.incorporationIdField;
			}
			set
			{
				this.incorporationIdField = value;
			}
		}
		

		/**
          *
		  */
		private decimal? averagePriceField;
		public decimal? averagePrice
		{
			get
			{
				return this.averagePriceField;
			}
			set
			{
				this.averagePriceField = value;
			}
		}
		

		/**
          *
		  */
		private decimal? averageMonthlyVolumeField;
		public decimal? averageMonthlyVolume
		{
			get
			{
				return this.averageMonthlyVolumeField;
			}
			set
			{
				this.averageMonthlyVolumeField = value;
			}
		}
		

		/**
          *
		  */
		private int? percentageRevenueFromOnlineField;
		public int? percentageRevenueFromOnline
		{
			get
			{
				return this.percentageRevenueFromOnlineField;
			}
			set
			{
				this.percentageRevenueFromOnlineField = value;
			}
		}
		

		/**
          *
		  */
		private List<SalesVenueType?> salesVenueField = new List<SalesVenueType?>();
		public List<SalesVenueType?> salesVenue
		{
			get
			{
				return this.salesVenueField;
			}
			set
			{
				this.salesVenueField = value;
			}
		}
		

		/**
          *
		  */
		private string salesVenueDescField;
		public string salesVenueDesc
		{
			get
			{
				return this.salesVenueDescField;
			}
			set
			{
				this.salesVenueDescField = value;
			}
		}
		

		/**
          *
		  */
		private string vatIdField;
		public string vatId
		{
			get
			{
				return this.vatIdField;
			}
			set
			{
				this.vatIdField = value;
			}
		}
		

		/**
          *
		  */
		private string vatCountryCodeField;
		public string vatCountryCode
		{
			get
			{
				return this.vatCountryCodeField;
			}
			set
			{
				this.vatCountryCodeField = value;
			}
		}
		

		/**
          *
		  */
		private string commercialRegistrationLocationField;
		public string commercialRegistrationLocation
		{
			get
			{
				return this.commercialRegistrationLocationField;
			}
			set
			{
				this.commercialRegistrationLocationField = value;
			}
		}
		

		/**
          *
		  */
		private AddressType principalPlaceOfBusinessAddressField;
		public AddressType principalPlaceOfBusinessAddress
		{
			get
			{
				return this.principalPlaceOfBusinessAddressField;
			}
			set
			{
				this.principalPlaceOfBusinessAddressField = value;
			}
		}
		

		/**
          *
		  */
		private AddressType registeredOfficeAddressField;
		public AddressType registeredOfficeAddress
		{
			get
			{
				return this.registeredOfficeAddressField;
			}
			set
			{
				this.registeredOfficeAddressField = value;
			}
		}
		

		/**
          *
		  */
		private string establishmentCountryCodeField;
		public string establishmentCountryCode
		{
			get
			{
				return this.establishmentCountryCodeField;
			}
			set
			{
				this.establishmentCountryCodeField = value;
			}
		}
		

		/**
          *
		  */
		private string establishmentStateField;
		public string establishmentState
		{
			get
			{
				return this.establishmentStateField;
			}
			set
			{
				this.establishmentStateField = value;
			}
		}
		

		/**
          *
		  */
		private List<BusinessStakeholderType> businessStakeholderField = new List<BusinessStakeholderType>();
		public List<BusinessStakeholderType> businessStakeholder
		{
			get
			{
				return this.businessStakeholderField;
			}
			set
			{
				this.businessStakeholderField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public BusinessInfoType(string businessName, AddressType businessAddress, string workPhone){
			this.businessName = businessName;
			this.businessAddress = businessAddress;
			this.workPhone = workPhone;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public BusinessInfoType(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.businessName != null)
			{
					sb.Append(prefix).Append("businessName").Append("=").Append(HttpUtility.UrlEncode(this.businessName, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.businessAddress != null)
			{
					string newPrefix = prefix + "businessAddress" + ".";
					sb.Append(this.businessAddressField.toNVPString(newPrefix));
			}
			if (this.workPhone != null)
			{
					sb.Append(prefix).Append("workPhone").Append("=").Append(HttpUtility.UrlEncode(this.workPhone, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.category != null)
			{
					sb.Append(prefix).Append("category").Append("=").Append(this.category).Append("&");
			}
			if (this.subCategory != null)
			{
					sb.Append(prefix).Append("subCategory").Append("=").Append(this.subCategory).Append("&");
			}
			if (this.merchantCategoryCode != null)
			{
					sb.Append(prefix).Append("merchantCategoryCode").Append("=").Append(this.merchantCategoryCode).Append("&");
			}
			if (this.doingBusinessAs != null)
			{
					sb.Append(prefix).Append("doingBusinessAs").Append("=").Append(HttpUtility.UrlEncode(this.doingBusinessAs, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.customerServicePhone != null)
			{
					sb.Append(prefix).Append("customerServicePhone").Append("=").Append(HttpUtility.UrlEncode(this.customerServicePhone, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.customerServiceEmail != null)
			{
					sb.Append(prefix).Append("customerServiceEmail").Append("=").Append(HttpUtility.UrlEncode(this.customerServiceEmail, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.disputeEmail != null)
			{
					sb.Append(prefix).Append("disputeEmail").Append("=").Append(HttpUtility.UrlEncode(this.disputeEmail, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.webSite != null)
			{
					sb.Append(prefix).Append("webSite").Append("=").Append(HttpUtility.UrlEncode(this.webSite, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.companyId != null)
			{
					sb.Append(prefix).Append("companyId").Append("=").Append(HttpUtility.UrlEncode(this.companyId, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.dateOfEstablishment != null)
			{
					sb.Append(prefix).Append("dateOfEstablishment").Append("=").Append(this.dateOfEstablishment).Append("&");
			}
			if (this.businessType != null)
			{
					sb.Append(prefix).Append("businessType").Append("=").Append(EnumUtils.getDescription(businessType));
					sb.Append("&");
			}
			if (this.businessSubtype != null)
			{
					sb.Append(prefix).Append("businessSubtype").Append("=").Append(EnumUtils.getDescription(businessSubtype));
					sb.Append("&");
			}
			if (this.incorporationId != null)
			{
					sb.Append(prefix).Append("incorporationId").Append("=").Append(HttpUtility.UrlEncode(this.incorporationId, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.averagePrice != null)
			{
					sb.Append(prefix).Append("averagePrice").Append("=").Append(this.averagePrice).Append("&");
			}
			if (this.averageMonthlyVolume != null)
			{
					sb.Append(prefix).Append("averageMonthlyVolume").Append("=").Append(this.averageMonthlyVolume).Append("&");
			}
			if (this.percentageRevenueFromOnline != null)
			{
					sb.Append(prefix).Append("percentageRevenueFromOnline").Append("=").Append(this.percentageRevenueFromOnline).Append("&");
			}
			for (int i = 0; i < this.salesVenue.Count; i++)
			{
				if (this.salesVenue[i] != null)
				{
					sb.Append(prefix).Append("salesVenue").Append(i).Append(")=").Append(EnumUtils.getDescription(salesVenue[i]));
					sb.Append("&");
				}
			}
			if (this.salesVenueDesc != null)
			{
					sb.Append(prefix).Append("salesVenueDesc").Append("=").Append(HttpUtility.UrlEncode(this.salesVenueDesc, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.vatId != null)
			{
					sb.Append(prefix).Append("vatId").Append("=").Append(HttpUtility.UrlEncode(this.vatId, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.vatCountryCode != null)
			{
					sb.Append(prefix).Append("vatCountryCode").Append("=").Append(HttpUtility.UrlEncode(this.vatCountryCode, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.commercialRegistrationLocation != null)
			{
					sb.Append(prefix).Append("commercialRegistrationLocation").Append("=").Append(HttpUtility.UrlEncode(this.commercialRegistrationLocation, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.principalPlaceOfBusinessAddress != null)
			{
					string newPrefix = prefix + "principalPlaceOfBusinessAddress" + ".";
					sb.Append(this.principalPlaceOfBusinessAddressField.toNVPString(newPrefix));
			}
			if (this.registeredOfficeAddress != null)
			{
					string newPrefix = prefix + "registeredOfficeAddress" + ".";
					sb.Append(this.registeredOfficeAddressField.toNVPString(newPrefix));
			}
			if (this.establishmentCountryCode != null)
			{
					sb.Append(prefix).Append("establishmentCountryCode").Append("=").Append(HttpUtility.UrlEncode(this.establishmentCountryCode, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.establishmentState != null)
			{
					sb.Append(prefix).Append("establishmentState").Append("=").Append(HttpUtility.UrlEncode(this.establishmentState, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			for (int i = 0; i < this.businessStakeholder.Count; i++)
			{
				if (this.businessStakeholder[i] != null)
				{
					string newPrefix = prefix + "businessStakeholder" + "(" + i + ").";
					sb.Append(this.businessStakeholder[i].toNVPString(newPrefix));
				}
			}
			return sb.ToString();
		}
	}




	/**
      *Info about Stakeholders such as partner, beneficial, owner,
      *director etc. 
      */
	public partial class BusinessStakeholderType	
	{

		/**
          *
		  */
		private StakeholderRoleType? roleField;
		public StakeholderRoleType? role
		{
			get
			{
				return this.roleField;
			}
			set
			{
				this.roleField = value;
			}
		}
		

		/**
          *
		  */
		private NameType nameField;
		public NameType name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}
		

		/**
          *
		  */
		private string fullLegalNameField;
		public string fullLegalName
		{
			get
			{
				return this.fullLegalNameField;
			}
			set
			{
				this.fullLegalNameField = value;
			}
		}
		

		/**
          *
		  */
		private AddressType addressField;
		public AddressType address
		{
			get
			{
				return this.addressField;
			}
			set
			{
				this.addressField = value;
			}
		}
		

		/**
          *
		  */
		private string dateOfBirthField;
		public string dateOfBirth
		{
			get
			{
				return this.dateOfBirthField;
			}
			set
			{
				this.dateOfBirthField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public BusinessStakeholderType(StakeholderRoleType? role){
			this.role = role;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public BusinessStakeholderType(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.role != null)
			{
					sb.Append(prefix).Append("role").Append("=").Append(EnumUtils.getDescription(role));
					sb.Append("&");
			}
			if (this.name != null)
			{
					string newPrefix = prefix + "name" + ".";
					sb.Append(this.nameField.toNVPString(newPrefix));
			}
			if (this.fullLegalName != null)
			{
					sb.Append(prefix).Append("fullLegalName").Append("=").Append(HttpUtility.UrlEncode(this.fullLegalName, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.address != null)
			{
					string newPrefix = prefix + "address" + ".";
					sb.Append(this.addressField.toNVPString(newPrefix));
			}
			if (this.dateOfBirth != null)
			{
					sb.Append(prefix).Append("dateOfBirth").Append("=").Append(this.dateOfBirth).Append("&");
			}
			return sb.ToString();
		}
	}




	/**
      *Info about PayPal user such as emailAddress, accountId,
      *firstName, lastName etc. 
      */
	public partial class UserInfoType	
	{

		/**
          *
		  */
		private string emailAddressField;
		public string emailAddress
		{
			get
			{
				return this.emailAddressField;
			}
			set
			{
				this.emailAddressField = value;
			}
		}
		

		/**
          *
		  */
		private string accountTypeField;
		public string accountType
		{
			get
			{
				return this.accountTypeField;
			}
			set
			{
				this.accountTypeField = value;
			}
		}
		

		/**
          *
		  */
		private string accountIdField;
		public string accountId
		{
			get
			{
				return this.accountIdField;
			}
			set
			{
				this.accountIdField = value;
			}
		}
		

		/**
          *
		  */
		private NameType nameField;
		public NameType name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}
		

		/**
          *
		  */
		private string businessNameField;
		public string businessName
		{
			get
			{
				return this.businessNameField;
			}
			set
			{
				this.businessNameField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public UserInfoType(){
		}



		public static UserInfoType createInstance(Dictionary<string, string> map, string prefix, int index)
		{
			UserInfoType userInfoType = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			key = prefix + "emailAddress";
			if (map.ContainsKey(key))
			{
				userInfoType = (userInfoType == null) ? new UserInfoType() : userInfoType;
				userInfoType.emailAddress = map[key];
			}
			key = prefix + "accountType";
			if (map.ContainsKey(key))
			{
				userInfoType = (userInfoType == null) ? new UserInfoType() : userInfoType;
				userInfoType.accountType = map[key];
			}
			key = prefix + "accountId";
			if (map.ContainsKey(key))
			{
				userInfoType = (userInfoType == null) ? new UserInfoType() : userInfoType;
				userInfoType.accountId = map[key];
			}
			NameType name =  NameType.createInstance(map, prefix + "name", -1);
			if (name != null)
			{
				userInfoType = (userInfoType == null) ? new UserInfoType() : userInfoType;
				userInfoType.name = name;
			}
			key = prefix + "businessName";
			if (map.ContainsKey(key))
			{
				userInfoType = (userInfoType == null) ? new UserInfoType() : userInfoType;
				userInfoType.businessName = map[key];
			}
			return userInfoType;
		}
		
	}




	/**
      *
      */
	public partial class WebOptionsType	
	{

		/**
          *
		  */
		private string returnUrlField;
		public string returnUrl
		{
			get
			{
				return this.returnUrlField;
			}
			set
			{
				this.returnUrlField = value;
			}
		}
		

		/**
          *
		  */
		private string cancelUrlField;
		public string cancelUrl
		{
			get
			{
				return this.cancelUrlField;
			}
			set
			{
				this.cancelUrlField = value;
			}
		}
		

		/**
          *
		  */
		private string returnUrlDescriptionField;
		public string returnUrlDescription
		{
			get
			{
				return this.returnUrlDescriptionField;
			}
			set
			{
				this.returnUrlDescriptionField = value;
			}
		}
		

		/**
          *
		  */
		private string cancelUrlDescriptionField;
		public string cancelUrlDescription
		{
			get
			{
				return this.cancelUrlDescriptionField;
			}
			set
			{
				this.cancelUrlDescriptionField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public WebOptionsType(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.returnUrl != null)
			{
					sb.Append(prefix).Append("returnUrl").Append("=").Append(HttpUtility.UrlEncode(this.returnUrl, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.cancelUrl != null)
			{
					sb.Append(prefix).Append("cancelUrl").Append("=").Append(HttpUtility.UrlEncode(this.cancelUrl, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.returnUrlDescription != null)
			{
					sb.Append(prefix).Append("returnUrlDescription").Append("=").Append(HttpUtility.UrlEncode(this.returnUrlDescription, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.cancelUrlDescription != null)
			{
					sb.Append(prefix).Append("cancelUrlDescription").Append("=").Append(HttpUtility.UrlEncode(this.cancelUrlDescription, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/**
      *Month in integer format, between 1 and 12 
      */
	public partial class CardDateType	
	{

		/**
          *
		  */
		private int? monthField;
		public int? month
		{
			get
			{
				return this.monthField;
			}
			set
			{
				this.monthField = value;
			}
		}
		

		/**
          *
		  */
		private int? yearField;
		public int? year
		{
			get
			{
				return this.yearField;
			}
			set
			{
				this.yearField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public CardDateType(int? month, int? year){
			this.month = month;
			this.year = year;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public CardDateType(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.month != null)
			{
					sb.Append(prefix).Append("month").Append("=").Append(this.month).Append("&");
			}
			if (this.year != null)
			{
					sb.Append(prefix).Append("year").Append("=").Append(this.year).Append("&");
			}
			return sb.ToString();
		}
	}





}