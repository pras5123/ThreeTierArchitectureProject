<%@ Page Title="" Language="C#" MasterPageFile="~/MasterTemplate.Master" AutoEventWireup="true" CodeBehind="DailyTransactionScreen.aspx.cs" Inherits="BLDLTemplate.DailyTransactionScreen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table">
    
<tr>
<td colspan="2" class="heading"><b>Daily Transaction Screen</b> </td>

</tr>
    
<tr>

<td >
    &nbsp;</td><td>
        &nbsp;</td>
               <tr>

<td style="height: 21px" >
           <asp:Label ID="lblBankname" runat="server" Text="Bank Name:"></asp:Label>
                   </td><td style="height: 21px">
                      <asp:DropDownList ID="ddlBank" runat="server" AppendDataBoundItems="True">
                 <asp:ListItem Value="0">---------------------------Select Bank----------------------------------</asp:ListItem>
             </asp:DropDownList></td>
               <tr><td >
                   &nbsp;</td><td>
                       <asp:RequiredFieldValidator ID="rfvBank" Font-Bold="true" ForeColor="Red" 
                runat="server" ControlToValidate="ddlBank" ErrorMessage="Please Select Bank" 
                InitialValue="0" Display="Dynamic"></asp:RequiredFieldValidator></td>
        <tr><td colspan="2" align="center">
                   <br />
                   <br />
                   <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="myButton" 
                       onclick="btnSubmit_Click" />
                   <br />
                   <br />
            <asp:GridView ID="gvBalance" runat="server" AutoGenerateColumns="False" 
                CellPadding="4" ForeColor="Black" BackColor="#CCCCCC" BorderColor="#999999" 
                       BorderStyle="Solid" BorderWidth="3px" CellSpacing="2" 
                       onrowcommand="gvBalance_RowCommand">
                <Columns>
                    <asp:TemplateField HeaderText="Account No">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtAccNo" runat="server" Text='<%# Bind("bankaccNo") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblAccNo" runat="server" Text='<%# Bind("bankaccNo") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Account Type">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtAcctype" runat="server" Text='<%# Bind("AccountType") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblAcctype" runat="server" Text='<%# Bind("AccountType") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Available Balance">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtBalance" runat="server" Text='<%# Bind("totalavailablebalance") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblBalance" runat="server" Text='<%# Bind("totalavailablebalance") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="All Transactions">
                            
                            <ItemTemplate>
                                <asp:LinkButton ID="lnkClickHere" CommandName="View" runat="server">View</asp:LinkButton>
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
    </td></tr>
<tr><td colspan="2" align="center">
            <br />
            <asp:GridView ID="gvTransaction" runat="server" AutoGenerateColumns="False" 
                     BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" 
                     CellPadding="4" CellSpacing="2" ForeColor="Black" AllowSorting="True" 
                onpageindexchanged="gvTransaction_PageIndexChanged" 
                onpageindexchanging="gvTransaction_PageIndexChanging" AllowPaging="True">
                <Columns>
                    <asp:TemplateField HeaderText="Transaction Date">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtTransdate" runat="server" Text='<%# Bind("dateoftrans") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblTransdate" runat="server" Text='<%# Bind("dateoftrans") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Narration">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtnarration" runat="server" Text='<%# Bind("narration") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblnarration" runat="server" Text='<%# Bind("narration") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Reference No">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtrefno" runat="server" Text='<%# Bind("refno") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblrefno" runat="server" Text='<%# Bind("refno") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Credit">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtcreditamount" runat="server" Text='<%# Bind("creditamount") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblcreditamount" runat="server" Text='<%# Bind("creditamount") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Debit">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtDebit" runat="server" Text='<%# Bind("crdtdbtamt") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblDebit" runat="server" Text='<%# Bind("crdtdbtamt") %>'></asp:Label>
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
    </td></tr>
</table>
</asp:Content>
