using System;
using System.Collections.Generic;
using System.Text;

using Hshg.Bll.SystemManage;

namespace Bll.SystemManage
{
	public class RoleManager
	{
		/// <summary>
		/// ָ�����ƵĽ�ɫ�Ƿ����
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
		/// �����ƻ�ý�ɫ
		/// </summary>
		public static Role LoadByName(string roleName)
		{
			Role result = new Role();
			result.LoadByParam(Role.Columns.RoleName, roleName);
			return result;
		}
	}
}
