using Quarzo_Web_App.Models;
using QuarzoDataAccess;
using QuarzoModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quarzo_Web_App
{
    public partial class _Default : Page
    {
        private ProductAccess productAccess = new ProductAccess();
        private CategoryAccess CategoryAccess = new CategoryAccess();
        private List<Category> categories;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                categories = CategoryAccess.GetCategories().Where(x => x.Activo).ToList();
                DDLCategorias.DataSource = categories;
                DDLCategorias.DataTextField = "Description";
                DDLCategorias.DataValueField = "Id";
                DDLCategorias.DataBind();
                DDLCategorias.Items.Insert(0, "Select a category");
            }
        }

        protected void DDLCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            int categoryId;
            if(int.TryParse(DDLCategorias.SelectedValue,out categoryId))
            {
                var products = productAccess.GetProductsByCategory(categoryId);
                GridProductos.DataSource = toProductsDto(products, DDLCategorias.SelectedItem.ToString());
                GridProductos.DataBind();
            }
            else
            {
                GridProductos.DataSource = null;
                GridProductos.DataBind();
            }
        }

        private List<ProductDTO> toProductsDto(List<Product> products, string category)
        {
            return products.Select(p =>
            {
                return new ProductDTO() { Id = p.Id, Name = p.Name, Price = p.Price, Category = category };
            }).ToList();
        }
    }
}