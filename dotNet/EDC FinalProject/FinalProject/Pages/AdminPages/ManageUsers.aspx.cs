using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject.Pages.AdminPages
{
    public partial class ManageUsers : System.Web.UI.Page
    {
        string connectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\housesDB.mdf;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UsersRpter_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            LinkButton lnkUpdate = (LinkButton)e.Item.FindControl("lnkUpdate");
            LinkButton lnkCancel = (LinkButton)e.Item.FindControl("lnkCancel");
            LinkButton lnkEdit = (LinkButton)e.Item.FindControl("lnkEdit");
            LinkButton lnkDelete = (LinkButton)e.Item.FindControl("lnkDelete");
            DropDownList userRoleList = (DropDownList)e.Item.FindControl("userRoleList");
            DropDownList HouseList = (DropDownList)e.Item.FindControl("HouseList");
            HiddenField userIdField = (HiddenField)e.Item.FindControl("hiddenField");

            #region Update
            if (e.CommandName == "update")
            {

                    lnkCancel.Visible = false;
                    lnkUpdate.Visible = false;
                    lnkEdit.Visible = true;
                    userRoleList.Enabled = false;
                    HouseList.Enabled = false;
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand("UpdateUserRole", con))
                        {
                            string value = userRoleList.SelectedValue.ToString();
                            string user = userIdField.Value.ToString();

                            cmd.CommandType = CommandType.StoredProcedure;
                            SqlParameter userId = new SqlParameter("@userID",user);
                            SqlParameter roleId = new SqlParameter("@roleID",value);
                            cmd.Parameters.Add(userId);
                            cmd.Parameters.Add(roleId);
                            
                            con.Open();
                                cmd.ExecuteScalar();
                            con.Close();

                        }

                        using (SqlCommand cmd = new SqlCommand("InsertOrUpdateHouse", con))
                        {
                            string value = HouseList.SelectedValue.ToString();
                            string user = userIdField.Value.ToString();

                            cmd.CommandType = CommandType.StoredProcedure;
                            SqlParameter userId = new SqlParameter("@userID", user);
                            SqlParameter roleId = new SqlParameter("@houseID", value);
                            cmd.Parameters.Add(userId);
                            cmd.Parameters.Add(roleId);
                            
                            con.Open();
                                cmd.ExecuteScalar();
                            con.Close();

                        }
                    }

                    SqlDataSource1.DataBind();
                    SqlDataSource3.DataBind();
                    UsersRpter.DataBind();
            }
            #endregion

            #region Edit
            if (e.CommandName == "edit")
            {
                
                lnkCancel.Visible = true;
                lnkUpdate.Visible = true;
                lnkEdit.Visible = false;
                userRoleList.Enabled = true;
                HouseList.Enabled = true;
            }
            #endregion

            #region Cancel
            if (e.CommandName == "cancel")
            {
                lnkCancel.Visible = false;
                lnkUpdate.Visible = false;
                lnkEdit.Visible = true;
                userRoleList.Enabled = false;
                HouseList.Enabled = false;
            }
            #endregion

            #region Delete
            if (e.CommandName == "delete")
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("DeleteUser", con))
                    {
                        string value = userRoleList.SelectedValue.ToString();
                        string user = userIdField.Value.ToString();

                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter userId = new SqlParameter("@userID", user);
                       
                        cmd.Parameters.Add(userId);
                        
                        con.Open();
                        cmd.ExecuteScalar();
                        con.Close();

                    }
                }

                SqlDataSource1.DataBind();
                UsersRpter.DataBind();
            }
            #endregion
        }

        protected void UsersRpter_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            DropDownList rolelist = (DropDownList)UsersRpter.FindControl("userRoleList");
        }

        protected void userRoleList_PreRender(object sender, EventArgs e)
        {
            DropDownList rolelist = (DropDownList)sender;
            RepeaterItem repeateritem = (RepeaterItem)rolelist.Parent;
            string userid = ((HiddenField)repeateritem.FindControl("hiddenField")).Value.ToString();

            object returnValue;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand newcmd = new SqlCommand("SELECT [idRole] FROM [Users_Roles] WHERE [Users_Roles].idUser = '" + userid + "'", con))
                {
                    newcmd.CommandType = CommandType.Text;


                    con.Open();
                    returnValue = newcmd.ExecuteScalar();
                    con.Close();
                }
            }
            if (returnValue != null)
            {
                rolelist.Items.FindByValue(returnValue.ToString()).Selected = true;
            }
        }

        protected void HouseList_PreRender(object sender, EventArgs e)
        {
            DropDownList houselist = (DropDownList)sender;
            RepeaterItem repeateritem = (RepeaterItem)houselist.Parent;
            string userid = ((HiddenField)repeateritem.FindControl("hiddenField")).Value.ToString();

            object returnValue;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand newcmd = new SqlCommand("SELECT [HouseId] FROM [Houses_Users] where [Houses_Users].UserId = '" + userid + "'", con))
                {
                    newcmd.CommandType = CommandType.Text;


                    con.Open();
                        returnValue = newcmd.ExecuteScalar();
                    con.Close();
                }
            }
            if (returnValue != null)
            {
                houselist.Items.FindByValue(returnValue.ToString()).Selected = true;
            }
        }
        
    }
}