using QuarzoDataAccess;
using System;

namespace Quarzo_Web_App
{
    public partial class CreateCategory : System.Web.UI.Page
    {
        private CategoryAccess CategoryAccess = new CategoryAccess();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void CreateNewCategory(object sender, EventArgs e)
        {
            var description = TextBoxDescription.Text;
            var active = CheckBoxActivo.Checked;
            if (!string.IsNullOrEmpty(description))
            {
                CategoryAccess.CreateCategory(description, active);
                Response.Redirect("Category.aspx");
            }
        }
    }
}