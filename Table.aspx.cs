using System.Data;
using System.Data.SqlClient;

protected void Page_Load(object sender,EventArgs e)
{
    Response.Write("欢迎您："+Session["username"]);
    Response.Write("您登录的时间是："+Session["logintime"]);
    string connString="Data Source=.....";
    SqlConnection conn = new SqlConnection(connString);
    string mysql="select * from Info";
    SqlDataAdapter myadapter = new SqlDataAdapter(mysql,conn);
    DataSet ds = new DataSet();
    myadapter.Fill(ds,"Info");
    GridView1.DataSource = ds.Tables["Info"];
    GridView1.DataBind();
}
protected void xyz(object sender,GridViewCommandEventArgs e)
{
    int x=Convert.ToInt16(e.CommandArgument);
    Response.Wrte(GridView1.Rows[x].Cells[2].Text);
}
