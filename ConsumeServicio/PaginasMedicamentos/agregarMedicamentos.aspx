<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="agregarMedicamentos.aspx.cs" Inherits="ConsumeServicio.PaginasMedicamentos.agregarMedicamentos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <LINK REL=StyleSheet HREF="agregarMedicamentos.css" TYPE="text/css"/>
    <title>Agregar Medicamentos</title>
</head>
<body>
    <form id="form1" runat="server">
        <header id="main-header">
		
		<a id="logo-header" href="#">
			SISTEMA CONSULTA MEDICA <span class="site-desc">Programacion I</span>
		</a> <!-- / #logo-header -->

		<nav>
			<ul>
				<li><a href="https://localhost:44321/PaginasMedicamentos/menuMedicamentos.aspx">Menu Medicamentos</a></li>
				
			</ul>
		</nav><!-- / nav -->

	</header><!-- / #main-header -->

        <div>
			<div class ="titulo"><center><asp:Label ID="Label1" runat="server" Text="Agregar Medicamentos"></asp:Label></center>
            </div>
			<center>
				<div class="agregar">
					
					<asp:TextBox ID="id_medicamento" runat="server" placeholder="ID" required="required" Type="number"></asp:TextBox>
					<asp:TextBox ID="descripcion" runat="server" placeholder="Descripcion" required="required"></asp:TextBox>
					<asp:TextBox ID="precio" runat="server" placeholder="Precio" required="required"  Type="number" step="any"></asp:TextBox>
					<asp:TextBox ID="marca" runat="server" placeholder="Marca" required="required"></asp:TextBox>
					<asp:TextBox ID="cantidad" runat="server" placeholder="Cantidad" required="required" Type="number"></asp:TextBox>
					<asp:TextBox ID="dosis" runat="server" placeholder="Dosis" required="required"></asp:TextBox>
					<asp:TextBox ID="presentacion" runat="server" placeholder="Presentacion" required="required"></asp:TextBox>
					<asp:Button ID="agregar" class="botones btn" runat="server" Text="Agregar" Width="288px" OnClick="agregar_Click" />
					<asp:Label ID="salidaLabel" runat="server" Text=" " ForeColor="White"></asp:Label>
				
				</div>
		        
		</center>
        </div>
    </form>
</body>
</html>
