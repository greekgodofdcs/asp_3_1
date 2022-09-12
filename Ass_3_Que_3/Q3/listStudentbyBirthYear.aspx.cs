using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;

public partial class listStudentbyBirthYear : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
        con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBStudentCon"].ConnectionString);
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        con.Open();
        cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select * from Student where YEAR(dob)='"+txtYear.Text+"'";
        dr = cmd.ExecuteReader();
        gvStud.DataSource = dr;
        gvStud.DataBind();
    }
}