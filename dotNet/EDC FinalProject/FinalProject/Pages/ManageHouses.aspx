<%@ Page Title="Gerir Casas" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="ManageHouses.aspx.cs" Inherits="FinalProject.Pages.ManageHouses" %>

<%@ Register TagPrefix="uc" TagName="EditHouse" Src="~/Pages/Controls/EditHouse.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <hgroup class="title">
        <h1><%: Title %></h1>
    </hgroup>

    <asp:SqlDataSource
        ID="SqlDataSource1"
        runat="server"
        DataSourceMode="DataReader"
        ConnectionString="<%$ ConnectionStrings:HouseSite%>"
        SelectCommand="SELECT HouseName,HouseID FROM Houses" EnableCaching="false"></asp:SqlDataSource>

    <!-- Lista das Casas -->
    <asp:Repeater ID="HousesRpter" runat="server" DataSourceID="SqlDataSource1" OnItemCommand="HousesRpter_ItemCommand">
        <HeaderTemplate>
            <table>
        </HeaderTemplate>
        <ItemTemplate>

            <tr>
                <td style="padding-top: 20px">
                    <label>
                        <asp:Label runat="server" ID="UserNameLabel"
                            Text='<%# Eval("HouseName") %>' /></label>
                    <asp:HiddenField ID="hiddenField" runat="server" Value='<%#Eval("HouseID")%>' />
                </td>

                <td>
                    <asp:LinkButton ID="lnkEdit" runat="server" CommandName="edit" CommandArgument='<%# Eval("HouseID") %>' CssClass="m-btn green icn-only">Edit <i class="icon-edit icon-white"></i>
                    </asp:LinkButton>
                    <asp:LinkButton Visible="false" ID="lnkUpdate" runat="server" CommandName="update" CommandArgument='<%# Eval("HouseID") %>' CssClass="m-btn blue icn-only">Update <i class="icon-upload icon-white"></i></asp:LinkButton>
                    <asp:LinkButton Visible="false" ID="lnkCancel" runat="server" CommandName="cancel" CommandArgument='<%# Eval("HouseID") %>' CssClass="m-btn red icn-only">Cancel <i class="icon-remove icon-white"></i></asp:LinkButton>
                    <asp:LinkButton ID="lnkDelete" runat="server" CommandName="delete" OnClientClick='javascript:return confirm("Tem a certeza que deseja apagar o utilizador?")'
                        CommandArgument='<%# Eval("HouseID") %>' CssClass="m-btn red icn-only">Delete <i class="icon-trash icon-white"></i>

                    </asp:LinkButton>
                </td>
            </tr>

        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>

    <!-- Botões -->
    <table>
        <tr>
            <td>
                <asp:LinkButton ID="AddButton" runat="server" CssClass="m-btn blue icn-only" OnClick="AddHouseBtn_Click">
                Adicionar Casa  <i class="m-icon-swapright m-icon-white"></i>
                </asp:LinkButton>
            </td>
        </tr>
    </table>


    <!-- Adicionar Casa -->
    <asp:XmlDataSource runat="server" ID="HouseDataSource" EnableCaching="false" />
    <div class="content-wrapper" style="background-color: lightgray;">
        <asp:FormView ID="AddHomeForm" runat="server" DefaultMode="Insert" DataSourceID="HouseDataSource" Visible="false" OnItemInserting="AddHomeForm_ItemInserting">
            <InsertItemTemplate>
                <table style="margin: 0px 10px 0px 10px">
                    <tr>
                        <td>
                            <h2>Adicionar Casa</h2>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <br />
                            <br />
                        </td>
                    </tr>
                    <tr>

                        <td>
                            <label>Name:</label></td>

                        <td>
                            <asp:TextBox ID="HouseNameInsertTextBox"
                                Text='<%# Bind("name") %>'
                                runat="server" CssClass="m-wrap m-ctrl-large" />
                        </td>
                    </tr>

                    <tr>
                        <td>
                            <h3>
                                <label style="font-size: larger; font-weight: bold">Localização</label></h3>
                        </td>
                    </tr>

                    <tr>

                        <td>
                            <label>Latitude:</label></td>

                        <td>
                            <asp:TextBox ID="Textbox1"
                                Text='<%# Bind("latitude") %>'
                                runat="server" CssClass="m-wrap m-ctrl-medium"/>
                        </td>


                    </tr>
                    <tr>
                        <td>
                            <label>Longitude:</label></td>
                        <td>
                            <asp:TextBox ID="Textbox2"
                                Text='<%# Bind("longitude") %>'
                                runat="server" CssClass="m-wrap m-ctrl-medium"/>
                        </td>
                    </tr>
                    <tr>

                        <td colspan="2">
                            <div style="background-color: darkgray">
                                <table border="1" style="margin: 20px 10px 10px 10px">
                                    <tr>
                                        <td>
                                            <h3>
                                                <label>Divisões</label></h3>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            <asp:XmlDataSource runat="server" ID="roomsXML" XPath="//rooms/room" EnableCaching="false"/>
                                            <asp:Repeater runat="server" ID="RoomsRpter" OnItemCommand="RoomsRpter_ItemCommand" OnLoad="RoomsRpter_Load" OnInit="RoomsRpter_Init">
