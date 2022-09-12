using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class insert_stud : System.Web.UI.Page
{
    SqlDataAdapter da;
    DataSet ds;
    int index;

    string cstr;

    protected void Page_Load(object sender, EventArgs e)
    {
        cstr = ConfigurationManager.ConnectionStrings["Student_Managment_SystemConnectionString"].ConnectionString;
        if (!IsPostBack)
        {
            load_grid();
        }
        SqlCommand cmd = new SqlCommand("SELECT * FROM TblCourse");
        da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        DropDownList1.DataSource = dt;
        DropDownList1.DataBind();
        DropDownList1.DataTextField = "co_name";
        DropDownList1.DataBind();
        loaddropdown2();
        load_grid();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DataRow row = ds.Tables[0].NewRow();
        row[0] = TextBox6.Text;
        row[1] = TextBox2.Text;
        row[2] = TextBox3.Text;
        row[3] = DropDownList2.SelectedValue;
        row[4] = DropDownList1.SelectedItem.Value;
        row[5] = TextBox4.Text;
        row[6] = TextBox5.Text;
        row[7] = Calendar1.SelectedDate.Date;
        ds.Tables[0].Rows.Add(row);
        da.Update(ds, "TblStudent");
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();
    }

    void loaddropdown2()
    {
        SqlCommand cmd = new SqlCommand("SELECT * FROM TblClass");
        da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        DropDownList2.DataSource = dt;
        DropDownList2.DataBind();
        DropDownList2.DataTextField = "cl_name";
        DropDownList2.DataBind();
    }

    void load_grid()
    {
        da = new SqlDataAdapter("SELECT * FROM TblStudent", cstr);
        ds = new DataSet();
        da.Fill(ds, "Student");
        SqlCommandBuilder cbldr = new SqlCommandBuilder(da);
        GridView1.DataSource = ds.Tables["Student"];
        GridView1.DataBind();
    }
}