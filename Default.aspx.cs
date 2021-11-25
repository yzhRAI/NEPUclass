protected void Page_Load(object sender,EventArgs e)
{
    if(tbName.Text=="fff"&&tbPassword.Text=="fff")
    {
        Session["username"]=tbName.Text;
        Session["logintime"]=DateTime.Now;
        Response.Redirect("~/Table.aspx");
    }
    else{
        Response.Write("<script>alert('Your USERNAME or PASSWORD is wrong!!!')</script>");
    }
}
