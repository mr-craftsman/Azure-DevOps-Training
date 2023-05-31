<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WApp1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Welcome to My ASP.NET Web Application</h1>
<p>This is a simple web application built using ASP.NET.</p>


            <asp:TextBox ID="txtNumber1" runat="server"></asp:TextBox> </br>
            <asp:TextBox ID="txtNumber2" runat="server"></asp:TextBox> </br>
            <asp:Button ID="Calculate" OnClick="btnCalculate_Click"  runat="server" Text="Button" />
            </br>
            <asp:Label ID="lblResult"  runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
