using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Security;

using SubSonic;

namespace Hshg.Bll.SystemManage
{
	public class UserManager
	{
		public static bool Login(string userName, string password, out string errorInfo)
		{
			errorInfo = "";
			User user = new User();
			user.LoadByParam(User.Columns.UserName, userName);
			if (user.IsLoaded)
			{
				if (user.Password == password)
				{
					FormsAuthentication.SetAuthCookie(userName, true);
					return true;
				}
				else
				{
					errorInfo = "������û��������!";
					return false;
				}
			}
			else
			{
				errorInfo = "������û��������!";
				return false;
			}
		}

		public static void SaveRoleMap(Guid varUserId, System.Web.UI.WebControls.ListItemCollection itemList)
		{
			QueryCommandCollection coll = new SubSonic.QueryCommandCollection();
			//delete out the existing
			QueryCommand cmdDel = new QueryCommand("DELETE FROM UserInRole WHERE UserId=@UserId", User.Schema.Provider.Name);
			cmdDel.AddParameter("@UserId", varUserId.ToString());
			coll.Add(cmdDel);
			DataService.ExecuteTransaction(coll);
			foreach (System.Web.UI.WebControls.ListItem l in itemList)
			{
				if (l.Selected)
				{
					UserInRole varUserInRole = new UserInRole();
					varUserInRole.SetColumnValue("UserId", varUserId);
					varUserInRole.SetColumnValue("RoleId", new Guid(l.Value));
					varUserInRole.Save();
				}
			}

		}
	}
}
