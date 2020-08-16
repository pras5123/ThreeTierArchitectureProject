<%@ Page Title="" Language="C#" MasterPageFile="~/MasterTemplate.Master" AutoEventWireup="true"  CodeBehind="ExportOption.aspx.cs" Inherits="BLDLTemplate.ExportOption" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
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
 <asp:Label ID="lblStartdate" runat="server" Text="Start date"></asp:Label>
    </td><td>
        <br />
    <asp:TextBox ID="txtStartdate" runat="server"></asp:TextBox>
      <asp:Image ID="imgStartdate" runat="server" ImageUrl="~/images/calendar.gif" 
            style="width: 20px" />
<asp:CalendarExtender ID="ceStartdate" runat="server" 
            TargetControlID="txtStartdate" PopupButtonID="imgStartdate">
    </asp:CalendarExtender>

        </td><td>
   <asp:Label ID="lblEnddate" runat="server" Text="End date"></asp:Label> 
        </td><td>
        <asp:TextBox ID="txtEnddate" runat="server"></asp:TextBox>
         <asp:Image ID="imgEnddate" runat="server" ImageUrl="~/images/calendar.gif" 
            style="width: 20px" />
        <asp:CalendarExtender ID="ceEndDate" runat="server" 
            TargetControlID="txtEnddate" PopupButtonID="imgEnddate">
    </asp:CalendarExtender>
       

        <br />
        </td>  </tr>
<tr>
<td >
    &nbsp;</td><td>

        <asp:RequiredFieldValidator ID="rfvStartdate" runat="server" 
            ErrorMessage="Enter the start date" Font-Bold="true" 
            ForeColor="Red" ControlToValidate="txtStartdate"></asp:RequiredFieldValidator>
        </td><td>
        &nbsp;</td><td>
        <asp:RequiredFieldValidator ID="rfvEnddate" runat="server" 
            ErrorMessage="Enter the end date" Font-Bold="true"
            ForeColor="Red" ControlToValidate="txtEnddate"></asp:RequiredFieldValidator>
        </td>  </tr>
        <tr><td colspan="4" align="center">
                
    <asp:Button ID="btnView" CssClass="myButton" runat="server"  Text="View" 
                    onclick="btnView_Click" />
            
                </td></tr>

    
        <tr><td >
            &nbsp;</td><td>
                &nbsp;</td><td>
                &nbsp;</td><td>
                &nbsp;</td></tr>
    
             <tr><td colspan="4" align="center" >
           
            <asp:GridView ID="gvExport" runat="server" AutoGenerateColumns="False" 
                     BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" 
                     CellPadding="4" CellSpacing="2" ForeColor="Black">
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
                 </td>
                 
        </tr>
             

             <tr ><td colspan="2" align="center" >
           
    <asp:Button ID="btnExcelExport" Visible="false" CssClass="myButton" runat="server"  Text="Excel Export" onclick="btnExcelExport_Click" 
                     />
            
                 </td>
                 <td colspan="2" align="center" >
                
    <asp:Button ID="btnPdfExport" CssClass="myButton" Visible="false" runat="server"  Text="PDF Export" onclick="btnPdfExport_Click" 
                     />
            
                 &nbsp;</td>
                 
        </tr>
             

             <tr><td colspan="4" align="center" >
           
                 <br />
                 <asp:ScriptManager ID="scmManager" runat="server">
                 </asp:ScriptManager>
                 </td>
                 
        </tr>
             

</table>

</asp:Content>


