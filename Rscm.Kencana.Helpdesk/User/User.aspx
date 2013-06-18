<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="Rscm.Kencana.Helpdesk.User.User" %>
<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <ext:Panel runat="server" MinWidth="800" MinHeight="600" AutoScroll="true">
        <LayoutConfig>
            <ext:HBoxLayoutConfig Align="StretchMax" Padding="5" />
        </LayoutConfig>
        <TopBar>
            <ext:Toolbar runat="server">
                <Items>
                    <ext:Button runat="server" ID="btnSave" Text="SAVE" Icon="Disk" />
                </Items>
            </ext:Toolbar>
        </TopBar>
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
                <SelectionModel>
                    <ext:RowSelectionModel runat="server" ID="smGrdServiceUnit" Mode="Single" >
                        <Listeners>
                            <Select Delay="150" Handler="App.direct.grdServiceUnit_Select();" />                            
                        </Listeners>
                    </ext:RowSelectionModel>
                </SelectionModel>                
            </ext:GridPanel>    
            <ext:GridPanel runat="server" ID="grdUser" Flex="1" Title="Users List" TitleAlign="Left" TitleCollapse="true" MultiSelect="false">
                <Store>
                    <ext:Store runat="server" ID="storeUser" RemoteSort="false" RemotePaging="false" AutoLoad="true" OnReadData="storeUser_Refresh" PageSize="10">
                        <Proxy>
                            <ext:PageProxy />
                        </Proxy>
                        <Model>
                            <ext:Model runat="server" IDProperty="UserID">
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
                <SelectionModel>
                    <ext:RowSelectionModel runat="server" ID="smGrdUser" Mode="Single" >
                        <Listeners>
                            <Select Delay="150" Handler="App.direct.grdUser_Select();" />
                        </Listeners>
                    </ext:RowSelectionModel>
                </SelectionModel>
                <View>
                    <ext:GridView runat="server">
                        <Plugins>
                            <ext:GridDragDrop runat="server" DragGroup="first" DropGroup="second" />
                        </Plugins>
                        <Listeners>
                            <AfterRender Handler="this.plugins[0].dragZone.getDragText = getDragDropText;" Delay="1" />
                            <Drop Handler="var dropOn = overModel ? ' ' + dropPosition + ' ' + overModel.get('UserName') : ' on empty view'; 
                                               Ext.net.Notification.show({title:'Drag from right to left', html:'Dropped ' + data.records[0].get('UserName') + dropOn});" />
                        </Listeners>
                    </ext:GridView>
                </View>
                <MessageBusListeners>
                    <ext:MessageBusListener Name="grdServiceUnit_Select" Handler="App.direct.grdUser_Refresh_From_Select(data);" />
                </MessageBusListeners>
            </ext:GridPanel>
            <ext:GridPanel runat="server" ID="grdUserOfServiceUnit" Flex="1" Title="Users belong to Service Unit" TitleAlign="Left" TitleCollapse="true" MultiSelect="true">
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
                <View>
                    <ext:GridView runat="server">
                        <Plugins>
                            <ext:GridDragDrop runat="server" DragGroup="second" DropGroup="first" />
                        </Plugins>
                        <Listeners>
                            <AfterRender Handler="this.plugins[0].dragZone.getDragText = getDragDropText;" Delay="1" />
                            <Drop Handler="var dropOn = overModel ? ' ' + dropPosition + ' ' + overModel.get('UserName') : ' on empty view'; 
                                               Ext.net.Notification.show({title:'Drag from right to left', html:'Dropped ' + data.records[0].get('UserName') + dropOn});" />
                        </Listeners>
                    </ext:GridView>
                </View>
            </ext:GridPanel>
        </Items>
    </ext:Panel>
</asp:Content>
