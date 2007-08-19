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

namespace Bll.SystemManage
{
	public partial class User : ActiveRecord<User>
	{
		public static User LoadByName(string userName)
		{
			User result = new User();
			result.LoadByParam(User.Columns.UserName, userName);
			return result;
		}
	}

}

