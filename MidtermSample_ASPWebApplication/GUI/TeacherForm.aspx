<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TeacherForm.aspx.cs" Inherits="MidtermSample_ASPWebApplication.GUI.TeacherForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style5 {
            width: 874px;
        }
        .auto-style7 {
            height: 279px;
            width: 874px;
        }
        .auto-style8 {
            text-align: center;
            height: 47px;
        }
        .auto-style19 {
            width: 199px;
        }
        .auto-style20 {
            width: 199px;
            height: 40px;
        }
        .auto-style21 {
            height: 279px;
        }
        .auto-style22 {
            width: 113px;
        }
        .auto-style23 {
            width: 113px;
            height: 40px;
        }
        .auto-style25 {
            width: 176px;
        }
        .auto-style26 {
            width: 176px;
            height: 40px;
        }
        .auto-style28 {
            width: 176px;
            text-align: center;
        }
        .auto-style29 {
            width: 199px;
            text-align: center;
        }
        .auto-style30 {
            width: 199px;
            height: 206px;
        }
        .auto-style31 {
            width: 176px;
            height: 206px;
        }
        .auto-style32 {
            width: 113px;
            height: 206px;
        }
        .auto-style33 {
            height: 206px;
            width: 874px;
        }
        .auto-style34 {
            width: 199px;
            height: 17px;
        }
        .auto-style35 {
            width: 176px;
            height: 17px;
        }
        .auto-style36 {
            width: 113px;
            height: 17px;
        }
        .auto-style37 {
            height: 17px;
            width: 874px;
        }
        .auto-style38 {
            margin-top: 0px;
        }
        .auto-style39 {
            height: 44px;
            text-align: center;
        }
        .auto-style40 {
            height: 44px;
            width: 874px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style8" colspan="3"><strong>Student_Project Assignment</strong></td>
                    <td class="auto-style5" rowspan="7"></td>
                </tr>
                <tr>
                    <td class="auto-style19">&nbsp;</td>
                    <td class="auto-style25">&nbsp;</td>
                    <td class="auto-style22">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style19"><strong>Select Student</strong></td>
                    <td class="auto-style25"><strong>Select Project</strong></td>
                    <td class="auto-style22">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style19">
                        <asp:DropDownList ID="DropDownListStudent" runat="server" Width="144px">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style25">
                        <asp:DropDownList ID="DropDownListProject" runat="server" Width="137px">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style22">
                        <asp:Button ID="btnAssignProject" runat="server" OnClick="btnAssignProject_Click" Text="Assign Project" Width="142px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style20"></td>
                    <td class="auto-style26"></td>
                    <td class="auto-style23">
                        <asp:Button ID="btnListProject" runat="server" OnClick="btnListProject_Click" Text="List Project" Width="103px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style19">&nbsp;</td>
                    <td class="auto-style25">&nbsp;</td>
                    <td class="auto-style22">
                        <asp:Button ID="btnListStudent" runat="server" OnClick="btnListStudent_Click" Text="List Student" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style29">Select the Assigned Date</td>
                    <td class="auto-style28">Select the Submitted Date</td>
                    <td class="auto-style22">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style30">
                        <asp:Calendar ID="CalendarAssignedDate" runat="server"></asp:Calendar>
                    </td>
                    <td class="auto-style31">
                        <asp:Calendar ID="CalendarSubmittedDate" runat="server"></asp:Calendar>
                    </td>
                    <td class="auto-style32"></td>
                    <td class="auto-style33"></td>
                </tr>
                <tr>
                    <td class="auto-style34"></td>
                    <td class="auto-style35"></td>
                    <td class="auto-style36"></td>
                    <td class="auto-style37"></td>
                </tr>
                <tr>
                    <td class="auto-style21" colspan="3">
                        <asp:GridView ID="GridViewListInfor" runat="server" CssClass="auto-style38" Height="183px" Width="383px">
                        </asp:GridView>
                    </td>
                    <td class="auto-style7">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style39" colspan="3">
                        <asp:Button ID="btnLogOut" runat="server" OnClick="btnLogOut_Click" Text="Log Out" />
                    </td>
                    <td class="auto-style40"></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
