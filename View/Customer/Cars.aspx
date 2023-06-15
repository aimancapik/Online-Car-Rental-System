<%@ Page Title="" Language="C#" MasterPageFile="~/View/Customer/CustomerMaster.Master" AutoEventWireup="true" CodeBehind="Cars.aspx.cs" Inherits="OnlineCarRent.View.Customer.Cars"%>

<asp:Content ID="Content2" ContentPlaceHolderID="mybody" runat="server">
  <div class="container-fluid">
    <div class="row justify-content-center">
      <div class="col-md-8">
        <div class="row">
          <div class="col-md-2">
            <asp:Label ID="CustName" runat="server"></asp:Label>
          </div>
        </div>
        <div class="row justify-content-center">
          <div class="text-center">
            <img src="../../Assets/Img/car.png" height="300"/>
          </div>
        </div>
        <div class="row justify-content-center">
          <div class="col-md-8">
            <div class="text-center">
              <h3><strong class="text-danger">AVAILABLE CARS</strong></h3>
            <asp:GridView runat="server" ID="CarList" Class="table table-hover" AutoGenerateSelectButton="True" PageSize="6" BackColor="White" BorderColor="Black" ForeColor="Black" OnSelectedIndexChanged="CarList_SelectedIndexChanged1">
                <AlternatingRowStyle BackColor="#FF9999" ForeColor="Black" BorderColor="Black" />
               <HeaderStyle BackColor="#FF9999"/>
            </asp:GridView>
            </div>
          </div>
        </div>
        <div class="row justify-content-center">
          <div class="col-md-4">
            <div class="form-group">
              <asp:Label runat="server">Date to rent</asp:Label>
              <input type="date" class="form-control" id="ReturnDate" runat="server" required="required"/>
            </div>
            <div class="form-group">
              <label id="InfoMsg" runat="server" class="text-danger"></label>
              <asp:Button type="submit" id="BookBtn" CssClass="btn tbn-danger btn-block" Text="Rent" runat="server" OnClick="BookBtn_Click" BackColor="#FF5050" />
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</asp:Content>