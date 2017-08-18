<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BasicWebEvents.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Countries<br />
        <br />
        <asp:DropDownList ID="CountriesDropDown" runat="server" AutoPostBack="True">
            <asp:ListItem>USA</asp:ListItem>
            <asp:ListItem>Mexico</asp:ListItem>
            <asp:ListItem>Canada</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="SubmitButton" runat="server" Text="Submit" />
        <br />
        <br />
        <asp:Label ID="OutputLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
