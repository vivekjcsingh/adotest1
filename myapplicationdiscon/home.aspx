<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="myapplicationdiscon.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DataGrid ID="DataGrid1" runat="server"></asp:DataGrid>

        <table>
            <tr>
                <td>Address id:</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
            </tr>
             <tr>
                <td>First Name:</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
            </tr>
             <tr>
                <td>Last Name:</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
            </tr>
             <tr>
                <td>Email:</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
            </tr>
             <tr>
                <td>Phone:</td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="insert" OnClick="Button1_Click" />
                    &nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" Text="delete" OnClick="Button2_Click" />
                &nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button3" runat="server" Text="Search" OnClick="Button3_Click" />
                    &nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button4" runat="server" Text="update" OnClick="Button4_Click" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
