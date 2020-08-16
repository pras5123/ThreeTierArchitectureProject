<%@ Page Title="" Language="C#" MasterPageFile="~/MasterBankTemplate.Master" AutoEventWireup="true" CodeBehind="CustomerRegform.aspx.cs" Inherits="BLDLTemplate.Customerregform" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <asp:UpdatePanel ID="pnlMain" runat="server">
            <ContentTemplate>

    <table class="table" cellpadding="5px" cellspacing="2px">

<tr>
<td colspan="4" class="heading"><b>Customer Registration Form </b> </td>

</tr>

        <tr>

<td>
    &nbsp;</td><td>
                <asp:ScriptManager ID="scmManager" runat="server">
                </asp:ScriptManager>
            </td><td>
                &nbsp;</td><td>
                &nbsp;</td></tr>
        <tr>

<td>
 <asp:Label ID="lblCustomerName" runat="server" Text="Customer Name"></asp:Label>
    </td><td>
        <asp:TextBox ID="txtCustomerName" MaxLength="20" runat="server"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="rfvCustomername" runat="server" 
            ErrorMessage="Enter customer name" Font-Bold="true" ForeColor="Red" 
                ControlToValidate="txtCustomerName" Display="Dynamic"></asp:RequiredFieldValidator>
    </td><td>
    <asp:Label ID="lblAddressLine1" runat="server" Text="Address Line1"></asp:Label>
    </td><td>
        <asp:TextBox ID="txtAddressLine1" runat="server"></asp:TextBox>
                <br />
        <asp:RequiredFieldValidator ID="rfvAddressLine1" runat="server" 
            ErrorMessage="Enter Address Line1" Font-Bold="true"  ForeColor="Red" 
            ControlToValidate="txtAddressLine1" Display="Dynamic"></asp:RequiredFieldValidator>
        <br /></td></tr>
<tr>

<td>
    </td><td>
    <asp:RegularExpressionValidator ID="revCustomerName" runat="server" 
            ErrorMessage="Only characters are allowed" Font-Bold="true"  ForeColor="Red" 
            ControlToValidate="txtCustomerName" 
            ValidationExpression="^[a-zA-Z]*$" 
            Display="Dynamic"></asp:RegularExpressionValidator>
       </td><td>
        </td><td>
        &nbsp;</td></tr>
        <tr><td>
 <asp:Label ID="lblAddressLine2" runat="server" Text="Address Line 2"></asp:Label>
    </td><td>
        <asp:TextBox ID="txtAddressLine2" runat="server"></asp:TextBox>
         
                <br />
                 <asp:RequiredFieldValidator ID="rfvAddressLine2" runat="server" 
            ErrorMessage="Enter Address Line 2" Font-Bold="true"  ForeColor="Red" 
            ControlToValidate="txtAddressLine2" Display="Dynamic"></asp:RequiredFieldValidator>
    </td><td>
    <asp:Label ID="lblAddressLine3" runat="server" Text="Address Line 3"></asp:Label>
    </td><td>
        <asp:TextBox ID="txtAdddressLine3" runat="server"></asp:TextBox>
                <br />
                 <asp:RequiredFieldValidator ID="rfvAddressLine3" runat="server" 
            ErrorMessage="Enter Address Line 3" Font-Bold="true"  ForeColor="Red" 
            ControlToValidate="txtAdddressLine3" Display="Dynamic"></asp:RequiredFieldValidator>
    </td></tr>
        <tr><td>
            &nbsp;</td><td>
                &nbsp;</td><td>
                &nbsp;</td><td>
                &nbsp;</td></tr>
