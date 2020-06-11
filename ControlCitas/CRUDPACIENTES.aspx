<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="CRUDPACIENTES.aspx.cs" Inherits="ControlCitas.CRUDPACIENTES" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: center;
            color: #000099;
            background-color: #33CCFF;
        }
        .auto-style4 {
            text-align: right;
        }
        .auto-style5 {
            text-align: left;
        }
        .auto-style6 {
            text-align: right;
            height: 30px;
        }
        .auto-style7 {
            text-align: left;
            height: 30px;
        }
        .auto-style8 {
            text-align: right;
            height: 29px;
        }
        .auto-style9 {
            text-align: left;
            height: 29px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2" colspan="2">
                <h1>Paciente</h1>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Id del Paciente</td>
            <td class="auto-style7">
                <asp:TextBox ID="txtIdPaciente" runat="server"></asp:TextBox>
                <asp:Button ID="btnBuscarPaciente" runat="server" Text="Buscar" OnClick="btnBuscarPaciente_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Nombres:</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtNombrePaciente" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Apellidos:</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtApellidosPaciente" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">Direccion:</td>
            <td class="auto-style9">
                <asp:TextBox ID="txtDirecPaciente" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Telefono/Celular:</td>
            <td class="auto-style5">
                <asp:TextBox ID="txttexlPaciente" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Email:</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtEmailPaciente" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Fecha de nacimiento</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtFechaNaciPaciente" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">DUI: </td>
            <td class="auto-style9">
                <asp:TextBox ID="txtDUIPaciente0" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
            </td>
            <td class="auto-style5">
                <asp:Button ID="btnEliminarPaciente" runat="server" Text="Eliminar" OnClick="btnEliminarPaciente_Click" />
                <asp:Button ID="btnActualizarPacienet" runat="server" Text="Actualizar" OnClick="btnActualizarPacienet_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                &nbsp;</td>
            <td class="auto-style5">
                <asp:Label ID="lblMensaje" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
