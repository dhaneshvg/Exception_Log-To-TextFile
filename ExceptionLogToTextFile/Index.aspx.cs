using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ExceptionLogToTextFile
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml(Server.MapPath("~/abcd.xml"));
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            catch(Exception ex)
            {
                ExceptionLogging.SendErrorToText(ex);
                Label1.Text="Some Technical Error occured, Please Visit after sometime";
            }
        }
    }
}