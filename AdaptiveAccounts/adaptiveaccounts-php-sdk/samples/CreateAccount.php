<?php
/********************************************
 CreateAccount.php
Calls CreateAccount API of CreateAccounts webservices.

Called by CreateAccount.html.php
********************************************/
$path = '../lib';
set_include_path(get_include_path() . PATH_SEPARATOR . $path);
require_once('services/AdaptiveAccounts/AdaptiveAccountsService.php');
require_once('PPLoggingManager.php');
require_once('Common/Constants.php');
session_start();

$logger = new PPLoggingManager('CreateAccount');

$serverName = $_SERVER['SERVER_NAME'];
$serverPort = $_SERVER['SERVER_PORT'];
$url=dirname('http://'.$serverName.':'.$serverPort.$_SERVER['REQUEST_URI']);
if($_REQUEST['returnUrl']!=null) {
	$returnURL = $_REQUEST['returnUrl'];
} else {
	$returnURL = $url."/Common/WebflowReturnPage.php";
}
$preferredLanguageCode = $_REQUEST['preferredLanguageCode'];
$registrationType = $_REQUEST['registrationType'];

$name = new NameType();
$name->salutation = $_REQUEST['salutation'];
$name->firstName = $_REQUEST['firstName'];
$name->middleName = $_REQUEST['middleName'];
$name->lastName = $_REQUEST['lastName'];

$address = new AddressType();
$address->line1 =  $_REQUEST['line1'];
$address->line2 =$_REQUEST['line2'];
$address->city = $_REQUEST['city'];
$address->state =  $_REQUEST['state'];
$address->postalCode= $_REQUEST['postalCode'];
$address->countryCode =  $_REQUEST['countryCode'];


if($_REQUEST['accountType'] == "Business") {

	$bizAddress = new AddressType();
	$bizAddress->line1 = $_REQUEST['businessAddressLine1'];
	$bizAddress->line2 = $_REQUEST['businessAddressLine2'];
	$bizAddress->city = $_REQUEST['businessAddressCity'];
	$bizAddress->state = $_REQUEST['businessAddressState'];
	$bizAddress->postalCode = $_REQUEST['businessAddressPostalCode'];
	$bizAddress->countryCode = $_REQUEST['businessAddressCountryCode'];

	$stkName = new NameType();
	$stkName->firstName =  $_REQUEST['stakeholderFirstName'];
	$stkName->lastName = $_REQUEST['stakeholderLastName'];
	$stkName->middleName = $_REQUEST['stakeholderMiddleName'];
	$stkName->salutation = $_REQUEST['stakeholderSalutation'];
	$stkName->suffix = $_REQUEST['stakeholderSuffix'];

	$stkHolderAddress = new AddressType();
	$stkHolderAddress->line1 = $_REQUEST['stakeholderLine1'];
	$stkHolderAddress->line2 = $_REQUEST['stakeholderLine2'];
	$stkHolderAddress->city = $_REQUEST['stakeholderCity'];
	$stkHolderAddress->state = $_REQUEST['stakeholderState'];
	$stkHolderAddress->postalCode = $_REQUEST['stakeholderPostalCode'];
	$stkHolderAddress->countryCode = $_REQUEST['stakeholderCountryCode'];

	$businessStakeholder = new BusinessStakeholderType();
	$businessStakeholder->address = $stkHolderAddress;
	$businessStakeholder->dateOfBirth = $_REQUEST['stakeholderDateOfBirth'];
	$businessStakeholder->name = $stkName;
	$businessStakeholder->role =  $_REQUEST['role'];
	$businessStakeholder->fullLegalName = $_REQUEST['fullLegalName'];

	$businssinfo = new BusinessInfoType();
	$businssinfo->businessAddress = $bizAddress;
	$businssinfo->businessName = $_REQUEST['businessName'];
	$businssinfo->workPhone = $_REQUEST['workPhone'];
	$businssinfo->category = $_REQUEST['category'];
	$businssinfo->subCategory = $_REQUEST['subCategory'];
	$businssinfo->merchantCategoryCode = $_REQUEST['merchantCategoryCode'];
	$businssinfo->doingBusinessAs = $_REQUEST['doingBusinessAs'];
	$businssinfo->customerServicePhone = $_REQUEST['customerServicePhone'];
	$businssinfo->customerServiceEmail = $_REQUEST['customerServiceEmail'];
	$businssinfo->disputeEmail = $_REQUEST['disputeEmail'];
	$businssinfo->webSite = $_REQUEST['webSite'];
	$businssinfo->companyId = $_REQUEST['companyId'];
	$businssinfo->dateOfEstablishment = $_REQUEST['dateOfEstablishment'];
	$businssinfo->businessType = $_REQUEST['businessType'];
	// $businssinfo->businessSubtype = $_REQUEST['businessSubtype'];
	$businssinfo->incorporationId = $_REQUEST['incorporationId'];
	$businssinfo->averagePrice = $_REQUEST['averagePrice'];
	$businssinfo->averageMonthlyVolume = $_REQUEST['averageMonthlyVolume'];
	$businssinfo->percentageRevenueFromOnline = $_REQUEST['percentageRevenueFromOnline'];
	$businssinfo->salesVenue = array($_REQUEST['salesVenue']);
	$businssinfo->salesVenueDesc = $_REQUEST['salesVenueDesc'];
	$businssinfo->vatId = $_REQUEST['vatId'];
	$businssinfo->vatCountryCode = $_REQUEST['vatCountryCode'];
	$businssinfo->commercialRegistrationLocation  = $_REQUEST['commercialRegistrationLocation'];
	$businssinfo->businessStakeholder = array($businessStakeholder);
}

