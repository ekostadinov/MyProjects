<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
    <asp:ScriptManager runat="server" ID="SM1">
    </asp:ScriptManager>
    <telerik:RadAjaxPanel runat="server" ID="RadAjaxPAnel1" LoadingPanelID="RALP1" Width="600px">
        <telerik:RadGrid AutoGenerateColumns="false" OnNeedDataSource="RadGrid1_NeedDataSource" ID="RadGrid1" AllowPaging="true" AllowSorting="true"
            AllowFilteringByColumn="True" ShowFooter="True" runat="server" PageSize="5"  OnItemCommand="RadGrid1_ItemCommand" OnItemCreated="RadGrid1_ItemCreated" Skin="Silk">
            <MasterTableView CommandItemDisplay="Top" DataKeyNames="ProductID">
                <PagerStyle Mode="NextPrevAndNumeric" PageSizeControlType="RadComboBox" PageSizes="5,10,15,20"></PagerStyle>
                <Columns>
                    <telerik:GridNumericColumn Aggregate="Count" DataField="ProductID" HeaderText="ProductID"
                        SortExpression="ProductID" UniqueName="ProductID" ReadOnly="true" InsertVisiblityMode="AlwaysHidden">
                    </telerik:GridNumericColumn>
                    <telerik:GridBoundColumn DataField="ProductName" FooterAggregateFormatString="" HeaderText="Product name" Aggregate="First" SortExpression="ProductName"
                        UniqueName="ProductName">
                    </telerik:GridBoundColumn>
                    <telerik:GridNumericColumn Aggregate="Sum" DataField="UnitPrice" HeaderText="Unit price" FooterAggregateFormatString="Sum : {0:C2}"
                        SortExpression="UnitPrice" UniqueName="UnitPrice" DataFormatString="{0:C}">
                    </telerik:GridNumericColumn>
                    <telerik:GridEditCommandColumn ButtonType="ImageButton"></telerik:GridEditCommandColumn>
                    <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" ConfirmText="Are you sure you want delete this item?"></telerik:GridButtonColumn>
                </Columns>
                <EditFormSettings>
                    <EditColumn ButtonType="ImageButton"></EditColumn>
                </EditFormSettings>
            </MasterTableView>
        </telerik:RadGrid>
        <br />
        <asp:Button ID="Button1" Text="Reset Data to its initial state." runat="server" OnClick="Button1_Click1" />
    </telerik:RadAjaxPanel>
        <telerik:RadAjaxLoadingPanel runat="server" ID="RALP1" Skin="Silk"></telerik:RadAjaxLoadingPanel>
    </form>
</body>
</html>
