<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registrosMedicos.aspx.cs" Inherits="ConsumeServicio.PaginasMedicas.registrosMedicos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="StyleSheet" href="registrosMedicos.css" type="text/css"/>
    <title></title>
</head>
<body>
    <header id="main-header">
		
		<a id="logo-header" href="#">
			SISTEMA CONSULTA MEDICA <span class="site-desc">Programacion I</span>
		</a> <!-- / #logo-header -->

		<nav>
			<ul>
				<li><a href="https://localhost:44321/PaginasUsuario/menuUsuario.aspx">Usuarios</a></li>
				<li><a href="https://localhost:44321/PaginasClinica/menuClinica.aspx">Clinicas</a></li>
				<li><a href="https://localhost:44321/PaginasEmpleados/menuEmpleado.aspx">Empleados</a></li>
                <li><a href="https://localhost:44321/PaginasPacientes/menuPaciente.aspx">Pacientes</a></li>
                <li><a href="https://localhost:44321/PaginasMedicamentos/menuMedicamentos.aspx">Medicamentos</a></li>
                <li><a href="https://localhost:44321/PaginasEnfermedades/menuEnfermedades.aspx">Enfermedad</a></li>
                <li><a href="https://localhost:44321/PaginasMedicas/registrosMedicos.aspx">Registros Medicos</a></li>
                <li><a href="https://localhost:44321/PaginasReportes/reporte.aspx">Reportería</a></li>
			</ul>
		</nav><!-- / nav -->

	</header><!-- / #main-header -->
    <form id="form1" runat="server">
        <div id="uno">
            <center>
                <asp:Label class="titulo" runat="server" Text="Citas"></asp:Label>
                <div class="agregar">
					<asp:TextBox ID="id_cita" runat="server" placeholder="Número Cita"  type="number"></asp:TextBox>
					<asp:Label class="subtitulo" runat="server" Text="Paciente"></asp:Label>
					<asp:DropDownList Class="clinica" ID="id_paciente" runat="server" Height="54px" style="margin-left: 0px" Width="300px" margin-bottom="10px">
                    </asp:DropDownList>
					<asp:Label class="subtitulo" runat="server" Text="Clinica"></asp:Label>
					<asp:DropDownList Class="clinica" ID="id_clinica" runat="server" Height="54px" style="margin-left: 0px" Width="300px" margin-bottom="10px">
                    </asp:DropDownList>
					<asp:Label class="subtitulo" runat="server" Text="Usuario que agenda"></asp:Label>
					<asp:DropDownList Class="clinica" ID="usuario_creador" runat="server" Height="54px" style="margin-left: 0px" Width="300px" margin-bottom="10px">
                    </asp:DropDownList>
					<asp:Label class="subtitulo" runat="server" Text="Fecha de cita"></asp:Label>
					<asp:TextBox ID="fecha" runat="server" placeholder="Fecha de Cita"  Type="datetime-local"></asp:TextBox>
					<asp:TextBox ID="costo" runat="server" placeholder="Costo" type="number" step="any" ></asp:TextBox>
					<asp:TextBox ID="no_consultorio" runat="server" placeholder="Numero de Consultorio"  type="number" ></asp:TextBox>
					<asp:TextBox ID="forma_pago" runat="server" placeholder="Forma de Pago"  ></asp:TextBox>
					<asp:Button ID="agregar" class="botones btn" runat="server" Text="Agendar Cita" Width="288px" OnClick="agregar_Click" />
					<asp:Label ID="salidaLabel" runat="server" Text=" " ForeColor="White"></asp:Label>
				
				</div>
            </center>
        </div>
        <div id="dos">
            <center>
            <asp:Label class="titulo" runat="server" Text="Consultas"></asp:Label>
				<div class="agregar">
					<asp:TextBox ID="id_reg_consul" runat="server" placeholder="Id a Buscar"  type="number"></asp:TextBox>

					<asp:Button ID="Button2" class="botones btn" runat="server" Text="Buscar Cita" Width="288px" OnClick="Button2_Click"  />
					
					<asp:Label class="subtitulo" runat="server" Text="Paciente"></asp:Label>
					<asp:DropDownList Class="clinica" ID="id_paciente2" runat="server" Height="54px" style="margin-left: 0px" Width="300px" margin-bottom="10px">
                    </asp:DropDownList>

					<asp:Label class="subtitulo" runat="server" Text="Fecha de Consulta"></asp:Label>
					<asp:TextBox ID="fecha_creacion" runat="server" placeholder="Fecha de Consulta"  Type="datetime-local"></asp:TextBox>
					
					<asp:Label class="subtitulo" runat="server" Text="Usuario que agendo la cita"></asp:Label>
					<asp:DropDownList Class="clinica" ID="usuario_creador2" runat="server" Height="54px" style="margin-left: 0px" Width="300px" margin-bottom="10px">
                    </asp:DropDownList>

					<asp:TextBox ID="medico" runat="server" placeholder="Nombre Medico" ></asp:TextBox>

					<asp:Label class="subtitulo" runat="server" Text="diagnostico"></asp:Label>
					<asp:DropDownList Class="clinica" ID="diagnostico" runat="server" Height="54px" style="margin-left: 0px" Width="300px" margin-bottom="10px">
                    </asp:DropDownList>

					<asp:Label class="subtitulo" runat="server" Text="medicamentos"></asp:Label>
					<asp:DropDownList Class="clinica" ID="medicamentos" runat="server" Height="54px" style="margin-left: 0px" Width="300px" margin-bottom="10px">
                    </asp:DropDownList>


					<asp:TextBox ID="estudios" runat="server" placeholder="Estudios/ Observaciones" ></asp:TextBox>
					
					<asp:Button ID="Button1" class="botones btn" runat="server" Text="Terminar Consulta" Width="288px" OnClick="Button1_Click" />
					<asp:Label ID="Label1" runat="server" Text=" " ForeColor="White"></asp:Label>
				
				</div>
            </center>
        </div>
    </form>
</body>
</html>
