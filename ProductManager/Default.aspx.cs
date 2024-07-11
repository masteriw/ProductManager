using System;
using System.Linq;
using ProductManager.Models;

namespace ProductManager
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindProductGrid();
            }
        }

        private void BindProductGrid()
        {
            using (var context = new DbContext()) 
            {
                var products = context.Products.ToList();
                GridViewProducts.DataSource = products;
                GridViewProducts.DataBind();
            }
        }

        protected void btnAddProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddProduct.aspx");
        }
    }
}
