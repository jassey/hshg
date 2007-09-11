using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Security;

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
					errorInfo = "错误的用户名或口令!";
					return false;
				}
			}
			else
			{
				errorInfo = "错误的用户名或口令!";
				return false;
			}
		}
	}
}
