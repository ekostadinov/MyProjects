<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PetOwnersTask.Client._Default" %>

<%@ Register assembly="Infragistics45.Web.v13.1, Version=13.1.20131.2107, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" namespace="Infragistics.Web.UI.GridControls" tagprefix="ig" %>
<%@ Register assembly="Infragistics45.Web.v13.1, Version=13.1.20131.2107, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" namespace="Infragistics.Web.UI.NavigationControls" tagprefix="ig" %>
<%@ Register assembly="Infragistics45.Web.v13.1, Version=13.1.20131.2107, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" namespace="Infragistics.Web.UI.DataSourceControls" tagprefix="ig" %>
<%@ Register assembly="Infragistics45.Web.v13.1, Version=13.1.20131.2107, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" namespace="Infragistics.Web.UI" tagprefix="ig" %>


<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Because we are cutting-edge - Check out our advanced Log in Service. <%: Title %></h1>
            </hgroup>
            <p>
                &nbsp;</p>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <head>
        <link type="text/css" href="styles/MyCustomStyles.css" rel="stylesheet"/>
    </head>
    <div id="container">
    <h2>Here You can see the owners web data tree:</h2>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    
    <div id="owners-tree">
    <ig:WebDataTree ID="WebDataTree1" runat="server" Height="300px" Width="350px" DataSourceID="Source">
        <DataBindings>
            <ig:DataTreeNodeBinding DataMember="OwnersSql_DefaultView" TextField="OwnerName" />
            <ig:DataTreeNodeBinding DataMember="PetsSql_DefaultView" TextField="PetSpecies" />
        </DataBindings>
    </ig:WebDataTree>
    <ig:WebHierarchicalDataSource ID="Source" runat="server">
        <DataViews>
            <ig:DataView ID="OwnersSql_DefaultView" DataMember="DefaultView" DataSourceID="OwnersSql" />
            <ig:DataView ID="PetsSql_DefaultView" DataMember="DefaultView" DataSourceID="PetsSql" />
        </DataViews>
        <DataRelations>
            <ig:DataRelation ChildColumns="OwnerId" ChildDataViewID="PetsSql_DefaultView" ParentColumns="OwnerId" ParentDataViewID="OwnersSql_DefaultView" />
        </DataRelations>
    </ig:WebHierarchicalDataSource>
    </div>
    <asp:SqlDataSource ID="PetsSql" runat="server" ConnectionString="<%$ ConnectionStrings:NewConnectionString %>" SelectCommand="SELECT * FROM [Pets]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="OwnersSql" runat="server" ConnectionString="<%$ ConnectionStrings:NewConnectionString %>" SelectCommand="SELECT * FROM [Owners]"></asp:SqlDataSource>
    
    <p></p>
    <div id="pets-grid">
        
        <h4>Additional information about the pets:</h4>
       
    <ig:WebDataGrid ID="WebDataGrid1" runat="server" AutoGenerateColumns="False" DataSourceID="PetsSql" Height="385px" Width="550px" >
        <Columns>
            <ig:BoundDataField DataFieldName="PetId" Hidden="True" Key="PetId">
                <Header Text="PetId">
                </Header>
            </ig:BoundDataField>
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
            <ig:BoundDataField DataFieldName="PetGender" Hidden="True" Key="PetGender">
                <Header Text="PetGender">
                </Header>
            </ig:BoundDataField>
            <ig:BoundDataField DataFieldName="OwnerId" Hidden="True" Key="OwnerId">
                <Header Text="OwnerId">
                </Header>
            </ig:BoundDataField>
        </Columns>
        <Behaviors>
            <ig:Paging PageSize="10" />
        </Behaviors>
    </ig:WebDataGrid>   
        <h4 id="details">For more pets details, please Login or Register and press <img src="/Images/PetsButton.png" alt="pets-link" width="60px" height="40px"/> button in Your User Account menu. </h4>        
    </div>

    <div id="footer"></div>
        
    <script>
        $("#container").css('background-image', 'url("/Images/Pets-logo.jpg")');
    </script>

    <script>    
           $("#footer").css("height", "300px");

           $("#owners-tree").css("position", "absolute");
           $("#owners-tree").css("left", "50px");

           var petsGrid = "#pets-grid";
           $(petsGrid).css("position", "absolute");
           $(petsGrid).css("height", "300px");
           $(petsGrid).css("top", "400px");
           $(petsGrid).css(" overflow-y", "scrollable");
           $(petsGrid).css("display", "none");
           $('#details').css("color", "blue");
           
           $("ul li ul li a").hover(function DislayGrid() {
            $(petsGrid).css("display", "inline");
            $(petsGrid).css("left", "450px");

            }, function HideGrid() {
                $(petsGrid).css("display", "none");
           });
        
        $("ul li a").hover(function ChangeBackground() {
            $("ul li ul li a").css("background-color", "#0094ff");
        });

        //not working properly
        $("ul li ul li a").click( function ChangeGridDisplay() {
            $(petsGrid).css("display", "inline");
            function HideGrid(){
                petsGrid = '';
            };
        });
    </script>   
   </div>
        <p></p>
        
</asp:Content>


