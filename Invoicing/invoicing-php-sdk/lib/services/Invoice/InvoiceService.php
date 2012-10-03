<?php 
require_once('PPBaseService.php');
require_once('Invoice.php');
require_once('PPUtils.php');


/**
 * AUTO GENERATED code for Invoice
 */
class InvoiceService extends PPBaseService {

	// Service Version
	private static $SERVICE_VERSION = "1.6.0";

	// Service Name
	private static $SERVICE_NAME = "Invoice";

	public function __construct() {
		parent::__construct('Invoice');
	}


	/**
	 * Service Call: CreateInvoice
	 * @param CreateInvoiceRequest $createInvoiceRequest
	 * @return CreateInvoiceResponse
	 * @throws APIException
	 */
	public function CreateInvoice($createInvoiceRequest, $apiUsername = NULL) {
		$ret = new CreateInvoiceResponse();
		$resp = $this->call("CreateInvoice", $createInvoiceRequest, $apiUsername);
		$ret->init(PPUtils::nvpToMap($resp));
		return $ret;
	}
	 

	/**
	 * Service Call: SendInvoice
	 * @param SendInvoiceRequest $sendInvoiceRequest
	 * @return SendInvoiceResponse
	 * @throws APIException
	 */
	public function SendInvoice($sendInvoiceRequest, $apiUsername = NULL) {
		$ret = new SendInvoiceResponse();
		$resp = $this->call("SendInvoice", $sendInvoiceRequest, $apiUsername);
		$ret->init(PPUtils::nvpToMap($resp));
		return $ret;
	}
	 

	/**
	 * Service Call: CreateAndSendInvoice
	 * @param CreateAndSendInvoiceRequest $createAndSendInvoiceRequest
	 * @return CreateAndSendInvoiceResponse
	 * @throws APIException
	 */
	public function CreateAndSendInvoice($createAndSendInvoiceRequest, $apiUsername = NULL) {
		$ret = new CreateAndSendInvoiceResponse();
		$resp = $this->call("CreateAndSendInvoice", $createAndSendInvoiceRequest, $apiUsername);
		$ret->init(PPUtils::nvpToMap($resp));
		return $ret;
	}
	 

	/**
	 * Service Call: UpdateInvoice
	 * @param UpdateInvoiceRequest $updateInvoiceRequest
	 * @return UpdateInvoiceResponse
	 * @throws APIException
	 */
	public function UpdateInvoice($updateInvoiceRequest, $apiUsername = NULL) {
		$ret = new UpdateInvoiceResponse();
		$resp = $this->call("UpdateInvoice", $updateInvoiceRequest, $apiUsername);
		$ret->init(PPUtils::nvpToMap($resp));
		return $ret;
	}
	 

	/**
	 * Service Call: GetInvoiceDetails
	 * @param GetInvoiceDetailsRequest $getInvoiceDetailsRequest
	 * @return GetInvoiceDetailsResponse
	 * @throws APIException
	 */
	public function GetInvoiceDetails($getInvoiceDetailsRequest, $apiUsername = NULL) {
		$ret = new GetInvoiceDetailsResponse();
		$resp = $this->call("GetInvoiceDetails", $getInvoiceDetailsRequest, $apiUsername);
		$ret->init(PPUtils::nvpToMap($resp));
		return $ret;
	}
	 

	/**
	 * Service Call: CancelInvoice
	 * @param CancelInvoiceRequest $cancelInvoiceRequest
	 * @return CancelInvoiceResponse
	 * @throws APIException
	 */
	public function CancelInvoice($cancelInvoiceRequest, $apiUsername = NULL) {
		$ret = new CancelInvoiceResponse();
		$resp = $this->call("CancelInvoice", $cancelInvoiceRequest, $apiUsername);
		$ret->init(PPUtils::nvpToMap($resp));
		return $ret;
	}
	 

	/**
	 * Service Call: SearchInvoices
	 * @param SearchInvoicesRequest $searchInvoicesRequest
	 * @return SearchInvoicesResponse
	 * @throws APIException
	 */
	public function SearchInvoices($searchInvoicesRequest, $apiUsername = NULL) {
		$ret = new SearchInvoicesResponse();
		$resp = $this->call("SearchInvoices", $searchInvoicesRequest, $apiUsername);
		$ret->init(PPUtils::nvpToMap($resp));
		return $ret;
	}
	 

	/**
	 * Service Call: MarkInvoiceAsPaid
	 * @param MarkInvoiceAsPaidRequest $markInvoiceAsPaidRequest
	 * @return MarkInvoiceAsPaidResponse
	 * @throws APIException
	 */
	public function MarkInvoiceAsPaid($markInvoiceAsPaidRequest, $apiUsername = NULL) {
		$ret = new MarkInvoiceAsPaidResponse();
		$resp = $this->call("MarkInvoiceAsPaid", $markInvoiceAsPaidRequest, $apiUsername);
		$ret->init(PPUtils::nvpToMap($resp));
		return $ret;
	}
	 

	/**
	 * Service Call: MarkInvoiceAsUnpaid
	 * @param MarkInvoiceAsUnpaidRequest $markInvoiceAsUnpaidRequest
	 * @return MarkInvoiceAsUnpaidResponse
	 * @throws APIException
	 */
	public function MarkInvoiceAsUnpaid($markInvoiceAsUnpaidRequest, $apiUsername = NULL) {
		$ret = new MarkInvoiceAsUnpaidResponse();
		$resp = $this->call("MarkInvoiceAsUnpaid", $markInvoiceAsUnpaidRequest, $apiUsername);
		$ret->init(PPUtils::nvpToMap($resp));
		return $ret;
	}
	 

	/**
	 * Service Call: MarkInvoiceAsRefunded
	 * @param MarkInvoiceAsRefundedRequest $markInvoiceAsRefundedRequest
	 * @return MarkInvoiceAsRefundedResponse
	 * @throws APIException
	 */
	public function MarkInvoiceAsRefunded($markInvoiceAsRefundedRequest, $apiUsername = NULL) {
		$ret = new MarkInvoiceAsRefundedResponse();
		$resp = $this->call("MarkInvoiceAsRefunded", $markInvoiceAsRefundedRequest, $apiUsername);
		$ret->init(PPUtils::nvpToMap($resp));
		return $ret;
	}
	 
}
?>