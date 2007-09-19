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

using Hshg.Bll;
using Hshg.Bll.SystemManage;
using System.Collections.Generic;

public partial class Admin_UserInfo : System.Web.UI.Page
{
	public User CurrentUser
	{
		get 
		{
			if (this.ViewState["user"] != null)
			{
				return ViewState["user"] as User;
			}
			else
			{
				User user = new User();
				ViewState["user"] = user;
				return user;
			}
		}
		set
		{
			ViewState["user"] = value;
		}
	}
	
	protected override void OnInit(EventArgs e)
	{
		base.OnInit(e);

		BindManager1.LoadValidate(typeof(User));
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		if (!IsPostBack)
		{
			if (Request["id"] != null)
			{
				CurrentUser = Hshg.Bll.SystemManage.User.FetchByID(Request["id"]);
			}

			chkRoleList.DataTextField = "RoleName";
			chkRoleList.DataValueField = "RoleID";
			chkRoleList.DataSource = Role.FetchAll();
			chkRoleList.DataBind();

			RoleCollection col = CurrentUser.GetRoleCollection();

			foreach (ListItem item in chkRoleList.Items)
			{
				foreach (Role role in col)
				{
					if (role.RoleId.ToString() == item.Value)
					{
						item.Selected = true;
						break;
					}
				}
			}

			this.BindManager1.BizObjectToPage(CurrentUser);
		}

	}

	protected void btnSave_Click(object sender, EventArgs e)
	{
		BindManager1.PageToBizObject(CurrentUser);
		CurrentUser.Save();
		UserManager.SaveRoleMap(CurrentUser.UserId, chkRoleList.Items);
	}

	protected void btnReturn_Click(object sender, EventArgs e)
	{

	}
}
