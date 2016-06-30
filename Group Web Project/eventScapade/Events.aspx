<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Events.aspx.cs" Inherits="Events" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="threeColumnbox">
        <div class="threeColumninnerbox">

            &nbsp;<asp:Label ID="lblMusic" runat="server" Text="Music"></asp:Label>
            <br />
            <br />
            <asp:ImageButton ID="imgbMusic" runat="server" ImageUrl="~/images/biffy clyro.jpg" OnClick="imgbMusic_Click" Width="280px" />

        </div>
        <div class="threeColumninnerbox">

            <asp:Label ID="lblSport" runat="server" Text="Sport"></asp:Label>
            <br />
            <br />
            <asp:ImageButton ID="imgbSport" runat="server" Height="339px" ImageUrl="~/images/147274.jpg" OnClick="imgbSport_Click" Width="280px" />

        </div>
        <div class="threeColumninnerbox">

            <asp:Label ID="lblTheatre" runat="server" Text="Theatre"></asp:Label>
            <br />
            <br />
            <asp:ImageButton ID="imgbTheatre" runat="server" Height="378px" ImageUrl="~/images/peter-pan-5252d9aa8b50a.jpg" OnClick="imgbTheatre_Click" />

        </div>

    </div>
    </asp:Content>

