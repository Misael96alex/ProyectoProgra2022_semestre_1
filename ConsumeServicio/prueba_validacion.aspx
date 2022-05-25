<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="prueba_validacion.aspx.cs" Inherits="ConsumeServicio.prueba_validacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="id" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:TextBox ID="contra" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
