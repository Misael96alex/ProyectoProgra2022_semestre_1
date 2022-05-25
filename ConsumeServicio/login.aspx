<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="ConsumeServicio.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<LINK REL=StyleSheet HREF="login.css" TYPE="text/css">
    <title>Login Usuarios</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="login">
	<h1>Login</h1>
        <asp:TextBox ID="Usuario"  placeholder="Usuario" runat="server"></asp:TextBox>
    	<asp:TextBox ID="Contra"  placeholder="Contraseña" runat="server"></asp:TextBox>
        <asp:Button ID="Ingresar"  class="btn btn-primary btn-block btn-large"  runat="server" Text="Ingresar" OnClick="Ingresar_Click"  />
    </div>
    </form>
</body>
</html>
