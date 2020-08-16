<%@ Page Title="" Language="C#" MasterPageFile="~/MasterBankTemplate.Master" AutoEventWireup="true" CodeBehind="ViewBankCredit.aspx.cs" Inherits="BLDLTemplate.ViewBankCredit" %>
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
                   <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="myButton" 
                       onclick="btnSubmit_Click" />
                   <br />
                   <br />
            
    </td></tr>
<tr><td colspan="2" align="center">
             <asp:GridView ID="gvBankCredit" runat="server" AutoGenerateColumns="False" 
                CellPadding="4" ForeColor="Black" BackColor="#CCCCCC" BorderColor="#999999" 
                       BorderStyle="Solid" BorderWidth="3px" CellSpacing="2" 
                       onrowcommand="gvBalance_RowCommand">
                <Columns>
                    <asp:TemplateField HeaderText="Bank Name">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtname" runat="server" Text='<%# Bind("name") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblname" runat="server" Text='<%# Bind("name") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="IFSC Code">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtifscode" runat="server" Text='<%# Bind("ifscode") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblifscode" runat="server" Text='<%# Bind("ifscode") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Bank Credit">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtswipedamount" runat="server" Text='<%# Bind("swipedamount") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblswipedamount" runat="server" Text='<%# Bind("swipedamount") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                  <asp:TemplateField HeaderText="Date of Transaction">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtsystime" runat="server" Text='<%# Bind("systime") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblsystime" runat="server" Text='<%# Bind("systime") %>'></asp:Label>
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
