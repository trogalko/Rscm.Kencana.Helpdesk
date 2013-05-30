<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TaskAdd.aspx.cs" Inherits="Rscm.Kencana.Helpdesk.Task.TaskAdd" %>
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
        <ext:Panel runat="server" Width="650" Height="330">
            <Items>
                <ext:FormPanel runat="server" MonitorValid="true">
                    <Items>                        
                        <ext:TextField runat="server" ID="txtTitle" FieldLabel="Title" Margin="0" AllowBlank="false" Width="600" Frame="true" />                        
                        <ext:TextArea runat="server" ID="txtDesc" FieldLabel="Description" Margin="0" AllowBlank="false" Width="600" MaxLengthText="148" Frame="true" />
                        <ext:ComboBox runat="server" ID="cmbServiceUnit" DisplayField="ServiceUnitName" ValueField="ServiceUnitID" FieldLabel="Request to Service Unit" Margin="0" Width="600" AllowBlank="false" Frame="true">
                            <Store>
                                <ext:Store runat="server" ID="storeSU">
                                    <Model>
                                        <ext:Model runat="server">
                                            <Fields>
                                                <ext:ModelField Name="ServiceUnitID" />
                                                <ext:ModelField Name="ServiceUnitName" />
                                            </Fields>
                                        </ext:Model>
                                    </Model>
                                </ext:Store>
                            </Store>
                        </ext:ComboBox>
                    </Items>
                    <Listeners>
                        <ValidityChange Handler="#{btnSave}.setDisabled(!valid);" />
                    </Listeners>
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
