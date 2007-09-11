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


public partial class admin_RoleInfo : System.Web.UI.Page
{
	public Role CurrentRole
	{
		get 
		{
			if (this.Session["role"] != null)
			{
				return Session["role"] as Role;
			}
			else
			{
				Role role = new Role();
				Session["role"] = role;
				return role;
			}
		}
		set
		{
			Session["role"] = value;
		}
	}

    protected void Page_Load(object sender, EventArgs e)
    {
		if (!IsPostBack)
		{
			if (Request["id"] != null)
			{
				CurrentRole = Role.FetchByID(Request["id"]);
				this.角色名.Text = CurrentRole.RoleName;
				this.说明.Text = CurrentRole.Comment;
			}
			else
			{
				CurrentRole = new Role();
			}
		}
    }
	protected void btnReturn_Click(object sender, EventArgs e)
	{
		this.Response.Redirect("RoleList.aspx");
	}

	protected void btnSave_Click(object sender, EventArgs e)
	{
		string s = this.角色名.Text;

		if (Role.CheckExists(CurrentRole.RoleId, s))
		{
			lblInfo.Visible = true;
			lblInfo.Text = "该角色名已存在!";
			return;
		}

		CurrentRole.RoleName = 角色名.Text;
		CurrentRole.Comment = 说明.Text;
		CurrentRole.Save();

		this.Response.Redirect("RoleList.aspx");
	}

	protected void Button1_Click(object sender, EventArgs e)
	{

	}

}
