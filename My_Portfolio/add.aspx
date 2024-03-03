<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="add.aspx.cs" Inherits="My_Portfolio.add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

        <asp:Label ID="Add" runat="server" Text="ADD"></asp:Label><br />
         <h3>Name :</h3>
        <asp:TextBox ID="Project_Name" runat="server"></asp:TextBox><br />

        <h3>Description : </h3>
        <textarea name="" id="Project_description" runat="server" cols="30" rows="10" placeholder="" required ></textarea><br /><br />
       
        <h3>Image_Url :</h3>
        <asp:TextBox ID="Project_image_url" runat="server"></asp:TextBox><br /><br />

        <h3>Github_Url :</h3>
        <asp:TextBox ID="Project_github_url" runat="server"></asp:TextBox><br /><br />

        <h3>Order Number :</h3>
        <asp:TextBox ID="Project_Order_number" runat="server"></asp:TextBox><br /><br />

        <asp:Button ID="Add_button" runat="server" OnClick="Project_Add" Text="Save" CssClass="btn" />
        <br />
        <br /><br />
            

</div>
    </form>
</body>
</html>
