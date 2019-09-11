using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace BookLibrary
{
    public partial class SendMail : System.Web.UI.Page
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Victor\source\repos\BookLibrary\BookLibrary\App_Data\Books.mdf;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}