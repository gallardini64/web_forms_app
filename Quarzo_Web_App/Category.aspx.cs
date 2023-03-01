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
    public partial class Categories : Page
    {
        private CategoryAccess CategoryAccess = new CategoryAccess();
        private List<Category> categories;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ChargeDropDownList();
            }
        }

        private void ChargeDropDownList()
        {
            DDLCategorias.DataSource = CategoryAccess.GetCategories();
            DDLCategorias.DataTextField = "Description";
            DDLCategorias.DataValueField = "Id";
            DDLCategorias.DataBind();
            DDLCategorias.Items.Insert(0, "Select a category");
        }

        public void IndexChange(object sender, EventArgs e)
        {
            int categoryId;
            if (int.TryParse(DDLCategorias.SelectedValue, out categoryId))
            {
                categories = CategoryAccess.GetCategories();
                var category = categories.Where(x => x.Id == categoryId).FirstOrDefault();
                TextBoxDescription.Text = category.Description;
                CheckBoxActive.Checked = category.Activo;
            }
            else
            {
                TextBoxDescription.Text = string.Empty;
                CheckBoxActive.Checked = false;
            }
        }

        public void ModifyCategory(object sender, EventArgs e)
        {
            int categoryId;
            if (int.TryParse(DDLCategorias.SelectedValue, out categoryId))
            {
                var description = TextBoxDescription.Text;
                var active = CheckBoxActive.Checked;
                CategoryAccess.UpdateCategory(categoryId, description, active);
                ChargeDropDownList();
            }
            TextBoxDescription.Text = string.Empty;
            CheckBoxActive.Checked = false;

        }
    }
}