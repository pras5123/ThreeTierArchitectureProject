<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="BLDLTemplate.ForgotPassword" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Styles/Site.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="padding-top:150px" >
    <center>
    <table class="tblOthers" style="margin:auto" cellpadding="2px" cellspacing="2px">
    
<tr>
<td colspan="2" class="heading" style="height: 10px">Forgot Password</td>
</tr>
    
<tr>
<td colspan="2"  style="height: 10px">&nbsp;</td>
</tr>
               <tr><td align="center" style="height: 26px">Email id</td><td align="center" style="height: 26px">
                  
        <asp:TextBox ID="txtEmailID" runat="server"></asp:TextBox>
    </td></tr>
               <tr><td align="center" style="height: 26px">
                  
                       &nbsp;</td><td align="center" style="height: 26px">
                  
                       <asp:RegularExpressionValidator ID="revEmailID" runat="server" 
                           ErrorMessage="Enter valid E-mail ID" Font-Bold="true" ForeColor="Red" 
                           ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                           ControlToValidate="txtEmailID"></asp:RegularExpressionValidator>
    </td></tr>
               <tr><td colspan="2" align="center" style="height: 37px">
                  
                       <asp:Button ID="btnSubmit" runat="server" Text="Submit" 
                           CssClass="myButton" onclick="btnSubmit_Click" />
                   </td></tr>
               <tr><td colspan="2" >
                  
                       &nbsp;</td></tr>
               <tr><td colspan="2" align="center">
                  
                       Make sure that you enter your correct E-mail Id.</td></tr>
</table>
</center>
</div>
    </form>
</body>
</html>
