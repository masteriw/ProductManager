using System;
using System.Linq;
using System.Web.UI;
using ProductManager.Models;

namespace ProductManager.Views
{
    public partial class EditDeleteProduct : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && Page.RouteData.Values["id"] != null &&
                Int32.TryParse(Page.RouteData.Values["id"].ToString(), out int productId) &&
                productId > 0)
            {
                LoadProduct(productId);
            }
        }

        protected override void OnPreRender(EventArgs e)
        {
            hiddenTxtField.Value = txtPrice.Text;
            base.OnPreRender(e);
        }

        private void LoadProduct(int productId)
        {
            using (var context = new DbContext())
            {
                var product = context.Products.Find(productId);
                if (product != null)
                {
                    ViewState["OriginalPrice"] = product.Price;

                    txtProductId.Text = productId.ToString();
                    txtProductName.Text = product.ProductName;
                    txtPrice.Text = product.Price.ToString();
                    hiddenTxtField.Value = product.Price.ToString(); // Atualizar hidden field com valor inicial
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
            if (Int32.TryParse(txtProductId.Text, out int productId))
            {
                LoadProduct(productId);
            }
            else
            {
                lblResult.Text = "Digite um ID de produto válido (numérico).";
                lblResult.Visible = true;
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtProductId.Text, out int productId))
            {
                using (var context = new DbContext())
                {
                    var product = context.Products.Find(productId);
                    if (product != null)
                    {
                        try
                        {
                            decimal originalPrice = (decimal)ViewState["OriginalPrice"];
                            decimal newPrice = Convert.ToDecimal(hiddenTxtField.Value);

                            if (originalPrice != newPrice)
                            {
                                product.Price = newPrice;
                            }

                            product.ProductName = txtProductName.Text;
                            context.SaveChanges();
                            lblResult.Text = "Produto atualizado com sucesso!";
                            lblResult.Visible = true;
                        }
                        catch (FormatException)
                        {
                            lblResult.Text = "Erro ao editar produto: Formato inválido para o preço. Verifique se o preço está no formato correto.";
                            lblResult.Visible = true;
                        }
                        catch (Exception ex)
                        {
                            lblResult.Text = "Erro ao editar produto: " + ex.Message;
                            lblResult.Visible = true;
                        }
                    }
                    else
                    {
                        lblResult.Text = "Produto não encontrado.";
                        lblResult.Visible = true;
                    }
                }
            }
            else
            {
                lblResult.Text = "Digite um ID de produto válido (numérico).";
                lblResult.Visible = true;
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtProductId.Text, out int productId))
            {
                using (var context = new DbContext())
                {
                    var product = context.Products.Find(productId);
                    if (product != null)
                    {
                        try
                        {
                            context.Products.Remove(product);
                            context.SaveChanges();
                            lblResult.Text = "Produto deletado com sucesso!";
                            lblResult.Visible = true;
                        }
                        catch (Exception ex)
                        {
                            lblResult.Text = "Erro ao deletar produto: " + ex.Message;
                            lblResult.Visible = true;
                        }
                    }
                    else
                    {
                        lblResult.Text = "Produto não encontrado.";
                        lblResult.Visible = true;
                    }
                }
            }
            else
            {
                lblResult.Text = "Digite um ID de produto válido (numérico).";
                lblResult.Visible = true;
            }
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Default.aspx");
        }
    }
}
