using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
public partial class AddClass : System.Web.UI.Page
{
    SqlConnection con;
    SqlDataAdapter da;
    DataSet ds;
    SqlCommand cmd;
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
        con =new SqlConnection( ConfigurationManager.ConnectionStrings["DBStudentCon"].ConnectionString);
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
        if (dr.HasRows)
        {
            ddlCourse.DataSource = dr;
            ddlCourse.DataTextField = "course_name";
            ddlCourse.DataValueField = "course_id";
            ddlCourse.DataBind();
        }
        else
        {
            Response.Write("Record Not Found");
        }
        con.Close();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        cmd = new SqlCommand();
        con.Open();
        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "INSERT INTO Class(course_id,class_name) VALUES("+ddlCourse.SelectedIndex+",'"+txtClass.Text+"')";
        int i = cmd.ExecuteNonQuery();
        if (i > 0)
        {
            lblmsg.Text = "Class Added Successfully...!";
            lblmsg.CssClass = "text-success";
        }else
        {
            lblmsg.Text = "Class Can't be Added...!";
            lblmsg.CssClass = "text-danger";
        }
        cmd.Dispose();
        con.Close();
        
        txtClass.Text = " ";
        ddlCourse.SelectedIndex = 0;
        //da = new SqlDataAdapter("Select * from Class", con);
        //ds = new DataSet();
        //da.Fill(ds);
        //Response.Write(ds.Tables[0].Rows.Count);
        //DataRow dr = ds.Tables[0].NewRow();
        //dr[1] = 3; //Convert.ToInt16( ddlCourse.SelectedIndex.ToString());
        //dr[2] = txtClass.Text;
        //ds.Tables[0].Rows.Add(dr);
        //SqlCommandBuilder sqlcb = new SqlCommandBuilder(da);

        //da.UpdateCommand = sqlcb.GetUpdateCommand();

        //da.Update(ds.Tables[0]);
        //da.Dispose();
        //ds.Dispose();

    }
}