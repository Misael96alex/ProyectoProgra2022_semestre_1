<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="agregarClinica.aspx.cs" Inherits="ConsumeServicio.PaginasClinica.agregarClinica" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <LINK REL=StyleSheet HREF="agregarClinica.css" TYPE="text/css"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <header id="main-header">
		
		<a id="logo-header" href="#">
			SISTEMA CONSULTA MEDICA <span class="site-desc">Programacion I</span>
		</a> <!-- / #logo-header -->

		<nav>
			<ul>
				<li><a href="https://localhost:44321/PaginasClinica/menuClinica.aspx">Clinicas</a></li>
				
			</ul>
		</nav><!-- / nav -->

	</header><!-- / #main-header -->

        <div>
			<div class ="titulo"><center><asp:Label ID="Label1" runat="server" Text="Agregar Clinicas"></asp:Label></center>
            </div>
			<center>
				<div class="agregar">
					<asp:TextBox ID="id_clinica" runat="server" placeholder="Id" required="required" type="number"></asp:TextBox>
					<asp:TextBox ID="nombre_clinica" runat="server" placeholder="Nombre Clinica" required="required"></asp:TextBox>
					<asp:TextBox ID="direccion" runat="server" placeholder="Direccion" required="required"></asp:TextBox>
					<asp:TextBox ID="correo" runat="server" placeholder="Correo" required="required"  ></asp:TextBox>
					<asp:TextBox ID="no_telelefono" runat="server" placeholder="Telefono" required="required" type="number"></asp:TextBox>
					<asp:TextBox ID="nit" runat="server" placeholder="Nit" required="required" type="number" ></asp:TextBox>
					<asp:Button ID="agregar" class="botones btn" runat="server" Text="Agregar" Width="288px" OnClick="agregar_Click" />
					<asp:Label ID="salidaLabel" runat="server" Text=" " ForeColor="White"></asp:Label>
				
				</div>
		        
		</center>
        </div>
    </form>
</body>
</html>
