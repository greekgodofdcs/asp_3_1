using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
//using System.Windows.Forms;
using System.Configuration;
using System.Data;

public partial class update_stud : System.Web.UI.Page
{
    SqlDataAdapter da;
    DataSet ds;
    int index;
    String cstr;

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
        dr.BeginEdit();
        dr["Email"] = TextBox2.Text;
        dr["Mobile"] = TextBox1.Text;
        dr["Dob"] = Calendar1.SelectedDate.Date;
        dr.EndEdit();
        da.Update(ds, "TblStudent");
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

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        index = GridView1.SelectedIndex;
        TextBox2.Text = GridView1.SelectedRow.Cells[6].Text;
        TextBox1.Text = GridView1.SelectedRow.Cells[7].Text;
    }
}