using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class updateStud : System.Web.UI.Page
{
    SqlConnection con;
    SqlDataAdapter da;
    DataSet ds;
    SqlCommand cmd;
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
        con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBStudentCon"].ConnectionString);
        hdnErnollno.Value = Request.QueryString["ernollno"];
        if (!IsPostBack)
        {
            load_data();
        }
    }
    protected void load_data()
    {
        Int64 Ernollno = Convert.ToInt64(Request.QueryString["ernollno"]);
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
        cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "Select * from Student where ernollno=" + Ernollno;
        dr = cmd.ExecuteReader();
        DataTable dt = new DataTable();
        dt.Load(dr);

        if (dt.Rows.Count > 0)
        {
            txtMono.Text = dt.Rows[0]["mobile"].ToString();
            txtEmail.Text = dt.Rows[0]["email"].ToString();
            txtDOB.Text = dt.Rows[0]["dob"].ToString();
        }
    }
    protected void Unnamed2_Click(object sender, EventArgs e)
    {
        cmd = new SqlCommand();
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "Update Student  set email='" + txtEmail.Text + "',mobile='" + txtMono.Text + "',dob='" + 
                            txtDOB.Text + "'  where ernollno=" + hdnErnollno.Value;
        int i = cmd.ExecuteNonQuery();
        if (i > 0)
        {
            Response.Redirect("~/ShowStudData.aspx");
        }
    }
}