<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SignUp.aspx.cs" Inherits="OnlineCarRent.View.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../Assets/Libraries/css/bootstrap.min.css" />
    <style>
    .form-outline {
      border: 1px solid black;
      padding: 15px;
      border-radius: 3px;
      width: 50%;
      margin-top: 100px;
      margin-left:400px;
    }
    </style>
</head>
<body>
    <div class="container-fluid">
        <div class="row">
            <div class="form-outline">
            <div class="col">
                <div class="text-center">
                    <h3><strong class="text-danger">SIGN UP PAGE</strong></h3>
                    <img src="../Assets/Img/logo.jpg" height="170"/>
                </div>
                <br />
                <form runat="server">
                    <div class="form-group">
                        <asp:Label ID="label1" runat="server">Username</asp:Label> 
                        <asp:TextBox ID="tblName" placeholder="Enter Username" class="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="laddress" runat="server">Address</asp:Label>
                        <asp:TextBox ID="tbaddress" placeholder="Enter Address" class="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lphoneNumber" runat="server">Phone Number</asp:Label>
                        <asp:TextBox ID="tbphoneNumber" placeholder="Enter Phone Number" class="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lpassword" runat="server">Password</asp:Label>
                        <asp:TextBox ID="tbPassword" class="form-control" placeholder="Enter Password" runat="server"></asp:TextBox>
                    </div>
                    <asp:Label ID="errorMessage" runat="server"></asp:Label>
                    <asp:Button type="submit" ID="buttonSubmit" class="btn btn-danger btn-block mt-3" Text="SUBMIT" runat="server" OnClick="buttonSubmit_Click"/>
                    <div class="text-center mt-3">
                        Already have account? <a class="text-danger" href="Login.aspx"> Login</a>
                    </div>
                </form>
            </div>
        </div>
    </div>
    </div>
</body>
</html>