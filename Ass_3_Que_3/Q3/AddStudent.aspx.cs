using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddStudent : System.Web.UI.Page
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
        if (dr.HasRows)
        {
            ddlCourse.DataSource = dr;
            ddlCourse.DataTextField = "course_name";
            ddlCourse.DataValueField = "course_id";
            ddlCourse.DataBind();
            ddlCourse.Items.Insert(0, new ListItem("--Select Course--", "0"));
        }
        else
        {
            Response.Write("Record Not Found");
        }
        con.Close();
    }

    protected void ddlCourse_SelectedIndexChanged(object sender, EventArgs e)
    {
        con.Open();
        cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "Select * from Class where course_id="+ddlCourse.SelectedIndex;
        dr = cmd.ExecuteReader();

        ddlClass.DataSource = dr;
        ddlClass.DataTextField = "class_name";
        ddlClass.DataValueField = "class_id";
        ddlClass.DataBind();
        ddlClass.Items.Insert(0,new ListItem( "--Select Class--","0"));
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        cmd = new SqlCommand();
        con.Open();
        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "INSERT INTO Student(rollno,name,class_id,course_id,email,mobile,dob)  VALUES (" + txtRno.Text + ",'" + 
            txtName.Text + "'," + ddlClass.SelectedValue + "," + ddlCourse.SelectedValue + ",'" + txtEmail.Text + "','" + 
            txtMono.Text + "','" + txtDOB.Text + "')";
        int i=cmd.ExecuteNonQuery();
        if (i > 0)
        {
            lblmsg.Text = "Recored Inserted Successfully";
            lblmsg.CssClass = "text-success";
        }
        else
        {
            lblmsg.Text = "Recored Can`t  Inserted";
            lblmsg.CssClass = "text-danger";
        }
        cmd.Dispose();
        con.Close();

        txtRno.Text = " ";
        txtDOB.Text = "";
        txtEmail.Text = "";
        txtMono.Text = "";
        txtName.Text = "";
        ddlClass.SelectedIndex = 0;
        ddlCourse.SelectedIndex = 0;
    }
}