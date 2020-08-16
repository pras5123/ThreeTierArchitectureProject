<%@ Page Title="" Language="C#" MasterPageFile="~/MasterBankTemplate.Master" AutoEventWireup="true" CodeBehind="CreditCardDetails.aspx.cs" Inherits="BLDLTemplate.CreditCardDetails" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp"%>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:UpdatePanel ID="pnlMain" runat="server">
            <ContentTemplate>
   
   
    <table class="table" cellpadding="5px" cellspacing="2px">

<tr>
<td colspan="4" class="heading"><b>Credit card detail</b> </td>

</tr>

<tr>
<td colspan="4" >
    </td>

</tr>
<tr>
<td >
 <asp:Label ID="lblCustname" runat="server" Text="Customer Name"></asp:Label>
    </td><td>
        <asp:DropDownList ID="ddlCustomerName" runat="server" 
            AppendDataBoundItems="True" AutoPostBack="True" 
            onselectedindexchanged="ddlCustomerName_SelectedIndexChanged">
            <asp:ListItem Value="0">----Select Customer ----</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:RequiredFieldValidator ID="rfvCustomerName" runat="server" 
            ErrorMessage="Select Customer Name" Font-Bold="true" ForeColor="Red" 
            ControlToValidate="ddlCustomerName" InitialValue="0" Display="Dynamic"></asp:RequiredFieldValidator>
        </td><td>
    <asp:Label ID="lblCreditnumber" runat="server" Text="Credit number"></asp:Label>
        </td><td>
        <asp:TextBox ID="txtCreditnumber" MaxLength="20" runat="server"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="rfvCreditnumber" runat="server" 
            ErrorMessage="Enter Credit Card Number" Font-Bold="true" ForeColor="Red" 
            ControlToValidate="txtCreditnumber" Display="Dynamic"></asp:RequiredFieldValidator>
        <br />
        <asp:RegularExpressionValidator ID="revCreditCardNumber" runat="server" 
            ErrorMessage="Enter Valid Credit Card No" Font-Bold="true" 
            ForeColor="Red"  ControlToValidate="txtCreditnumber" 
            
            ValidationExpression="^(?:4[0-9]{12}(?:[0-9]{3})?|5[1-5][0-9]{14}|3[47][0-9]{13}|3(?:0[0-5]|[68][0-9])[0-9]{11}|6(?:011|5[0-9]{2})[0-9]{12}|(?:2131|1800|35\d{3})\d{11})$" 
            Display="Dynamic" ></asp:RegularExpressionValidator>
        </td>  </tr>
       

    
      
    

    

    

    
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
       

    
      
    

    

    

    
<tr style="display:none"><td >
          <asp:Label ID="lblValid" runat="server" Text="Valid"></asp:Label>
    </td><td>
        <asp:RadioButtonList ID="rbtValid" runat="server" RepeatDirection="Horizontal">
            <asp:ListItem Value="1" Selected="True">Yes</asp:ListItem>
            <asp:ListItem Value="0">No</asp:ListItem>
        </asp:RadioButtonList>
    </td><td>
           <asp:Label ID="lblLocked" runat="server" Text="Locked"></asp:Label>
    </td><td>
                 <asp:RadioButtonList ID="rbtLocked" runat="server" 
                     RepeatDirection="Horizontal">
                     <asp:ListItem Value="1">Yes</asp:ListItem>
                     <asp:ListItem Selected="True" Value="0">No</asp:ListItem>
                 </asp:RadioButtonList>
    </td></tr>
    
<tr>
<td> <asp:Label ID="lblBank" runat="server" Text="Bank Name"></asp:Label></td>
         <td colspan="3" >
            
             <asp:DropDownList ID="ddlBank" runat="server" 
                 AutoPostBack="True" onselectedindexchanged="ddlBank_SelectedIndexChanged">
                 <asp:ListItem Value="0">---------------------------Select Bank----------------------------------</asp:ListItem>
             </asp:DropDownList>
         </td></tr>

         <tr>
             <td>
                 &nbsp;</td>
             <td colspan="3">
                 <asp:RequiredFieldValidator ID="rfvddlBank" runat="server" 
            ErrorMessage="Select Bank Name" Font-Bold="true" ForeColor="Red" 
            ControlToValidate="ddlBank" InitialValue="0" Display="Dynamic"></asp:RequiredFieldValidator></td>
        </tr>

         <tr><td >
 <asp:Label ID="lblRegistrationdate" runat="server" Text="registration date"></asp:Label>
    </td><td>
        
       <asp:TextBox ID="txtRegistrationdate" runat="server" 
                             ontextchanged="txtRegistrationdate_TextChanged" 
            Enabled="False"></asp:TextBox>
