<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="agegarEnfermedades.aspx.cs" Inherits="ConsumeServicio.PaginasEnfermedades.agegarEnfermedades" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <LINK REL=StyleSheet HREF="agegarEnfermedades.css" TYPE="text/css"/>
    <title>Agregar Enfermedades</title>
</head>
<body>
    <form id="form1" runat="server">
         <header id="main-header">
		
		<a id="logo-header" href="#">
			SISTEMA CONSULTA MEDICA <span class="site-desc">Programacion I</span>
		</a> <!-- / #logo-header -->

		<nav>
			<ul>
				<li><a href="https://localhost:44321/PaginasEnfermedades/menuEnfermedades.aspx">Menu Enfermedades</a></li>
				
			</ul>
		</nav><!-- / nav -->

	</header><!-- / #main-header -->

        <div>
			<div class ="titulo"><center><asp:Label ID="Label1" runat="server" Text="Agregar Enfermedades"></asp:Label></center>
            </div>
			<center>
				<div class="agregar">
					
					<asp:TextBox ID="id_enfermedad" runat="server" placeholder="ID" required="required" Type="number"></asp:TextBox>
					<asp:TextBox ID="nombre_enfermedad" runat="server" placeholder="Nombre Enfermedad" required="required"></asp:TextBox>
					<asp:TextBox ID="tipo_enfermedad" runat="server" placeholder="Tipo Enfermedad" required="required"  ></asp:TextBox>
					<asp:TextBox ID="nivel_contagio" runat="server" placeholder="Nivel Contagio" required="required"></asp:TextBox>
					<asp:Button ID="agregar" class="botones btn" runat="server" Text="Agregar" Width="288px" OnClick="agregar_Click" />
					<asp:Label ID="salidaLabel" runat="server" Text=" " ForeColor="White"></asp:Label>
				
				</div>
		        
		</center>
        </div>
    </form>
</body>
</html>
