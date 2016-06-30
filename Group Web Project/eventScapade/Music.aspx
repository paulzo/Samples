<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Music.aspx.cs" Inherits="Music" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <asp:GridView ID="dgvMusic" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="dgvEvents_SelectedIndexChanged" OnPageIndexChanged="dgvEvents_SelectedIndexChanged" CssClass="Grid" HorizontalAlign="Center"  >
         <AlternatingRowStyle BackColor="#66CCFF" />
        <Columns>
            
            <asp:BoundField DataField="EventID" HeaderText="Event ID" />
            
            <asp:CommandField ShowSelectButton="True" />
            <asp:BoundField DataField="EventType" HeaderText="Event Type" />
            <asp:BoundField DataField="EventTitle" HeaderText="Event Name" />
            <asp:BoundField DataField="EventDate" DataFormatString="{0:d}" HeaderText="Event Date" />
            <asp:BoundField DataField="EventVenue" HeaderText="Event Venue" />
            <asp:BoundField DataField="EventPrice" DataFormatString="{0:c}." HeaderText="Event Price" />
            <asp:BoundField DataField="TicketQuantity" HeaderText="Ticket Quantity" />
            <asp:BoundField DataField="EventImage" HeaderText="Image" Visible="False" />
            <asp:ImageField DataImageUrlField="EventImage" HeaderText="Event Image">
                <ControlStyle Height="125px" Width="125px" />
            </asp:ImageField>
        </Columns>
         <HeaderStyle BackColor="#3399FF" BorderColor="Black" BorderStyle="Solid" BorderWidth="5px" Font-Bold="True" Font-Size="Medium" ForeColor="White" HorizontalAlign="Center" VerticalAlign="Middle" />
         <RowStyle BorderStyle="Solid" BorderColor="Black" BorderWidth="5px" HorizontalAlign="Center" />
         <SortedDescendingCellStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="5px" />
</asp:GridView>






</asp:Content>

