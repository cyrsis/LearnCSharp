<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HelloWebForms._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <asp:Button ID="Button1"  runat="server" OnClick="Button1_Click" Text="Button" Height="70px" Width="200px" Font-Size="Large" Enabled="False" EnableTheming="True" ForeColor="#6699FF" />
    &nbsp;
    <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>

</asp:Content>
