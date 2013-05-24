<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Task.aspx.cs" Inherits="Rscm.Kencana.Helpdesk.Task.Task" %>
<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <ext:Panel runat="server" ID="pnlTask" Title="REQUESTS">
        <Items>
            <ext:GridPanel runat="server" ID="grdTask">
                <Store>
                    <ext:Store ID="storeTask" runat="server" AutoLoad="true" OnReadData="storeTask_ReadData" PageSize="100">
                        <Proxy>
                            <ext:PageProxy />
                        </Proxy>
                        <Model>
                            <ext:Model runat="server">
                                <Fields>
                                    <ext:ModelField Name="TaskID" Type="Int" />
                                    <ext:ModelField Name="Status" Type="String" /> 
                                    <ext:ModelField Name="DueDate" Type="Date" />
                                    <ext:ModelField Name="CreatedDate" Type="Date" />
                                    <ext:ModelField Name="AssignedRoleID" Type="Int" />
                                    <ext:ModelField Name="Description" Type="String" />
                                    <ext:ModelField Name="RequesterName" Type="String" />
                                </Fields>
                            </ext:Model>
                        </Model>
                    </ext:Store>    
                </Store>
                <ColumnModel>
                    <Columns>
                        <ext:ActionColumn runat="server" Flex="1">
                            <Items>
                                <ext:ActionItem Icon="NoteEdit" Tooltip="Edit" Handler="function(view,rowidx,colidx,item,e,record){#{DirectMethods}.grdTask_Edit(record.data.TaskID)}" />
                                <ext:ActionItem Icon="NoteGo" Tooltip="Confirm as Finished" Handler="function(view,rowidx,colidx,item,e,record){#{DirectMethods}.grdTask_Confirm(record.data.TaskID)}" />
                                <ext:ActionItem Icon="NoteDelete" Tooltip="Cancel Request" Handler="function(view,rowidx,colidx,item,e,record){#{DirectMethods}.grdTask_Cancel(record.data.TaskID)}" />
                            </Items>
                        </ext:ActionColumn>
                        <ext:Column runat="server" Text="TaskID" DataIndex="TaskID" Visible="false" Flex="1" />
                        <ext:Column runat="server" Text="Status" DataIndex="Status" Flex="1" />
                        <ext:DateColumn runat="server" Text="Deadline" DataIndex="DueDate" Flex="3" />
                        <ext:DateColumn runat="server" Text="Created Date" DataIndex="CreatedDate" Flex="3" />
                        <ext:Column runat="server" Text="Description" DataIndex="Description" Flex="10" />
                        <ext:Column runat="server" Text="Request By" DataIndex="RequesterName" Flex="3" />
                    </Columns>
                </ColumnModel>
                <TopBar>                    
                    <ext:DesktopTaskBar>
                        <Items>
                            <ext:Button ID="btnNew" Icon="Add" runat="server">
                                <Listeners>
                                    <Click Handler="App.direct.btnNew_Click();" />                                    
                                </Listeners>
                            </ext:Button>
                            <ext:TextField ID="txtSearch" Icon="Find" runat="server" Width="250">
                                <Listeners>
                                    <Change Handler="App.direct.txtSearch_Change();" />
                                </Listeners>
                            </ext:TextField>
                            <ext:ComboBox ID="cmbStatus" runat="server" FieldLabel="Status" LabelAlign="Left" ForceSelection="true" Editable="false" DisplayField="text" ValueField="value">
                                <Store>
                                    <ext:Store ID="storeStatus" runat="server">
                                        <Model>
                                            <ext:Model runat="server">
                                                <Fields>
                                                    <ext:ModelField Name="text" />
                                                    <ext:ModelField Name="value" />
                                                </Fields>
                                            </ext:Model>
                                        </Model>
                                    </ext:Store>
                                </Store>
                                <Items>
                                    <%--<ext:ListItem Text="New" Value="New" />
                                    <ext:ListItem Text="Finished" Value="Resolved" />
                                    <ext:ListItem Text="Cancelled" Value="Cancelled" />--%>
                                </Items>
                                <Listeners>
                                    <%--<Change Handler="App.direct.cmbStatus_Change();" />   --%>                                 
                                </Listeners>
                            </ext:ComboBox>
                            <ext:Button runat="server" ID="btnSearch" Icon="Zoom" Text="Search">
                                <Listeners>
                                    <Click Handler="App.direct.btnSearch_Click();" />
                                </Listeners>   
                            </ext:Button>
                        </Items>
                    </ext:DesktopTaskBar>
                </TopBar>
                <BottomBar>
                    <ext:PagingToolbar runat="server" ID="pagingTask" StoreID="storeTask" />
                </BottomBar>
            </ext:GridPanel>
        </Items>
    </ext:Panel>
    <ext:Window runat="server" ID="wNew" Hidden="true">
        <Loader runat="server" Mode="Frame" AutoLoad="false">
            <LoadMask ShowMask="true" />
        </Loader>
    </ext:Window>
</asp:Content>
