<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Voucher.aspx.cs" Inherits="Tp_Voucher.Voucher" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
            <div class="row">
        <div class="col-3"></div>
        <div class="col-6">

<h2 class="text-center display-4 font-weight-bold my-4">VOUCHER</h2>
            <hr>
  <div class="form-group">
     <asp:TextBox class="form-control w-50 mx-auto" id="codPromoNuevo" runat="server" placeholder="Ingresa tu código" OnClick="btnSiguiente_Click"></asp:TextBox>
  </div>
                  <asp:Button Class="btn btn-primary" ID="btnSiguiente" OnClick="btnSiguiente_Click" runat="server" Text="Siguiente"/>
                   <asp:Label ID="lbl1" runat="server" Text="Label"></asp:Label>
        </div>
        <div class="col-3"></div>

    </div>
</asp:Content>
