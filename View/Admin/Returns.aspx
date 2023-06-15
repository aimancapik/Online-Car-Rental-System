<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Returns.aspx.cs" Inherits="OnlineCarRent.View.Admin.Returns" EnableEventValidation="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
  <div class="container-fluid">
    <div class="row justify-content-center">
      <div class="col-md-4 p-3">
        <form runat="server">
          <div class="text-center">
              <h3><strong class="text-danger">RETURN LIST</strong></h3>
            <asp:GridView runat="server" ID="returnlist" class="table table-hover" BackColor="White" BorderColor="Black" ForeColor="Black">
                <AlternatingRowStyle BackColor="#FF9999" ForeColor="Black" BorderColor="Black" />
               <HeaderStyle BackColor="#FF9999"/>
            </asp:GridView>
          </div>
        </form>
      </div>
    </div>
  </div>
</asp:Content>