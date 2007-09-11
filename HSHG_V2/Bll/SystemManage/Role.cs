using System; 
using System.Text; 
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration; 
using System.Xml; 
using System.Xml.Serialization;
using SubSonic; 
using SubSonic.Utilities;

namespace Hshg.Bll.SystemManage
{

	public partial class Role : ActiveRecord<Role>
	{
		public static Role LoadByName(string roleName)
		{
			Role result = new Role();
			result.LoadByParam(Role.Columns.RoleName, roleName);
			return result;
		}

		public static bool CheckExists(Guid roleId, string roleName)
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
	}
}