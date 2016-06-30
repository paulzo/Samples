<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
            width: 137px;
        }
        .auto-style3 {
            height: 23px;
            width: 132px;
        }
        .auto-style4 {
            width: 132px;
        }
        .auto-style5 {
            width: 218px;
        }
        .auto-style6 {
            height: 23px;
            width: 218px;
        }
        .auto-style7 {
            height: 23px;
            width: 334px;
        }
        .auto-style8 {
            width: 334px;
        }
        .auto-style9 {
            width: 132px;
            height: 26px;
        }
        .auto-style10 {
            width: 334px;
            height: 26px;
        }
        .auto-style11 {
            width: 218px;
            height: 26px;
        }
        .auto-style12 {
            height: 26px;
            width: 137px;
        }
        .auto-style13 {
            width: 137px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p>
        &nbsp;</p>
    <table class="auto-style1">
        <tr>
            <td colspan="4">
                <asp:Label ID="lblTitle" runat="server" Font-Bold="True" Font-Names="Arial" Font-Underline="True" Text="Registration"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label2" runat="server" Text="Title"></asp:Label>
            </td>
            <td class="auto-style7">
                <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    <asp:ListItem>Mr</asp:ListItem>
                    <asp:ListItem>Miss</asp:ListItem>
                    <asp:ListItem>Ms</asp:ListItem>
                    <asp:ListItem>Mrs</asp:ListItem>
                    <asp:ListItem>Dr</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style6">
                <asp:Label ID="lblusernametext" runat="server" Text="Please choose a user name"></asp:Label>
            </td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="lblFname" runat="server" Text="First Name"></asp:Label>
            </td>
            <td class="auto-style7">
                <asp:TextBox ID="TBfname" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style6">
                <asp:Label ID="lblUsername" runat="server" Text="Username:"></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:TextBox ID="TBUser" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">
                <asp:Label ID="lblsurName" runat="server" Text="Surname:"></asp:Label>
            </td>
            <td class="auto-style10">
                <asp:TextBox ID="TBSurname" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style11">
                <asp:Label ID="lblPwd" runat="server" Text="Password:"></asp:Label>
            </td>
            <td class="auto-style12">
                <asp:TextBox ID="TBPwd" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label>
            </td>
            <td class="auto-style8">
                <asp:TextBox ID="TBEmail" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style5">
                <asp:Label ID="lblRePwd" runat="server" Text="Re-enter Password:"></asp:Label>
            </td>
            <td class="auto-style13">
                <asp:TextBox ID="TBRePwd" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
            </td>
            <td class="auto-style8">
                <asp:TextBox ID="TBAddress" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style13">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="lblTown" runat="server" Text="Town"></asp:Label>
            </td>
            <td class="auto-style8">
                <asp:TextBox ID="TBTown" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style13">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="lblCity" runat="server" Text="City:"></asp:Label>
            </td>
            <td class="auto-style8">
                <asp:TextBox ID="TBCity" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style5">
                <asp:Button ID="btnClear" runat="server" Text="Clear" Width="65px" />
            </td>
            <td class="auto-style13">
                <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="lblPostCode" runat="server" Text="Phone:"></asp:Label>
            </td>
            <td class="auto-style8">
                <asp:TextBox ID="TBPhone" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style13">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style13">&nbsp;</td>
        </tr>
    </table>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>

