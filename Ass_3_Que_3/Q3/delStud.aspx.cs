using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class delStud : System.Web.UI.Page
{
    SqlConnection con;
    SqlDataAdapter da;
    DataSet ds;
    SqlCommand cmd;
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
        con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBStudentCon"].ConnectionString);
        if (!IsPostBack)
        {
            load_ddlCourse();
        }
    }
    protected void load_ddlCourse()
    {
        con.Open();
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

    protected void btnDel_Click(object sender, EventArgs e)
    {
        cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "delete from Student where rollno=" + txtRno.Text+" and  course_id="+ddlCourse.SelectedValue;
        con.Open();
        int i = cmd.ExecuteNonQuery();
        if (i>0)
        {
            Response.Write("record deleted successfully");
        }
        con.Close();
    }
}