﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="Rscm.Kencana.Helpdesk.User.User" %>
<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <ext:Panel runat="server" MinWidth="800" MinHeight="600" AutoScroll="true">
        <LayoutConfig>
            <ext:HBoxLayoutConfig Align="StretchMax" Padding="5" />
        </LayoutConfig>
        <Items>
            <ext:GridPanel runat="server" ID="grdServiceUnit" Flex="1" Title="Service Units List" TitleAlign="Left" TitleCollapse="true">
                <Store>
                    <ext:Store runat="server" ID="storeServiceUnit" RemoteSort="false" RemotePaging="false" AutoLoad="true" OnReadData="storeServiceUnit_Refresh" PageSize="10">
                        <Proxy>
                            <ext:PageProxy />
                        </Proxy>
                        <Model>
                            <ext:Model runat="server" IDProperty="ServiceUnitID">
                                <Fields>
                                    <ext:ModelField Name="ServiceUnitID" />
                                    <ext:ModelField Name="ServiceUnitName" Type="String" />
                                </Fields>
                            </ext:Model>
                        </Model>
                    </ext:Store>
                </Store>
                <ColumnModel>
                    <Columns>
                        <ext:Column runat="server" Text="ID" DataIndex="ServiceUnitID" Visible="false" Flex="1" />
                        <ext:Column runat="server" Text="Service Unit" DataIndex="ServiceUnitName" Width="220" Flex="19" />
                    </Columns>
                </ColumnModel>
            </ext:GridPanel>    
            <ext:GridPanel runat="server" ID="grdUser" Flex="1" Title="Users List" TitleAlign="Left" TitleCollapse="true">
                <Store>
                    <ext:Store runat="server" ID="storeUser" RemoteSort="false" RemotePaging="false" AutoLoad="true" OnReadData="storeUser_Refresh" PageSize="10">
                        <Proxy>
                            <ext:PageProxy />
                        </Proxy>
                        <Model>
                            <ext:Model runat="server" IDProperty="ServiceUnitID">
                                <Fields>
                                    <ext:ModelField Name="UserID" />
                                    <ext:ModelField Name="UserName" Type="String" />
                                </Fields>
                            </ext:Model>
                        </Model>
                    </ext:Store>
                </Store>
                <ColumnModel>
                    <Columns>
                        <ext:Column runat="server" Text="ID" DataIndex="UserID" Visible="false" Flex="1" />
                        <ext:Column runat="server" Text="User Name" DataIndex="UserName" Width="220" Flex="19" />
                    </Columns>
                </ColumnModel>
                <View>
                    <ext:GridView runat="server">
                        <Plugins>
                            <ext:GridDragDrop runat="server" DragGroup="first" DropGroup="second" />
                        </Plugins>
                    </ext:GridView>
                </View>
            </ext:GridPanel>
            <ext:GridPanel runat="server" ID="grdUserOfServiceUnit" Flex="1" Title="Users belong to Service Unit" TitleAlign="Left" TitleCollapse="true">
                <Store>
                    <ext:Store runat="server" ID="storeUserOfServiceUnit" RemoteSort="false" RemotePaging="false" AutoLoad="true" OnReadData="storeUserOfServiceUnit_Refresh" PageSize="10">
                        <Proxy>
                            <ext:PageProxy />
                        </Proxy>
                        <Model>
                            <ext:Model ID="Model1" runat="server" IDProperty="ServiceUnitID">
                                <Fields>
                                    <ext:ModelField Name="UserID" />
                                    <ext:ModelField Name="UserName" Type="String" />
                                </Fields>
                            </ext:Model>
                        </Model>
                    </ext:Store>
                </Store>
                <ColumnModel>
                    <Columns>
                        <ext:Column runat="server" Text="ID" DataIndex="UserID" Visible="false" Flex="1" />
                        <ext:Column runat="server" Text="Service Unit" DataIndex="UserName" Width="220" Flex="19" />
                    </Columns>
                </ColumnModel>
            </ext:GridPanel>
        </Items>
    </ext:Panel>
</asp:Content>