<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="DOCTORES2.aspx.cs" Inherits="ControlCitas.DOCTORES2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: center;
            font-size: large;
            color: #0000FF;
            background-color: #66FFCC;
        }
        .auto-style3 {
            text-align: right;
        }
        .auto-style4 {
            text-align: left;
        }
        .auto-style5 {
            text-align: justify;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2" colspan="2">
                <h1>Doctor</h1>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Id doctor:</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtIdDoc" runat="server" OnTextChanged="txtIdDoc_TextChanged"></asp:TextBox>
                <asp:Button ID="btnDuscarDoc" runat="server" Text="Buscar" OnClick="btnDuscarDoc_Click"/>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Nombres:</td>
            <td class="auto-style4">
                <asp:TextBox ID="txtNombreDoc" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Apellidos:</td>
            <td class="auto-style4">
                <asp:TextBox ID="txtApellidoDoc" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Telfono o celular:</td>
            <td class="auto-style4">
                <asp:TextBox ID="txtTelCelDOC" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Email:</td>
            <td class="auto-style4">
                <asp:TextBox ID="txtEmailDoc" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">IdEspecialidad</td>
            <td class="auto-style4">
                <asp:DropDownList ID="DropDownREspecialidad" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Id Usuario</td>
            <td class="auto-style4">
                <asp:DropDownList ID="DropDownRUsuario" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Button ID="btnGuardarDoc" runat="server" Text="Guardar" OnClick="btnGuardarDoc_Click" />
            </td>
            <td class="auto-style4">
                <asp:Button ID="btnEliminarDoc" runat="server" Text="Eliminar" OnClick="btnEliminarDoc_Click" />
                <asp:Button ID="btnActualizarDoc" runat="server" Text="Actualizar" OnClick="btnActualizarDoc_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                &nbsp;</td>
            <td class="auto-style4">
                <asp:Label ID="lblMensaje" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
