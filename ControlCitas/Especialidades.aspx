<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Especialidades.aspx.cs" Inherits="ControlCitas.Especialidades" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            color: #0000FF;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td class="text-center" colspan="2">
                <h1 class="auto-style1">Especialidades</h1>
            </td>
        </tr>
        <tr>
            <td class="text-center">id especialidad</td>
            <td class="text-left">
                <asp:TextBox ID="txtIdespecialidad" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-center">nombre de la especialidad</td>
            <td class="text-left">
                <asp:TextBox ID="txtNombreEspecialidad" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-center">&nbsp;</td>
            <td class="text-left">
                <asp:Button ID="Button1" runat="server" Text="Guardar" />
                <asp:Button ID="Button2" runat="server" Text="Eliminar" />
                <asp:Button ID="Button3" runat="server" Text="Buscar" />
            </td>
        </tr>
        <tr>
            <td class="text-center">&nbsp;</td>
            <td class="text-left">
                <asp:Label ID="lblMensaje" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