<tr><td>
 <asp:Label ID="lblCountry" runat="server" Text="Country"></asp:Label>
    </td><td>
    <asp:DropDownList ID="ddlCountry" runat="server" AppendDataBoundItems="True" 
            AutoPostBack="True" onselectedindexchanged="ddlCountry_SelectedIndexChanged">
        <asp:ListItem Value="0">-----Select Country---</asp:ListItem>
    </asp:DropDownList>
        <br />
         <asp:RequiredFieldValidator ID="rfvCountry" Font-Bold="true" ForeColor="Red" 
            runat="server" ControlToValidate="ddlCountry" ErrorMessage="Select Country" 
            InitialValue="0" Display="Dynamic"></asp:RequiredFieldValidator>
    </td><td>
    <asp:Label ID="lblState" runat="server" Text="State"></asp:Label>
    </td><td>
    <asp:DropDownList ID="ddlState" runat="server" AppendDataBoundItems="True" 
            AutoPostBack="True" onselectedindexchanged="ddlState_SelectedIndexChanged">
        <asp:ListItem Value="0">---Select State----</asp:ListItem>
    </asp:DropDownList>
        <br />
         <asp:RequiredFieldValidator ID="rfvState" Font-Bold="true" ForeColor="Red" 
            runat="server" ControlToValidate="ddlState" ErrorMessage="Select State" 
            InitialValue="0" Display="Dynamic"></asp:RequiredFieldValidator>
    </td></tr>
<tr><td >
    &nbsp;</td><td>
        &nbsp;</td><td>
        &nbsp;</td><td>
        &nbsp;</td></tr>
<tr><td >
 <asp:Label ID="lblCity" runat="server" Text="City"></asp:Label>
    </td><td>
    <asp:DropDownList ID="ddlCity" runat="server" AppendDataBoundItems="True">
        <asp:ListItem Value="0">---Select City---</asp:ListItem>
    </asp:DropDownList>
        <br />
         <asp:RequiredFieldValidator ID="rfvCity" Font-Bold="true" ForeColor="Red" 
            runat="server" ControlToValidate="ddlCity" ErrorMessage="Select City" 
            InitialValue="0" Display="Dynamic"></asp:RequiredFieldValidator>
        <br />
    </td><td>
    <asp:Label ID="lblEmailId" runat="server" Text="Email Id"></asp:Label>
    </td><td>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
    

        <br />
    <asp:RequiredFieldValidator ID="rfvEmail" runat="server" 
            ErrorMessage="Email Id is Required" Font-Bold="true"  ForeColor="Red" 
            ControlToValidate="txtEmail" Display="Dynamic"></asp:RequiredFieldValidator>

        <br />

    </td></tr>
<tr><td >
    &nbsp;</td><td>
        &nbsp;</td><td>
        &nbsp;</td><td>
        <asp:RegularExpressionValidator ID="revEmailID" runat="server" 
            ErrorMessage="enter Valid email Id" Font-Bold="true"  ForeColor="Red" 
            ControlToValidate="txtEmail" 
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
            Display="Dynamic"></asp:RegularExpressionValidator>

    </td></tr>
<tr><td >
 <asp:Label ID="lblSex" runat="server" Text="Sex"></asp:Label>
    </td><td>
       
        <asp:RadioButtonList ID="rbtnSex" runat="server" RepeatDirection="Horizontal">
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:RequiredFieldValidator runat="server" ID="rfvSex"  
            ControlToValidate="rbtnSex" ForeColor="Red" Font-Bold="true" 
            ErrorMessage="Please select an option" Display="Dynamic"/>
    </td><td>
    <asp:Label ID="lblCheque" runat="server" Text="Account with Cheque book ?"></asp:Label>
    </td><td>

        <asp:RadioButtonList ID="rbtnYesNo" runat="server" RepeatDirection="Horizontal">
            <asp:ListItem Selected="True">Yes</asp:ListItem>
            <asp:ListItem>No</asp:ListItem>
        </asp:RadioButtonList>

        </td></tr>


<tr><td >
    &nbsp;</td><td>
       
        &nbsp;</td><td>
        &nbsp;</td><td>
        &nbsp;</td></tr>


