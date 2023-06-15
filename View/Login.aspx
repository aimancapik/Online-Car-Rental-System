<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="OnlineCarRent.View.Login" %>


<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../Assets/Libraries/css/bootstrap.min.css" />
    <style>
    .form-outline {
      border: 1px solid black;
      padding: 15px;
      border-radius: 10px;
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
                <h3><strong class="text-danger">LOGIN PAGE</strong></h3>
                <img src="../Assets/Img/logo.jpg" height="170"/>
            </div>
        <form runat="server">
          <div class="form-group" runat="server">
            <asp:Label id="label1" runat="server" Text="Username"></asp:Label>
            <input type="text" class="form-control" id="UserNameTb" placeholder="Enter Username" runat="server" required="required"/>
          </div>
          <div class="form-group">
            <asp:Label id="label2" runat="server" Text="Password"></asp:Label>
            <input type="password" class="form-control" id="PasswordTb" placeholder="Enter Password" runat="server" required="required"/>
          </div>
          <div class="form-group">
            &nbsp;&nbsp;&nbsp;&nbsp;<input type="radio" class="form-check-input" id="CustomerRadio" name="Role" runat="server"/>
            <label class="form-check-label" for="exampleCheck1">Customer</label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<input type="radio" class="form-check-input" id="AdminRadio" name="Role" runat="server"/>
            <label class="form-check-label" for="exampleCheck1">Admin</label>
          </div> 
          <div class="form-group d-grid">
            <label id="InfoMsg" runat="server" class="text-danger"></label>
            <asp:Button type="submit" id="SaveBtn" class="btn btn-danger btn-block" Text="Login" runat="server" OnClick="SaveBtn_Click"/>
          </div>
          <div class="col">Dont have an account? <a class="text-danger" href="SignUp.aspx"> Sign Up</a></div>
        </form>
      </div>
    </div>
  </div>
</div>
</body>
</html>