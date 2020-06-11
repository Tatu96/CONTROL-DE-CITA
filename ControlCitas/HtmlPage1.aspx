<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HtmlPage1.aspx.cs" Inherits="bootstrapwebform.HtmlPage1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />

    <!-- CSS only -->
    <link href="CSS/estilo.css" rel="stylesheet" />
    <%--<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css"/>--%>
</head>
<body>

    <div class="container well contenedor" >
        <div class="row">
            <div class="col-xs-12 espa">
                <h2>Iniciar sesion </h2>
            </div>
        </div>
        <form id="form1" runat="server" class="form-horizontal">
            <div class="form-group">
                <asp:Label ID="lblusuario" runat="server" Text="Usuario" CssClass="control-label col-sm-2"></asp:Label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <asp:Label ID="lblcontra" runat="server" Text="Contraseña" CssClass="control-label col-sm-2"></asp:Label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txtContrasena" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <asp:Button ID="btnIniciar" runat="server" Text="Iniciar" CssClass="form-control btn btn-primary" OnClick="btnIniciar_Click" />
                <asp:Label ID="TxtMensaje" runat="server"></asp:Label>
            </div>

        </form>
    </div>
    <script src="Scripts/jquery-3.5.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