<HeaderTemplate>
                                                    <table>
                                                </HeaderTemplate>
                                                <ItemTemplate>

                                                    <tr>
                                                        <td style="padding-top: 20px">

                                                            <asp:TextBox ID="EditNameTB" runat="server" BorderStyle="None" BackColor="Transparent" ReadOnly="true" CssClass="m-wrap m-ctrl-medium" Text='<%# XPath("name")%>'></asp:TextBox>

                                                        </td>

                                                        <td>
                                                            <asp:LinkButton ID="RoomEdit" runat="server" CommandName="edit" CommandArgument='<%# XPath("name")%>' CssClass="m-btn green icn-only">Edit <i class="icon-edit icon-white"></i>
                                                            </asp:LinkButton>
                                                            <asp:LinkButton Visible="false" ID="lnkUpdate" runat="server" CommandName="update" CommandArgument='<%# XPath("name")%>' CssClass="m-btn blue icn-only">Update <i class="icon-upload icon-white"></i></asp:LinkButton>
                                                            <asp:LinkButton Visible="false" ID="lnkCancel" runat="server" CommandName="cancel" CommandArgument='<%# XPath("name")%>' CssClass="m-btn red icn-only">Cancel <i class="icon-remove icon-white"></i></asp:LinkButton>
                                                            <asp:LinkButton ID="lnkDelete" runat="server" CommandName="delete" OnClientClick='javascript:return confirm("Tem a certeza que deseja apagar o utilizador?")'
                                                                CommandArgument='<%# XPath("name")%>' CssClass="m-btn red icn-only">Delete <i class="icon-trash icon-white"></i>

                                                            </asp:LinkButton>
                                                        </td>
                                                    </tr>

                                                </ItemTemplate>
                                                <FooterTemplate>
                                                    </table>
                                                </FooterTemplate>
                                            </asp:Repeater>
                                        </td>
                                    </tr>


                                    <tr class="m-wrap">
                                        <td>
                                            <label>Name:</label></td>
                                        <td>
                                            <asp:TextBox ID="RoomName"
                                                Text='<%# Bind("roomname") %>'
                                                runat="server" CssClass="m-wrap m-ctrl-large" />
                                        </td>

                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:LinkButton ID="AddRoomButton1"
                                                Text="Adicionar"
                                                CssClass="m-btn red sm" runat="server" OnClick="AddRoomButton1_Click">
                                                <i class="icon-plus icon-white"></i>  Adicionar
                                            </asp:LinkButton>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <br />
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:LinkButton ID="InsertButton"
                                Text="Adicionar"
                                CommandName="Insert"
                                runat="server" CssClass="m-btn blue big" OnClick="AddHouseButton_Click">
                                    <i class="icon-plus icon-white" style="margin-top:12px;"></i>  Adicionar
                            </asp:LinkButton>
                        </td>

                    </tr>
                </table>
            </InsertItemTemplate>

            <EditItemTemplate>
               <uc:EditHouse ID="EditHouse1" runat="server" OnInit="EditHouse1_Init" OnPreRender="EditHouse1_PreRender1"/>
            </EditItemTemplate>

        </asp:FormView>

        <div>

            <asp:LinkButton ID="AddHouseButton" runat="server" CssClass="m-btn blue big" OnClick="AddHouseButton_Click" Visible="false">
                Add House  <i class="m-icon-big-swapright m-icon-white"></i>
            </asp:LinkButton>
        </div>

    </div>
</asp:Content>

