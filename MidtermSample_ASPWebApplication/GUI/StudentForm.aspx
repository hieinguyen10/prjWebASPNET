<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentForm.aspx.cs" Inherits="MidtermSample_ASPWebApplication.GUI.StudentForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            height: 40px;
            width: 875px;
            text-align: center;
        }
        .auto-style5 {
            width: 875px;
            text-align: center;
        }
        .auto-style6 {
            height: 40px;
            width: 619px;
            text-align: center;
        }
        .auto-style7 {
            width: 619px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style6"><strong>List of Project</strong></td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style7">Student ID:
                    <asp:Label ID="lblStudentId" runat="server" Text="ID"></asp:Label>
                </td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">First Name:<asp:Label ID="lblFirstName" runat="server" Text="Name"></asp:Label>
                </td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">Last Name:<asp:Label ID="lblLastName" runat="server" Text="Name"></asp:Label>
                </td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:GridView ID="GridView1" runat="server">
                    </asp:GridView>
                </td>
                <td class="auto-style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Button ID="btnLogOut" runat="server" OnClick="btnLogOut_Click" Text="Log Out" />
                </td>
                <td class="auto-style5">
                    &nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
