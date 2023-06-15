<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="OnlineCarRent.View.Admin.Customer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col"></div>
            <div class="col">
                <div class="text-center">
                <h3><strong class="text-danger">CUSTOMER LIST</strong></h3>
                </div>
            </div>
            <div class="col"></div>
            </div>
            <div class="row">
            <div class="col">
                <div class="text-center">
                    <asp:GridView runat="server" ID="customerlist" class="table table-hover" BackColor="White" BorderColor="Black" ForeColor="Black">
                        <AlternatingRowStyle BackColor="#FF9999" ForeColor="Black" BorderColor="Black" />
                          <HeaderStyle BackColor="#FF9999"  />
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>