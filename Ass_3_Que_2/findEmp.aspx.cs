using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class findEmp : System.Web.UI.Page
{
    SqlConnection cn;
    SqlCommand cmd;

    protected void Page_Load(object sender, EventArgs e)
    {
        cn = new SqlConnection(ConfigurationManager.ConnectionStrings["mycn"].ConnectionString);
        cmd = new SqlCommand();
    }

    protected void btn_search_Click(object sender, EventArgs e)
    {
        cn.Open();
        SqlCommand cmd = cn.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "SELECT * FROM TblEmp where Salary>'" + txt_salary.Text + "' and Designation='" + txt_designation.Text + "'";
        cmd.ExecuteNonQuery();

        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);

        da.Fill(dt);

        GridView1.DataSource = dt;
        GridView1.DataBind();
        cn.Close();
    }
}