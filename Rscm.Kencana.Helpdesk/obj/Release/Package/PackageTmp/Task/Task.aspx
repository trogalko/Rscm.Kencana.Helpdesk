<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Task.aspx.cs" Inherits="Rscm.Kencana.Helpdesk.Task.Task" %>
<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <script runat="server">
        protected void gridDetails_Refresh(object sender, DirectEventArgs e)
        {
            RowSelectionModel rm = this.grdTask.GetSelectionModel() as RowSelectionModel;
            lblHtml.Html = rm.SelectedRow.RecordID;
        }
    </script>
<ext:Panel runat="server" MinWidth="800" MinHeight="800">
<Items>
    <ext:Panel runat="server" ID="pnlTask" MinHeight="400" Split="true" AutoScroll="true">
        <Items>
            <ext:TabPanel runat="server" MinHeight="600" Frame="true">
                <Defaults>
                    <ext:Parameter Name="bodyPadding" Value="10" Mode="Raw" />
                    <ext:Parameter Name="autoScroll" Value="true" Mode="Raw" />
                </Defaults>
                <Items>
                    <ext:Panel runat="server" ID="Panel1" Title="All Tasks" MinHeight="400" Split="true" AutoScroll="true">
                        <Items>
                            <ext:GridPanel runat="server" ID="grdTask">
                                <Store>
                                    <ext:Store ID="storeTask" runat="server" RemoteSort="false" RemotePaging="false" AutoLoad="true" OnReadData="storeTask_ReadData" PageSize="100">                        
                                        <Model>
                                            <ext:Model runat="server" IDProperty="TaskID">
                                                <Fields>
                                                    <ext:ModelField Name="TaskID" Type="Int" />
                                                    <ext:ModelField Name="Status" Type="String" /> 
                                                    <ext:ModelField Name="DueDate" Type="Date" />
                                                    <ext:ModelField Name="CreatedDate" Type="Date" />
                                                    <ext:ModelField Name="ConfirmAsFinishDate" Type="Date" />
                                                    <ext:ModelField Name="AssignedRoleID" Type="Int" />
                                                    <ext:ModelField Name="Description" Type="String" />
                                                    <ext:ModelField Name="RequesterName" Type="String" />
                                                    <ext:ModelField Name="RequesterEmail" Type="String" />
                                                    <ext:ModelField Name="RequesterPhone" Type="String" />
                                                </Fields>
                                            </ext:Model>
                                        </Model>
                                        <Sorters>
                                            <ext:DataSorter Property="TaskID" Direction="DESC" />
                                        </Sorters>
                                    </ext:Store>    
                                </Store>
                                <ColumnModel>
                                    <Columns>
                                        <ext:ActionColumn runat="server" Flex="2">
                                            <Items>
                                                <ext:ActionItem Icon="NoteEdit" Tooltip="Edit" Handler="function(view,rowidx,colidx,item,e,record){#{DirectMethods}.grdTask_Edit(record.data.TaskID)}" />
                                                <ext:ActionItem Icon="NoteGo" Tooltip="Confirm as Finished" Handler="function(view,rowidx,colidx,item,e,record){#{DirectMethods}.grdTask_Confirm(record.data.TaskID)}" />
                                                <ext:ActionItem Icon="NoteDelete" Tooltip="Cancel Request" Handler="function(view,rowidx,colidx,item,e,record){#{DirectMethods}.grdTask_Cancel(record.data.TaskID)}" />
                                            </Items>
                                        </ext:ActionColumn>
                                        <ext:ActionColumn ID="acApprove" runat="server" Flex="1">
                                            <Items>
                                                <ext:ActionItem Icon="MedalGold1" Tooltip="Approve by PIC" Handler="function(view,rowidx,colidx,item,e,record){#{DirectMethods}.grdTask_ApproveByPic(record.data.TaskID)}" />
                                            </Items>
                                        </ext:ActionColumn>
                                        <ext:Column runat="server" Text="TaskID" DataIndex="TaskID" Visible="true" Flex="2" />
                                        <ext:Column runat="server" Text="Status" DataIndex="Status" Flex="3" />
                                        <ext:DateColumn runat="server" Text="Deadline" DataIndex="DueDate" Flex="3" />
                                        <ext:DateColumn runat="server" Text="Created Date" DataIndex="CreatedDate" Flex="3" />
                                        <ext:DateColumn runat="server" Text="Confirm Date" DataIndex="ConfirmAsFinishDate" Flex="3" />
                                        <ext:Column runat="server" Text="Description" DataIndex="Description" Flex="11" />
                                        <ext:Column runat="server" Text="Req. By" DataIndex="RequesterName" Flex="4" />
                                        <ext:Column runat="server" Text="Req. By Serv. Unit" DataIndex="RequesterName" Flex="4" />
                                        <ext:Column runat="server" Text="Req. For Serv. Unit" DataIndex="RequesterName" Flex="4" />
                                    </Columns>
                                </ColumnModel>
                                <TopBar>                    
                                    <ext:DesktopTaskBar>
                                        <Items>
                                            <ext:Button ID="btnNew" Icon="Add" Text="Add New Request" runat="server">
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
                                <MessageBusListeners>
                                    <ext:MessageBusListener Name="grdTask_Refresh" Handler="this.getStore().reload();" />                    
                                </MessageBusListeners>                
                                <SelectionModel>
                                    <ext:RowSelectionModel ID="RowSelectionModel1" runat="server" Mode="Single"> 
                                        <Listeners>
                                            <Select Delay="300" Handler="App.direct.grdTask_Select();" />                            
                                        </Listeners>                
                                    </ext:RowSelectionModel>                    
                                </SelectionModel>
                                <Features>
                                    <ext:RowBody ID="RowBody1" runat="server">
                                        <%--<GetAdditionalData 
                                            Handler="return {rowBodyColspan : record.fields.getCount(), rowBody : '<p>' + data.TaskID + '</p>'};" />--%>
                                    </ext:RowBody>
                                </Features>          
                                <BottomBar>
                                    <ext:PagingToolbar ID="PagingToolbar1" 
                                        runat="server"                      
                                        DisplayInfo="true" 
                                        DisplayMsg="Displaying Task {0} - {1} of {2}" 
                                        EmptyMsg="No employees to display" 
                                    />
                                </BottomBar>
                            </ext:GridPanel>
                            <ext:Panel runat="server" ID="pnlDetails" MinHeight="400" AutoScroll="true">
                                <Items>
                                    <ext:Panel ID="Panel2" runat="server" MinHeight="400" AutoScroll="true">
                                        <TopBar>
                                            <ext:Toolbar ID="Toolbar1" runat="server">
                                                <Items>
                                                    <ext:Button runat="server" ID="btnComment" Text="Add Comment" Icon="CommentAdd">
                                                        <Listeners>
                                                            <Click Handler="App.direct.btnComment_Click();" />
                                                        </Listeners>
                                                    </ext:Button>
                                                </Items>
                                            </ext:Toolbar>
                                        </TopBar>
                                        <Items>                    
                                            <ext:Label runat="server" ID="lblHtml" Html="<b>Comment :</b><br>" />       
                                            <ext:TextArea runat="server" ID="txtComment" Width="500" FieldLabel="Comment" />             
                                        </Items>
                                    </ext:Panel>
                                    <ext:Panel ID="Panel3" runat="server">
                                    </ext:Panel>
                                </Items>
                            </ext:Panel>
                        </Items>
                    </ext:Panel>      
                    <ext:Panel runat="server" ID="PanelApprove" Title="Task(s) that require your Approval">
                        <Items>
                            <ext:GridPanel runat="server" ID="grdNeedApproval">                                
                                <Store>
                                    <ext:Store ID="storeNeedApproval" runat="server" RemoteSort="false" RemotePaging="false" AutoLoad="true" OnReadData="storeNeedApproval_ReadData" PageSize="10">                        
                                        <Model>
                                            <ext:Model ID="ModelstoreNeedApproval" runat="server" IDProperty="TaskID">
                                                <Fields>
                                                    <ext:ModelField Name="TaskID" Type="Int" />
                                                    <ext:ModelField Name="Status" Type="String" /> 
                                                    <ext:ModelField Name="DueDate" Type="Date" />
                                                    <ext:ModelField Name="CreatedDate" Type="Date" />
                                                    <ext:ModelField Name="ConfirmAsFinishDate" Type="Date" />
                                                    <ext:ModelField Name="AssignedRoleID" Type="Int" />
                                                    <ext:ModelField Name="Description" Type="String" />
                                                    <ext:ModelField Name="RequesterName" Type="String" />
                                                    <ext:ModelField Name="RequesterEmail" Type="String" />
                                                    <ext:ModelField Name="RequesterPhone" Type="String" />
                                                </Fields>
                                            </ext:Model>
                                        </Model>
                                        <Sorters>
                                            <ext:DataSorter Property="TaskID" Direction="DESC" />
                                        </Sorters>
                                    </ext:Store>    
                                </Store>
                                <ColumnModel>
                                    <Columns>                                        
                                        <ext:ActionColumn ID="ActionColumn2" runat="server" Flex="1">
                                            <Items>
                                                <ext:ActionItem Icon="MedalGold1" Tooltip="Approve by Requestor" Handler="function(view,rowidx,colidx,item,e,record){#{DirectMethods}.grdTask_ApproveByPic(record.data.TaskID)}" />
                                            </Items>
                                        </ext:ActionColumn>
                                        <ext:Column ID="Column1" runat="server" Text="TaskID" DataIndex="TaskID" Visible="true" Flex="2" />
                                        <ext:Column ID="Column2" runat="server" Text="Status" DataIndex="Status" Flex="3" />
                                        <ext:DateColumn ID="DateColumn1" runat="server" Text="Deadline" DataIndex="DueDate" Flex="3" />
                                        <ext:DateColumn ID="DateColumn2" runat="server" Text="Created Date" DataIndex="CreatedDate" Flex="3" />
                                        <ext:DateColumn ID="DateColumn3" runat="server" Text="Confirm Date" DataIndex="ConfirmAsFinishDate" Flex="3" />
                                        <ext:Column ID="Column3" runat="server" Text="Description" DataIndex="Description" Flex="11" />
                                        <ext:Column ID="Column4" runat="server" Text="Req. By" DataIndex="RequesterName" Flex="4" />
                                        <ext:Column ID="Column5" runat="server" Text="Req. By Serv. Unit" DataIndex="RequesterName" Flex="4" />
                                        <ext:Column ID="Column6" runat="server" Text="Req. For Serv. Unit" DataIndex="RequesterName" Flex="4" />
                                    </Columns>
                                </ColumnModel>                                               
                                <MessageBusListeners>
                                    <ext:MessageBusListener Name="grdTask_Refresh" Handler="this.getStore().reload();" />                    
                                </MessageBusListeners>                
                                <SelectionModel>
                                    <ext:RowSelectionModel ID="RowSelectionModel2" runat="server" Mode="Single"> 
                                        <Listeners>
                                            <Select Delay="300" Handler="App.direct.grdTask_Select();" />                            
                                        </Listeners>                
                                    </ext:RowSelectionModel>                    
                                </SelectionModel>
                                <Features>
                                    <ext:RowBody ID="RowBody2" runat="server">
                                        <%--<GetAdditionalData 
                                            Handler="return {rowBodyColspan : record.fields.getCount(), rowBody : '<p>' + data.TaskID + '</p>'};" />--%>
                                    </ext:RowBody>
                                </Features>          
                                <BottomBar>
                                    <ext:PagingToolbar ID="PagingToolbar2" 
                                        runat="server"                      
                                        DisplayInfo="true" 
                                        DisplayMsg="Displaying Task {0} - {1} of {2}" 
                                        EmptyMsg="No employees to display" 
                                    />
                                </BottomBar>
                            </ext:GridPanel>
                        </Items>
                    </ext:Panel>              
                </Items>
            </ext:TabPanel>
        </Items>
    </ext:Panel>    
</Items>
</ext:Panel>
        
    <ext:Window runat="server" ID="wNew" Hidden="true">
        <Loader runat="server" Mode="Frame" AutoLoad="false">
            <LoadMask ShowMask="true" />
        </Loader>
    </ext:Window>

    <script>
        var ongrdTaskRefresh = function () {
            grdTask.store.load();
        };
    </script>
</asp:Content>