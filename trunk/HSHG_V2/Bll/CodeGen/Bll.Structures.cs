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
	#region Tables Struct
	public partial struct Tables
	{
		
		public static string Role = @"Role";
        
		public static string User = @"User";
        
		public static string UserInfo = @"UserInfo";
        
		public static string UserInRole = @"UserInRole";
        
	}

	#endregion
    #region View Struct
    public partial struct Views 
    {
		
		public static string Sysconstraint = @"sysconstraints";
        
		public static string Syssegment = @"syssegments";
        
    }

    #endregion
}

#region Databases
public partial struct Databases 
{
	
	public static string Bll = @"Bll";
    
}

#endregion

