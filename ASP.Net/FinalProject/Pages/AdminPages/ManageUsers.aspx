<%@ Page Title="Gerir Utilizadores" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageUsers.aspx.cs" Inherits="FinalProject.Pages.AdminPages.ManageUsers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <hgroup class="title">
        <h1><%: Title %></h1>
    </hgroup>
    <asp:SqlDataSource
          id="SqlDataSource1"
          runat="server"
          DataSourceMode="DataReader"
          ConnectionString="<%$ ConnectionStrings:HouseSite%>"
          SelectCommand="SELECT UserName,UserId FROM Users" EnableCaching="false">
      </asp:SqlDataSource>

    <asp:SqlDataSource ID="SqlDataSource2" 
                           runat="server" 
                           ConnectionString="<%$ ConnectionStrings:HouseSite %>"
            SelectCommand="SELECT DISTINCT [Role],[id] FROM [UserRoles] ORDER BY [id]"></asp:SqlDataSource>

    <asp:SqlDataSource ID="SqlDataSource3" 
                           runat="server" 
                           ConnectionString="<%$ ConnectionStrings:HouseSite %>"
            SelectCommand="SELECT DISTINCT [HouseName],[HouseID] FROM [Houses] ORDER BY [HouseID]"></asp:SqlDataSource>

    <asp:Repeater ID="UsersRpter" runat="server" DataSourceID="SqlDataSource1" OnItemCommand="UsersRpter_ItemCommand">
        <HeaderTemplate>
               <table>
        </HeaderTemplate>
        <ItemTemplate>
                <tr>
                    <td style="padding-top:20px">
                        <label><asp:Label runat="server" ID="UserNameLabel" 
                      text='<%# Eval("UserName") %>' /></label>
                        <asp:HiddenField ID="hiddenField" runat="server" Value='<%#Eval("UserId")%>' />
                    </td>
                    
                    <td style="padding-top:20px">
                        <asp:DropDownList ID="userRoleList" 
                          runat="server" 
                          AutoPostBack="False" 
                          DataSourceID="SqlDataSource2"
                          DataTextField="Role" 
                          DataValueField="id" 
                          CssClass="m-wrap" Enabled="false" OnPreRender="userRoleList_PreRender">
                        </asp:DropDownList>
                    </td>
                    <td style="padding-top:20px">
                        <asp:DropDownList ID="HouseList" 
                          runat="server" 
                          AutoPostBack="False" 
                          DataSourceID="SqlDataSource3"
                          DataTextField="HouseName" 
                          DataValueField="HouseID"
                          CssClass="m-wrap" Enabled="false" OnPreRender="HouseList_PreRender">
                        </asp:DropDownList>
                    </td>
                    <td >
                        <asp:LinkButton ID="lnkEdit" runat="server" CommandName="edit" CommandArgument='<%# Eval("UserId") %>' CssClass="m-btn green icn-only">Edit <i class="icon-edit icon-white"></i>
                        </asp:LinkButton>
                        <asp:LinkButton Visible="false" ID="lnkUpdate" runat="server" CommandName="update" CommandArgument='<%# Eval("UserId") %>' CssClass="m-btn blue icn-only">Update <i class="icon-upload icon-white"></i></asp:LinkButton>
                        <asp:LinkButton Visible="false" ID="lnkCancel" runat="server" CommandName="cancel" CommandArgument='<%# Eval("UserId") %>' CssClass="m-btn red icn-only">Cancel <i class="icon-remove icon-white"></i></asp:LinkButton>
                        <asp:LinkButton ID="lnkDelete" runat="server" CommandName="delete" OnClientClick='javascript:return confirm("Tem a certeza que deseja apagar o utilizador?")' 
                    CommandArgument='<%# Eval("UserId") %>' CssClass="m-btn red icn-only">Delete <i class="icon-trash icon-white"></i>

                        </asp:LinkButton>
                    </td>
                </tr>
          
        </ItemTemplate>
         <FooterTemplate>
                </table>
         </FooterTemplate>
           </asp:Repeater>
</asp:Content>