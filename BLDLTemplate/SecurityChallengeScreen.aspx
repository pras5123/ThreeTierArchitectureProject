<%@ Page Title="" Language="C#" MasterPageFile="~/MasterTemplate.Master" AutoEventWireup="true" CodeBehind="SecurityChallengeScreen.aspx.cs" Inherits="BLDLTemplate.SecurityChallengeScreen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table class="table">
<tr>
 <td colspan="2" class="heading" style="height: 30px"><b>security challenge screen</b></td>
 </tr>
 <tr>       
<td class="style1" style="width: 146px; height: 26px;" >
 <asp:Label ID="lblselectaquestion" runat="server" Text="select a question:"></asp:Label>
    </td><td style="height: 26px">
        <asp:DropDownList ID="ddlQuestion" runat="server" AppendDataBoundItems="True">
            <asp:ListItem Value="0">--------Please select a question------</asp:ListItem>
        </asp:DropDownList>
    </td></tr>
 <tr>       
<td class="style1" style="width: 146px; height: 26px;" >
    &nbsp;</td><td style="height: 26px">
         <asp:RequiredFieldValidator ID="rfvQuestion" Font-Bold="true" ForeColor="Red" 
                runat="server" ControlToValidate="ddlQuestion" ErrorMessage="Select Question" 
                InitialValue="0" Display="Dynamic"></asp:RequiredFieldValidator></td></tr>
         <tr><td class="style1" style="width: 146px; height: 22px;" >
 <asp:Label ID="lblenteraanswer" runat="server" Text="enter a answer:"></asp:Label>
    </td><td style="height: 22px">
        <asp:TextBox ID="txtAnswer" Width="232px" runat="server" style="margin-bottom: 0px"></asp:TextBox>
    </td></tr>
         <tr><td class="style1" style="width: 146px; height: 22px;" >
             &nbsp;</td><td style="height: 22px">
                <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                     ErrorMessage="RequiredFieldValidator" Font-Italic="True" ForeColor="#990000"></asp:RequiredFieldValidator>--%>
                 <asp:RequiredFieldValidator ID="rfventerananswer" runat="server" 
                     ControlToValidate="txtAnswer" ErrorMessage="Please Enter your answer" 
                      ForeColor="Red" Font-Bold="true"></asp:RequiredFieldValidator>
    </td></tr>
    <tr><td colspan="2" align="center" style="height: 91px">
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="myButton" 
            onclick="btnSubmit_Click" />
        </td></tr>
   


</table>
</asp:Content>