<%--<asp:CalendarExtender ID="CalendarExtender" runat="server" 
            TargetControlID="txtRegistrationdate" PopupButtonID="imgCalender">
    </asp:CalendarExtender>--%>
        <%--<asp:Image ID="imgCalender" runat="server" ImageUrl="~/images/calendar.gif" />--%>
                         
                         
        <br />
        <asp:RequiredFieldValidator ID="rfvRegistrationDate" runat="server" 
            ErrorMessage="Enter Registration Date" Font-Bold="true" ForeColor="Red" 
            ControlToValidate="txtRegistrationdate" Display="Dynamic"></asp:RequiredFieldValidator>
        
        </td><td>
           <asp:Label ID="lblCVVnumber" runat="server" Text="CVV Number"></asp:Label>
        </td><td>
        <asp:TextBox ID="txtcvvnumber" MaxLength="3" runat="server"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="rfvCvvNumber" runat="server" 
            ErrorMessage="Enter CVV Number" Font-Bold="true" ForeColor="Red" 
            ControlToValidate="txtcvvnumber"></asp:RequiredFieldValidator>
        <br />
        <asp:RegularExpressionValidator ID="revNumber" runat="server" 
            ErrorMessage="Enter Only Numbers" Font-Bold="true" 
            ForeColor="Red" ValidationExpression="^\d{3}$" ControlToValidate="txtcvvnumber" 
            Display="Dynamic" ></asp:RegularExpressionValidator>
    </td></tr>
    
     <%--   <tr id="TrObsolete" runat="server" visible="false"><td >
 
    </td><td>
        <asp:NumericUpDownExtender ID="nmrcupdownValidity" Width="70" RefValues="10;11;12;13;14" runat="server" 
            TargetControlID="txtvalidity" >
        </asp:NumericUpDownExtender>
        </td><td>
           <asp:Label ID="lblvalidity" runat="server" Text="validity year"></asp:Label></td><td>
        <asp:TextBox ID="txtvalidity" runat="server"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="rfvValidity" runat="server" 
            ErrorMessage="Enter Validity" Font-Bold="true" ForeColor="Red" 
            ControlToValidate="txtvalidity"></asp:RequiredFieldValidator>
        
        </td></tr>--%>

         <tr><td >
             &nbsp;</td><td>
                 &nbsp;</td><td>
                 &nbsp;</td><td>
                 &nbsp;</td></tr>

        <tr>
            <td>
                <asp:Label ID="lblCreditcardetails" runat="server" Text="Credit card details"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtCreditcarddetails" runat="server" 
                    ontextchanged="txtCreditcarddetails_TextChanged" TextMode="MultiLine"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator ID="rfvCreditCardDetails" runat="server" 
                    ControlToValidate="txtCreditcarddetails" Display="Dynamic" 
                    ErrorMessage="Enter Credit Card Details" Font-Bold="true" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>
                <asp:Label ID="lblExpirydate" runat="server" Text="Expiry date"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtExpirydate" runat="server" Enabled="False"></asp:TextBox>
                <asp:CalendarExtender ID="ceExpiryDate" runat="server" 
                    PopupButtonID="imgExpiryDate" TargetControlID="txtExpirydate">
                </asp:CalendarExtender>
                <asp:Image ID="imgExpiryDate" runat="server" ImageUrl="~/images/calendar.gif" />
                <br />
                <asp:RequiredFieldValidator ID="rfvExpiryDate" runat="server" 
                    ControlToValidate="txtExpirydate" Display="Dynamic" 
                    ErrorMessage="Enter Expiry Date" Font-Bold="true" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <asp:CompareValidator ID="cvDateNext" runat="server" 
                    ControlToCompare="txtExpirydate" ControlToValidate="txtRegistrationdate" 
                    Display="Dynamic" 
                    ErrorMessage="Expiry Date should be greater &lt;/br&gt; than Registration Date" 
                    Font-Bold="true" ForeColor="Red" Operator="LessThan" Type="Date"></asp:CompareValidator>
                <br />
            </td>
        </tr>

      <tr><td colspan="4">
              <asp:CustomValidator ID="cvDateCompare" runat="server" 
                    ErrorMessage="Difference between Expiry date and Registration Date should be atleast 10 years" 
                    Font-Bold="true" ForeColor="Red" OnServerValidate="ValidateDuration"></asp:CustomValidator></td></tr>
    
<tr>
<td> &nbsp;</td>
         <td colspan="3" >
            
             <asp:ScriptManager ID="scmManager" runat="server">
             </asp:ScriptManager>
    </td></tr>
             <tr><td colspan="4" align="center" >
                 <asp:Button ID="btnSubmit" runat="server" Text="Submit" Height="35px" 
                     Width="128px" CssClass="myButton" onclick="btnSubmit_Click" /></td>
                 
        </tr>
             

</table>


</ContentTemplate>
        </asp:UpdatePanel>

<asp:UpdateProgress ID="pgrMain" AssociatedUpdatePanelID="pnlMain" runat="server">
            <ProgressTemplate>
             <div style="position:absolute;margin:auto; padding-left:30%">
              <img src="images/Telerik.Web.UI.Skins.WebBlue.Common.loading.gif" style="position:relative;top:25%"  />
          </div> 
            </ProgressTemplate>
        </asp:UpdateProgress>
</asp:Content>
