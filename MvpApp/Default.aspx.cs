using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MvpApp
{
    public partial class _Default : System.Web.UI.Page, IView
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region IView Members

        public string Label
        {
            get
            {
                return Label1.Text;
            }
            set
            {
                Label1.Text = value;
            }
        }

        public string TextBox
        {
            get
            {
                return TextBox1.Text;
            }
            set
            {
                TextBox1.Text = value;
            }
        }

        #endregion

        protected void Button1_Click(object sender, EventArgs e)
        {
            Presenter p = new Presenter(this, new MvpApp.Model());
            p.BindModalView();
        }
    }
}