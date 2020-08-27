<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <dx:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" KeyFieldName="OrderID" OnCustomUnboundColumnData="ASPxGridView1_CustomUnboundColumnData"
                OnAutoFilterCellEditorCreate="ASPxGridView1_AutoFilterCellEditorCreate" OnProcessColumnAutoFilter="ASPxGridView1_ProcessColumnAutoFilter" OnHeaderFilterFillItems="ASPxGridView1_HeaderFilterFillItems"
                OnCustomColumnDisplayText="ASPxGridView1_CustomColumnDisplayText" OnAutoFilterCellEditorInitialize="ASPxGridView1_AutoFilterCellEditorInitialize">
                <Settings ShowFilterBar="Visible" ShowFilterRow="true" />
                <Columns>
                    <dx:GridViewDataTextColumn FieldName="OrderID" ReadOnly="True" VisibleIndex="0">
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="CustomerID" VisibleIndex="1">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="EmployeeID" VisibleIndex="2">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Month" VisibleIndex="3" UnboundType="Integer" Caption="Order Date">
                        <Settings AllowHeaderFilter="True" HeaderFilterMode="CheckedList" />
                    </dx:GridViewDataTextColumn>
                </Columns>
            </dx:ASPxGridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server"
                SelectCommand="SELECT [OrderID], [CustomerID], [EmployeeID], [OrderDate] FROM [Orders]" ConnectionString="<%$ ConnectionStrings:ConnStr %>" />
        </div>
    </form>
</body>
</html>
