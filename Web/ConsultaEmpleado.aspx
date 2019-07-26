<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultaEmpleado.aspx.cs" Inherits="Web.ConsultaEmpleado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td>
                <asp:TextBox ID="txtCedula" runat="server"></asp:TextBox>
                <asp:Label ID="lblNombre" runat="server" Text="Label"></asp:Label>
                <asp:Label ID="lblCargo" runat="server" Text="Label"></asp:Label>
                <asp:Button ID="btnConsultar" runat="server" Text="Button" OnClick="btnConsultar_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtDepartamento" runat="server"></asp:TextBox>
                
                <asp:Button ID="btnDepartamento" runat="server" Text="Button" OnClick="btnDepartamento_Click" />
                <asp:GridView ID="gvDatos" runat="server"></asp:GridView>
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
