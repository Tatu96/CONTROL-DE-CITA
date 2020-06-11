<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="CITA.aspx.cs" Inherits="ControlCitas.CITA" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style type="text/css">
         .auto-style4 {
             width: 751px
         }
         .auto-style5 {
             height: 26px;
             width: 376px;
         }
         .auto-style6 {
             width: 376px;
         }
         .auto-style7 {
             height: 26px;
             width: 375px;
         }
         .auto-style8 {
             width: 375px;
         }
         .auto-style9 {
             text-align: center;
             height: 30px;
         }
         .auto-style10 {
             height: 26px;
             width: 393px;
         }
         .auto-style11 {
             width: 393px;
         }
         .auto-style12 {
             height: 18px;
             width: 375px;
         }
         .auto-style13 {
             width: 393px;
             height: 18px;
         }
         .auto-style14 {
             width: 376px;
             height: 18px;
         }
         .auto-style15 {
             height: 26px;
             width: 489px;
         }
         .auto-style16 {
             height: 18px;
             width: 489px;
         }
         .auto-style17 {
             width: 489px;
         }
     </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class="auto-style4">
        <tr>
            <td class="auto-style9" colspan="5">
                <h2><strong>FORMULARIO SOLICITUD DE CITAS</strong></h2>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Numero de Cita:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
            <td class="auto-style15">
                <asp:TextBox ID="txtIdCITA" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style7">
                &nbsp;</td>
            <td class="auto-style10">Nombre: </td>
            <td class="auto-style5">
                <asp:TextBox ID="txtNombrePaciente" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Dia de la cita:</td>
            <td class="auto-style15">
                <asp:TextBox ID="txtCalendario" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style7">
                &nbsp;</td>
            <td class="auto-style10">Apellido:</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtApellidosPaciente" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style12">Hora de la Cita:</td>
            <td class="auto-style16">
                <asp:TextBox ID="txtHoraCita" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style12">
            </td>
            <td class="auto-style10">Direccion:</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtDireccionPaciente" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Nombre del Doctor/a:&nbsp;&nbsp; </td>
            <td class="auto-style15">
                <asp:DropDownList ID="DropDownNombreDoc" runat="server">
                </asp:DropDownList>
            </td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style13">celular/Telefono:</td>
            <td class="auto-style14">
                <asp:TextBox ID="txttexlPaciente" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Id Paciente:</td>
            <td class="auto-style15">
                <asp:TextBox ID="txtIdPaciente0" runat="server"></asp:TextBox>
                </td>
            <td class="auto-style7">
                <asp:Button ID="btnBuscarPaciente0" runat="server" Text="Buscar Paciente" OnClick="btnBuscarPaciente_Click" />
            </td>
            <td class="auto-style10">email:</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtEmailPaciente" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Button ID="bntGuardar" runat="server" Text="Guardar" OnClick="bntGuardar_Click" />
            </td>
            <td class="auto-style15">
                <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" />
                <asp:Button ID="bntEliminar" runat="server" Text="Eliminar" OnClick="bntEliminar_Click" />
            </td>
            <td class="auto-style7">
                <asp:Button ID="bntBuscarCita" runat="server" Text="Buscar Cita" OnClick="bntBuscarCita_Click" />
            </td>
            <td class="auto-style10">Fecha de nacimiento</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtNacimiento" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style17">
                <asp:Label ID="lblMensaje" runat="server"></asp:Label>
            </td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style10">DUI:</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtDUIPaciente0" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style8" colspan="2">&nbsp;</td>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style8" colspan="2">&nbsp;</td>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
        </tr>
    </table>

</asp:Content>
