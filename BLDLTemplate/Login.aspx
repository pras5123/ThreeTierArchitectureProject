<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BLDLTemplate.Login" %>

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
     <table class="tblOthers" style="margin:auto" cellspacing="2px" cellpadding="2px">
        <tr>
            <td colspan="2" class="heading" align="center">
                <b>Login</b>
            </td>
        </tr>
        <tr>
            <td >
                &nbsp;</td>
            <td >
                &nbsp;</td>
        </tr>
        <tr>
            <td align="center" >
                <asp:Label ID="lblUserName" runat="server" Text="User Name:"></asp:Label>
            </td>
            <td align="center" >
                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator ID="rfvEnterUsername" runat="server" ErrorMessage="Enter User name"
                     Font-Bold="true" ForeColor="Red" ControlToValidate="txtUserName"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td >
                &nbsp;</td>
            <td >
                &nbsp;</td>
        </tr>
        <tr>
            <td align="center" >
                <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
            </td>
            <td align="center" >
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ErrorMessage="Enter Password"
                     Font-Bold="true" ForeColor="Red" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td >
                &nbsp;</td>
            <td >
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" CssClass="myButton" />
                <br />
            </td>
        </tr>
        <tr>
            <td colspan="2" align="right">
                <asp:LinkButton ID="lnkForgotPassword" runat="server" 
                    OnClick="lnkForgotPassword_Click" CausesValidation="False" 
                    Font-Underline="True">Forgot your Password ?</asp:LinkButton>
            </td>
        </tr>
    </table>
    </center>

    </div>
    </form>
</body>
</html>
