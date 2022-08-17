<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ImportExport.aspx.cs" Inherits="UI_WEB.ImportExport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-6">
            <div class="row my-3">
                <div class="col-2">
                    <asp:Label ID="Label1" runat="server" Text="Graficos" CssClass="form-text"></asp:Label>
                </div>
                <div class="col-4">
                    <asp:DropDownList ID="ddlGraficos" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlGraficos_SelectedIndexChanged" CssClass="form-control"></asp:DropDownList>
                </div>
                <div class="col-2">
                    <asp:Label ID="Label2" runat="server" Text="Colores" CssClass="form-text"></asp:Label>
                </div>
                <div class="col-4">
                    <asp:DropDownList ID="ddlColores" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlColores_SelectedIndexChanged" CssClass="form-control"></asp:DropDownList>
                </div>
            </div>
            <div class="row my-3">
                <div class="col-12">
                    <div class="row my-3">
                        <div class="col-3">
                            <asp:Label ID="Label3" runat="server" Text="Nombre" CssClass="form-text"></asp:Label>
                        </div>
                        <div class="col-9">
                            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row my-3">
                        <div class="col-3">
                            <asp:Label ID="Label4" runat="server" Text="Formato" CssClass="form-text"></asp:Label>
                        </div>
                        <div class="col-9">
                            <asp:DropDownList ID="ddlFormato" runat="server" CssClass="form-control"></asp:DropDownList>
                        </div>
                    </div>
                    <div class="row my-3">
                        <div class="col-12">
                            <asp:Button CssClass="btn btn-success" ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-6">
            <asp:Chart ID="Chart1" runat="server">
                <Series>
                    <asp:Series Name="Series1" Legend="Legend1"></asp:Series>
                </Series>
                <ChartAreas>
                    <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                </ChartAreas>
                <Legends>
                    <asp:Legend Name="Legend1">
                    </asp:Legend>
                </Legends>
            </asp:Chart>
        </div>
    </div>
</asp:Content>
