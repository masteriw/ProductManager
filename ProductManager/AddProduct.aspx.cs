using System;
using System.Linq;
using ProductManager.Models;
using System.Web.UI;

namespace ProductManager
{
    public partial class AddProduct : Page
    {
        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtProductName.Text))
            {
                try
                {
                    using (var context = new DbContext())
                    {
                        var product = new Product
                        {
                            ProductName = txtProductName.Text,
                            Price = Convert.ToDecimal(txtPrice.Text)
                        };

                        context.Products.Add(product);
                        context.SaveChanges();

                        lblResult.Text = "Produto adicionado com sucesso!";
                        lblResult.Visible = true;
                    }
                }
                catch (FormatException ex)
                {
                    lblResult.Text = "Erro ao adicionar produto: Formato inválido para o preço. Verifique se o preço está no formato correto.";
                    lblResult.Visible = true;
                }
                catch (Exception ex)
                {
                    lblResult.Text = "Erro ao adicionar produto: " + ex.Message;
                    lblResult.Visible = true;
                }
            }
            else
            {
                lblResult.Text = "Erro ao adicionar produto: O nome do produto deve conter pelo menos 1 letra";
                lblResult.Visible = true;
            }
        }
        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}
