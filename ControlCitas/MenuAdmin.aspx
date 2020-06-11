<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MenuAdmin.aspx.cs" Inherits="ControlCitas.MenuAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
   <body>
        <div id="carouselExampleFade" class="carousel slide carousel-fade" data-ride="carousel">
            <div class="carousel-inner">
                <div class="carousel-item active">
                    <img src="Imagenes/doc.jpg" class="d-block w-100" alt="...">
                </div>
                <div class="carousel-item">
                    <img src="Imagenes/medicalpurple.jpg" class="d-block w-100" alt="...">
                </div>
                <div class="carousel-item">
                    <img src="Imagenes/ini.jpg" class="d-block w-100" alt="...">
                </div>
            </div>
            <a class="carousel-control-prev" href="#carouselExampleFade" role="button" data-slide="prev">
                <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                <span class="sr-only">Previous</span>
            </a>
            <a class="carousel-control-next" href="#carouselExampleFade" role="button" data-slide="next">
                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                <span class="sr-only">Next</span>
            </a>

        </div>
    </body>         
 
    <script src="Scripts/jquery-3.5.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</asp:Content>
