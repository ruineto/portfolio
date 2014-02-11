using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace FinalProject.Pages
{
    public partial class ManageDevices : System.Web.UI.Page
    {
        string connectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\housesDB.mdf;Integrated Security=True";
        protected static XmlDocument HouseDoc;
        protected static int DocID;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (User.IsInRole("Administrator"))
            {
                SqlDataSource1.SelectCommand = "SELECT HouseName,HouseID FROM Houses";
            }
            if (User.IsInRole("ResidentManager"))
            {
                MembershipUser myObject = Membership.GetUser();
                object UserID = myObject.ProviderUserKey;
                SqlDataSource1.SelectCommand = "SELECT HouseName,HouseID FROM Houses WHERE HouseID = (SELECT HouseId FROM Houses_Users WHERE UserId = '" + UserID + "')";
            }
        }

        protected void HousesRpter_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            LinkButton lnkUpdate = (LinkButton)e.Item.FindControl("lnkUpdate");
            LinkButton lnkCancel = (LinkButton)e.Item.FindControl("lnkCancel");
            LinkButton lnkSelect = (LinkButton)e.Item.FindControl("lnkSelect");


            #region Select
            if (e.CommandName == "select")
            {

                lnkCancel.Visible = true;
                lnkUpdate.Visible = true;
                lnkSelect.Visible = false;

                int houseId = int.Parse(e.CommandArgument.ToString());
                int doc = GetHomeDocID(houseId);
                DocID = doc;
                object returningValue;
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand newcmd = new SqlCommand("SELECT theDoc FROM XMLDoc WHERE id=" + doc, con))
                    {
                        newcmd.CommandType = CommandType.Text;
                        con.Open();
                        returningValue = newcmd.ExecuteScalar();
                        con.Close();
                    }
                }

                HouseDoc = new XmlDocument();
                HouseDoc.InnerXml = (string)returningValue;

                roomsXML.Data = HouseDoc.InnerXml;
                roomsXML.DataBind();

                devicesXML.Data = HouseDoc.InnerXml;
                devicesXML.DataBind();

                DevicesRpter.DataSource = devicesXML;
                DevicesRpter.DataBind();

                DevicesRpter.Visible = true;
                DeviceAddForm.Visible = true;

            }
            #endregion

            #region Cancel
            if (e.CommandName == "cancel")
            {
                lnkCancel.Visible = false;
                lnkUpdate.Visible = false;
                lnkSelect.Visible = true;

                DevicesRpter.Visible = false;
                DeviceAddForm.Visible = false;
            }
            #endregion

            #region Update
            if (e.CommandName == "update")
            {
                int houseId = int.Parse(e.CommandArgument.ToString());
                int doc = GetHomeDocID(houseId);

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("UpdateHouseXML", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@theDoc", SqlDbType.Xml).Value = HouseDoc.OuterXml;
                        cmd.Parameters.Add("@Original_id", SqlDbType.Int).Value = doc;

                        con.Open();
                        cmd.ExecuteScalar();
                        con.Close();
                    }
                }

                lnkCancel.Visible = false;
                lnkUpdate.Visible = false;
                lnkSelect.Visible = true;
                DevicesRpter.Visible = false;
                DeviceAddForm.Visible = false;
            }
            #endregion
        }

        private int GetHomeDocID(int houseId)
        {
            using (var db = new Models.HouseContext())
            {
                int docId = (from house in db.House where house.HouseID.Equals(houseId) select house.docID).SingleOrDefault();
                return docId;
            }

        }

        protected void DevicesRpter_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            LinkButton lnkUpdate = (LinkButton)e.Item.FindControl("lnkUpdate");
            LinkButton lnkCancel = (LinkButton)e.Item.FindControl("lnkCancel");
            LinkButton lnkEdit = (LinkButton)e.Item.FindControl("lnkEdit");
            LinkButton lnkDelete = (LinkButton)e.Item.FindControl("lnkDelete");
            TextBox txtName = (TextBox)e.Item.FindControl("EditNameTB");
            HiddenField hiddenDeviceName = (HiddenField)e.Item.FindControl("hiddenDeviceName");

            DropDownList DeviceTypeList = (DropDownList)e.Item.FindControl("DeviceTypeList");
            DropDownList RoomList = (DropDownList)e.Item.FindControl("RoomList");

            #region Edit
            if (e.CommandName == "edit")
            {
                lnkCancel.Visible = true;
                lnkUpdate.Visible = true;
                lnkEdit.Visible = false;

                DeviceTypeList.Enabled = true;
                RoomList.Enabled = true;

                hiddenDeviceName.Value = txtName.Text;

                txtName.BorderStyle = BorderStyle.Solid;
                txtName.BackColor = System.Drawing.Color.White;
                txtName.ReadOnly = false;
            }
            #endregion

            #region Update
            if (e.CommandName == "update")
            {

                XmlNode device = HouseDoc.SelectSingleNode("//devices/device[name[text() = '" + hiddenDeviceName.Value + "']]");

                string selfName = txtName.Text;

                XmlNode testeName = HouseDoc.SelectSingleNode("//rooms/room/devices/device[name[text()='" + txtName.Text + "']]");
                if (testeName == null || selfName.Equals(hiddenDeviceName.Value))
                {

                    lnkCancel.Visible = false;
                    lnkUpdate.Visible = false;
                    lnkEdit.Visible = true;

                    XmlNode oldDeviceRoom = HouseDoc.SelectSingleNode("//rooms/room[devices/device[name[text() = '" + hiddenDeviceName.Value + "']]]");
                    if (oldDeviceRoom.SelectSingleNode("name").InnerText != RoomList.SelectedValue)
                    {

                        XmlNode oldRoomDevices = oldDeviceRoom.SelectSingleNode("devices");
                        oldRoomDevices.RemoveChild(device);

                        XmlNode newDeviceRoom = HouseDoc.SelectSingleNode("//rooms/room[name[text() = '" + RoomList.SelectedValue + "']]");
                        XmlNode newRoomDevices = newDeviceRoom.SelectSingleNode("devices");
                        if (newRoomDevices == null)
                        {
                            newRoomDevices = HouseDoc.CreateElement("devices");
                            newDeviceRoom.AppendChild(newRoomDevices);
                        }
                        newRoomDevices.AppendChild(device);
                    }

                    XmlNode type = device.SelectSingleNode("type");
                    type.InnerText = DeviceTypeList.SelectedValue;

                    XmlNode name = device.SelectSingleNode("name");
                    name.InnerText = txtName.Text;




                    txtName.BorderStyle = BorderStyle.None;
                    txtName.BackColor = System.Drawing.Color.Transparent;
                    txtName.ReadOnly = true;

                    devicesXML.DataBind();
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(),
                                                     "err_msg",
                                                     "alert('O nome do dispositivo já existe!');",
                                                     true);
                }

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
            }
            #endregion

            #region Delete
            if (e.CommandName == "delete")
            {

                XmlNode nodeToDelete = HouseDoc.SelectSingleNode("//rooms/room/devices/device[name[text()='" + e.CommandArgument.ToString() + "']]");
                XmlNode devices = HouseDoc.SelectSingleNode("//rooms/room/devices[device/name[text()='" + e.CommandArgument.ToString() + "']]");

                devices.RemoveChild(nodeToDelete);

                devicesXML.DataBind();
                devicesXML.Data = HouseDoc.InnerXml;
                roomsXML.Data = HouseDoc.InnerXml;
                DevicesRpter.DataSource = devicesXML;
                DevicesRpter.DataBind();
            }
            #endregion
        }

        protected void AddDeviceBtn_Click(object sender, EventArgs e)
        {
            DropDownList RoomList = (DropDownList)DeviceAddForm.FindControl("RoomList");
            TextBox DeviceNameInsertTextBox = (TextBox)DeviceAddForm.FindControl("DeviceNameInsertTextBox");
            DropDownList DeviceTypeList = (DropDownList)DeviceAddForm.FindControl("DeviceTypeList");

            XmlNode room = HouseDoc.SelectSingleNode("//rooms/room[name[text()='" + RoomList.SelectedValue + "']]");

            XmlNode devices = room.SelectSingleNode("devices");
            if (devices == null)
            {
                devices = HouseDoc.CreateElement("devices");
                room.AppendChild(devices);
            }

            XmlNode device = HouseDoc.CreateElement("device");

            XmlNode testeName = HouseDoc.SelectSingleNode("//rooms/room/devices/device[name[text()='" + DeviceNameInsertTextBox.Text + "']]");
            if (testeName == null)
            {
                XmlNode name = HouseDoc.CreateElement("name");
                name.InnerText = DeviceNameInsertTextBox.Text;
                device.AppendChild(name);

                XmlNode type = HouseDoc.CreateElement("type");
                type.InnerText = DeviceTypeList.SelectedValue;
                device.AppendChild(type);

                XmlNode state = HouseDoc.CreateElement("state");
                state.InnerText = "off";
                device.AppendChild(state);

                devices.AppendChild(device);

                devicesXML.DataBind();
                devicesXML.Data = HouseDoc.InnerXml;
                roomsXML.Data = HouseDoc.InnerXml;
                DevicesRpter.DataSource = devicesXML;
                DevicesRpter.DataBind();
            }
            else
            {
                ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(),
                                                  "err_msg",
                                                  "alert('O nome do dispositivo já existe!');",
                                                  true);
            }
        }

        protected void RoomList_PreRender(object sender, EventArgs e)
        {
            DropDownList RoomList = (DropDownList)sender;
            RepeaterItem repeateritem = (RepeaterItem)RoomList.Parent;
            TextBox EditNameTB = (TextBox)repeateritem.FindControl("EditNameTB");
            XmlNode room = HouseDoc.SelectSingleNode("//room[devices/device[name[text()='" + EditNameTB.Text + "']]]");
            if (room != null)
            {
                XmlNode roomname = room.SelectSingleNode("name");
                RoomList.SelectedValue = roomname.InnerText;
            }
        }

        protected void DeviceTypeList_PreRender(object sender, EventArgs e)
        {
            DropDownList RoomList = (DropDownList)sender;
            RepeaterItem repeateritem = (RepeaterItem)RoomList.Parent;
            TextBox EditNameTB = (TextBox)repeateritem.FindControl("EditNameTB");
            XmlNode device = HouseDoc.SelectSingleNode("//device[name[text()='" + EditNameTB.Text + "']]");
            if (device != null)
            {
                XmlNode type = device.SelectSingleNode("type");
                RoomList.SelectedValue = type.InnerText;
            }
        }

    }
}