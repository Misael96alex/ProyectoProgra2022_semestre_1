<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="modificarUsuario.aspx.cs" Inherits="ConsumeServicio.PaginasUsuario.modificarUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <LINK REL=StyleSheet HREF="modificarUsuario.css" TYPE="text/css"/>
    <title>Modificar Usuario</title>
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
				<li><a href="#">Clinicas</a></li>
				<li><a href="#">Medicamentos</a></li>
                <li><a href="#">Enfermedades</a></li>
			</ul>
		</nav><!-- / nav -->

	</header><!-- / #main-header -->
		
        <div>
			<div class ="titulo"><center><asp:Label ID="Label1" runat="server" Text="Modificar Usuarios"></asp:Label></center>
            </div>
			<center>
			<div class="agregar">
				<asp:TextBox ID="idBuscar" runat="server" placeholder="Id a Buscar" ></asp:TextBox>
				<asp:Button ID="verificar" class="botones btn" runat="server" Text="Verificar" Width="288px" OnClick="verificar_Click"  />
			    
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
			<center>
				<div class="agregar">
					
					<asp:DropDownList Class="clinica" ID="clinica" runat="server" Height="54px" style="margin-left: 0px" Width="300px" margin-bottom="10px">
                    </asp:DropDownList>
					<asp:TextBox ID="nombre" runat="server" placeholder="Nombre" ></asp:TextBox>
					<asp:TextBox ID="apellido" runat="server" placeholder="Apellido" ></asp:TextBox>
					<asp:TextBox ID="fecha_nac" runat="server" placeholder="Fecha nacimiento"   type="date"></asp:TextBox>
					<asp:TextBox ID="dpi" runat="server" placeholder="DPI" ></asp:TextBox>
					<asp:TextBox ID="nit" runat="server" placeholder="Nit" ></asp:TextBox>
					<asp:TextBox ID="direccion" runat="server" placeholder="Dirección" ></asp:TextBox>
					<asp:TextBox ID="correo" runat="server" placeholder="E-mail" ></asp:TextBox>
					<asp:TextBox ID="telefono" runat="server" placeholder="Número de Telefono" ></asp:TextBox>
					<asp:TextBox ID="contrasena" runat="server" placeholder="Contraseña" ></asp:TextBox>
					<asp:Button ID="agregar" class="botones btn" runat="server" Text="Agregar" Width="288px" OnClick="agregar_Click"  />
					<asp:Label ID="salidaLabel" runat="server" Text=" " ForeColor="White"></asp:Label>
				
				</div>
		        
		</center>
        </div>
    </form>
</body>
</html>
