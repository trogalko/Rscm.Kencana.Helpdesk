<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TaskEdit.aspx.cs" Inherits="Rscm.Kencana.Helpdesk.Task.TaskEdit" %>
<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <ext:ResourceManager runat="server"/>
    <div>
        <ext:Button runat="server" >
            <Listeners>
                <Click Fn="={onWinClose};" />
            </Listeners>
        </ext:Button>
    </div>
    <script>
        var onWinClose = function () {
            App.winNew.close();
        };
    </script>
    </form>
</body>
</html>
