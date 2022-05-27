<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="borrarClinica.aspx.cs" Inherits="ConsumeServicio.PaginasClinica.borrarClinica" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <LINK REL=StyleSheet HREF="borrarClinica.css" TYPE="text/css"/>
    <title>Borrar Clinica</title>
</head>
<body>
    <form id="form1" runat="server">
        <header id="main-header">
		
		<a id="logo-header" href="#">
			SISTEMA CONSULTA MEDICA <span class="site-desc">Programacion I</span>
		</a> <!-- / #logo-header -->

		<nav>
			<ul>
				<li><a href="https://localhost:44321/PaginasClinica/menuClinica.aspx">Clinica</a></li>
				
			</ul>
		</nav><!-- / nav -->

	</header><!-- / #main-header -->
        <div>
			<div class ="titulo"><center><asp:Label ID="Label1" runat="server" Text="Borrar Clinica"></asp:Label></center>
            </div>
			<center>
			<div class="agregar">
				<asp:TextBox ID="idBuscar" runat="server" placeholder="Id a Buscar" required="required" ></asp:TextBox>
				<asp:Button ID="verificar" class="botones btn" runat="server" Text="Verificar" Width="288px" OnClick="verificar_Click"   />
			    <asp:Button ID="borrar" class="botones btn" runat="server" Text="Borrar" Width="288px" OnClick="borrar_Click"   />
			</div>
				<asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" />
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
				<br />
			</center>
        </div>
    </form>
</body>
</html>
