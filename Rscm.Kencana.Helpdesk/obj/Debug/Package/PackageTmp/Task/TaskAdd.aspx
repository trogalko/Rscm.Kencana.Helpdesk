<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TaskAdd.aspx.cs" Inherits="Rscm.Kencana.Helpdesk.Task.TaskAdd" %>
<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>

<!DOCTYPE html">
<html>
<head runat="server">
    <title></title>
</head>
<body>    
    <form runat="server">
    <ext:ResourceManager ID="ResourceManager1" runat="server" Theme="Neptune" />
    <div> Halo World
        <ext:Button runat="server" ID="btnClose" Text="Close">
            <Listeners>
                <Click Fn="={onWinClose};" />
            </Listeners>
        </ext:Button>
        <asp:Button runat="server" Text="ASP Button" />
        <ext:Panel runat="server" Title="Close">
            <Items>
                
            </Items>
            <TopBar>
                <ext:Toolbar runat="server">
                    <Items>
                        <ext:Button runat="server" ID="Button1" Text="Close">
                            <Listeners>
                                <Click Fn="={onWinClose};" />
                            </Listeners>
                        </ext:Button>
                    </Items>
                </ext:Toolbar>
            </TopBar>
        </ext:Panel>
    </div>
    <%--<script>
        var onWinClose = function () {
            App.winNew.close();
        };
    </script>--%>
    </form>
</body>
</html>
