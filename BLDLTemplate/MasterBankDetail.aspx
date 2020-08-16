<%@ Page Title="" Language="C#" MasterPageFile="~/MasterBankTemplate.Master" AutoEventWireup="true" CodeBehind="MasterBankDetail.aspx.cs" Inherits="BLDLTemplate.MasterBankDetail" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="scmManager" runat="server">
    </asp:ScriptManager>

    <table class="table" cellspacing="5px" cellpadding="2px">
<tr>
<td colspan="4" class="heading"><b>bank Master details </b>&nbsp;</td>

</tr>

<tr>
<td colspan="4" >
    &nbsp;</td>

</tr>
<tr>

<td >
 <asp:Label ID="lblBankid" runat="server" Text="Bank id"></asp:Label>
    </td><td>
        <asp:TextBox ID="txtBankid" Width="181px" runat="server"></asp:TextBox>
    </td><td>
    <asp:Label ID="lblBankname" runat="server" Text="Bank name"></asp:Label>
    </td>
    <td>
      
    
        <asp:TextBox ID="txtBankname" Width="181px" runat="server"></asp:TextBox></td></tr>
<tr>

<td >
    &nbsp;</td><td>
        <asp:RequiredFieldValidator ID="rfventerBankId" runat="server" 
            ErrorMessage="Bank ID is Required" ControlToValidate="txtBankid" 
            Font-Bold="True" ForeColor="Red" 
             ></asp:RequiredFieldValidator>
    </td><td>
        &nbsp;</td>
    <td>
        <asp:RequiredFieldValidator ID="rfventerBankname" runat="server" 
             ForeColor="Red" Font-Bold="true" ControlToValidate="txtBankname" 
            ErrorMessage="Bank Name is Required"></asp:RequiredFieldValidator>
    </td>
    </tr>
<tr><td >
 <asp:Label ID="lblBankaddess" runat="server" Text="Bank addess"></asp:Label>
    </td><td>
        <asp:TextBox ID="txtBankaddress" runat="server" TextMode="MultiLine" 
            ></asp:TextBox>
    </td><td>
    <asp:Label ID="lblBranch" runat="server" Text="Branch"></asp:Label>
    </td><td>
        <asp:TextBox ID="txtBranch" Width="181px" runat="server"></asp:TextBox>
    </td></tr>
<tr><td >
    &nbsp;</td><td>
        <asp:RequiredFieldValidator ID="rfvBankAddress" runat="server" 
            ErrorMessage="Bank Address is Required" Font-Bold="true" ForeColor="Red" ControlToValidate="txtBankaddress"></asp:RequiredFieldValidator>
    </td><td>
        &nbsp;</td><td>
        <asp:RequiredFieldValidator ID="rfvtxtBankname" runat="server" 
            ControlToValidate="txtBranch" Font-Bold="true" ErrorMessage="Branch Name is required" 
             ForeColor="Red"></asp:RequiredFieldValidator>
    </td></tr>
<tr><td >
 <asp:Label ID="lblIFSCcode" runat="server" Text="IFSC code"></asp:Label>
    </td><td>
        <asp:TextBox ID="txtIFSCcode" Width="181px"  runat="server"></asp:TextBox>
    </td><td>
        &nbsp;</td><td>&nbsp;</td></tr>
<tr><td >
    &nbsp;</td><td>
        <asp:RequiredFieldValidator ID="rfvIFSCcode" runat="server" 
            ControlToValidate="txtIFSCcode" ErrorMessage="IFSC Code is Required"  
            ForeColor="Red" Font-Bold="true"></asp:RequiredFieldValidator>
    </td><td>
        &nbsp;</td><td>&nbsp;</td></tr>
<tr><td colspan="2" align="center">
       &nbsp;</td><td colspan="2" align="center">
        &nbsp;</td></tr>
<tr><td colspan="2" align="center">
       <asp:Button ID="btnAdd" runat="server" Text="Add" onclick="btnAdd_Click" 
           CssClass="myButton" />
    </td><td colspan="2" align="center">
        <asp:Button ID="btnShow" runat="server" Text="Show" onclick="btnShow_Click" 
            CssClass="myButton" CausesValidation="False" />
    </td></tr>
<tr><td colspan="4" align="center">
       &nbsp;</td></tr>
