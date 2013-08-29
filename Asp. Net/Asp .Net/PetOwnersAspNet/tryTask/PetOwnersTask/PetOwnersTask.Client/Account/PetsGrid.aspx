<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PetsGrid.aspx.cs" Inherits="PetOwnersTask.Client.Account.PetsGrid" %>

<%@ Register assembly="Infragistics45.Web.v13.1, Version=13.1.20131.2107, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" namespace="Infragistics.Web.UI.GridControls" tagprefix="ig" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pets web data grid</title>
    <link href="../styles/GridStyles.css" rel="stylesheet" type="text/css"/>
</head>
<body>
    <div id="header">
        <p></p>
        <div id="header-logo">            
         <img src="/Images/pets-logo-mini.jpg" alt="pets-logo-mini" width="150" height="90"/>
        </div>
        <h2>Simple Asp .Net Web task</h2>
    </div>
        <form id="form1" runat="server">
        <h2>Pets data as grid, please select page.</h2>
    <div id="grid-container">
        <asp:ScriptManager ID="sm" runat="server">
        </asp:ScriptManager>
        
        <ig:WebDataGrid ID="wdg" runat="server" AutoGenerateColumns="False" DataSourceID="PetsDb" Height="350px" Width="833px">
            <Columns>
                <ig:BoundDataField DataFieldName="PetName" Key="PetName">
                    <Header Text="PetName">
                    </Header>
                </ig:BoundDataField>
                <ig:BoundDataField DataFieldName="PetSpecies" Key="PetSpecies">
                    <Header Text="PetSpecies">
                    </Header>
                </ig:BoundDataField>
                <ig:BoundDataField DataFieldName="PetAge" Key="PetAge">
                    <Header Text="PetAge">
                    </Header>
                </ig:BoundDataField>
                <ig:BoundDataField DataFieldName="PetGender" Key="PetGender">
                    <Header Text="PetGender">
                    </Header>
                </ig:BoundDataField>
                <ig:BoundDataField DataFieldName="OwnerId" Key="OwnerId">
                    <Header Text="OwnerId">
                    </Header>
                </ig:BoundDataField>
            </Columns>
            <Behaviors>
                <ig:Paging PageIndex="3" PagerAppearance="Both" PageSize="5" CurrentPageLinkCssClass="current" PageLinkCssClass="link" PagerCssClass="pager" EnableInheritance="True">
                </ig:Paging>
                <ig:Sorting SortingMode="Multi">
                </ig:Sorting>
                <ig:Filtering>
                </ig:Filtering>
                <ig:Activation ActiveCellCssClass="activeCell" ActiveRowCssClass="activeRow">
                </ig:Activation>
            </Behaviors>
        </ig:WebDataGrid>
        <asp:SqlDataSource ID="PetsDb" runat="server" ConnectionString="<%$ ConnectionStrings:NewConnectionString %>" SelectCommand="SELECT [PetName], [PetSpecies], [PetAge], [PetGender], [OwnerId] FROM [Pets] ORDER BY [PetName]"></asp:SqlDataSource>
        
    </div>
    </form>
    <p></p>
    <p></p>
    <footer>
         <div>
                <p>&copy; <%: DateTime.Now.Year %> - E.Kostadinov ASP.NET Application</p>
            </div>
    </footer>
</body>
    
</html>
