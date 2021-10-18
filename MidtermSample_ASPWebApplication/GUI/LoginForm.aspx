<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="MidtermSample_ASPWebApplication.GUI.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 1863px;
        }
        .auto-style3 {
            text-align: right;
            font-size: medium;
            width: 621px;
        }
        .auto-style5 {
            text-align: center;
            width: 621px;
        }
        .auto-style8 {
            font-size: medium;
            text-align: center;
        }
        .auto-style12 {
            text-align: left;
            width: 621px;
        }
        .auto-style13 {
            width: 110px;
            text-align: center;
        }
        .auto-style14 {
            width: 621px;
        }
        .auto-style15 {
            text-align: center;
        }
        .auto-style16 {
            width: 204px;
            text-align: center;
        }
        .auto-style18 {
            width: 204px;
        }
        .auto-style19 {
            width: 110px;
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style8" colspan="2"><strong>Login</strong></td>
                    <td class="auto-style3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style16">&nbsp;</td>
                    <td class="auto-style14">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style19">Login as : </td>
                    <td class="auto-style18">
                        <asp:DropDownList ID="DropDownList1" runat="server" Width="235px">
                            <asp:ListItem>Choose an item ...</asp:ListItem>
                            <asp:ListItem>Teacher</asp:ListItem>
                            <asp:ListItem>Student</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style12">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style19">&nbsp;</td>
                    <td class="auto-style18">&nbsp;</td>
                    <td class="auto-style14">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style19">ID : </td>
                    <td class="auto-style18">
                        <asp:TextBox ID="TextBoxID" runat="server" Width="235px"></asp:TextBox>
                    </td>
                    <td class="auto-style14">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style19">Password :</td>
                    <td class="auto-style18">
                        <asp:TextBox ID="TextBoxPassword" runat="server" Width="235px" TextMode="Password"></asp:TextBox>
                    </td>
                    <td class="auto-style14">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style18">&nbsp;</td>
                    <td class="auto-style14">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style15" colspan="2">
                        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" Width="188px" />
                    </td>
                    <td class="auto-style5">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style16">&nbsp;</td>
                    <td class="auto-style14">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
