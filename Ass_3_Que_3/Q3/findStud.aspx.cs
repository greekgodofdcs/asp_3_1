using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class findStud : System.Web.UI.Page
{
    SqlConnection con;
    SqlDataAdapter da;
    DataSet ds;
    SqlCommand cmd;
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
        con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBStudentCon"].ConnectionString);
    }
    protected void load_ddlCourse()
    {
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
        cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "Select * from Course";
        dr = cmd.ExecuteReader();

        ddlCourse.DataSource = dr;
        ddlCourse.DataTextField = "course_name";
        ddlCourse.DataValueField = "course_id";
        ddlCourse.DataBind();
        ddlCourse.Items.Insert(0, new ListItem("--Select Course--", "0"));

        con.Close();
    }


    protected void btnFind_Click(object sender, EventArgs e)
    {
        con.Open();
        cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
        if (ddlCourse.Visible)
        {
            cmd.CommandText = "select * from Student where name='" + txtName.Text + "' and course_id=" + ddlCourse.SelectedValue;
            dr = cmd.ExecuteReader();
            gvstud.DataSource = dr;
            gvstud.DataBind();
        }
        else
        {
            cmd.CommandText = "Select * from Student where name='" + txtName.Text + "'";
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            int i = dt.Rows.Count;
            if (i > 1)
            {
                ddlCourse.Visible = true;
                lblCourse.Visible = true;
                load_ddlCourse();
            }
            else
            {
                gvstud.DataSource = dr;
                gvstud.DataBind();
            }
        }
    }
}