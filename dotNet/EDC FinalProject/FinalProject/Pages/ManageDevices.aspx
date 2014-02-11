<%@ Page Title="Gerir Dispositivos" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="ManageDevices.aspx.cs" Inherits="FinalProject.Pages.ManageDevices" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <hgroup class="title">
        <h1><%: Title %></h1>
    </hgroup>

    <asp:SqlDataSource
        ID="SqlDataSource1"
        runat="server"
        DataSourceMode="DataReader"
        ConnectionString="<%$ ConnectionStrings:HouseSite%>"
        EnableCaching="false"></asp:SqlDataSource>

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
                    <asp:LinkButton ID="lnkSelect" runat="server" CommandName="select" CommandArgument='<%# Eval("HouseID") %>' CssClass="m-btn green icn-only">Select <i></i>
                    </asp:LinkButton>
                    <asp:LinkButton Visible="false" ID="lnkUpdate" runat="server" CommandName="update" CommandArgument='<%# Eval("HouseID") %>' CssClass="m-btn blue icn-only">Update <i class="icon-upload icon-white"></i></asp:LinkButton>
                    <asp:LinkButton Visible="false" ID="lnkCancel" runat="server" CommandName="cancel" CommandArgument='<%# Eval("HouseID") %>' CssClass="m-btn red icn-only">Cancel <i class="icon-remove icon-white"></i></asp:LinkButton>
                    
                </td>
            </tr>

        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>

    <asp:XmlDataSource ID="devicesXML" runat="server" XPath="//devices/device" EnableCaching="false"/>
    <br />
    <br />
     
    <asp:XmlDataSource ID="roomsXML" runat="server" XPath="//rooms/room" TransformFile="/XML/RoomsTransform.xslt" EnableCaching="false"/>
    <div class="content-wrapper" style="background-color: lightgray;"> 
    <asp:Repeater ID="DevicesRpter" runat="server" OnItemCommand="DevicesRpter_ItemCommand">
        <HeaderTemplate>
               <table style="margin: 0px 10px 0px 10px;">
                   <tr>
                  <td>
                      <label><h4>Dispositivos:</h4></label>
                  </td>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
                
                <tr>
                    <td style="padding-top: 20px">
                        <asp:TextBox ID="EditNameTB" runat="server" BorderStyle="None" BackColor="Transparent" ReadOnly="true" CssClass="m-wrap m-ctrl-medium" Text='<%# XPath("name")%>'></asp:TextBox>
                    </td>
                    <td style="padding-top:20px">
                            <asp:DropDownList ID="DeviceTypeList" 
                              runat="server" 
                              AutoPostBack="False" 
                              CssClass="m-wrap" Enabled="false" OnPreRender="DeviceTypeList_PreRender">
                                <asp:ListItem Selected="True" Value="Porta"> Porta </asp:ListItem>
                                <asp:ListItem Value="Janela"> Janela </asp:ListItem>
                                <asp:ListItem Value="Lampada"> Lâmpada </asp:ListItem>
                                <asp:ListItem Value="Electrodomestico"> Electrodoméstico </asp:ListItem>
                            </asp:DropDownList>
                    </td>
                    <td style="padding-top:20px">
                            <asp:DropDownList ID="RoomList" 
                              runat="server" 
                              AutoPostBack="False" 
                              DataSourceID="roomsXML"
                              DataValueField="name" DataTextField="name"
                              
                              CssClass="m-wrap" Enabled="false" OnPreRender="RoomList_PreRender">
                            </asp:DropDownList>
                        <asp:HiddenField Value="" runat="server" ID="hiddenDeviceName" />
                    </td>
                   
                        
                    
                    <td>
                        <asp:LinkButton ID="lnkEdit" runat="server" CommandName="edit" CommandArgument='<%# XPath("name") %>' CssClass="m-btn green icn-only">Edit <i class="icon-edit icon-white"></i>
                        </asp:LinkButton>
                        <asp:LinkButton Visible="false" ID="lnkUpdate" runat="server" CommandName="update" CommandArgument='<%# XPath("name") %>' CssClass="m-btn blue icn-only">Update <i class="icon-upload icon-white"></i></asp:LinkButton>
                        <asp:LinkButton Visible="false" ID="lnkCancel" runat="server" CommandName="cancel" CommandArgument='<%# XPath("name") %>' CssClass="m-btn red icn-only">Cancel <i class="icon-remove icon-white"></i></asp:LinkButton>
                        <asp:LinkButton ID="lnkDelete" runat="server" CommandName="delete" OnClientClick='javascript:return confirm("Tem a certeza que deseja apagar o dispositivo?")' 
                    CommandArgument='<%# XPath("name") %>' CssClass="m-btn red icn-only">Delete <i class="icon-trash icon-white"></i>

                        </asp:LinkButton>
                    </td>
                    
                </tr>
          
        </ItemTemplate>
         <FooterTemplate>
                </table>
         </FooterTemplate>
     </asp:Repeater>

        <div style="margin: 0px 10px 10px 10px; background-color:darkgray">
    <asp:FormView ID="DeviceAddForm" runat="server" DefaultMode="Insert" Visible="false">
            <InsertItemTemplate>
                <table style="margin: 0px 20px 0px 10px;">
                    <tr>
                        <td><label><h4>Novo Dispositivo:</h4></label></td>
                    </tr>
                    <tr>
                        <td>
                            <label>Nome:</label>
                        </td>
                        <td>
                            <asp:TextBox ID="DeviceNameInsertTextBox"
                                Text='<%# Bind("name") %>'
                                runat="server" CssClass="m-wrap m-ctrl-large" />
                        </td>
                    </tr>
                    
                    <tr>
                        <td>
                            <label>Tipo:</label>
                        </td>
                        
                        <td style="padding-top:20px">
                            <asp:DropDownList ID="DeviceTypeList" 
                              runat="server" 
                              AutoPostBack="False" 
                              CssClass="m-wrap">
                                <asp:ListItem Selected="True" Value="Porta"> Porta </asp:ListItem>
                                <asp:ListItem Value="Janela"> Janela </asp:ListItem>
                                <asp:ListItem Value="Lampada"> Lâmpada </asp:ListItem>
                                <asp:ListItem Value="Electrodomestico"> Electrodoméstico </asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label>Divisão:</label>
                        </td>
                        <td style="padding-top:10px">
                            <asp:DropDownList ID="RoomList" 
                              runat="server" 
                              AutoPostBack="False" 
                              DataSourceID="roomsXML"
                              DataValueField="name" DataTextField="name"
                              CssClass="m-wrap">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:LinkButton ID="AddDeviceBtn"
                                Text="Adicionar"
                                CssClass="m-btn red sm" runat="server" OnClick="AddDeviceBtn_Click">
                                <i class="icon-plus icon-white"></i>  Adicionar
                            </asp:LinkButton>
                        </td>
                    </tr>
                </table>
            </InsertItemTemplate>
     </asp:FormView>
            </div>
        </div>
</asp:Content>