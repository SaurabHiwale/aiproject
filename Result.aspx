<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Result.aspx.cs" Inherits="Result" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    bbbb</p>
<p>
    &nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="Label1" runat="server" ForeColor="White" 
        style="font-weight: 700" Text="Enter your seat number (eg : 101) : "></asp:Label>
&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server" ontextchanged="TextBox1_TextChanged" 
        Width="162px"></asp:TextBox>
</p>
<p>
    &nbsp;&nbsp; &nbsp;<asp:Label ID="Label2" runat="server" ForeColor="Aqua" 
        style="font-weight: 700"></asp:Label>
</p>
<p>
    &nbsp;&nbsp;&nbsp; &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
</asp:Content>

