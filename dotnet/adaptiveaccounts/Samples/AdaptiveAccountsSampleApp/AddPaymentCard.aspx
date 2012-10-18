<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddPaymentCard.aspx.cs" Inherits="AdaptiveAccountsSampleApp.AddPaymentCard" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Adaptive Accounts - Add Payment Card</title>    
    <link rel="stylesheet" type="text/css" href="Content/sdk.css" />
    <script type="text/javascript" src="Content/sdk_functions.js"></script>
</head>
<body>
		<div id="wrapper">
		<div id="header">
			<h3>Add Payment Card</h3>
			<div id="apidetails">Set up credit cards as funding sources for
				PayPal accounts.</div>
		</div>
		<form method="post" action="adaptiveaccountshandler.ashx" runat="server">
			<div id="request_form">
				<div class="input_header">Account ID or email Address of your paypal
					account *</div>
				<table class="params">
					<tr>
						<th>Account ID</th>
						<th>Email address</th>
					</tr>
					<tr>
						<td><input type="text" name="accountId" value="" /></td>
						<td><input type="text" name="emailAddress" value="" /></td>
					</tr>
				</table>
				<div class="params">
					<div class="param_name">
						Create Account Key ( <a href='CreateAccount.aspx'>Get
							CreateAccountKey</a>)
					</div>
					<div class="param_value">
						<input type="text" name="createAccountKey" value="" />
					</div>
				</div>
				<div class="section_header">Name on card</div>
				<table class="params">
					<tr>
						<th>Salutation</th>
						<th>First Name *</th>
						<th>Middle Name</th>
						<th>Last Name *</th>
						<th>Suffix</th>
					</tr>
					<tr>
						<td><input type="text" name="salutation" value="Mr." /></td>
						<td><input type="text" name="firstName" value="Bonzop" /></td>
						<td><input type="text" name="middleName" value="Zaius" /></td>
						<td><input type="text" name="lastName" value="Simore" /></td>
						<td><input type="text" name="suffix" value="" /></td>
					</tr>
				</table>			
				<div class="section_header">Card Details</div>
				<table class="params">
					<tr>
						<th>Card number *</th>
						<th>Card type</th>
						<th>CardOwner DateOfBirth</th>
						<th>Card verification number (CVV2)</th>
						<th>Issue number</th>
					</tr>
					<tr>
						<td class="param_value">
						    <input type="text" name="cardNumber" value="" />
						</td>
						<td class="param_value">
						    <select name="cardType">								
								<option value="VISA" selected="selected">Visa</option>
								<option value="MASTERCARD">MasterCard</option>
								<option value="AMERICANEXPRESS">AmericanExpress</option>
								<option value="DISCOVER">Discover</option>
								<option value="SWITCHMAESTRO">SwitchMaestro</option>
								<option value="SOLO">Solo</option>
								<option value="CARTEAURORE">CarteAurore</option>
								<option value="CARTEBLUE">CarteBleue</option>
								<option value="COFINOGA">Cofinoga</option>
								<option value="ETOILES">4etoiles</option>
								<option value="CARTAAURA">CartaAura</option>
								<option value="TARJETAAURORA">TarjetaAurora</option>
								<option value="JCB">JCB</option>
						    </select>
						</td>
						<td class="param_value">
						    <input type="text" name="cardOwnerDateOfBirth" value="" />
						</td>
						<td class="param_value">
						    <input type="text" name="cardVerificationNumber" value="" />
						</td>
						<td class="param_value">
						    <input type="text" name="issueNumber" value="" />
						</td>
					</tr>
				</table>
				<div class="section_header">Start Date</div>
				<table class="params">
					<tr>
						<th class="param_name">Start Month</th>
						<th class="param_name">Start Year</th>
					</tr>
					<tr>
						<td class="param_value"><select name="startMonth">
								<option value="">--Select--</option>
								<option value="01" >01</option>
								<option value="02">02</option>
								<option value="03">03</option>
								<option value="04">04</option>
								<option value="05">05</option>
								<option value="06">06</option>
								<option value="07">07</option>
								<option value="08">08</option>
								<option value="09">09</option>
								<option value="10">10</option>
								<option value="11">11</option>
								<option value="12">12</option>
						</select></td>
						<td class="param_value">
						    <input type="text" name="startYear" value="" />
						</td>
					</tr>
				</table>
				<div class="section_header">Expiration Date</div>
				<table class="params">
					<tr>
						<th class="param_name">Expiration Month</th>
						<th class="param_name">Expiration Year</th>
					</tr>
					<tr>
						<td class="param_value"><select name="expirationMonth">
								<option value="">--Select--</option>
								<option value="01" selected="selected">01</option>
								<option value="02">02</option>
								<option value="03">03</option>
								<option value="04">04</option>
								<option value="05">05</option>
								<option value="06">06</option>
								<option value="07">07</option>
								<option value="08">08</option>
								<option value="09">09</option>
								<option value="10">10</option>
								<option value="11">11</option>
								<option value="12">12</option>
						</select></td>
						<td class="param_value">
						    <input type="text" name="expirationYear" value="2022" />
						</td>
					</tr>
				</table>
				<div class="section_header">Address Details</div>
				<table class="params">
					<tr>
						<th class="param_name">Address Line1*</th>
						<th class="param_name">Address Line2</th>
						<th class="param_name">City*</th>
						<th class="param_name">State*</th>
						<th class="param_name">PostalCode*</th>
						<th class="param_name">CountryCode*</th>
					</tr>
					<tr>
						<td class="param_value">
						    <input type="text" name="line1" value="1,Main St" />
						</td>
						<td class="param_value">
						    <input type="text" name="line2" value="" />
						</td>
						<td class="param_value">
						    <input type="text" name="city" value="Austin" />
						</td>
						<td class="param_value">
						    <input type="text" name="state" value="TX" />
						</td>
						<td class="param_value">
						    <input type="text" name="postalCode" value="78750" />
						</td>
						<td class="param_value">
						    <input type="text" name="countryCode" value="US" />
						</td>
					</tr>
				</table>
				
				<div class="params">
					<div class="param_name">ConfirmationType * (ConfirmationType
						NONE requires advanced permission levels. You must pass the
						createAccount key.)</div>
					<div class="param_value">
						<select name="confirmationType">
							<option value="WEB">WEB</option>
							<option value="MOBILE">MOBILE</option>
							<option value="NONE">NONE</option>
						</select>
					</div>
				</div>
				<div class="section_header">Web options (For Confirmation Type WEB
					only)</div>
				<table class="params">
					<tr>
						<th class="param_name">Return URL</th>
						<th class="param_name">Return URL description</th>
						<th class="param_name">Cancel URL</th>
						<th class="param_name">Cancel URL description</th>
					</tr>
					<tr>
						<td class="param_value">
						    <input type="text" name="returnURL" id="returnURL" value="" runat="server"/>
						</td>
						<td class="param_value">
						    <input type="text" name="returnURLDescription" value="" />
						</td>
						<td class="param_value">
						    <input type="text" name="cancelURL" id="cancelURL" value="" runat="server"/>
						</td>
						<td class="param_value">
						    <input type="text" name="cancelURLDescription" value="" />
						</td>
					</tr>
				</table>
				<div class="submit">
				    <asp:Button ID="AdaptiveAccountsBtn" Text="AddPaymentCard" runat="server" PostBackUrl="adaptiveaccountshandler.ashx" />					
				</div>			
			</div>
		</form>
		<a href="Default.aspx">Home</a>
	</div>
</body>
</html>