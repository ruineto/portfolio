using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace FinalProject.Pages.Controls
{
   
    public partial class EditHouse : System.Web.UI.UserControl
    {
        private static XmlDocument housedoc;
        private static bool flagEdit = true;
        public XmlDocument HouseDoc { get { return housedoc; } set { housedoc = value; } }
      
        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    if (!IsPostBack)
        //    {

        //    }
        //}


      

        protected void roomsEdit_PreRender(object sender, EventArgs e)
        {
            if (flagEdit)
            {
                roomsXML.Data = HouseDoc.InnerXml;
                roomsXML.DataBind();
                roomsEdit.DataSourceID = null;
                roomsEdit.DataSource = roomsXML;
                roomsEdit.DataBind();
            }
        }

        protected void roomsEdit_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            LinkButton lnkUpdate = (LinkButton)e.Item.FindControl("lnkUpdate");
            LinkButton lnkCancel = (LinkButton)e.Item.FindControl("lnkCancel");
            LinkButton lnkEdit = (LinkButton)e.Item.FindControl("RoomEdit");
            LinkButton lnkDelete = (LinkButton)e.Item.FindControl("lnkDelete");
           
            TextBox txtName = (TextBox)e.Item.FindControl("EditNameTB");
            #region Edit
            if (e.CommandName == "edit")
            {

                lnkCancel.Visible = true;
                lnkUpdate.Visible = true;
                lnkEdit.Visible = false;

                txtName.BorderStyle = BorderStyle.Solid;
                txtName.BackColor = System.Drawing.Color.White;
                txtName.ReadOnly = false;
                flagEdit = false;
            }
            #endregion

            #region Update
            if (e.CommandName == "update")
            {
                lnkCancel.Visible = false;
                lnkUpdate.Visible = false;
                lnkEdit.Visible = true;



                string oldname = (string)e.CommandArgument;

                XmlNode sourceSelected = HouseDoc.SelectSingleNode("//rooms/room[name[text() ='"
                + oldname + "']]");

                sourceSelected.ChildNodes[0].InnerText = txtName.Text;

                roomsXML.EnableCaching = false;
                roomsXML.Data = HouseDoc.InnerXml;
                roomsXML.DataBind();
                ((Repeater)source).DataBind();

                txtName.BorderStyle = BorderStyle.None;
                txtName.BackColor = System.Drawing.Color.Transparent;
                txtName.ReadOnly = true;

                flagEdit = true;
            }
            #endregion

            #region Cancel
            if (e.CommandName == "cancel")
            {
                lnkCancel.Visible = false;
                lnkUpdate.Visible = false;
                lnkEdit.Visible = true;

                txtName.BorderStyle = BorderStyle.None;
                txtName.BackColor = System.Drawing.Color.Transparent;
                txtName.ReadOnly = true;

                roomsXML.EnableCaching = false;
                roomsXML.Data = HouseDoc.InnerXml;
                roomsXML.DataBind();
                ((Repeater)source).DataBind();
                flagEdit = true;
            }
            #endregion

            #region Delete
            if (e.CommandName == "delete")
            {
                string sourceToDelete = (string)e.CommandArgument;


                XmlNode room2delete = HouseDoc.SelectSingleNode("//rooms/room[name[text() ='"
                + sourceToDelete + "']]");

                XmlNode rooms = HouseDoc.SelectSingleNode("//rooms");
                rooms.RemoveChild(room2delete);



                roomsXML.EnableCaching = false;
                roomsXML.Data = HouseDoc.InnerXml;
                roomsXML.DataBind();
                ((Repeater)source).DataBind();
                flagEdit = true;
            }
            #endregion
        }

        protected void AddRoomBtn_Click(object sender, EventArgs e)
        {

            string roomnametext = RoomName.Text;

            if (roomnametext != "")
            {

                XmlNode rooms = HouseDoc.SelectSingleNode("//rooms");
                if (rooms == null)
                {
                    XmlElement roomsElem = HouseDoc.CreateElement("rooms");
                    XmlNode root = HouseDoc.SelectSingleNode("home");
                    root.AppendChild(roomsElem);

                    XmlElement room = HouseDoc.CreateElement("room");
                    XmlElement roomname = HouseDoc.CreateElement("name");
                    roomname.InnerText = roomnametext;

                    roomname.InnerText = RoomName.Text;

                    room.AppendChild(roomname);
                    roomsElem.AppendChild(room);

                }
                else
                {
                    XmlElement roomNode = HouseDoc.CreateElement("room");
                    XmlElement roomnameNode = HouseDoc.CreateElement("name");


                    roomnameNode.InnerText = RoomName.Text;

                    roomNode.AppendChild(roomnameNode);
                    rooms.AppendChild(roomNode);

                }

                roomsXML.Data = HouseDoc.InnerXml;
                
                roomsXML.DataBind();
                roomsEdit.DataSourceID = roomsXML.ID;
                roomsEdit.DataBind();


            }
        }


    }
}