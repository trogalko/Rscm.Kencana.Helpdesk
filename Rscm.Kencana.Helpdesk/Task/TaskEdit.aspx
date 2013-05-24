<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TaskEdit.aspx.cs" Inherits="Rscm.Kencana.Helpdesk.Task.TaskEdit" %>
<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">  
    <ext:ResourceManager ID="ResourceManager1" runat="server" Theme="Neptune" />      
    <div>
        <ext:TextField runat="server" FieldLabel="Isi disini" /> 
        <ext:TextField ID="TextField1" runat="server" FieldLabel="Isi disini" />
        <ext:TextField ID="TextField2" runat="server" FieldLabel="Isi disini" />
        <ext:TextField ID="TextField3" runat="server" FieldLabel="Isi disini" />
        <ext:TextField ID="TextField4" runat="server" FieldLabel="Isi disini" />
        <ext:TextField ID="TextField5" runat="server" FieldLabel="Isi disini" />
        <ext:Button ID="Button10" runat="server" Text="Click">
            <Listeners>
                <Click Fn="={onWinClose}" />                
            </Listeners>            
        </ext:Button>   
    </div> 
    
    <script>
        var onWinClose = function () {
            parentAutoLoadControl.close();
        };
    </script>   
    </form>
</body>
</html>
