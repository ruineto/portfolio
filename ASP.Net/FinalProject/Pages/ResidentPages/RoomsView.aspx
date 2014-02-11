<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RoomsView.aspx.cs" Inherits="FinalProject.RoomsView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:XmlDataSource ID="HouseDetailsXML" runat="server" EnableCaching="false" />
    <aside>
            <div style="margin-top:-20px">
                <label style="margin-bottom:10px"><asp:Label ID="weatherDescription" runat="server"></asp:Label></label>
                <asp:Image ID="weatherIcon" runat="server"/>
                <div><label style="display: inline-block;">Temperatura:</label><label style="display: inline-block; margin-left:10px"><asp:Label ID="weatherTemperature" runat="server"></asp:Label></label></div>
            </div>
        </aside>
    <asp:FormView id="HouseDetails" runat="server" DataSourceID="HouseDetailsXML" >
        <ItemTemplate>
            <label><h2><%# XPath("/home/name/text()") %></h2></label>
        </ItemTemplate>
    </asp:FormView>
    <br />
    <asp:XmlDataSource ID="roomsXML" TransformFile="~/XML/StateTransform.xslt" runat="server" XPath="//rooms/room" EnableCaching="false" />
    <script type="text/javascript" src="../../Scripts/js/jquery.cookie.js"></script>
    <script>
        // accordion menu
        $(function () {
            var act = 0;
            $("#accordion").accordion({
                collapsible: true,
                clearStyle: true,
                heightStyle: "content",
                autoHeight: false,
                create: function (event, ui) {
                    //get index in cookie on accordion create event
                    if ($.cookie('saved_index') != null) {
                        act = parseInt($.cookie('saved_index'));
                    }
                },
                activate: function (event, ui) {
                    //set cookie for current index on change event
                    var active = jQuery("#accordion").accordion('option', 'active');
                    $.cookie('saved_index', null);
                    $.cookie('saved_index', active);
                },
                active: parseInt($.cookie('saved_index'))
            });
        });



       
    </script>
    <div id="accordion">
        <asp:ListView ID="RoomsList" runat="server" DataSourceID="roomsXML">

            <ItemTemplate>

                <h2><label><%# XPath("name") %></label></h2>

                <div>
                    <asp:HiddenField runat="server" ID="RoomName" Value='<%# XPath("name") %>' />
                    <asp:ListView ID="ListView1" runat="server" OnPreRender="ListView1_PreRender">

                        <ItemTemplate>
                            <table>
                                <td style="width:200px">
                                    <asp:HiddenField runat="server" ID="DeviceName" Value='<%# XPath("name") %>' />
                                    <label><%# XPath("name") %></label></td>
                                <td>
                                    <div class="checkboxThree">
                                        <asp:CheckBox ID="CheckBox1" runat="server" Checked='<%# bool.Parse(XPath("state").ToString()) %>' AutoPostBack="true"  OnCheckedChanged="CheckBox1_CheckedChanged1" />
                                        <asp:label runat="server" ID="CheckboxLabel" AssociatedControlID="CheckBox1"></asp:label>
                                    </div>
                                </td>
                            </table>
                        </ItemTemplate>
                    </asp:ListView>
                </div>

            </ItemTemplate>
        </asp:ListView>
    </div>
</asp:Content>
