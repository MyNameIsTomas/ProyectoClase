<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Practica.aspx.cs" Inherits="Practica" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    	<asp:ListBox ID="ListBox1" runat="server" Height="221px" Width="134px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"></asp:ListBox>
		<br />
		<asp:Label ID="Label1" runat="server" Text="Minima"></asp:Label>
		<asp:TextBox ID="txtMinima" runat="server"></asp:TextBox>
		<br />
		<asp:Label ID="Label2" runat="server" Text="Media"></asp:Label>
		<asp:TextBox ID="txtMedia" runat="server"></asp:TextBox>
		<br />
		<asp:Label ID="Label3" runat="server" Text="Maxima"></asp:Label>
		<asp:TextBox ID="txtMaxima" runat="server"></asp:TextBox>
		<br />
		<asp:Button ID="Button1" runat="server" Text="Generar" Width="170px" OnClick="Button1_Click" />
    </form>
</body>
</html>
