using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using FinalProject.Models;
using FinalProject.Pages.Controls;

namespace FinalProject.Pages
{
    public partial class ManageHouses : System.Web.UI.Page
    {
        string connectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\housesDB.mdf;Integrated Security=True";
        protected static XmlDocument  HouseDoc;
        
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
                AddButton.Visible = false;
            }

            if (!IsPostBack)
            {
                HouseDoc = new XmlDocument();

                HouseDataSource.Data = HouseDoc.InnerXml;
                HouseDataSource.DataBind();
                //AddHomeForm.DataSource = homeDatasource;
               
                XmlElement root = HouseDoc.CreateElement("home");
                XmlElement name = HouseDoc.CreateElement("name");

                XmlElement latitude = HouseDoc.CreateElement("latitude");

                XmlElement longitude = HouseDoc.CreateElement("longitude");

                root.AppendChild(name);
                root.AppendChild(latitude);
                root.AppendChild(longitude);

                HouseDoc.AppendChild(root); 
            }
        }

        private int GetHomeDocID(int houseId)
        {
            using (var db = new Models.HouseContext())
            {
                int docId = (from house in db.House where house.HouseID.Equals(houseId) select house.docID).SingleOrDefault();
                return docId;
            }

        }

        protected void AddHouseButton_Click(object sender, EventArgs e)
        {

        }

        

        protected void AddHomeForm_ItemInserting(object sender, FormViewInsertEventArgs e)
        {

            XmlNode name = HouseDoc.SelectSingleNode("home/name");
            name.InnerText = e.Values["name"].ToString();
            XmlNode longitude = HouseDoc.SelectSingleNode("home/longitude");
            longitude.InnerText = e.Values["longitude"].ToString();
            XmlNode latitude = HouseDoc.SelectSingleNode("home/latitude");
            latitude.InnerText = e.Values["latitude"].ToString();

            MembershipUser myObject = Membership.GetUser();
            object UserID = myObject.ProviderUserKey;

            using (var db = new Models.HouseContext())
            {
                try
                {

                    //var query = from b in db.House
                    //            orderby b.HouseID
                    //            select b;

                    //List<string> lst = new List<string>();
                    //XmlDocument HouseDoc = new XmlDocument();
                    //XmlElement root = HouseDoc.CreateElement("home");
                    //XmlElement nm = HouseDoc.CreateElement("name");
                    //root.AppendChild(nm);
                    //HouseDoc.AppendChild(root);



                    //XmlDataSource homeDatasource = new XmlDataSource();
                    //HouseDataSource.Data = HouseDoc.InnerXml;
                    //HouseDataSource.DataBind();
                    //AddHomeForm.DataBind();
                   


                    #region SQL interface


                    #region Insert xml into localDB
                    Object returnValue;
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand("InsertXmlDoc", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@theDoc", SqlDbType.Xml).Value = HouseDoc.OuterXml;


                            con.Open();
                            returnValue = cmd.ExecuteScalar();
                            con.Close();

                            //TextBox HouseNameInsertTextBox = (TextBox)AddHomeForm.FindControl("HouseNameInsertTextBox");

                            House newHouse = new House
                            {
                                HouseName = name.InnerText,
                                HouseDescription = "The best house in the world",
                                docID = (int)returnValue
                            };
                            House addedHouse = db.House.Add(newHouse);
                            db.SaveChanges();

                            int houseId = addedHouse.HouseID;

                            using (SqlCommand newcmd = new SqlCommand("INSERT INTO Houses_Users (HouseId, UserId) VALUES (@houseID, @userID)", con))
                            {
                                newcmd.CommandType = CommandType.Text;

                                newcmd.Parameters.Add("@houseID", SqlDbType.Int).Value = houseId;
                                newcmd.Parameters.Add("@userID", SqlDbType.UniqueIdentifier).Value = UserID;

                                con.Open();
                                    returnValue = newcmd.ExecuteScalar();
                                con.Close();
                            }
                        }
                    }
                    #endregion

                    #region Select from View
                    // Table to store the query results
                    //DataTable table = new DataTable();

                    //// Creates a SQL connection
                    //using (var connection = new SqlConnection(connectionString))
                    //{
                    //    connection.Open();

                    //    // Creates a SQL command
                    //    using (var command = new SqlCommand("SELECT * FROM Select_HouseName_XML", connection))
                    //    {
                    //        // Loads the query results into the table
                    //        table.Load(command.ExecuteReader());
                    //    }

                    //    connection.Close();
                    //}
                    #endregion

                    SqlDataSource1.DataBind();
                    HousesRpter.DataBind();
                    AddHomeForm.Visible = false;
                    #endregion

                    e.Cancel = true;
                }
                catch (DbEntityValidationException dbEx)
                {
                    Console.WriteLine(dbEx);
                }
            }
        }

        protected void AddRoomButton1_Click(object sender, EventArgs e)
        {
            XmlDataSource roomsXML = (XmlDataSource)AddHomeForm.FindControl("roomsXML");
            //roomsXML.Data = HouseDoc.InnerXml;

            TextBox RoomNameTB = (TextBox)AddHomeForm.FindControl("RoomName");
            string roomnametext = RoomNameTB.Text;

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

                    roomname.InnerText = RoomNameTB.Text;

                    room.AppendChild(roomname);
                    roomsElem.AppendChild(room);

                }
                else
                {
                    XmlElement roomNode = HouseDoc.CreateElement("room");
                    XmlElement roomnameNode = HouseDoc.CreateElement("name");

                    TextBox RoomNameTBNode = (TextBox)AddHomeForm.FindControl("RoomName");
                    roomnameNode.InnerText = RoomNameTBNode.Text;

                    roomNode.AppendChild(roomnameNode);
                    rooms.AppendChild(roomNode);


                }

                
                roomsXML.Data = HouseDoc.InnerXml;
                Repeater RoomRepeater = (Repeater)AddHomeForm.FindControl("RoomsRpter");

                roomsXML.DataBind();
                RoomRepeater.DataSourceID = roomsXML.ID;
                RoomRepeater.DataBind();

               
            }
        }

        protected void AddHouseBtn_Click(object sender, EventArgs e)
        {
            AddHomeForm.Visible = true;
            AddHomeForm.ChangeMode(FormViewMode.Insert);
        }

        private void AddHomeForm_ModeChanging(object sender, FormViewModeEventArgs e)
        {
            //switch (e.NewMode)
            //{
            //    case FormViewMode.Edit:
            //        AddHomeForm.ChangeMode(FormViewMode.Edit);
            //        break;
            //}
        }
        
        protected void HousesRpter_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            LinkButton lnkUpdate = (LinkButton)e.Item.FindControl("lnkUpdate");
            LinkButton lnkCancel = (LinkButton)e.Item.FindControl("lnkCancel");
            LinkButton lnkEdit = (LinkButton)e.Item.FindControl("lnkEdit");
            LinkButton lnkDelete = (LinkButton)e.Item.FindControl("lnkDelete");

            #region Edit
            if (e.CommandName == "edit")
            {

                lnkCancel.Visible = true;
                lnkUpdate.Visible = true;
                lnkEdit.Visible = false;
               
                int houseId = int.Parse(e.CommandArgument.ToString());
                int doc = GetHomeDocID(houseId);

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

                HouseDoc.InnerXml = (string)returningValue;
                
                XmlDataSource homeDatasource = new XmlDataSource();
                homeDatasource.Data = HouseDoc.InnerXml;
                homeDatasource.EnableCaching = false;
                homeDatasource.DataBind();
                AddHomeForm.DataSourceID = null;
                AddHomeForm.DataSource = homeDatasource;

                AddHomeForm.ChangeMode(FormViewMode.Edit);
                
                AddHomeForm.DataBind();
                AddHomeForm.Visible = true;
            }
            #endregion

            #region Update
            if (e.CommandName == "update")
            {
                lnkCancel.Visible = false;
                lnkUpdate.Visible = false;
                lnkEdit.Visible = true;


                EditHouse edit = (EditHouse)AddHomeForm.FindControl("EditHouse1");
                string HouseName = ((TextBox)edit.FindControl("HouseNameTextBox")).Text;
                string HouseLat = ((TextBox)edit.FindControl("HouseLatTextBox")).Text;
                string HouseLong = ((TextBox)edit.FindControl("HouseLongTextBox")).Text;

                int houseId = int.Parse(e.CommandArgument.ToString());
                
                House house = new House();
                house.HouseID = houseId;
                house.HouseName = HouseName;
                house.HouseDescription = "House Description";

                int docID = UpdateHouse(house);

                XmlNode name = HouseDoc.SelectSingleNode("home/name");
                name.InnerText = HouseName;
                XmlNode longitude = HouseDoc.SelectSingleNode("home/longitude");
                longitude.InnerText = HouseLong;
                XmlNode latitude = HouseDoc.SelectSingleNode("home/latitude");
                latitude.InnerText = HouseLat;
                
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("UpdateHouseXML", con))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter userId = new SqlParameter("@Original_id", docID);
                        SqlParameter roleId = new SqlParameter("@thedoc", HouseDoc.InnerXml);
                        cmd.Parameters.Add(userId);
                        cmd.Parameters.Add(roleId);

                        con.Open();
                            cmd.ExecuteScalar();
                        con.Close();

                    }
                }
                SqlDataSource1.DataBind();
                HousesRpter.DataBind();
                AddHomeForm.Visible = false;
            }

            


            #endregion

            #region Cancel
            if (e.CommandName == "cancel")
            {
                lnkCancel.Visible = false;
                lnkUpdate.Visible = false;
                lnkEdit.Visible = true;
                AddHomeForm.Visible = false;
            }
            #endregion

            #region Delete
            if (e.CommandName == "delete")
            {
                int houseId = int.Parse(e.CommandArgument.ToString());

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("DeleteHouse", con))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter userId = new SqlParameter("@houseID", houseId);
                        
                        cmd.Parameters.Add(userId);
                        
                        con.Open();
                            cmd.ExecuteScalar();
                        con.Close();

                    }
                }

                SqlDataSource1.DataBind();
                HousesRpter.DataBind();
            }
            #endregion
        }

        protected void RoomsRpter_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            LinkButton lnkUpdate = (LinkButton)e.Item.FindControl("lnkUpdate");
            LinkButton lnkCancel = (LinkButton)e.Item.FindControl("lnkCancel");
            LinkButton lnkEdit = (LinkButton)e.Item.FindControl("RoomEdit");
            LinkButton lnkDelete = (LinkButton)e.Item.FindControl("lnkDelete");
            XmlDataSource roomsXML = (XmlDataSource)AddHomeForm.FindControl("roomsXML");
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

            }
            #endregion

            #region Delete
            if (e.CommandName == "delete")
            {
                string sourceToDelete = (string)e.CommandArgument;

                
                XmlNode room2delete = HouseDoc.SelectSingleNode("//rooms/room[name[text() ='"
                + sourceToDelete + "']]");

                XmlNode rooms = HouseDoc.SelectSingleNode("//rooms") ;
                rooms.RemoveChild(room2delete);


               
                roomsXML.EnableCaching = false;
                roomsXML.Data = HouseDoc.InnerXml;
                roomsXML.DataBind();
                ((Repeater)source).DataBind();
            }
            #endregion
        }

        protected void RoomsRpter_Load(object sender, EventArgs e)
        {
          
        }

        protected void RoomsRpter_Init(object sender, EventArgs e)
        {
            XmlDataSource roomsXML = (XmlDataSource)AddHomeForm.FindControl("roomsXML");
            roomsXML.Data = HouseDoc.InnerXml;
        }

        protected void EditHouse1_PreRender1(object sender, EventArgs e)
        {
            
        }

        private int UpdateHouse(House house)
        {
            int docID;

            try
            {
                using (var db = new Models.HouseContext())
                {
                    var ho = db.House.FirstOrDefault(c => c.HouseID == house.HouseID);

                    ho.HouseName = house.HouseName;
                    ho.HouseDescription = house.HouseDescription;
                    docID = ho.docID;
                    db.SaveChanges();
                    return docID;
                }
            }
            catch (DbEntityValidationException dbEx)
            {
                Console.WriteLine(dbEx);
                return 0;
            }

            
        }

        protected void EditHouse1_Init(object sender, EventArgs e)
        {
            
                EditHouse edit = (EditHouse)AddHomeForm.FindControl("EditHouse1");
                edit.HouseDoc = HouseDoc;
            
        }
    }
}