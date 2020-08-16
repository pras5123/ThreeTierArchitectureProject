<%@ Page Title="" Language="C#" MasterPageFile="~/MasterTemplate.Master" AutoEventWireup="true" CodeBehind="ThankYouPage.aspx.cs" Inherits="BLDLTemplate.ThankYouPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table" cellpadding="10px" cellspacing="10px" style="width: 100%">
        <tr>
            <td colspan="2" style="font-size: x-large">
                You have successfully Completed the Transaction</td>
            
        </tr>
        <tr>
            <td colspan="2" style="font-size: x-large">
                &nbsp;</td>
            
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblTransaction" runat="server" 
                    Text="Transaction Reference Number" Font-Bold="True" Font-Size="Large"></asp:Label>
            </td>
            <td>
<b>

                <asp:Label ID="lblReferenceNumber" runat="server" Text="Label" 
                    Font-Size="Large"></asp:Label>
    </b> </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblTStatus" runat="server" Text="Transaction Status&nbsp;" 
                    Font-Bold="True" Font-Size="Large"></asp:Label>
            </td>
            <td>
    <asp:Label ID="lblStatus" runat="server" Text="Label" Font-Bold="True" Font-Size="Large"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblAmt" runat="server" Text="Transaction Amount " 
                    Font-Bold="True" Font-Size="Large"></asp:Label>
            </td>
            <td>
    <b> <asp:Label ID="lblAmount" runat="server" Text="Label" Font-Bold="True" 
                    Font-Size="Large"></asp:Label></b>
   
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
<b>

    <br />
    <br />
    <br />
    <br />
    <br />
    &nbsp;<br />
    </b> <br />
    &nbsp;<br />
    <br />
       
</asp:Content>
