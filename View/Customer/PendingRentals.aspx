<%@ Page Title="" Language="C#" MasterPageFile="~/View/Customer/CustomerMaster.Master" AutoEventWireup="true" CodeBehind="PendingRentals.aspx.cs" Inherits="OnlineCarRent.View.Customer.PendingRentals" %>
<asp:Content ID="Content2" ContentPlaceHolderID="mybody" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col"></div>
            <div class="col"></div>
        </div>
            <div class="row">
                <div class="col">
                    <div class="text-center">
                      <h3><strong class="text-danger">YOUR CURRENT RENTALS</strong></h3>
                      <asp:GridView runat="server" ID="CarList" Class="table table-hover" BackColor="White" BorderColor="Black" ForeColor="Black">
                        <AlternatingRowStyle BackColor="#FF9999" ForeColor="Black" BorderColor="Black"/>
                      <HeaderStyle BackColor="#FF9999"/>
                      </asp:GridView>
                    </div>
                </div>
            </div>
    </div>
</asp:Content>