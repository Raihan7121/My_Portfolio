<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="edit.aspx.cs" Inherits="My_Portfolio.edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>EDIT PAGE</h1>
        
                <asp:Label ID="Home" runat="server" Text="Home"></asp:Label><br />
                 <h3>Name :</h3>
                <asp:TextBox ID="Project_Name" runat="server"></asp:TextBox><br />

                <h3>Description : </h3>
                <textarea name="" id="Project_description" runat="server" cols="30" rows="10" placeholder="Write Message Here..." required ></textarea><br /><br />
               
                <h3>Image_Url :</h3>
                <asp:TextBox ID="Project_image_url" runat="server"></asp:TextBox><br />

                <h3>Github_Url :</h3>
                <asp:TextBox ID="Project_github_url" runat="server"></asp:TextBox><br /><br />

                <h3>Order Number :</h3>
                <asp:TextBox ID="Project_Order_number" runat="server"></asp:TextBox><br /><br />

                <asp:Button ID="Edit" runat="server" OnClick="Project_Edit" Text="Save" CssClass="btn" />
                <br />
                <br /><br />
                    

        </div>

         


        
        
         


    </form>
</body>
</html>
