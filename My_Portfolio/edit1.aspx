<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="edit1.aspx.cs" Inherits="My_Portfolio.edit1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <title>Edit Page</title>
    <link rel="stylesheet" href="editt_style.css"/>
</head>
<body>
    <form id="form1" runat="server">
        
        <div>

           
            <asp:Table ID="dynamicTable" runat="server" CssClass="table-styled">
                <asp:TableHeaderRow runat="server">
                    <asp:TableHeaderCell CssClass="cell-styled">Serial_No</asp:TableHeaderCell>
                    <asp:TableHeaderCell CssClass="cell-styled">Name</asp:TableHeaderCell>
                    <asp:TableHeaderCell CssClass="cell-styled">Description</asp:TableHeaderCell>
                    <asp:TableHeaderCell CssClass="cell-styled">Image</asp:TableHeaderCell>
                    <asp:TableHeaderCell CssClass="cell-styled">Priority Order</asp:TableHeaderCell>
                    <asp:TableHeaderCell CssClass="cell-styled">Operation</asp:TableHeaderCell>
                </asp:TableHeaderRow>
            </asp:Table>
            <br /><br /><br /><br />
            <asp:Button ID="Add_Button1" runat="server" OnClick="Add_Button" Text="Add More" CssClass="btn"/>

        </div>
    </form>
</body>
</html>
