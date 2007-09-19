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
using Bll.SystemManage;

// 角色信息页面
public partial class admin_RoleInfo : System.Web.UI.Page
{
	public Role CurrentRole
	{
		get 
		{
			if (this.ViewState["role"] != null)
			{
				return ViewState["role"] as Role;
			}
			else
			{
				Role role = new Role();
				ViewState["role"] = role;
				return role;
			}
		}
		set
		{
			ViewState["role"] = value;
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
		}
    }

	protected void btnReturn_Click(object sender, EventArgs e)
	{
		this.Response.Redirect("RoleList.aspx");
	}

	protected void btnSave_Click(object sender, EventArgs e)
	{
		if (this.IsValid)
		{
			CurrentRole.RoleName = 角色名.Text;
			CurrentRole.Comment = 说明.Text;
			CurrentRole.Save();

			this.Response.Redirect("RoleList.aspx");
		}
	}

	protected void Validator_RoleName_ServerValidate(object source, ServerValidateEventArgs args)
	{
		// 检查角色名是否存在
		if (RoleManager.RoleExists(CurrentRole.RoleId, args.Value))
		{
			args.IsValid = false;
		}
	}
}
