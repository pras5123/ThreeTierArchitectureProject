<%@ Page Title="" Language="C#" MasterPageFile="~/MasterBankTemplate.Master" AutoEventWireup="true"
    CodeBehind="ImportCustomerDetail.aspx.cs" Inherits="BLDLTemplate.ImportCustomerDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <asp:UpdatePanel ID="pnlMain" runat="server">
            <ContentTemplate>

    <table class="table" cellpadding="2px" cellspacing="2px">
        <tr>
            <td colspan="4" class="heading" >
                <b>Import Customer Details</b>
            </td>
        </tr>
       
        <tr>
            <td colspan="2">
                <asp:ScriptManager ID="scmManager" runat="server">
                </asp:ScriptManager>
            </td>
            <td colspan="2">
                &nbsp;</td>
        </tr>
       
      


        <tr>
            <td colspan="2" >
                <asp:Label ID="lblAccountNumber" runat="server" Text="Current Account Number"></asp:Label>
            </td>
            
            <td colspan="2">
                <asp:TextBox ID="txtAccountNumber" Width="200px" runat="server" 
                    AutoPostBack="True" ontextchanged="txtAccountNumber_TextChanged"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator ID="rfvAcountNumber" runat="server" 
                    ControlToValidate="txtAccountNumber" ErrorMessage="Enter Account Number" 
                    Font-Bold="true" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                <br />
                <asp:RegularExpressionValidator ID="revAccountNumber" runat="server" 
            ErrorMessage="Enter Valid Account Number.Min :10 digits" Font-Bold="true"  ForeColor="Red" 
            ControlToValidate="txtAccountNumber" 
            ValidationExpression="^\d{10,20}$" Display="Dynamic"></asp:RegularExpressionValidator>
            </td>
           

        </tr>
        <tr>
            <td colspan="2">
                &nbsp;
            </td>
            <td colspan="2">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td >
    <asp:Label ID="lblEmailId" runat="server" Text="Email Id"></asp:Label>
            </td>
            <td>
                &nbsp;
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
    

               

                <br />
                <asp:RequiredFieldValidator ID="rfvEmail" runat="server" 
                    ControlToValidate="txtEmail" ErrorMessage="Email Id is Required" 
                    Font-Bold="true" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
    

               

            </td>
            <td >
                <asp:Label ID="lblCheque" runat="server" Text="Account with Cheque book ?"></asp:Label>
            </td>
            <td>
                <asp:RadioButtonList ID="rbtnYesNo" runat="server" 
                    RepeatDirection="Horizontal">
                    <asp:ListItem Selected="True">Yes</asp:ListItem>
                    <asp:ListItem>No</asp:ListItem>
                </asp:RadioButtonList>
               
            </td>
        </tr>
        <tr>
            <td >
                &nbsp;</td>
            <td>
        <asp:RegularExpressionValidator ID="revEmailID" runat="server" 
            ErrorMessage="Enter Valid email Id" Font-Bold="true"  ForeColor="Red" 
            ControlToValidate="txtEmail" 
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                    Display="Dynamic"></asp:RegularExpressionValidator>

            </td>
            <td >
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>

        <tr>
            <td style="width:140px">
 <asp:Label ID="lblCustomerName" runat="server" Text="Customer Name"></asp:Label>
            </td>
            <td>
        <asp:TextBox ID="txtCustomerName" runat="server"></asp:TextBox>

            </td>
            <td >
                <asp:Label ID="lblContact" runat="server" Text="Contact Number"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtContact" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td >
                &nbsp;</td>
            <td>
                <asp:RequiredFieldValidator ID="rfvCustomername" runat="server" 
                    ControlToValidate="txtCustomerName" ErrorMessage="Enter customer name" 
                    Font-Bold="true" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
            <td >
                &nbsp;</td>
            <td>
                <asp:RequiredFieldValidator ID="rfvContactNumber" runat="server" 
                    ControlToValidate="txtContact" ErrorMessage="Enter Contact Number" 
                    Font-Bold="true" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                <br />
                <asp:RegularExpressionValidator ID="revContactNumber" runat="server" 
            ErrorMessage="Enter Valid Contact Number" Font-Bold="true"  ForeColor="Red" 
            ControlToValidate="txtContact" 
            ValidationExpression="^\d{10}$" 
            Display="Dynamic"></asp:RegularExpressionValidator>
            </td>
        </tr>

          <tr>
            <td colspan="2" >
                <asp:Label ID="lblcurrentbank" runat="server" Text="current bank:"></asp:Label>
            </td>
            <td colspan="2">
                <asp:DropDownList ID="ddlFromBank" runat="server" AppendDataBoundItems="True">
                    <asp:ListItem Value="0">---------------------------Select Bank----------------------------------</asp:ListItem>
                </asp:DropDownList>
                <br />
         <asp:RequiredFieldValidator ID="rfvFromBank" Font-Bold="true" ForeColor="Red" 
                runat="server" ControlToValidate="ddlFromBank" ErrorMessage="Select From Bank" 
                InitialValue="0" Display="Dynamic"></asp:RequiredFieldValidator>

                <br />

            </td>
        </tr>
        <tr>
            <td colspan="2">
                &nbsp;</td>
            <td colspan="2">
                <br />
            </td>
        </tr>
        <tr>
            <td colspan="2" >
                <asp:Label ID="lblselectbank" runat="server" Text="select bank:"></asp:Label>
            </td>
            <td colspan="2">
                <asp:DropDownList ID="ddlToBank" runat="server" AppendDataBoundItems="True">
                    <asp:ListItem Value="0">---------------------------Select Bank----------------------------------</asp:ListItem>
                </asp:DropDownList>
                <br />
         <asp:RequiredFieldValidator ID="rfvToBank" Font-Bold="true" ForeColor="Red" 
                runat="server" ControlToValidate="ddlToBank" ErrorMessage="Select To Bank" 
                InitialValue="0" Display="Dynamic"></asp:RequiredFieldValidator>

                <br />

            </td>
        </tr>
        <tr>
            <td colspan="2">
            </td>
            <td colspan="2">
                &nbsp;
            </td>
        </tr>

        <tr>
      
            <td colspan="4" align="center">
                <asp:Button ID="btnImport" runat="server" Text="Import" CssClass="myButton" OnClick="btnImport_Click" />
            </td>
        </tr>
    </table>

      </ContentTemplate>
        </asp:UpdatePanel>
    <asp:UpdateProgress ID="pgrMain" AssociatedUpdatePanelID="pnlMain" runat="server">
            <ProgressTemplate>
             <div style="position:absolute;margin:auto; padding-left:30%">
              <img src="images/Telerik.Web.UI.Skins.WebBlue.Common.loading.gif" style="position:relative;top:45%"  />
          </div> 
            </ProgressTemplate>
        </asp:UpdateProgress>
</asp:Content>
