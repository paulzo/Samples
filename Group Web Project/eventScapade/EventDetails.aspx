<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="EventDetails.aspx.cs" Inherits="EventDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    

      <div class="threeColumnbox">
        <div class="threeColumninnerbox">

        </div>
        <div class="threeColumninnerbox">

            &nbsp;<asp:Label ID="EventsDetailsTitle" runat="server" Text="Event Details"></asp:Label>
            <br />
            <br />


           <div class="EventDetailsLable">
  
  
    <p>
        <asp:Label ID="lblEventID" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Label ID="lblEventTitle" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Label ID="lblEventDate" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Label ID="lblEventVenue" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Label ID="lblEventPrice" runat="server"></asp:Label>
    </p>
    
        </div> <%--end of product label div--%>

    <div class="EventDetailsPic">
        

        <asp:Image ID="imgEventImage" runat="server" Height="200px" Width="200px" />


    </div> <%--end of product picture div--%>

            <br />
            <div id="AddToCart">

                <asp:Button ID="BtnCart" runat="server" Text="Proceed to Check Out" />

                <br />
                <asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" style="margin-left: 0px" Text="Back" Width="193px" />

            </div> <%--end of add to cart div--%>

        </div>
        <div class="threeColumninnerbox">

            
        </div>

    </div>


</asp:Content>

