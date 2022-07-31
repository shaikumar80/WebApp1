<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>my web application</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:label ID="lblname" runat="server" Text="UserName"></asp:label>
            <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
            <asp:Label ID="lblpass" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txtpass" runat="server"></asp:TextBox>
            <asp:Button ID="button" runat="server" Text="submit" OnClick="button_Click" />
                
        </div>
    </form>
</body>
</html>
