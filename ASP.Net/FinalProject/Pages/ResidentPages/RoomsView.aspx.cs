using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Xml;

namespace FinalProject
{
    public partial class RoomsView : System.Web.UI.Page
    {
        string connectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\housesDB.mdf;Integrated Security=True";
        protected static XmlDocument HouseDoc;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                MembershipUser myObject = Membership.GetUser();
                if (myObject != null)
                {
                    object UserID = myObject.ProviderUserKey;
                    object returningValue;

                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand("XMLDoc_byUserID", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            SqlParameter userId = new SqlParameter("@userID", UserID);
                            cmd.Parameters.Add(userId);

                            con.Open();
                            returningValue = cmd.ExecuteScalar();
                            con.Close();
                        }
                    }
                    HouseDoc = new XmlDocument();
                    if (returningValue != null)
                    {
                        HouseDoc.InnerXml = (string)returningValue;
                        roomsXML.Data = HouseDoc.InnerXml;
                        roomsXML.DataBind();
                        RoomsList.DataBind();

                        HouseDetailsXML.Data = HouseDoc.InnerXml;
                        HouseDetailsXML.DataBind();
                        HouseDetails.DataBind();

                        RoomsList.Visible = true;
                        HouseDetails.Visible = true;
                    }
                    else
                    {
                        roomsXML.Data = "";
                        roomsXML.DataBind();
                        HouseDetailsXML.Data = "";
                        HouseDetailsXML.DataBind();

                        RoomsList.Visible = false;
                        HouseDetails.Visible = false;
                    }
                }
            }


            weatherService.Weather we = new weatherService.Weather();
            weatherService.WeatherReturn wr = new weatherService.WeatherReturn();

            wr = we.GetCityWeatherByZIP("97365");

            weatherTemperature.Text = ((int.Parse(wr.Temperature) - 32) * (5 / (float)9)).ToString("0") + "º";
            //weatherlist = we.GetWeatherInformation();
            switch (wr.Description)
            {
                case "Sunny": weatherDescription.Text = "Céu Limpo"; weatherIcon.ImageUrl = @"~/WeatherIcons/sunny.gif"; break;

                case "Drizzle": weatherDescription.Text = "Aguaçeiros"; weatherIcon.ImageUrl = @"~/WeatherIcons/drizzle.gif"; break;

                case "Thunder Storms": weatherDescription.Text = "Trovoada"; weatherIcon.ImageUrl = @"~/WeatherIcons/thunderstorms.gif"; break;

                case "Mostly Cloudy": weatherDescription.Text = "Muito Nublado"; weatherIcon.ImageUrl = @"~/WeatherIcons/mostlycloudy.gif"; break;

                case "Rain": weatherDescription.Text = "Chuva"; weatherIcon.ImageUrl = @"~/WeatherIcons/rain.gif"; break;

                default: weatherDescription.Text = ""; weatherIcon.ImageUrl = @"~/WeatherIcons/na.gif"; break;
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


        protected void ListView1_PreRender(object sender, EventArgs e)
        {
            ListView listview = (ListView)sender;
            ListViewItem item = (ListViewItem)listview.Parent;

            HtmlControl htmlDivControl = (HtmlControl)item.FindControl("CheckBox1");

            HiddenField hidden = (HiddenField)item.FindControl("RoomName");
            string str = "//rooms/room[name/text()='"+hidden.Value+"']/devices/device";
            XmlDataSource src = new XmlDataSource();
            src.Data = HouseDoc.InnerXml;
            src.TransformFile = "~/XML/StateTransform.xslt";
            src.XPath = str;
            src.DataBind();
            src.EnableCaching = false;
            src.ID = "srcDevices";
            listview.DataSource = src;
            listview.DataBind();
        }

        protected void CheckBox1_CheckedChanged1(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            ListViewItem item = (ListViewItem)box.Parent;
            HiddenField deviceName = (HiddenField)item.FindControl("DeviceName");

            XmlNode device = HouseDoc.SelectSingleNode("//rooms/room/devices/device[name[text()='" + deviceName.Value + "']]");
            if (device != null)
            {
                XmlNode state = device.SelectSingleNode("state");
                if (box.Checked)
                {
                    state.InnerText = "on";
                    
                }
                else
                {
                    state.InnerText = "off";
                }

                roomsXML.Data = HouseDoc.InnerXml;

                MembershipUser myObject = Membership.GetUser();
                if (myObject != null)
                {
                    object UserID = myObject.ProviderUserKey;




                   
                    string strhouseId = "";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT HouseId FROM Houses_Users WHERE UserId = '" + UserID+ "'", con))
                        {
                            cmd.CommandType = CommandType.Text;

                            
                            con.Open();
                            strhouseId = cmd.ExecuteScalar().ToString();
                            con.Close();
                        }

                        int houseId = int.Parse(strhouseId);
                        int doc = GetHomeDocID(houseId);

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
                }

                RoomsList.DataBind();
            }
        }


    }
}