<tr><td >
    <asp:Label ID="lblContact" runat="server" Text="Contact Number"></asp:Label>
    </td><td>
        <asp:TextBox ID="txtContact" runat="server"></asp:TextBox>
        <br />
         <asp:RequiredFieldValidator ID="rfvContactNumber" runat="server" 
            ErrorMessage="Enter Contact Number" Font-Bold="true"  ForeColor="Red" 
            ControlToValidate="txtContact" Display="Dynamic"></asp:RequiredFieldValidator>
        <br />
        <asp:RegularExpressionValidator ID="revContactNumber" runat="server" 
            ErrorMessage="Enter Valid Contact Number" Font-Bold="true"  ForeColor="Red" 
            ControlToValidate="txtContact" 
            ValidationExpression="^\d{10}$" 
            Display="Dynamic"></asp:RegularExpressionValidator>
    </td><td>
 <asp:Label ID="lblOtherContact" runat="server" Text="Other contact Number"></asp:Label>
        </td><td>
        <asp:TextBox ID="txtOtherContact" runat="server"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="rfvOtherContact" runat="server" 
            ControlToValidate="txtOtherContact" ErrorMessage="Enter Alternate Number" 
            Font-Bold="true" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
        <br />
       <asp:RegularExpressionValidator ID="revOthercontact" runat="server" 
            ErrorMessage="Enter Valid Number" Font-Bold="true"  ForeColor="Red" 
            ControlToValidate="txtOtherContact" 
            ValidationExpression="^([0-9]\d{2,4}-\d{6,8}|\d{10})$" 
            Display="Dynamic"></asp:RegularExpressionValidator>
        </td></tr>


        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>


<tr><td >
    <asp:Label ID="lblPanCardNumber" runat="server" Text="PAN Card Number"></asp:Label>
    </td><td>
        <asp:TextBox ID="txtPanCardNumber" runat="server"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="rfvPanCardNumber" runat="server" 
            ControlToValidate="txtPanCardNumber" ErrorMessage="Enter PAN Card Number" 
            Font-Bold="true" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
        <br />
        <asp:RegularExpressionValidator ID="rev" runat="server" 
            ErrorMessage="Enter Valid Pan Card Number" Font-Bold="true"  ForeColor="Red" 
            ControlToValidate="txtPanCardNumber" 
            ValidationExpression="^[A-Za-z]{5}\d{4}[A-Za-z]{1}$" 
            Display="Dynamic"></asp:RegularExpressionValidator>
    </td><td>
        &nbsp;</td><td>
        &nbsp;</td></tr>


        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>


<tr><td  align="left" >
        <asp:Label ID="lblBank" runat="server" Text="Bank Name"></asp:Label>
    </td>
    
  
        
        <td colspan="3" align="left">

        <asp:DropDownList ID="ddlBank" runat="server" AppendDataBoundItems="True">
            <asp:ListItem Value="0">---------------------------Select Bank----------------------------------</asp:ListItem>
        </asp:DropDownList>

            <br />
         <asp:RequiredFieldValidator ID="rfvBank" Font-Bold="true" ForeColor="Red" 
                runat="server" ControlToValidate="ddlBank" ErrorMessage="Select Bank" 
                InitialValue="0" Display="Dynamic"></asp:RequiredFieldValidator>

            <br />

       </td></tr>


<tr><td  align="left" >
        &nbsp;</td>
    
  
        
        <td colspan="3" align="left">

            &nbsp;</td></tr>
<tr><td colspan="4" align="center">
    <asp:Button ID="btnRegister" runat="server" Text="Register" 
        onclick="btnRegister_Click" CssClass="myButton"/>
    </td></tr>
</table>

  </ContentTemplate>
        </asp:UpdatePanel>

<asp:UpdateProgress ID="pgrMain" AssociatedUpdatePanelID="pnlMain" runat="server">
            <ProgressTemplate>
             <div style="margin:auto; padding-left:10%">
              <img src="images/Telerik.Web.UI.Skins.WebBlue.Common.loading.gif" style="position:relative;top:10%"  />
          </div> 
            </ProgressTemplate>
        </asp:UpdateProgress>
</asp:Content>
