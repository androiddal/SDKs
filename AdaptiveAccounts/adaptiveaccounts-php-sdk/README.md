
PayPal PHP Adaptive Accounts SDK
===============================

Prerequisites
-------------

PayPal's PHP Adaptive Accounts SDK requires 

 * PHP 5.2 and above 
 * curl extension with support for OpenSSL 
 * PHPUnit 3.5 for running test suite (Optional)

Using the SDK
-------------

To use the SDK, 

* Copy the config and lib folders into your project.
* Make sure that the lib folder in your project is available in PHP's include path
* Include the services\AdaptiveAccounts\AdaptiveAccountsService.php file in your code.
* Create a service wrapper object
* Create a request object as per your project's needs. All the API request and response classes are available in services\AdaptiveAccounts\AdaptiveAccountsService.php
* Invoke the appropriate method on the request object.

For example,

	require_once('services/AdaptiveAccounts/AdaptiveAccountsService.php');
	require_once('PPLoggingManager.php');

  	$createAccountRequest = new CreateAccountRequest($requestEnvelope, $name, $address, $preferredLanguageCode);
	$createAccountRequest->accountType = $_REQUEST['accountType'];
	......

	$service  = new AdaptiveAccountsService();
	$response = $service->CreateAccount($createAccountRequest);
	
	$ack = strtoupper($response->responseEnvelope->ack);
 
	if($ack == 'SUCCESS') {
		// Success
	}
  
 

SDK Configuration
-----------------

replace the API credential in config/sdk_config.ini . You can use the configuration file to configure

 * (Multiple) API account credentials.
 * Service endpoint and other HTTP connection parameters 


Please refer to the sample config file provided with this bundle.
