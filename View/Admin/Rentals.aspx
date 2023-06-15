<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Rentals.aspx.cs" Inherits="OnlineCarRent.View.Admin.Rentals" EnableEventValidation="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">

  <div class="container-fluid">
    <div class="row">
      <div class="col-md-4 p-3">
        <div class="text-center">
            <h3><strong class="text-danger">MANAGE RENTAL</strong></h3>
          <form runat="server">
            <div class="form-group">
              <asp:Label ID="ldelay" runat="server">Delay(Day)</asp:Label><br />
              <asp:TextBox ID="tbdelay" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
              <asp:Label ID="lfine" runat="server">Fine(RM)</asp:Label><br />
              <asp:TextBox ID="tbfine" runat="server"></asp:TextBox>
            </div>
            <asp:Label ID="errorMessage" runat="server"></asp:Label>
            <asp:Button ID="buttonSave" class="btn btn-primary" Text="SAVE" runat="server" OnClick="buttonSave_Click"/>
          </form>
        </div>
      </div>
      <div class="col-md-8 p-3">
        <div class="text-center">
            <h3><strong class="text-danger">RENTAL LIST</strong></h3>
            <asp:GridView runat="server" ID="rentallist" class="table table-hover" AutoGenerateSelectButton="True" BackColor="White" BorderColor="Black" ForeColor="Black">
                   <AlternatingRowStyle BackColor="#FF9999" ForeColor="Black" BorderColor="Black" />
                   <HeaderStyle BackColor="#FF9999"/>
            </asp:GridView>
        </div>
      </div>
    </div>
  </div>
</asp:Content>