<tr><td colspan="4" align="center">
<asp:UpdatePanel ID="pnlBankDetails" runat="server">
<ContentTemplate>
       <asp:GridView ID="gvBankDetails"  runat="server" 
           AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" 
           BorderStyle="Solid" BorderWidth="3px" CellPadding="4" ForeColor="Black" AllowPaging="True" 
           onpageindexchanged="gvBankDetails_PageIndexChanged" PageSize="5" 
           CellSpacing="2" onrowcancelingedit="gvBankDetails_RowCancelingEdit" 
           onrowdeleting="gvBankDetails_RowDeleting" 
           onrowediting="gvBankDetails_RowEditing" 
           onrowupdating="gvBankDetails_RowUpdating" DataKeyNames="BankID" 
           onpageindexchanging="gvBankDetails_PageIndexChanging">
           <Columns>

           <asp:TemplateField HeaderText="MICR Code">
                   <EditItemTemplate>
                       <asp:TextBox ID="txtMICRCode" runat="server" ValidationGroup="Edit" Text='<%# Bind("BankID") %>'></asp:TextBox>
                       <asp:RequiredFieldValidator ID="rfvMICRCode" Display="None" runat="server" ControlToValidate="txtMICRCode" ValidationGroup="Edit" ErrorMessage="Enter Bank ID"></asp:RequiredFieldValidator>
                                        <cc1:ValidatorCalloutExtender ID="vceMICRCode" TargetControlID="rfvMICRCode" runat="server"></cc1:ValidatorCalloutExtender>
                                   
                   </EditItemTemplate>
                   <ItemTemplate>
                       <asp:Label ID="lblMICRCode" runat="server" Text='<%# Bind("BankID") %>'></asp:Label>
                   </ItemTemplate>
               </asp:TemplateField>

               <asp:TemplateField HeaderText="Bank Name">
                   <EditItemTemplate>
                       <asp:TextBox ID="txtBname" runat="server" ValidationGroup="Edit" Text='<%# Bind("name") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvBname" Display="None" runat="server" ControlToValidate="txtBname" ValidationGroup="Edit" ErrorMessage="Enter Bank Name"></asp:RequiredFieldValidator>
                                        <cc1:ValidatorCalloutExtender ID="vceBname" TargetControlID="rfvBname" runat="server"></cc1:ValidatorCalloutExtender>
                  
                   </EditItemTemplate>
                   <ItemTemplate>
                       <asp:Label ID="lblBname" runat="server" Text='<%# Bind("name") %>'></asp:Label>
                   </ItemTemplate>
               </asp:TemplateField>
               <asp:TemplateField HeaderText="Branch">
                   <EditItemTemplate>
                       <asp:TextBox ID="txtBranch" runat="server" ValidationGroup="Edit" Text='<%# Bind("branch") %>'></asp:TextBox>
                          <asp:RequiredFieldValidator ID="rfvBranch" Display="None" runat="server" ControlToValidate="txtBranch" ValidationGroup="Edit" ErrorMessage="Enter Branch Name"></asp:RequiredFieldValidator>
                                        <cc1:ValidatorCalloutExtender ID="vceBranch" TargetControlID="rfvBranch" runat="server"></cc1:ValidatorCalloutExtender>
                  
                 
                   </EditItemTemplate>
                   <ItemTemplate>
                       <asp:Label ID="lblBranch" runat="server" Text='<%# Bind("branch") %>'></asp:Label>
                   </ItemTemplate>
               </asp:TemplateField>
               <asp:TemplateField HeaderText="Bank Address">
                   <EditItemTemplate>
                       <asp:TextBox ID="txtBaddress" runat="server" ValidationGroup="Edit" Text='<%# Bind("addr") %>'></asp:TextBox>
                         <asp:RequiredFieldValidator ID="rfvBaddress" Display="None" runat="server" ControlToValidate="txtBaddress" ValidationGroup="Edit" ErrorMessage="Enter Branch Address"></asp:RequiredFieldValidator>
                                        <cc1:ValidatorCalloutExtender ID="vceBaddress" TargetControlID="rfvBaddress" runat="server"></cc1:ValidatorCalloutExtender>
                  
                 
                   </EditItemTemplate>
                   <ItemTemplate>
                       <asp:Label ID="lblBaddress" runat="server" Text='<%# Bind("addr") %>'></asp:Label>
                   </ItemTemplate>
               </asp:TemplateField>

               <asp:TemplateField HeaderText="IFSCCode" Visible="false">
                   <EditItemTemplate>
                       <asp:TextBox ID="txtIFSCCode" runat="server" ValidationGroup="Edit" Text='<%# Bind("ifscode") %>'></asp:TextBox>

                   </EditItemTemplate>
                   <ItemTemplate>
                       <asp:Label ID="lblIFSCCode" runat="server" Text='<%# Bind("ifscode") %>'></asp:Label>
                   </ItemTemplate>
               </asp:TemplateField>

               <asp:TemplateField HeaderText="Add|Edit">
                                    <EditItemTemplate>
                                        <asp:ImageButton ID="btnUpdateFirst" ValidationGroup="Edit" CausesValidation="true" runat="server" CommandName="Update" ImageUrl="~/images/Update.png" ToolTip="Update" />
                                        &nbsp;&nbsp;<asp:ImageButton ID="btnCancelFirst" CausesValidation="false" runat="server" CommandName="Cancel" ImageUrl="~/images/Cancel.png" ToolTip="Cancel" />
                                    </EditItemTemplate>
                                  
                                    <ItemTemplate>
                                        <asp:ImageButton ID="btneditFirst" CausesValidation="false" runat="server" CommandName="Edit" ImageUrl="~/images/Edit.png" ToolTip="Edit" />
                                        &nbsp;&nbsp;<%--<asp:ImageButton ID="btndeleteFirst" CausesValidation="false" runat="server" CommandName="Delete" ImageUrl="~/images/Delete.gif" ToolTip="Delete" />--%>
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

       </ContentTemplate>
</asp:UpdatePanel>
    </td><td>
        &nbsp;</td><td>&nbsp;</td></tr>
   

</table>

</asp:Content>
