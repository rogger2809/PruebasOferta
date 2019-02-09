<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="Asignación_de_Demanda.Principal" %>

<asp:Content ID="ContentHeader" ContentPlaceHolderID="head" runat="server">

</asp:Content>

<asp:Content ID="ContentBody" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script src="JS/Generales.js"></script>

    <asp:ScriptManager id="ScriptManager1" runat="server">
    </asp:ScriptManager>

    <asp:UpdatePanel ID="UpdatePrincipal" runat="server">
        <ContentTemplate>
            <h2>Búsqueda ofertas</h2>
            <div class="row">             
                    <label>IdProducto</label>
                <br />
                    <asp:TextBox ID="txtIdProducto" runat="server" MaxLength="10" placeholder="Ingrese el id del producto" onkeypress="return ValidaNumeros(event)"></asp:TextBox>
            </div>

            <div class="row">
                <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
            </div>

            <div class="row">
                <asp:GridView ID="GridDemandaOferta" runat="server" AutoGenerateColumns="false" CssClass="table table-striped" 
                    Font-Size="Small" >
                    <Columns>
                        <asp:BoundField DataField="IdProducto" HeaderText="Idproducto" />
                        <asp:BoundField DataField="CantidadSolicitada" HeaderText="Cantidad solicitada" />
                        <asp:BoundField DataField="CantidadAsignada" HeaderText="Cantidad asignada" />
                        <asp:BoundField DataField="Residuo" HeaderText="Residuo" />
                        <asp:BoundField DataField="CantidadDisponible" HeaderText="Cantidad disponible" />
                        <asp:BoundField DataField="Lote" HeaderText="Lote" />
                    </Columns>
                </asp:GridView>
            </div>
            
        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>