$requestEnvelope = new RequestEnvelope("en_US");

$createAccountWebOptions = new CreateAccountWebOptionsType();
$createAccountWebOptions->returnUrl = $returnURL;
$createAccountWebOptions->returnUrlDescription = $_POST['returnUrlDescription'];
$createAccountWebOptions->showAddCreditCard = $_POST['showAddCreditCard'];
$createAccountWebOptions->showMobileConfirm = $_POST['showMobileConfirm'];
$createAccountWebOptions->useMiniBrowser = $_POST['useMiniBrowser'];

$createAccountRequest = new CreateAccountRequest($requestEnvelope, $name, $address, $preferredLanguageCode);
$createAccountRequest->accountType = $_REQUEST['accountType'];
$createAccountRequest->dateOfBirth =  $_REQUEST['dateOfBirth'];
$createAccountRequest->notificationURL = $_REQUEST['notificationUrl'];
$createAccountRequest->citizenshipCountryCode = $_REQUEST['citizenshipCountryCode'];
$createAccountRequest->contactPhoneNumber = $_REQUEST['contactPhoneNumber'];
$createAccountRequest->registrationType = $registrationType;
$createAccountRequest->currencyCode = $_REQUEST['currencyCode'];;
$createAccountRequest->emailAddress = $_REQUEST['emailAddress'];
$createAccountRequest->createAccountWebOptions =  $createAccountWebOptions;
$createAccountRequest->homePhoneNumber = $_REQUEST['homePhoneNumber'];
$createAccountRequest->mobilePhoneNumber =  $_REQUEST['mobilePhoneNumber'];
$createAccountRequest->partnerField1 = $_REQUEST['partnerField1'];
$createAccountRequest->partnerField2 = $_REQUEST['partnerField2'];
$createAccountRequest->partnerField3 = $_REQUEST['partnerField3'];
$createAccountRequest->partnerField4 = $_REQUEST['partnerField4'];
$createAccountRequest->partnerField5 = $_REQUEST['partnerField5'];
$createAccountRequest->suppressWelcomeEmail = $_POST['suppressWelcomeEmail'];
$createAccountRequest->performExtraVettingOnThisAccount = $_POST['performExtraVettingOnThisAccount'];
$createAccountRequest->taxId = $_POST['taxId'];

if($_REQUEST['accountType'] == "Business") {
	$createAccountRequest->businessInfo = $businssinfo;
}

$service  = new AdaptiveAccountsService();
try {
	$response = $service->CreateAccount($createAccountRequest);
} catch(Exception $ex) {
	require_once 'Common/Error.php';
	exit;
}	
$logger->log("Received CreateAccount Response:");
$ack = strtoupper($response->responseEnvelope->ack);
if($ack != "SUCCESS"){
	echo "<b>Error </b>";
	echo "<pre>";
	print_r($response);
	echo "</pre>";	
} else {
	echo "<pre>";
	print_r($response);
	echo "</pre>";
	$createAccountKey = strtoupper($response->createAccountKey);
	$payPalURL = $response->redirectURL;

	echo "<table>";
	echo "<tr><td>Ack :</td><td><div id='Ack'>$ack</div> </td></tr>";
	echo "<tr><td>CreateAccountKey :</td><td> <div id='createAccountKey'>$createAccountKey</div></td></tr>";
	echo "<tr><td>Redirect URL :</td><td> <div id='Redirect URL'><a href=$payPalURL><b>Redirect To PayPal</b></a><br></div></td></tr>";
	echo "</table>";
	//echo "<a href=$payPalURL><b>* Redirect URL to Complete Account Creation </b></a><br>";
}
require_once 'Common/Response.php';
