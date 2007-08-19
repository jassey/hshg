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

public partial class member_registerinfo : System.Web.UI.Page
{
	private User _User = new User();
	protected void Page_Load(object sender, EventArgs e)
	{

	}

	protected override void OnInit(EventArgs e)
	{
		base.OnInit(e);

		mgrUser.LoadValidate(typeof(User));
	}

	protected void btnOk_Click(object sender, EventArgs e)
	{
		this.mgrUser.PageToBizObject(_User);
		_User.UserId = Guid.NewGuid();
		_User.CreateDate = DateTime.Now;
		_User.EmailActiveCode = Guid.NewGuid().ToString("N");
		_User.IsLocked = false;
		_User.IsMailValidate = false;
		_User.LastLoginDate = DateTime.Now;
		_User.Save();

		FormsAuthentication.SetAuthCookie(_User.UserName, false);

		Response.Redirect("~/member/member_Index.aspx");
	}
}
