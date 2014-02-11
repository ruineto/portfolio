<%@ Control Language="C#" CodeBehind="EditHouse.ascx.cs" Inherits="FinalProject.Pages.Controls.EditHouse" %>
<table style="margin: 0px 10px 0px 10px">
    <tr>
        <td>
            <h2>Editar Casa</h2>
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
            <asp:TextBox ID="HouseNameTextBox"
                Text='<%# XPath("//name") %>'
                runat="server" CssClass="m-wrap m-ctrl-large" placeholder="" />
        </td>
    </tr>
    <tr>
        <td>
            <h3>
                <label style="font-size: larger; font-weight: bold">Localização</label>
            </h3>
        </td>
    </tr>
    <tr>

                        <td>
                            <label>Latitude:</label></td>

                        <td>
                            <asp:TextBox ID="HouseLatTextBox"
                                Text='<%# XPath("//latitude") %>'
                                runat="server" CssClass="m-wrap m-ctrl-medium"/>
                        </td>


                    </tr>
                    <tr>
                        <td>
                            <label>Longitude:</label></td>
                        <td>
                            <asp:TextBox ID="HouseLongTextBox"
                                Text='<%# XPath("//longitude") %>'
                                runat="server" CssClass="m-wrap m-ctrl-medium" placeholder="" />
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
                                            <asp:Repeater runat="server" ID="roomsEdit" OnPreRender="roomsEdit_PreRender" OnItemCommand="roomsEdit_ItemCommand">
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
                                                Text=""
                                                runat="server" CssClass="m-wrap m-ctrl-large" />
                                        </td>

                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:LinkButton ID="AddRoomBtn"
                                                Text="Adicionar" OnClick="AddRoomBtn_Click"
                                                CssClass="m-btn red sm" runat="server">
                                                <i class="icon-plus icon-white"></i>  Add Room
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
    
   
    
</table>
