<%@ Page Title="" Language="C#" MasterPageFile="~/MasterTemplate.Master" AutoEventWireup="true" CodeBehind="ChangePasswordScreen.aspx.cs" Inherits="BLDLTemplate.ChangePasswordScreen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table" cellspacing="10px">
    
<tr>
<td colspan="5" class="heading"><b>Change Password Screen</b> </td>

</tr>
        
<tr>
<td colspan="5" >&nbsp;</td>

</tr>
<tr>

<td >
    &nbsp;</td><td>
        &nbsp;</td>
               <td>
                   &nbsp;</td>
               <td>
 <asp:Label ID="lblInternetBankingPassword" runat="server" Text="Internet Banking Password:"></asp:Label>
    </td>
               <td>
        <asp:TextBox ID="txtoldpassword" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="rfvCustomername" runat="server" 
            ErrorMessage="Enter Internet Banking Password" Font-Bold="true" ForeColor="Red" 
                ControlToValidate="txtoldpassword"></asp:RequiredFieldValidator>
        <br />
    </td>
               </tr>
<tr>
<td  >
                   </td><td >
                       &nbsp;</td>
               <td >
                       &nbsp;</td>
               <td >
                       &nbsp;</td>
               <td >
                       &nbsp;</td>
               </tr>
               <tr>
<td >
           &nbsp;</td><td style="height: 21px">
                       &nbsp;</td>
                   <td style="height: 21px">
                       &nbsp;</td>
                   <td style="height: 21px">
           <asp:Label ID="lblNewPassword0" runat="server" Text="New Password:"></asp:Label>
                       </td>
                   <td style="height: 21px">
        <asp:TextBox ID="txtNewPassword" runat="server" TextMode="Password"></asp:TextBox>
                       <br />
        <asp:RequiredFieldValidator ID="rfvNewPassword" runat="server" 
            ErrorMessage="Enter New Password" Font-Bold="true" ForeColor="Red" 
                ControlToValidate="txtNewPassword"></asp:RequiredFieldValidator>
                       </td>
               </tr>
<tr>
<td  >
                 </td><td >
                       
                       &nbsp;</td>
               <td >
                       
                       &nbsp;</td>
               <td >
                       
                       &nbsp;</td>
               <td >
                       
                       </td>
               </tr>
<tr>
<td >
                &nbsp;</td><td >
        &nbsp;</td>
               <td >
                   &nbsp;</td>
               <td >
                <asp:Label ID="lblRetypePassword" runat="server" Text="Retype Password:"></asp:Label>
                       </td>
               <td >
        <asp:TextBox ID="txtretypepassword" runat="server" TextMode="Password"></asp:TextBox>
                       <br />
        <asp:CompareValidator ID="CompareValidator1" runat="server" 
            ControlToCompare="txtretypepassword" ControlToValidate="txtNewPassword" 
            ErrorMessage="Password Does not match" Font-Bold="True" ForeColor="Red"></asp:CompareValidator>
                       </td>
               </tr>
               <tr>
<td  >
                 &nbsp;</td><td >
                       &nbsp;</td>
                   <td >
                       &nbsp;</td>
                   <td >
                       &nbsp;</td>
                   <td >
                       &nbsp;</td>
            </tr>   <tr><td colspan="5" align="center">
                   <br />
                   <br />
                   <asp:Button ID="btnchange" runat="server"  Text="Change" CssClass="myButton" 
                       onclick="btnchange_Click" />
                   <br />
                   <br />
    </td></tr>
</table>
</asp:Content>
