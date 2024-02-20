using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Drawing;

namespace emp_details
{
    public partial class details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[2] { new DataColumn("Item"), new DataColumn("Quantity") });
                dt.Rows.Add("Top", 200);
                dt.Rows.Add("Gown", 1100);
                dt.Rows.Add("Midi", 500);
                dt.Rows.Add("Purse", 450);
                dt.Rows.Add("Truffle Cake", 350);
                dt.Rows.Add("Pizza", 99);
                dt.Rows.Add("Pasta", 140);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }
        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                TableCell cell = e.Row.Cells[1];
                int quantity = int.Parse(cell.Text);
                if (quantity == 0)
                {
                    cell.BackColor = Color.Red;
                }
                if (quantity > 0 && quantity <= 300)
                {
                    cell.BackColor = Color.Yellow;
                }
                if (quantity > 400 && quantity <= 1000)
                {
                    cell.BackColor = Color.Orange;
                }
            }
        }
    }
    
}