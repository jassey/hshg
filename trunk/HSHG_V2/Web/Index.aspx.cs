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

using Hshg.Bll.SystemManage;
using Hshg.Core.Utility;

public partial class _Index : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{

	}
	protected void btnLogin_Click(object sender, EventArgs e)
	{
		string info = "";

		if (UserManager.Login(txtUserName.Text, txtPassword.Text, out info))
		{
			Response.Redirect("~/member/member_index.aspx", true);
		}
		else
		{
			Response.Write(ClientMessage.ShowMsgBox(info));
		}

	}
}
