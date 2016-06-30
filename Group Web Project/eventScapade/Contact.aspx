<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 75%;
            margin-left: 168px;
        }
        .auto-style3 {
            height: 24px;
            width: 713px;
        }
        .auto-style4 {
            width: 713px;
        }
    .auto-style5 {
        height: 24px;
        width: 175px;
    }
    .auto-style6 {
        width: 175px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

         <div class="contactTitle">
<h1>Contact Us </h1>
               
        
              </div>

                
            <div class="table">
                <table class="auto-style1">
            <td class="auto-style5">
                <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="TBName" runat="server"></asp:TextBox>
            </td>
    
        <tr>
            <td class="auto-style6">
                <asp:Label ID="lblEmail" runat="server" Text="Email Address:"></asp:Label>
            </td>
            <td class="auto-style4">
                <asp:TextBox ID="TBEmail" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Label ID="lblContactNo" runat="server" Text="Contact Number:"></asp:Label>
            </td>
            <td class="auto-style4">
                <asp:TextBox ID="TBContactNo" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Label ID="lblMessage" runat="server" Text="Message:"></asp:Label>
            </td>
            <td class="auto-style4">
                <asp:TextBox ID="TBMessage" runat="server" Height="156px" MaxLength="100"  Width="360px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">
                &nbsp;</td>
            <td class="auto-style4">
                <asp:Button ID="Submit" runat="server" Text="Submit" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnClear" runat="server" Text="Clear" />
            </td>
        </tr>
    </table>
                </div>
</asp:Content>

