<%@ Page Title="" Language="C#" MasterPageFile="~/MasterTemplate.Master" AutoEventWireup="true" CodeBehind="AddFavTransaction.aspx.cs" Inherits="BLDLTemplate.AddFavTransaction" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 
 <table class="table" cellpadding="5px" cellspacing="2px">

<tr>
<td colspan="4" class="heading">Search<b> card details </b> </td>

</tr>

<tr>
<td colspan="4" >
    --not required- not in use</td>

</tr>
<tr>
<td >
 <asp:Label ID="lblStartdate" runat="server" Text="Start date"></asp:Label>
    </td><td>
        <br />
    <asp:TextBox ID="txtStartdate" runat="server"></asp:TextBox>
      <asp:Image ID="imgCalender1" runat="server" ImageUrl="~/images/calendar.gif" 
            style="width: 20px" />
<asp:CalendarExtender ID="CalendarExtender1" runat="server" 
            TargetControlID="txtStartdate" PopupButtonID="imgCalender1">
    </asp:CalendarExtender>

      

        <br />
        <asp:RequiredFieldValidator ID="rfvStartdate0" runat="server" 
            ErrorMessage="enter the start date" Font-Italic="True" 
            ForeColor="#990000" ControlToValidate="txtStartdate"></asp:RequiredFieldValidator>
        </td><td>
   <asp:Label ID="lblEnddate" runat="server" Text="End date"></asp:Label> 
        </td><td>
        <asp:TextBox ID="txtEnddate" runat="server"></asp:TextBox>
         <asp:Image ID="imgCalender2" runat="server" ImageUrl="~/images/calendar.gif" 
            style="width: 20px" />
        <asp:CalendarExtender ID="CalendarExtender2" runat="server" 
            TargetControlID="txtEnddate" PopupButtonID="imgCalender2">
    </asp:CalendarExtender>
       

        <br />
        <asp:RequiredFieldValidator ID="rfvEnddate" runat="server" 
            ErrorMessage="enter the end date" Font-Italic="True" 
            ForeColor="#990000" ControlToValidate="txtEnddate"></asp:RequiredFieldValidator>
        </td>  </tr>
<tr>
<td >
 <asp:Label ID="lblnameoffavtransaction" runat="server" Text="name of fav transaction"></asp:Label>
    </td><td>
        <asp:TextBox ID="txtnameoffavtransaction" runat="server"></asp:TextBox>
    </td><td>
        &nbsp;</td><td>
        &nbsp;</td>  </tr>
        <tr><td >
            &nbsp;</td><td>
                <br />
            <asp:Button ID="btnAdd" runat="server" Text="Add"  CssClass="myButton" />
    </td><td>
                <br />
    <asp:Button ID="btnView" CssClass="myButton" runat="server"  Text="View" />
            
                </td><td>
                <br />
    </td></tr>

    
        <tr><td >
            &nbsp;</td><td>
                &nbsp;</td><td>
                &nbsp;</td><td>
                &nbsp;</td></tr>
    
             <tr><td colspan="4" align="center" >
           
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                     BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" 
                     CellPadding="4" CellSpacing="2" ForeColor="Black">
                <Columns>
                    <asp:TemplateField HeaderText="DateofTrans">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtTransdate" runat="server" Text='<%# Bind("Transdate") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblTransdate" runat="server" Text='<%# Bind("Transdate") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="RefNo">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtRef_No" runat="server" Text='<%# Bind("Ref_No") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblRef_No" runat="server" Text='<%# Bind("Ref_No") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Narration">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtNarration" runat="server" Text='<%# Bind("Narration") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblNarration" runat="server" Text='<%# Bind("Narration") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Creditcard">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtCreditcard" runat="server" Text='<%# Bind("Creditcard") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblCreditcard" runat="server" Text='<%# Bind("Creditcard") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Debit">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtDebit" runat="server" Text='<%# Bind("Debit") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblDebit" runat="server" Text='<%# Bind("Debit") %>'></asp:Label>
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
                 <br />
                 <asp:ScriptManager ID="ScriptManager1" runat="server">
                 </asp:ScriptManager>
                 </td>
                 
        </tr>
             

</table>
</asp:Content>
