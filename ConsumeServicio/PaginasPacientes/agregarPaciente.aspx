<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="agregarPaciente.aspx.cs" Inherits="ConsumeServicio.PaginasPacientes.agregarPaciente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <LINK REL=StyleSheet HREF="agregarPaciente.css" TYPE="text/css"/>
    <title>Agregar Paciente</title>
</head>
<body>
    <form id="form1" runat="server">
        <header id="main-header">
		
		<a id="logo-header" href="#">
			SISTEMA CONSULTA MEDICA <span class="site-desc">Programacion I</span>
		</a> <!-- / #logo-header -->

		<nav>
			<ul>
				<li><a href="https://localhost:44321/PaginasPacientes/menuPaciente.aspx">Pacientes</a></li>
				
			</ul>
		</nav><!-- / nav -->

	</header><!-- / #main-header -->

        <div>
			<div class ="titulo"><center><asp:Label ID="Label1" runat="server" Text="Agregar Paciente"></asp:Label></center>
            </div>
			<center>
				<div class="agregar">
					
					<asp:TextBox ID="id_paciente" runat="server" placeholder="ID paciente" required="required" type="number"></asp:TextBox>
					<asp:TextBox ID="nombre_paciente" runat="server" placeholder="Nombre" required="required"></asp:TextBox>
					<asp:TextBox ID="apellido_paciente" runat="server" placeholder="Apellido" required="required"></asp:TextBox>
					<asp:TextBox ID="familiar_responsable" runat="server" placeholder="familiar responsable" required="required"></asp:TextBox>
					<asp:TextBox ID="fecha_nac" runat="server" placeholder="Fecha nacimiento" required="required"  type="date"></asp:TextBox>
					<asp:TextBox ID="tipo_sangre" runat="server" placeholder="Tipo sangre" required="required"></asp:TextBox>
					<asp:TextBox ID="enferm_preexitente" runat="server" placeholder="Enfermedad preexitente" required="required"></asp:TextBox>
					<asp:TextBox ID="dpi" runat="server" placeholder="DPI" required="required" type="number"></asp:TextBox>
					<asp:TextBox ID="nit" runat="server" placeholder="Nit" required="required" type="number"></asp:TextBox>
					<asp:TextBox ID="direccion" runat="server" placeholder="Dirección" required="required"></asp:TextBox>
					<asp:TextBox ID="correo" runat="server" placeholder="E-mail" required="required"></asp:TextBox>
					<asp:TextBox ID="no_telelefono" runat="server" placeholder="Número de Telefono" required="required" type="number" Width="120px"></asp:TextBox>
					<asp:Button ID="agregar" class="botones btn" runat="server" Text="Agregar" Width="288px" OnClick="agregar_Click" />
					<asp:Label ID="salidaLabel" runat="server" Text=" " ForeColor="White"></asp:Label>
				
				</div>
		        
		</center>
        </div>
    </form>
</body>
</html>
