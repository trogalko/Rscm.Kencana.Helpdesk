<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="Rscm.Kencana.Helpdesk._Default" %>
<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <%--<ext:ResourceManager ThemePath="~/Resources/css/bootstrap/bootstrap.css" runat="server"></ext:ResourceManager>--%>
    <h2>
        <ext:Button runat="server" ID="btnClickMe" Text="CLICK ME">
            <Listeners>
                <Click Handler="App.direct.btnClickMe_Clicked();" />
            </Listeners>
        </ext:Button>
        Welcome to ASP.NET!
    </h2>
    <p>
        To learn more about ASP.NET visit <a href="http://www.asp.net" title="ASP.NET Website">www.asp.net</a>.
    </p>
    <ext:GridPanel runat="server"/>
</asp:Content>
