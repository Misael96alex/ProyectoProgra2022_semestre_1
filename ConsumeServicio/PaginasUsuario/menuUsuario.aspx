﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menuUsuario.aspx.cs" Inherits="ConsumeServicio.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <LINK REL=StyleSheet HREF="menuUsuario.css" TYPE="text/css"/>
    <title>Menu Usuario</title>
</head>
<body>
    <form id="form1" runat="server">
        <header id="main-header">
		
		<a id="logo-header" href="#">
			SISTEMA CONSULTA MEDICA <span class="site-desc">Programacion I</span>
		</a> <!-- / #logo-header -->

		<nav>
			<ul>
				<li><a href="https://localhost:44321/PaginasUsuario/menuUsuario.aspx">Usuarios</a></li>
				<li><a href="https://localhost:44321/PaginasClinica/menuClinica.aspx">Clinicas</a></li>
				<li><a href="#">Empleados</a></li>
                <li><a href="#">Pacientes</a></li>
                <li><a href="#">Medicamentos</a></li>
                <li><a href="#">Enfermedad</a></li>
                <li><a href="#">Registros Medicos</a></li>
                <li><a href="#">Reportería</a></li>
			</ul>
		</nav><!-- / nav -->

	</header><!-- / #main-header -->

        <div>
            <div class ="titulo"><center><asp:Label ID="Label1" runat="server" Text="Menú Usuarios"></asp:Label></center><br /></div>
            <center><asp:GridView ID="GridView1" runat="server" CellPadding="4" Width="422px" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px">
                <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                <RowStyle BackColor="White" ForeColor="#003399" />
                <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <SortedAscendingCellStyle BackColor="#EDF6F6" />
                <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                <SortedDescendingCellStyle BackColor="#D6DFDF" />
                <SortedDescendingHeaderStyle BackColor="#002876" />
            </asp:GridView></center>
        </div>
        <div class="botones">
            <center>
            <asp:Button ID="Agregar" class="btn" runat="server" Text="Agregar" OnClick="Agregar_Click" />
            <asp:Button ID="Eliminar" class="btn" runat="server" Text="Eliminar" OnClick="Eliminar_Click" />
            <asp:Button ID="Modificar" class="btn" runat="server" Text="Modificar" OnClick="Modificar_Click" />
            <asp:Button ID="Buscar" class="btn" runat="server" Text="Buscar" OnClick="Buscar_Click" />
            </center>
        </div>
    </form>
</body>
</html>
