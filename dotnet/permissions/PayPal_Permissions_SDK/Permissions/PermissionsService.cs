using System.Xml;
using PayPal;
using PayPal.Authentication;
using PayPal.Util;
using PayPal.Manager;
using PayPal.NVP;
using PayPal.Permissions.Model;

namespace PayPal.Permissions 
{
	public partial class PermissionsService : BasePayPalService 
	{

		// Service Version
		private const string ServiceVersion = "";

		// Service Name
		private const string ServiceName = "Permissions";
		
		//SDK Name
		private const string SDKName = "sdkname";
	
		//SDK Version
		private const string SDKVersion = "sdkversion";

		public PermissionsService() {}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public RequestPermissionsResponse RequestPermissions(RequestPermissionsRequest requestPermissionsRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(requestPermissionsRequest.ToNVPString(string.Empty), ServiceName, "RequestPermissions", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return RequestPermissionsResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public RequestPermissionsResponse RequestPermissions(RequestPermissionsRequest requestPermissionsRequest)
	 	{
	 		return RequestPermissions(requestPermissionsRequest,(string) null);
	 	}
	 	
	 	/**	
          *AUTO_GENERATED
	 	  */
	 	public RequestPermissionsResponse RequestPermissions(RequestPermissionsRequest requestPermissionsRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(requestPermissionsRequest.ToNVPString(string.Empty), ServiceName, "RequestPermissions", credential);
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return RequestPermissionsResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetAccessTokenResponse GetAccessToken(GetAccessTokenRequest getAccessTokenRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(getAccessTokenRequest.ToNVPString(string.Empty), ServiceName, "GetAccessToken", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return GetAccessTokenResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetAccessTokenResponse GetAccessToken(GetAccessTokenRequest getAccessTokenRequest)
	 	{
	 		return GetAccessToken(getAccessTokenRequest,(string) null);
	 	}
	 	
	 	/**	
          *AUTO_GENERATED
	 	  */
	 	public GetAccessTokenResponse GetAccessToken(GetAccessTokenRequest getAccessTokenRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(getAccessTokenRequest.ToNVPString(string.Empty), ServiceName, "GetAccessToken", credential);
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return GetAccessTokenResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetPermissionsResponse GetPermissions(GetPermissionsRequest getPermissionsRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(getPermissionsRequest.ToNVPString(string.Empty), ServiceName, "GetPermissions", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return GetPermissionsResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetPermissionsResponse GetPermissions(GetPermissionsRequest getPermissionsRequest)
	 	{
	 		return GetPermissions(getPermissionsRequest,(string) null);
	 	}
	 	
	 	/**	
          *AUTO_GENERATED
	 	  */
	 	public GetPermissionsResponse GetPermissions(GetPermissionsRequest getPermissionsRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(getPermissionsRequest.ToNVPString(string.Empty), ServiceName, "GetPermissions", credential);
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return GetPermissionsResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public CancelPermissionsResponse CancelPermissions(CancelPermissionsRequest cancelPermissionsRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(cancelPermissionsRequest.ToNVPString(string.Empty), ServiceName, "CancelPermissions", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return CancelPermissionsResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public CancelPermissionsResponse CancelPermissions(CancelPermissionsRequest cancelPermissionsRequest)
	 	{
	 		return CancelPermissions(cancelPermissionsRequest,(string) null);
	 	}
	 	
	 	/**	
          *AUTO_GENERATED
	 	  */
	 	public CancelPermissionsResponse CancelPermissions(CancelPermissionsRequest cancelPermissionsRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(cancelPermissionsRequest.ToNVPString(string.Empty), ServiceName, "CancelPermissions", credential);
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return CancelPermissionsResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetBasicPersonalDataResponse GetBasicPersonalData(GetBasicPersonalDataRequest getBasicPersonalDataRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(getBasicPersonalDataRequest.ToNVPString(string.Empty), ServiceName, "GetBasicPersonalData", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return GetBasicPersonalDataResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetBasicPersonalDataResponse GetBasicPersonalData(GetBasicPersonalDataRequest getBasicPersonalDataRequest)
	 	{
	 		return GetBasicPersonalData(getBasicPersonalDataRequest,(string) null);
	 	}
	 	
	 	/**	
          *AUTO_GENERATED
	 	  */
	 	public GetBasicPersonalDataResponse GetBasicPersonalData(GetBasicPersonalDataRequest getBasicPersonalDataRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(getBasicPersonalDataRequest.ToNVPString(string.Empty), ServiceName, "GetBasicPersonalData", credential);
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return GetBasicPersonalDataResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetAdvancedPersonalDataResponse GetAdvancedPersonalData(GetAdvancedPersonalDataRequest getAdvancedPersonalDataRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(getAdvancedPersonalDataRequest.ToNVPString(string.Empty), ServiceName, "GetAdvancedPersonalData", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return GetAdvancedPersonalDataResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetAdvancedPersonalDataResponse GetAdvancedPersonalData(GetAdvancedPersonalDataRequest getAdvancedPersonalDataRequest)
	 	{
	 		return GetAdvancedPersonalData(getAdvancedPersonalDataRequest,(string) null);
	 	}
	 	
	 	/**	
          *AUTO_GENERATED
	 	  */
	 	public GetAdvancedPersonalDataResponse GetAdvancedPersonalData(GetAdvancedPersonalDataRequest getAdvancedPersonalDataRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new NVPAPICallPreHandler(getAdvancedPersonalDataRequest.ToNVPString(string.Empty), ServiceName, "GetAdvancedPersonalData", credential);
	   	 	((NVPAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((NVPAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return GetAdvancedPersonalDataResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	}
}
