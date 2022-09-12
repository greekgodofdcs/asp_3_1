using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ShowStudData : System.Web.UI.Page
{
    SqlConnection con;
    SqlDataAdapter da;
    DataSet ds;
    SqlCommand cmd;
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
        con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBStudentCon"].ConnectionString);
        load_gvStudDetail();
    }
    protected void load_gvStudDetail()
    {
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
        cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "Select ernollno,rollno,name,class_name,course_name,email,mobile,dob from Student s,Course c,Class cs where  c.course_id=cs.course_id and cs.class_id=s.class_id and c.course_id=s.course_id";
        dr = cmd.ExecuteReader();
        gvStudDetail.DataSource = dr;
        gvStudDetail.DataBind();
        cmd.Dispose();
        con.Close();
    }
    
    protected void gvStudDetail_RowEditing(object sender, GridViewEditEventArgs e)
    {
        var ernollno = gvStudDetail.DataKeys[e.NewEditIndex].Value.ToString();
        Response.Redirect("~/updateStud.aspx?ernollno=" + ernollno);
    }

    protected void gvStudDetail_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        var ernollno = gvStudDetail.DataKeys[e.RowIndex].Value.ToString();
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
        cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "delete  from  student where ernollno="+ernollno;
        int i = cmd.ExecuteNonQuery();
        if (i > 0)
        {
            load_gvStudDetail();
        }
    }
}