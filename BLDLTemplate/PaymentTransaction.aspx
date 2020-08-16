<%@ Page Title="" Language="C#" MasterPageFile="~/MasterTemplate.Master" AutoEventWireup="true"
    CodeBehind="PaymentTransaction.aspx.cs" Inherits="BLDLTemplate.PaymentTransaction" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <table class="table" style="width: 100%; height: 193px;">
        <tr>
            <td colspan="2" align="center">
                <asp:Label ID="lblChoose" runat="server" Font-Bold="True" 
                    Text="Choose Your Payment Mode" Font-Size="Large"></asp:Label>
                <br />
            </td>
        </tr>
        <tr>
            <td align="center" style="height: 79px">
                <asp:Label ID="lblBank" runat="server" Text="Select A Bank" Font-Size="Large"></asp:Label>
            </td>
            <td align="center" style="height: 79px">
                 <asp:DropDownList ID="ddlBank" runat="server" AppendDataBoundItems="True" 
                     AutoPostBack="True" onselectedindexchanged="ddlBank_SelectedIndexChanged">
                 <asp:ListItem Value="0">---------------------------Select Bank----------------------------------</asp:ListItem>
             </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td align="center" style="height: 79px">
                <asp:Label ID="lblProductType" runat="server" Text="Select Product Type" Font-Size="Large"></asp:Label>
            </td>
            <td align="center" style="height: 79px">
                 <asp:DropDownList ID="ddlProductType" runat="server" AppendDataBoundItems="True" 
                     AutoPostBack="True" 
                     onselectedindexchanged="ddlProductType_SelectedIndexChanged">
                 <asp:ListItem Value="0">-------------------Select Product Type--------------------------</asp:ListItem>
                     <asp:ListItem Value="1">Cosmetics</asp:ListItem>
                     <asp:ListItem Value="2">Shirts </asp:ListItem>
                     <asp:ListItem Value="3">Pant</asp:ListItem>
                     <asp:ListItem Value="4">Kurta</asp:ListItem>
             </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td align="center" style="height: 79px">
                <asp:Label ID="lblCost" runat="server" Text="Product Cost" Font-Size="Large"></asp:Label>
            </td>
            <td align="center" style="height: 79px">
                <asp:Label ID="lblCostOfProduct" runat="server"  Font-Size="Large"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="center">
                <asp:Label ID="lblPaythrough" runat="server" Text="Pay Through" Font-Size="Large"></asp:Label>
            </td>
            <td align="center" id="trUniquepay" runat="server" style="display:none" >
                <form action="https://www.sandbox.paypal.com/cgi-bin/webscr" method="post">
                </form>
                <form action="https://www.sandbox.paypal.com/cgi-bin/webscr" method="post">
                <input type="hidden" name="cmd" value="_xclick" />
                <input name="business" value="rajend_1357986603_biz@yahoo.com" type="hidden">
                <input name="email" value="rajend_1357986603_biz@yahoo.com" type="hidden">
                <input type="hidden" name="lc" value="US" />
                <input type="hidden" name="item_name" value="Your Total Item Description" />
                <input type="hidden" name="amount" value="<%=Session["ProductCost"] %>" />
                <input type="hidden" name="currency_code" value="USD" />
                <input type="hidden" name="button_subtype" value="services" />
                <input name="shopping_url" type="hidden" value="http://www.custom-india.in/women.aspx" />
                <input name="return" type="hidden" value="http://localhost:50316/ThankYouPage.aspx" />
                <input name="cancel_return" type="hidden" value="http://www.custom-india.in/failure.aspx" />
                <input type="hidden" name="bn" value="PP-BuyNowBF:btn_paynow_LG.gif:NonHostedGuest" />
                <input type="image" src="https://www.paypalobjects.com/en_US/i/btn/btn_xpressCheckout.gif"
                    border="0" name="submit" alt="PayPal - The safer, easier way to pay online!" />
                <img alt="" border="0" src="https://www.paypalobjects.com/en_US/i/scr/pixel.gif"
                    width="1" height="1" />
                </form>
            </td>
        </tr>
    </table>
    <br />
    <br />
    <br />
    <br />
    <script language="javascript" type="text/javascript">

    </script>
</asp:Content>
