<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="My_Portfolio.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <title>Login Page</title>
    <link rel="stylesheet" href="~/EXTENSION/login_styles.css"/>
</head>
<body>
    <form id="form1" runat="server">
              <div class="login-container">
                <h2>Login</h2>
                <form action="#">
                    <div class="input-group">
                        <label for="username">Username:</label>
                        <asp:TextBox ID="Username" runat="server"></asp:TextBox>
                       
                    </div>
                    <div class="input-group">
                        <label for="password">Password:</label>
                        <asp:TextBox ID="Password" runat="server"></asp:TextBox>
                        
                    </div>
                   
                        <asp:Button ID="LoginButton" runat="server" OnClick="Login_button" Text="LOGIN" CssClass="btn" />
                   
                </form>
            </div>
   
       
    </form>
</body>
</html>
