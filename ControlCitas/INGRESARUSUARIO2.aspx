<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="INGRESARUSUARIO2.aspx.cs" Inherits="ControlCitas.INGRESARUSUARIO2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style1 {
            width: 100%;
        }
        .auto-style6 {
            text-align: center;
            font-size: xx-large;
            color: #0000CC;
        }
        .auto-style6 {
            text-align: justify;
        }
        .auto-style3 {
            width: 366px;
            text-align: right;
        }
        .auto-style4 {
            width: 366px;
            text-align: right;
            height: 26px;
        }
        .auto-style5 {
            height: 26px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style6" colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Mantenimiento de Usuarios</td>
        </tr>
        <tr>
            <td class="auto-style3">IdUsuario</td>
            <td>
                <asp:TextBox ID="txtIdUsuario" runat="server" ></asp:TextBox>
                <asp:Button ID="btnBuscar" runat="server"  Text="Buscar" OnClick="btnBuscar_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style4">User Name:</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Contraseña:</td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Rol:</td>
            <td>
                <asp:DropDownList ID="ddlRol" runat="server" Height="16px" >
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Activo</td>
            <td>
                <asp:CheckBox ID="CbEstado" runat="server" Text="Estado" />
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Button ID="btnInsertar" runat="server"  Text="Insertar" OnClick="btnInsertar_Click" />
            </td>
            <td>
                <asp:Button ID="btnModificar" runat="server"  Text="Modificar" OnClick="btnModificar_Click" />
                &nbsp;
                <asp:Button ID="BtnEliminar" runat="server"  Text="Eliminar" OnClick="BtnEliminar_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td>
                <asp:Label ID="lbMensaje" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
