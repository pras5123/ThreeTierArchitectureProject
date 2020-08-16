<%@ Page Title="" Language="C#" MasterPageFile="~/MasterBankTemplate.Master" AutoEventWireup="true"
    CodeBehind="LockInvalidateCard.aspx.cs" Inherits="BLDLTemplate.LockInvalidateCard" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table" cellpadding="5px" cellspacing="2px">
        <tr>
            <td colspan="4" class="heading">
                Search<b> card details </b>
            </td>
        </tr>
        <tr>
            <td colspan="4">
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblCustname" runat="server" Text="Customer Name"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlCustomerName" runat="server" AppendDataBoundItems="True">
                    <asp:ListItem Value="0">----Select Customer ----</asp:ListItem>
                </asp:DropDownList>
                <br />
            </td>
            <td>
                <asp:Label ID="lblAccountnumber" runat="server" Text="Account number"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlAccountNumber" runat="server" AppendDataBoundItems="True">
                    <asp:ListItem Value="0">----Select Account Number----</asp:ListItem>
                </asp:DropDownList>
                <br />
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblCreditNumber" runat="server" Text="Credit card Number"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlCreditCardNumber" runat="server" AppendDataBoundItems="True">
                    <asp:ListItem Value="0">----Select Card Number----</asp:ListItem>
                </asp:DropDownList>
                <br />
            </td>
            <td>
                <asp:Label ID="lblBankID" runat="server" Text="Bank ID"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlBankID" Width="175px" runat="server" AppendDataBoundItems="True">
                    <asp:ListItem Value="0">-------Select Bank ID-------</asp:ListItem>
                </asp:DropDownList>
                <br />
            </td>
        </tr>
       
        <tr>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td colspan="4" align="center">
                <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="myButton" OnClick="btnSearch_Click" />
            </td>
        </tr>
        <tr>
            <td colspan="4" align="center">
                <asp:GridView ID="gvSearchInvalidated" runat="server" AutoGenerateColumns="False"
                    BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px"
                    CellPadding="4" CellSpacing="2" ForeColor="Black" 
                    onpageindexchanged="gvSearchInvalidated_PageIndexChanged" 
                    onpageindexchanging="gvSearchInvalidated_PageIndexChanging" 
                    onrowcancelingedit="gvSearchInvalidated_RowCancelingEdit" 
                    onrowediting="gvSearchInvalidated_RowEditing" 
                    onrowupdating="gvSearchInvalidated_RowUpdating" 
                    onrowdatabound="gvSearchInvalidated_RowDataBound">
                    <Columns>


                       <asp:TemplateField Visible="false">
                            <EditItemTemplate>
                         
                              <asp:Label ID="lblBankIDEdit" runat="server" Text='<%# Bind("BankID") %>'></asp:Label>
                           
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lblBankIDItem" runat="server" Text='<%# Bind("BankID") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>



                           <asp:TemplateField Visible="false">
                            <EditItemTemplate>
                         
                              <asp:Label ID="lblcustomerIDEdit" runat="server" Text='<%# Bind("customerID") %>'></asp:Label>
                           
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lblcustomerIDItem" runat="server" Text='<%# Bind("customerID") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>



                        <asp:TemplateField HeaderText="Customer Name">
                            <EditItemTemplate>
                               
                            <asp:Label ID="lblCustomerName" runat="server" Text='<%# Bind("customername") %>'></asp:Label>
                            
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lblCustomerName" runat="server" Text='<%# Bind("customername") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>



                        <asp:TemplateField HeaderText="Credit Card Number">
                            <EditItemTemplate>
                         
                              <asp:Label ID="lblCreditID" runat="server" Text='<%# Bind("creditID") %>'></asp:Label>
                           
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lblCreditID" runat="server" Text='<%# Bind("creditID") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>



                        <asp:TemplateField HeaderText="Valid ? ">
                            <EditItemTemplate>
                              <asp:RadioButtonList ID="rbtnYesNoValidEdit" runat="server"  RepeatDirection="Horizontal">
                                    <asp:ListItem Value="1">Yes</asp:ListItem>
                                    <asp:ListItem Value="0">No</asp:ListItem>
                                </asp:RadioButtonList>
                                  <asp:Label ID="lblValidEdit" Visible="false"  runat="server" Text='<%# Bind("valid") %>'></asp:Label>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lblValidItem"   runat="server" Text='<%# Bind("valid") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>



                        <asp:TemplateField HeaderText="Locked ? ">
                            <EditItemTemplate>
                                <asp:RadioButtonList ID="rbtnYesNoLockedEdit" runat="server" RepeatDirection="Horizontal">
                                    <asp:ListItem Value="1">Yes</asp:ListItem>
                                    <asp:ListItem Value="0">No</asp:ListItem>
                                </asp:RadioButtonList>
                                <asp:Label ID="lblLockedEdit" Visible="false" runat="server" Text='<%# Bind("locked") %>'></asp:Label>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lblLockedItem" runat="server" Text='<%# Bind("locked") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>



                        <asp:TemplateField HeaderText="Add|Edit">
                            <EditItemTemplate>
                                <asp:ImageButton ID="btnUpdateFirst" ValidationGroup="Edit" CausesValidation="true"
                                    runat="server" CommandName="Update" ImageUrl="~/images/Update.png" ToolTip="Update" />
                                &nbsp;&nbsp;<asp:ImageButton ID="btnCancelFirst" CausesValidation="false" runat="server"
                                    CommandName="Cancel" ImageUrl="~/images/Cancel.png" ToolTip="Cancel" />
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:ImageButton ID="btneditFirst" CausesValidation="false" runat="server" CommandName="Edit"
                                    ImageUrl="~/images/Edit.png" ToolTip="Edit" />
                                &nbsp;&nbsp;
                            </ItemTemplate>
                            <HeaderStyle Font-Size="11px" />
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
        <tr>
            <td colspan="4">
                <asp:ScriptManager ID="scmManager" runat="server">
                </asp:ScriptManager>
            </td>
        </tr>
        <tr>
            <td colspan="4" align="center" style="height: 150px">
                <br />
            </td>
        </tr>
    </table>
</asp:Content>
