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
        <ext:Panel ID="Panel1" runat="server" Width="650" Height="330">
            <Items>
                <ext:FormPanel ID="FormPanel1" runat="server">
                    <Items>
                        <ext:TextField runat="server" ID="txtTitle" FieldLabel="Title" LabelAlign="Top" Margin="0" AllowBlank="false" Width="600" />                        
                        <ext:TextArea runat="server" ID="txtDesc" FieldLabel="Description" LabelAlign="Top" Margin="0" AllowBlank="false" Width="600" MaxLengthText="148" />
                    </Items>
                </ext:FormPanel>
            </Items>
            <Buttons>
                <ext:Button runat="server" ID="btnSave" Text="Save" Icon="Disk">
                <Listeners>
                    <Click Handler="App.direct.btnSave_Click();parentAutoLoadControl.close();" />
                </Listeners>
                </ext:Button>                
            </Buttons>
        </ext:Panel>
    </div>
    <script>
        var onWinClose = function () {
            parentAutoLoadControl.close();
        };
    </script> 
    </form>
</body>
</html>
