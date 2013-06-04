<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="Rscm.Kencana.Helpdesk.User.User" %>
<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <ext:Panel runat="server" ID="pnlUser" AutoScroll="true" MinWidth="800" MinHeight="600">
        <LayoutConfig>
            <ext:HBoxLayoutConfig Align="Stretch" Padding="5" />
        </LayoutConfig>
        <Items>
            <ext:GridPanel runat="server" ID="grdServiceUnit">
                <Store>
                    <ext:Store runat="server" ID="storeServiceUnit" AutoLoad="true" OnReadData="storeServiceUnit_Refresh" PageSize="10">
                        <Proxy>
                            <ext:PageProxy />
                        </Proxy>
                        <Model>
                            <ext:Model runat="server" IDProperty="ServiceUnitID">
                                <Fields>
                                    <ext:ModelField Name="ServiceUnitID" Type="Int" />
                                    <ext:ModelField Name="ServiceUnitName" Type="String" />
                                </Fields>
                            </ext:Model>
                        </Model>
                    </ext:Store>
                </Store>
                <ColumnModel>
                    <Columns>
                        <ext:NumberColumn runat="server" Text="ID" DataIndex="ServiceUnitID" />
                        <ext:Column runat="server" Text="Service Unit" DataIndex="ServiceUnitName" />
                    </Columns>
                </ColumnModel>
            </ext:GridPanel>    
            <ext:GridPanel runat="server" ID="grdUser">
                <Store>
                
                </Store>
                <Items>
                
                </Items>
            </ext:GridPanel>
            <ext:GridPanel runat="server" ID="grdUserOfServiceUnit">
                <Store>
                
                </Store>
                <Items>
                
                </Items>
            </ext:GridPanel>
        </Items>
    </ext:Panel>
</asp:Content>
