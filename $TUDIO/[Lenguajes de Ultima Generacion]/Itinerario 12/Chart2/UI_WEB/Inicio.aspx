<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="UI_WEB.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row my-3">
        <div class="col-2">
            <asp:Button ID="btnArrays" runat="server" Text="Arrays" CssClass="btn btn-success inicio" OnClick="btnArrays_Click" />
        </div>
        <div class="col-2">
            <asp:Button ID="btnDataView" runat="server" Text="Data View" CssClass="btn btn-success inicio" OnClick="btnDataView_Click" />
        </div>
        <div class="col-2">
            <asp:Button ID="btnTabla" runat="server" Text="Tabla" CssClass="btn btn-success inicio" OnClick="btnTabla_Click" />
        </div>
       <div class="col-2">
            <asp:Button ID="btnLista" runat="server" Text="Lista" CssClass="btn btn-success inicio" OnClick="btnLista_Click" />
        </div>
        <div class="col-2">
            <asp:Button ID="btnXML" runat="server" Text="XML" CssClass="btn btn-success inicio" OnClick="btnXML_Click" />
        </div>
        
        <div class="col-2">
            <asp:Button ID="btnImportExport" runat="server" Text="Import Export " CssClass="btn btn-success inicio" OnClick="btnImportExport_Click" />
        </div>
    </div>
</asp:Content>
