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

    public partial class RoleController
    {

		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		[DataObjectMethod(DataObjectMethodType.Update, true)]
		public void Update(string RoleName, string Comment, Guid original_RoleId)
		{
			Role item = new Role();

			item.RoleId = original_RoleId;

			item.RoleName = RoleName;

			item.Comment = Comment;

			item.MarkOld();
			item.Save(UserName);
		}

    }

}

