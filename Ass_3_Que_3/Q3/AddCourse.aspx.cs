using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddCourse : System.Web.UI.Page
{
    SqlConnection con;
    SqlDataAdapter da;
    DataSet ds;

    SqlCommand cmd;

    protected void Page_Load(object sender, EventArgs e)
    {
        con =new SqlConnection( ConfigurationManager.ConnectionStrings["DBStudentCon"].ConnectionString);

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (txtClass.Text != " ")
        {
            cmd = new SqlCommand();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Course(course_name)  VALUES ('" + txtClass.Text + "')";
            int i = cmd.ExecuteNonQuery();
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

            txtClass.Text = " ";
        }
        else
        {
            lblmsg.Text = "Please Enter Class Name";
            lblmsg.CssClass = "text-danger";
        }
        
        //da = new SqlDataAdapter("Select * from Course", con);
        //ds = new DataSet();
        //da.Fill(ds);
        //int i = 0;
        //DataRow dr = ds.Tables[0].NewRow();
        //dr[0] = i;
        //dr[2] = txtClass.Text.ToString();

        //ds.Tables[0].Rows.Add(dr);

        //SqlCommandBuilder sqlcb = new SqlCommandBuilder(da);

        //da.UpdateCommand = sqlcb.GetUpdateCommand();

        //da.Update(ds);
        //da.Dispose();
        //ds.Dispose();
        //i = i + 1;
    }
}