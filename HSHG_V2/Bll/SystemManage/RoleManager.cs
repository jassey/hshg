using System;
using System.Collections.Generic;
using System.Text;

using Hshg.Bll.SystemManage;

namespace Bll.SystemManage
{
	public class RoleManager
	{
		/// <summary>
		/// 指定名称的角色是否存在
		/// </summary>
		public static bool RoleExists(Guid roleId, string roleName)
		{
			Role role = new Role();
			role.LoadByParam(Role.Columns.RoleName, roleName);

			if (role.IsLoaded && role.RoleId != roleId)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 按名称获得角色
		/// </summary>
		public static Role LoadByName(string roleName)
		{
			Role result = new Role();
			result.LoadByParam(Role.Columns.RoleName, roleName);
			return result;
		}
	}
}
