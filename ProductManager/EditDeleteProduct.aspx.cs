using System;
using System.Linq;
using System.Web.UI;
using ProductManager.Models; 

namespace ProductManager
{
    public partial class EditDeleteProduct : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.RouteData.Values["id"] != null &&
                Int32.TryParse(Page.RouteData.Values["id"].ToString(), out int productId) &&
                productId > 0)
            {
                LoadProduct(productId);
            }
        }
        private void LoadProduct(int productId)
        {
            using (var context = new DbContext()) 
            {
                var product = context.Products.Find(productId);
                if (product != null)
                {
                    txtProductId.Text = productId.ToString();
                    txtProductName.Text = product.ProductName;
                    txtPrice.Text = product.Price.ToString();
                    lblResult.Visible = false;
                }
                else
                {
                    lblResult.Text = "Produto não encontrado.";
                    lblResult.Visible = true;
                    txtPrice.Text = "";
                    txtProductId.Text = "";
                    txtProductName.Text = "";
                }
            }
        }

        protected void btnLoadProduct_Click(object sender, EventArgs e)
        {
            Int32.TryParse(txtProductId.Text, out int productId);
            LoadProduct(productId);
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Int32.TryParse(txtProductId.Text, out int productId);
            using (var context = new DbContext()) 
            {
                var product = context.Products.Find(productId);
                if (product != null)
                {
                    product.ProductName = txtProductName.Text;
                    product.Price = Convert.ToDecimal(txtPrice.Text);
                    context.SaveChanges();
                    lblResult.Text = "Produto atualizado com sucesso!";
                    lblResult.Visible = true;
                }
                else
                {
                    lblResult.Text = "Favor carregar um produto válido.";
                    lblResult.Visible = true;
                }
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int productId = Convert.ToInt32(txtProductId.Text);
            using (var context = new DbContext()) 
            {
                var product = context.Products.Find(productId);
                if (product != null)
                {
                    context.Products.Remove(product);
                    context.SaveChanges();
                    lblResult.Text = "Produto deletado com sucesso!";
                    lblResult.Visible = true;
                }
            }
        }
        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}
