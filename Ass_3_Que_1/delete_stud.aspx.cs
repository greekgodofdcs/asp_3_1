using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class delete_stud : System.Web.UI.Page
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
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DataRow dr = ds.Tables[0].Rows[index];
        //ds.Tables[0].Rows.Remove(dr);
        dr.Delete();
        da.Update(ds, "Student");
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();
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

    protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
    {
        index = GridView1.SelectedIndex;
        TextBox1.Text = GridView1.SelectedRow.Cells[2].Text;
        TextBox2.Text = GridView1.SelectedRow.Cells[5].Text;
    }
}