<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menuUsuario.aspx.cs" Inherits="ConsumeServicio.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <LINK REL=StyleSheet HREF="menuUsuario.css" TYPE="text/css">
    <title>Mi pagina</title>
</head>
<body>
    <form id="form1" runat="server">
        <header id="main-header">
		
		<a id="logo-header" href="#">
			SISTEMA CONSULTA MEDICA <span class="site-desc">Programacion I</span>
		</a> <!-- / #logo-header -->

		<nav>
			<ul>
				<li><a href="#">Usuarios</a></li>
				<li><a href="#">Clinicas</a></li>
				<li><a href="#">Medicamentos</a></li>
                <li><a href="#">Enfermedades</a></li>
			</ul>
		</nav><!-- / nav -->

	</header><!-- / #main-header -->

        <div>
            <div class ="titulo"><h1><center><asp:Label ID="Label1" runat="server" Text="Menú Usuarios"></asp:Label></center></h1><br /></div>
            <center><asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="422px">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView></center>
        </div>
    </form>
</body>
</html>
