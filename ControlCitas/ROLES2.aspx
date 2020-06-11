<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="ROLES2.aspx.cs" Inherits="ControlCitas.ROLES2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: center;
            font-size: large;
            color: #0000FF;
            background-color: #99FF66;
        }
        .auto-style3 {
            text-align: left;
        }
        .auto-style4 {
            text-align: right;
            width: 354px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table class="auto-style1">
        <tr>
            <td class="auto-style2" colspan="2">
                <h1>Roles</h1>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;IdRol:</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtIdRol" runat="server"></asp:TextBox>
                <asp:Button ID="Buscar" runat="server" Text="Buscar" OnClick="Buscar_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Nombre del Rol:</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtNombreRoles" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
            </td>
            <td class="auto-style3">
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click"  />
                <asp:Button ID="btnActualizarRol" runat="server" Text="Actualizar" OnClick="btnActualizarRol_Click"  />
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                &nbsp;</td>
            <td class="auto-style3">
                <asp:Label ID="lblMensaje" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
