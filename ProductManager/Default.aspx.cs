using System;
using System.Linq;
using System.Web.UI;
using ProductManager.Models;

namespace ProductManager
{
    public partial class Default : Page
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
