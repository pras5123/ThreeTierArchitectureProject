<%@ Page Title="" Language="C#" MasterPageFile="~/MasterBankTemplate.Master" AutoEventWireup="true" CodeBehind="ViewReportByBank.aspx.cs" Inherits="BLDLTemplate.ViewReportByBank" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp"%>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <table class="table" cellpadding="5px" cellspacing="2px">

<tr>
<td colspan="4" class="heading">Search<b> card details </b> </td>

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
            AppendDataBoundItems="True">
            <asp:ListItem Value="0">----Select Customer ----</asp:ListItem>
        </asp:DropDownList>
        <br />
        </td><td>
    <asp:Label ID="lblAccountnumber" runat="server" Text="Account number"></asp:Label>
        </td><td>
        <asp:DropDownList ID="ddlAccountNumber" runat="server" 
            AppendDataBoundItems="True">
            <asp:ListItem Value="0">----Select Account Number----</asp:ListItem>
        </asp:DropDownList>
        <br />
        </td>  </tr>
<tr>
<td >
    &nbsp;</td><td>
        &nbsp;</td><td>
        &nbsp;</td><td>
        &nbsp;</td>  </tr>
        <tr><td >
 <asp:Label ID="lblCreditNumber" runat="server" Text="Credit card Number"></asp:Label>
            </td><td>
        <asp:DropDownList ID="ddlCreditCardNumber" runat="server" AppendDataBoundItems="True">
            <asp:ListItem Value="0">----Select Card Number----</asp:ListItem>
        </asp:DropDownList>
                <br />
    </td><td>
    <asp:Label ID="lblEmailId" runat="server" Text="Email ID"></asp:Label>
                </td><td>
                <asp:TextBox ID="txtEmailId" Width="175px" runat="server"></asp:TextBox>
                <br />
    </td></tr>

    
        <tr><td >
            &nbsp;</td><td>
                &nbsp;</td><td>
                &nbsp;</td><td>
                &nbsp;</td></tr>
    
<tr><td >
          &nbsp;</td><td>
        &nbsp;</td><td>
           &nbsp;</td><td>
        &nbsp;</td></tr>
             <tr><td colspan="4" align="center" >
                 <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="myButton" 
                     onclick="btnSearch_Click"  /></td>
                 
        </tr>
             <tr><td colspan="4" align="center" >
                 &nbsp;</td>
                 
        </tr>
             <tr><td colspan="4" align="center" >
                 <asp:GridView ID="gvCustomerReport" runat="server" AutoGenerateColumns="False" 
                     BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" 
                     CellPadding="4" CellSpacing="2" ForeColor="Black" 
                     onrowcommand="gvCustomerReport_RowCommand">
                     <Columns>
                         <asp:TemplateField HeaderText="Customer Name">
                             <EditItemTemplate>
                                 <asp:TextBox ID="txtcustomername" runat="server" Text='<%# Bind("customername") %>'></asp:TextBox>
                             </EditItemTemplate>
                             <ItemTemplate>
                                 <asp:Label ID="lblcustomername" runat="server" Text='<%# Bind("customername") %>'></asp:Label>
                             </ItemTemplate>
                         </asp:TemplateField>

                         
                         <asp:TemplateField HeaderText="Bank Name">
                             <EditItemTemplate>
                                 <asp:TextBox ID="txtname" runat="server" Text='<%# Bind("name") %>'></asp:TextBox>
                             </EditItemTemplate>
                             <ItemTemplate>
                                 <asp:Label ID="lblname" runat="server" Text='<%# Bind("name") %>'></asp:Label>
                             </ItemTemplate>
                         </asp:TemplateField>

                          <asp:TemplateField HeaderText="Account Number ">
                             <EditItemTemplate>
                                 <asp:TextBox ID="txtAccNO" runat="server" Text='<%# Bind("AccNO") %>'></asp:TextBox>
                             </EditItemTemplate>
                             <ItemTemplate>
                                 <asp:Label ID="lblAccNO" runat="server" Text='<%# Bind("AccNO") %>'></asp:Label>
                             </ItemTemplate>
                         </asp:TemplateField>

                         <asp:TemplateField HeaderText="Registration Details">
                             <EditItemTemplate>
                                 <asp:TextBox ID="txtRegistrationPath" runat="server" 
                                     Text='<%# Bind("RegistrationPath") %>'></asp:TextBox>
                             </EditItemTemplate>
                             <ItemTemplate>
                             <%-- <asp:LinkButton ID="lnkRegistrationPath"  Text='<%# Bind("RegistrationPath") %>'  runat="server">Click Here</asp:LinkButton>--%>
                                 <asp:LinkButton ID="lnkRegistrationPath" CommandName="ViewRegistration"  runat="server">Click to view</asp:LinkButton>
                             </ItemTemplate>
                         </asp:TemplateField>
                         <asp:TemplateField HeaderText="Credit Card Details">
                             <EditItemTemplate>
                                 <asp:TextBox ID="txtCreditCardPath" runat="server" Text='<%# Bind("CreditCardPath") %>'></asp:TextBox>
                             </EditItemTemplate>
                             <ItemTemplate>
                               <%--  <asp:LinkButton ID="lnkCreditCardPath"  Text='<%# Bind("CreditCardPath") %>'  runat="server">Click Here</asp:LinkButton>--%>
                                  <asp:LinkButton ID="lnkCreditCardPath" CommandName="ViewCredit"   runat="server">Click to view</asp:LinkButton>
                             </ItemTemplate>
                         </asp:TemplateField>

                           <asp:TemplateField HeaderText="Bank Id" Visible="false">
                             <EditItemTemplate>
                                 <asp:TextBox ID="txtBankID" runat="server" Text='<%# Bind("BankID") %>'></asp:TextBox>
                             </EditItemTemplate>
                             <ItemTemplate>
                                   <asp:Label ID="lblbankid" runat="server" Text='<%# Bind("BankID") %>'></asp:Label>
                             </ItemTemplate>
                         </asp:TemplateField>

                         <asp:TemplateField HeaderText="Customer Id" Visible="false">
                             <EditItemTemplate>
                                 <asp:TextBox ID="txtcustomerID" runat="server" Text='<%# Bind("customerID") %>'></asp:TextBox>
                             </EditItemTemplate>
                             <ItemTemplate>
                            
                                <asp:Label ID="lblcustomerID" runat="server" Text='<%# Bind("customerID") %>'></asp:Label>
                             </ItemTemplate>
                         </asp:TemplateField>

                     </Columns>
                     <FooterStyle BackColor="#CCCCCC" />
                     <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                     <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                     <RowStyle BackColor="White" />
                     <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                     <SortedAscendingCellStyle BackColor="#F1F1F1" />
                     <SortedAscendingHeaderStyle BackColor="#808080" />
                     <SortedDescendingCellStyle BackColor="#CAC9C9" />
                     <SortedDescendingHeaderStyle BackColor="#383838" />
                 </asp:GridView>
                 </td>
                 
        </tr>
             <tr><td colspan="4">
                 <asp:ScriptManager ID="scmManager" runat="server">
                 </asp:ScriptManager>
                 </td>
        </tr>
                <tr><td colspan="4" align="center" style="height: 150px">
       <br/>
       
    </td></tr>


</table>
</asp:Content>
