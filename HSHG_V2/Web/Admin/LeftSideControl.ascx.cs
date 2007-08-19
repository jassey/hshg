using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using Bll.SystemManage;

public partial class admin_LeftSideControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
		if (this.Page.User.Identity.IsAuthenticated)
		{
			User user = new User();
			user.LoadByParam("UserName", this.Page.User.Identity.Name);
			this.lblUserName.Text = user.UserName;
			this.lblLastLoginDate.Text = user.LastLoginDate.Value.ToString("yyyy-mm-dd");
		}
    }
}
