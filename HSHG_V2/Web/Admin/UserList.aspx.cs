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

using SubSonic;

public partial class admin_RoleList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

	protected void btnNew_Click(object sender, EventArgs e)
	{
		this.Response.Redirect("RoleInfo.aspx");
	}

	protected void btnDelete_Click(object sender, EventArgs e)
	{
		ArrayList list = new ArrayList();
		for(int i=0; i < gridMain.Rows.Count; i++)
		{
			GridViewRow item = gridMain.Rows[i];
			CheckBox chk = (CheckBox)item.FindControl("chkSelect");
			if (chk.Checked)
			{
				list.Add(gridMain.DataKeys[i].Value.ToString());
			}
		}

		if (list.Count > 0)
		{
			Query q = Role.CreateQuery();
			q.IN(Role.Columns.RoleId, list);
			q.QueryType = QueryType.Delete;
			q.Execute();
			gridMain.DataBind();
		}
	}

	protected void chkSelectAll_CheckedChanged(object sender, EventArgs e)
	{
		bool selected = (sender as CheckBox).Checked;
		foreach (GridViewRow item in gridMain.Rows)
		{
			CheckBox chk = (CheckBox)item.FindControl("chkSelect");
			chk.Checked = selected;
		}
	}
}
