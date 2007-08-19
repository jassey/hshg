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

public partial class Member_member_index : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		if (this.User.Identity.IsAuthenticated)
		{
			User user = new User();
			user.LoadByParam("UserName", this.User.Identity.Name);
			this.lblUserName.Text = user.UserName;
			this.lblLastLoginDate.Text = user.LastLoginDate.Value.ToString("yyyy-mm-dd");
		}
		else
		{
			Response.Redirect("~/Index.aspx");
		}

	}
	protected void btnLoginOut_Click(object sender, EventArgs e)
	{
		FormsAuthentication.SignOut();
		Response.Redirect("~/Index.aspx");
	}
}
