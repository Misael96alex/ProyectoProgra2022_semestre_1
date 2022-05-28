<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reporte.aspx.cs" Inherits="ConsumeServicio.PaginasReportes.reporte" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="StyleSheet" href="reporte.css" type="text/css"/>
    <title>Reportes</title>
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
      <div>
			<div class ="titulo"><center><asp:Label ID="Label1" runat="server" Text="Buscar Paciente"></asp:Label></center>
            </div>
			<center>
			<div class="agregar">
				
				<asp:TextBox ID="nombreBuscar" runat="server" placeholder="Nombre a buscar" required="required" ></asp:TextBox>
				<asp:Button ID="verificar" class="botones btn" runat="server" Text="Buscar Paciente" Width="288px" OnClick="verificar_Click"  />
			    
			</div>
				<asp:GridView ID="GridView1" runat="server" CellPadding="4" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px">
                    <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                    <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                    <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                    <RowStyle BackColor="White" ForeColor="#003399" />
                    <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                    <SortedAscendingCellStyle BackColor="#EDF6F6" />
                    <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                    <SortedDescendingCellStyle BackColor="#D6DFDF" />
                    <SortedDescendingHeaderStyle BackColor="#002876" />
                </asp:GridView>
				<br />
                <div class ="titulo"><center><asp:Label ID="Label2" runat="server" Text="Citas Agendadas"></asp:Label></center>
            </div>
                <asp:GridView ID="GridView2" runat="server" CellPadding="4" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px">
                    <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                    <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                    <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                    <RowStyle BackColor="White" ForeColor="#003399" />
                    <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                    <SortedAscendingCellStyle BackColor="#EDF6F6" />
                    <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                    <SortedDescendingCellStyle BackColor="#D6DFDF" />
                    <SortedDescendingHeaderStyle BackColor="#002876" />
                </asp:GridView>
			</center>
        </div>
    </form>
</body>
</html>
