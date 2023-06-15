<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Cars.aspx.cs" Inherits="OnlineCarRent.View.Admin.Cars" enableEventValidation="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">

  <div class="container-fluid">
    <div class="row justify-content-center">
      <div class="col-md-4 p-3 text-center">
          <form runat="server">
            <h3><strong class="text-danger">MANAGE CAR</strong></h3>
            <div class="form-group">
                            <asp:Label ID="llicenceNum" runat="server">Licence Number</asp:Label><br />
                            <asp:TextBox ID="tblicenceNum" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="brandName" runat="server">Brand</asp:Label><br />
                            <asp:TextBox ID="tbbrandName" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lmodel" runat="server">Model</asp:Label><br />
                            <asp:TextBox ID="tbmodel" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="Price" runat="server">Price</asp:Label><br />
                            <asp:TextBox ID="tbPrice" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lcolor" runat="server">Color</asp:Label><br />
                            <asp:TextBox ID="tbcolor" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lAvailability" runat="server">Availability</asp:Label>
                            <asp:DropDownList ID= "DDAvailability" runat="server">
                                <asp:ListItem>Available</asp:ListItem>
                                <asp:ListItem>Booked</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <asp:Label ID="errorMessage" runat="server"></asp:Label><br />
            <asp:Button type="submit" ID="buttonEdit" class="btn btn-primary" Text="EDIT" runat="server" OnClick="buttonEdit_Click" BackColor="#FF5050"/>
            <asp:Button type="submit" ID="buttonAdd" class="btn btn-primary" Text="ADD" runat="server" OnClick="buttonAdd_Click" BackColor="#FF5050"/>
            <asp:Button type="submit" ID="buttonDelete" class="btn btn-primary" Text="DELETE" runat="server" OnClick="buttonDelete_Click" BackColor="#FF5050"/>
          </form>
        </div>
      <div class="col-md-8 p-3">
        <div class="text-center">
          <h3><strong class="text-danger">CAR LIST</strong></h3>
          <asp:GridView runat="server" ID="carlist" class="table table-hover" AutoGenerateSelectButton="True" OnSelectedIndexChanged="carlist_SelectedIndexChanged" BackColor="White" BorderColor="Black" ForeColor="Black">
            <AlternatingRowStyle BackColor="#FF9999" ForeColor="Black" BorderColor="Black"/>
              <HeaderStyle BackColor="#FF9999"/>
          </asp:GridView>
        </div>
      </div>
    </div>
  </div>
</asp:Content>