using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


public partial class updateEmp : System.Web.UI.Page
{
    SqlConnection cn;
    SqlCommand cmd;
    string str;

    protected void Page_Load(object sender, EventArgs e)
    {
        cn = new SqlConnection(ConfigurationManager.ConnectionStrings["mycn"].ConnectionString);
        cmd = new SqlCommand();
        show();
    }

    protected void clear()
    {
        txt_emp_id.Text = "";
        txt_designation.Text = "";
        txt_department.Text = "";
        txt_salary.Text = "";
    }

    protected void show()
    {
        cn.Open();
        SqlCommand cmd = cn.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "SELECT * FROM TblEmp";
        cmd.ExecuteNonQuery();

        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);

        da.Fill(dt);

        GridView1.DataSource = dt;
        GridView1.DataBind();
        cn.Close();

    }


    protected void btn_search_Click(object sender, EventArgs e)
    {
        cn.Open();
        SqlCommand cmd = cn.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "SELECT * FROM TblEmp WHERE EmpNo = " + txt_emp_id.Text + "";
        cmd.ExecuteNonQuery();

        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);

        da.Fill(dt);
        foreach (DataRow r in dt.Rows)
        {
            txt_designation.Text = r["designation"].ToString();
            txt_department.Text = r["dept"].ToString();
            txt_salary.Text = r["Salary"].ToString();
        }

        cn.Close();
    }

    protected void btn_insert_dept_Click(object sender, EventArgs e)
    {
        cn.Open();
        cmd.Connection = cn;
        cmd.CommandType = CommandType.Text;


        str = "update TblEmp set  Designation = '" + txt_designation.Text + "',Dept = '" + txt_department.Text + "',Salary = '" + txt_salary.Text + "' where EmpNo = " + txt_emp_id.Text + "";
        cmd.CommandText = str;

        int i = cmd.ExecuteNonQuery();

        if (i > 0)
        {
            Response.Write("<script>alert('Employee Update Successfully..');</script>");
        }
        else
        {
            Response.Write("<script>alert('Please Enter Correct Credential');</script>");
        }
        cmd.Dispose();
        cn.Close();
        clear();
        show();
        cn.Dispose();
    }
}